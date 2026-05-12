using UCM_Tools.CAN_Conn;
using UCM_Tools.Config;
using LogProc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Kitware.VTK.vtkMultiProcessController;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_TCP : IConn
    {
        TcpClient tcpClient = null;
        Thread threadRecv = null;
        private bool _connected = false;

        private readonly int _connectTimeOutMs = 2000;//默认2000ms 连接超时时间
        private readonly int _reconnectIntervalMs = 3000;//默认3000 重连间隔
        private readonly int _maxReconnectCount = -1;//最大重连次数(-1代表无线重连)
        private int _currentReconnnectCount = 0;//当前重连次数
        private Timer _reconnectTimer;//重连定时器
        private Timer _heartbeatTimer;//心跳检测定时器
        public override bool IsConnected => _connected;

        public override void CloseDevice()
        {
            //StopReconnect();
            //StopHeartbeatCheck();
            _connected = false;
            if (threadRecv != null)
            {
                threadRecv?.Join();
            }
            threadRecv = null;
            //关闭设备
            if (tcpClient != null)
                tcpClient.Close();
            tcpClient = null;
            //OnConnectStatusChanged?.Invoke(false,"已手动断开连接");
        }

        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                CloseDevice();//关闭现有连接，避免重连
                if (await ConnectedQuickly(connParams.IP, connParams.Port, _connectTimeOutMs))
                {
                    _connected = true;
                    threadRecv = new Thread(RecvTCPData);
                    threadRecv.IsBackground = true;
                    threadRecv.Start();
                    return true;
                }
                //Console.WriteLine("超时");
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_TCP OpenDevice() Ex\r\n{ex.ToString()}");
            }
            return false;
        }

        public async Task<bool> ConnectedQuickly(string ip, int port, int timeoutMs = 2000)
        {
            if (string.IsNullOrWhiteSpace(ip) || port < 1 || port > 65535 || timeoutMs <= 0)
                return false;
            tcpClient = new TcpClient();
            try
            {
                var connectedTask = tcpClient.ConnectAsync(ip, port);
                var timeoutTask = Task.Delay(timeoutMs);
                if (await Task.WhenAny(connectedTask, timeoutTask) == timeoutTask)
                {
                    //StartReconnect();
                    //OnConnectStatusChanged?.Invoke(false,"连接超时");
                    return false;
                }
                await connectedTask;
                _currentReconnnectCount = 0;//重置计数器
                //OnConnectStatusChanged?.Invoke(false,"连接成功");
                //StartHeartbeatCheck();//启动心跳检测
                return true;
            }
            catch (SocketException ex)
            {
                //string errorMsg = $"连接失败：{ex.Message}(错误码：{ex.ErrorCode})";
                //OnErrorOccurred?.Invoke( errorMsg);
                //OnConnectStatusChanged?.Invoke(false,errorMsg);
                //StartReconnect();
                Log.Error($"ConnectedQuickly({ip},{port},{timeoutMs}) Ex\r\n{ex.ToString()}");
                return false;
            }
            catch (Exception ex)
            {
                //string errorMsg = $"连接失败：{ex.Message}";
                //OnErrorOccurred?.Invoke( errorMsg);
                //OnConnectStatusChanged?.Invoke(false,errorMsg);
                //StartReconnect();
                Log.Error($"ConnectedQuickly({ip},{port},{timeoutMs}) Ex\r\n{ex.ToString()}");
                return false;
            }
        }


        public override bool SendCmd(ConnData data)
        {
            if (data == null || data.Datas == null && !_connected || tcpClient == null || tcpClient.Client == null || !tcpClient.Client.Connected)
                return false;
            return tcpClient.Client.Send(data.Datas.ToArray()) > 0;
        }

        private void RecvTCPData()
        {

            while (_connected)
            {
                try
                {
                    int? num = tcpClient.Available;
                    if (tcpClient == null || tcpClient.Client == null || !tcpClient.Client.Connected || num == null || num <= 0)
                    {
                        Thread.Sleep(1);
                        continue;
                    }
                    byte[] recvBytes = new byte[num.Value];
                    tcpClient.Client.Receive(recvBytes, num.Value, SocketFlags.None);
                    //Console.WriteLine($"通讯类：{BitConverter.ToString(recvBytes)}");
                    if(OnRecvConnDataEvent!=null)
                        OnRecvConnDataEvent(new ConnData(recvBytes));
                }
                catch (Exception ex)
                {
                    Log.Error($"RecvTCPData() Ex\r\n{ex.ToString()}");
                }
            }
        }

        public bool GetConnected()
        {
            if (tcpClient == null || !tcpClient.Connected)
                return false;
            try
            {
                var socket = tcpClient.Client;
                bool isDisconnected = socket.Poll(100, SelectMode.SelectRead) && socket.Available == 0;
                if (isDisconnected)
                    return false;
                socket.Send(new byte[0]); //发送空数据触发连接检测
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void StartReconnect()
        {
            StopReconnect();
            if (_maxReconnectCount != -1 && _currentReconnnectCount >= _maxReconnectCount)
            {
                //OnConnectStatusChanged?.Invoke(false,"已达到最大重连次数，停止重连");
                return;
            }
            _reconnectTimer = new Timer(async (state) =>
            {
                _currentReconnnectCount++;
                //OnConnectStatusChanged?.Invoke(false,$"正在第{_currentReconnnectCount}次重连...");
                await OpenDevice();//重试连接
            }, null, _reconnectIntervalMs, Timeout.Infinite);
        }

        private void StopReconnect()
        {
            _reconnectTimer?.Dispose();
            _reconnectTimer = null;
        }

        private void StartHeartbeatCheck()
        {
            StoptHeartbeatCheck();
            _heartbeatTimer = new Timer((state) =>
            {
                if (!GetConnected())
                {
                    //OnConnectStatusChanged?.Invoke(false,$"连接已断开");
                    StartReconnect();//断线重连
                }
            }, null, 0, 5000);//5秒检测一次
        }
        private void StoptHeartbeatCheck()
        {
            _heartbeatTimer?.Dispose();
            _heartbeatTimer = null;
        }
    }
}
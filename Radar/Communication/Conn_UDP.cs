using LogProc;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using UCM_Tools.Models;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_UDP : IConn
    {
        UdpClient udpClient = null;
        Thread threadRecv = null;
        private bool _connected = false;

        private readonly int _reconnectIntervalMs = 3000;
        private readonly int _maxReconnectCount = -1;
        private int _currentReconnnectCount = 0;
        private Timer _reconnectTimer;
        private Timer _heartbeatTimer;
        private bool _isReconnecting = false;
        public override bool IsConnected => _connected;

        public override void CloseDevice()
        {
            StopReconnect();
            StopHeartbeatCheck();
            _connected = false;
            if (threadRecv != null)
            {
                threadRecv?.Join();
            }
            threadRecv = null;
            if (udpClient != null)
            {
                try { udpClient.Close(); } catch { }
                udpClient = null;
            }
            OnConnectStatusChanged?.Invoke(false, _isReconnecting ? ConnState.Reconneting : ConnState.Disconnected);
        }

        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                CloseDevice();
                udpClient = new UdpClient(0);
                _connected = true;
                _currentReconnnectCount = 0;
                _isReconnecting = false;
                StopReconnect();
                threadRecv = new Thread(RecvUDPData);
                threadRecv.IsBackground = true;
                threadRecv.Start();
                OnConnectStatusChanged?.Invoke(true, ConnState.Connected);
                StartHeartbeatCheck();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_UDP OpenDevice() Ex\r\n{ex.ToString()}");
                OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                StartReconnect();
            }
            return false;
        }

        public override bool SendCmd(ConnData data)
        {
            try
            {
                if (data == null || data.Datas == null || !_connected || udpClient == null)
                    return false;
                udpClient.Send(data.Datas.ToArray(), data.Datas.Count, connParams.IP, connParams.Port);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_UDP SendCmd() Ex\r\n{ex.ToString()}");
            }
            return false;
        }

        private void RecvUDPData()
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (_connected)
            {
                try
                {
                    if (udpClient == null || udpClient.Client == null)
                    {
                        Thread.Sleep(1);
                        continue;
                    }
                    if (udpClient.Available > 0)
                    {
                        byte[] recvBytes = udpClient.Receive(ref remoteEndPoint);
                        if (recvBytes != null && recvBytes.Length > 0 && OnRecvConnDataEvent != null)
                            OnRecvConnDataEvent(new ConnData(recvBytes));
                    }
                    else
                    {
                        Thread.Sleep(1);
                    }
                }
                catch (SocketException)
                {
                    _connected = false;
                    OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                    StartReconnect();
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error($"RecvUDPData() Ex\r\n{ex.ToString()}");
                }
            }
        }

        private bool GetConnected()
        {
            if (udpClient == null || udpClient.Client == null)
                return false;
            try
            {
                return udpClient.Client.IsBound;
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
                _isReconnecting = false;
                OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                return;
            }
            _isReconnecting = true;
            _reconnectTimer = new Timer(async (state) =>
            {
                _currentReconnnectCount++;
                OnConnectStatusChanged?.Invoke(false, ConnState.Reconneting);
                await OpenDevice();
            }, null, _reconnectIntervalMs, Timeout.Infinite);
        }

        private void StopReconnect()
        {
            _reconnectTimer?.Dispose();
            _reconnectTimer = null;
        }

        private void StartHeartbeatCheck()
        {
            StopHeartbeatCheck();
            _heartbeatTimer = new Timer((state) =>
            {
                if (!GetConnected())
                {
                    OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                    StartReconnect();
                }
            }, null, 0, 5000);
        }

        private void StopHeartbeatCheck()
        {
            _heartbeatTimer?.Dispose();
            _heartbeatTimer = null;
        }
    }
}

using LogProc;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UCM_Tools.Config;
using UCM_Tools.Models;
using static UCM_Tools.Tools.PubClass;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_COM :IConn
    {
        SerialPort _serial = null;

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
            if (_serial != null)
                _serial.Close();
            _serial = null;
            OnConnectStatusChanged?.Invoke(false, _isReconnecting ? ConnState.Reconnecting : ConnState.Disconnected);// "重连中..." : "已手动断开连接");
        }

        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                CloseDevice();
                _serial = new SerialPort()
                {
                    PortName = connParams.COM_No,
                    BaudRate = connParams.COM_Baud,
                    Parity = (Parity)Enum.Parse(typeof(Parity), connParams.COM_Parity),
                    DataBits = int.Parse(connParams.COM_DataBit),
                    StopBits = (StopBits)Enum.Parse(typeof(StopBits), connParams.COM_StopBit),
                };
                _serial.Open();
                _connected = true;
                _currentReconnnectCount = 0;
                _isReconnecting = false;
                StopReconnect();
                threadRecv = new Thread(RecvCOMData);
                threadRecv.IsBackground = true;
                threadRecv.Start();
                OnConnectStatusChanged?.Invoke(true, ConnState.Connected);
                StartHeartbeatCheck();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_COM OpenDevice() Ex\r\n{ex.ToString()}");
                OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                StartReconnect();
            }
            return false;
        }

        public override bool SendCmd(ConnData data)
        {
            try
            {
                if (data == null || data.Datas == null && !_connected || _serial == null || !_serial.IsOpen)
                    return false;
                _serial.Write(data.Datas.ToArray(), 0, data.Datas.Count);
                return true;
            }
            catch { }
            return false;
        }

        private void RecvCOMData()
        {
            while (_connected)
            {
                try
                {
                    int? num = _serial.BytesToRead;
                    if (_serial == null || !_serial.IsOpen || num == null || num <= 0)
                    {
                        Thread.Sleep(1);
                        continue;
                    }
                    byte[] recvBytes = new byte[num.Value];
                    _serial?.Read(recvBytes, 0, num.Value);
                    if (OnRecvConnDataEvent != null)
                        OnRecvConnDataEvent(new ConnData(recvBytes));
                }
                catch (InvalidOperationException)
                {
                    _connected = false;
                    OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                    StartReconnect();
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error($"RecvCOMData() Ex\r\n{ex.ToString()}");
                }
            }
        }
        private bool GetConnected()
        {
            return _serial != null && _serial.IsOpen;
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
                OnConnectStatusChanged?.Invoke(false, ConnState.Reconnecting);
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
            }, null, 0, 3000);
        }
        private void StopHeartbeatCheck()
        {
            _heartbeatTimer?.Dispose();
            _heartbeatTimer = null;
        }
    }
}

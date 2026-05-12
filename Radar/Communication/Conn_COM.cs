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
using static UCM_Tools.Tools.PubClass;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_COM :IConn
    {
        SerialPort _serial = null;

        Thread threadRecv = null;
        private bool _connected = false;

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
            if (_serial != null)
                _serial.Close();
            _serial = null;
            //OnConnectStatusChanged?.Invoke(false,"已手动断开连接");
        }

        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                CloseDevice();//关闭现有连接，避免重连
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
                threadRecv = new Thread(RecvCOMData);
                threadRecv.IsBackground = true;
                threadRecv.Start();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_COM OpenDevice() Ex\r\n{ex.ToString()}");
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
                    _serial?.Read(recvBytes,0, num.Value);
                    if (OnRecvConnDataEvent != null)
                        OnRecvConnDataEvent(new ConnData(recvBytes));
                }
                catch (Exception ex)
                {
                    Log.Error($"RecvCOMData() Ex\r\n{ex.ToString()}");
                }
            }
        }
    }
}

using LogProc;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UCM_Tools.CAN_Conn;
using UCM_Tools.Config;
using UCM_Tools.Models;
using UCM_Tools.Tools;
using ZLGCAN;
using static UCM_Tools.CAN_Conn.CAN_Function;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_CANFD : IConn
    {
        private bool _connected = false;
        public override bool IsConnected => _connected;

        private readonly int _reconnectIntervalMs = 3000;
        private readonly int _maxReconnectCount = -1;
        private int _currentReconnnectCount = 0;
        private Timer _reconnectTimer;
        private Timer _heartbeatTimer;
        private bool _isReconnecting = false;

        /// <summary>
        /// 接收线程
        /// </summary>
        recvdatathread recv_data_thread;

        public override void CloseDevice()
        {
            StopReconnect();
            StopHeartbeatCheck();
            _connected = false;
            if (recv_data_thread != null)
            {
                recv_data_thread.RecvCANData -= RecvData;
                recv_data_thread.RecvFDData -= RecvDataFD;
                recv_data_thread?.setStart(_connected);
            }
            recv_data_thread = null;
            CAN_Function.CloseCAN(connParams);
            OnConnectStatusChanged?.Invoke(false, _isReconnecting ? ConnState.Reconneting: ConnState.Disconnected);// "重连中..." : "已手动断开连接");
        }


        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                if (!CAN_Function.OpenCAN(connParams)) return false;
                if (!CAN_Function.InitCAN(connParams)) return false;
                if (!CAN_Function.StartCAN(connParams)) return false;
                _connected = true;
                _currentReconnnectCount = 0;
                _isReconnecting = false;
                StopReconnect();
                recv_data_thread = new recvdatathread();
                recv_data_thread.canFactory = connParams.CAN_Company;
                recv_data_thread.setChannelHandle(CAN_Function.GetChannel());
                recv_data_thread.setStart(_connected);
                recv_data_thread.RecvCANData += RecvData;
                recv_data_thread.RecvFDData += RecvDataFD;
                OnConnectStatusChanged?.Invoke(true, ConnState.Connected);
                StartHeartbeatCheck();
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Conn_CANFD OpenDevice() Ex\r\n{ex.ToString()}");
                OnConnectStatusChanged?.Invoke(false, ConnState.Disconnected);
                StartReconnect();
                return false;
            }
        }

        public override bool SendCmd(ConnData connData)
        {
            //canfd_frame canfd_Frame = CAN_Function.BytesConvertToCANFDFrame(bytes);
            if (connData == null || connData.Datas == null || !_connected || connParams==null)
                return false;
            ZLG_TYPE type = EnumCls.GetEnum<ZLG_TYPE>(connData.ConnType);
            return CAN_Function.WriteBytes(connParams.CAN_Company,type, connData.Datas.ToArray(), connData.FrameID);
        }
        public bool SendCmd(List<ConnData> connDatas)
        {
            if (connDatas == null && connDatas.Count <= 0 || !_connected || connParams == null)
                return false;
            List<byte[]> bytesList = new List<byte[]>();
            List<uint>frameIdList = new List<uint>();
            foreach (var connData in connDatas)
            {
                if (connData == null)
                    continue;
                frameIdList.Add(connData.FrameID);
                bytesList.Add(connData.Datas.ToArray());
            }
            ZLG_TYPE type = EnumCls.GetEnum<ZLG_TYPE>(connDatas[0].ConnType);
            return CAN_Function.WriteBytesMulti(connParams.CAN_Company, type, bytesList, frameIdList);
        }
        #region 接收数据
        private void RecvData(ZCAN_Receive_Data[] data_CAN, uint len)
        {
            //List<ConnData> connData = new List<ConnData>();
            foreach (var data in data_CAN)
            {
                if(OnRecvConnDataEvent!=null)
                    OnRecvConnDataEvent(new ConnData(data.frame));
            }
                //connData.Add(new ConnData(data.frame));
            //OnRecvConnDataEvent(connData);
        }

        private void RecvDataFD(ZCAN_ReceiveFD_Data[] data_CANFD, uint len)
        {
            //List<ConnData> connData = new List<ConnData>();
            foreach (var data in data_CANFD)
                if (OnRecvConnDataEvent != null)
                    OnRecvConnDataEvent(new ConnData(data.frame));
            //connData.Add(new ConnData(data.frame));
            //OnRecvConnDataEvent(connData);
        }

        #endregion 接收数据

        private bool GetConnected()
        {
            return _connected && recv_data_thread != null && CAN_Function.GetChannel() != IntPtr.Zero;
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
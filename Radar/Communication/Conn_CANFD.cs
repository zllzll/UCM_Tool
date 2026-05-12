using UCM_Tools.CAN_Conn;
using UCM_Tools.Config;
using UCM_Tools.Tools;
using LogProc;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZLGCAN;
using static UCM_Tools.CAN_Conn.CAN_Function;

namespace UCM_Tools.Radar.Communication
{
    public class Conn_CANFD : IConn
    {
        private bool _connected = false;
        public override bool IsConnected => _connected;

        /// <summary>
        /// 接收线程
        /// </summary>
        recvdatathread recv_data_thread;

        public override void CloseDevice()
        {
            _connected = false;
            if (recv_data_thread != null)
            {
                recv_data_thread.RecvCANData -= RecvData;
                recv_data_thread.RecvFDData -= RecvDataFD;
                recv_data_thread?.setStart(_connected);
            }
            recv_data_thread = null;
            //关闭设备
            CAN_Function.CloseCAN(connParams);
        }


        public override async Task<bool> OpenDevice()
        {
            try
            {
                if (connParams == null)
                    return false;
                //连接设备
                if (!CAN_Function.OpenCAN(connParams)) return false;

                if (!CAN_Function.InitCAN(connParams)) return false;

                if (!CAN_Function.StartCAN(connParams)) return false;
                _connected = true;
                recv_data_thread = new recvdatathread();
                recv_data_thread.canFactory = connParams.CAN_Company;
                recv_data_thread.setChannelHandle(CAN_Function.GetChannel());
                recv_data_thread.setStart(_connected);
                recv_data_thread.RecvCANData += RecvData;
                recv_data_thread.RecvFDData += RecvDataFD;
                return true;
            }
            catch
            {
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
    }
}
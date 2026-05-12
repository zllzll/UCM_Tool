using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLGCAN;

namespace UCM_Tools.Radar
{
    public class ConnData
    {
        public string ConnType { get; set; } = string.Empty;

        public uint FrameID { get; set; } = 0;

        /// <summary>
        /// CAN帧时是数据区字节数组
        /// 字节流时是整个字节数组
        /// </summary>
        public List<byte> Datas { get; set; } = new List<byte>();

        /// <summary>
        /// 代表数据有效长度
        /// </summary>
        public int Length { get; set; } = 0;
        public bool AddRadarId { get; set; } = false;
        public ConnData()
        {

        }
        public ConnData(can_frame can_Frame)
        {
            ConnType = "CAN";
            FrameID = can_Frame.can_id;
            Datas = can_Frame.data?.ToList();
            Length = can_Frame.can_dlc;
            AddRadarId = false;
        }
        public ConnData(canfd_frame canfd_Frame)
        {
            ConnType = "CANFD";
            FrameID = canfd_Frame.can_id;
            Datas = canfd_Frame.data?.ToList();
            Length = canfd_Frame.len;
            AddRadarId = false;
        }
        public ConnData(byte[] bytes)
        {
            ConnType = "TCP";
            Datas = bytes?.ToList();
            Length = bytes == null ? 0 : bytes.Length;
            AddRadarId = false;
        }

    }
}

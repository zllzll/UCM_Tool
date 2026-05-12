using UCM_Tools.CAN_Conn;
using LogProc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UCM_Tools.Tools;
using ZLGCAN;

namespace UCM_Tools.Radar
{
    public class RadarProtcol
    {
        public uint radarId = 0;
        #region 委托
        /// <summary>
        /// 周期内点云目标委托
        /// </summary>
        public delegate void CyclePointCloud(int tarNum, List<TargetInfo.RadarTargetInfoStruct> targetInfoList);
        [method: CompilerGenerated]
        public event CyclePointCloud cyclePointCloud;

        public delegate void CycleDataDelegate(string time, int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList);
        [method: CompilerGenerated]
        public event CycleDataDelegate cycleDataEvent;

        public void OnIdentifyInfoEvent(string time,int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            if (cycleDataEvent != null)
                cycleDataEvent(time,NumTar, targetInfoList);
        }
        /// <summary>
        /// 版本委托
        /// </summary>
        public delegate void VersionDelegate(string version);
        [method: CompilerGenerated]
        public event VersionDelegate versionEvent;
        public void OnVersionEvent(string version)
        {
            if (versionEvent != null)
                versionEvent(version);
        }
        /// <summary>
        /// 雷达ID和错频ID委托
        /// </summary>
        public delegate void RadarIDDelegate(int radarId,int freqId);
        [method: CompilerGenerated]
        public event RadarIDDelegate radarIdEvent;
        public void OnRadarIDEvent(int radarId, int freqId)
        {
            if (radarIdEvent != null)
                radarIdEvent(radarId,freqId);
        }

        /// <summary>
        /// 硬件ID委托
        /// </summary>
        public delegate void HardwareIDDelegate(byte[] hardwareId);
        [method: CompilerGenerated]
        public event HardwareIDDelegate hardwareIdEvent;
        public void OnHardwareIDEvent(byte[] hardwareId)
        {
            if (hardwareIdEvent != null)
                hardwareIdEvent(hardwareId);
        }
        /// <summary>
        /// 密钥回复委托
        /// </summary>
        public delegate void KeyIDRespDelegate(bool success);
        [method: CompilerGenerated]
        public event KeyIDRespDelegate keyIdRespEvent;
        public void OnKeyIDRespEvent(bool success)
        {
            if (keyIdRespEvent != null)
                keyIdRespEvent(success);
        }
        /// <summary>
        /// 激活状态委托
        /// </summary>
        public delegate void AliveStatusDelegate(bool alive);
        [method: CompilerGenerated]
        public event AliveStatusDelegate aliveStatusEvent;
        public void OnAliveStatusEvent(bool alive)
        {
            if (aliveStatusEvent != null)
                aliveStatusEvent(alive);
        }

        #endregion  委托
        /// <summary>
        /// 当前显示目标的对应60A的目标数量值
        /// </summary>
        public int curTarNum = 0;
        DateTime lastTime = DateTime.Now;
        /// <summary>
        /// 当前显示目标列表
        /// </summary>
        public List<TargetInfo.RadarTargetInfoStruct> radarTarList = new List<TargetInfo.RadarTargetInfoStruct>();

        public RadarProtcol()
        {
            curTarNum = 0;
            radarTarList = new List<TargetInfo.RadarTargetInfoStruct>();
            lastTime = DateTime.Now;
        }

        public can_frame? PackCANFrame(string cmd, byte[] bytes = null, bool addRadarId = false)
        {
            can_frame? can_Frame = null;
            switch (cmd)
            {
                case "readversion":
                    can_Frame = new can_frame() { can_id = 0x500 + (addRadarId ? (radarId << 4) : 0), data = bytes == null ? new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00} : bytes };
                    break;
                case "readradarid":
                    can_Frame = new can_frame() { can_id = 0x500 + (addRadarId ? (radarId << 4) : 0), data = bytes == null ? new byte[8] { 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00} : bytes };
                    break;
                case "readalivestatus":
                    can_Frame = new can_frame() { can_id = 0x500 + (addRadarId ? (radarId << 4) : 0), data = bytes == null ? new byte[8] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00} : bytes };
                    break;
                case "readhardwareid":
                    can_Frame = new can_frame() { can_id = 0x302, data = bytes==null?new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }:bytes };
                    break;
                case "writekeyid":
                    can_Frame = new can_frame() { can_id = 0x304, data = bytes==null?new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }:bytes };
                    break;
                case "enterupgrade":
                    can_Frame = new can_frame() { can_id = 0x500 + (addRadarId ? (radarId << 4) : 0), data = bytes==null?new byte[8] { 0xFE, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }:bytes };
                    break;
            }
            return can_Frame;
        }



        public void handleCANData(uint frameId, byte[] data)
        {
            if (data == null || data.Length < 8)
                return;
            try
            {
                uint can_id = CAN_Function.GetId(frameId);
                switch (can_id & 0xF0F)
                {
                    case 0x60A:
                    case 0x600:
                        radarId = ((can_id >> 4) & 0x0F);
                        //委托
                        CyclePointCloud expr_6E = cyclePointCloud;
                        if (expr_6E != null)
                        {
                            expr_6E(curTarNum, radarTarList);
                        }
                        OnIdentifyInfoEvent(lastTime.ToString(PubClass.timeFormat),curTarNum, radarTarList);
                        //下一个显示目标的对应60A的目标数量值
                        curTarNum = (data[0] << 8) + data[1];
                        lastTime = DateTime.Now;
                        radarTarList.Clear();
                        break;
                    case 0x60B:
                    case 0x701:
                        CANDataParse(data, lastTime.ToString(PubClass.timeFormat));
                        break;
                    case 0x700:
                        radarId = ((can_id >> 4) & 0x0F);
                        string verstring = $"{data[0]}.{data[1]}.{data[2]}";
                        OnVersionEvent(verstring);
                        break;
                    case 0x201:
                        radarId = ((can_id >> 4) & 0x0F);
                        break;
                    case 0x501:
                        bool isSuccess = (data[0]>>7) == 1;
                        switch (data[0] & 0x7F)
                        {
                            case 0x02://版本号
                                OnVersionEvent($"{data[1]}.{data[2]}.{data[3]}");
                                break;
                            case 0x04://雷达编号和错频编号
                                OnRadarIDEvent(data[1], data[2]);
                                break;
                            case 0x0F://激活状态
                                OnAliveStatusEvent(data[1] == 0);
                                break;
                        }
                        break;
                    case 0x303: //硬件ID
                        OnHardwareIDEvent(data);
                        break;
                    case 0x305: //写入密钥回复
                        OnKeyIDRespEvent(data[0]==0x0F);
                        break;
                }
            }
            catch (Exception _ex)
            {
                Log.Error("处理CANFD接收数据异常\r\n" + _ex.ToString());
            }
        }
        #region 计算坐标

        /// <summary>
        /// 计算坐标
        /// </summary>
        private void CANDataParse(byte[] data,string time)
        {
            try
            {
                int count = data.Length / 8;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i * 8;
                    TargetInfo.RadarTargetInfoStruct target = new TargetInfo.RadarTargetInfoStruct();
                    //X坐标
                    double obj_DistLat = ((0x07 & data[startIndex + 2]) << 8) + data[startIndex + 3];
                    obj_DistLat = obj_DistLat * 0.05 - 50;
                    //obj_DistLat = obj_DistLat - 51.15;
                    //Y坐标
                    decimal obj_DistLong = (data[startIndex + 1] << 5) + ((data[startIndex + 2] >> 3) & 0x1f);
                    obj_DistLong = (obj_DistLong * 0.05M) - 100;
                    //Z坐标
                    decimal obj_Z = ((data[startIndex + 5] & 0x3f) << 3) + ((data[startIndex + 6] >> 5) & 0x07);
                    obj_Z = obj_Z * 0.25M - 64;
                    //速度Y
                    decimal obj_Vrelong = (data[startIndex + 4] << 2) + ((data[startIndex + 5] >> 6) & 0x03);
                    obj_Vrelong = obj_Vrelong * 0.25M - 128;
                    //目标类型
                    double obj_DynProp = (data[startIndex + 6] & 0x07);
                    //目标类型
                    double obj_Class = (data[startIndex + 6] & 0x18) >> 3;

                    uint tarId = data[startIndex + 0];
                    double rcs =data[startIndex + 6];//canfd_frame.data[startIndex + 6] * 0.5 - 64;
                    target.ID = tarId;
                    target.Num = tarId;
                    target.XAxis = obj_DistLat;
                    target.YAxis = (double)obj_DistLong;
                    target.ZAxis = (double)obj_Z;
                    target.Range = Math.Sqrt(target.XAxis * target.XAxis + target.YAxis * target.YAxis);
                    target.PAngle = (Math.Atan2(target.XAxis, target.YAxis) * 180 / Math.PI);
                    target.TAngle = (Math.Atan2(target.ZAxis, target.YAxis) * 180 / Math.PI);
                    target.Class = (int)obj_Class;
                    target.Vy = (double)obj_Vrelong;
                    target.Velocity = target.Vy;
                    target.RCS = rcs;

                    target.Type = (int)obj_DynProp;
                    target.RadarType = "SR75";
                    target.SaveTime = time;
                    radarTarList.Add(target);
                }

            }
            catch (Exception _ex) { Log.Error("计算CANFD坐标异常\r\n" + _ex.ToString()); }
        }

        #endregion 计算坐标

    }
}

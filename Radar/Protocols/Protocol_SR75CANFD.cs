using UCM_Tools.CAN_Conn;
using UCM_Tools.Tools;
using LogProc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZLGCAN;

namespace UCM_Tools.Radar.Protocols
{
    public class Protocol_SR75CANFD:IProtocol
    {
        ConcurrentQueue<ConnData> connDataQueue = new ConcurrentQueue<ConnData>();
        Thread thread = null;
        bool isHandle = false;
        public Protocol_SR75CANFD()
        {
            curTarNum = 0;
            radarTarList = new List<TargetInfo.RadarTargetInfoStruct>();
            lastTime = DateTime.Now;
            connDataQueue = new ConcurrentQueue<ConnData>();
            isHandle = true;
            thread = new Thread(HandleData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void HandleData()
        {
            while (isHandle)
            {
                if (connDataQueue.TryDequeue(out var result))
                {
                    if (result != null)
                    {
                        handleData(result);
                        //OnFrameEvent(temp.FrameID, temp.Datas.ToArray());
                    }
                }
                else
                    Thread.Sleep(1);
            }
        }

        public override ConnData PackFrame(RadarCommand cmd, byte[] bytes = null, bool addRadarId = false)
        {
            ConnData connData = new ConnData() {ConnType="CANFD",Length = (byte)(bytes == null ? 8 : bytes.Length) };
            try
            {
                switch (cmd)
                {
                    case RadarCommand.ReadSoftwareVersion:
                        connData.FrameID = 0x500 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.ReadRadarId:
                        connData.FrameID = 0x500 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.ReadAliveStatus:
                        connData.FrameID = 0x500 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.ReadHardwareId:
                        connData.FrameID = 0x302 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.WriteKeyId:
                        connData.FrameID = 0x304 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.EnterUpgrade:
                        connData.FrameID = 0x500 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0xFE, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.EarseFile:
                        connData.FrameID = 0x102 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.SendFile:
                        connData.FrameID = 0x104 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.SendFileCheck:
                        connData.FrameID = 0x105 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.StartUpgrade:
                        connData.FrameID = 0x109 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    default:
                        throw new Exception($"Protocol_SR75CANFD not find {cmd}");
                }
            }catch(Exception ex)
            {
                Log.Error(ex.Message);
                connData = null;
            }
            return connData;
        }



        public void handleData(ConnData data)
        {
            if (data == null || data.Length < 8)
                return;
            try
            {
                uint can_id = CAN_Function.GetId(data.FrameID);
                switch (can_id & 0xF0F)
                {
                    case 0x60A:
                    case 0x600:
                        radarId = ((can_id >> 4) & 0x0F);
                        OnCyclePointCloudEvent(curTarNum, radarTarList);
                        OnIdentifyInfoEvent(lastTime.ToString(PubClass.timeFormat), curTarNum, radarTarList);
                        //下一个显示目标的对应60A的目标数量值
                        curTarNum = (data.Datas[0] << 8) + data.Datas[1];
                        lastTime = DateTime.Now;
                        radarTarList.Clear();
                        break;
                    case 0x60B:
                    case 0x701:
                        CANDataParse(data.Datas.ToArray(), lastTime.ToString(PubClass.timeFormat));
                        break;
                    case 0x700:
                        radarId = ((can_id >> 4) & 0x0F);
                        string verstring = $"{data.Datas[0]}.{data.Datas[1]}.{data.Datas[2]}";
                        OnVersionEvent(verstring);
                        break;
                    case 0x201:
                        radarId = ((can_id >> 4) & 0x0F);
                        break;
                    case 0x501:
                        bool isSuccess = (data.Datas[0] >> 7) == 1;
                        switch (data.Datas[0] & 0x7F)
                        {
                            case 0x02://版本号
                                OnVersionEvent($"{data.Datas[1]}.{data.Datas[2]}.{data.Datas[3]}");
                                break;
                            case 0x04://雷达编号和错频编号
                                OnRadarIDEvent(data.Datas[1], data.Datas[2]);
                                break;
                            case 0x0F://激活状态
                                OnAliveStatusEvent(data.Datas[1] == 0);
                                break;
                        }
                        break;
                    case 0x303: //硬件ID
                        OnHardwareIDEvent(data.Datas.ToArray());
                        break;
                    case 0x305: //写入密钥回复
                        OnKeyIDRespEvent(data.Datas[0] == 0x0F);
                        break;
                    case 0x102:
                    case 0x103:
                    case 0x104:
                    case 0x105:
                    case 0x109:
                        OnFrameEvent(can_id, data.Datas.ToArray());
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
        private void CANDataParse(byte[] data, string time)
        {
            try
            {
                int count = data.Length / 8;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i * 8;
                    TargetInfo.RadarTargetInfoStruct target = new TargetInfo.RadarTargetInfoStruct();
                    //X坐标
                    decimal obj_DistLat = ((0x07 & data[startIndex + 2]) << 8) + data[startIndex + 3];
                    obj_DistLat = obj_DistLat * 0.05M - 50;
                    //obj_DistLat = obj_DistLat - 51.15;
                    //Y坐标
                    decimal obj_DistLong = (data[startIndex + 1] << 5) + ((data[startIndex + 2] >> 3) & 0x1f);
                    obj_DistLong = (obj_DistLong * 0.05M) - 100;
                    //Z坐标
                    decimal obj_Z = ((data[startIndex + 5] & 0x3f) << 3) + ((data[startIndex + 6] >> 5) & 0x07);
                    obj_Z = obj_Z * 0.25M - 64;
                    //速度Y
                    decimal obj_Vrelong = (data[startIndex + 4] << 2) + ((data[startIndex + 5] >> 6) & 0x03);
                    obj_Vrelong = obj_Vrelong * 0.05M - 16;
                    //目标类型
                    double obj_DynProp = (data[startIndex + 6] & 0x07);
                    //目标类型
                    double obj_Class = (data[startIndex + 6] & 0x18) >> 3;

                    uint tarId = data[startIndex + 0];
                    double rcs = data[startIndex + 7];//canfd_frame.data[startIndex + 6] * 0.5 - 64;
                    target.ID = tarId;
                    target.Num = tarId;
                    target.XAxis = (double)obj_DistLat;
                    target.YAxis = (double)obj_DistLong;
                    target.ZAxis = (double)obj_Z;
                    target.Range = Math.Sqrt(target.XAxis * target.XAxis + target.YAxis * target.YAxis);
                    target.PAngle = (Math.Atan2(target.XAxis, target.YAxis) * 180 / Math.PI);
                    target.TAngle = (Math.Atan2(target.ZAxis, target.YAxis) * 180 / Math.PI);
                    target.Class = (int)obj_Class;
                    target.Vy = (double)obj_Vrelong;
                    target.Velocity = target.Vy;
                    //Console.WriteLine($"{target.Velocity}\r\n");
                    target.RCS = rcs;

                    target.Type = (int)obj_DynProp;
                    target.RadarType = "SR75";
                    target.SaveTime = time;
                    radarTarList.Add(target);
                }

            }
            catch (Exception _ex) { Log.Error("计算CANFD坐标异常\r\n" + _ex.ToString()); }
        }

        //public override ConnData GetFullFrame(ConnData connData)
        //{
        //    return connData;
        //}

        #endregion 计算坐标

        public override void AddDataList(ConnData connData)
        {
            connDataQueue.Enqueue(connData);
        }

        public override void Dispose()
        {
            isHandle = false;
            if (thread != null)
            {
                thread.Join(500);
            }
            thread = null;
            connDataQueue = new ConcurrentQueue<ConnData>();
        }
    }
}

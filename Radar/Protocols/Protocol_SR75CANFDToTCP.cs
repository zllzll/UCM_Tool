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
    /// <summary>
    /// AA AA + 4字节数据长度(小端) + 4字节帧ID(小端)  + 数据 + 校验和 + 55 55
    /// 数据长度（包含帧ID和数据）
    /// 校验和(从帧头后面的字节到检验和前面的字节之和取低8位)
    /// 最小长度21
    /// </summary>
    public class Protocol_SR75CANFDToTCP: IProtocol
    {
        private static object obj = new object();
        byte HEAD = 0xAA, TAIL = 0x55;
        Thread thread = null;
        bool isHandle = false;
        /// <summary>
        /// 用于存储
        /// </summary>
        List<byte> ByteBuffer = new List<byte>();
        private const int minFrameLength = 21;//1个目标时
        private const int maxFrameLength = 77;//8个目标时
        public Protocol_SR75CANFDToTCP()
        {
            curTarNum = 0;
            radarTarList = new List<TargetInfo.RadarTargetInfoStruct>();
            lastTime = DateTime.Now;
            ByteBuffer.Clear();
            isHandle = true;
            thread = new Thread(HandleData);
            thread.IsBackground = true;
            thread.Start();
        }
        private void HandleData()
        {
            List<byte> temp = new List<byte>();
            while (isHandle)
            {
                if (ByteBuffer.Count > 0)
                {
                    lock (obj)
                    {
                        //Console.WriteLine($"锁增加：{BitConverter.ToString(ByteBuffer.ToArray())}");
                        temp.AddRange(ByteBuffer);
                        ByteBuffer.Clear();
                    }
                    //if (temp.Count >= 4 && temp[0] == HEAD && temp[1] == HEAD && temp[2] == HEAD && temp[3] == HEAD)
                    //{

                    //}
                    GetFullFrame(ref temp);
                }
                else
                    Thread.Sleep(1);
            }
        }

        public override ConnData PackFrame(RadarCommand cmd, byte[] bytes = null, bool addRadarId = false)
        {
            ConnData connData = new ConnData() { ConnType = "TCP" };
            try
            {
                connData.Datas.AddRange(new byte[] { 0xAA,0xAA});
                switch (cmd)
                {
                    case RadarCommand.ReadSoftwareVersion:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x500 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);                        
                        break;
                    case RadarCommand.ReadRadarId:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x500 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.ReadAliveStatus:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x500 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.ReadHardwareId:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x302 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.WriteKeyId:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x304 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.EnterUpgrade:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x500 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0xFE, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.EarseFile:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x102 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.SendFile:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x104 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.SendFileCheck:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x105 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes);
                        break;
                    case RadarCommand.StartUpgrade:
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(bytes == null ? 8 : bytes.Length) + 4));
                        connData.Datas.AddRange(BitConverter.GetBytes((uint)(0x109 + (addRadarId ? (radarId << 4) : 0))));
                        connData.Datas.AddRange(bytes == null ? new byte[8] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 } : bytes);
                        break;
                    default:
                        throw new NotImplementedException($"Protocol_SR75CANFDToTCP Not find {cmd}");
                }
                connData.Datas.Add(PubClass.GetCheckSum(connData.Datas.ToArray(), 2, connData.Datas.Count - 2));
                connData.Datas.AddRange(new byte[] { 0x55, 0x55 });
                connData.Length = connData.Datas.Count;
            }
            catch (Exception e) 
            {
                Log.Error(e.Message);
                connData = null;
            }
            return connData;
        }



        public void handleData(byte[] connData)
        {
            if (connData == null || connData.Length < 8)
                return;
            try
            {
                int dataLength = BitConverter.ToInt32(connData.ToArray(), 2);
                uint can_id = BitConverter.ToUInt32(connData.ToArray(),6);
                byte[] data = connData.Skip(10).Take(dataLength - 4).ToArray();
                switch (can_id & 0xF0F)
                {
                    case 0x60A:
                    case 0x600:
                        radarId = ((can_id >> 4) & 0x0F);
                        OnCyclePointCloudEvent(curTarNum, radarTarList);
                        OnIdentifyInfoEvent(lastTime.ToString(PubClass.timeFormat), curTarNum, radarTarList);
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
                        bool isSuccess = (data[0] >> 7) == 1;
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
                        OnKeyIDRespEvent(data[0] == 0x0F);
                        break;
                    case 0x102:
                    case 0x103:
                    case 0x104:
                    case 0x105:
                    case 0x109:
                        Console.WriteLine($"收到0x{Convert.ToString(can_id, 16)}");
                        OnFrameEvent(can_id, data);
                        break;
                }
            }
            catch (Exception _ex)
            {
                Log.Error("处理数据异常\r\n" + _ex.ToString());
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
                    target.RCS = rcs;

                    target.Type = (int)obj_DynProp;
                    target.RadarType = "SR75";
                    target.SaveTime = time;
                    radarTarList.Add(target);
                }

            }
            catch (Exception _ex) { Log.Error("计算CANFD坐标异常\r\n" + _ex.ToString()); }
        }

        /// <summary>
        /// 获取完整帧
        /// </summary>
        /// <param name="connData">传进来是字节流</param>
        /// <returns>返回的是完整帧</returns>
        /// <exception cref="NotImplementedException"></exception>
        public void GetFullFrame(ref List<byte> bytes)
         {
            if (bytes == null || bytes.Count<=0)
                return;
            try
            {
                
                while (bytes.Count >= minFrameLength)
                {
                    int head0Index = bytes.IndexOf(HEAD, 0);
                    if (head0Index < 0)
                    {
                        //Console.WriteLine("没找到帧头");
                        bytes.Clear();
                        break;
                    }
                    if (bytes[head0Index + 1] !=HEAD)
                    {
                        //Console.WriteLine("第二个帧头不对");
                        bytes.RemoveAt(0);
                        continue;
                    }
                    int length = BitConverter.ToInt32(bytes.ToArray(), head0Index + 2);
                    int frameLength = 9 + length;
                    if (frameLength > maxFrameLength || frameLength< minFrameLength)
                    {
                        //Console.WriteLine("长度不合法");
                        Log.Error("frame leng is error");
                        bytes.RemoveRange(0, head0Index + 2);
                        continue;
                    }
                    if (bytes.Count < head0Index + frameLength)
                    {
                        //Console.WriteLine("长度不够");
                        break;
                    }
                    byte[] result = bytes.Skip(head0Index).Take(frameLength).ToArray();
                    if (result[frameLength - 1] != TAIL || result[frameLength - 2] != TAIL || result[frameLength - 3]!=PubClass.GetCheckSum(result,2, frameLength-5))
                    {
                        bytes.RemoveRange(0, head0Index + 2);
                        //Console.WriteLine("检验或帧尾不过");
                        Log.Error("frame check is error");
                        continue;
                    }

                    bytes.RemoveRange(0, head0Index + frameLength);
                    handleData(result);
                    //OnFrameEvent(temp.FrameID, temp.Datas.ToArray());
                }
            }
            catch(Exception ex)
            {
                Log.Error($"ConnData GetFullFrame(ConnData connData)\r\n{ex.ToString()}");
            }
        }

        #endregion 计算坐标

        public override void Dispose()
        {
            isHandle = false;
            if (thread != null)
            {
                thread.Join(500);
            }
            thread = null;
            ByteBuffer.Clear();
        }

        public override void AddDataList(ConnData connData)
        {
            lock(obj)
                ByteBuffer.AddRange(connData.Datas);
        }
    }
}

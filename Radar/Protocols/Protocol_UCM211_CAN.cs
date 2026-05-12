using LogProc;
using OpenCvSharp;
using OpenCvSharp.Flann;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UCM_Tools.CAN_Conn;
using UCM_Tools.Models;
using UCM_Tools.Tools;
using ZLGCAN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UCM_Tools.Radar.Protocols
{
    public class Protocol_UCM211_CAN : IProtocol
    {
        ConcurrentQueue<ConnData> connDataQueue = new ConcurrentQueue<ConnData>();
        Thread thread = null;
        bool isHandle = false;
        bool isGetFirst = false;
        TargetInfo.RadarTargetInfoStruct target = new TargetInfo.RadarTargetInfoStruct();
        ConcurrentDictionary<uint,DateTime> canIdList = new ConcurrentDictionary<uint, DateTime>();//用于判定何时往上推数据

        List<PointCloudData> pointList = new List<PointCloudData>();
        List<TrackData> trackList = new List<TrackData>();
        int clusterMeasCounter = -1;
        int objectMeasCounter = -1;
        public Protocol_UCM211_CAN()
        {
            isGetFirst = false;
            canIdList.Clear();
            pointList.Clear();
            trackList.Clear();
            clusterMeasCounter = -1;
            objectMeasCounter = -1;
            target = new TargetInfo.RadarTargetInfoStruct();
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
            ConnData connData = new ConnData() {ConnType="CAN",Length = (byte)(bytes == null ? 8 : bytes.Length) };
            try
            {
                switch (cmd)
                {
                    case RadarCommand.ReadSoftwareVersion:
                        connData.FrameID = 0x200 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.ReadRadarId:
                        connData.FrameID = 0x200 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } : bytes?.ToList();
                        connData.Length = (byte)(bytes == null ? 8 : bytes.Length);
                        break;
                    case RadarCommand.ReadAliveStatus:
                        connData.FrameID = 0x200 + (addRadarId ? (radarId << 4) : 0);
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
                        connData.FrameID = 0x200 + (addRadarId ? (radarId << 4) : 0);
                        connData.Datas = bytes == null ? new List<byte> { 0xFE, 0x08, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 } : bytes?.ToList();
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
                        throw new Exception($"Protocol_UCM211_CAN not find {cmd}");
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
                        radarId = ((can_id >> 4) & 0x0F);
                        objectMeasCounter = BitConverter.ToUInt16(data.Datas.ToArray(), 2);
                        if (canIdList.TryGetValue(can_id, out DateTime dateTimeObject))
                        {
                            if (canIdList.Count == 1 || (canIdList.Count == 2 && objectMeasCounter == clusterMeasCounter))
                            {
                                //Console.WriteLine(radarTarList.Count);
                                //OnTarAndClusterPointCloudEvent(curObjectTime.ToString(PubClass.timeFormat), radarTarList, radarClusterList);
                                OnTarAndClusterPointCloudEvent(lastTime.ToString(PubClass.timeFormat), radarTarList, radarClusterList);
                                OnPointCloudSaveDataEvent(pointList, trackList);
                            }
                        }
                        DateTime curObjectTime = DateTime.Now;
                        //lastTime = DateTime.Now;
                        canIdList.AddOrUpdate(can_id, curObjectTime, (k, v) => curObjectTime);
                        radarTarList.Clear();
                        break;
                    case 0x600:
                        radarId = ((can_id >> 4) & 0x0F);
                        clusterMeasCounter = BitConverter.ToUInt16(data.Datas.ToArray(), 2);
                        if (canIdList.TryGetValue(can_id, out DateTime dateTimeCluster))
                        {
                            if (canIdList.Count == 1 || (canIdList.Count == 2 && objectMeasCounter == clusterMeasCounter))
                            {
                                OnTarAndClusterPointCloudEvent(dateTimeCluster.ToString(PubClass.timeFormat), radarTarList, radarClusterList);
                                OnPointCloudSaveDataEvent(pointList, trackList);
                            }
                        }
                        DateTime curClusterTime = DateTime.Now;
                        canIdList.AddOrUpdate(can_id, curClusterTime, (k, v) => curClusterTime);
                        radarClusterList.Clear();
                        break;
                    case 0x60B:
                        radarId = ((can_id >> 4) & 0x0F);
                        CANTargetDataParse(data.Datas.ToArray(), lastTime.ToString(PubClass.timeFormat));
                        break;
                    case 0x701:
                        CANClusterDataParse(data.Datas.ToArray(), lastTime.ToString(PubClass.timeFormat));
                        break;
                    case 0x700:
                        radarId = ((can_id >> 4) & 0x0F);
                        string verstring = $"{data.Datas[0]}.{data.Datas[1]}.{data.Datas[2]}";
                        OnVersionEvent(verstring);
                        break;
                    case 0x400:
                        radarId = ((can_id >> 4) & 0x0F);
                        if (data.Datas[0] == 0x82)
                            OnVersionEvent($"{data.Datas[1]}.{data.Datas[2]}.{data.Datas[3]}");
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
                Log.Error("Protocol_UCM211_CAN handle Ex\r\n" + _ex.ToString());
            }
        }
        #region 计算坐标

        /// <summary>
        /// 计算坐标
        /// </summary>
        private void CANClusterDataParse(byte[] data, string time)
        {
            if (data == null || data.Length != 8)
                return;
            try
            {
                int subFrame = (data[7] >> 5) & 0x07;
                if (subFrame == 0 && !isGetFirst)
                {
                    target = new TargetInfo.RadarTargetInfoStruct();
                    target.ID = BitConverter.ToUInt16(data, 0);
                    target.Range = BitConverter.ToSingle(data, 2);
                    target.SNR = data[6];
                    isGetFirst = true;
                }
                else if (subFrame == 1 && isGetFirst && ((data[7] << 8) + data[6]) == target.ID )
                {
                    double clusterAzimuth = BitConverter.ToInt16(data, 0) * 0.01d;
                    double Azimuth = clusterAzimuth * Math.PI / 180d;//方位角度
                    double clusterPitch = BitConverter.ToInt16(data, 2) * 0.01d;
                    double Pitch = clusterPitch * Math.PI / 180d;//俯仰角度
                    double z = target.Range * Math.Sin(clusterPitch);
                    double xy = target.Range * Math.Cos(clusterPitch);
                    double x = xy * Math.Sin(clusterAzimuth);
                    double y = xy * Math.Cos(clusterAzimuth);
                    target.PAngle = Math.Abs(Azimuth) < PubClass.ε ? 0 : Azimuth;//传的角度
                    target.TAngle = Math.Abs(Pitch) < PubClass.ε ? 0 : Pitch;//传的角度
                    target.XAxis = Math.Abs(x) < PubClass.ε ? 0 : x;
                    target.YAxis = Math.Abs(y) < PubClass.ε ? 0 : y;
                    target.ZAxis = Math.Abs(z) < PubClass.ε ? 0 : z;
                    target.Velocity = BitConverter.ToInt16(data, 4) * 0.01d;
                    target.SaveTime = time;
                    radarClusterList.Add(target);
                    pointList.Add(new PointCloudData()
                    {
                        Range = (float)target.Range,
                        Azimuth = clusterAzimuth,//传的弧度
                        Elevation = clusterPitch,
                        Velocity = target.Velocity,
                        SNR = target.SNR
                    });
                    isGetFirst = false;
                }
                else
                {
                    target = new TargetInfo.RadarTargetInfoStruct();
                    isGetFirst = false;
                }
            }
            catch (Exception _ex) { Log.Error("Protocol_UCM211_CAN Dataparse Ex\r\n" + _ex.ToString()); }
        }

        /// <summary>
        /// 计算坐标
        /// </summary>
        private void CANTargetDataParse(byte[] data, string time)
        {
            if (data == null || data.Length != 8)
                return;
            try
            {
                //Console.WriteLine(BitConverter.ToString(data));
                int subFrame = (data[7]>>5) & 0x07;
                //Console.WriteLine(data[0]);
                if (subFrame == 0 && !isGetFirst)
                {
                    target = new TargetInfo.RadarTargetInfoStruct();
                    target.ID = data[0];
                    target.Class = data[1]&0x0F;
                    target.Confidence = ((data[1]>>4)&0x0F)*10;
                    target.XAxis = PubClass.Bit21ToInt(((data[4] & 0x1F) << 16) + (data[3] << 8) + data[2]) * 0.01d;//单位m;
                    target.YAxis = PubClass.Bit21ToInt(((data[7] & 0x03) << 19) + (data[6] << 11) + (data[5] << 3) + ((data[4] >> 5) & 0x07)) * 0.01d;
                    isGetFirst = true;
                }
                else if (subFrame == 1 && isGetFirst && data[0]==target.ID)
                {
                    target.Velocity = BitConverter.ToInt16(data, 1) * 0.01d;//速度单位m/s
                    target.RadarAcc = BitConverter.ToInt16(data, 3) * 0.01d;//加速度单位m/s²
                    target.ZAxis = PubClass.Bit21ToInt(((data[7] & 0x1F) << 16) + (data[6] << 8) + data[5]) * 0.01d;//单位m;
                    target.Range = Math.Sqrt(target.XAxis * target.XAxis + target.YAxis * target.YAxis + target.ZAxis * target.ZAxis);
                    double pAngle = Math.Atan(target.XAxis / target.YAxis) * 180d / Math.PI;
                    target.PAngle = Math.Abs(pAngle) < PubClass.ε ? 0 : pAngle;
                    double tAngle = Math.Atan(target.ZAxis / Math.Sqrt(target.XAxis * target.XAxis + target.YAxis * target.YAxis)) * 180d / Math.PI;
                    target.TAngle = Math.Abs(tAngle) < PubClass.ε ? 0 : tAngle;
                    target.Velocity = BitConverter.ToInt16(data, 4) * 0.01d;
                    target.SaveTime = time;
                    radarTarList.Add(target);
                    trackList.Add(new TrackData()
                    {
                        TarID = target.ID,
                        TarClass = target.Class,
                        Confidence = target.Confidence,
                        X = target.XAxis,
                        Y = target.YAxis,
                        Z = target.ZAxis,
                        Velocity = target.Velocity,
                        Acc = target.RadarAcc,
                    });
                    isGetFirst = false;
                }
                else
                {
                    target = new TargetInfo.RadarTargetInfoStruct();
                    isGetFirst = false;
                }
            }
            catch (Exception _ex) { Log.Error("Protocol_UCM211_CAN Dataparse Ex\r\n" + _ex.ToString()); }
        }
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

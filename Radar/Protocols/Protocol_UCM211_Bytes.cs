using CommonLib;
using Kitware.VTK;
using LogProc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.Models;
using UCM_Tools.Tools;
using static CommonLib.ConfigXMLRadar;

namespace UCM_Tools.Radar.Protocols
{
    /// <summary>
    /// 全用小端
    /// </summary>
    public class Protocol_UCM211_Bytes : IProtocol
    {
        private static object obj = new object();
        byte HEAD_TY0 = 0xA5, HEAD_TY1 = 0x5A;
        private const byte BASE_DATA_TY0 = 0xA7;
        private const byte BASE_DATA_TY1 = 0x7A;

        private const byte TAR_DATA_TY0 = 0xA8;
        private const byte TAR_DATA_TY1 = 0x8A;
        private const byte CLUSTER_DATA_TY0 = 0xA9;
        private const byte CLUSTER_DATA_TY1 = 0x9A;
        Thread thread = null;
        bool isHandle = false;
        /// <summary>
        /// 用于存储
        /// </summary>
        List<byte> ByteBuffer = new List<byte>();
        public const int minRespFrameLength = 24;//回复帧最小24
        private const int minTarFrameLength = 25;//目标帧在无跟踪和点云信息时 2字节总帧头+2字节总帧长度 + 汇总信息总长度(24个字节) + 1字节总校验和  30
        public Protocol_UCM211_Bytes()
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
                //Console.WriteLine(ByteBuffer.Count);
                if (ByteBuffer.Count > 0)
                {
                    lock (obj)
                    {
                        //Console.WriteLine($"锁增加：{BitConverter.ToString(ByteBuffer.ToArray())}");
                        temp.AddRange(ByteBuffer);
                        ByteBuffer.Clear();
                    }
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
                //Heather（2字节）+ Command（10字节）+ ReturnValue（4字节）+ Flags（4字节）+ prmSize（4字节）+ Params（prmSize字节）
                connData.Datas.AddRange(new byte[] { HEAD_TY1, HEAD_TY0 });//帧头
                string cmdString = string.Empty;
                switch (cmd)
                {
                    case RadarCommand.ReadSoftwareVersion:
                        cmdString = FuncTYType.getVer.ToString();
                        break;
                    case RadarCommand.EnterUpgrade:
                        cmdString = FuncTYType.upgrade.ToString();
                        break;
                    case RadarCommand.SetParamsUCM211:
                        cmdString = FuncTYType.setPara.ToString();
                        break;
                    case RadarCommand.ReadParamsUCM211:
                        cmdString = FuncTYType.getPara.ToString();
                        break;
                    default:
                        throw new NotImplementedException($"Protocol_UCM211_Bytes Not find {cmd}");
                }
                byte[] cmdByte = Encoding.ASCII.GetBytes(cmdString);
                byte[] byteCmd = new byte[10];//Command
                Array.Clear(byteCmd, 0, byteCmd.Length);//将数组全部设置为0
                Array.Copy(cmdByte, 0, byteCmd, 0, cmdByte.Length);
                connData.Datas.AddRange(byteCmd);
                byte[] returnByte = new byte[4];//ReturnValue
                Array.Clear(returnByte, 0, returnByte.Length);//将数组全部设置为0
                connData.Datas.AddRange(returnByte.Reverse());
                //byte[] flags = new byte[4];//ReturnValue
                //Array.Clear(flags, 0, flags.Length);//将数组全部设置为0
                connData.Datas.AddRange(BitConverter.GetBytes(0));
                int size = bytes == null ? 0 : bytes.Length;
                connData.Datas.AddRange(BitConverter.GetBytes(size));
                if (size > 0)
                    connData.Datas.AddRange(bytes);
                connData.Length = connData.Datas.Count;
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                connData = null;
            }
            return connData;
        }

        /// <summary>
        /// 获取完整帧
        /// </summary>
        /// <param name="connData">传进来是字节流</param>
        /// <returns>返回的是完整帧</returns>
        /// <exception cref="NotImplementedException"></exception>
        public void GetFullFrame(ref List<byte> bytes)
        {
            if (bytes == null || bytes.Count <= 0)
                return;
            byte[] buff = bytes?.ToArray();
            try
            {
                int first = 0, second = 0;
                while (bytes.Count >= Math.Min(minRespFrameLength, minTarFrameLength))
                {
                    first = Array.IndexOf(buff, HEAD_TY0);
                    second = Array.IndexOf(buff, HEAD_TY1);
                    if ((first < 0 && second < 0) || (first < 0 && second >= 0 && (buff.Length - 1) != second) || (first >= 0 && second < 0 && (buff.Length - 1) != first))
                    {
                        Array.Resize(ref buff, 0);
                        bytes = buff.ToList();
                        return;
                    }
                    else if ((first < 0 && second >= 0 && (buff.Length - 1) == second) || (first >= 0 && second < 0 && (buff.Length - 1) == first))
                    {
                        bytes = buff.ToList();
                        return;
                    }
                    if (second < 0)
                    {
                        bytes = buff.ToList();
                        return;
                    }
                    if (second - first == 1)//目标帧
                    {
                        buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                        if (buff.Length < 4)
                        {
                            bytes = buff.ToList();
                            return;
                        }

                        int dataModelTotalLen = BitConverter.ToUInt16(buff, 2);// (buff[2] << 8) + buff[3];//数据模块字节长度
                        if (buff.Length < dataModelTotalLen + 5)//列表长度必须大于一帧长度
                        {
                            bytes = buff.ToList();
                            return;
                        }
                        if (buff.Length < 7)//确保能获取到基础信息长度
                        {
                            bytes = buff.ToList();
                            return;
                        }
                        int totalIndex = 4;
                        if (buff[totalIndex] != BASE_DATA_TY0 || buff[totalIndex + 1] != BASE_DATA_TY1 || buff[4 + dataModelTotalLen] != PubClass.GetCheckSum(buff, 4, dataModelTotalLen))//总校验和基础信息模块头需相等
                        {
                            first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                            continue;
                        }

                        int dataBaseLen = buff[totalIndex + 2];//整个基本信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                        byte[] baseData = buff.Skip(4).Take(dataBaseLen).ToArray();
                        int baseIndex = 3;//基础模块信息
                        int dataStatus = baseData[baseIndex];
                        baseIndex++;
                        int TarNum = baseData[baseIndex]; //目标数量
                        baseIndex += 1;
                        int perTarByteNum = baseData[baseIndex];//每个目标信息字节数
                        baseIndex++;
                        int tarLenForBaseData = ((TarNum == 0 || perTarByteNum == 0) ? 0 : TarNum * perTarByteNum + 5);
                        int year = baseData[baseIndex];//年份偏移值
                        baseIndex++;
                        int month = baseData[baseIndex];//月
                        baseIndex++;
                        int day = baseData[baseIndex];//日
                        baseIndex++;
                        int hour = baseData[baseIndex];//时
                        baseIndex++;
                        int minutes = baseData[baseIndex];//分
                        baseIndex++;
                        int seconds = baseData[baseIndex];//秒
                        baseIndex++;
                        int millSeconds = BitConverter.ToUInt16(baseData, baseIndex);//(baseData[baseIndex] << 8) + baseData[baseIndex + 1];//毫秒
                        baseIndex += 2;
                        string time = $"{1900 + year}-{month.ToString().PadLeft(2, '0')}-{day.ToString().PadLeft(2, '0')} {hour.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}.{millSeconds.ToString().PadLeft(3, '0')}";
                        int deviceFlag = BitConverter.ToUInt16(baseData, baseIndex);//设备标识
                        baseIndex += 2;
                        int clusterNum = BitConverter.ToUInt16(baseData, baseIndex); //BitConverter.ToInt32(baseData.Skip(baseIndex).Take(4).ToArray(), 0);//点云数量
                        baseIndex += 2;
                        int perTarByteNumCluster = baseData[baseIndex];//每个点云信息字节数
                        baseIndex += 1;
                        int clusterLenForBaseData = ((clusterNum == 0 || perTarByteNumCluster == 0) ? 0 : clusterNum * perTarByteNumCluster + 5);
                        byte baseDataCheck = baseData[baseIndex];
                        baseIndex++;
                        int dataTotalLength = dataBaseLen + tarLenForBaseData + clusterLenForBaseData;

                        if (dataTotalLength != dataModelTotalLen || baseDataCheck != PubClass.GetCheckSum(baseData, 0, dataBaseLen - 1))//总数据长度和基础模块算出来的长度需相等且基础模块校验通过
                        {
                            first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                            continue;
                        }
                        totalIndex += dataBaseLen;//总下标
                        if (TarNum * perTarByteNum > 0)//表示有目标模块
                        {
                            if (buff[totalIndex] != TAR_DATA_TY0 || buff[totalIndex + 1] != TAR_DATA_TY1)
                            {
                                first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            int tarBaseLen = BitConverter.ToUInt16(buff, totalIndex + 2);//整个目标信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                            byte[] tarBaseData = buff.Skip(totalIndex).Take(tarBaseLen).ToArray();
                            if (tarLenForBaseData != tarBaseLen || tarBaseData[tarBaseLen - 1] != PubClass.GetCheckSum(tarBaseData, 0, tarBaseLen - 1))
                            {
                                first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            totalIndex += tarBaseLen;
                        }

                        if (clusterNum * perTarByteNumCluster > 0)//表示有点云模块
                        {
                            if (buff[totalIndex] != CLUSTER_DATA_TY0 || buff[totalIndex + 1] != CLUSTER_DATA_TY1)
                            {
                                first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            int clusterBaseLen = BitConverter.ToUInt16(buff, totalIndex + 2);//整个点云信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                            byte[] clusterBaseData = buff.Skip(totalIndex).Take(clusterBaseLen).ToArray();
                            if (clusterLenForBaseData != clusterBaseLen || clusterBaseData[clusterBaseLen - 1] != PubClass.GetCheckSum(clusterBaseData, 0, clusterBaseLen - 1))
                            {
                                first = Array.IndexOf(buff, HEAD_TY0, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            totalIndex += clusterBaseLen;
                        }
                        totalIndex++;
                        byte[] result = new byte[totalIndex];
                        Array.Copy(buff, 0, result, 0, totalIndex);
                        buff = buff.Skip(result.Length).Take(buff.Length - result.Length).ToArray();
                        bytes = buff.ToList();
                        handleData(0, result);
                    }
                    else if (second - first == -1)//回复帧
                    {
                        buff = buff.Skip(second).Take(buff.Length - second).ToArray();//跳过前面无用的字节
                        if (buff.Length < 4)
                        {
                            bytes = buff.ToList();
                            return;
                        }
                        //获取参数回复帧帧头
                        if (buff[0] != HEAD_TY1 || buff[1] != HEAD_TY0)
                        {
                            first = Array.IndexOf(buff, HEAD_TY1, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                        }

                        if (buff.Length < minRespFrameLength)
                        {
                            bytes = buff.ToList();
                            return;
                        }
                        UInt32 size = BitConverter.ToUInt32(buff, 20);
                        if (buff.Length < (minRespFrameLength + size))
                        {
                            bytes = buff.ToList();
                            return;
                        }
                        byte[] result = new byte[minRespFrameLength + size];
                        Array.Copy(buff, 0, result, 0, minRespFrameLength + size);
                        buff = buff.Skip(result.Length).Take(buff.Length - result.Length).ToArray();
                        bytes = buff.ToList();
                        handleData(1, result);
                    }
                    else if (first >= 0 && second >= 0 && Math.Abs(first - second) > 1)//防止查到下标相差大的两个头字节
                    {
                        int index = first > second ? second : first;
                        buff = buff.Skip(index + 1).Take(buff.Length - index).ToArray();
                    }
                    else
                    {
                        first = Array.IndexOf(buff, HEAD_TY1, first + 1);
                        if (first < 0)
                        {
                            Array.Resize(ref buff, 0);
                            bytes = buff.ToList();
                            return;
                        }
                        buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Error($"Protocol_UCM211_Bytes GetFullFrame Ex\r\n{ex.ToString()}");
            }
        }


        public void handleData(int type, byte[] bytes)
        {

            try
            {
                if (type == 0)//目标帧
                {
                    if (bytes == null || bytes.Length < minTarFrameLength || bytes[0] != HEAD_TY0 || bytes[1] != HEAD_TY1)
                        return;
                    //Console.WriteLine(BitConverter.ToString(bytes));
                    radarTarList.Clear();
                    radarClusterList.Clear();
                    int index = 2;//从帧数据总长度开始
                    int totalLen = BitConverter.ToUInt16(bytes, index); //帧数据总长度
                    index += 2;
                    index += 2;//基础模块帧头跳过
                    int baseModelLen = bytes[index];
                    index++;
                    int dataStatus = bytes[index];
                    index++;
                    int TarNum = bytes[index];//目标数量
                    index += 1;
                    int perTarByteNum = bytes[index];//每个目标信息字节数
                    index++;
                    int tarLenForBaseData = ((TarNum > 0 || perTarByteNum == 0) ? TarNum * perTarByteNum + 5 : 0);
                    int year = bytes[index];//年份偏移值
                    index++;
                    int month = bytes[index];//月
                    index++;
                    int day = bytes[index];//日
                    index++;
                    int hour = bytes[index];//时
                    index++;
                    int minutes = bytes[index];//分
                    index++;
                    int seconds = bytes[index];//秒
                    index++;
                    int millSeconds = BitConverter.ToUInt16(bytes, index);//毫秒
                    index += 2;
                    string time = SystemSetting.GetTimeType == 1 ? $"{1900 + year}-{month.ToString().PadLeft(2, '0')}-{day.ToString().PadLeft(2, '0')} {hour.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}.{millSeconds.ToString().PadLeft(3, '0')}" : DateTime.Now.ToString(PubClass.timeFormat);
                    int deviceFlag = BitConverter.ToUInt16(bytes, index);//设备标识
                    index += 2;
                    int clusterNum = BitConverter.ToUInt16(bytes, index);//点云数量
                    index += 2;
                    int perTarByteNumCluster = bytes[index];//每个点云信息字节数
                    index++;
                    int clusterLenForBaseData = ((clusterNum == 0 || perTarByteNumCluster == 0) ? clusterNum * perTarByteNumCluster + 5 : 0);
                    byte baseDataCheck = bytes[index];
                    index++;
                    List<TrackData> trackList = new List<TrackData>();
                    if (TarNum * perTarByteNum > 0)
                    {
                        index += 2;//跳过目标帧帧头；
                        int tarModelLen = BitConverter.ToUInt16(bytes, index); //目标总数据长度
                        index += 2;
                        for (int i = 0; i < TarNum; i++)
                        {
                            byte idLower = bytes[index];//目标ID低字节
                            index++;
                            int tarType = bytes[index] & 0x0F;//目标类型 低4位
                            int tarConfidence = ((bytes[index] >> 4) & 0x0F) * 10;//目标置信度  高4位
                            index++;
                            double tarX = PubClass.Bit21ToInt(((bytes[index + 2] & 0x1F) << 16) + (bytes[index + 1] << 8) + bytes[index]) * 0.01d;//单位m
                            index += 2;
                            double tarY = PubClass.Bit21ToInt(((bytes[index + 3] & 0x03) << 19) + (bytes[index + 2] << 11) + (bytes[index + 1] << 3) + ((bytes[index] >> 5) & 0x07)) * 0.01d;
                            index += 3;
                            double tarZ = PubClass.Bit21ToInt(((bytes[index + 2] & 0x7F) << 14) + (bytes[index + 1] << 6) + ((bytes[index] >> 2) & 0x3F)) * 0.01d;
                            index += 3;
                            double tarV = BitConverter.ToInt16(bytes, index) * 0.01d;//速度单位m/s
                            index += 2;
                            double tarAccele = PubClass.BitNumToInt(((bytes[index + 1] & 0x0F) << 8) + bytes[index], 12) * 0.01d;//加速度单位m/s²
                            index++;
                            uint tarId = (uint)(((bytes[index] >> 4) & 0x0F) << 8) + idLower;//目标ID 由该字节的高4位和第一个字节组成
                            index++;
                            double range = Math.Sqrt(tarX * tarX + tarY * tarY + tarZ * tarZ);
                            double pAngle = Math.Atan(tarX / tarY) * 180d / Math.PI;
                            double tAngle = Math.Atan(tarZ / Math.Sqrt(tarX * tarX + tarY * tarY)) * 180d / Math.PI;
                            radarTarList.Add(new TargetInfo.RadarTargetInfoStruct()
                            {
                                ID = tarId,
                                Class = tarType,
                                Confidence = tarConfidence,
                                Range = range,
                                XAxis = tarX,
                                YAxis = tarY,
                                ZAxis = tarZ,
                                PAngle = Math.Abs(pAngle) < PubClass.ε ? 0 : pAngle,
                                TAngle = Math.Abs(tAngle) < PubClass.ε ? 0 : tAngle,
                                Velocity = tarV,
                                RadarAcc = tarAccele,
                                SaveTime = time
                            });
                            trackList.Add(new TrackData()
                            {
                                TarID = tarId,
                                TarClass = tarType,
                                Confidence = tarConfidence,
                                X = tarX,
                                Y = tarY,
                                Z = tarZ,
                                Velocity = tarV,
                                Acc = tarAccele,
                            });
                        }
                        byte tarModelCheck = bytes[index];
                        index++;
                    }
                    List<PointCloudData> pointList = new List<PointCloudData>();
                    if (clusterNum * perTarByteNumCluster > 0)
                    {
                        index += 2;//跳过点云模块帧头；
                        int clusterModelLen = BitConverter.ToUInt16(bytes, index); //点云模块总数据长度
                        index += 2;
                        for (int i = 0; i < clusterNum; i++)
                        {
                            uint clusterId = BitConverter.ToUInt16(bytes, index);//目标ID
                            index += 2;
                            float clusterDistance = BitConverter.ToSingle(bytes, index);//Console.WriteLine($"Range:{clusterDistance:F3}");
                            index += 4;
                            byte clusterSNR = bytes[index];
                            index += 2;
                            double clusterAzimuth = BitConverter.ToInt16(bytes, index) * 0.01d;//方位角  单位弧度
                            double Azimuth = clusterAzimuth * Math.PI / 180d;//方位角度
                            index += 2;
                            double clusterPitch = BitConverter.ToInt16(bytes, index) * 0.01d;//俯仰角   单位弧度
                            double Pitch = clusterAzimuth * Math.PI / 180d;//俯仰角度
                            index += 2;
                            double clusterV = BitConverter.ToInt16(bytes, index) * 0.01d;//速度单位m/s
                            index += 2;
                            double z = clusterDistance * Math.Sin(clusterPitch);//clusterDistance * Math.Sin(clusterPitch / Math.PI * 180d);
                            double xy = clusterDistance * Math.Cos(clusterPitch);// clusterDistance * Math.Cos(clusterPitch / Math.PI * 180d);
                            double x = xy * Math.Sin(clusterAzimuth);// xy * Math.Sin(clusterAzimuth / Math.PI * 180d);
                            double y = xy * Math.Cos(clusterAzimuth);// xy * Math.Cos(clusterAzimuth / Math.PI * 180d);
                            if (y < 0)
                            {
                                Log.Debug($"Protocol_UCM211_Bytes Exist y less than 0--{i}--Data:{BitConverter.ToString(bytes)}");
                            }
                            radarClusterList.Add(new TargetInfo.RadarTargetInfoStruct()
                            {
                                ID = clusterId,
                                Range = clusterDistance,
                                XAxis = Math.Abs(x) < PubClass.ε ? 0 : x,
                                YAxis = Math.Abs(y) < PubClass.ε ? 0 : y,
                                ZAxis = Math.Abs(z) < PubClass.ε ? 0 : z,
                                PAngle = Math.Abs(Azimuth) < PubClass.ε ? 0 : Azimuth,//传的角度
                                TAngle = Math.Abs(Pitch) < PubClass.ε ? 0 : Pitch,
                                SNR = clusterSNR,
                                Velocity = clusterV,
                                SaveTime = time
                            });
                            pointList.Add(new PointCloudData()
                            {
                                Range = clusterDistance,
                                Azimuth = clusterAzimuth,//传的弧度
                                Elevation = clusterPitch,
                                Velocity = clusterV,
                                SNR = clusterSNR
                            });
                        }
                        byte clusterModelCheck = bytes[index];
                        index++;
                    }
                    byte totalCheck = bytes[index];//总校验和
                    if (simulateData)
                    {
                        radarClusterList.Clear();
                        Random random = new Random();
                        for (int i = 1; i < 1024; i++)
                        {
                            radarClusterList.Add(new TargetInfo.RadarTargetInfoStruct()
                            {
                                ID = 0,
                                XAxis = random.NextDouble() * 20 * (i % 2 == 0 ? -1 : 1),
                                YAxis = random.NextDouble() * 40,
                                ZAxis = random.NextDouble() * 10 * (i % 2 == 0 ? -1 : 1),
                                SaveTime = time
                            });
                        }
                        radarTarList.Clear();
                        if (tarIDtemp % 2 == 0)
                        {
                            radarTarList.Add(new TargetInfo.RadarTargetInfoStruct()
                            {
                                ID = tarIDtemp,
                                XAxis = 0,
                                YAxis = (1 * num) % 100,
                                ZAxis = 1,
                                SaveTime = time
                            });
                        }
                        else
                        {
                            radarTarList.Add(new TargetInfo.RadarTargetInfoStruct()
                            {
                                ID = tarIDtemp,
                                XAxis = 10,
                                YAxis = (1 * num) % 100,
                                ZAxis = 1,
                                SaveTime = time
                            });
                        }
                        num++;
                        if (num % 100 == 0)
                            tarIDtemp = (uint)random.Next(0, 11);
                    }
                    OnTarAndClusterPointCloudEvent(time, radarTarList, radarClusterList);
                    OnPointCloudSaveDataEvent(pointList, trackList);
                }
                else if (type == 1) //回复帧
                {
                    if (bytes == null || bytes.Length < minRespFrameLength || bytes[0] != HEAD_TY1 || bytes[1] != HEAD_TY0)
                        return;
                    try
                    {
                        //命令字
                        byte[] cmdByte;
                        int index = 2;

                        cmdByte = new byte[10];
                        Array.Copy(bytes, index, cmdByte, 0, cmdByte.Length);
                        index += 10;


                        string command = Encoding.ASCII.GetString(cmdByte)?.Replace("\0", "");
                        //返回值
                        int returnValue = BitConverter.ToInt32(bytes, index);
                        index += 4;
                        //标志
                        int flags = BitConverter.ToInt32(bytes, index);
                        index += 4;
                        //内容长度
                        int size = BitConverter.ToInt32(bytes, index);
                        index += 4;
                        byte[] data = null;
                        if (size > 0)
                        {
                            data = new byte[size];
                            Array.Copy(bytes, index, data, 0, data.Length);
                            Log.Debug("Recev Params data:0x" + BitConverter.ToString(data).Replace("-", " 0x"));
                        }
                        if (string.Compare(FuncTYType.getVer.ToString(), command, true) == 0)//版本获取回复
                        {
                            //版本号
                            if (returnValue == 0 && data != null && data.Length > 0)
                                OnVersionEvent(Encoding.ASCII.GetString(data));
                        }
                        OnParamRespDataEvent(command, returnValue, flags, size, data);
                    }
                    catch (Exception _ex)
                    {
                        Log.Error("Respose Delegate Exception\r\n" + _ex);
                    }
                }
            }
            catch (Exception _ex)
            {
                Log.Error("Protocol_UCM211_Bytes Handle Data Ex\r\n" + _ex.ToString());
            }
        }
        #region 模拟数据变量
        bool simulateData = false;
        int num = 0;
        uint tarIDtemp = 0;
        #endregion 模拟数据变量

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
            lock (obj)
                ByteBuffer.AddRange(connData.Datas);
        }
    }
}

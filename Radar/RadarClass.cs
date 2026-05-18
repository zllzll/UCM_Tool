using LogProc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UCM_Tools.CAN_Conn;
using UCM_Tools.Config;
using UCM_Tools.Models;
using UCM_Tools.Radar.Communication;
using UCM_Tools.Radar.Protocols;
using UCM_Tools.Tools;
using ZLGCAN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static UCM_Tools.CAN_Conn.CAN_Function;

namespace UCM_Tools.Radar
{
    public class RadarClass
    {
        private static object obj = new object();

        /// <summary>
        /// 处理线程
        /// </summary>
        Thread handleThread;
        IConn conn = null;

        public bool _bOpen = false;
        IProtocol radarProtcol = null;
        ConcurrentQueue<ConnData> connDataQueue = new ConcurrentQueue<ConnData>();
        //从start开始
        uint recvFrameNum = 0;
        #region 事件委托
        public delegate void CycleDataDelegate(string time, int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList);
        [method: CompilerGenerated]
        public event CycleDataDelegate cycleDataEvent;

        public void OnIdentifyInfoEvent(string time, int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            if (cycleDataEvent != null)
                cycleDataEvent(time, NumTar, targetInfoList);
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
        public delegate void RadarIDDelegate(int radarId, int freqId);
        [method: CompilerGenerated]
        public event RadarIDDelegate radarIdEvent;
        public void OnRadarIDEvent(int radarId, int freqId)
        {
            if (radarIdEvent != null)
                radarIdEvent(radarId, freqId);
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
        /// <summary>
        /// 连接状态变更委托（用于自动重连通知）
        /// </summary>
        public delegate void ConnectStatusChangedDelegate(bool isConnected, ConnState message);
        [method: CompilerGenerated]
        public event ConnectStatusChangedDelegate connectStatusChangedEvent;
        public void OnConnectStatusChanged(bool isConnected, ConnState message)
        {
            if (connectStatusChangedEvent != null)
                connectStatusChangedEvent(isConnected, message);
        }
        /// <summary>
        /// 数据帧委托
        /// </summary>
        public delegate void FrameDelegate(uint frameId, byte[] frameData);
        [method: CompilerGenerated]
        public event FrameDelegate frameEvent;
        public void OnFrameEvent(uint frameId, byte[] frameData)
        {
            if (frameEvent != null)
                frameEvent(frameId, frameData);
        }

        /// <summary>
        /// 周期内点云和跟踪目标委托
        /// </summary>
        public delegate void TarAndClusterPointCloud(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList);
        [method: CompilerGenerated]
        public event TarAndClusterPointCloud tarAndClusterPointCloud;
        public void OnTarAndClusterPointCloudEvent(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList)
        {
            if (tarAndClusterPointCloud != null)
                tarAndClusterPointCloud(time,targetInfoList, clusterInfoList);
        }

        /// <summary>
        /// UCM211参数回复委托
        /// </summary>
        public delegate void ParamRespDataDeleagte(string function, int resultValue, int flag, int size, byte[] bytes);
        [method: CompilerGenerated]
        public event ParamRespDataDeleagte paramRespDataEvent;
        public void OnParamRespDataEvent(string function, int resultValue, int flag, int size, byte[] bytes)
        {
            if (paramRespDataEvent != null)
                paramRespDataEvent(function, resultValue, flag, size, bytes);
        }

        /// <summary>
        /// 点云保存数据委托
        /// </summary>
        public delegate void PointCloudSaveDataDeleagte(uint frame,List<PointCloudData> list, List<TrackData> trackList);
        [method: CompilerGenerated]
        public event PointCloudSaveDataDeleagte pointCloudSaveEvent;
        public void OnPointCloudSaveDataEvent(uint frame,List<PointCloudData> list, List<TrackData> trackList)
        {
            if (pointCloudSaveEvent != null)
                pointCloudSaveEvent(frame,list,trackList);
        }
        /// <summary>
        /// ImuAndGpsData保存数据委托
        /// </summary>
        public delegate void ImuAndGpsSaveDataDeleagte(string time, IMUAndGPSData imuAndGpsData);
        [method: CompilerGenerated]
        public event ImuAndGpsSaveDataDeleagte imuAndGpsSaveEvent;
        public void OnImuAndGpsSaveDataEvent(string time, IMUAndGPSData imuAndGpsData)
        {
            if (imuAndGpsSaveEvent != null && imuAndGpsData != null)
                imuAndGpsSaveEvent(time, imuAndGpsData);
        }
        #endregion 事件委托

        public async Task<bool> Start(string name,string connType)
        {
            string proStr = $"{name}_{connType}"; 
            string connStr = string.Compare(SystemSetting.ConnType, "CAN", true) == 0 ? "CANFD" : SystemSetting.ConnType;//暂时CAN和CANFD用同一个通讯类，后续有改动再说
            conn = ProtocolManage.InitConn(connStr);
            radarProtcol = ProtocolManage.InitProtocol(ConfigImpl.getConfigProperties(proStr));
            if(conn==null || radarProtcol==null)
            {
                Log.Error($"{proStr}不支持");
                return false;
            }
            recvFrameNum = 0;
            conn.connParams = new ConnParams()
            {
                ConnType = SystemSetting.ConnType,
                COM_No = SystemSetting.COM_No,
                COM_Baud = SystemSetting.COM_Baud,
                COM_Parity = SystemSetting.COM_Parity,
                COM_DataBit = SystemSetting.COM_DataBit,
                COM_StopBit = SystemSetting.COM_StopBit,
                Zlg_Type = SystemSetting.Zlg_Type,
                CAN_Company = SystemSetting.CAN_Company,
                Zlg_CAN_Type = SystemSetting.Zlg_CAN_Type,
                CAN_Index = SystemSetting.CAN_Index,
                CAN_Channel = SystemSetting.CAN_Channel,
                CAN_WorkMode = SystemSetting.WorkMode,
                CANFD_Standard = SystemSetting.CANFD_Standard,
                CANFD_Baud_Abit = SystemSetting.CANFD_Baud_Abit,
                CANFD_Baud_Dbit = SystemSetting.CANFD_Baud_Dbit,
                CAN_Baud = SystemSetting.CAN_Baud,
                IP = SystemSetting.TCP_IP,
                Port = SystemSetting.TCP_Port
            };
            if (!await conn.OpenDevice())
                return false;
            conn.OnRecvConnDataEvent += Conn_OnRecvConnDataEvent;
            conn.OnConnectStatusChanged += OnConnectStatusChanged;
            _bOpen = true;
            radarProtcol.cycleDataEvent += RadarProtcol_cycleDataEvent;
            radarProtcol.versionEvent += RadarProtcol_versionEvent;
            radarProtcol.hardwareIdEvent += RadarProtcol_hardwareIdEvent;
            radarProtcol.keyIdRespEvent += RadarProtcol_keyIdRespEvent;
            radarProtcol.aliveStatusEvent += RadarProtcol_aliveStatusEvent;
            radarProtcol.radarIdEvent += RadarProtcol_radarIdEvent;
            radarProtcol.frameEvent += RadarProtcol_frameEvent;
            radarProtcol.tarAndClusterPointCloud += RadarProtcol_tarAndClusterPointCloud;
            radarProtcol.paramRespDataEvent += RadarProtcol_paramRespDataEvent;
            radarProtcol.pointCloudSaveDataEvent += RadarProtcol_pointCloudSaveDataEvent;
            handleThread = new Thread(new ThreadStart(HandleRecvData));
            handleThread.IsBackground = true;
            handleThread.Start();
            return true;
        }

        private void RadarProtcol_pointCloudSaveDataEvent(List<PointCloudData> list, List<TrackData> trackList)
        {
            recvFrameNum++;
            OnPointCloudSaveDataEvent(recvFrameNum, list, trackList);
        }

        private void RadarProtcol_paramRespDataEvent(string function, int resultValue, int flag, int size, byte[] bytes)
        {
            OnParamRespDataEvent(function, resultValue, flag, size, bytes);
        }

        private void RadarProtcol_tarAndClusterPointCloud(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList, IMUAndGPSData imuAndGpsData = null)
        {
            OnTarAndClusterPointCloudEvent(time,targetInfoList, clusterInfoList);
            OnImuAndGpsSaveDataEvent(time, imuAndGpsData);
        }

        private void RadarProtcol_frameEvent(uint frameId, byte[] frameData)
        {
            OnFrameEvent(frameId, frameData);
        }

        private void RadarProtcol_radarIdEvent(int radarId, int freqId)
        {
            OnRadarIDEvent(radarId, freqId);
        }

        private void RadarProtcol_aliveStatusEvent(bool alive)
        {
            OnAliveStatusEvent(alive);
        }

        private void RadarProtcol_keyIdRespEvent(bool success)
        {
            OnKeyIDRespEvent(success);
        }

        private void RadarProtcol_hardwareIdEvent(byte[] hardwareId)
        {
            OnHardwareIDEvent(hardwareId);
        }

        private void RadarProtcol_cycleDataEvent(string time, int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            OnIdentifyInfoEvent(time, NumTar, targetInfoList);
        }

        private void RadarProtcol_versionEvent(string version)
        {
            OnVersionEvent(version);
        }

        #region 接收数据
        private void Conn_OnRecvConnDataEvent(ConnData connDataList)
        {
            connDataQueue.Enqueue(connDataList);
        }
        #endregion 接收数据

        #region 处理数据
        private void HandleRecvData()
        {
            //List<byte> byteBuffer = new List<byte>();
            try
            {
                while (_bOpen)
                {
                    
                    if (connDataQueue.TryDequeue(out var connData))
                    {
                        //Console.WriteLine($"雷达类：{BitConverter.ToString(connData.Datas.ToArray())}");
                        radarProtcol.AddDataList(connData);
                    }
                    else
                        Thread.Sleep(1);
                   
                }

            }
            catch (Exception _ex)
            {
                Log.Error("处理接收数据线程异常\r\n" + _ex.ToString());
            }
        }
        #endregion 处理数据
        public void Stop()
        {
            //关闭线程
            _bOpen = false;

            if (handleThread != null)
            {
                try
                {
                    handleThread.Abort();
                }
                catch { }
                handleThread = null;
            }
            if (radarProtcol != null)
            {
                radarProtcol.cycleDataEvent -= RadarProtcol_cycleDataEvent;
                radarProtcol.versionEvent -= RadarProtcol_versionEvent;
                radarProtcol.hardwareIdEvent -= RadarProtcol_hardwareIdEvent;
                radarProtcol.keyIdRespEvent -= RadarProtcol_keyIdRespEvent;
                radarProtcol.aliveStatusEvent -= RadarProtcol_aliveStatusEvent;
                radarProtcol.radarIdEvent -= RadarProtcol_radarIdEvent;
                radarProtcol.frameEvent -= RadarProtcol_frameEvent;
                radarProtcol.tarAndClusterPointCloud -= RadarProtcol_tarAndClusterPointCloud;
                radarProtcol.paramRespDataEvent -= RadarProtcol_paramRespDataEvent;
                radarProtcol.pointCloudSaveDataEvent -= RadarProtcol_pointCloudSaveDataEvent;
                radarProtcol.Dispose();
                radarProtcol = null;
            }

            //关闭设备
            if (conn != null)
            {
                conn.OnRecvConnDataEvent -= Conn_OnRecvConnDataEvent;
                conn.OnConnectStatusChanged -= OnConnectStatusChanged;
                conn.CloseDevice();
            }
            conn = null;

        }

        public void SendCmd(RadarCommand cmd, byte[] data = null, bool addRadarId = true)
        {
            if (conn == null || radarProtcol == null || !_bOpen)
                return;
            ConnData frame = radarProtcol.PackFrame(cmd, data, addRadarId);
            if (frame == null)
                return;
            conn.SendCmd(frame);
        }
    }

}

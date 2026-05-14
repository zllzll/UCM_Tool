using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UCM_Tools.Models;
using UCM_Tools.Tools;
using ZLGCAN;

namespace UCM_Tools.Radar.Protocols
{
    public abstract class IProtocol
    {
        public uint radarId = 0;
        #region 委托
        /// <summary>
        /// 周期内点云目标委托
        /// </summary>
        public delegate void CyclePointCloud(int tarNum, List<TargetInfo.RadarTargetInfoStruct> targetInfoList);
        [method: CompilerGenerated]
        public static event CyclePointCloud cyclePointCloud;
        public void OnCyclePointCloudEvent(int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            if (cyclePointCloud != null)
                cyclePointCloud(NumTar, targetInfoList);
        }

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
        public delegate void TarAndClusterPointCloud(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList, IMUAndGPSData imuAndGpsData = null);
        [method: CompilerGenerated]
        public event TarAndClusterPointCloud tarAndClusterPointCloud;
        public void OnTarAndClusterPointCloudEvent(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList, IMUAndGPSData imuAndGpsData = null)
        {
            if (tarAndClusterPointCloud != null)
                tarAndClusterPointCloud(time,targetInfoList, clusterInfoList, imuAndGpsData);
        }
        /// <summary>
        /// UCM211参数回复委托
        /// </summary>
        public delegate void ParamRespDataDeleagte(string function, int resultValue, int flag, int size, byte[] bytes);
        [method: CompilerGenerated]
        public event ParamRespDataDeleagte paramRespDataEvent;
        public void OnParamRespDataEvent(string function, int resultValue,int flag,int size, byte[] bytes)
        {
            if (paramRespDataEvent != null)
                paramRespDataEvent(function, resultValue, flag, size, bytes);
        }

        /// <summary>
        /// 点云保存数据委托
        /// </summary>
        public delegate void PointCloudSaveDataDeleagte(List<PointCloudData> list, List<TrackData> trackList);
        [method: CompilerGenerated]
        public event PointCloudSaveDataDeleagte pointCloudSaveDataEvent;
        public void OnPointCloudSaveDataEvent(List<PointCloudData> list, List<TrackData> trackList)
        {
            if (pointCloudSaveDataEvent != null)
                pointCloudSaveDataEvent(list, trackList);
        }
        #endregion  委托
        /// <summary>
        /// 当前显示目标的对应60A的目标数量值
        /// </summary>
        public int curTarNum = 0;
        public DateTime lastTime = DateTime.Now;
        /// <summary>
        /// 当前显示目标列表
        /// </summary>
        public List<TargetInfo.RadarTargetInfoStruct> radarTarList = new List<TargetInfo.RadarTargetInfoStruct>();
        /// <summary>
        /// 当前显示点云目标列表
        /// </summary>
        public List<TargetInfo.RadarTargetInfoStruct> radarClusterList = new List<TargetInfo.RadarTargetInfoStruct>();

        public abstract ConnData PackFrame(RadarCommand cmd, byte[] bytes = null, bool addRadarId = false);

        public abstract void AddDataList(ConnData connData);

        public abstract void Dispose();
    }
    
}

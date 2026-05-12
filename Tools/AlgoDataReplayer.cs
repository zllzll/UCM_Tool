using LogProc;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UCM_Tools.Tools
{
    public class ReplayFrameData
    {
        public string FilePath = string.Empty;
        public List<TargetInfo.RadarTargetInfoStruct> ReplayTargets = new List<TargetInfo.RadarTargetInfoStruct>();
    }
    public class AlgoDataReplayer
    {
        private int queueMaxCount = 100;//队列最大数
        private int millSecondsCycle = 25;//帧周期毫秒数
        private readonly string _folderPath; // 存储文件的文件夹路径
        private readonly string _periodStartString = "";//周期开始行字符串
        private ConcurrentQueue<ReplayPeriodData> _dataQueue; // 用于存储已读取的周期数据
        private CancellationTokenSource _cancellationTokenSource;
        private bool _readFinish = false;
        private ManualResetEventSlim _playSignal = new ManualResetEventSlim(true); // true=运行, false=暂停
        private volatile bool _isPaused = false;
        /// <summary>
        /// 周期内点云和跟踪目标委托
        /// </summary>
        public delegate void TarAndClusterPointCloud(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList);
        [method: CompilerGenerated]
        public event TarAndClusterPointCloud tarAndClusterPointCloud;
        public void OnTarAndClusterPointCloudEvent(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList)
        {
            if (tarAndClusterPointCloud != null)
                tarAndClusterPointCloud(time, targetInfoList, clusterInfoList);
        }

        /// <summary>
        /// 回放状态委托
        /// </summary>
        public delegate void ReplayerStatus(int state,string msg);
        [method: CompilerGenerated]
        public event ReplayerStatus replayerStatus;
        public void OnReplayerStatus(int state, string msg)
        {
            if (replayerStatus != null)
                replayerStatus(state,msg);
        }
        public AlgoDataReplayer(string folderPath,string periodStartString,int frameCycle)
        {
            _folderPath = folderPath;
            _periodStartString = periodStartString;
            _dataQueue = new ConcurrentQueue<ReplayPeriodData>();
            _readFinish = false;
            millSecondsCycle = frameCycle;
        }

        public void StartReplay()
        {
            _readFinish = false;
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            // 线程 1：读取文件并填充队列
            new Thread(() =>
            {
                try
                {
                    if (token.IsCancellationRequested) return;

                    var files = Directory.GetFiles(_folderPath)
                                        .Where(f => Path.GetExtension(f) == ".csv")// && Path.GetFileNameWithoutExtension(f).Contains("ClusterAlogFormat"))
                                        .OrderBy(f => File.GetCreationTime(f))
                                        .ToList();
                    uint frame_id = 0;
                    ReplayPeriodData currentPeriod = null;
                    string time = DateTime.Now.ToString(PubClass.timeFormat);
                    foreach (var file in files)
                    {
                        if (token.IsCancellationRequested) return;
                        
                        using (var reader = new StreamReader(file))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (token.IsCancellationRequested) return;

                                if (line.Contains(_periodStartString))
                                    continue;
                                else
                                {
                                    TargetInfo.RadarTargetInfoStruct? tar = StringToTargetList(time,line,out uint frameID);
                                    if (tar.HasValue && frameID != 0)
                                    {
                                        if(frame_id != 0 && frameID != 0 && frame_id != frameID)
                                        {
                                            _dataQueue.Enqueue(currentPeriod);
                                            // 避免队列过大（每次入队后检查）
                                            while (_dataQueue.Count > 100 && !token.IsCancellationRequested)
                                            {
                                                Thread.Sleep(1); // 等待消费
                                            }
                                            currentPeriod = null;
                                            time = DateTime.Now.ToString(PubClass.timeFormat);
                                        }
                                        if (frame_id == 0 || frame_id != frameID || currentPeriod == null)
                                            currentPeriod = new ReplayPeriodData() { FilePath = file, ReplayTargets = new List<TargetInfo.RadarTargetInfoStruct>() };
                                        if(frameID != 0 && frame_id != frameID)
                                            frame_id = frameID;
                                        currentPeriod.ReplayTargets.Add(tar.Value);
                                    }
                                }
                            }

                            
                        }
                    }
                    if (currentPeriod != null && currentPeriod.ReplayTargets.Count >= 0)
                    {
                        _dataQueue.Enqueue(currentPeriod);
                    }
                    //避免队列过大，占用内存过多
                    // 避免队列过大（每次入队后检查）
                    while (_dataQueue.Count > queueMaxCount && !token.IsCancellationRequested)
                    {
                        Thread.Sleep(1); // 等待消费
                    }

                }
                catch (Exception ex)
                {
                    Log.Error($"AlgoDataDataReplayer ReadFiles Ex\r\n {ex.ToString()}");
                    OnReplayerStatus(2, $"");//文件读取错误
                }
                finally
                {
                    _readFinish = true;
                }
            }).Start();
            //线程 2：从队列中取出数据并回放
            new Thread(() =>
            {
                try
                {
                    var stopwatch = new Stopwatch();
                    string curFile = string.Empty;
                    while (true)
                    {
                        if (_isPaused)
                            curFile = string.Empty;
                        // 等待播放信号（处理暂停/恢复）
                        _playSignal.Wait(_cancellationTokenSource.Token);
                        if (token.IsCancellationRequested) return;

                        if (_dataQueue.TryDequeue(out var period))
                        {
                            if (string.Compare(curFile, period.FilePath, false) != 0)
                            {
                                curFile = period.FilePath;
                                OnReplayerStatus(1, $"{curFile}");//正在回放文件
                            }
                            OnTarAndClusterPointCloudEvent(DateTime.Now.ToString(PubClass.timeFormat), null, period.ReplayTargets.ToList());
                            int millSecond = millSecondsCycle - (int)stopwatch.ElapsedMilliseconds;
                            if (millSecond > 0)
                                Thread.Sleep(millSecond);
                            // 确保每个周期间隔 100ms
                            stopwatch.Restart();
                        }
                        else
                        {
                            if (token.IsCancellationRequested) return;
                            Thread.Sleep(1);
                            if (_readFinish)
                            {
                                OnReplayerStatus(4, $"");//文件回放结束
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"AlgoDataDataReplayer Replay Ex\r\n {ex.ToString()}");
                    OnReplayerStatus(3, $"");//文件回放错误
                }
            }).Start();
        }

        public void StopReplay()
        {
            _cancellationTokenSource?.Cancel();
            _playSignal.Set(); // 确保线程不阻塞
            _isPaused = false;
        }

        /// <summary>
        /// 暂停回放
        /// </summary>
        public void Pause()
        {
            if (!_isPaused)
            {
                _isPaused = true;
                _playSignal.Reset(); // 阻塞回放线程
                OnReplayerStatus(5, "");
            }
        }

        /// <summary>
        /// 恢复回放
        /// </summary>
        public void Resume()
        {
            if (_isPaused)
            {
                _isPaused = false;
                _playSignal.Set(); // 释放回放线程
            }
        }

        private TargetInfo.RadarTargetInfoStruct? StringToTargetList(string time,string line,out uint frameId)
        {
            frameId = 0;
            try
            {
                string[] items = line.Split(',');
                if (items == null || items.Length != 9)
                    return null;
                frameId = Convert.ToUInt32(items[0]);
                double range = Convert.ToDouble(items[1]);
                double azimuth = Convert.ToDouble(items[2]);//水平弧度
                double azimuthAngle = azimuth * Math.PI / 180d;//水平角度
                double elevation = Convert.ToDouble(items[3]);//俯仰弧度
                double elevationAngle = elevation * Math.PI / 180d;//俯仰角度
                double velocity = Convert.ToDouble(items[4]);
                double snr = Convert.ToDouble(items[5]);
                double v_ego_x = Convert.ToDouble(items[6]);
                double v_ego_y = Convert.ToDouble(items[7]);
                double v_ego_z = Convert.ToDouble(items[8]);
                double z = range * Math.Sin(elevation);// Math.Sin(elevation / Math.PI * 180d);
                double xy = range * Math.Cos(elevation); //Math.Cos(elevation / Math.PI * 180d);
                double x = xy * Math.Sin(azimuth);// Math.Sin(azimuth / Math.PI * 180d);
                double y = xy * Math.Cos(azimuth);// Math.Cos(azimuth / Math.PI * 180d);
                return new TargetInfo.RadarTargetInfoStruct()
                {
                    ID = frameId,
                    Range = range,
                    XAxis = Math.Abs(x) < PubClass.ε ? 0 : x,
                    YAxis = Math.Abs(y) < PubClass.ε ? 0 : y,
                    ZAxis = Math.Abs(z) < PubClass.ε ? 0 : z,
                    PAngle = Math.Abs(azimuthAngle) < PubClass.ε ? 0 : azimuthAngle,
                    TAngle = Math.Abs(elevationAngle) < PubClass.ε ? 0 : elevationAngle,
                    SNR = snr,
                    Velocity = velocity,
                    SaveTime = time
                };
                

            }
            catch(Exception ex)
            {
                Log.Error($"StringToTargetList(string line) Ex\r\n {ex.ToString()}");
                return null;
            }
        }
    }
}

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

namespace UCM_Tools.Tools
{
    public class ReplayCycleData
    {
        public string FilePath = string.Empty;
        public List<TargetInfo.RadarTargetInfoStruct> ReplayTargets = new List<TargetInfo.RadarTargetInfoStruct>();
        public List<TargetInfo.RadarTargetInfoStruct> ReplayTracks = new List<TargetInfo.RadarTargetInfoStruct>();
    }
    public class PointTrackDataReplayer
    {
        private int queueMaxCount = 100;//队列最大数
        private int millSecondsCycle = 25;//帧周期毫秒数
        private readonly string _folderPath; // 存储文件的文件夹路径
        private readonly string _periodStartString = "";//周期开始行字符串
        private ConcurrentQueue<ReplayCycleData> _dataQueue; // 用于存储已读取的周期数据
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
        public PointTrackDataReplayer(string folderPath,string periodStartString, int frameCycle)
        {
            _folderPath = folderPath;
            _periodStartString = periodStartString;
            _dataQueue = new ConcurrentQueue<ReplayCycleData>();
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
                                        .Where(f => Path.GetExtension(f) == ".txt")
                                        .OrderBy(f => File.GetCreationTime(f))
                                        .ToList();

                    foreach (var file in files)
                    {
                        int periodNum = 0;
                        if (token.IsCancellationRequested) return;
                        
                        using (var reader = new StreamReader(file))
                        {
                            ReplayCycleData currentPeriod = null;
                            string line;

                            while ((line = reader.ReadLine()) != null)
                            {
                                if (token.IsCancellationRequested) return;

                                if (line.Contains(_periodStartString))
                                {
                                    periodNum++;
                                    if (currentPeriod != null && currentPeriod.ReplayTargets.Count > 0)
                                    {
                                        _dataQueue.Enqueue(currentPeriod);
                                        // 避免队列过大（每次入队后检查）
                                        while (_dataQueue.Count > queueMaxCount && !token.IsCancellationRequested)
                                        {
                                            Thread.Sleep(1); // 等待消费
                                        }

                                    }
                                    currentPeriod = new ReplayCycleData() { FilePath = file, ReplayTargets = new List<TargetInfo.RadarTargetInfoStruct>(), ReplayTracks = new List<TargetInfo.RadarTargetInfoStruct>() };
                                }
                                else
                                {
                                    if (currentPeriod == null)
                                        currentPeriod = new ReplayCycleData { FilePath = file, ReplayTargets = new List<TargetInfo.RadarTargetInfoStruct>(), ReplayTracks = new List<TargetInfo.RadarTargetInfoStruct>() };
                                    string pointOrTrack = string.Empty;
                                    TargetInfo.RadarTargetInfoStruct? tar = StringToTargetList(line,out pointOrTrack);
                                    if (tar.HasValue && !string.IsNullOrEmpty(pointOrTrack))
                                    {
                                        if(string.Compare(pointOrTrack,"Point",false) == 0)
                                            currentPeriod.ReplayTargets.Add(tar.Value);
                                        else if (string.Compare(pointOrTrack, "Track", false) == 0)
                                            currentPeriod.ReplayTracks.Add(tar.Value);
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
                        //Console.WriteLine($"{file} 周期数：{periodNum}");
                    }

                }
                catch (Exception ex)
                {
                    Log.Error($"DataReplayer ReadFiles Ex\r\n {ex.ToString()}");
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

                            OnTarAndClusterPointCloudEvent(DateTime.Now.ToString(PubClass.timeFormat), period.ReplayTargets, period.ReplayTracks);
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
                    Log.Error($"DataReplayer Replay Ex\r\n {ex.ToString()}");
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

        private TargetInfo.RadarTargetInfoStruct? StringToTargetList(string line,out string pointOrTrack)
        {
            pointOrTrack = string.Empty;
            try
            {
                string[] items = line.Split(',');
                if (items == null || items.Length != 14)
                    return null;
                pointOrTrack= items[0].Split("--")[2];
                return new TargetInfo.RadarTargetInfoStruct() 
                {
                    SaveTime = items[0].Split("--")[0],
                    ID = Convert.ToUInt32(items[1].Split('=')[1]),
                    XAxis = Convert.ToDouble(items[2].Split('=')[1]),
                    YAxis = Convert.ToDouble(items[3].Split('=')[1]),
                    ZAxis = Convert.ToDouble(items[4].Split('=')[1]),
                    Velocity = Convert.ToDouble(items[5].Split('=')[1]),
                    RCS = Convert.ToDouble(items[6].Split('=')[1]),
                    Type = (int)Convert.ToDouble(items[7].Split('=')[1]),
                    Class = (int)Convert.ToDouble(items[8].Split('=')[1]),
                    PAngle = Convert.ToDouble(items[9].Split('=')[1]),
                    TAngle = Convert.ToDouble(items[10].Split('=')[1]),
                    SNR = Convert.ToDouble(items[11].Split('=')[1]),
                    Confidence = (int)Convert.ToDouble(items[12].Split('=')[1]),
                    RadarAcc = Convert.ToDouble(items[13].Split('=')[1]),
                };
            }
            catch(Exception ex)
            {
                pointOrTrack = string.Empty;
                Log.Error($"StringToTargetList(string line) Ex\r\n {ex.ToString()}");
                return null;
            }
        }
    }
}

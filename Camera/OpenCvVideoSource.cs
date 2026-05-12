using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCM_Tools.Camera
{
    public class OpenCvVideoSource : IVideoSource
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private volatile bool _isRunning;
        private readonly object _stopLock = new object();
        private readonly string _source;

        // 帧率控制
        private readonly int _targetFps;
        private Stopwatch _fpsWatch = new Stopwatch();
        private long _frameInterval;
        private long _lastFrameTime = 0;

        // 状态跟踪
        private VideoState _currentState = VideoState.Idle;
        private Stopwatch _stateWatch = new Stopwatch();
        private long _frameCount = 0;
        private long _lastFrameCount = 0;
        private double _currentFps = 0;
        private long _lastFpsUpdateTime = 0;

        // 缓冲控制
        private int _bufferTarget = 30;
        private int _bufferCount = 0;

        public event EventHandler<Bitmap> FrameReceived;
        public event EventHandler<bool> ConnectionStatusChanged;
        public event EventHandler<VideoState> StateChanged;

        public bool IsRunning => _isRunning;
        /// <summary>
        /// 是否增加时间戳
        /// </summary>
        private bool _isAddTimestamp = false;
        public bool IsAddTimestamp { get { return _isAddTimestamp; } set { _isAddTimestamp = value; } }
        public string SourceName { get; private set; }
        public System.Drawing.Size FrameSize { get; private set; }
        public VideoState CurrentState => _currentState;
        public double CurrentFps => _currentFps;
        public int BufferProgress => _bufferTarget > 0 ? (_bufferCount * 100 / _bufferTarget) : 0;

        public OpenCvVideoSource(string source, string name = null, int targetFps = 30,bool isAddTimestamp = false)
        {
            _isAddTimestamp = isAddTimestamp;
            _source = source;
            SourceName = name ?? $"Camera-{source}";
            _targetFps = targetFps;
            _frameInterval = 1000 / targetFps;

            // RTSP需要更多缓冲帧
            if (source.StartsWith("rtsp", StringComparison.OrdinalIgnoreCase))
            {
                _bufferTarget = 50; // RTSP缓冲50帧约2秒
            }
            else
            {
                _bufferTarget = 10; // USB缓冲10帧
            }
        }

        public void Start()
        {
            if (_isRunning) return;

            lock (_stopLock)
            {
                ChangeState(VideoState.Connecting);

                Task.Run(() =>
                {
                    try
                    {
                        InitializeCapture();

                        _isRunning = true;
                        _fpsWatch.Restart();
                        _stateWatch.Restart();

                        _captureThread = new Thread(CaptureLoop)
                        {
                            IsBackground = true,
                            Name = "OpenCvCaptureThread"
                        };
                        _captureThread.Start();

                        ConnectionStatusChanged?.Invoke(this, true);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"启动失败: {ex.Message}");
                        ChangeState(VideoState.Error);
                        ConnectionStatusChanged?.Invoke(this, false);
                        Cleanup();
                    }
                });
            }
        }

        private void InitializeCapture()
        {
            bool isUsb = int.TryParse(_source, out int index);

            // RTSP使用FFmpeg后端，USB使用DirectShow
            if (!isUsb)
            {
                ChangeState(VideoState.Connecting);
                _capture = new VideoCapture(_source, VideoCaptureAPIs.FFMPEG);

                if (!_capture.IsOpened())
                {
                    // 备用：尝试自动检测后端
                    _capture = new VideoCapture(_source, VideoCaptureAPIs.ANY);
                }
            }
            else
            {
                _capture = new VideoCapture(index, VideoCaptureAPIs.DSHOW);
            }

            if (!_capture.IsOpened())
            {
                throw new ArgumentException($"无法打开视频源: {_source}");
            }

            ConfigureCapture();
            ReadFrameSize();

            Debug.WriteLine($"✅ 视频源初始化成功: {FrameSize.Width}x{FrameSize.Height}");
        }

        private void ConfigureCapture()
        {
            _capture.Set(VideoCaptureProperties.BufferSize, 1);
            _capture.Set(VideoCaptureProperties.FrameWidth, 1280);
            _capture.Set(VideoCaptureProperties.FrameHeight, 720);
            _capture.Set(VideoCaptureProperties.Fps, _targetFps);

            // RTSP优化
            if (_source.StartsWith("rtsp", StringComparison.OrdinalIgnoreCase))
            {
                _capture.Set(VideoCaptureProperties.PosFrames, 0);
            }

            ReadFrameSize();
        }

        private void ReadFrameSize()
        {
            int width = (int)_capture.Get(VideoCaptureProperties.FrameWidth);
            int height = (int)_capture.Get(VideoCaptureProperties.FrameHeight);
            FrameSize = new System.Drawing.Size(Math.Max(width, 0), Math.Max(height, 0));
        }
        private void CaptureLoop()
        {
            while (_isRunning)
            {
                // 帧率控制
                long currentTime = _fpsWatch.ElapsedMilliseconds;
                if (currentTime - _lastFrameTime < _frameInterval)
                {
                    Thread.Sleep(1);
                    continue;
                }

                using (Mat mat = new Mat())
                {
                    if (_capture == null || !_capture.Read(mat) || mat.Empty())
                    {
                        Debug.WriteLine($"Read Frame Failed (FrameID: {_frameCount})");
                        ChangeState(VideoState.Error);
                        Thread.Sleep(10);
                        continue;
                    }

                    _lastFrameTime = currentTime;
                    _frameCount++;

                    // 计算实时FPS
                    UpdateFps(currentTime);
                    // 添加时间戳（关键修改）
                    if (_isAddTimestamp)
                    {
                        DrawTimestamp(mat);
                    }
                    // 缓冲阶段检测
                    if (_bufferCount < _bufferTarget)
                    {
                        _bufferCount++;
                        ChangeState(VideoState.Buffering);
                        Debug.WriteLine($"缓冲进度: {BufferProgress}% ({_bufferCount}/{_bufferTarget})");
                        continue; // 不显示缓冲帧
                    }

                    // 缓冲完成后切换到播放状态
                    if (_currentState != VideoState.Playing)
                    {
                        ChangeState(VideoState.Playing);
                    }

                    // 转换并发送帧
                    using (Bitmap tempBitmap = ConvertMatToBitmap(mat))
                    {
                        if (tempBitmap != null && _isRunning)
                        {
                            Bitmap clonedBitmap = new Bitmap(tempBitmap);

                            BeginInvokeOnUI(() =>
                            {
                                if (_isRunning)
                                {
                                    FrameReceived?.Invoke(this, clonedBitmap);
                                }
                                else
                                {
                                    clonedBitmap?.Dispose();
                                }
                            });
                        }
                    }
                }
            }

            Cleanup();
        }

        private void UpdateFps(long currentTime)
        {
            if (currentTime - _lastFpsUpdateTime >= 1000)
            {
                _currentFps = _frameCount - _lastFrameCount;
                _lastFrameCount = _frameCount;
                _lastFpsUpdateTime = currentTime;
            }
        }

        // 添加时间戳绘制方法
        private void DrawTimestamp(Mat mat)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                // ✅ 修改：计算文字尺寸，精确定位到右上角
                var textSize = Cv2.GetTextSize(timestamp, HersheyFonts.HersheySimplex, 0.7, 2, out int baseline);
                int margin = 10;
                var point = new OpenCvSharp.Point(mat.Cols - textSize.Width - margin, textSize.Height + margin);

                // 黑色描边增强可读性
                Cv2.PutText(mat, timestamp, new OpenCvSharp.Point(point.X + 1, point.Y + 1),
                    HersheyFonts.HersheySimplex, 0.7, Scalar.Black, 3);
                // 绿色文字
                Cv2.PutText(mat, timestamp, point, HersheyFonts.HersheySimplex, 0.7, Scalar.Lime, 2);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DrawTimestamp Failed: {ex.Message}");
            }
        }

        //private Bitmap ConvertMatToBitmap(Mat mat)
        //{
        //    if (mat.Empty()) return null;

        //    try
        //    {
        //        // 安全转换：先克隆Mat，再创建Bitmap，最后复制像素
        //        using (Mat cloneMat = mat.Clone())
        //        {
        //            // 创建临时Bitmap
        //            Bitmap tempBitmap = new Bitmap(
        //                cloneMat.Cols,
        //                cloneMat.Rows,
        //                (int)cloneMat.Step(),
        //                PixelFormat.Format24bppRgb,
        //                cloneMat.Data);

        //            // 创建独立副本
        //            Bitmap result = new Bitmap(tempBitmap);

        //            // 释放临时Bitmap
        //            tempBitmap.Dispose();

        //            return result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Mat转Bitmap失败: {ex.Message}");
        //        return null;
        //    }
        //}

        // 优化Mat转Bitmap方法（关键修改）
        private Bitmap ConvertMatToBitmap(Mat mat)
        {
            if (mat.Empty()) return null;

            try
            {
                // 直接转换，避免克隆和临时Bitmap（需要安装 OpenCvSharp.Extensions）
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Mat转Bitmap失败: {ex.Message}");
                return null;
            }
        }


        private void ChangeState(VideoState newState)
        {
            if (_currentState != VideoState.Buffering && _currentState == newState) return;

            _currentState = newState;
            StateChanged?.Invoke(this, newState);
        }

        public void Stop()
        {
            if (!_isRunning) return;

            lock (_stopLock)
            {
                _isRunning = false;
                ChangeState(VideoState.Disconnected);
                _captureThread?.Join(2000);
                _captureThread = null;
                Cleanup();
                ConnectionStatusChanged?.Invoke(this, false);
            }
        }

        private void Cleanup()
        {
            try
            {
                _capture?.Release();
                _capture?.Dispose();
                _capture = null;

                _frameCount = 0;
                _lastFrameCount = 0;
                _currentFps = 0;
                _bufferCount = 0;
            }
            catch { }
        }

        public void Dispose()
        {
            Stop();
            GC.SuppressFinalize(this);
        }

        private static void BeginInvokeOnUI(Action action)
        {
            if (Application.OpenForms.Count > 0)
                Application.OpenForms[0].BeginInvoke(action);
        }
    }
}
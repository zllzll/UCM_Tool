using System;
using System.Drawing;

namespace UCM_Tools.Camera
{
    /// <summary>
    /// 视频状态枚举
    /// </summary>
    public enum VideoState
    {
        Idle = 0,           // 空闲
        Connecting = 1,     // 连接中
        Buffering = 2,      // 缓冲中
        Playing = 3,        // 正常播放
        Error = 4,          // 错误
        Disconnected = 5    // 已断开
    }

    /// <summary>
    /// 统一视频源接口，支持USB摄像头和RTSP流
    /// </summary>
    public interface IVideoSource : IDisposable
    {
        /// <summary>
        /// 视频帧到达事件
        /// </summary>
        event EventHandler<Bitmap> FrameReceived;

        /// <summary>
        /// 连接状态改变事件（简化版）
        /// </summary>
        event EventHandler<bool> ConnectionStatusChanged;

        /// <summary>
        /// 详细状态变化事件（新增）
        /// </summary>
        event EventHandler<VideoState> StateChanged;

        /// <summary>
        /// 启动视频源
        /// </summary>
        void Start();

        /// <summary>
        /// 停止视频源
        /// </summary>
        void Stop();

        /// <summary>
        /// 是否正在运行
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// 视频源名称
        /// </summary>
        string SourceName { get; }

        /// <summary>
        /// 视频分辨率
        /// </summary>
        Size FrameSize { get; }

        /// <summary>
        /// 当前状态（新增）
        /// </summary>
        VideoState CurrentState { get; }

        /// <summary>
        /// 实时帧率（新增）
        /// </summary>
        double CurrentFps { get; }

        /// <summary>
        /// 缓冲进度0-100%（新增）
        /// </summary>
        int BufferProgress { get; }
    }
}
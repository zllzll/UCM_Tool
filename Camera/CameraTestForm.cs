using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using AForge.Video.DirectShow;
using UCM_Tools.Camera;

namespace UCM_Tools.Camera
{
    public partial class CameraTestForm : Form
    {
        private IVideoSource _currentVideoSource;
        private readonly object _videoLock = new object();

        // UI控件
        private ComboBox comboDevices;
        private Panel panelVideo;
        private Label lblStatus;
        private Label lblDeviceInfo;
        private Label lblFps;
        private Label lblState;
        private Panel ledState;
        private Button btnStart, btnStop, btnRefresh;
        private GroupBox groupControl;

        public CameraTestForm()
        {
            InitializeUIControls();
        }

        private void InitializeUIControls()
        {
            // 窗体基本设置
            this.Text = "OpenCvSharp4 统一视频预览系统";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // 视频预览区（左侧主区域）
            panelVideo = new Panel
            {
                Name = "panelVideo",
                Location = new Point(10, 10),
                Size = new Size(800, 600),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Black
            };
            this.Controls.Add(panelVideo);

            // 状态指示器（右上角，浮动在视频上）
            var statePanel = new Panel
            {
                Location = new Point(panelVideo.Width - 150, 10),
                Size = new Size(140, 60),
                BackColor = Color.FromArgb(180, 0, 0, 0),
                Parent = panelVideo
            };

            // LED指示灯
            ledState = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(20, 20),
                BackColor = Color.Gray,
                BorderStyle = BorderStyle.FixedSingle,
                Parent = statePanel
            };

            // 状态文本
            lblState = new Label
            {
                Text = "离线",
                Location = new Point(35, 10),
                Size = new Size(95, 20),
                ForeColor = Color.White,
                Font = new Font("Arial", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = statePanel
            };

            // 帧率显示
            lblFps = new Label
            {
                Text = "FPS: 0.0",
                Location = new Point(10, 35),
                Size = new Size(120, 15),
                ForeColor = Color.Lime,
                Font = new Font("Arial", 8),
                TextAlign = ContentAlignment.MiddleLeft,
                Parent = statePanel
            };

            // 控制面板（右侧）
            groupControl = new GroupBox
            {
                Text = "控制面板",
                Location = new Point(820, 10),
                Size = new Size(350, 400)
            };
            this.Controls.Add(groupControl);

            // 设备列表
            var lblDevices = new Label { Text = "设备列表:", Location = new Point(10, 25), AutoSize = true, Parent = groupControl };
            comboDevices = new ComboBox
            {
                Name = "comboDevices",
                Location = new Point(10, 45),
                Size = new Size(320, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Parent = groupControl
            };

            // 控制按钮
            btnStart = new Button { Text = "▶ 启动预览", Location = new Point(10, 80), Size = new Size(150, 30), Parent = groupControl };
            btnStop = new Button { Text = "⏹ 停止预览", Location = new Point(165, 80), Size = new Size(150, 30), Parent = groupControl, Enabled = false };
            btnRefresh = new Button { Text = "🔄 刷新设备", Location = new Point(10, 115), Size = new Size(150, 30), Parent = groupControl };

            // 绑定事件
            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
            btnRefresh.Click += BtnRefresh_Click;

            // 设备信息
            lblDeviceInfo = new Label
            {
                Text = "📋 设备信息:\n(未连接)",
                Location = new Point(10, 155),
                Size = new Size(320, 60),
                BorderStyle = BorderStyle.FixedSingle,
                Parent = groupControl
            };

            // 状态栏（底部）
            lblStatus = new Label
            {
                Name = "lblStatus",
                Text = "就绪",
                Location = new Point(10, 620),
                Size = new Size(1160, 25),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.LightYellow
            };
            this.Controls.Add(lblStatus);

            // 初始加载设备
            RefreshDevices();
        }

        private void RefreshDevices()
        {
            comboDevices.Items.Clear();
            lblStatus.Text = "正在枚举设备...";
            Application.DoEvents();

            try
            {
                // 枚举USB摄像头
                var devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (devices.Count == 0)
                {
                    comboDevices.Items.Add(new VideoSourceItem("⚠️ USB: 未检测到设备", "usb", "-1"));
                }
                else
                {
                    for (int i = 0; i < devices.Count; i++)
                    {
                        comboDevices.Items.Add(new VideoSourceItem($"📹 USB: {devices[i].Name}", "usb", i.ToString()));
                    }
                    lblStatus.Text = $"✓ 找到 {devices.Count} 个USB设备";
                }
            }
            catch (Exception ex)
            {
                comboDevices.Items.Add(new VideoSourceItem($"❌ USB: 枚举失败 - {ex.Message}", "usb", "-1"));
                lblStatus.Text = $"枚举错误: {ex.Message}";
            }

            // 添加RTSP测试流
            comboDevices.Items.Add(new VideoSourceItem("🌐 RTSP: 测试流 (公网)", "rtsp", "rtsp://195.3.171.158:1935/strba/VYHLAD_JAZERO.stream"));
            comboDevices.Items.Add(new VideoSourceItem("🌐 RTSP: 雷视融合RTSP流", "rtsp", "rtsp://192.168.43.11/live/0"));

            if (comboDevices.Items.Count > 0) comboDevices.SelectedIndex = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartVideoSource();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopVideoSource();
            lblStatus.Text = "✓ 已停止";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void StartVideoSource()
        {
            if (comboDevices.SelectedItem == null) return;

            lock (_videoLock)
            {
                StopVideoSource();

                var item = (VideoSourceItem)comboDevices.SelectedItem;
                try
                {
                    // 统一使用OpenCvVideoSource
                    _currentVideoSource = new OpenCvVideoSource(
                        item.ConnectionString,
                        item.Name,
                        targetFps: 30
                    );

                    // 订阅所有事件
                    _currentVideoSource.FrameReceived += OnFrameReceived;
                    _currentVideoSource.ConnectionStatusChanged += OnConnectionStatusChanged;
                    _currentVideoSource.StateChanged += OnVideoStateChanged;

                    _currentVideoSource.Start();

                    lblStatus.Text = $"⏳ 正在启动 {item.Name}...";
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"启动失败: {ex.Message}\n\n请检查设备管理器中摄像头是否正常",
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = $"❌ 启动失败: {ex.Message}";
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                }
            }
        }

        private void StopVideoSource()
        {
            lock (_videoLock)
            {
                if (_currentVideoSource != null)
                {
                    // 取消事件订阅
                    _currentVideoSource.FrameReceived -= OnFrameReceived;
                    _currentVideoSource.ConnectionStatusChanged -= OnConnectionStatusChanged;
                    _currentVideoSource.StateChanged -= OnVideoStateChanged;

                    // 停止并释放
                    _currentVideoSource.Stop();
                    _currentVideoSource.Dispose();
                    _currentVideoSource = null;

                    // 清空预览画面
                    using (var g = panelVideo.CreateGraphics())
                    {
                        g.Clear(Color.Black);
                        g.DrawString("未连接", new Font("Arial", 24), Brushes.Gray,
                            panelVideo.Width / 2 - 60, panelVideo.Height / 2 - 20);
                    }

                    // 恢复UI状态
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    lblFps.Text = "FPS: 0.0";
                    lblState.Text = "离线";
                    ledState.BackColor = Color.Gray;
                }
            }
        }

        private void OnFrameReceived(object sender, Bitmap frame)
        {
            if (panelVideo.InvokeRequired)
            {
                panelVideo.BeginInvoke(new Action<object, Bitmap>(OnFrameReceived), sender, frame);
                return;
            }

            lock (_videoLock)
            {
                if (!_currentVideoSource?.IsRunning ?? true)
                {
                    frame?.Dispose();
                    return;
                }

                if (!panelVideo.IsHandleCreated || panelVideo.Disposing)
                {
                    frame?.Dispose();
                    return;
                }

                using (var g = panelVideo.CreateGraphics())
                {
                    try
                    {
                        if (frame == null || frame.Width <= 0 || frame.Height <= 0)
                        {
                            frame?.Dispose();
                            return;
                        }

                        // 缩放显示
                        var rect = GetScaledRect(panelVideo.ClientRectangle, frame.Size);
                        g.DrawImage(frame, rect);

                        // 更新FPS显示
                        var source = sender as OpenCvVideoSource;
                        if (source != null)
                        {
                            lblFps.Text = $"FPS: {source.CurrentFps:F1}";
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"绘制异常: {ex.Message}");
                    }
                    finally
                    {
                        // ⚠️ 关键：立即释放帧
                        frame?.Dispose();
                    }
                }
            }
        }

        private void OnConnectionStatusChanged(object sender, bool isConnected)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.BeginInvoke(new Action<object, bool>(OnConnectionStatusChanged), sender, isConnected);
                return;
            }

            var source = sender as IVideoSource;
            if (source != null)
            {
                lblStatus.Text = isConnected ? $"✓ {source.SourceName} 运行中" : $"✗ {source.SourceName} 已断开";
                lblDeviceInfo.Text = $"📋 设备信息:\n{source.SourceName}\n分辨率: {source.FrameSize.Width}x{source.FrameSize.Height}";
            }
        }

        private void OnVideoStateChanged(object sender, VideoState state)
        {
            if (ledState.InvokeRequired)
            {
                ledState.BeginInvoke(new Action<object, VideoState>(OnVideoStateChanged), sender, state);
                return;
            }

            var source = sender as IVideoSource;
            if (source == null) return;

            // 更新LED颜色和状态文本
            switch (state)
            {
                case VideoState.Idle:
                    ledState.BackColor = Color.Gray;
                    lblState.Text = "空闲";
                    break;
                case VideoState.Connecting:
                    ledState.BackColor = Color.Orange;
                    lblState.Text = "连接中...";
                    break;
                case VideoState.Buffering:
                    ledState.BackColor = Color.Orange;
                    lblState.Text = $"缓冲中...({source.BufferProgress}%)";
                    break;
                case VideoState.Playing:
                    ledState.BackColor = Color.Lime;
                    lblState.Text = "播放中";
                    break;
                case VideoState.Error:
                    ledState.BackColor = Color.Red;
                    lblState.Text = "错误";
                    break;
                case VideoState.Disconnected:
                    ledState.BackColor = Color.Gray;
                    lblState.Text = "已断开";
                    break;
            }
        }

        private Rectangle GetScaledRect(Rectangle container, Size imageSize)
        {
            if (imageSize.Width == 0 || imageSize.Height == 0) return container;

            float containerRatio = (float)container.Width / container.Height;
            float imageRatio = (float)imageSize.Width / imageSize.Height;

            if (containerRatio > imageRatio)
            {
                int width = (int)(container.Height * imageRatio);
                int x = container.X + (container.Width - width) / 2;
                return new Rectangle(x, container.Y, width, container.Height);
            }
            else
            {
                int height = (int)(container.Width / imageRatio);
                int y = container.Y + (container.Height - height) / 2;
                return new Rectangle(container.X, y, container.Width, height);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopVideoSource();
            base.OnFormClosing(e);
        }
    }

    
}
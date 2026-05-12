using UCM_Tools.Camera;
using UCM_Tools.Config;
using UCM_Tools.MessageBoxEx;
using AForge.Video.DirectShow;
using CommonLib;
using LogProc;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UCM_Tools.Tools;

namespace UCM_Tools.Forms
{
    public partial class VideoPreviewForm : UIForm
    {
        private IVideoSource _currentVideoSource;
        private readonly object _videoLock = new object();
        public VideoPreviewForm()
        {
            InitializeComponent();
        }
        private void VideoPreviewForm_Load(object sender, EventArgs e)
        {
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            ControlItemExtend();
            LoadLanguage();
            RefreshDevices();
                              // ✅ 关键：配置透明控件
                              //SetupTransparentControls();
                              // 5. 启用视频面板双缓冲减少闪烁
            pan_Video.DoubleBuffered(true);
            tb_RtspAddress.Text = SystemSetting.RTSPStream;
            lb_Fps.ForeColor = Color.Red;
        }
        public void ControlItemExtend()
        {
            led_State.Color = Color.Gray;
        }
        private void SetupTransparentControls()
        {
            // 1. 配置状态标签
            //lb_State.BackColor = Color.Transparent;
            lb_State.StyleCustomMode = true;  // SunnyUI关键属性

            // 2. 配置FPS标签
            lb_Fps.ForeColor = Color.Red;
            lb_Fps.StyleCustomMode = true;    // SunnyUI关键属性

            // 3. 配置状态灯（UIPanel模拟）
            led_State.BackColor = Color.Transparent;
            //led_State.StyleCustomMode = true; // SunnyUI关键属性
            //led_State.FillColor = Color.Gray; // 默认灰色
            //lb_State.ForeColor = Color.Gray;

            // 4. 确保控件在视频层之上
            lb_State.BringToFront();
            led_State.BringToFront();
            lb_Fps.BringToFront();

            // 5. 启用视频面板双缓冲减少闪烁
            pan_Video.DoubleBuffered(true);
        }

        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("MainForm", "VideoPreview");
                tb_RtspAddress.Watermark = MultiLanguage.LanguageText("VideoPreviewForm", "RtspAddress");
                lb_State.Text = MultiLanguage.LanguageText("VideoPreviewForm", "Offline");
                lb_DevicesList.Text = $"📹{MultiLanguage.LanguageText("VideoPreviewForm", "DevicesList")} : ";
                btn_StartPreview.Text = $"▶ {MultiLanguage.LanguageText("VideoPreviewForm", "StartPreview")}";
                btn_StopPreview.Text = $"⏹ {MultiLanguage.LanguageText("VideoPreviewForm", "StopPreview")}";
                lb_DeviceInfo.Text = $"📋 {MultiLanguage.LanguageText("VideoPreviewForm", "DevicesInfo")} : ";
                rtb_DeviceMessage.Text = MultiLanguage.LanguageText("VideoPreviewForm", "NoConnected");
                gb_ControlBox.Text = MultiLanguage.LanguageText("VideoPreviewForm", "ControlBox");
            }
            catch (Exception ex) { Log.Error($"VideoPreviewForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }

        private void VideoPreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideoSource();
        }

        #region 调整大小时保持控制区宽度
        private int _fixedPanelWidthCollapsed = 10; // 收缩宽度
        private int _fixedPanelWidthExtended = 295; // 展开宽度
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // 保持 Panel1 宽度固定
            if (uiSplitContainer1?.Panel1 != null && !uiSplitContainer1.IsSplitterFixed)
            {
                // 计算最大允许宽度（确保 Panel2 至少有最小宽度）
                int maxAllowedWidth = uiSplitContainer1.Width -
                                     uiSplitContainer1.Panel2MinSize -
                                     uiSplitContainer1.SplitterWidth;

                // 确保在有效范围内
                int targetWidth = Math.Max(uiSplitContainer1.Panel1MinSize,
                                  Math.Min(uiSplitContainer1.SplitPanelState == UISplitContainer.UISplitPanelState.Collapsed ? _fixedPanelWidthCollapsed: _fixedPanelWidthExtended, maxAllowedWidth));

                if (targetWidth > 0)
                {
                    uiSplitContainer1.SplitterDistance = targetWidth;
                }
            }
        }

        #endregion 调整大小时保持控制区宽度

        #region 自定义拖动实现窗体大小变化
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int HT_LEFT = 0xA;
        private const int HT_RIGHT = 0xB;
        private const int HT_TOP = 0xC;
        private const int HT_TOPLEFT = 0xD;
        private const int HT_TOPRIGHT = 0xE;
        private const int HT_BOTTOM = 0xF;
        private const int HT_BOTTOMLEFT = 0x10;
        private const int HT_BOTTOMRIGHT = 0x11;

        // 边框检测宽度
        private const int BorderWidth = 4;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // 获取鼠标位置
                Point cursor = this.PointToClient(new Point((int)m.LParam));

                // 判断鼠标位置并返回对应的 hit-test 值
                if (cursor.X <= BorderWidth && cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOPLEFT;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth && cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOPRIGHT;
                else if (cursor.X <= BorderWidth && cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOMLEFT;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth && cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOMRIGHT;
                else if (cursor.X <= BorderWidth)
                    m.Result = (IntPtr)HT_LEFT;
                else if (cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOP;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth)
                    m.Result = (IntPtr)HT_RIGHT;
                else if (cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOM;
            }
        }
        #endregion 自定义拖动实现窗体大小变化

        

        private void RefreshDevices()
        {
            cmb_Devices.Items.Clear();
            lb_USBDeviceNum.Text = MultiLanguage.LanguageText("VideoPreviewForm", "GetingDevices");
            Application.DoEvents();

            try
            {
                // 枚举USB摄像头
                var devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (devices.Count > 0)
                {
                    for (int i = 0; i < devices.Count; i++)
                    {
                        cmb_Devices.Items.Add(new VideoSourceItem($"📹 USB: {devices[i].Name}", "usb", i.ToString()));
                    }
                }
                lb_USBDeviceNum.Text = $"📹 USB: {devices.Count}";
            }
            catch (Exception ex)
            {
                lb_USBDeviceNum.Text = $"❌ USB: {MultiLanguage.LanguageText("CurrencyInfo", "Exception")}";
                Log.Error($"Get USB Video Ex\r\n{ex.ToString()}");
            }

            // 添加RTSP测试流
            //cmb_Devices.Items.Add(new VideoSourceItem("🌐 RTSP: 测试流 (公网)", "rtsp", "rtsp://195.3.171.158:1935/strba/VYHLAD_JAZERO.stream"));
            cmb_Devices.Items.Add(new VideoSourceItem($"🌐 RTSP: {MultiLanguage.LanguageText("VideoPreviewForm", "RtspStream")}", "rtsp", ""));

            if (cmb_Devices.Items.Count > 0) cmb_Devices.SelectedIndex = 0;
        }

        private void StartVideoSource()
        {

            if (cmb_Devices.SelectedItem == null) 
            {
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("VideoPreviewForm", "NoSelectDevice"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                return; 
            }
            var item = (VideoSourceItem)cmb_Devices.SelectedItem;
            if (item == null)
            {
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("VideoPreviewForm", "SelectDeviceError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                return;
            }
            if (item.Type == "rtsp")
            {
                item.ConnectionString = tb_RtspAddress.Text;
                if ((!item.ConnectionString.ToLower().Contains("rtsp://")))
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("VideoPreviewForm", "InputRTSPAddress"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
            }
            
            lock (_videoLock)
            {
                StopVideoSource();

                try
                {
                    // 统一使用OpenCvVideoSource
                    _currentVideoSource = new OpenCvVideoSource(
                        item.ConnectionString,
                        item.Name,
                        targetFps: 30,
                        isAddTimestamp:SystemSetting.B_AddTimestamp
                    );

                    // 订阅所有事件
                    _currentVideoSource.FrameReceived += OnFrameReceived;
                    _currentVideoSource.ConnectionStatusChanged += OnConnectionStatusChanged;
                    _currentVideoSource.StateChanged += OnVideoStateChanged;
                    rtb_DeviceMessage.Text = $"{MultiLanguage.LanguageText("VideoPreviewForm", "NoConnected")}\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Starting")} {item.Name}...";
                    _currentVideoSource.Start();

                    
                    btn_StartPreview.Enabled = false;
                    btn_StopPreview.Enabled = true;
                    cmb_Devices.Enabled = false;
                    if(item.Type == "rtsp")
                        pan_RTSP.Visible = false;
                }
                catch (Exception ex)
                {
                    UIMessageBoxEx.ShowMessageDialog($"{MultiLanguage.LanguageText("VideoPreviewForm", "StartFailed")}: {ex.Message}\n\n{(item.Type=="rtsp"? MultiLanguage.LanguageText("VideoPreviewForm", "USBVideoError") : MultiLanguage.LanguageText("VideoPreviewForm", "RTSPVideoError"))}",
                         MultiLanguage.LanguageText("CurrencyInfo", "Error"), false, SunnyUIHelper.DefaultThreme);
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "StartFailed")}: {ex.Message}");
                    btn_StartPreview.Enabled = true;
                    btn_StopPreview.Enabled = false;
                    cmb_Devices.Enabled = true;
                    if (item.Type == "rtsp")
                        pan_RTSP.Visible = true;
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

                }
                // ✅ 新增：重置帧计数器
                _frameCount = 0;
                // 清空预览画面
                var oldImage = pan_Video.BackgroundImage;
                pan_Video.BackgroundImage = null;
                oldImage?.Dispose();

                // 恢复UI状态
                if (!btn_StartPreview.Enabled)
                {
                    if (rtb_DeviceMessage.Lines[rtb_DeviceMessage.Lines.Count() - 1].Contains($"{MultiLanguage.LanguageText("VideoPreviewForm", "Disconnected")}"))
                    {
                        List<string> msgList = rtb_DeviceMessage.Lines.ToList();
                        msgList.RemoveAt(rtb_DeviceMessage.Lines.Count() - 1);
                        rtb_DeviceMessage.Text = string.Join("\r\n", msgList);
                    }
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Disconnected")}");
                }
                DrawVideoState($"{MultiLanguage.LanguageText("VideoPreviewForm", "NoConnected")}");
                btn_StartPreview.Enabled = true;
                btn_StopPreview.Enabled = false;
                cmb_Devices.Enabled = true;
                if (cmb_Devices.SelectedItem != null && ((VideoSourceItem)cmb_Devices.SelectedItem).Type == "rtsp")
                    pan_RTSP.Visible = true;
                else
                    pan_RTSP.Visible = false;
                lb_Fps.Text = "FPS: 0.0";
                lb_State.Text = MultiLanguage.LanguageText("VideoPreviewForm", "Offline");
                led_State.Color = Color.Gray;
                lb_State.ForeColor = Color.Gray;
                lb_Fps.ForeColor = Color.Red;
            }
        }

        private void DrawVideoState(string state)
        {
            // 清空预览画面
            using (var g = pan_Video.CreateGraphics())
            {
                g.Clear(pan_Video.BackColor);
                g.DrawString(state, new Font("Arial", 24), Brushes.Gray,
                    pan_Video.Width / 2 - 60, pan_Video.Height / 2 - 20);
            }
        }

        // ✅ 新增：帧计数器
        private long _frameCount = 0;
        private void OnFrameReceived(object sender, Bitmap frame)
        {
            if (pan_Video.InvokeRequired)
            {
                pan_Video.BeginInvoke(new Action<object, Bitmap>(OnFrameReceived), sender, frame);
                return;
            }
            // ✅ 递增帧计数器
            _frameCount++;
            lock (_videoLock)
            {
                if (!_currentVideoSource?.IsRunning ?? true)
                {
                    frame?.Dispose();
                    return;
                }

                if (!pan_Video.IsHandleCreated || pan_Video.Disposing)
                {
                    frame?.Dispose();
                    return;
                }

                using (var g = pan_Video.CreateGraphics())
                {
                    try
                    {
                        if (frame == null || frame.Width <= 0 || frame.Height <= 0)
                        {
                            frame?.Dispose();
                            return;
                        }
                        // ✅ 关键：直接设置 BackgroundImage，而非 Paint 绘制
                        var oldImage = pan_Video.BackgroundImage;
                        pan_Video.BackgroundImage = new Bitmap(frame);
                        oldImage?.Dispose();

                        // ✅ 关键：仅重绘标签，不整个面板
                        lb_State.Invalidate();
                        lb_Fps.Invalidate();
                        led_State.Invalidate();
                        // 更新FPS显示
                        var source = sender as OpenCvVideoSource;
                        if (source != null && _frameCount % 2 == 0)
                        {
                            lb_Fps.ForeColor = Color.Lime;
                            lb_Fps.Text = $"FPS : {source.CurrentFps:F1}";
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"DrawVideoFrame Ex: {ex.Message}");
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
            if (rtb_DeviceMessage.InvokeRequired)
            {
                rtb_DeviceMessage.BeginInvoke(new Action<object, bool>(OnConnectionStatusChanged), sender, isConnected);
                return;
            }

            var source = sender as IVideoSource;
            if (source != null && isConnected)
            {
                string name = source.SourceName.Replace("📹 ", "").Replace("🌐 ", "");
                rtb_DeviceMessage.AppendText(isConnected ? $"\r\n{name} {MultiLanguage.LanguageText("VideoPreviewForm", "Running")}" : $"\r\n{name} {MultiLanguage.LanguageText("VideoPreviewForm", "Disconnected")}");
                rtb_DeviceMessage.AppendText($"\r\n{name}=>{MultiLanguage.LanguageText("VideoPreviewForm", "Resolution")}: {source.FrameSize.Width}x{source.FrameSize.Height}");
            }
        }

        private void OnVideoStateChanged(object sender, VideoState state)
        {
            if (led_State.InvokeRequired)
            {
                led_State.BeginInvoke(new Action<object, VideoState>(OnVideoStateChanged), sender, state);
                return;
            }

            var source = sender as IVideoSource;
            if (source == null) return;

            // 更新LED颜色和状态文本
            switch (state)
            {
                case VideoState.Idle:
                    led_State.Color = Color.Gray;
                    lb_State.ForeColor = Color.Gray;
                    lb_State.Text = MultiLanguage.LanguageText("VideoPreviewForm", "Idle");
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Idle")}");
                    break;
                case VideoState.Connecting:
                    led_State.Color = Color.Orange;
                    lb_State.ForeColor = Color.Orange;
                    lb_State.Text = $"{MultiLanguage.LanguageText("VideoPreviewForm", "Connecting")}...";
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Connecting")}...");
                    DrawVideoState($"{MultiLanguage.LanguageText("VideoPreviewForm", "Connecting")}...");
                    break;
                case VideoState.Buffering:
                    
                    led_State.Color = Color.Orange;
                    lb_State.ForeColor = Color.Orange;
                    lb_State.Text = $"{MultiLanguage.LanguageText("VideoPreviewForm", "Buffering")}...({source.BufferProgress}%)";
                    if (rtb_DeviceMessage.Lines[rtb_DeviceMessage.Lines.Count() - 1].Contains($"{MultiLanguage.LanguageText("VideoPreviewForm", "Buffering")}..."))
                    {
                        List<string> msgList = rtb_DeviceMessage.Lines.ToList();
                        msgList.RemoveAt(rtb_DeviceMessage.Lines.Count() - 1);
                        rtb_DeviceMessage.Text = string.Join("\r\n",msgList);
                    }
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Buffering")}...({source.BufferProgress}%)");
                    break;
                case VideoState.Playing:
                    led_State.Color = Color.Lime;
                    lb_State.ForeColor = Color.Lime;
                    lb_State.Text = $"{MultiLanguage.LanguageText("VideoPreviewForm", "Playing")}...";
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Playing")}...");
                    SystemSetting.RTSPStream = tb_RtspAddress.Text;
                    break;
                case VideoState.Error:
                    led_State.Color = Color.Red;
                    lb_State.ForeColor = Color.Red;
                    lb_State.Text = MultiLanguage.LanguageText("VideoPreviewForm", "PlayError");
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "PlayError")}");
                    OnVideoStateChanged(sender, VideoState.Disconnected);
                    
                    break;
                case VideoState.Disconnected:
                    led_State.Color = Color.Gray;
                    lb_State.ForeColor = Color.Gray;
                    lb_State.Text = MultiLanguage.LanguageText("VideoPreviewForm", "Disconnected");
                    rtb_DeviceMessage.AppendText($"\r\n{MultiLanguage.LanguageText("VideoPreviewForm", "Disconnected")}");
                    DrawVideoState($"{MultiLanguage.LanguageText("VideoPreviewForm", "NoConnected")}");
                    StopVideoSource();
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

        private void cmb_Devices_DropDown(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void cmb_Devices_DropDownClosed(object sender, EventArgs e)
        {
            var item = (VideoSourceItem)cmb_Devices.SelectedItem;
            if (item != null && item.Type == "rtsp")
                pan_RTSP.Visible = true;
            else
                pan_RTSP.Visible = false;
        }

        private void btn_StartPreview_Click(object sender, EventArgs e)
        {
            StartVideoSource();
        }

        private void btn_StopPreview_Click(object sender, EventArgs e)
        {
            StopVideoSource();
        }
    }
}

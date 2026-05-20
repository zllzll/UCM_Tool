using CommonLib;
using Kitware.VTK;
using log4net;
using LogProc;
using OpenCvSharp.Features2D;
using OpenCvSharp.ML;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.ExtendControls;
using UCM_Tools.MessageBoxEx;
using UCM_Tools.Models;
using UCM_Tools.Radar;
using UCM_Tools.Tools;
using static Sunny.UI.RandomColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static UCM_Tools.CAN_Conn.CAN_Function;
using static UCM_Tools.Tools.VTKHelper;

namespace UCM_Tools.Forms
{
    public partial class MainForm : UIForm
    {// 实例
        DateTime lastDrawTime = DateTime.Now;
        private DynamicFollowerText3D dynamicFollowerText = new DynamicFollowerText3D();
        private GdiTextOverlay gdiOverlay = new GdiTextOverlay();
        VideoPreviewForm videoPreviewForm = null;
        TrackNplotForm trackNplotForm = null;
        GPSInfoForm gpsInfoForm = null;
        TrackFilterForm trackFilterForm = null;
        string periodstring = "*******************  xyz_data **************************";
        string periodstringPointTrack = "*******************  point_track_data **************************";
        string saveDataClusterAlogHead = "frame_id,range,azimuth,elevation,velocity,snr,v_ego_x,v_ego_y,v_ego_z";
        string saveDataImuAndGpsHead = "time,AccX1,AccY1,AccZ1,AVX1,AVY1,AVZ1,AccX2,AccY2,AccZ2,AVX2,AVY2,AVZ2,GpsLong,GpsLat,GpsHeight,GpsSpeed,GpsDecl";
        #region 全局变量

        #region 画图控件
        vtkRenderWindow renderWindow = null;
        vtkRenderer firstRenderer = null;

        private VTKHelper vtkHelper = new VTKHelper();

        public vtkActor gridactor = new vtkActor();

        public vtkActor axisactor = new vtkActor();

        private List<vtkFollower> followers = new List<vtkFollower>();
        private double _axisRefDistance = -1; // -1=未校准，AxisTextFixedSize首次启用时自动计算

        vtkTransform transform = vtkTransform.New();//矩阵变换

        #region 跟踪目标
        // 跟踪目标Actor（使用不同几何体区分点云）
        private vtkActor trackTargetActor = null;
        private vtkPolyData trackTargetData = null;
        private vtkPoints trackTargetPoints = null;
        private vtkUnsignedCharArray trackTargetColors = null; // 使用直接颜色而非lookup table
        private vtkPolyDataMapper trackTargetMapper = null;

        // 跟踪目标文字专用池（与点云文字分开管理）
        private List<vtkTextActor3D> activeTrack3DTextActors = new List<vtkTextActor3D>();
        private List<vtkTextActor> activeTrack2DTextActors = new List<vtkTextActor>();
        private Queue<vtkTextActor3D> trackText3DActorPool = new Queue<vtkTextActor3D>();
        private Queue<vtkTextActor> trackText2DActorPool = new Queue<vtkTextActor>();

        // 跟踪目标几何体缓存（避免每帧重建）
        private vtkSphereSource trackSphereSource = null;
        private vtkGlyph3D trackGlyphFilter = null;

        #endregion 跟踪目标

        #region 复用关键
        // 复用核心VTK对象（关键！）
        private vtkActor pointCloudActor = null;
        private vtkPolyData pointCloudData = null;
        private vtkPoints pointCloudPoints = null;
        private vtkUnsignedCharArray pointCloudColors = null; // 直接颜色数组（替代LookupTable）
        private vtkVertexGlyphFilter pointCloudGlyphFilter = null; // 保留引用不复用
        private vtkPolyDataMapper pointCloudMapper = null;
        private List<vtkTextActor3D> active3DTextActors = new List<vtkTextActor3D>();
        private Queue<vtkTextActor3D> text3DActorPool = new Queue<vtkTextActor3D>();
        private List<vtkTextActor> active2DTextActors = new List<vtkTextActor>();
        private Queue<vtkTextActor> text2DActorPool = new Queue<vtkTextActor>();
        // 性能优化：复用对象
        private vtkCoordinate cachedCoordinate = null;
        private double[] cachedCameraPos = new double[3];
        // 渲染节流
        private DateTime lastRenderTime = DateTime.MinValue;
        private bool renderSkipped = false;

        #region 跟踪目标轨迹
        // 每目标独立Actor：天然支持增量追加和单目标删除
        private class TrajectoryActorData
        {
            public vtkActor Actor;
            public vtkPolyData Data;
            public vtkPoints Points;
            public vtkCellArray Lines;
            public vtkPolyDataMapper Mapper;
        }
        private Dictionary<uint, TrajectoryActorData> trajectoryActors = new Dictionary<uint, TrajectoryActorData>();

        // 轨迹数据管理：TrackID -> 轨迹点队列
        private Dictionary<uint, Queue<TargetInfo.RadarTargetInfoStruct>> trackTrajectories = new Dictionary<uint, Queue<TargetInfo.RadarTargetInfoStruct>>();
        private readonly object trajectoryLock = new object();
        #endregion 跟踪目标轨迹

        #endregion 复用关键

        #endregion 画图控件

        RadarClass radar = null;
        int curFrameNum = 0;
        System.Timers.Timer timerFrame = new System.Timers.Timer(1000);
        QueueSaveData saveData = null;
        QueueSaveData saveDataTrack = null;
        QueueSaveData saveDataPointTrack = null;
        QueueSaveData saveDataClusterAlog = null;
        QueueSaveData saveDataImuAndGps = null;
        /// <summary>
        /// 累计多少帧显示
        /// </summary>
        List<List<TargetInfo.RadarTargetInfoStruct>> targetFrameTemp = new List<List<TargetInfo.RadarTargetInfoStruct>>();
        /// <summary>
        /// 每次显示的列表总数
        /// </summary>
        List<TargetInfo.RadarTargetInfoStruct> targetTemp = new List<TargetInfo.RadarTargetInfoStruct>();

        public delegate void TrackDataDelegate(List<TargetInfo.RadarTargetInfoStruct> data);

        public static event TrackDataDelegate trackDataReceived;
        public delegate void GpsInfoDataDelegate(IMUAndGPSData data);

        public static event GpsInfoDataDelegate gpsInfoDataReceived;
        #endregion 全局变量

        #region 初始化
        public MainForm()
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // = this.Style;
            LoadTheme();
            LoadLanguage();
            FrameTimer();
            btn_DataReplay.Visible = SystemSetting.ShowDataReplay;
            btn_StopReplay.Visible = SystemSetting.ShowDataReplay;
            btn_StopReplay.Enabled = false;
            ts_RadarAlive_SR75.Visible = false;
            ts_RadarUpgrade_SR75.Visible = false;
            ts_RadarUpgrade_UCM211.Visible = true;
            // 在渲染前计算并应用非等比例缩放
            if (SystemSetting.NonUniformScale)
                SystemSetting.ApplyNonUniformScale();
            TrackFilterForm.FilterChanged += OnFilterChanged;
        }

        #region 加载主题
        private void LoadTheme()
        {
            try
            {
                ts_Theme.DropDownItems.Clear();
                ts_Theme.DropDownItems.Add("Default", null, ThemeOnClick);
                var styles = UIStyles.PopularStyles();
                foreach (UIStyle style in styles)
                {
                    ts_Theme.DropDownItems.Add(style.Description(), null, ThemeOnClick);
                }
                //初始化主题
                SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            }
            catch (Exception ex)
            {
                Log.Error($"MainForm LoadTheme() Ex\r\n{ex.ToString()} ");
            }
        }

        private void ThemeOnClick(object sender, EventArgs e)
        {
            try
            {
                if (sender is ToolStripItem)
                {
                    ToolStripItem tsItem = sender as ToolStripItem;

                    SunnyUIHelper.SetTheme(this, tsItem.Text);
                    if (videoPreviewForm != null)
                    {
                        SunnyUIHelper.SetTheme(videoPreviewForm, tsItem.Text);
                        videoPreviewForm.ControlItemExtend();
                    }
                    if (trackNplotForm != null)
                    {
                        SunnyUIHelper.SetTheme(trackNplotForm, tsItem.Text);
                    }
                    if (gpsInfoForm != null)
                    {
                        SunnyUIHelper.SetTheme(gpsInfoForm, tsItem.Text);
                    }
                    if (trackFilterForm != null)
                    {
                        SunnyUIHelper.SetTheme(trackFilterForm, tsItem.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"MainForm ThemeOnClick() Ex\r\n{ex.ToString()} ");
            }
        }


        #endregion 加载主题

        #region 语言加载
        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("CurrencyInfo", "System_Name");
                lb_ConnParamsAreaTitle.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ConnectParams");
                lb_RadarType.Text = MultiLanguage.LanguageText("ConnectSettingForm", "RadarType");
                lb_DeviceIndex.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DeviceIndex");
                lb_ChannelIndex.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ChannelIndex");
                lb_AbitBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ABitBaud");
                lb_DbitBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DBitBaud");
                btn_Start.Text = MultiLanguage.LanguageText("MainForm", "ts_Start");
                btn_Connect.Text = MultiLanguage.LanguageText("MainForm", "ts_Connect");
                lb_DeviceAddressText.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DeviceAddress");
                lb_DevicePortText.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DevicePort");
                lb_COMNo.Text = MultiLanguage.LanguageText("ConnectSettingForm", "SerialNum");
                lb_COMBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "CANBaud");

                lb_RadarInfo.Text = MultiLanguage.LanguageText("MainForm", "RadarInfoArea");
                lb_VersionText.Text = MultiLanguage.LanguageText("MainForm", "VersionText");
                lb_TarNumText.Text = MultiLanguage.LanguageText("MainForm", "TarNumText");
                lb_ShowTarNumText.Text = MultiLanguage.LanguageText("MainForm", "ShowTarNumText");
                lb_CumulativeFramesText.Text = MultiLanguage.LanguageText("SystemSetForm", "CumulativeFramesText");
                lb_FrameNumText.Text = MultiLanguage.LanguageText("MainForm", "FrameNumText");
                lb_TrackNumText.Text = MultiLanguage.LanguageText("MainForm", "TrackNumText");

                lb_ControlAreaTitle.Text = MultiLanguage.LanguageText("MainForm", "ControlAreaTitle");
                ts_RadarAlive_SR75.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarAlive") + "(SR75)";
                ts_RadarUpgrade_SR75.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarUpgrade") + "(SR75)";
                ts_RadarUpgrade_UCM211.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarUpgrade") + "(UCM211)";
                btn_ResetView.Text = MultiLanguage.LanguageText("MainForm", "btn_ResetCamera");
                btn_DataReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStart");
                btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop");
                btn_SystemSet.Text = MultiLanguage.LanguageText("MainForm", "btn_SystemSet");
                lb_SystemInfo.Text = MultiLanguage.LanguageText("MainForm", "SystemInfoArea");
                ts_Theme.Text = MultiLanguage.LanguageText("MainForm", "ts_Theme");
                ts_RadarFunction.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarFunc");
                menuItem_VideoPreview.Text = MultiLanguage.LanguageText("MainForm", "VideoPreview");
                ts_TrackData.Text = MultiLanguage.LanguageText("MainForm", "XY2DView");
                lb_GpsText.Text = MultiLanguage.LanguageText("MainForm", "GpsState");
                ts_GpsInfoData.Text = MultiLanguage.LanguageText("GPSInfoForm", "GPSInfoTitle");
                ts_FilterTrackIds.Text = MultiLanguage.LanguageText("TrackFilterForm", "FilterIdTitle");
            }
            catch (Exception ex) { Log.Error($"MainForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }
        #endregion 语言加载

        #region 帧率定时器
        private void FrameTimer()
        {
            timerFrame.AutoReset = true;
            timerFrame.Elapsed += TimerFrame_Elapsed;
        }

        private void TimerFrame_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {

                int frameNum = curFrameNum;
                curFrameNum = 0;
                if (this.WindowState != FormWindowState.Minimized)//WinForms + VTK 窗体最小化时渲染性能下降 的问题。根本原因是：当窗体最小化时，RenderWindow 的渲染循环被系统暂停或降频，导致数据堆积、延迟
                    this.Invoke((EventHandler)delegate { lb_FrameNum.Text = $"{frameNum}Hz"; });
            }
            catch (Exception ex)
            {
                Log.Error($"TimerFrame_Elapsed Ex\r\n{ex.ToString()}");
            }
        }
        #endregion  帧率定时器

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UIMessageBoxEx.ShowMessageDialog($"{MultiLanguage.LanguageText("CurrencyInfo", "Determine")}", MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), true, SunnyUIHelper.DefaultThreme))
            {
                TrackFilterForm.FilterChanged -= OnFilterChanged;
                timerFrame.Stop();
                if (radar != null && radar._bOpen)
                    Stop();
                if (dataReplayer != null)
                {
                    dataReplayer.StopReplay();
                    dataReplayer.cycleDataEvent -= Radar_cycleDataEvent;
                    dataReplayer.replayerStatus -= DataReplayer_replayerStatus;
                }
                dataReplayer = null;
                if (dataAlogReplayer != null)
                {
                    dataAlogReplayer.StopReplay();
                    dataAlogReplayer.tarAndClusterPointCloud -= Radar_tarAndClusterPointCloud;
                    dataAlogReplayer.replayerStatus -= DataReplayer_replayerStatus;
                }
                dataAlogReplayer = null;
                if (dataPointTrackReplayer != null)
                {
                    dataPointTrackReplayer.StopReplay();
                    dataPointTrackReplayer.tarAndClusterPointCloud -= Radar_tarAndClusterPointCloud;
                    dataPointTrackReplayer.replayerStatus -= DataReplayer_replayerStatus;
                }
                dataPointTrackReplayer = null;
                isReplaying = false;
                #region VTK清除
                ClearVTKDynamicData();
                ClearVTKStaticData();
                dynamicFollowerText.Cleanup(firstRenderer);
                gdiOverlay?.Dispose();
                #endregion VTK清除

                Process.GetCurrentProcess().Kill();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void ClearVTKDynamicData()
        {
            
            ClearTrajectory();//清除跟踪轨迹
            ClearTrackTargets();//清除跟踪目标和文本
                                // 清理跟踪目标文字池
            lock (trackText3DActorPool)
            {
                while (trackText3DActorPool.Count > 0)
                {
                    trackText3DActorPool.Dequeue().Dispose();
                }
            }
            lock (trackText2DActorPool)
            {
                while (trackText2DActorPool.Count > 0)
                {
                    trackText2DActorPool.Dequeue().Dispose();
                }
            }
            // 清理点云相关对象
            if (pointCloudActor != null)
            {
                firstRenderer?.RemoveViewProp(pointCloudActor);
                pointCloudActor.Dispose();
                pointCloudActor = null;
            }
            if (pointCloudData != null)
            {
                pointCloudData.Dispose();
                pointCloudData = null;
            }
            if (pointCloudPoints != null)
            {
                pointCloudPoints.Dispose();
                pointCloudPoints = null;
            }
            if (pointCloudColors != null)
            {
                pointCloudColors.Dispose();
                pointCloudColors = null;
            }
            if (pointCloudGlyphFilter != null)
            {
                pointCloudGlyphFilter.Dispose();
                pointCloudGlyphFilter = null;
            }

            // 清理激活的文本Actor
            ClearTextActors();

            // 清理对象池
            lock (text3DActorPool)
            {
                while (text3DActorPool.Count > 0)
                {
                    text3DActorPool.Dequeue().Dispose();
                }
            }
            lock (text2DActorPool)
            {
                while (text2DActorPool.Count > 0)
                {
                    text2DActorPool.Dequeue().Dispose();
                }
            }
        }

        /// <summary>
        /// 更新坐标轴刻度文字缩放，使其远近大小一致
        /// </summary>
        private void UpdateAxisLabelScale()
        {
            if (!Config.SystemSetting.AxisTextFixedSize || followers == null || followers.Count == 0 || firstRenderer == null)
                return;

            double[] camPos = firstRenderer.GetActiveCamera().GetPosition();

            // 首次启用时自动校准参考距离，使当前文字大小与关闭时一致
            if (_axisRefDistance < 0)
            {
                double totalDist = 0;
                int count = 0;
                for (int i = 0; i < followers.Count; i++)
                {
                    var f = followers[i];
                    if (f == null) continue;
                    double[] p = GetFollowerWorldPos(f);
                    double d = Dist(p, camPos);
                    if (d > 0.1) { totalDist += d; count++; }
                }
                _axisRefDistance = count > 0 ? totalDist / count : 100.0;
            }

            for (int i = 0; i < followers.Count; i++)
            {
                var follower = followers[i];
                if (follower == null) continue;

                double[] pos = GetFollowerWorldPos(follower);
                double distance = Dist(pos, camPos);
                double scale = Math.Max(distance, 0.5) / _axisRefDistance
                             * Config.SystemSetting.AxisTextScale;
                follower.SetScale(scale, scale, scale);
            }
        }

        private double[] GetFollowerWorldPos(vtkFollower follower)
        {
            double[] pos = follower.GetPosition();
            if (SystemSetting.NonUniformScale && SystemSetting.GlobalTransform != null)
                return SystemSetting.GlobalTransform.TransformPoint(pos[0], pos[1], pos[2]);
            return pos;
        }

        private static double Dist(double[] a, double[] b)
        {
            double dx = a[0] - b[0];
            double dy = a[1] - b[1];
            double dz = a[2] - b[2];
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        private void ClearVTKStaticData()
        {
            // 清理静态网格和坐标轴
            if (firstRenderer != null)
            {
                if (axisactor != null)
                {
                    firstRenderer.RemoveActor(axisactor);
                    axisactor.Dispose();
                    axisactor = null;
                }
                if (gridactor != null)
                {
                    firstRenderer.RemoveActor(gridactor);
                    gridactor.Dispose();
                    gridactor = null;
                }
                // 清理坐标轴标签
                for (int i = 0; i < followers.Count; i++)
                {
                    firstRenderer.RemoveViewProp(followers[i]);
                    followers[i].Dispose();
                }
                followers.Clear();
                _axisRefDistance = -1; // 重新校准
            }

            // 释放RenderWindow
            if (renderWindow != null)
            {
                renderWindow.Dispose();
                renderWindow = null;
            }
        }
        #region 图表初始化
        private void renderWindowControl1_Load(object sender, EventArgs e)
        {
            InitializeStaticContent(true);

            StatusMenuShow();

            DisplaySystemParams();

            // 初始化GDI文本叠加层
            gdiOverlay.Initialize(renderWindowControl1.Width, renderWindowControl1.Height);
            gdiOverlay.Enabled = SystemSetting.UseGdiTextOverlay;
        }
        private void renderWindowControl1_SizeChanged(object sender, EventArgs e)
        {
            gdiOverlay?.Resize(renderWindowControl1.Width, renderWindowControl1.Height);
            if (firstRenderer != null && renderWindow != null)
            {
                // 仅重新计算Zoom，不改变位置
                ResetCameraView(false, false, false, true);
            }
        }
        private void DisplaySystemParams()
        {
            lb_CumulativeFrames.Text = SystemSetting.CumulativeFrameNum.ToString();
        }

        private void InitializeStaticContent(bool isInit)
        {
            if (renderWindow == null || firstRenderer == null)
            {
                renderWindow = this.renderWindowControl1.RenderWindow;

                firstRenderer = renderWindow.GetRenderers().GetFirstRenderer();
                // 设置渲染器背景颜色（RGB，范围0-1）
                if (SystemSetting.VTKBackColor)
                    firstRenderer.SetBackground(1, 1, 1);  // 纯白背景
            }
            // 启用多重采样抗锯齿（关键！）
            renderWindow.SetMultiSamples(2);  // 4x MSAA，可设为8或更高

            // 启用Alpha位平面（有助于平滑渲染）
            renderWindow.SetAlphaBitPlanes(1);
            //启用VTK硬件加速
            if (SystemSetting.HardwareAcc)
            {
                renderWindow.SetMultiSamples(4);
                renderWindow.SetAlphaBitPlanes(1);
            }
            for (int i = 0; i < this.followers.Count; i++)
            {
                firstRenderer.RemoveViewProp(this.followers[i]);
                this.followers[i].Dispose(); // 确保释放对象
            }
            this.followers.Clear();
            if (firstRenderer.HasViewProp(axisactor) != 0)
            {
                firstRenderer.RemoveActor(axisactor);
                //axisactor.Dispose();
                axisactor = null;
            }
            if (firstRenderer.HasViewProp(gridactor) != 0)
            {
                firstRenderer.RemoveActor(gridactor);
                //gridactor.Dispose();
                gridactor = null;
            }
            // 在renderWindow.Render()之前调用
            if (renderWindow.IsA("vtkWin32OpenGLRenderWindow") != 0)
            {
                renderWindow.MakeCurrent(); // 强制激活OpenGL上下文
            }
            firstRenderer.Modified(); // 标记渲染器已修改

            if (isInit && SystemSetting.NonUniformScale)
            {
                SystemSetting.ApplyNonUniformScale();
            }

            // 绘制网格
            this.gridactor = this.vtkHelper.DrawGrid();
            firstRenderer.AddActor(this.gridactor);

            // 绘制坐标轴
            this.axisactor = this.vtkHelper.DrawAxis(3.0);
            firstRenderer.AddActor(this.axisactor);
            //vtkCamera currentCamera = firstRenderer.GetActiveCamera();
            // 绘制坐标轴文本
            this.followers = this.vtkHelper.Scale(new List<vtkFollower>());
            foreach (var follower in this.followers)
            {
                follower.SetCamera(firstRenderer.GetActiveCamera());
                firstRenderer.AddActor(follower);
            }
            // 新增：初始化Follower文本池（模仿坐标轴的初始化方式）
            if (isInit)
            {
                dynamicFollowerText.Initialize(firstRenderer);
            }
            if (isInit)
                ResetCameraView(true, true, true, true);//初始化操作
            else
                ResetCameraView(false, false, false, false);//修改系统参数操作

            #region MyRegion
            // 相机位于 Z 轴正方向
            //         currentCamera.SetPosition(0, -200, 0);
            //         // 焦点设置为原点
            //         currentCamera.SetFocalPoint((SystemSetting.XMin + SystemSetting.XMax) / 2.0, (SystemSetting.YMin + SystemSetting.YMax) / 2.0, (SystemSetting.ZMin + SystemSetting.ZMax) / 2.0);
            //currentCamera.SetViewUp(0.0, 0.0, 5.0);
            //         //currentCamera.SetViewUp(0, 1, 0);     // 视图向上方向为 Y 轴正方向
            //         currentCamera.Zoom(1);//缩放视图

            //currentCamera.SetViewAngle(0); // 设置视角为 30 度
            //currentCamera.SetParallelScale(1);// 设置平行投影缩放比例
            //currentCamera.SetParallelProjection(1); // 启用平行投影
            //currentCamera.SetClippingRange(0.1, 1000); // 设置剪裁范围为 0.1 到 1000
            //currentCamera.Roll(45); // 绕视线旋转 45 度
            //currentCamera.Azimuth(30); // 绕垂直轴旋转 30 度
            //currentCamera.Elevation(15); // 绕水平轴旋转 15 度
            //double[] position = camera.GetPosition();
            //double[] focalPoint = camera.GetFocalPoint();
            //double[] viewUp = camera.GetViewUp();
            //renderer.ResetCamera(); // 重置相机
            //renderer.ResetCameraClippingRange();//重置相机的剪裁范围。
            //camera.SetWindowCenter(0.5, 0.5); // 设置窗口中心为 (0.5, 0.5)
            //camera.SetDistance(500); // 设置相机到焦点的距离为 500
            //camera.SetEyeAngle(2.0); // 设置眼睛角度为 2.0 度
            //camera.SetScreenOffset(0.1, 0.1); // 设置屏幕偏移量
            // 保存初始状态
            //initialCameraState = vtkCamera.New();
            //initialCameraState.DeepCopy(currentCamera);
            #endregion

            // 6. 重置剪裁范围并渲染
            //firstRenderer.ResetCameraClippingRange();
            //renderWindow.Render(); // 刷新渲染窗口
        }

        private void ResetCameraView(bool isResetPosition, bool isResetFocalPoint, bool isResetViewUp, bool isResetZoom)
        {
            if (firstRenderer == null || renderWindow == null) return;

            vtkCamera currentCamera = firstRenderer.GetActiveCamera();
            if (isResetPosition)
                currentCamera.SetPosition(0, -200, 50);
            if (isResetFocalPoint)
            {
                // 如果你一定要用原始坐标设置焦点，需要先逆向变换
                double originalCenterX = (SystemSetting.XMin + SystemSetting.XMax) / 2.0;
                double originalCenterY = (SystemSetting.YMin + SystemSetting.YMax) / 2.0;
                double originalCenterZ = (SystemSetting.ZMin + SystemSetting.ZMax) / 2.0;
                if (SystemSetting.NonUniformScale)
                {
                    // 变换到视觉坐标
                    double[] visualCenter = SystemSetting.GlobalTransform.TransformPoint(
                        originalCenterX, originalCenterY, originalCenterZ);

                    currentCamera.SetFocalPoint(visualCenter[0], visualCenter[1], visualCenter[2]);
                }
                else
                    currentCamera.SetFocalPoint(originalCenterX, originalCenterY, originalCenterZ);
            }
            if (isResetViewUp)
                currentCamera.SetViewUp(0.0, 0.0, 5.0);
            if (isResetZoom)
                currentCamera.Zoom(1);

            firstRenderer.ResetCameraClippingRange();
            _axisRefDistance = -1; // 相机复位后重新校准
            UpdateAxisLabelScale();
            dynamicFollowerText?.RefreshScales();
            renderWindow.Render();
        }

        private void StatusMenuShow()
        {
            lb_RadarTypeStr.Text = SystemSetting.RadarType;
            lb_DeviceIndexStr.Text = SystemSetting.CAN_Index.ToString();
            lb_ChannelIndexStr.Text = SystemSetting.CAN_Channel.ToString();
            lb_AbitBaudStr.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CANFD_BAUD_ARBITRATE>((int)SystemSetting.CANFD_Baud_Abit));
            lb_DbitBaudStr.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CANFD_BAUD_DATA>((int)SystemSetting.CANFD_Baud_Dbit));
            lb_DeviceAddress.Text = SystemSetting.TCP_IP;
            lb_DevicePort.Text = SystemSetting.TCP_Port.ToString();
            lb_COMNoStr.Text = SystemSetting.COM_No;
            lb_COMBaudStr.Text = SystemSetting.COM_Baud.ToString();
            lb_DeviceIndexStrCAN.Text = SystemSetting.CAN_Index.ToString();
            lb_ChannelIndexStrCAN.Text = SystemSetting.CAN_Channel.ToString();
            lb_CANBaudStr.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CAN_BAUD>((int)SystemSetting.CAN_Baud));
            if (string.Compare(SystemSetting.ConnType, "TCP", false) == 0 || string.Compare(SystemSetting.ConnType, "UDP", false) == 0)
            {
                pan_TCPParams.BringToFront();
                pan_TCPParams.Dock = DockStyle.Fill;
            }
            else if (string.Compare(SystemSetting.ConnType, "COM", false) == 0)
            {
                pan_COMParams.BringToFront();
                pan_COMParams.Dock = DockStyle.Fill;
            }
            else if (string.Compare(SystemSetting.ConnType, "CAN", false) == 0)
            {
                if (string.Compare(SystemSetting.Zlg_Type, "CANFD", false) == 0)
                {
                    pan_CANFDParams.BringToFront();
                    pan_CANFDParams.Dock = DockStyle.Fill;
                }
                else if (string.Compare(SystemSetting.Zlg_Type, "CAN", false) == 0)
                {
                    pan_CANParams.BringToFront();
                    pan_CANParams.Dock = DockStyle.Fill;
                }
            }
        }
        #endregion 图表初始化

        #endregion 初始化

        #region 启动扫描
        private async void btn_Start_Click(object sender, EventArgs e)
        {
            MsgForeColor(rtb_SystemMessage, "", "");
            btn_Start.Enabled = false;
            try
            {
                if (string.Compare(btn_Start.Text, MultiLanguage.LanguageText("MainForm", "ts_Start"), true) == 0)
                {

                    if (SystemSetting.TargetData && !PubClass.EnsureFolderPath(SystemSetting.FileRoute))
                    {
                        MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "ErrorSavePath"), "ERROR");
                        return;
                    }
                    
                    if (await Start())
                    {
                        ControlState(false);
                        timerFrame.Start();
                        btn_Start.Text = MultiLanguage.LanguageText("MainForm", "ts_Stop");
                        MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "DeviceConnected"), "SUCCESS");
                    }
                    else
                    {
                        MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "DeviceConnectFailed"), "ERROR");
                        return;
                    }
                }
                else
                {
                    timerFrame.Stop();
                    Stop();
                    ControlState(true);
                    btn_Start.Text = MultiLanguage.LanguageText("MainForm", "ts_Start");
                    MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "DeviceDisconnected"), "INFO");
                }
            }
            catch
            {

            }
            finally
            {
                btn_Start.Enabled = true;

            }
        }
        private void MsgForeColor(Control control, string msg, string type)
        {
            Color color = Control.DefaultForeColor;
            switch (type)
            {

                case "ERROR":
                    color = Color.Red;
                    break;
                case "INFO":
                case "SUCCESS":
                    color = Color.LimeGreen;
                    break;
                default:
                    break;
            }
            control.Text = msg;
            control.ForeColor = color;
        }
        private void ControlState(bool b)
        {
            ClearCommon();
            btn_Connect.Enabled = b;
            //btn_SystemSet.Enabled = b;
            //btn_ResetView.Enabled = b;
            ts_RadarAlive_SR75.Visible = !b;
            ts_RadarUpgrade_SR75.Visible = !b;
            ts_RadarUpgrade_UCM211.Visible = b;
            if (SystemSetting.ShowDataReplay)
                btn_DataReplay.Enabled = b;
        }
        /// <summary>
        /// 清空帧信息显示和累积列表
        /// </summary>
        private void ClearCommon()
        {
            curFrameNum = 0;
            targetTemp.Clear();
            targetFrameTemp.Clear();
            lb_FrameNum.Text = "0Hz";
            lb_TarNum.Text = "0";
            lb_ShowTarNum.Text = "0";
            lb_TrackNum.Text = "0";
            lb_Version.Text = "v0.0.0";
            lb_Gps.Text = "Invalid";
        }

        private async Task<bool> Start()
        {
            try
            {
                radar = new RadarClass();

                if (!await radar.Start(SystemSetting.RadarType, SystemSetting.ConnType))
                    return false;
                radar.cycleDataEvent += Radar_cycleDataEvent;
                radar.versionEvent += Radar_versionEvent;
                radar.tarAndClusterPointCloud += Radar_tarAndClusterPointCloud;
                radar.pointCloudSaveEvent += Radar_pointCloudSaveEvent;
                radar.imuAndGpsSaveEvent += Radar_imuAndGpsSaveEvent;
                radar.connectStatusChangedEvent += Radar_connectStatusChangedEvent;
                radar.SendCmd(RadarCommand.ReadSoftwareVersion);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"MainForm Start() Ex\r\n{ex.ToString()}");
            }
            return false;
        }



        #region 委托事件
        private void Radar_versionEvent(string version)
        {
            string ver = version;
            this.Invoke((EventHandler)delegate { lb_Version.Text = $"v{ver}"; });
        }

        private void Radar_connectStatusChangedEvent(bool isConnected, ConnState connState)
        {
            string message = MultiLanguage.LanguageText("ErrorInfo", connState.ToString());
            this.Invoke((Action)(() =>
            {
                if (isConnected)
                {
                    // 重连成功：清除断连期间积累的动态渲染数据，避免轨迹断裂
                    lock (trajectoryLock)
                    {
                        trackTrajectories.Clear();
                    }
                    targetFrameTemp.Clear();
                    targetTemp.Clear();
                    ClearTrajectoryData();
                    ClearPointCloud();
                    ClearTrackTargets();
                    dynamicFollowerText.HideAll();
                    MsgForeColor(rtb_SystemMessage, message, "SUCCESS");
                    // 重连后重新握手，触发雷达输出目标数据
                    radar.SendCmd(RadarCommand.ReadSoftwareVersion);
                }
                else
                {
                    MsgForeColor(rtb_SystemMessage, message, "INFO");
                }
            }));
        }

        #region 新绘图事件

        private void Radar_cycleDataEvent(string time, int NumTar, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            //cumulativeFrameSum++;
            curFrameNum++;
            int tarNum = NumTar;
            int tarListCount = targetInfoList == null ? 0 : targetInfoList.Count;
            if (SystemSetting.TargetData && !isReplaying)
            {
                if (saveData == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//Clusters"))
                    {
                        if ((saveData = new QueueSaveData($"{SystemSetting.FileRoute}//Clusters", 0, "txt", SystemSetting.FileSize, "Cluster")) != null)
                            saveData.AddQueue(TarsListToString(time, targetInfoList));
                    }
                }
                else
                    saveData.AddQueue(TarsListToString(time, targetInfoList));
            }
            else//以防测试过程中修改了保存设置
            {
                if (saveData != null)
                {
                    saveData.Dispose();
                    saveData = null;
                }
            }
            List<TargetInfo.RadarTargetInfoStruct> LoadTemp;
            if (SystemSetting.CumulativeFrameNum <= 1)
            {
                LoadTemp = targetInfoList;
            }
            else
            {
                targetFrameTemp.Add(targetInfoList);
                targetTemp.Clear();
                foreach (var item in targetFrameTemp)
                    targetTemp.AddRange(item);
                LoadTemp = new List<TargetInfo.RadarTargetInfoStruct>(targetTemp);
                if (targetFrameTemp.Count >= SystemSetting.CumulativeFrameNum)
                {
                    if (SystemSetting.CumulativeFrameType == 1)
                        targetFrameTemp.Clear();
                    else
                    {
                        int removeNum = targetFrameTemp.Count - SystemSetting.CumulativeFrameNum;
                        if (removeNum > 0)
                            targetFrameTemp.RemoveRange(0, removeNum + 1);
                        else if (removeNum == 0)
                            targetFrameTemp.RemoveAt(0);
                    }
                }
            }
            UpdateLabels(targetInfoList.Count, LoadTemp.Count, 0);
            if (isLostFocus)
            {
                int throttle = SystemSetting.VtkDrawTimeInLostFocus > 0 ? SystemSetting.VtkDrawTimeInLostFocus : 500;
                if ((DateTime.Now - lastDrawTime).TotalMilliseconds < throttle)
                    return;
            }

            lastDrawTime = DateTime.Now;
            UpdatePointCloud(LoadTemp);
        }

        #region 核心变更
        private void UpdatePointCloud(List<TargetInfo.RadarTargetInfoStruct> pointData = null, List<TargetInfo.RadarTargetInfoStruct> trackData = null, Dictionary<uint, Queue<TargetInfo.RadarTargetInfoStruct>> trackTrajectoriesTemp = null)
        {
            // 双重检查，防止Invoke延迟导致最小化后仍执行渲染
            if (this.WindowState == FormWindowState.Minimized ||
                !this.Visible ||
                this.IsDisposed)
            {
                return;
            }
            if ((pointData == null || pointData.Count == 0) && (trackData == null || trackData.Count == 0))
            {
                ClearPointCloud();
                ClearTrackTargets();
                ClearTrajectory();
                dynamicFollowerText.HideAll();
                // 清空GDI叠加层
                if (gdiOverlay != null && textOverlayPanel != null)
                {
                    gdiOverlay.BeginFrame();
                    gdiOverlay.EndFrame();
                    textOverlayPanel.SetOverlayBitmap(gdiOverlay.GetBitmap());
                }
                return;
            }

            try
            {
                Invoke(new Action(() =>
                {
                    // 缓存相机位置（本帧内复用）
                    if (firstRenderer?.GetActiveCamera() != null)
                    {
                        double[] pos = firstRenderer.GetActiveCamera().GetPosition();
                        cachedCameraPos[0] = pos[0];
                        cachedCameraPos[1] = pos[1];
                        cachedCameraPos[2] = pos[2];
                    }

                    // 1. 同步清理上一帧文本
                    ClearTextActors();
                    ClearTrackTextActors();

                    // 2. 初始化或复用点云Actor
                    if (pointCloudActor == null) InitializePointCloudActor();
                    if (trackTargetActor == null) InitializeTrackTargetActor(); // 新增
                    // 轨迹Actor按需创建，不再需要初始化检查

                    if (pointCloudActor.GetProperty().GetPointSize() != SystemSetting.PointSize)
                        pointCloudActor?.GetProperty().SetPointSize(SystemSetting.PointSize);//需要更新点目标
                    // 3. 更新点云数据（不创建新Actor）
                    if ((SystemSetting.DisplayTargetType == 0 || SystemSetting.DisplayTargetType == 1) && pointData != null && pointData.Count > 0)
                        UpdatePointCloudData(pointData);
                    else
                    {
                        // 清空点云但保留Actor
                        pointCloudPoints.Reset();
                        pointCloudColors.Reset();
                        pointCloudData.Modified();
                    }
                    // 4. 新增：更新跟踪目标数据
                    if ((SystemSetting.DisplayTargetType == 0 || SystemSetting.DisplayTargetType == 2) && trackData != null && trackData.Count > 0)
                    {
                        if (trackSphereSource.GetRadius() != SystemSetting.TrackSize)
                            trackSphereSource.SetRadius(SystemSetting.TrackSize);
                        UpdateTrackTargetData(trackData);
                        // 新增：更新轨迹（高性能，与跟踪目标同步更新）
                        UpdateTrajectoryData(trackData);
                        // 5. 添加跟踪目标文字
                        if (SystemSetting.DisplayTrackText)
                        {
                            int textThrottle = isLostFocus
                                ? (SystemSetting.VtkDrawTimeInLostFocus > 0 ? SystemSetting.VtkDrawTimeInLostFocus : 500)
                                : SystemSetting.VtkDrawTimeInLostFocus;
                            bool textTimeOk = isLostFocus
                                ? (DateTime.Now - lastDrawTime).TotalMilliseconds >= textThrottle
                                : (DateTime.Now - lastDrawTime).TotalMilliseconds > textThrottle;

                            if (SystemSetting.UseGdiTextOverlay)
                            {
                                // GDI+ 位图叠加：所有文本渲染到一张位图，1次draw call
                                RenderTrackTextGdiOverlay(trackData);
                            }
                            else if (textTimeOk)
                            {
                                if (SystemSetting.UseScreenSpaceText)
                                {
                                    AddTrack2DTextBatch(trackData);
                                }
                                else
                                {
                                    dynamicFollowerText.UpdateFrame(
                                        trackData,
                                        SystemSetting.NonUniformScale,
                                        SystemSetting.GlobalTransform
                                    );
                                }
                            }
                            lastDrawTime = DateTime.Now;
                        }
                        else
                        {
                            if (!SystemSetting.UseScreenSpaceText)
                            {
                                dynamicFollowerText.HideAll();
                            }
                        }
                    }
                    else
                    {
                        // 清空跟踪目标
                        trackTargetPoints?.Reset();
                        trackTargetColors?.Reset();
                        trackTargetData?.Modified();
                        // 新增：清空轨迹
                        ClearTrajectoryData();
                        // 隐藏所有文本
                        //dynamicFollowerText.UpdateFrame(
                        //    new List<TargetInfo.RadarTargetInfoStruct>(),
                        //    false,
                        //    null
                        //);
                        if (!SystemSetting.UseScreenSpaceText)
                        {
                            dynamicFollowerText.HideAll();
                        }
                    }

                    // 4. 添加文本（可配置是否限制）
                    if ((SystemSetting.DisplayTargetType == 0 || SystemSetting.DisplayTargetType == 1) && SystemSetting.DisplayText)
                    {
                        // 3. ✅ 智能文本筛选（关键优化！）
                        List<TargetInfo.RadarTargetInfoStruct> textTargets = pointData;

                        // 如果目标太多，启用空间哈希
                        if (pointData.Count > 50)
                        {
                            textTargets = SpatialTextManager.FilterRepresentatives(pointData);
                        }
                        // 按距离排序，只显示最近N个
                        textTargets = SortByCameraDistance(textTargets);

                        // 4. 分帧更新坐标（每3帧更新一次文本位置）
                        //bool shouldUpdateTextPosition = (frameCounter++ % 3 == 0);
                        // 4. 根据配置添加文本（性能分支选择）
                        if (SystemSetting.UseScreenSpaceText)
                        {
                            // ✅ 高性能2D文本方案（200+个不卡顿）
                            Add2DTextBatch(textTargets);
                        }
                        else
                        {
                            // 高质量3D文本方案（严格限制数量）
                            Add3DTextBatch(textTargets);
                        }
                    }
                    // 5. 更新坐标轴文字缩放（远近一致补偿）
                    UpdateAxisLabelScale();
                    // 6. 只渲染一次
                    renderWindow.Render();
                    // 7. 更新GDI文本叠加层
                    if (gdiOverlay.Enabled && textOverlayPanel != null)
                        textOverlayPanel.SetOverlayBitmap(gdiOverlay.GetBitmap());
                }));
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }



        private List<TargetInfo.RadarTargetInfoStruct> SortByCameraDistance(List<TargetInfo.RadarTargetInfoStruct> targets)
        {
            if (firstRenderer == null) return new List<TargetInfo.RadarTargetInfoStruct>(targets.Take(20));

            double cx = cachedCameraPos[0], cy = cachedCameraPos[1], cz = cachedCameraPos[2];
            int takeN = SystemSetting.UseScreenSpaceText ? SystemSetting.Max2DTextCount : SystemSetting.Max3DTextCount;
            return targets
                .OrderBy(t =>
                    (t.XAxis - cx) * (t.XAxis - cx) +
                    (t.YAxis - cy) * (t.YAxis - cy) +
                    (t.ZAxis - cz) * (t.ZAxis - cz))
                .Take(takeN)
                .ToList();
        }

        // 初始化点云Actor（仅执行一次）
        private void InitializePointCloudActor()
        {
            pointCloudPoints = vtkPoints.New();
            pointCloudColors = vtkUnsignedCharArray.New();
            pointCloudColors.SetNumberOfComponents(3);
            pointCloudColors.SetName("Colors");
            pointCloudData = vtkPolyData.New();
            pointCloudMapper = vtkPolyDataMapper.New();
            pointCloudGlyphFilter = vtkVertexGlyphFilter.New();

            pointCloudData.SetPoints(pointCloudPoints);
            pointCloudData.GetPointData().SetScalars(pointCloudColors);

            pointCloudGlyphFilter.SetInputConnection(pointCloudData.GetProducerPort());
            pointCloudMapper.SetInputConnection(pointCloudGlyphFilter.GetOutputPort());
            pointCloudMapper.SetColorMode(0); // 直接使用RGB颜色

            pointCloudActor = vtkActor.New();
            pointCloudActor.SetMapper(pointCloudMapper);
            pointCloudActor.GetProperty().SetPointSize(SystemSetting.PointSize);

            if (SystemSetting.NonUniformScale)
                pointCloudActor.SetUserTransform(SystemSetting.GlobalTransform);
            firstRenderer.AddActor(pointCloudActor);
        }



        private void UpdatePointCloudData(List<TargetInfo.RadarTargetInfoStruct> pointData)
        {
            pointCloudPoints.Reset();
            pointCloudColors.Reset();

            if (SystemSetting.Default_Color)
            {
                double zMin = double.MaxValue, zMax = double.MinValue;
                foreach (var point in pointData)
                {
                    pointCloudPoints.InsertNextPoint(point.XAxis, point.YAxis, point.ZAxis);
                    if (point.ZAxis < zMin) zMin = point.ZAxis;
                    if (point.ZAxis > zMax) zMax = point.ZAxis;
                }
                double zRange = zMax - zMin;
                if (zRange < 0.001) zRange = 1.0;

                for (int i = 0; i < pointData.Count; i++)
                {
                    double z = pointData[i].ZAxis;
                    double t = (z - zMin) / zRange; // 0~1
                    double hue = 0.67 * (1.0 - t); // 紫(0.67) -> 红(0)
                    HsvToRgb(hue, 1.0, 1.0, out byte r, out byte g, out byte b);
                    pointCloudColors.InsertNextTuple3(r, g, b);
                }
            }
            else
            {
                foreach (var point in pointData)
                {
                    pointCloudPoints.InsertNextPoint(point.XAxis, point.YAxis, point.ZAxis);
                    double z = point.ZAxis;
                    if (z > SystemSetting.RedValue)
                        pointCloudColors.InsertNextTuple3(255, 0, 0);
                    else if (z <= SystemSetting.RedValue && z > SystemSetting.OrangeValue)
                        pointCloudColors.InsertNextTuple3(255, 153, 0);
                    else if (z <= SystemSetting.OrangeValue && z > SystemSetting.YellowValue)
                        pointCloudColors.InsertNextTuple3(255, 255, 0);
                    else if (z <= SystemSetting.YellowValue && z > SystemSetting.GreenValue)
                        pointCloudColors.InsertNextTuple3(0, 255, 0);
                    else if (z <= SystemSetting.GreenValue && z > SystemSetting.CyanValue)
                        pointCloudColors.InsertNextTuple3(0, 255, 255);
                    else if (z <= SystemSetting.CyanValue && z > SystemSetting.BlueValue)
                        pointCloudColors.InsertNextTuple3(0, 0, 255);
                    else
                        pointCloudColors.InsertNextTuple3(128, 0, 128);
                }
            }

            pointCloudData.Modified();
        }

        private static void HsvToRgb(double h, double s, double v, out byte r, out byte g, out byte b)
        {
            int hi = (int)(h * 6.0) % 6;
            double f = h * 6.0 - (int)(h * 6.0);
            double p = v * (1.0 - s);
            double q = v * (1.0 - f * s);
            double t = v * (1.0 - (1.0 - f) * s);
            double dr, dg, db;
            switch (hi)
            {
                case 0: dr = v; dg = t; db = p; break;
                case 1: dr = q; dg = v; db = p; break;
                case 2: dr = p; dg = v; db = t; break;
                case 3: dr = p; dg = q; db = v; break;
                case 4: dr = t; dg = p; db = v; break;
                default: dr = v; dg = p; db = q; break;
            }
            r = (byte)(dr * 255.0);
            g = (byte)(dg * 255.0);
            b = (byte)(db * 255.0);
        }

        // 清理点云
        private void ClearPointCloud()
        {
            if (pointCloudActor != null)
            {
                firstRenderer.RemoveViewProp(pointCloudActor);
                pointCloudActor.Dispose();
                pointCloudActor = null;
            }
            if (pointCloudData != null)
            {
                pointCloudData.Dispose();
                pointCloudData = null;
            }
            if (pointCloudPoints != null)
            {
                pointCloudPoints.Dispose();
                pointCloudPoints = null;
            }
            if (pointCloudColors != null)
            {
                pointCloudColors.Dispose();
                pointCloudColors = null;
            }
            if (pointCloudGlyphFilter != null)
            {
                pointCloudGlyphFilter.Dispose();
                pointCloudGlyphFilter = null;
            }
            ClearTextActors();
        }

        // 同步清理文本（使用可见性切换，不从渲染器移除）
        private void ClearTextActors()
        {
            foreach (var actor in active3DTextActors)
            {
                actor.SetVisibility(0);
                actor.SetInput("");
                ReturnTextActorToPool(actor);
            }
            active3DTextActors.Clear();
            foreach (var actor in active2DTextActors)
            {
                actor.SetVisibility(0);
                actor.SetInput("");
                ReturnTextActorToPool(actor);
            }
            active2DTextActors.Clear();
        }
        #region 2D文字
        /// <summary>
        /// 批量添加2D屏幕空间文本（200+个不卡顿）
        /// </summary>
        private void Add2DTextBatch(List<TargetInfo.RadarTargetInfoStruct> pointData)
        {
            int maxTexts = SystemSetting.Max2DTextCount > 0 ?
                Math.Min(pointData.Count, SystemSetting.Max2DTextCount) :
                pointData.Count;

            for (int i = 0; i < maxTexts; i++)
            {
                var actor = Get2DTextActor(pointData[i]);
                if (SystemSetting.NonUniformScale)
                {
                    double[] transformedPos = SystemSetting.TransformPoint(pointData[i].XAxis, pointData[i].YAxis, pointData[i].ZAxis);
                    int[] screenPos = WorldToScreenCoordinates(transformedPos[0], transformedPos[1], transformedPos[2]);
                    actor.SetDisplayPosition(screenPos[0], screenPos[1]);
                }
                actor.SetVisibility(1);
                active2DTextActors.Add(actor);
            }
        }

        private vtkTextActor Get2DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor actor;
            lock (text2DActorPool)
            {
                actor = text2DActorPool.Count > 0 ? text2DActorPool.Dequeue() : null;
            }
            if (actor == null)
            {
                actor = vtkTextActor.New();
                var textProperty = vtkTextProperty.New();
                actor.SetTextProperty(textProperty);
                textProperty.Dispose();
                actor.GetTextProperty().SetColor(1.0, 1.0, 1.0);
                firstRenderer.AddActor2D(actor); // 仅新建时添加一次
            }

            actor.SetInput(VTKHelper.GetDetectionText(tar));
            int[] screenPos = WorldToScreenCoordinates(tar.XAxis, tar.YAxis, tar.ZAxis);
            actor.SetDisplayPosition(screenPos[0], screenPos[1]);

            int fontSize = SystemSetting.Text2DFontSize;
            if (fontSize <= 0) fontSize = 14;
            actor.GetTextProperty().SetFontSize(fontSize);

            return actor;
        }
        private int[] WorldToScreenCoordinates(double worldX, double worldY, double worldZ)
        {
            if (cachedCoordinate == null)
                cachedCoordinate = vtkCoordinate.New();
            cachedCoordinate.SetCoordinateSystemToWorld();
            cachedCoordinate.SetValue(worldX, worldY, worldZ);
            cachedCoordinate.SetViewport(firstRenderer);
            return cachedCoordinate.GetComputedDisplayValue(firstRenderer);
        }

        /// <summary>
        /// .NET Framework兼容的Clamp实现
        /// </summary>
        public double Clamp(double value, double min, double max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
        /// <summary>
        /// 计算到相机距离（用于字体大小衰减）
        /// </summary>
        private double CalculateDistanceToCamera(double x, double y, double z)
        {
            double dx = x - cachedCameraPos[0];
            double dy = y - cachedCameraPos[1];
            double dz = z - cachedCameraPos[2];
            return Math.Max(0.1, Math.Sqrt(dx * dx + dy * dy + dz * dz));
        }

        private void ReturnTextActorToPool(vtkTextActor actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
                firstRenderer.RemoveViewProp(actor);
                actor.Dispose();
                return;
            }

            lock (text2DActorPool)
            {
                if (text2DActorPool.Count < 200)
                {
                    actor.SetInput("");
                    actor.SetDisplayPosition(0, 0);
                    text2DActorPool.Enqueue(actor);
                    return;
                }
            }
            firstRenderer.RemoveViewProp(actor);
            actor.Dispose();
        }
        #endregion 2D文字

        #region 3D文字
        private void Add3DTextBatch(List<TargetInfo.RadarTargetInfoStruct> pointData)
        {
            int maxTexts = SystemSetting.Max3DTextCount > 0 ?
                Math.Min(pointData.Count, SystemSetting.Max3DTextCount) :
                Math.Min(pointData.Count, 15);

            for (int i = 0; i < maxTexts; i++)
            {
                var actor = Get3DTextActor(pointData[i]);
                if (SystemSetting.NonUniformScale)
                    actor.SetUserTransform(SystemSetting.GlobalTransform);
                actor.SetVisibility(1);
                active3DTextActors.Add(actor);
            }
        }

        private vtkTextActor3D Get3DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor3D actor;
            lock (text3DActorPool)
            {
                actor = text3DActorPool.Count > 0 ? text3DActorPool.Dequeue() : null;
            }
            if (actor == null)
            {
                actor = vtkTextActor3D.New();
                firstRenderer.AddActor(actor); // 仅新建时添加一次
            }

            var textProperty = vtkTextProperty.New();
            VTKHelper.SetTextProperty(textProperty);
            actor.SetInput(VTKHelper.GetDetectionText(tar));
            actor.SetTextProperty(textProperty);
            actor.SetPosition(tar.XAxis, tar.YAxis, tar.ZAxis + 0.5);
            actor.SetScale(0.03, 0.03, 0.03);
            actor.RotateX(90.0);

            textProperty.Dispose();
            return actor;
        }
        // 回收TextActor到对象池
        private void ReturnTextActorToPool(vtkTextActor3D actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
                firstRenderer.RemoveViewProp(actor);
                actor.Dispose();
                return;
            }
            lock (text3DActorPool)
            {
                if (text3DActorPool.Count < 200)
                {
                    actor.SetInput("");
                    text3DActorPool.Enqueue(actor);
                    return;
                }
            }
            firstRenderer.RemoveViewProp(actor);
            actor.Dispose();
        }
        #endregion 3D文字

        // 批量更新标签（减少UI刷新）
        private void UpdateLabels(int tarNum = 0, int showNum = 0, int trackNum = 0)
        {
            Invoke((Action)(() =>
            {
                lb_TarNum.Text = $"{tarNum}";
                lb_ShowTarNum.Text = $"{showNum}";
                lb_TrackNum.Text = $"{trackNum}";
            }));
        }
        #endregion 核心变更

        #endregion 新绘图事件

        private string TarsListToString(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            StringBuilder sb = new StringBuilder($"{periodstring}\r\n");
            if (targetInfoList != null)
            {
                int index = 0;
                foreach (TargetInfo.RadarTargetInfoStruct tar in targetInfoList)
                {
                    sb.AppendLine($"{tar.SaveTime}--{index}--,id ={tar.ID},x = {tar.XAxis:F6},y = {tar.YAxis:F6},z = {tar.ZAxis:F6},v = {tar.Velocity:F6},rcs = {tar.RCS:F6},type = {tar.Type:F6}");
                    index++;
                }
            }
            return sb.ToString();
        }
        private string AllTarsListToString(string time, List<TargetInfo.RadarTargetInfoStruct> trackList, List<TargetInfo.RadarTargetInfoStruct> targetInfoList)
        {
            StringBuilder sb = new StringBuilder($"{periodstringPointTrack}\r\n");
            int index = 0;
            if (targetInfoList != null)
            {
                foreach (TargetInfo.RadarTargetInfoStruct tar in targetInfoList)
                {
                    sb.AppendLine($"{tar.SaveTime}--{index}--Point--,id ={tar.ID},x = {tar.XAxis:F6},y = {tar.YAxis:F6},z = {tar.ZAxis:F6},v = {tar.Velocity:F6},rcs = {tar.RCS:F6},type = {tar.Type},class = {tar.Class},a = {tar.PAngle:F6},pitch = {tar.TAngle:F6},snr = {tar.SNR:F6},confidence = {tar.Confidence},acc = {tar.RadarAcc:F6}");
                    index++;
                }
            }
            if (trackList != null)
            {
                foreach (TargetInfo.RadarTargetInfoStruct tar in trackList)
                {
                    sb.AppendLine($"{tar.SaveTime}--{index}--Track--,id ={tar.ID},x = {tar.XAxis:F6},y = {tar.YAxis:F6},z = {tar.ZAxis:F6},v = {tar.Velocity:F6},rcs = {tar.RCS:F6},type = {tar.Type},class = {tar.Class},a = {tar.PAngle:F6},pitch = {tar.TAngle:F6},snr = {tar.SNR:F6},confidence = {tar.Confidence},acc = {tar.RadarAcc:F6}");
                    index++;
                }
            }
            return sb.ToString();
        }

        #region 点云跟踪
        /// <summary>
        /// 程序是否失去焦点
        /// </summary>
        bool isLostFocus = false;
        /// <summary>
        /// WinForms + VTK 窗体最小化时渲染性能下降 的问题。根本原因是：当窗体最小化时，RenderWindow 的渲染循环被系统暂停或降频，导致数据堆积、延迟
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112 && (m.WParam.ToInt32() & 0xFFF0) == 0xF020) // WM_SYSCOMMAND SC_MINIMIZE
            {
                // 最小化前：启用离屏渲染模式，防止上下文丢失
                if (renderWindow != null)
                {
                    renderWindow.SetOffScreenRendering(1);
                }
                // 清空积压数据
                lock (trajectoryLock)
                {
                    trackTrajectories.Clear();
                }
                targetFrameTemp.Clear();
                targetTemp.Clear();
            }
            else if (m.Msg == 0x0112 && (m.WParam.ToInt32() & 0xFFF0) == 0xF120) // SC_RESTORE
            {
                // 恢复时：切回屏幕渲染并强制重建上下文
                this.BeginInvoke(new Action(() =>
                {
                    if (renderWindow != null)
                    {
                        renderWindow.SetOffScreenRendering(0);
                        // 强制重建OpenGL上下文
                        if (renderWindow.IsA("vtkWin32OpenGLRenderWindow") != 0)
                        {
                            renderWindow.Modified();
                            renderWindow.MakeCurrent();
                        }
                        // 第一帧先清空显示，避免渲染旧数据
                        ClearPointCloud();
                        ClearTrackTargets();
                        ClearTrajectoryData();
                        firstRenderer.ResetCameraClippingRange();
                        renderWindow.Render();
                    }
                }));
            }
            else if (m.Msg == 0x001C)
            {
                // 失去/恢复焦点时只做帧率节流，不切换渲染模式
                if (m.WParam.ToInt32() == 0)
                {
                    isLostFocus = true;
                }
                else
                {
                    isLostFocus = false;
                }
            }
            base.WndProc(ref m);
        }
        /// <summary>
        /// 点云和跟踪一起
        /// </summary>
        /// <param name="targetInfoList"></param>
        /// <param name="clusterInfoList"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Radar_tarAndClusterPointCloud(string time, List<TargetInfo.RadarTargetInfoStruct> targetInfoList, List<TargetInfo.RadarTargetInfoStruct> clusterInfoList)
        {
            curFrameNum++;
            int tarNum = targetInfoList == null ? 0 : targetInfoList.Count;
            int cluListCount = clusterInfoList == null ? 0 : clusterInfoList.Count;
            if (trackDataReceived != null)
                trackDataReceived(targetInfoList);
            if (SystemSetting.TargetData && !isReplaying)//回放时不存储
            {
                if (saveData == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//Clusters"))
                    {
                        if ((saveData = new QueueSaveData($"{SystemSetting.FileRoute}//Clusters", 0, "txt", SystemSetting.FileSize, "Cluster")) != null)
                            saveData.AddQueue(TarsListToString(time, clusterInfoList));
                    }
                }
                else
                    saveData.AddQueue(TarsListToString(time, clusterInfoList));
                if (saveDataTrack == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//Tracks"))
                    {
                        if ((saveDataTrack = new QueueSaveData($"{SystemSetting.FileRoute}//Tracks", 0, "txt", SystemSetting.FileSize, "Track")) != null)
                            saveDataTrack.AddQueue(TarsListToString(time, targetInfoList));
                    }
                }
                else
                    saveDataTrack.AddQueue(TarsListToString(time, targetInfoList));
                if (saveDataPointTrack == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//PointsAndTracks"))
                    {
                        if ((saveDataPointTrack = new QueueSaveData($"{SystemSetting.FileRoute}//PointsAndTracks", 0, "txt", SystemSetting.FileSize, "PointAndTrack")) != null)
                            saveDataPointTrack.AddQueue(AllTarsListToString(time, clusterInfoList, targetInfoList));
                    }
                }
                else
                    saveDataPointTrack.AddQueue(AllTarsListToString(time, clusterInfoList, targetInfoList));
            }
            else//以防测试过程中修改了保存设置
            {
                saveData?.Dispose();
                saveData = null;
                saveDataTrack?.Dispose();
                saveDataTrack = null;
                saveDataPointTrack?.Dispose();
                saveDataPointTrack = null;
            }
            List<TargetInfo.RadarTargetInfoStruct> LoadTemp;
            if (SystemSetting.CumulativeFrameNum <= 1)
            {
                LoadTemp = clusterInfoList;
            }
            else
            {
                targetFrameTemp.Add(clusterInfoList);
                targetTemp.Clear();
                foreach (var item in targetFrameTemp)
                    targetTemp.AddRange(item);
                LoadTemp = new List<TargetInfo.RadarTargetInfoStruct>(targetTemp);
                if (targetFrameTemp.Count >= SystemSetting.CumulativeFrameNum)
                {
                    if (SystemSetting.CumulativeFrameType == 1)
                        targetFrameTemp.Clear();
                    else
                    {
                        int removeNum = targetFrameTemp.Count - SystemSetting.CumulativeFrameNum;
                        if (removeNum > 0)
                            targetFrameTemp.RemoveRange(0, removeNum + 1);
                        else if (removeNum == 0)
                            targetFrameTemp.RemoveAt(0);
                    }
                }
            }
            List<TargetInfo.RadarTargetInfoStruct> TrackTemp = targetInfoList;
            UpdateLabels(clusterInfoList.Count, LoadTemp.Count, tarNum);
            lock (trajectoryLock)
            {
                // 1. 更新轨迹队列：添加新点，移除旧点
                HashSet<uint> currentIds = new HashSet<uint>();
                if (TrackTemp != null && TrackTemp.Count > 0)
                {
                    //DateTime dt = DateTime.Parse(trackData[0].SaveTime);
                    foreach (var target in TrackTemp)
                    {
                        uint id = target.ID;
                        currentIds.Add(id);

                        if (!trackTrajectories.ContainsKey(id))
                        {
                            trackTrajectories[id] = new Queue<TargetInfo.RadarTargetInfoStruct>();
                        }

                        var queue = trackTrajectories[id];
                        queue.Enqueue(target);

                        // 限制轨迹长度
                        while (queue.Count > SystemSetting.TrackTrajectoryPointCount)
                            queue.Dequeue();
                    }
                }

                if (SystemSetting.ClearTrackTrajectoryType == 0)
                {
                    // 2. 处理消失的跟踪目标轨迹
                    var deadTracks = trackTrajectories.Where(keyValuePair => !currentIds.Contains(keyValuePair.Key)).ToList();
                    foreach (var deadTrack in deadTracks)
                    {
                        if (deadTrack.Value == null || deadTrack.Value.Count <= 0)//没有轨迹点
                            trackTrajectories.Remove(deadTrack.Key);
                        else if (deadTrack.Value != null && deadTrack.Value.Count > 0 && (DateTime.Now - DateTime.Parse(deadTrack.Value.Last().SaveTime)).TotalMilliseconds > SystemSetting.TrackTrajectoryTime)
                            trackTrajectories.Remove(deadTrack.Key);
                        else
                        {
                            deadTrack.Value.Dequeue();
                            //trackTrajectories[deadTrack.Key] = deadTrack.Value;
                        }
                    }
                }
                else
                {
                    // 2. 清理消失的跟踪目标轨迹
                    var deadTracks = trackTrajectories.Keys.Where(id => !currentIds.Contains(id)).ToList();
                    foreach (var deadId in deadTracks)
                    {
                        trackTrajectories.Remove(deadId);
                    }
                }
            }
            if (isLostFocus)
            {
                int throttle = SystemSetting.VtkDrawTimeInLostFocus > 0 ? SystemSetting.VtkDrawTimeInLostFocus : 500;
                if ((DateTime.Now - lastDrawTime).TotalMilliseconds < throttle)
                    return;
            }

            // 渲染节流：跳帧时仅积累数据，不触发渲染
            if (SystemSetting.RenderIntervalMs > 0)
            {
                double elapsed = (DateTime.Now - lastRenderTime).TotalMilliseconds;
                if (elapsed < SystemSetting.RenderIntervalMs)
                {
                    renderSkipped = true;
                    return;
                }
            }
            lastRenderTime = DateTime.Now;
            var filterIds = SystemSetting.GetFilterTrackIdSet();
            var filteredTrackTemp = (filterIds != null && TrackTemp != null)
                ? TrackTemp.Where(t => filterIds.Contains(t.ID)).ToList()
                : TrackTemp;
            UpdatePointCloud(LoadTemp, filteredTrackTemp);

        }

        #region 跟踪模块
        /// <summary>
        /// 初始化跟踪目标Actor（仅执行一次）
        /// 使用球体代替点，便于区分点云
        /// </summary>
        private void InitializeTrackTargetActor()
        {
            // 清理旧数据（如果存在）
            if (trackTargetActor != null)
            {
                ClearTrackTargets();
            }
            // 创建点数据
            trackTargetPoints = vtkPoints.New();
            trackTargetData = vtkPolyData.New();
            trackTargetData.SetPoints(trackTargetPoints);
            // 根据配置决定是否创建颜色数组（关键区别）
            if (SystemSetting.TrackColorMode == 1) // ID着色模式
            {
                trackTargetColors = vtkUnsignedCharArray.New();
                trackTargetColors.SetName("Colors");
                trackTargetColors.SetNumberOfComponents(3); // RGB
                trackTargetData.GetPointData().SetScalars(trackTargetColors);
            }

            // 创建球体模板（所有跟踪目标共用）
            trackSphereSource = vtkSphereSource.New();
            trackSphereSource.SetRadius(SystemSetting.TrackSize); // 球体半径，根据实际场景调整
            trackSphereSource.SetPhiResolution(8); // 降低精度提升性能
            trackSphereSource.SetThetaResolution(8);

            // Glyph3D将球体复制到每个点位置
            trackGlyphFilter = vtkGlyph3D.New();
            trackGlyphFilter.SetSourceConnection(trackSphereSource.GetOutputPort());
            trackGlyphFilter.SetInput(trackTargetData);
            trackGlyphFilter.SetScaleModeToDataScalingOff(); // 统一大小
            trackGlyphFilter.SetScaleFactor(1.0);
            // 修复：确保颜色传递
            //trackGlyphFilter.SetColorModeToColorByScalar(); // 明确按标量着色

            trackTargetMapper = vtkPolyDataMapper.New();
            trackTargetMapper.SetInputConnection(trackGlyphFilter.GetOutputPort());
            // 根据配置配置Mapper颜色行为（关键区别）
            if (SystemSetting.TrackColorMode == 1) // ID着色模式
            {
                trackGlyphFilter.SetColorModeToColorByScalar();
                trackTargetMapper.SetScalarModeToUsePointData();
                trackTargetMapper.SetColorMode(0); // 直接使用RGB值
            }
            else // 统一颜色模式
            {
                trackTargetMapper.ScalarVisibilityOff(); // 关闭标量颜色映射，使用Actor属性
            }
            //trackTargetMapper.SetColorMode(2); // 直接使用RGB颜色
            //trackTargetMapper.SetColorModeToMapScalars(); // 直接使用RGB颜色
            //trackTargetMapper.SetScalarRange(0.0, 1.0);

            trackTargetActor = vtkActor.New();
            trackTargetActor.SetMapper(trackTargetMapper);
            // 设置高亮度材质，使其更醒目
            trackTargetActor.GetProperty().SetLighting(true);
            trackTargetActor.GetProperty().SetSpecular(0.5);
            trackTargetActor.GetProperty().SetSpecularPower(20);
            // 关键：直接在 Property 上设置颜色（最简单可靠）
            // 统一颜色模式下设置初始颜色
            if (SystemSetting.TrackColorMode == 0)
            {
                UpdateTrackColor();
            }
            // 关键：应用全局变换
            if (SystemSetting.NonUniformScale)
                trackTargetActor.SetUserTransform(SystemSetting.GlobalTransform);
            firstRenderer.AddActor(trackTargetActor);
        }

        #region 跟踪点颜色
        // 更新颜色方法（当设置改变时调用）
        public void UpdateTrackColor()
        {
            if (trackTargetActor == null) return;

            if (SystemSetting.TrackColorMode == 0) // 统一颜色模式
            {
                trackTargetActor.GetProperty().SetColor(
                    SystemSetting.TrackColor.R / 255.0,
                    SystemSetting.TrackColor.G / 255.0,
                    SystemSetting.TrackColor.B / 255.0
                );

                // 确保标量颜色关闭（如果之前是ID着色模式切换过来）
                if (trackTargetMapper != null)
                {
                    trackTargetMapper.ScalarVisibilityOff();
                }
            }
            else // ID着色模式
            {
                // 颜色由顶点数据数组控制，这里只需确保标量可见性开启
                if (trackTargetMapper != null)
                {
                    trackTargetMapper.ScalarVisibilityOn();
                }

                // 如果颜色映射算法改变，触发数据更新重绘
                trackTargetData?.Modified();
            }
        }

        #endregion 跟踪点颜色

        /// <summary>
        /// 更新跟踪目标数据 - 使用固定颜色区分（例如红色球体）
        /// </summary>
        private void UpdateTrackTargetData(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            trackTargetPoints.Reset();
            // ID着色模式：更新位置和颜色数组
            if (SystemSetting.TrackColorMode == 1 && trackTargetColors != null)
            {
                trackTargetColors.Reset();

                foreach (var target in trackData)
                {
                    trackTargetPoints.InsertNextPoint(target.XAxis, target.YAxis, target.ZAxis);

                    // 根据ID获取颜色
                    PubClass.GetColorById(target.ID, out byte r, out byte g, out byte b);
                    trackTargetColors.InsertNextTuple3(r, g, b);
                }
            }
            else // 统一颜色模式：只更新位置
            {
                foreach (var target in trackData)
                {
                    trackTargetPoints.InsertNextPoint(target.XAxis, target.YAxis, target.ZAxis);
                }
            }

            trackTargetData.Modified();
        }

        #region 跟踪目标文字（独立管理，确保全部显示）

        /// <summary>
        /// GDI+ 位图叠加方式渲染跟踪文本：所有文本绘制到一张位图，1次draw call
        /// </summary>
        private void RenderTrackTextGdiOverlay(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            if (gdiOverlay == null || textOverlayPanel == null) return;

            gdiOverlay.Enabled = true;
            gdiOverlay.TextFont = new Font("Consolas",
                SystemSetting.Text2DFontSize > 0 ? SystemSetting.Text2DFontSize : 12,
                FontStyle.Bold);
            gdiOverlay.TextColor = SystemSetting.TrackTextColor;

            gdiOverlay.BeginFrame();

            int maxTargets = gdiOverlay.MaxTargets;
            int count = Math.Min(trackData.Count, maxTargets);

            for (int i = 0; i < count; i++)
            {
                var target = trackData[i];

                double wx = target.XAxis;
                double wy = target.YAxis + SystemSetting.TrackSize + 1.2;
                double wz = target.ZAxis;

                if (SystemSetting.NonUniformScale)
                {
                    double[] t = SystemSetting.TransformPoint(wx, wy, wz);
                    wx = t[0]; wy = t[1]; wz = t[2];
                }

                int[] screen = WorldToScreenCoordinates(wx, wy, wz);
                string text = VTKHelper.GetDetectionTextH(target);

                float sx = ClampScreenX(screen[0]);
                float sy = ClampScreenY(screen[1] + 15);

                gdiOverlay.DrawTarget(text, sx, sy);
            }

            gdiOverlay.EndFrame();
        }

        private float ClampScreenX(int x)
        {
            int w = renderWindowControl1?.Width ?? 870;
            return Math.Max(0, Math.Min(x, w - 120));
        }

        private float ClampScreenY(int y)
        {
            int h = renderWindowControl1?.Height ?? 745;
            return Math.Max(0, Math.Min(y, h - 20));
        }

        private void AddTrack2DTextBatch(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            int maxTexts = SystemSetting.Max2DTextCount > 0
                ? Math.Min(trackData.Count, SystemSetting.Max2DTextCount)
                : trackData.Count;

            var sorted = maxTexts < trackData.Count
                ? trackData.OrderBy(t =>
                {
                    double dx = t.XAxis - cachedCameraPos[0];
                    double dy = t.YAxis - cachedCameraPos[1];
                    double dz = t.ZAxis - cachedCameraPos[2];
                    return dx * dx + dy * dy + dz * dz;
                }).Take(maxTexts)
                : (IEnumerable<TargetInfo.RadarTargetInfoStruct>)trackData;

            foreach (var target in sorted)
            {
                var actor = GetTrack2DTextActor(target);
                if (actor == null) continue;
                if (SystemSetting.NonUniformScale)
                {
                    double[] transformedPos = SystemSetting.TransformPoint(target.XAxis, target.YAxis, target.ZAxis);
                    int[] screenPos = WorldToScreenCoordinates(transformedPos[0], transformedPos[1], transformedPos[2]);
                    actor.SetDisplayPosition(screenPos[0], screenPos[1] + 15);
                }
                actor.SetVisibility(1);
                activeTrack2DTextActors.Add(actor);
            }
        }

        /// <summary>
        /// 废弃
        /// </summary>
        /// <param name="trackData"></param>
        private void AddTrack3DTextBatch(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            int maxTexts = SystemSetting.Max3DTextCount > 0
                ? Math.Min(trackData.Count, SystemSetting.Max3DTextCount)
                : trackData.Count;

            var sorted = maxTexts < trackData.Count
                ? trackData.OrderBy(t =>
                {
                    double dx = t.XAxis - cachedCameraPos[0];
                    double dy = t.YAxis - cachedCameraPos[1];
                    double dz = t.ZAxis - cachedCameraPos[2];
                    return dx * dx + dy * dy + dz * dz;
                }).Take(maxTexts)
                : (IEnumerable<TargetInfo.RadarTargetInfoStruct>)trackData;

            foreach (var target in sorted)
            {
                var actor = GetTrack3DTextActor(target);
                if (SystemSetting.NonUniformScale)
                    actor.SetUserTransform(SystemSetting.GlobalTransform);
                actor.SetVisibility(1);
                activeTrack3DTextActors.Add(actor);
            }
        }

        private vtkTextActor GetTrack2DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor actor;
            lock (trackText2DActorPool)
            {
                actor = trackText2DActorPool.Count > 0 ? trackText2DActorPool.Dequeue() : null;
            }
            if (actor == null)
            {
                actor = vtkTextActor.New();
                var textProperty = vtkTextProperty.New();
                actor.SetTextProperty(textProperty);
                textProperty.SetColor(SystemSetting.TrackTextColor.R / 255d, SystemSetting.TrackTextColor.G / 255d, SystemSetting.TrackTextColor.B / 255d);
                textProperty.SetBold(1);
                textProperty.SetFontSize(12);
                textProperty.Dispose();
                firstRenderer.AddActor2D(actor);
            }
            string text = VTKHelper.GetDetectionTextH(tar);
            if (string.IsNullOrWhiteSpace(text))
            {
                // 空文本会导致VTK FreeType报错，不显示
                actor.SetVisibility(0);
                ReturnTrackTextActorToPool(actor);
                return null;
            }
            actor.SetInput(text);
            int[] screenPos = WorldToScreenCoordinates(tar.XAxis, tar.YAxis, tar.ZAxis);
            actor.SetDisplayPosition(screenPos[0], screenPos[1] + 15);
            return actor;
        }
        /// <summary>
        /// 获取文本在屏幕上的像素尺寸
        /// </summary>
        private int[] GetTextDisplaySize(vtkTextActor actor)
        {
            try
            {
                // 方法1：使用vtkTextMapper（如果可用）
                var mapper = actor.GetMapper();
                if (mapper != null && mapper.IsA("vtkTextMapper") != 0)
                {
                    int[] size = new int[2];
                    // vtkTextMapper.GetSize需要viewport，这里用近似值
                    // 返回估计尺寸：字符数 * 字体大小 * 0.6（近似系数）
                    string text = actor.GetInput() ?? "";
                    int fontSize = actor.GetTextProperty().GetFontSize();
                    size[0] = (int)(text.Length * fontSize * 0.6);
                    size[1] = fontSize;
                    return size;
                }
            }
            catch { }

            // 方法2：保守估计
            string txt = actor.GetInput() ?? "";
            int fs = actor.GetTextProperty().GetFontSize();
            return new int[] { (int)(txt.Length * fs * 0.6), fs };
        }
        private vtkTextActor3D GetTrack3DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor3D actor;
            lock (trackText3DActorPool)
            {
                actor = trackText3DActorPool.Count > 0 ? trackText3DActorPool.Dequeue() : null;
            }
            if (actor == null)
            {
                actor = vtkTextActor3D.New();
                firstRenderer.AddActor(actor); // 仅新建时添加一次
            }

            var textProperty = vtkTextProperty.New();
            textProperty.SetColor(SystemSetting.TrackTextColor.R / 255d, SystemSetting.TrackTextColor.G / 255d, SystemSetting.TrackTextColor.B / 255d);
            textProperty.SetFontSize(SystemSetting.TrackTextSize);
            textProperty.SetBold(1);
            textProperty.SetJustificationToCentered();

            string text = VTKHelper.GetDetectionTextH(tar);
            actor.SetInput(text);
            actor.SetTextProperty(textProperty);
            double approxCharWidth = 25 * 0.6 * 0.04;
            double textWidth = text.Length * approxCharWidth;
            actor.SetPosition(tar.XAxis - (textWidth / 2), tar.YAxis + (SystemSetting.TrackSize), tar.ZAxis);
            actor.SetScale(0.04, 0.04, 0.04);
            actor.SetOrientation(0, 0, 0);

            textProperty.Dispose();
            return actor;
        }

        /// <summary>
        /// 清理跟踪目标文字
        /// </summary>
        private void ClearTrackTextActors()
        {
            foreach (var actor in activeTrack3DTextActors)
            {
                actor.SetVisibility(0);
                ReturnTrackTextActorToPool(actor);
            }
            activeTrack3DTextActors.Clear();

            foreach (var actor in activeTrack2DTextActors)
            {
                actor.SetVisibility(0);
                ReturnTrackTextActorToPool(actor);
            }
            activeTrack2DTextActors.Clear();
        }

        private void ReturnTrackTextActorToPool(vtkTextActor3D actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
                firstRenderer.RemoveViewProp(actor);
                actor.Dispose();
                return;
            }
            lock (trackText3DActorPool)
            {
                if (trackText3DActorPool.Count < 200)
                {
                    actor.SetInput("");
                    trackText3DActorPool.Enqueue(actor);
                    return;
                }
            }
            firstRenderer.RemoveViewProp(actor);
            actor.Dispose();
        }

        private void ReturnTrackTextActorToPool(vtkTextActor actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
                firstRenderer.RemoveViewProp(actor);
                actor.Dispose();
                return;
            }
            lock (trackText2DActorPool)
            {
                if (trackText2DActorPool.Count < 200)
                {
                    actor.SetInput("");
                    actor.SetDisplayPosition(0, 0);
                    trackText2DActorPool.Enqueue(actor);
                    return;
                }
            }
            firstRenderer.RemoveViewProp(actor);
            actor.Dispose();
        }
        #endregion 跟踪目标文字

        /// <summary>
        /// 清理跟踪目标相关资源
        /// </summary>
        private void ClearTrackTargets()
        {
            if (trackTargetActor != null)
            {
                firstRenderer?.RemoveViewProp(trackTargetActor);
                trackTargetActor.Dispose();
                trackTargetActor = null;
            }
            if (trackTargetMapper != null)
            {
                trackTargetMapper.Dispose();
                trackTargetMapper = null;
            }
            if (trackGlyphFilter != null)
            {
                trackGlyphFilter.Dispose();
                trackGlyphFilter = null;
            }
            if (trackSphereSource != null)
            {
                trackSphereSource.Dispose();
                trackSphereSource = null;
            }
            if (trackTargetData != null)
            {
                trackTargetData.Dispose();
                trackTargetData = null;
            }
            if (trackTargetColors != null)
            {
                trackTargetColors.Dispose();
                trackTargetColors = null;
            }
            if (trackTargetPoints != null)
            {
                trackTargetPoints.Dispose();
                trackTargetPoints = null;
            }
            ClearTrackTextActors();
        }

                #region 跟踪轨迹
        /// <summary>
        /// 初始化/重建轨迹（设置变更时调用，清空所有Actor由下一帧重建）
        /// </summary>
        private void InitializeTrajectoryActor()
        {
            ClearTrajectory();
        }

        /// <summary>
        /// 更新所有轨迹Actor的颜色和线宽
        /// </summary>
        public void UpdateTrajectoryColor()
        {
            lock (trajectoryLock)
            {
                float lineWidth = SystemSetting.TrackTrajectoryLineWidth;
                foreach (var kvp in trajectoryActors)
                {
                    var actor = kvp.Value.Actor;
                    actor.GetProperty().SetLineWidth(lineWidth);
                    if (SystemSetting.TrackColorMode == 0)
                    {
                        actor.GetProperty().SetColor(
                            SystemSetting.TrackTrajectoryColor.R / 255.0,
                            SystemSetting.TrackTrajectoryColor.G / 255.0,
                            SystemSetting.TrackTrajectoryColor.B / 255.0
                        );
                        kvp.Value.Mapper.ScalarVisibilityOff();
                    }
                    else
                    {
                        PubClass.GetColorById(kvp.Key, out byte r, out byte g, out byte b);
                        actor.GetProperty().SetColor(r / 255.0, g / 255.0, b / 255.0);
                    }
                }
            }
        }

        /// <summary>
        /// 更新轨迹数据（每帧调用）
        /// 每目标独立Actor：活跃目标增量追加线段，消失目标直接移除Actor
        /// </summary>
        private void UpdateTrajectoryData(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            if (!SystemSetting.DisplayTrackTrajectory || firstRenderer == null)
            {
                ClearTrajectoryData();
                return;
            }
            lock (trajectoryLock)
            {
                HashSet<uint> currentIds = trackData != null
                    ? new HashSet<uint>(trackData.Select(t => t.ID))
                    : new HashSet<uint>();

                float lineWidth = SystemSetting.TrackTrajectoryLineWidth;
                int colorMode = SystemSetting.TrackColorMode;
                Color uniformColor = SystemSetting.TrackTrajectoryColor;
                bool nonUniformScale = SystemSetting.NonUniformScale;

                // 1. 处理活跃目标：新建Actor 或 增量/重建
                bool needRebuild = renderSkipped;
                renderSkipped = false;

                foreach (var id in currentIds)
                {
                    if (!trackTrajectories.TryGetValue(id, out var queue) || queue.Count < 2)
                        continue;

                    if (!trajectoryActors.TryGetValue(id, out var actorData))
                    {
                        actorData = CreateTrajectoryActor(id, queue, lineWidth, colorMode, uniformColor, nonUniformScale);
                        trajectoryActors[id] = actorData;
                    }
                    else if (needRebuild)
                    {
                        RebuildActorFromQueue(actorData, queue);
                    }
                    else
                    {
                        AppendTrajectorySegment(actorData, queue, lineWidth);
                    }
                }

                // 2. 移除已消失目标的Actor
                var staleIds = trajectoryActors.Keys.Where(k => !currentIds.Contains(k)).ToList();
                foreach (var id in staleIds)
                {
                    RemoveTrajectoryActor(id);
                }

                // 打印每个ID轨迹的VTK总点数
                foreach (var kvp in trajectoryActors)
                {
                    Console.WriteLine($"ID={kvp.Key}, VTK点数={kvp.Value.Points.GetNumberOfPoints()}");
                }
            }
        }

        private TrajectoryActorData CreateTrajectoryActor(uint id, Queue<TargetInfo.RadarTargetInfoStruct> queue,
            float lineWidth, int colorMode, Color uniformColor, bool nonUniformScale)
        {
            var data = new TrajectoryActorData();

            data.Points = vtkPoints.New();
            data.Lines = vtkCellArray.New();
            data.Data = vtkPolyData.New();
            data.Data.SetPoints(data.Points);
            data.Data.SetLines(data.Lines);

            int count = 0;
            foreach (var pt in queue)
            {
                data.Points.InsertNextPoint(pt.XAxis, pt.YAxis, pt.ZAxis);
                count++;
            }

            if (count >= 2)
            {
                using (vtkIdList idList = vtkIdList.New())
                {
                    idList.SetNumberOfIds(count);
                    for (int i = 0; i < count; i++)
                        idList.SetId(i, i);
                    data.Lines.InsertNextCell(idList);
                }
            }
            data.Data.Modified();

            data.Mapper = vtkPolyDataMapper.New();
            data.Mapper.SetInput(data.Data);
            data.Mapper.ScalarVisibilityOff();

            data.Actor = vtkActor.New();
            data.Actor.SetMapper(data.Mapper);
            data.Actor.GetProperty().SetLineWidth(lineWidth);

            if (colorMode == 1)
            {
                PubClass.GetColorById(id, out byte r, out byte g, out byte b);
                data.Actor.GetProperty().SetColor(r / 255.0, g / 255.0, b / 255.0);
            }
            else
            {
                data.Actor.GetProperty().SetColor(
                    uniformColor.R / 255.0, uniformColor.G / 255.0, uniformColor.B / 255.0);
            }

            if (nonUniformScale)
                data.Actor.SetUserTransform(SystemSetting.GlobalTransform);

            firstRenderer.AddActor(data.Actor);
            return data;
        }

        private void AppendTrajectorySegment(TrajectoryActorData data, Queue<TargetInfo.RadarTargetInfoStruct> queue, float lineWidth)
        {
            int maxPoints = SystemSetting.TrackTrajectoryPointCount;

            if (data.Points.GetNumberOfPoints() >= maxPoints)
            {
                RebuildActorFromQueue(data, queue);
            }
            else
            {
                var lastPt = queue.Last();
                int prevIdx = data.Points.GetNumberOfPoints() - 1;
                int newIdx = data.Points.InsertNextPoint(lastPt.XAxis, lastPt.YAxis, lastPt.ZAxis);

                using (vtkIdList idList = vtkIdList.New())
                {
                    idList.SetNumberOfIds(2);
                    idList.SetId(0, prevIdx);
                    idList.SetId(1, newIdx);
                    data.Lines.InsertNextCell(idList);
                }

                data.Data.Modified();
            }

            data.Actor.GetProperty().SetLineWidth(lineWidth);
        }

        private void RebuildActorFromQueue(TrajectoryActorData data, Queue<TargetInfo.RadarTargetInfoStruct> queue)
        {
            data.Points.Reset();
            data.Lines.Reset();

            int count = 0;
            foreach (var pt in queue)
            {
                data.Points.InsertNextPoint(pt.XAxis, pt.YAxis, pt.ZAxis);
                count++;
            }

            if (count >= 2)
            {
                using (vtkIdList idList = vtkIdList.New())
                {
                    idList.SetNumberOfIds(count);
                    for (int i = 0; i < count; i++)
                        idList.SetId(i, i);
                    data.Lines.InsertNextCell(idList);
                }
            }

            data.Data.Modified();
        }

        private void RemoveTrajectoryActor(uint id)
        {
            if (!trajectoryActors.TryGetValue(id, out var data))
                return;

            firstRenderer?.RemoveViewProp(data.Actor);
            data.Actor?.Dispose();
            data.Mapper?.Dispose();
            data.Data?.Dispose();
            data.Points?.Dispose();
            data.Lines?.Dispose();
            trajectoryActors.Remove(id);
        }

        /// <summary>
        /// 清空轨迹数据
        /// </summary>
        private void ClearTrajectoryData()
        {
            lock (trajectoryLock)
            {
                trackTrajectories.Clear();
            }

            var ids = trajectoryActors.Keys.ToList();
            foreach (var id in ids)
                RemoveTrajectoryActor(id);
        }

        /// <summary>
        /// 完全清理轨迹资源（用于关闭/断开时）
        /// </summary>
        private void ClearTrajectory()
        {
            ClearTrajectoryData();
        }

        #endregion 跟踪轨迹


        #endregion 跟踪模块

        #endregion 点云跟踪

        #region 算法要求格式保存
        private void Radar_pointCloudSaveEvent(uint frame, List<PointCloudData> list, List<TrackData> trackList)
        {
            if (SystemSetting.TargetData)
            {
                if (saveDataClusterAlog == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//ClusterAlogFormat"))
                    {
                        if ((saveDataClusterAlog = new QueueSaveData($"{SystemSetting.FileRoute}//ClusterAlogFormat", 0, "csv", SystemSetting.FileSize, "ClusterAlogFormat")) != null)
                        {
                            saveDataClusterAlog.AddQueue($"{saveDataClusterAlogHead}\r\n");
                            saveDataClusterAlog.AddQueue(ClusterListToStringAlog(frame, list));
                        }
                    }
                }
                else
                    saveDataClusterAlog.AddQueue(ClusterListToStringAlog(frame, list));
            }
            else//以防测试过程中修改了保存设置
            {
                saveDataClusterAlog?.Dispose();
                saveDataClusterAlog = null;
            }
        }

        private string ClusterListToStringAlog(uint frame, List<PointCloudData> clusterList)
        {
            StringBuilder sb = new StringBuilder();
            if (clusterList != null)
            {
                int index = 0;
                foreach (PointCloudData clu in clusterList)
                {
                    sb.AppendLine($"{frame},{clu.Range:F3},{clu.Azimuth:F3},{clu.Elevation:F3},{clu.Velocity:F3},{clu.SNR:F3},{clu.V_EGO_X:F3},{clu.V_EGO_Y:F3},{clu.V_EGO_Z:F3}");
                    index++;
                }
            }
            return sb.ToString();
        }
        #endregion 算法要求格式保存

        #region 扩展数据保存
        private void Radar_imuAndGpsSaveEvent(string time, IMUAndGPSData imuAndGpsData)
        {
            string gpsState = imuAndGpsData != null && Math.Abs(imuAndGpsData.GpsLat - (-214.7483648)) > 0.000000001 ? "Valid" : "Invalid";
            if (gpsInfoDataReceived != null)
                gpsInfoDataReceived(imuAndGpsData);
            this.BeginInvoke((EventHandler)delegate { lb_Gps.Text = gpsState; });
            if (SystemSetting.TargetData)
            {
                if (saveDataImuAndGps == null)
                {
                    if (PubClass.EnsureFolderPath($"{SystemSetting.FileRoute}//ImuAndGpsFormat"))
                    {
                        if ((saveDataImuAndGps = new QueueSaveData($"{SystemSetting.FileRoute}//ImuAndGpsFormat", 0, "csv", SystemSetting.FileSize, "ImuAndGpsFormat")) != null)
                        {
                            saveDataImuAndGps.AddQueue($"{saveDataImuAndGpsHead}\r\n");
                            saveDataImuAndGps.AddQueue(ImuAndGpsToString(time, imuAndGpsData));
                        }
                    }
                }
                else
                    saveDataImuAndGps.AddQueue(ImuAndGpsToString(time, imuAndGpsData));
            }
            else//以防测试过程中修改了保存设置
            {
                saveDataImuAndGps?.Dispose();
                saveDataImuAndGps = null;
            }
        }

        private string ImuAndGpsToString(string time, IMUAndGPSData imuAndGpsData)
        {
            StringBuilder sb = new StringBuilder();
            if (imuAndGpsData != null)
            {
                sb.AppendLine($"{time},{imuAndGpsData.AccX1},{imuAndGpsData.AccY1},{imuAndGpsData.AccZ1},{imuAndGpsData.AVX1},{imuAndGpsData.AVY1},{imuAndGpsData.AVZ1},{imuAndGpsData.AccX2},{imuAndGpsData.AccY2},{imuAndGpsData.AccZ2},{imuAndGpsData.AVX2},{imuAndGpsData.AVY2},{imuAndGpsData.AVZ2},{imuAndGpsData.GpsLong},{imuAndGpsData.GpsLat},{imuAndGpsData.GpsHeight},{imuAndGpsData.GpsSpeed},{imuAndGpsData.GpsDeclination}");
            }
            return sb.ToString();
        }
        #endregion

        #endregion 委托事件

        private bool Stop()
        {
            try
            {
                if (radar != null)
                {
                    radar.cycleDataEvent -= Radar_cycleDataEvent;
                    radar.versionEvent -= Radar_versionEvent;
                    radar.tarAndClusterPointCloud -= Radar_tarAndClusterPointCloud;
                    radar.pointCloudSaveEvent -= Radar_pointCloudSaveEvent;
                    radar.imuAndGpsSaveEvent -= Radar_imuAndGpsSaveEvent;
                    radar.connectStatusChangedEvent -= Radar_connectStatusChangedEvent;
                    radar.Stop();
                }

                radar = null;
                if (SystemSetting.TargetData)
                {
                    saveData?.Dispose();
                    saveDataTrack?.Dispose();
                    saveDataPointTrack?.Dispose();
                    saveDataClusterAlog?.Dispose();
                    saveDataImuAndGps?.Dispose();
                }
                saveData = null;
                saveDataTrack = null;
                saveDataPointTrack = null;
                saveDataClusterAlog = null;
                saveDataImuAndGps = null;
                // 2. 关键：使用Invoke等待所有待处理的渲染完成后再清理
                this.Invoke(new Action(() =>
                {
                    // 强制清空所有待显示数据
                    targetTemp.Clear();
                    targetFrameTemp.Clear();
                    dynamicFollowerText.HideAll();
                    // 清理VTK资源
                    ClearVTKDynamicData();

                    // 强制刷新一次空场景（关键！）
                    if (renderWindow != null && firstRenderer != null)
                    {
                        firstRenderer.ResetCameraClippingRange();
                        renderWindow.Render();
                    }
                }));

                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"MainForm Stop() Ex\r\n{ex.ToString()}");
            }
            return false;
        }

        #endregion 启动扫描

        #region 控制功能区
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ConnectSetForm csf = new ConnectSetForm();
            csf.ShowDialog();
            StatusMenuShow();
        }

        private void btn_SystemSet_Click(object sender, EventArgs e)
        {
            SystemSetForm ssf = new SystemSetForm();
            ssf.ShowDialog();
            InitializeStaticContent(true);
            //UpdateTrackColor();
            InitializeTrackTargetActor();//更新跟踪点属性
            //UpdateTrajectoryColor();
            InitializeTrajectoryActor();//更新跟踪轨迹属性
            DisplaySystemParams();
            if (trackNplotForm != null)
                trackNplotForm.InitGraph();
        }

        private void btn_ResetCamera_Click(object sender, EventArgs e)
        {
            ResetCameraView(true, true, true, true);
        }

        private void btn_RadarAlive_Click(object sender, EventArgs e)
        {
            if (radar == null || !radar._bOpen)
            {
                MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "NotConnect"), "ERROR");
                return;
            }
            RadarAliveForm raf = new RadarAliveForm(radar);
            raf.ShowDialog();
        }

        private void btn_RadarUpgrade_Click(object sender, EventArgs e)
        {
            if (radar == null || !radar._bOpen)
            {
                MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "NotConnect"), "ERROR");
                return;
            }
            RadarUpgradeForm uf = new RadarUpgradeForm(radar);
            uf.ShowDialog();
        }

        private void ts_RadarUpgrade_UCM211_Click(object sender, EventArgs e)
        {
            if (radar != null && radar._bOpen)
            {
                MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "ConnectError"), "ERROR");
                return;
            }
            UpgradeForm uf = new UpgradeForm();
            uf.ShowDialog();
        }
        #endregion 控制功能区

        #region 回放功能
        bool isReplaying = false;
        DataReplayer dataReplayer = null;
        AlgoDataReplayer dataAlogReplayer = null;
        PointTrackDataReplayer dataPointTrackReplayer = null;
        private void btn_DataReplay_Click(object sender, EventArgs e)
        {

            if (string.Compare(btn_DataReplay.Text, MultiLanguage.LanguageText("MainForm", "lb_DataReplayStart"), true) == 0)
            {
                MsgForeColor(rtb_SystemMessage, "", "");
                ClearCommon();
                folderBrowserDialog1.Description = MultiLanguage.LanguageText("ErrorInfo", "SelectReplayFolder");
                string fileExtent = ".txt", keyString = "Cluster";
                if (SystemSetting.DataReplayFormatType == 1)
                {
                    fileExtent = ".csv";
                    keyString = "ClusterAlogFormat";
                }
                else if (SystemSetting.DataReplayFormatType == 2)
                {
                    fileExtent = ".txt";
                    keyString = "PointAndTrack";
                }
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog1.SelectedPath;
                    var files = Directory.GetFiles(folderPath)
                                            .Where(f => Path.GetExtension(f) == (fileExtent) && Path.GetFileNameWithoutExtension(f).Contains($"_{keyString}_"))
                                            .OrderBy(f => File.GetCreationTime(f))
                                            .ToList();
                    if (files == null || files.Count <= 0)
                    {
                        MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "NoReplayFile"), "ERROR");
                        return;
                    }
                    isReplaying = true;
                    if (SystemSetting.DataReplayFormatType == 1)
                    {
                        dataAlogReplayer = new AlgoDataReplayer(folderPath, saveDataClusterAlogHead, SystemSetting.DataReplayFrameCycle);
                        dataAlogReplayer.tarAndClusterPointCloud += Radar_tarAndClusterPointCloud;
                        dataAlogReplayer.replayerStatus += DataReplayer_replayerStatus;
                        dataAlogReplayer.StartReplay();
                    }
                    else if (SystemSetting.DataReplayFormatType == 2)
                    {
                        dataPointTrackReplayer = new PointTrackDataReplayer(folderPath, periodstringPointTrack, SystemSetting.DataReplayFrameCycle);
                        dataPointTrackReplayer.tarAndClusterPointCloud += Radar_tarAndClusterPointCloud;
                        dataPointTrackReplayer.replayerStatus += DataReplayer_replayerStatus;
                        dataPointTrackReplayer.StartReplay();
                    }
                    else
                    {
                        dataReplayer = new DataReplayer(folderPath, periodstring, SystemSetting.DataReplayFrameCycle);
                        dataReplayer.cycleDataEvent += Radar_cycleDataEvent;
                        dataReplayer.replayerStatus += DataReplayer_replayerStatus;
                        dataReplayer.StartReplay();
                    }
                    timerFrame.Start();
                    ReplayControlVisable(false);
                    btn_DataReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayAbort");
                }
                else
                {
                    MsgForeColor(rtb_SystemMessage, MultiLanguage.LanguageText("ErrorInfo", "CancelReplay"), "INFO");
                    return;
                }
            }
            else
            {
                timerFrame.Stop();
                if (SystemSetting.DataReplayFormatType == 1)
                {
                    if (dataAlogReplayer != null)
                    {
                        dataAlogReplayer.StopReplay();
                        dataAlogReplayer.tarAndClusterPointCloud -= Radar_tarAndClusterPointCloud;
                        dataAlogReplayer.replayerStatus -= DataReplayer_replayerStatus;
                    }
                    dataReplayer = null;
                }
                else if (SystemSetting.DataReplayFormatType == 2)
                {
                    if (dataPointTrackReplayer != null)
                    {
                        dataPointTrackReplayer.StopReplay();
                        dataPointTrackReplayer.tarAndClusterPointCloud -= Radar_tarAndClusterPointCloud;
                        dataPointTrackReplayer.replayerStatus -= DataReplayer_replayerStatus;
                    }
                    dataPointTrackReplayer = null;
                }
                else
                {
                    if (dataReplayer != null)
                    {
                        dataReplayer.StopReplay();
                        dataReplayer.cycleDataEvent -= Radar_cycleDataEvent;
                        dataReplayer.replayerStatus -= DataReplayer_replayerStatus;
                    }
                    dataReplayer = null;
                }
                isReplaying = false;
                ClearVTKDynamicData();

                ClearCommon();
                MsgForeColor(rtb_SystemMessage, "", "");
                ReplayControlVisable(true);
                btn_DataReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStart");
            }
        }

        private void ReplayControlVisable(bool b)
        {
            btn_Start.Enabled = b;
            ts_RadarAlive_SR75.Visible = b;
            ts_RadarUpgrade_SR75.Visible = b;
            //btn_SystemSet.Enabled = b;
            btn_StopReplay.Visible = !b;
            btn_StopReplay.Enabled = !b;
        }

        private void DataReplayer_replayerStatus(int state, string msg)
        {
            bool isEnd = false;
            bool isAbort = false;
            string statusMsg = string.Empty;
            switch (state)
            {
                case 1:
                    statusMsg = $"{MultiLanguage.LanguageText("ErrorInfo", "Replaying")} {msg}";
                    break;
                case 2:
                    statusMsg = $"{MultiLanguage.LanguageText("ErrorInfo", "FileReadError")}";
                    isAbort = true;
                    break;
                case 3:
                    statusMsg = $"{MultiLanguage.LanguageText("ErrorInfo", "FileReplayError")}";
                    isAbort = true;
                    break;
                case 4:
                    statusMsg = $"{MultiLanguage.LanguageText("ErrorInfo", "FileReplayEnd")}";
                    isEnd = true;
                    break;
                case 5:
                    statusMsg = $"{MultiLanguage.LanguageText("ErrorInfo", "FileReplayStop")}";
                    break;
            }
            if (isEnd || isAbort)
            {
                this.Invoke((EventHandler)delegate
                {
                    btn_DataReplay_Click(null, null);
                    MsgForeColor(rtb_SystemMessage, statusMsg, isAbort ? "ERROR" : "SUCCESS");
                });
            }
            else
                this.Invoke((EventHandler)delegate { MsgForeColor(rtb_SystemMessage, statusMsg, "SUCCESS"); });
        }
        private void btn_StopReplay_Click(object sender, EventArgs e)
        {
            if (SystemSetting.DataReplayFormatType == 1)
            {
                if (dataAlogReplayer == null)
                    return;
                if (string.Compare(btn_StopReplay.Text, MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop"), true) == 0)
                {
                    dataAlogReplayer.Pause();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayResume");
                }
                else
                {
                    dataAlogReplayer.Resume();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop");
                }
            }
            else if (SystemSetting.DataReplayFormatType == 2)
            {
                if (dataPointTrackReplayer == null)
                    return;
                if (string.Compare(btn_StopReplay.Text, MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop"), true) == 0)
                {
                    dataPointTrackReplayer.Pause();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayResume");
                }
                else
                {
                    dataPointTrackReplayer.Resume();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop");
                }
            }
            else
            {
                if (dataReplayer == null)
                    return;
                if (string.Compare(btn_StopReplay.Text, MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop"), true) == 0)
                {
                    dataReplayer.Pause();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayResume");
                }
                else
                {
                    dataReplayer.Resume();
                    btn_StopReplay.Text = MultiLanguage.LanguageText("MainForm", "lb_DataReplayStop");
                }
            }
        }
        #endregion 回放功能

        #region 扩展功能

        #region 视频预览
        private void menuItem_VideoPreview_Click(object sender, EventArgs e)
        {
            if (videoPreviewForm != null && !videoPreviewForm.IsDisposed)
            {
                if (videoPreviewForm.WindowState == FormWindowState.Minimized)
                    videoPreviewForm.WindowState = FormWindowState.Normal;
                videoPreviewForm.Focus();
                return;
            }
            videoPreviewForm = new VideoPreviewForm();
            videoPreviewForm.Show();
        }
        #endregion 视频预览

        #region 2维跟踪目标
        private void ts_TrackData_Click(object sender, EventArgs e)
        {
            if (trackNplotForm != null && !trackNplotForm.IsDisposed)
            {
                if (trackNplotForm.WindowState == FormWindowState.Minimized)
                    trackNplotForm.WindowState = FormWindowState.Normal;
                trackNplotForm.Focus();
                return;
            }
            trackNplotForm = new TrackNplotForm();
            trackNplotForm.Show();
        }

        #endregion

        #region GPS信息
        private void ts_GpsInfoData_Click(object sender, EventArgs e)
        {
            if (gpsInfoForm != null && !gpsInfoForm.IsDisposed)
            {
                if (gpsInfoForm.WindowState == FormWindowState.Minimized)
                    gpsInfoForm.WindowState = FormWindowState.Normal;
                gpsInfoForm.Focus();
                return;
            }
            gpsInfoForm = new GPSInfoForm();
            gpsInfoForm.Show();
        }
        #endregion GPS信息

        #region 跟踪目标过滤
        private void ts_FilterTrackIds_Click(object sender, EventArgs e)
        {
            if (trackFilterForm != null && !trackFilterForm.IsDisposed)
            {
                if (trackFilterForm.WindowState == FormWindowState.Minimized)
                    trackFilterForm.WindowState = FormWindowState.Normal;
                trackFilterForm.Focus();
                return;
            }
            trackFilterForm = new TrackFilterForm();
            trackFilterForm.Show();
        }

        private void OnFilterChanged()
        {
            lock (trajectoryLock)
            {
                var filterSet = SystemSetting.GetFilterTrackIdSet();
                if (filterSet != null)
                {
                    var staleIds = trajectoryActors.Keys
                        .Where(k => !filterSet.Contains(k)).ToList();
                    foreach (var id in staleIds)
                        RemoveTrajectoryActor(id);
                }
            }
        }

        #endregion 跟踪目标过滤

        #endregion 扩展功能


    }

}

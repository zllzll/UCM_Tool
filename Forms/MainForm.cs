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
        VideoPreviewForm videoPreviewForm = null;
        TrackNplotForm trackNplotForm = null;
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
        private vtkFloatArray pointCloudScalars = null;
        private vtkLookupTable pointCloudLookupTable = null;
        private vtkPolyDataMapper pointCloudMapper = null;
        private List<vtkTextActor3D> active3DTextActors = new List<vtkTextActor3D>();
        private Queue<vtkTextActor3D> text3DActorPool = new Queue<vtkTextActor3D>();
        private List<vtkTextActor> active2DTextActors = new List<vtkTextActor>();
        private Queue<vtkTextActor> text2DActorPool = new Queue<vtkTextActor>();

        #region 跟踪目标轨迹
        // 轨迹Actor（使用vtkPolyData表示线条）
        private vtkActor trajectoryActor = null;
        private vtkPolyData trajectoryData = null;
        private vtkPoints trajectoryPoints = null;
        private vtkCellArray trajectoryLines = null;
        private vtkPolyDataMapper trajectoryMapper = null;
        private vtkUnsignedCharArray trajectoryColors = null; // 新增：轨迹颜色数组（ID着色模式用）

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
                menuItem_VideoPreview.Text = MultiLanguage.LanguageText("MainForm", "VideoPreview");
                ts_TrackData.Text = MultiLanguage.LanguageText("MainForm", "XY2DView");
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
            if (pointCloudLookupTable != null)
            {
                pointCloudLookupTable.Dispose();
                pointCloudLookupTable = null;
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
        }
        private void renderWindowControl1_SizeChanged(object sender, EventArgs e)
        {
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
            if (string.Compare(SystemSetting.ConnType, "TCP", false) == 0)
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
            targetFrameTemp.Add(targetInfoList);
            targetTemp.Clear();
            foreach (var item in targetFrameTemp)
                targetTemp.AddRange(item);
            List<TargetInfo.RadarTargetInfoStruct> LoadTemp = targetTemp.ToList();
            if (targetFrameTemp.Count >= SystemSetting.CumulativeFrameNum)
            {

                if (SystemSetting.CumulativeFrameType == 1)//每显示cumulativeFrameSum帧数据清空再积累
                {
                    targetFrameTemp.Clear();
                }
                else//if(SystemSetting.CumulativeFrameType == 0)//cumulativeFrameSum帧数据保留积累最新cumulativeFrameSum
                {
                    int removeNum = targetFrameTemp.Count - SystemSetting.CumulativeFrameNum;
                    if (removeNum > 0)
                        targetFrameTemp.RemoveRange(0, removeNum + 1);
                    else if (removeNum == 0)
                        targetFrameTemp.RemoveAt(0);
                }
            }
            UpdateLabels(targetInfoList.Count, LoadTemp.Count, 0);
            if (isLostFocus && (DateTime.Now - lastDrawTime).TotalMilliseconds < SystemSetting.VtkDrawTimeInLostFocus)
                return;

            lastDrawTime = DateTime.Now;
            UpdatePointCloud(LoadTemp);
        }

        #region 核心变更
        int textRefreshCounter = 0; // 文本刷新计数器
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
                ClearTrackTargets(); // 新增
                ClearTrajectory(); // 新增：清理轨迹
                dynamicFollowerText.HideAll();
                return;
            }

            try
            {
                Invoke(new Action(() =>
                {
                    // 1. 同步清理上一帧文本（关键！）
                    ClearTextActors();
                    ClearTrackTextActors(); // 新增：清理跟踪目标文字

                    // 2. 初始化或复用点云Actor
                    if (pointCloudActor == null) InitializePointCloudActor();
                    if (trackTargetActor == null) InitializeTrackTargetActor(); // 新增
                    if (trajectoryActor == null) InitializeTrajectoryActor(); // 新增：初始化轨迹

                    if (pointCloudActor.GetProperty().GetPointSize() != SystemSetting.PointSize)
                        pointCloudActor?.GetProperty().SetPointSize(SystemSetting.PointSize);//需要更新点目标
                    // 3. 更新点云数据（不创建新Actor）
                    if ((SystemSetting.DisplayTargetType == 0 || SystemSetting.DisplayTargetType == 1) && pointData != null && pointData.Count > 0)
                        UpdatePointCloudData(pointData);
                    else
                    {
                        // 清空点云但保留Actor
                        pointCloudPoints.Reset();
                        pointCloudScalars.Reset();
                        pointCloudData.Modified();
                    }
                    // 4. 新增：更新跟踪目标数据
                    if ((SystemSetting.DisplayTargetType == 0 || SystemSetting.DisplayTargetType == 2) && trackData != null && trackData.Count > 0)
                    {
                        if (trackSphereSource.GetRadius() != SystemSetting.TrackSize)
                            trackSphereSource.SetRadius(SystemSetting.TrackSize);
                        UpdateTrackTargetData(trackData);
                        // 新增：更新轨迹（高性能，与跟踪目标同步更新）
                        UpdateTrajectoryData();
                        // 5. 新增：添加跟踪目标文字（强制显示ID和坐标）
                        if (SystemSetting.DisplayTrackText)
                        {
                            //textRefreshCounter++;
                            //当丢失焦点的时候，前面已经判定了250ms时间才刷新一次文本，这里就不再限制10帧刷新一次了，直接每帧刷新，保证文本信息的及时更新，虽然可能会有性能影响，但丢失焦点时性能已经不是主要问题了
                            if (isLostFocus || (!isLostFocus && (DateTime.Now - lastDrawTime).TotalMilliseconds > SystemSetting.VtkDrawTimeInLostFocus))
                            {
                                // 使用新的高性能方案
                                dynamicFollowerText.UpdateFrame(
                                    trackData,
                                    SystemSetting.NonUniformScale,
                                    SystemSetting.GlobalTransform
                                );
                                //textRefreshCounter = 0;
                            }
                            lastDrawTime = DateTime.Now;
                            //if (SystemSetting.UseScreenSpaceText)
                            //{
                            //    AddTrack2DTextBatch(trackData); // 跟踪目标使用独立方法
                            //}
                            //else
                            //{
                            //    AddTrack3DTextBatch(trackData);
                            //}
                        }
                        else
                        {
                            dynamicFollowerText.HideAll();
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
                        dynamicFollowerText.HideAll();
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
                }));
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }



        /// <summary>
        /// 按距离相机远近排序（取最近N个）
        /// </summary>
        private List<TargetInfo.RadarTargetInfoStruct> SortByCameraDistance(List<TargetInfo.RadarTargetInfoStruct> targets)
        {
            if (firstRenderer == null) return targets.Take(20).ToList();

            double[] cameraPos = firstRenderer.GetActiveCamera().GetPosition();
            return targets
                .OrderBy(t =>
                    (t.XAxis - cameraPos[0]) * (t.XAxis - cameraPos[0]) +
                    (t.YAxis - cameraPos[1]) * (t.YAxis - cameraPos[1]) +
                    (t.ZAxis - cameraPos[2]) * (t.ZAxis - cameraPos[2]))
                .Take(SystemSetting.UseScreenSpaceText ? SystemSetting.Max2DTextCount : SystemSetting.Max3DTextCount)
                .ToList();
        }

        // 初始化点云Actor（仅执行一次）
        private void InitializePointCloudActor()
        {
            // 创建核心对象（只创建一次）
            pointCloudPoints = vtkPoints.New();
            pointCloudScalars = vtkFloatArray.New();
            pointCloudData = vtkPolyData.New();
            pointCloudLookupTable = vtkLookupTable.New();
            pointCloudMapper = vtkPolyDataMapper.New();
            var glyphFilter = vtkVertexGlyphFilter.New();

            // 构建管线
            pointCloudData.SetPoints(pointCloudPoints);
            pointCloudData.GetPointData().SetScalars(pointCloudScalars);

            glyphFilter.SetInputConnection(pointCloudData.GetProducerPort());
            pointCloudMapper.SetInputConnection(glyphFilter.GetOutputPort());

            // ✅ 根据配置设置颜色方案（关键！）
            if (SystemSetting.Default_Color)
            {
                // 默认彩虹渐变（紫->红）
                pointCloudLookupTable.SetHueRange(0.67, 0);
                pointCloudLookupTable.Build();
            }
            else
            {
                // ✅ 自定义方案：初始化时不设置颜色（由UpdatePointCloudData每帧设置）
                pointCloudLookupTable.SetNumberOfColors(1); // 临时
                pointCloudLookupTable.Build();
            }

            pointCloudMapper.SetLookupTable(pointCloudLookupTable);

            // 创建Actor
            pointCloudActor = vtkActor.New();
            pointCloudActor.SetMapper(pointCloudMapper);
            pointCloudActor.GetProperty().SetPointSize(SystemSetting.PointSize);

            // 关键：应用全局变换
            if (SystemSetting.NonUniformScale)
                pointCloudActor.SetUserTransform(SystemSetting.GlobalTransform);
            firstRenderer.AddActor(pointCloudActor);

            // 清理临时对象
            glyphFilter.Dispose();

        }



        /// <summary>
        /// 设置自定义颜色表（7个颜色档位，完全匹配原始代码）
        /// </summary>
        private void SetupCustomColorTable()
        {
            // 清除旧颜色
            pointCloudLookupTable.SetNumberOfColors(7);

            // 按Z值从高到低分配颜色索引：
            // 索引0: 红色 (最高)
            // 索引1: 橙色
            // 索引2: 黄色
            // 索引3: 绿色
            // 索引4: 青色
            // 索引5: 蓝色
            // 索引6: 紫色 (最低)

            pointCloudLookupTable.SetTableValue(0, 1.0, 0.0, 0.0, 1.0);   // 红
            pointCloudLookupTable.SetTableValue(1, 1.0, 0.6, 0.0, 1.0);   // 橙
            pointCloudLookupTable.SetTableValue(2, 1.0, 1.0, 0.0, 1.0);   // 黄
            pointCloudLookupTable.SetTableValue(3, 0.0, 1.0, 0.0, 1.0);   // 绿
            pointCloudLookupTable.SetTableValue(4, 0.0, 1.0, 1.0, 1.0);   // 青
            pointCloudLookupTable.SetTableValue(5, 0.0, 0.0, 1.0, 1.0);   // 蓝
            pointCloudLookupTable.SetTableValue(6, 0.5, 0.0, 0.5, 1.0);   // 紫

            pointCloudLookupTable.Build();
        }

        /// <summary>
        /// 更新点云数据并重新映射颜色
        /// </summary>
        private void UpdatePointCloudData(List<TargetInfo.RadarTargetInfoStruct> pointData)
        {
            pointCloudPoints.Reset();
            pointCloudScalars.Reset();
            // 根据配置选择颜色方案
            if (SystemSetting.Default_Color)
            {
                // 默认方案：使用Z值作为标量，彩虹渐变
                foreach (var point in pointData)
                {
                    pointCloudPoints.InsertNextPoint(point.XAxis, point.YAxis, point.ZAxis);
                    pointCloudScalars.InsertNextTuple1(point.ZAxis);
                }

                // 重建渐变颜色表
                pointCloudLookupTable.SetNumberOfColors(256);
                pointCloudLookupTable.SetHueRange(0.67, 0); // 紫->红
                pointCloudLookupTable.Build();

                // 设置标量范围（Z轴范围）
                double[] bounds = pointCloudData.GetBounds();
                pointCloudMapper.SetScalarRange(bounds[4], bounds[5]);
            }
            else
            {
                // ✅ 自定义方案：完全复制原始代码逻辑（每帧重建LookupTable）
                int pointCount = pointData.Count;
                pointCloudLookupTable.SetNumberOfColors(pointCount);

                for (int i = 0; i < pointCount; i++)
                {
                    var point = pointData[i];
                    pointCloudPoints.InsertNextPoint(point.XAxis, point.YAxis, point.ZAxis);

                    // 标量值是索引（关键！）
                    pointCloudScalars.InsertNextTuple1(i);

                    // 根据Z值设置该索引对应的颜色（动态响应阈值变化！）
                    double z = point.ZAxis;
                    if (z > SystemSetting.RedValue)
                        pointCloudLookupTable.SetTableValue(i, 1.0, 0.0, 0.0, 1.0);      // 红
                    else if (z <= SystemSetting.RedValue && z > SystemSetting.OrangeValue)
                        pointCloudLookupTable.SetTableValue(i, 1.0, 0.6, 0.0, 1.0);     // 橙
                    else if (z <= SystemSetting.OrangeValue && z > SystemSetting.YellowValue)
                        pointCloudLookupTable.SetTableValue(i, 1.0, 1.0, 0.0, 1.0);     // 黄
                    else if (z <= SystemSetting.YellowValue && z > SystemSetting.GreenValue)
                        pointCloudLookupTable.SetTableValue(i, 0.0, 1.0, 0.0, 1.0);     // 绿
                    else if (z <= SystemSetting.GreenValue && z > SystemSetting.CyanValue)
                        pointCloudLookupTable.SetTableValue(i, 0.0, 1.0, 1.0, 1.0);     // 青
                    else if (z <= SystemSetting.CyanValue && z > SystemSetting.BlueValue)
                        pointCloudLookupTable.SetTableValue(i, 0.0, 0.0, 1.0, 1.0);     // 蓝
                    else
                        pointCloudLookupTable.SetTableValue(i, 0.5, 0.0, 0.5, 1.0);     // 紫
                }

                pointCloudLookupTable.Build();
                pointCloudMapper.SetScalarRange(0, pointCount - 1);
            }

            pointCloudData.Modified();
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
            if (pointCloudLookupTable != null)
            {
                pointCloudLookupTable.Dispose();
                pointCloudLookupTable = null;
            }
            ClearTextActors();
        }

        // 同步清理文本（关键！）
        private void ClearTextActors()
        {
            // 清理3D文本
            foreach (var actor in active3DTextActors)
            {
                firstRenderer.RemoveViewProp(actor);
                // 回收到对象池
                ReturnTextActorToPool(actor);
            }
            active3DTextActors.Clear();
            // 清理2D文本
            foreach (var actor in active2DTextActors)
            {
                firstRenderer.RemoveViewProp(actor);
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
            // 限制数量避免UI过载
            int maxTexts = SystemSetting.Max2DTextCount > 0 ?
                Math.Min(pointData.Count, SystemSetting.Max2DTextCount) :
                pointData.Count;

            for (int i = 0; i < maxTexts; i++)
            {
                var actor = Get2DTextActor(pointData[i]);
                // 对2D文本，使用变换后的坐标计算屏幕位置
                if (SystemSetting.NonUniformScale)
                {
                    double[] transformedPos = SystemSetting.TransformPoint(pointData[i].XAxis, pointData[i].YAxis, pointData[i].ZAxis);
                    int[] screenPos = WorldToScreenCoordinates(transformedPos[0], transformedPos[1], transformedPos[2]);
                    actor.SetDisplayPosition(screenPos[0], screenPos[1]);
                }
                firstRenderer.AddActor2D(actor); // ✅ 注意：使用AddActor2D而不是AddActor
                active2DTextActors.Add(actor);
            }
        }

        /// <summary>
        /// 获取/创建2D文本Actor（固定字体大小，远近一致）
        /// </summary>
        private vtkTextActor Get2DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor actor;
            lock (text2DActorPool)
            {
                actor = text2DActorPool.Count > 0 ? text2DActorPool.Dequeue() : vtkTextActor.New();
            }

            // 配置文本属性（只设置一次）
            var textProperty = actor.GetTextProperty();
            if (textProperty == null)
            {
                textProperty = vtkTextProperty.New();
                actor.SetTextProperty(textProperty);
                textProperty.Dispose(); // VTK会内部引用，可立即释放
            }

            // 设置内容
            actor.SetInput(VTKHelper.GetDetectionText(tar));

            // 计算屏幕坐标
            int[] screenPos = WorldToScreenCoordinates(tar.XAxis, tar.YAxis, tar.ZAxis);
            actor.SetDisplayPosition(screenPos[0], screenPos[1]);

            // 固定字体大小，远近一致
            int fontSize = SystemSetting.Text2DFontSize;
            if (fontSize <= 0) fontSize = 14;
            actor.GetTextProperty().SetFontSize(fontSize);

            // 设置颜色
            textProperty.SetColor(1.0, 1.0, 1.0); // 白色

            return actor;
        }
        /// <summary>
        /// 世界坐标转屏幕像素坐标（正确实现）
        /// </summary>
        private int[] WorldToScreenCoordinates(double worldX, double worldY, double worldZ)
        {
            using (vtkCoordinate coordinate = vtkCoordinate.New())
            {
                coordinate.SetCoordinateSystemToWorld();
                coordinate.SetValue(worldX, worldY, worldZ);
                coordinate.SetViewport(firstRenderer);

                // 直接返回 [screenX, screenY]
                return coordinate.GetComputedDisplayValue(firstRenderer);
            }
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
            double[] cameraPos = firstRenderer.GetActiveCamera().GetPosition();
            double dx = x - cameraPos[0];
            double dy = y - cameraPos[1];
            double dz = z - cameraPos[2];
            return Math.Max(0.1, Math.Sqrt(dx * dx + dy * dy + dz * dz)); // 避免除零
        }

        private void ReturnTextActorToPool(vtkTextActor actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
                actor.Dispose();
                return;
            }

            lock (text2DActorPool)
            {
                if (text2DActorPool.Count < 200) // 2D文本池更大
                {
                    actor.SetInput("");
                    actor.SetDisplayPosition(0, 0); // 复位
                    text2DActorPool.Enqueue(actor);
                    return;
                }
            }
            actor.Dispose();
        }
        #endregion 2D文字

        #region 3D文字
        private void Add3DTextBatch(List<TargetInfo.RadarTargetInfoStruct> pointData)
        {
            // 严格限制3D文本数量（超过15个性能急剧下降）
            int maxTexts = SystemSetting.Max3DTextCount > 0 ?
                Math.Min(pointData.Count, SystemSetting.Max3DTextCount) :
                Math.Min(pointData.Count, 15); // 强制上限

            for (int i = 0; i < maxTexts; i++)
            {
                var actor = Get3DTextActor(pointData[i]);
                // 关键：应用全局变换
                if (SystemSetting.NonUniformScale)
                    actor.SetUserTransform(SystemSetting.GlobalTransform);
                firstRenderer.AddActor(actor);
                active3DTextActors.Add(actor);
            }
        }

        private vtkTextActor3D Get3DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor3D actor;
            lock (text3DActorPool)
            {
                actor = text3DActorPool.Count > 0 ? text3DActorPool.Dequeue() : vtkTextActor3D.New();
            }

            var textProperty = vtkTextProperty.New();
            VTKHelper.SetTextProperty(textProperty);
            actor.SetInput(VTKHelper.GetDetectionText(tar));
            actor.SetTextProperty(textProperty);
            actor.SetPosition(tar.XAxis, tar.YAxis, tar.ZAxis + 0.5); // Z轴抬高避免穿透
            actor.SetScale(0.03, 0.03, 0.03);
            actor.RotateX(90.0);

            textProperty.Dispose();
            return actor;
        }
        // 回收TextActor到对象池
        private void ReturnTextActorToPool(vtkTextActor3D actor)
        {
            if (!SystemSetting.EnableVtkObjectPool) // 检查配置
            {
                actor.Dispose();
                return;
            }
            lock (text3DActorPool)
            {
                if (text3DActorPool.Count < 200) // 限制池大小
                {
                    actor.SetInput(""); // 清空内容
                    text3DActorPool.Enqueue(actor);
                    return;
                }
            }
            actor.Dispose(); // 池满则销毁
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
                // 应用程序激活/失去焦点时切换渲染模式
                if (renderWindow != null)
                {
                    if (m.WParam.ToInt32() == 0) // 失去焦点
                    {
                        isLostFocus = true;
                        Console.WriteLine("失去焦点");
                        renderWindow.SetOffScreenRendering(1);
                    }
                    else // 恢复焦点
                    {
                        isLostFocus = false;
                        Console.WriteLine("恢复焦点");
                        renderWindow.SetOffScreenRendering(0);
                        renderWindow.Modified();
                        renderWindow.MakeCurrent();
                    }
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
            targetFrameTemp.Add(clusterInfoList);
            targetTemp.Clear();
            foreach (var item in targetFrameTemp)
                targetTemp.AddRange(item);
            List<TargetInfo.RadarTargetInfoStruct> LoadTemp = targetTemp.ToList();
            List<TargetInfo.RadarTargetInfoStruct> TrackTemp = targetInfoList.ToList();
            if (targetFrameTemp.Count >= SystemSetting.CumulativeFrameNum)
            {

                if (SystemSetting.CumulativeFrameType == 1)//每显示cumulativeFrameSum帧数据清空再积累
                {
                    targetFrameTemp.Clear();
                }
                else//if(SystemSetting.CumulativeFrameType == 0)//cumulativeFrameSum帧数据保留积累最新cumulativeFrameSum
                {
                    int removeNum = targetFrameTemp.Count - SystemSetting.CumulativeFrameNum;
                    if (removeNum > 0)
                        targetFrameTemp.RemoveRange(0, removeNum + 1);
                    else if (removeNum == 0)
                        targetFrameTemp.RemoveAt(0);
                }
            }
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
            if (isLostFocus && (DateTime.Now - lastDrawTime).TotalMilliseconds < SystemSetting.VtkDrawTimeInLostFocus)
                return;
            UpdatePointCloud(LoadTemp, TrackTemp);

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

        private void AddTrack2DTextBatch(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            // 跟踪目标数量通常较少，全部显示
            foreach (var target in trackData)
            {
                var actor = GetTrack2DTextActor(target);
                // 2D文本手动计算变换后位置
                if (SystemSetting.NonUniformScale)
                {
                    double[] transformedPos = SystemSetting.TransformPoint(target.XAxis, target.YAxis, target.ZAxis);
                    int[] screenPos = WorldToScreenCoordinates(transformedPos[0], transformedPos[1], transformedPos[2]);
                    actor.SetDisplayPosition(screenPos[0], screenPos[1] + 15);
                }
                firstRenderer.AddActor2D(actor);
                activeTrack2DTextActors.Add(actor);
            }
        }

        private void AddTrack3DTextBatch(List<TargetInfo.RadarTargetInfoStruct> trackData)
        {
            foreach (var target in trackData)
            {
                var actor = GetTrack3DTextActor(target);
                // 应用全局变换
                if (SystemSetting.NonUniformScale)
                    actor.SetUserTransform(SystemSetting.GlobalTransform);
                firstRenderer.AddActor(actor);
                activeTrack3DTextActors.Add(actor);
            }
        }

        /// <summary>
        /// 获取跟踪目标2D文本 - 强制显示ID+坐标
        /// </summary>
        private vtkTextActor GetTrack2DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor actor;
            lock (trackText2DActorPool)
            {
                actor = trackText2DActorPool.Count > 0 ? trackText2DActorPool.Dequeue() : vtkTextActor.New();
            }

            var textProperty = actor.GetTextProperty() ?? vtkTextProperty.New();
            if (actor.GetTextProperty() == null)
            {
                actor.SetTextProperty(textProperty);
                // 跟踪目标文字使用黄色突出显示
                textProperty.SetColor(1.0, 1.0, 0.0); // 黄色
                textProperty.SetBold(1);
                // 黑色描边增强可读性
                textProperty.SetShadow(1);
                textProperty.SetShadowOffset(1, 1);
                //textProperty.SetShadowColor(0, 0, 0);
                textProperty.Dispose();
            }
            actor.SetInput(VTKHelper.GetDetectionTextH(tar));
            // 计算球体顶部的世界坐标（球体半径0.3，顶部在Z+0.3处）
            //double sphereTopZ = tar.ZAxis + SystemSetting.TrackSize + 0.5; // 球体半径 + 额外偏移
            // 计算屏幕坐标
            int[] screenPos = WorldToScreenCoordinates(tar.XAxis, tar.YAxis, tar.ZAxis);

            // 文字偏移避免遮挡球体
            actor.SetDisplayPosition(screenPos[0], screenPos[1] + 15);
            actor.GetTextProperty().SetFontSize(12);


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
        /// <summary>
        /// 获取跟踪目标3D文本
        /// </summary>
        private vtkTextActor3D GetTrack3DTextActor(TargetInfo.RadarTargetInfoStruct tar)
        {
            vtkTextActor3D actor;
            lock (trackText3DActorPool)
            {
                actor = trackText3DActorPool.Count > 0 ? trackText3DActorPool.Dequeue() : vtkTextActor3D.New();
            }

            var textProperty = vtkTextProperty.New();
            //textProperty.SetColor(1.0, 1.0, 0.0); // 黄色
            textProperty.SetColor(SystemSetting.TrackTextColor.R / 255d, SystemSetting.TrackTextColor.G / 255d, SystemSetting.TrackTextColor.B / 255d);
            textProperty.SetFontSize(SystemSetting.TrackTextSize);
            textProperty.SetBold(1);
            textProperty.SetJustificationToCentered(); // 3D文本水平居中

            string text = VTKHelper.GetDetectionTextH(tar);// $"ID:{tar.ID} X:{tar.XAxis:F3} Y:{tar.YAxis:F3} Z:{tar.ZAxis:F3}";
            actor.SetInput(text);
            actor.SetTextProperty(textProperty);
            // 关键：估算文本宽度并偏移X位置
            // 字体大小25，每个字符约0.6倍宽度，缩放0.04
            double approxCharWidth = 25 * 0.6 * 0.04; // ≈ 0.6
            double textWidth = text.Length * approxCharWidth;
            // 位于目标上方
            actor.SetPosition(tar.XAxis - (textWidth / 2), tar.YAxis + (SystemSetting.TrackSize), tar.ZAxis);
            actor.SetScale(0.04, 0.04, 0.04);
            // 始终面向相机
            actor.SetOrientation(0, 0, 0);
            //actor.SetUseBounds(true);// 使用边界对齐实现居中

            textProperty.Dispose();
            return actor;
        }

        /// <summary>
        /// 清理跟踪目标文字
        /// </summary>
        private void ClearTrackTextActors()
        {
            // 3D
            foreach (var actor in activeTrack3DTextActors)
            {
                firstRenderer.RemoveViewProp(actor);
                ReturnTrackTextActorToPool(actor);
            }
            activeTrack3DTextActors.Clear();

            // 2D
            foreach (var actor in activeTrack2DTextActors)
            {
                firstRenderer.RemoveViewProp(actor);
                ReturnTrackTextActorToPool(actor);
            }
            activeTrack2DTextActors.Clear();
        }

        private void ReturnTrackTextActorToPool(vtkTextActor3D actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
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
            actor.Dispose();
        }

        private void ReturnTrackTextActorToPool(vtkTextActor actor)
        {
            if (!SystemSetting.EnableVtkObjectPool)
            {
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
        /// 初始化轨迹显示Actor（仅执行一次）
        /// </summary>
        private void InitializeTrajectoryActor()
        {
            if (trajectoryActor != null)
            {
                ClearTrajectory();
            }
            trajectoryPoints = vtkPoints.New();
            trajectoryLines = vtkCellArray.New();
            if (SystemSetting.TrackColorMode == 1) // ID着色模式
            {
                // 新增：颜色数组用于ID着色模式
                trajectoryColors = vtkUnsignedCharArray.New();
                trajectoryColors.SetName("Colors");
                trajectoryColors.SetNumberOfComponents(3); // RGB
            }
            else
            {
                trajectoryColors = null; // Mode=0时不创建
            }

            trajectoryData = vtkPolyData.New();
            trajectoryData.SetPoints(trajectoryPoints);
            trajectoryData.SetLines(trajectoryLines);

            // 根据配置决定是否添加颜色数组
            //if (SystemSetting.TrackColorMode == 1) // ID着色模式
            //{
            //    trajectoryData.GetCellData().SetScalars(trajectoryColors); // 注意：线条颜色用CellData
            //}

            trajectoryMapper = vtkPolyDataMapper.New();
            trajectoryMapper.SetInput(trajectoryData);
            // 根据颜色模式配置Mapper
            if (SystemSetting.TrackColorMode == 1) // ID着色模式
            {
                trajectoryData.GetCellData().SetScalars(trajectoryColors); // 注意：线条颜色用CellData
                trajectoryMapper.SetColorMode(0); // 直接使用RGB值
                trajectoryMapper.SetScalarModeToUseCellData(); // 使用单元（线条）数据
                trajectoryMapper.ScalarVisibilityOn(); // 开启标量着色
            }
            else // 统一颜色模式
            {
                trajectoryData.GetCellData().SetScalars(null); // **清除CellData中的标量引用**
                trajectoryMapper.ScalarVisibilityOff(); // 关闭标量颜色映射
                // 禁用颜色数组以提升性能
                trajectoryColors = null;
            }

            trajectoryActor = vtkActor.New();
            trajectoryActor.SetMapper(trajectoryMapper);
            trajectoryActor.GetProperty().SetLineWidth(SystemSetting.TrackTrajectoryLineWidth);
            trajectoryActor.GetProperty().SetOpacity(0.5); // 轻微透明，避免遮挡
            // 关键：直接在 Property 上设置颜色（最简单可靠）
            // 统一颜色模式下设置颜色
            if (SystemSetting.TrackColorMode == 0)
            {
                UpdateTrajectoryColor();
            }
            // 关键：应用全局变换
            if (SystemSetting.NonUniformScale)
                trajectoryActor.SetUserTransform(SystemSetting.GlobalTransform);
            firstRenderer.AddActor(trajectoryActor);
        }
        // 更新颜色方法（当设置改变时调用）
        public void UpdateTrajectoryColor()
        {
            if (trajectoryActor == null) return;

            if (SystemSetting.TrackColorMode == 0) // 统一颜色模式
            {
                trajectoryActor.GetProperty().SetColor(
                    SystemSetting.TrackTrajectoryColor.R / 255.0,
                    SystemSetting.TrackTrajectoryColor.G / 255.0,
                    SystemSetting.TrackTrajectoryColor.B / 255.0
                );

                // 确保标量颜色关闭（如果之前是ID着色模式切换过来）
                if (trajectoryMapper != null)
                {
                    trajectoryMapper.ScalarVisibilityOff();
                }
            }
            else // ID着色模式
            {
                // 颜色由顶点数据数组控制，这里只需确保标量可见性开启
                if (trajectoryMapper != null)
                {
                    trajectoryMapper.ScalarVisibilityOn();
                    trajectoryMapper.SetScalarModeToUseCellData();
                }

                // 如果颜色映射算法改变，触发数据更新重绘
                trajectoryData?.Modified();
            }
        }
        /// <summary>
        /// 更新轨迹数据 - 高性能批量更新
        /// </summary>
        private void UpdateTrajectoryData()
        {
            if (!SystemSetting.DisplayTrackTrajectory)
            {
                // 清空轨迹显示但不销毁Actor
                //trajectoryPoints.Reset();
                //trajectoryLines.Reset();
                //trajectoryColors?.Reset();
                //trajectoryData.Modified();
                ClearTrajectoryData();
                return;
            }
            lock (trajectoryLock)
            {
                
                if (trajectoryActor.GetProperty().GetLineWidth() != SystemSetting.TrackTrajectoryLineWidth)
                    trajectoryActor.GetProperty().SetLineWidth(SystemSetting.TrackTrajectoryLineWidth);
                
                // 3. 批量构建VTK数据（关键性能优化：一次性重建）
                trajectoryPoints.Reset();
                trajectoryLines.Reset();
                //trajectoryColors?.Reset(); // 清空颜色数组
                // 3. 关键修改：根据当前模式处理颜色数组
                if (SystemSetting.TrackColorMode == 1)
                {
                    // Mode=1：确保颜色数组存在并重置
                    if (trajectoryColors == null)
                    {
                        trajectoryColors = vtkUnsignedCharArray.New();
                        trajectoryColors.SetName("Colors");
                        trajectoryColors.SetNumberOfComponents(3);
                    }
                    trajectoryColors.Reset();
                }
                else
                {
                    // Mode=0：清除CellData中的标量（防止Mapper尝试读取）
                    trajectoryData.GetCellData().SetScalars(null);
                }

                foreach (var kvp in trackTrajectories)
                {
                    var queue = kvp.Value;
                    if (queue.Count < 2) continue; // 至少需要2个点才能画线

                    var points = queue.ToArray();
                    int startIdx = trajectoryPoints.GetNumberOfPoints();

                    // 添加所有点到vtkPoints
                    for (int i = 0; i < points.Length; i++)
                    {
                        trajectoryPoints.InsertNextPoint(points[i].XAxis, points[i].YAxis, points[i].ZAxis);
                    }
                    // 创建线条Cell
                    using (vtkIdList idList = vtkIdList.New())
                    {
                        idList.SetNumberOfIds(points.Length);
                        for (int i = 0; i < points.Length; i++)
                        {
                            idList.SetId(i, startIdx + i);
                        }
                        trajectoryLines.InsertNextCell(idList);

                        // 关键修改：只在Mode=1时添加颜色，且直接操作trajectoryColors
                        if (SystemSetting.TrackColorMode == 1 && trajectoryColors != null)
                        {
                            PubClass.GetColorById(kvp.Key, out byte r, out byte g, out byte b);
                            trajectoryColors.InsertNextTuple3(r, g, b);
                        }
                    }


                    //创建线条连接（使用VTK_LINE类型，每段一个cell）
                    //for (int i = 0; i < points.Length - 1; i++)
                    //{
                    //    //vtkLine line = vtkLine.New();
                    //    //line.GetPointIds().SetId(0, startIdx + i);
                    //    //line.GetPointIds().SetId(1, startIdx + i + 1);
                    //    //trajectoryLines.InsertNextCell(line);
                    //    //line.Dispose(); // 立即释放临时对象
                    //    // ID着色模式：为每条线段添加颜色（与跟踪点同色）
                    //    if (SystemSetting.TrackColorMode == 1 && trajectoryColors != null)
                    //    {
                    //        trajectoryColors.InsertNextTuple3(r, g, b);
                    //    }
                    //}
                }
                // 5. 关键修改：更新完成后，根据模式决定是否将颜色数组设置到CellData
                if (SystemSetting.TrackColorMode == 1 && trajectoryColors != null)
                {
                    trajectoryData.GetCellData().SetScalars(trajectoryColors);
                    trajectoryMapper.ScalarVisibilityOn(); // 确保开启
                }
                // Mode=0时不需要操作，上面已经清除了

            }

            trajectoryData.Modified();
        }

        /// <summary>
        /// 清空轨迹数据（不销毁Actor）
        /// </summary>
        private void ClearTrajectoryData()
        {
            lock (trajectoryLock)
            {
                trackTrajectories.Clear();
            }

            if (trajectoryPoints != null) trajectoryPoints.Reset();
            if (trajectoryLines != null) trajectoryLines.Reset();
            if (trajectoryData != null) trajectoryData.Modified();
        }

        /// <summary>
        /// 完全清理轨迹资源（用于关闭时）
        /// </summary>
        private void ClearTrajectory()
        {
            ClearTrajectoryData();

            if (trajectoryActor != null)
            {
                firstRenderer?.RemoveViewProp(trajectoryActor);
                trajectoryActor.Dispose();
                trajectoryActor = null;
            }
            if (trajectoryMapper != null)
            {
                trajectoryMapper.Dispose();
                trajectoryMapper = null;
            }
            if (trajectoryData != null)
            {
                trajectoryData.Dispose();
                trajectoryData = null;
            }
            if (trajectoryPoints != null)
            {
                trajectoryPoints.Dispose();
                trajectoryPoints = null;
            }
            if (trajectoryLines != null)
            {
                trajectoryLines.Dispose();
                trajectoryLines = null;
            }
            // 新增：清理颜色数组
            if (trajectoryColors != null)
            {
                trajectoryColors.Dispose();
                trajectoryColors = null;
            }
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

        #endregion 扩展功能


    }

}

using UCM_Tools.ExtendControls;
using Sunny.UI;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UCM_Tools.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_Main = new Sunny.UI.UIPanel();
            this.pan_Right = new Sunny.UI.UIPanel();
            this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
            this.textOverlayPanel = new UCM_Tools.ExtendControls.TransparentOverlayPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pan_Left = new Sunny.UI.UIPanel();
            this.uiPanel56 = new Sunny.UI.UIPanel();
            this.uiPanel57 = new Sunny.UI.UIPanel();
            this.rtb_SystemMessage = new Sunny.UI.UIRichTextBox();
            this.uiPanel58 = new Sunny.UI.UIPanel();
            this.lb_SystemInfo = new Sunny.UI.UILabel();
            this.uiPanel55 = new Sunny.UI.UIPanel();
            this.pan_ControlArea = new Sunny.UI.UIPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.uiPanel37 = new Sunny.UI.UIPanel();
            this.uiPanel38 = new Sunny.UI.UIPanel();
            this.btn_StopReplay = new Sunny.UI.UIButton();
            this.uiPanel39 = new Sunny.UI.UIPanel();
            this.uiPanel40 = new Sunny.UI.UIPanel();
            this.btn_DataReplay = new Sunny.UI.UIButton();
            this.uiPanel41 = new Sunny.UI.UIPanel();
            this.uiPanel12 = new Sunny.UI.UIPanel();
            this.uiPanel13 = new Sunny.UI.UIPanel();
            this.btn_SystemSet = new Sunny.UI.UIButton();
            this.uiPanel14 = new Sunny.UI.UIPanel();
            this.uiPanel15 = new Sunny.UI.UIPanel();
            this.btn_ResetView = new Sunny.UI.UIButton();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.lb_ControlAreaTitle = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiPanel16 = new Sunny.UI.UIPanel();
            this.uiPanel97 = new Sunny.UI.UIPanel();
            this.lb_Fc = new Sunny.UI.UILabel();
            this.uiPanel98 = new Sunny.UI.UIPanel();
            this.uiPanel99 = new Sunny.UI.UIPanel();
            this.lb_FcText = new Sunny.UI.UILabel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.lb_Gps = new Sunny.UI.UILabel();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiPanel11 = new Sunny.UI.UIPanel();
            this.lb_GpsText = new Sunny.UI.UILabel();
            this.uiPanel43 = new Sunny.UI.UIPanel();
            this.uiPanel44 = new Sunny.UI.UIPanel();
            this.lb_Version = new Sunny.UI.UILabel();
            this.uiPanel45 = new Sunny.UI.UIPanel();
            this.uiPanel46 = new Sunny.UI.UIPanel();
            this.lb_VersionText = new Sunny.UI.UILabel();
            this.uiPanel51 = new Sunny.UI.UIPanel();
            this.uiPanel52 = new Sunny.UI.UIPanel();
            this.lb_FrameNum = new Sunny.UI.UILabel();
            this.uiPanel53 = new Sunny.UI.UIPanel();
            this.uiPanel54 = new Sunny.UI.UIPanel();
            this.lb_FrameNumText = new Sunny.UI.UILabel();
            this.uiPanel73 = new Sunny.UI.UIPanel();
            this.uiPanel94 = new Sunny.UI.UIPanel();
            this.lb_TrackNum = new Sunny.UI.UILabel();
            this.uiPanel95 = new Sunny.UI.UIPanel();
            this.uiPanel96 = new Sunny.UI.UIPanel();
            this.lb_TrackNumText = new Sunny.UI.UILabel();
            this.uiPanel68 = new Sunny.UI.UIPanel();
            this.uiPanel69 = new Sunny.UI.UIPanel();
            this.lb_ShowTarNum = new Sunny.UI.UILabel();
            this.uiPanel70 = new Sunny.UI.UIPanel();
            this.uiPanel71 = new Sunny.UI.UIPanel();
            this.lb_ShowTarNumText = new Sunny.UI.UILabel();
            this.uiPanel47 = new Sunny.UI.UIPanel();
            this.uiPanel48 = new Sunny.UI.UIPanel();
            this.lb_TarNum = new Sunny.UI.UILabel();
            this.uiPanel49 = new Sunny.UI.UIPanel();
            this.uiPanel50 = new Sunny.UI.UIPanel();
            this.lb_TarNumText = new Sunny.UI.UILabel();
            this.uiPanel64 = new Sunny.UI.UIPanel();
            this.uiPanel65 = new Sunny.UI.UIPanel();
            this.lb_CumulativeFrames = new Sunny.UI.UILabel();
            this.uiPanel66 = new Sunny.UI.UIPanel();
            this.uiPanel67 = new Sunny.UI.UIPanel();
            this.lb_CumulativeFramesText = new Sunny.UI.UILabel();
            this.uiPanel42 = new Sunny.UI.UIPanel();
            this.uiPanel63 = new Sunny.UI.UIPanel();
            this.lb_RadarInfo = new Sunny.UI.UILabel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.pan_ConnParamsArea = new Sunny.UI.UIPanel();
            this.pan_Conn = new Sunny.UI.UIPanel();
            this.pan_Params_CANFD = new Sunny.UI.UIPanel();
            this.uiPanel72 = new Sunny.UI.UIPanel();
            this.pan_CANParams = new Sunny.UI.UIPanel();
            this.uiPanel102 = new Sunny.UI.UIPanel();
            this.uiPanel103 = new Sunny.UI.UIPanel();
            this.lb_CANBaudStr = new Sunny.UI.UILabel();
            this.uiPanel104 = new Sunny.UI.UIPanel();
            this.uiPanel105 = new Sunny.UI.UIPanel();
            this.lb_CANBaud = new Sunny.UI.UILabel();
            this.uiPanel106 = new Sunny.UI.UIPanel();
            this.uiPanel107 = new Sunny.UI.UIPanel();
            this.lb_ChannelIndexStrCAN = new Sunny.UI.UILabel();
            this.uiPanel108 = new Sunny.UI.UIPanel();
            this.uiPanel109 = new Sunny.UI.UIPanel();
            this.lb_ChannelIndexCAN = new Sunny.UI.UILabel();
            this.uiPanel110 = new Sunny.UI.UIPanel();
            this.uiPanel111 = new Sunny.UI.UIPanel();
            this.lb_DeviceIndexStrCAN = new Sunny.UI.UILabel();
            this.uiPanel112 = new Sunny.UI.UIPanel();
            this.uiPanel113 = new Sunny.UI.UIPanel();
            this.lb_DeviceIndexCAN = new Sunny.UI.UILabel();
            this.pan_CANFDParams = new Sunny.UI.UIPanel();
            this.uiPanel29 = new Sunny.UI.UIPanel();
            this.uiPanel30 = new Sunny.UI.UIPanel();
            this.lb_DbitBaudStr = new Sunny.UI.UILabel();
            this.uiPanel31 = new Sunny.UI.UIPanel();
            this.uiPanel32 = new Sunny.UI.UIPanel();
            this.lb_DbitBaud = new Sunny.UI.UILabel();
            this.uiPanel25 = new Sunny.UI.UIPanel();
            this.uiPanel26 = new Sunny.UI.UIPanel();
            this.lb_AbitBaudStr = new Sunny.UI.UILabel();
            this.uiPanel27 = new Sunny.UI.UIPanel();
            this.uiPanel28 = new Sunny.UI.UIPanel();
            this.lb_AbitBaud = new Sunny.UI.UILabel();
            this.uiPanel59 = new Sunny.UI.UIPanel();
            this.uiPanel60 = new Sunny.UI.UIPanel();
            this.lb_ChannelIndexStr = new Sunny.UI.UILabel();
            this.uiPanel61 = new Sunny.UI.UIPanel();
            this.uiPanel62 = new Sunny.UI.UIPanel();
            this.lb_ChannelIndex = new Sunny.UI.UILabel();
            this.uiPanel21 = new Sunny.UI.UIPanel();
            this.uiPanel22 = new Sunny.UI.UIPanel();
            this.lb_DeviceIndexStr = new Sunny.UI.UILabel();
            this.uiPanel23 = new Sunny.UI.UIPanel();
            this.uiPanel24 = new Sunny.UI.UIPanel();
            this.lb_DeviceIndex = new Sunny.UI.UILabel();
            this.pan_COMParams = new Sunny.UI.UIPanel();
            this.uiPanel79 = new Sunny.UI.UIPanel();
            this.uiPanel80 = new Sunny.UI.UIPanel();
            this.lb_COMBaudStr = new Sunny.UI.UILabel();
            this.uiPanel81 = new Sunny.UI.UIPanel();
            this.uiPanel87 = new Sunny.UI.UIPanel();
            this.lb_COMBaud = new Sunny.UI.UILabel();
            this.uiPanel88 = new Sunny.UI.UIPanel();
            this.uiPanel89 = new Sunny.UI.UIPanel();
            this.uiPanel90 = new Sunny.UI.UIPanel();
            this.lb_COMNoStr = new Sunny.UI.UILabel();
            this.uiPanel91 = new Sunny.UI.UIPanel();
            this.uiPanel92 = new Sunny.UI.UIPanel();
            this.lb_COMNo = new Sunny.UI.UILabel();
            this.uiPanel93 = new Sunny.UI.UIPanel();
            this.pan_TCPParams = new Sunny.UI.UIPanel();
            this.uiPanel74 = new Sunny.UI.UIPanel();
            this.uiPanel75 = new Sunny.UI.UIPanel();
            this.lb_DevicePort = new Sunny.UI.UILabel();
            this.uiPanel76 = new Sunny.UI.UIPanel();
            this.uiPanel77 = new Sunny.UI.UIPanel();
            this.lb_DevicePortText = new Sunny.UI.UILabel();
            this.uiPanel78 = new Sunny.UI.UIPanel();
            this.uiPanel82 = new Sunny.UI.UIPanel();
            this.uiPanel83 = new Sunny.UI.UIPanel();
            this.lb_DeviceAddress = new Sunny.UI.UILabel();
            this.uiPanel84 = new Sunny.UI.UIPanel();
            this.uiPanel85 = new Sunny.UI.UIPanel();
            this.lb_DeviceAddressText = new Sunny.UI.UILabel();
            this.uiPanel86 = new Sunny.UI.UIPanel();
            this.uiPanel17 = new Sunny.UI.UIPanel();
            this.uiPanel18 = new Sunny.UI.UIPanel();
            this.lb_RadarTypeStr = new Sunny.UI.UILabel();
            this.uiPanel19 = new Sunny.UI.UIPanel();
            this.uiPanel20 = new Sunny.UI.UIPanel();
            this.lb_RadarType = new Sunny.UI.UILabel();
            this.uiPanel33 = new Sunny.UI.UIPanel();
            this.uiPanel34 = new Sunny.UI.UIPanel();
            this.btn_Start = new Sunny.UI.UIButton();
            this.uiPanel35 = new Sunny.UI.UIPanel();
            this.uiPanel36 = new Sunny.UI.UIPanel();
            this.btn_Connect = new Sunny.UI.UIButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.lb_ConnParamsAreaTitle = new Sunny.UI.UILabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.ts_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_VideoPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_TrackData = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_RadarFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_RadarAlive_SR75 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_RadarUpgrade_SR75 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_RadarUpgrade_UCM211 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_FilterTrackIds = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_GpsInfoData = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_FcInfoData = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_Main.SuspendLayout();
            this.pan_Right.SuspendLayout();
            this.pan_Left.SuspendLayout();
            this.uiPanel56.SuspendLayout();
            this.uiPanel57.SuspendLayout();
            this.pan_ControlArea.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.uiPanel37.SuspendLayout();
            this.uiPanel38.SuspendLayout();
            this.uiPanel40.SuspendLayout();
            this.uiPanel12.SuspendLayout();
            this.uiPanel13.SuspendLayout();
            this.uiPanel15.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel16.SuspendLayout();
            this.uiPanel97.SuspendLayout();
            this.uiPanel99.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.uiPanel11.SuspendLayout();
            this.uiPanel43.SuspendLayout();
            this.uiPanel44.SuspendLayout();
            this.uiPanel46.SuspendLayout();
            this.uiPanel51.SuspendLayout();
            this.uiPanel52.SuspendLayout();
            this.uiPanel54.SuspendLayout();
            this.uiPanel73.SuspendLayout();
            this.uiPanel94.SuspendLayout();
            this.uiPanel96.SuspendLayout();
            this.uiPanel68.SuspendLayout();
            this.uiPanel69.SuspendLayout();
            this.uiPanel71.SuspendLayout();
            this.uiPanel47.SuspendLayout();
            this.uiPanel48.SuspendLayout();
            this.uiPanel50.SuspendLayout();
            this.uiPanel64.SuspendLayout();
            this.uiPanel65.SuspendLayout();
            this.uiPanel67.SuspendLayout();
            this.uiPanel63.SuspendLayout();
            this.pan_ConnParamsArea.SuspendLayout();
            this.pan_Conn.SuspendLayout();
            this.pan_Params_CANFD.SuspendLayout();
            this.uiPanel72.SuspendLayout();
            this.pan_CANParams.SuspendLayout();
            this.uiPanel102.SuspendLayout();
            this.uiPanel103.SuspendLayout();
            this.uiPanel105.SuspendLayout();
            this.uiPanel106.SuspendLayout();
            this.uiPanel107.SuspendLayout();
            this.uiPanel109.SuspendLayout();
            this.uiPanel110.SuspendLayout();
            this.uiPanel111.SuspendLayout();
            this.uiPanel113.SuspendLayout();
            this.pan_CANFDParams.SuspendLayout();
            this.uiPanel29.SuspendLayout();
            this.uiPanel30.SuspendLayout();
            this.uiPanel32.SuspendLayout();
            this.uiPanel25.SuspendLayout();
            this.uiPanel26.SuspendLayout();
            this.uiPanel28.SuspendLayout();
            this.uiPanel59.SuspendLayout();
            this.uiPanel60.SuspendLayout();
            this.uiPanel62.SuspendLayout();
            this.uiPanel21.SuspendLayout();
            this.uiPanel22.SuspendLayout();
            this.uiPanel24.SuspendLayout();
            this.pan_COMParams.SuspendLayout();
            this.uiPanel79.SuspendLayout();
            this.uiPanel80.SuspendLayout();
            this.uiPanel87.SuspendLayout();
            this.uiPanel89.SuspendLayout();
            this.uiPanel90.SuspendLayout();
            this.uiPanel92.SuspendLayout();
            this.pan_TCPParams.SuspendLayout();
            this.uiPanel74.SuspendLayout();
            this.uiPanel75.SuspendLayout();
            this.uiPanel77.SuspendLayout();
            this.uiPanel82.SuspendLayout();
            this.uiPanel83.SuspendLayout();
            this.uiPanel85.SuspendLayout();
            this.uiPanel17.SuspendLayout();
            this.uiPanel18.SuspendLayout();
            this.uiPanel20.SuspendLayout();
            this.uiPanel33.SuspendLayout();
            this.uiPanel34.SuspendLayout();
            this.uiPanel36.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Main
            // 
            this.pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.Controls.Add(this.pan_Right);
            this.pan_Main.Controls.Add(this.uiPanel1);
            this.pan_Main.Controls.Add(this.pan_Left);
            this.pan_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Main.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Main.Location = new System.Drawing.Point(10, 45);
            this.pan_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Main.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Main.Name = "pan_Main";
            this.pan_Main.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pan_Main.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Main.Size = new System.Drawing.Size(1180, 745);
            this.pan_Main.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Main.TabIndex = 1;
            this.pan_Main.Text = null;
            this.pan_Main.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Right
            // 
            this.pan_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.Controls.Add(this.renderWindowControl1);
            this.pan_Right.Controls.Add(this.textOverlayPanel);
            this.pan_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Right.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Right.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Right.Location = new System.Drawing.Point(310, 0);
            this.pan_Right.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Right.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Right.Name = "pan_Right";
            this.pan_Right.Opacity = ((byte)(180));
            this.pan_Right.Radius = 10;
            this.pan_Right.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Right.Size = new System.Drawing.Size(870, 745);
            this.pan_Right.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Right.TabIndex = 4;
            this.pan_Right.Text = null;
            this.pan_Right.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // renderWindowControl1
            // 
            this.renderWindowControl1.AddTestActors = false;
            this.renderWindowControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderWindowControl1.Location = new System.Drawing.Point(0, 0);
            this.renderWindowControl1.Margin = new System.Windows.Forms.Padding(0);
            this.renderWindowControl1.Name = "renderWindowControl1";
            this.renderWindowControl1.Size = new System.Drawing.Size(870, 745);
            this.renderWindowControl1.TabIndex = 2;
            this.renderWindowControl1.TestText = null;
            this.renderWindowControl1.Load += new System.EventHandler(this.renderWindowControl1_Load);
            // 
            // textOverlayPanel
            // 
            this.textOverlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.textOverlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOverlayPanel.Location = new System.Drawing.Point(0, 0);
            this.textOverlayPanel.Name = "textOverlayPanel";
            this.textOverlayPanel.Size = new System.Drawing.Size(870, 745);
            this.textOverlayPanel.TabIndex = 3;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel1.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel1.Location = new System.Drawing.Point(300, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(10, 745);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Left
            // 
            this.pan_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.Controls.Add(this.uiPanel56);
            this.pan_Left.Controls.Add(this.uiPanel55);
            this.pan_Left.Controls.Add(this.pan_ControlArea);
            this.pan_Left.Controls.Add(this.uiPanel2);
            this.pan_Left.Controls.Add(this.uiPanel4);
            this.pan_Left.Controls.Add(this.uiPanel5);
            this.pan_Left.Controls.Add(this.pan_ConnParamsArea);
            this.pan_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_Left.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Left.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Left.Location = new System.Drawing.Point(0, 0);
            this.pan_Left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Left.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Left.Name = "pan_Left";
            this.pan_Left.Opacity = ((byte)(180));
            this.pan_Left.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pan_Left.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Left.Size = new System.Drawing.Size(300, 745);
            this.pan_Left.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Left.TabIndex = 2;
            this.pan_Left.Text = null;
            this.pan_Left.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel56
            // 
            this.uiPanel56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.Controls.Add(this.uiPanel57);
            this.uiPanel56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel56.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel56.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel56.Location = new System.Drawing.Point(0, 618);
            this.uiPanel56.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel56.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel56.Name = "uiPanel56";
            this.uiPanel56.Opacity = ((byte)(180));
            this.uiPanel56.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel56.Radius = 10;
            this.uiPanel56.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.Size = new System.Drawing.Size(300, 127);
            this.uiPanel56.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel56.TabIndex = 18;
            this.uiPanel56.Text = null;
            this.uiPanel56.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel57
            // 
            this.uiPanel57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.Controls.Add(this.rtb_SystemMessage);
            this.uiPanel57.Controls.Add(this.uiPanel58);
            this.uiPanel57.Controls.Add(this.lb_SystemInfo);
            this.uiPanel57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel57.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel57.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel57.Location = new System.Drawing.Point(10, 10);
            this.uiPanel57.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel57.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel57.Name = "uiPanel57";
            this.uiPanel57.Opacity = ((byte)(180));
            this.uiPanel57.Radius = 10;
            this.uiPanel57.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel57.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel57.Size = new System.Drawing.Size(280, 107);
            this.uiPanel57.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel57.TabIndex = 6;
            this.uiPanel57.Text = null;
            this.uiPanel57.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_SystemMessage
            // 
            this.rtb_SystemMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_SystemMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rtb_SystemMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rtb_SystemMessage.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rtb_SystemMessage.Location = new System.Drawing.Point(0, 31);
            this.rtb_SystemMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_SystemMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtb_SystemMessage.Name = "rtb_SystemMessage";
            this.rtb_SystemMessage.Padding = new System.Windows.Forms.Padding(2);
            this.rtb_SystemMessage.ReadOnly = true;
            this.rtb_SystemMessage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_SystemMessage.ScrollBarStyleInherited = false;
            this.rtb_SystemMessage.ShowText = false;
            this.rtb_SystemMessage.Size = new System.Drawing.Size(280, 76);
            this.rtb_SystemMessage.Style = Sunny.UI.UIStyle.Custom;
            this.rtb_SystemMessage.TabIndex = 10;
            this.rtb_SystemMessage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // uiPanel58
            // 
            this.uiPanel58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel58.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel58.Location = new System.Drawing.Point(0, 21);
            this.uiPanel58.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel58.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel58.Name = "uiPanel58";
            this.uiPanel58.Opacity = ((byte)(180));
            this.uiPanel58.Radius = 10;
            this.uiPanel58.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel58.Size = new System.Drawing.Size(280, 10);
            this.uiPanel58.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel58.TabIndex = 9;
            this.uiPanel58.Text = null;
            this.uiPanel58.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SystemInfo
            // 
            this.lb_SystemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_SystemInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SystemInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_SystemInfo.Location = new System.Drawing.Point(0, 0);
            this.lb_SystemInfo.Name = "lb_SystemInfo";
            this.lb_SystemInfo.Size = new System.Drawing.Size(280, 21);
            this.lb_SystemInfo.Style = Sunny.UI.UIStyle.Custom;
            this.lb_SystemInfo.TabIndex = 1;
            this.lb_SystemInfo.Text = "系统消息区";
            this.lb_SystemInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel55
            // 
            this.uiPanel55.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel55.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel55.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel55.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel55.Location = new System.Drawing.Point(0, 608);
            this.uiPanel55.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel55.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel55.Name = "uiPanel55";
            this.uiPanel55.Opacity = ((byte)(180));
            this.uiPanel55.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel55.Size = new System.Drawing.Size(300, 10);
            this.uiPanel55.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel55.TabIndex = 15;
            this.uiPanel55.Text = null;
            this.uiPanel55.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_ControlArea
            // 
            this.pan_ControlArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Controls.Add(this.uiPanel6);
            this.pan_ControlArea.Controls.Add(this.lb_ControlAreaTitle);
            this.pan_ControlArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ControlArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_ControlArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_ControlArea.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_ControlArea.Location = new System.Drawing.Point(0, 476);
            this.pan_ControlArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_ControlArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_ControlArea.Name = "pan_ControlArea";
            this.pan_ControlArea.Opacity = ((byte)(180));
            this.pan_ControlArea.Padding = new System.Windows.Forms.Padding(10);
            this.pan_ControlArea.Radius = 10;
            this.pan_ControlArea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Size = new System.Drawing.Size(300, 132);
            this.pan_ControlArea.Style = Sunny.UI.UIStyle.Custom;
            this.pan_ControlArea.TabIndex = 14;
            this.pan_ControlArea.Text = null;
            this.pan_ControlArea.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            this.uiPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Controls.Add(this.uiPanel37);
            this.uiPanel6.Controls.Add(this.uiPanel41);
            this.uiPanel6.Controls.Add(this.uiPanel12);
            this.uiPanel6.Controls.Add(this.uiPanel8);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel6.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel6.Location = new System.Drawing.Point(10, 31);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Opacity = ((byte)(180));
            this.uiPanel6.Radius = 10;
            this.uiPanel6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel6.Size = new System.Drawing.Size(280, 91);
            this.uiPanel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel6.TabIndex = 6;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel37
            // 
            this.uiPanel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.Controls.Add(this.uiPanel38);
            this.uiPanel37.Controls.Add(this.uiPanel39);
            this.uiPanel37.Controls.Add(this.uiPanel40);
            this.uiPanel37.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel37.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel37.Location = new System.Drawing.Point(0, 55);
            this.uiPanel37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel37.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel37.Name = "uiPanel37";
            this.uiPanel37.Opacity = ((byte)(180));
            this.uiPanel37.Radius = 10;
            this.uiPanel37.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel37.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel37.Size = new System.Drawing.Size(280, 35);
            this.uiPanel37.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel37.TabIndex = 13;
            this.uiPanel37.Text = null;
            this.uiPanel37.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel38
            // 
            this.uiPanel38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.Controls.Add(this.btn_StopReplay);
            this.uiPanel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel38.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel38.Location = new System.Drawing.Point(145, 0);
            this.uiPanel38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel38.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel38.Name = "uiPanel38";
            this.uiPanel38.Opacity = ((byte)(180));
            this.uiPanel38.Radius = 10;
            this.uiPanel38.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel38.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel38.Size = new System.Drawing.Size(135, 35);
            this.uiPanel38.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel38.TabIndex = 11;
            this.uiPanel38.Text = null;
            this.uiPanel38.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StopReplay
            // 
            this.btn_StopReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StopReplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StopReplay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_StopReplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_StopReplay.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_StopReplay.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_StopReplay.ForePressColor = System.Drawing.Color.Red;
            this.btn_StopReplay.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_StopReplay.Location = new System.Drawing.Point(0, 0);
            this.btn_StopReplay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_StopReplay.Name = "btn_StopReplay";
            this.btn_StopReplay.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopReplay.RectPressColor = System.Drawing.Color.Red;
            this.btn_StopReplay.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_StopReplay.Size = new System.Drawing.Size(135, 35);
            this.btn_StopReplay.Style = Sunny.UI.UIStyle.Custom;
            this.btn_StopReplay.TabIndex = 1;
            this.btn_StopReplay.Text = "暂停回放";
            this.btn_StopReplay.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StopReplay.Visible = false;
            this.btn_StopReplay.Click += new System.EventHandler(this.btn_StopReplay_Click);
            // 
            // uiPanel39
            // 
            this.uiPanel39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel39.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel39.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel39.Location = new System.Drawing.Point(135, 0);
            this.uiPanel39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel39.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel39.Name = "uiPanel39";
            this.uiPanel39.Opacity = ((byte)(180));
            this.uiPanel39.Radius = 10;
            this.uiPanel39.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel39.Size = new System.Drawing.Size(10, 35);
            this.uiPanel39.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel39.TabIndex = 10;
            this.uiPanel39.Text = null;
            this.uiPanel39.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel40
            // 
            this.uiPanel40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.Controls.Add(this.btn_DataReplay);
            this.uiPanel40.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel40.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel40.Location = new System.Drawing.Point(0, 0);
            this.uiPanel40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel40.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel40.Name = "uiPanel40";
            this.uiPanel40.Opacity = ((byte)(180));
            this.uiPanel40.Radius = 10;
            this.uiPanel40.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel40.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel40.Size = new System.Drawing.Size(135, 35);
            this.uiPanel40.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel40.TabIndex = 9;
            this.uiPanel40.Text = null;
            this.uiPanel40.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DataReplay
            // 
            this.btn_DataReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DataReplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DataReplay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DataReplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_DataReplay.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DataReplay.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_DataReplay.ForePressColor = System.Drawing.Color.Red;
            this.btn_DataReplay.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_DataReplay.Location = new System.Drawing.Point(0, 0);
            this.btn_DataReplay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_DataReplay.Name = "btn_DataReplay";
            this.btn_DataReplay.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DataReplay.RectPressColor = System.Drawing.Color.Red;
            this.btn_DataReplay.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_DataReplay.Size = new System.Drawing.Size(135, 35);
            this.btn_DataReplay.Style = Sunny.UI.UIStyle.Custom;
            this.btn_DataReplay.TabIndex = 0;
            this.btn_DataReplay.Text = "数据回放";
            this.btn_DataReplay.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DataReplay.Click += new System.EventHandler(this.btn_DataReplay_Click);
            // 
            // uiPanel41
            // 
            this.uiPanel41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel41.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel41.Location = new System.Drawing.Point(0, 45);
            this.uiPanel41.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel41.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel41.Name = "uiPanel41";
            this.uiPanel41.Opacity = ((byte)(180));
            this.uiPanel41.Radius = 10;
            this.uiPanel41.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel41.Size = new System.Drawing.Size(280, 10);
            this.uiPanel41.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel41.TabIndex = 12;
            this.uiPanel41.Text = null;
            this.uiPanel41.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel12
            // 
            this.uiPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Controls.Add(this.uiPanel13);
            this.uiPanel12.Controls.Add(this.uiPanel14);
            this.uiPanel12.Controls.Add(this.uiPanel15);
            this.uiPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel12.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel12.Location = new System.Drawing.Point(0, 10);
            this.uiPanel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel12.Name = "uiPanel12";
            this.uiPanel12.Opacity = ((byte)(180));
            this.uiPanel12.Radius = 10;
            this.uiPanel12.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel12.Size = new System.Drawing.Size(280, 35);
            this.uiPanel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel12.TabIndex = 11;
            this.uiPanel12.Text = null;
            this.uiPanel12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel13
            // 
            this.uiPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.Controls.Add(this.btn_SystemSet);
            this.uiPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel13.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel13.Location = new System.Drawing.Point(145, 0);
            this.uiPanel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel13.Name = "uiPanel13";
            this.uiPanel13.Opacity = ((byte)(180));
            this.uiPanel13.Radius = 10;
            this.uiPanel13.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel13.Size = new System.Drawing.Size(135, 35);
            this.uiPanel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel13.TabIndex = 11;
            this.uiPanel13.Text = null;
            this.uiPanel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SystemSet
            // 
            this.btn_SystemSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SystemSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SystemSet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_SystemSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_SystemSet.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SystemSet.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_SystemSet.ForePressColor = System.Drawing.Color.Red;
            this.btn_SystemSet.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_SystemSet.Location = new System.Drawing.Point(0, 0);
            this.btn_SystemSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SystemSet.Name = "btn_SystemSet";
            this.btn_SystemSet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SystemSet.RectPressColor = System.Drawing.Color.Red;
            this.btn_SystemSet.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_SystemSet.Size = new System.Drawing.Size(135, 35);
            this.btn_SystemSet.Style = Sunny.UI.UIStyle.Custom;
            this.btn_SystemSet.TabIndex = 1;
            this.btn_SystemSet.Text = "系统配置";
            this.btn_SystemSet.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SystemSet.Click += new System.EventHandler(this.btn_SystemSet_Click);
            // 
            // uiPanel14
            // 
            this.uiPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel14.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel14.Location = new System.Drawing.Point(135, 0);
            this.uiPanel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel14.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel14.Name = "uiPanel14";
            this.uiPanel14.Opacity = ((byte)(180));
            this.uiPanel14.Radius = 10;
            this.uiPanel14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel14.Size = new System.Drawing.Size(10, 35);
            this.uiPanel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel14.TabIndex = 10;
            this.uiPanel14.Text = null;
            this.uiPanel14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel15
            // 
            this.uiPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Controls.Add(this.btn_ResetView);
            this.uiPanel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel15.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel15.Location = new System.Drawing.Point(0, 0);
            this.uiPanel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel15.Name = "uiPanel15";
            this.uiPanel15.Opacity = ((byte)(180));
            this.uiPanel15.Radius = 10;
            this.uiPanel15.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel15.Size = new System.Drawing.Size(135, 35);
            this.uiPanel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel15.TabIndex = 9;
            this.uiPanel15.Text = null;
            this.uiPanel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ResetView
            // 
            this.btn_ResetView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ResetView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ResetView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ResetView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ResetView.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ResetView.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_ResetView.ForePressColor = System.Drawing.Color.Red;
            this.btn_ResetView.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_ResetView.Location = new System.Drawing.Point(0, 0);
            this.btn_ResetView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ResetView.Name = "btn_ResetView";
            this.btn_ResetView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetView.RectPressColor = System.Drawing.Color.Red;
            this.btn_ResetView.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_ResetView.Size = new System.Drawing.Size(135, 35);
            this.btn_ResetView.Style = Sunny.UI.UIStyle.Custom;
            this.btn_ResetView.TabIndex = 0;
            this.btn_ResetView.Text = "重置视角";
            this.btn_ResetView.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetView.Click += new System.EventHandler(this.btn_ResetCamera_Click);
            // 
            // uiPanel8
            // 
            this.uiPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel8.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel8.Location = new System.Drawing.Point(0, 0);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.Opacity = ((byte)(180));
            this.uiPanel8.Radius = 10;
            this.uiPanel8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel8.Size = new System.Drawing.Size(280, 10);
            this.uiPanel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel8.TabIndex = 8;
            this.uiPanel8.Text = null;
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ControlAreaTitle
            // 
            this.lb_ControlAreaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_ControlAreaTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lb_ControlAreaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_ControlAreaTitle.Location = new System.Drawing.Point(10, 10);
            this.lb_ControlAreaTitle.Name = "lb_ControlAreaTitle";
            this.lb_ControlAreaTitle.Size = new System.Drawing.Size(280, 21);
            this.lb_ControlAreaTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ControlAreaTitle.TabIndex = 0;
            this.lb_ControlAreaTitle.Text = "控制功能区";
            this.lb_ControlAreaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel2.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel2.Location = new System.Drawing.Point(0, 466);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Opacity = ((byte)(180));
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel2.Size = new System.Drawing.Size(300, 10);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 13;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Controls.Add(this.uiPanel16);
            this.uiPanel4.Controls.Add(this.uiPanel7);
            this.uiPanel4.Controls.Add(this.uiPanel43);
            this.uiPanel4.Controls.Add(this.uiPanel51);
            this.uiPanel4.Controls.Add(this.uiPanel73);
            this.uiPanel4.Controls.Add(this.uiPanel68);
            this.uiPanel4.Controls.Add(this.uiPanel47);
            this.uiPanel4.Controls.Add(this.uiPanel64);
            this.uiPanel4.Controls.Add(this.uiPanel42);
            this.uiPanel4.Controls.Add(this.uiPanel63);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel4.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel4.Location = new System.Drawing.Point(0, 221);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Opacity = ((byte)(180));
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel4.Radius = 10;
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Size = new System.Drawing.Size(300, 245);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.TabIndex = 12;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel16
            // 
            this.uiPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Controls.Add(this.uiPanel97);
            this.uiPanel16.Controls.Add(this.uiPanel98);
            this.uiPanel16.Controls.Add(this.uiPanel99);
            this.uiPanel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel16.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel16.Location = new System.Drawing.Point(10, 216);
            this.uiPanel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel16.Name = "uiPanel16";
            this.uiPanel16.Opacity = ((byte)(180));
            this.uiPanel16.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel16.Radius = 1;
            this.uiPanel16.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel16.Size = new System.Drawing.Size(280, 25);
            this.uiPanel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel16.TabIndex = 26;
            this.uiPanel16.Text = null;
            this.uiPanel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel97
            // 
            this.uiPanel97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.Controls.Add(this.lb_Fc);
            this.uiPanel97.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel97.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel97.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel97.Location = new System.Drawing.Point(145, 0);
            this.uiPanel97.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel97.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel97.Name = "uiPanel97";
            this.uiPanel97.Opacity = ((byte)(180));
            this.uiPanel97.Radius = 10;
            this.uiPanel97.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel97.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel97.Size = new System.Drawing.Size(135, 23);
            this.uiPanel97.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel97.TabIndex = 11;
            this.uiPanel97.Text = null;
            this.uiPanel97.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Fc
            // 
            this.lb_Fc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Fc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Fc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_Fc.Location = new System.Drawing.Point(0, 0);
            this.lb_Fc.Name = "lb_Fc";
            this.lb_Fc.Size = new System.Drawing.Size(135, 23);
            this.lb_Fc.Style = Sunny.UI.UIStyle.Custom;
            this.lb_Fc.TabIndex = 1;
            this.lb_Fc.Text = "Invalid";
            this.lb_Fc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel98
            // 
            this.uiPanel98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel98.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel98.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel98.Location = new System.Drawing.Point(135, 0);
            this.uiPanel98.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel98.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel98.Name = "uiPanel98";
            this.uiPanel98.Opacity = ((byte)(180));
            this.uiPanel98.Radius = 10;
            this.uiPanel98.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel98.Size = new System.Drawing.Size(10, 23);
            this.uiPanel98.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel98.TabIndex = 10;
            this.uiPanel98.Text = null;
            this.uiPanel98.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel99
            // 
            this.uiPanel99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.Controls.Add(this.lb_FcText);
            this.uiPanel99.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel99.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel99.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel99.Location = new System.Drawing.Point(0, 0);
            this.uiPanel99.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel99.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel99.Name = "uiPanel99";
            this.uiPanel99.Opacity = ((byte)(180));
            this.uiPanel99.Radius = 10;
            this.uiPanel99.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel99.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel99.Size = new System.Drawing.Size(135, 23);
            this.uiPanel99.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel99.TabIndex = 9;
            this.uiPanel99.Text = null;
            this.uiPanel99.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FcText
            // 
            this.lb_FcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FcText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FcText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_FcText.Location = new System.Drawing.Point(0, 0);
            this.lb_FcText.Name = "lb_FcText";
            this.lb_FcText.Size = new System.Drawing.Size(135, 23);
            this.lb_FcText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FcText.TabIndex = 0;
            this.lb_FcText.Text = "飞控状态：";
            this.lb_FcText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel7
            // 
            this.uiPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Controls.Add(this.uiPanel9);
            this.uiPanel7.Controls.Add(this.uiPanel10);
            this.uiPanel7.Controls.Add(this.uiPanel11);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel7.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel7.Location = new System.Drawing.Point(10, 191);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Opacity = ((byte)(180));
            this.uiPanel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel7.Radius = 1;
            this.uiPanel7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel7.Size = new System.Drawing.Size(280, 25);
            this.uiPanel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel7.TabIndex = 25;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel9
            // 
            this.uiPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Controls.Add(this.lb_Gps);
            this.uiPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel9.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel9.Location = new System.Drawing.Point(145, 0);
            this.uiPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel9.Name = "uiPanel9";
            this.uiPanel9.Opacity = ((byte)(180));
            this.uiPanel9.Radius = 10;
            this.uiPanel9.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel9.Size = new System.Drawing.Size(135, 23);
            this.uiPanel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel9.TabIndex = 11;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Gps
            // 
            this.lb_Gps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Gps.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Gps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_Gps.Location = new System.Drawing.Point(0, 0);
            this.lb_Gps.Name = "lb_Gps";
            this.lb_Gps.Size = new System.Drawing.Size(135, 23);
            this.lb_Gps.Style = Sunny.UI.UIStyle.Custom;
            this.lb_Gps.TabIndex = 1;
            this.lb_Gps.Text = "Invalid";
            this.lb_Gps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel10
            // 
            this.uiPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel10.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel10.Location = new System.Drawing.Point(135, 0);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Opacity = ((byte)(180));
            this.uiPanel10.Radius = 10;
            this.uiPanel10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(10, 23);
            this.uiPanel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel10.TabIndex = 10;
            this.uiPanel10.Text = null;
            this.uiPanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel11
            // 
            this.uiPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Controls.Add(this.lb_GpsText);
            this.uiPanel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel11.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel11.Location = new System.Drawing.Point(0, 0);
            this.uiPanel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel11.Name = "uiPanel11";
            this.uiPanel11.Opacity = ((byte)(180));
            this.uiPanel11.Radius = 10;
            this.uiPanel11.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel11.Size = new System.Drawing.Size(135, 23);
            this.uiPanel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel11.TabIndex = 9;
            this.uiPanel11.Text = null;
            this.uiPanel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_GpsText
            // 
            this.lb_GpsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_GpsText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GpsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_GpsText.Location = new System.Drawing.Point(0, 0);
            this.lb_GpsText.Name = "lb_GpsText";
            this.lb_GpsText.Size = new System.Drawing.Size(135, 23);
            this.lb_GpsText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_GpsText.TabIndex = 0;
            this.lb_GpsText.Text = "GPS状态：";
            this.lb_GpsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel43
            // 
            this.uiPanel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.Controls.Add(this.uiPanel44);
            this.uiPanel43.Controls.Add(this.uiPanel45);
            this.uiPanel43.Controls.Add(this.uiPanel46);
            this.uiPanel43.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel43.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel43.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel43.Location = new System.Drawing.Point(10, 166);
            this.uiPanel43.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel43.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel43.Name = "uiPanel43";
            this.uiPanel43.Opacity = ((byte)(180));
            this.uiPanel43.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel43.Radius = 1;
            this.uiPanel43.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel43.Size = new System.Drawing.Size(280, 25);
            this.uiPanel43.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel43.TabIndex = 24;
            this.uiPanel43.Text = null;
            this.uiPanel43.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel44
            // 
            this.uiPanel44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.Controls.Add(this.lb_Version);
            this.uiPanel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel44.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel44.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel44.Location = new System.Drawing.Point(145, 0);
            this.uiPanel44.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel44.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel44.Name = "uiPanel44";
            this.uiPanel44.Opacity = ((byte)(180));
            this.uiPanel44.Radius = 10;
            this.uiPanel44.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel44.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel44.Size = new System.Drawing.Size(135, 23);
            this.uiPanel44.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel44.TabIndex = 11;
            this.uiPanel44.Text = null;
            this.uiPanel44.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Version
            // 
            this.lb_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Version.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_Version.Location = new System.Drawing.Point(0, 0);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(135, 23);
            this.lb_Version.Style = Sunny.UI.UIStyle.Custom;
            this.lb_Version.TabIndex = 1;
            this.lb_Version.Text = "v0.0.0";
            this.lb_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel45
            // 
            this.uiPanel45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel45.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel45.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel45.Location = new System.Drawing.Point(135, 0);
            this.uiPanel45.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel45.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel45.Name = "uiPanel45";
            this.uiPanel45.Opacity = ((byte)(180));
            this.uiPanel45.Radius = 10;
            this.uiPanel45.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel45.Size = new System.Drawing.Size(10, 23);
            this.uiPanel45.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel45.TabIndex = 10;
            this.uiPanel45.Text = null;
            this.uiPanel45.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel46
            // 
            this.uiPanel46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.Controls.Add(this.lb_VersionText);
            this.uiPanel46.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel46.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel46.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel46.Location = new System.Drawing.Point(0, 0);
            this.uiPanel46.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel46.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel46.Name = "uiPanel46";
            this.uiPanel46.Opacity = ((byte)(180));
            this.uiPanel46.Radius = 10;
            this.uiPanel46.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel46.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel46.Size = new System.Drawing.Size(135, 23);
            this.uiPanel46.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel46.TabIndex = 9;
            this.uiPanel46.Text = null;
            this.uiPanel46.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_VersionText
            // 
            this.lb_VersionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_VersionText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_VersionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_VersionText.Location = new System.Drawing.Point(0, 0);
            this.lb_VersionText.Name = "lb_VersionText";
            this.lb_VersionText.Size = new System.Drawing.Size(135, 23);
            this.lb_VersionText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_VersionText.TabIndex = 0;
            this.lb_VersionText.Text = "软件版本号：";
            this.lb_VersionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel51
            // 
            this.uiPanel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.Controls.Add(this.uiPanel52);
            this.uiPanel51.Controls.Add(this.uiPanel53);
            this.uiPanel51.Controls.Add(this.uiPanel54);
            this.uiPanel51.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel51.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel51.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel51.Location = new System.Drawing.Point(10, 141);
            this.uiPanel51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel51.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel51.Name = "uiPanel51";
            this.uiPanel51.Opacity = ((byte)(180));
            this.uiPanel51.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel51.Radius = 1;
            this.uiPanel51.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel51.Size = new System.Drawing.Size(280, 25);
            this.uiPanel51.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel51.TabIndex = 23;
            this.uiPanel51.Text = null;
            this.uiPanel51.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel52
            // 
            this.uiPanel52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.Controls.Add(this.lb_FrameNum);
            this.uiPanel52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel52.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel52.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel52.Location = new System.Drawing.Point(145, 0);
            this.uiPanel52.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel52.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel52.Name = "uiPanel52";
            this.uiPanel52.Opacity = ((byte)(180));
            this.uiPanel52.Radius = 10;
            this.uiPanel52.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel52.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel52.Size = new System.Drawing.Size(135, 23);
            this.uiPanel52.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel52.TabIndex = 11;
            this.uiPanel52.Text = null;
            this.uiPanel52.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FrameNum
            // 
            this.lb_FrameNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FrameNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_FrameNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_FrameNum.Location = new System.Drawing.Point(0, 0);
            this.lb_FrameNum.Name = "lb_FrameNum";
            this.lb_FrameNum.Size = new System.Drawing.Size(135, 23);
            this.lb_FrameNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FrameNum.TabIndex = 1;
            this.lb_FrameNum.Text = "0Hz";
            this.lb_FrameNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel53
            // 
            this.uiPanel53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel53.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel53.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel53.Location = new System.Drawing.Point(135, 0);
            this.uiPanel53.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel53.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel53.Name = "uiPanel53";
            this.uiPanel53.Opacity = ((byte)(180));
            this.uiPanel53.Radius = 10;
            this.uiPanel53.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel53.Size = new System.Drawing.Size(10, 23);
            this.uiPanel53.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel53.TabIndex = 10;
            this.uiPanel53.Text = null;
            this.uiPanel53.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel54
            // 
            this.uiPanel54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.Controls.Add(this.lb_FrameNumText);
            this.uiPanel54.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel54.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel54.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel54.Location = new System.Drawing.Point(0, 0);
            this.uiPanel54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel54.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel54.Name = "uiPanel54";
            this.uiPanel54.Opacity = ((byte)(180));
            this.uiPanel54.Radius = 10;
            this.uiPanel54.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel54.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel54.Size = new System.Drawing.Size(135, 23);
            this.uiPanel54.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel54.TabIndex = 9;
            this.uiPanel54.Text = null;
            this.uiPanel54.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FrameNumText
            // 
            this.lb_FrameNumText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FrameNumText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FrameNumText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_FrameNumText.Location = new System.Drawing.Point(0, 0);
            this.lb_FrameNumText.Name = "lb_FrameNumText";
            this.lb_FrameNumText.Size = new System.Drawing.Size(135, 23);
            this.lb_FrameNumText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FrameNumText.TabIndex = 0;
            this.lb_FrameNumText.Text = "雷达帧率：";
            this.lb_FrameNumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel73
            // 
            this.uiPanel73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.Controls.Add(this.uiPanel94);
            this.uiPanel73.Controls.Add(this.uiPanel95);
            this.uiPanel73.Controls.Add(this.uiPanel96);
            this.uiPanel73.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel73.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel73.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel73.Location = new System.Drawing.Point(10, 116);
            this.uiPanel73.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel73.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel73.Name = "uiPanel73";
            this.uiPanel73.Opacity = ((byte)(180));
            this.uiPanel73.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel73.Radius = 1;
            this.uiPanel73.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel73.Size = new System.Drawing.Size(280, 25);
            this.uiPanel73.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel73.TabIndex = 22;
            this.uiPanel73.Text = null;
            this.uiPanel73.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel94
            // 
            this.uiPanel94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.Controls.Add(this.lb_TrackNum);
            this.uiPanel94.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel94.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel94.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel94.Location = new System.Drawing.Point(145, 0);
            this.uiPanel94.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel94.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel94.Name = "uiPanel94";
            this.uiPanel94.Opacity = ((byte)(180));
            this.uiPanel94.Radius = 10;
            this.uiPanel94.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel94.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel94.Size = new System.Drawing.Size(135, 23);
            this.uiPanel94.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel94.TabIndex = 11;
            this.uiPanel94.Text = null;
            this.uiPanel94.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackNum
            // 
            this.lb_TrackNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_TrackNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_TrackNum.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackNum.Name = "lb_TrackNum";
            this.lb_TrackNum.Size = new System.Drawing.Size(135, 23);
            this.lb_TrackNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackNum.TabIndex = 1;
            this.lb_TrackNum.Text = "0";
            this.lb_TrackNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel95
            // 
            this.uiPanel95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel95.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel95.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel95.Location = new System.Drawing.Point(135, 0);
            this.uiPanel95.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel95.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel95.Name = "uiPanel95";
            this.uiPanel95.Opacity = ((byte)(180));
            this.uiPanel95.Radius = 10;
            this.uiPanel95.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel95.Size = new System.Drawing.Size(10, 23);
            this.uiPanel95.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel95.TabIndex = 10;
            this.uiPanel95.Text = null;
            this.uiPanel95.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel96
            // 
            this.uiPanel96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.Controls.Add(this.lb_TrackNumText);
            this.uiPanel96.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel96.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel96.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel96.Location = new System.Drawing.Point(0, 0);
            this.uiPanel96.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel96.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel96.Name = "uiPanel96";
            this.uiPanel96.Opacity = ((byte)(180));
            this.uiPanel96.Radius = 10;
            this.uiPanel96.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel96.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel96.Size = new System.Drawing.Size(135, 23);
            this.uiPanel96.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel96.TabIndex = 9;
            this.uiPanel96.Text = null;
            this.uiPanel96.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackNumText
            // 
            this.lb_TrackNumText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackNumText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackNumText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackNumText.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackNumText.Name = "lb_TrackNumText";
            this.lb_TrackNumText.Size = new System.Drawing.Size(135, 23);
            this.lb_TrackNumText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackNumText.TabIndex = 0;
            this.lb_TrackNumText.Text = "周期目标数：";
            this.lb_TrackNumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel68
            // 
            this.uiPanel68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.Controls.Add(this.uiPanel69);
            this.uiPanel68.Controls.Add(this.uiPanel70);
            this.uiPanel68.Controls.Add(this.uiPanel71);
            this.uiPanel68.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel68.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel68.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel68.Location = new System.Drawing.Point(10, 91);
            this.uiPanel68.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel68.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel68.Name = "uiPanel68";
            this.uiPanel68.Opacity = ((byte)(180));
            this.uiPanel68.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel68.Radius = 1;
            this.uiPanel68.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel68.Size = new System.Drawing.Size(280, 25);
            this.uiPanel68.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel68.TabIndex = 19;
            this.uiPanel68.Text = null;
            this.uiPanel68.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel69
            // 
            this.uiPanel69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.Controls.Add(this.lb_ShowTarNum);
            this.uiPanel69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel69.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel69.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel69.Location = new System.Drawing.Point(145, 0);
            this.uiPanel69.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel69.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel69.Name = "uiPanel69";
            this.uiPanel69.Opacity = ((byte)(180));
            this.uiPanel69.Radius = 10;
            this.uiPanel69.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel69.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel69.Size = new System.Drawing.Size(135, 23);
            this.uiPanel69.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel69.TabIndex = 11;
            this.uiPanel69.Text = null;
            this.uiPanel69.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ShowTarNum
            // 
            this.lb_ShowTarNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ShowTarNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_ShowTarNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_ShowTarNum.Location = new System.Drawing.Point(0, 0);
            this.lb_ShowTarNum.Name = "lb_ShowTarNum";
            this.lb_ShowTarNum.Size = new System.Drawing.Size(135, 23);
            this.lb_ShowTarNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ShowTarNum.TabIndex = 1;
            this.lb_ShowTarNum.Text = "0";
            this.lb_ShowTarNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel70
            // 
            this.uiPanel70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel70.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel70.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel70.Location = new System.Drawing.Point(135, 0);
            this.uiPanel70.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel70.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel70.Name = "uiPanel70";
            this.uiPanel70.Opacity = ((byte)(180));
            this.uiPanel70.Radius = 10;
            this.uiPanel70.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel70.Size = new System.Drawing.Size(10, 23);
            this.uiPanel70.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel70.TabIndex = 10;
            this.uiPanel70.Text = null;
            this.uiPanel70.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel71
            // 
            this.uiPanel71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.Controls.Add(this.lb_ShowTarNumText);
            this.uiPanel71.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel71.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel71.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel71.Location = new System.Drawing.Point(0, 0);
            this.uiPanel71.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel71.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel71.Name = "uiPanel71";
            this.uiPanel71.Opacity = ((byte)(180));
            this.uiPanel71.Radius = 10;
            this.uiPanel71.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel71.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel71.Size = new System.Drawing.Size(135, 23);
            this.uiPanel71.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel71.TabIndex = 9;
            this.uiPanel71.Text = null;
            this.uiPanel71.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ShowTarNumText
            // 
            this.lb_ShowTarNumText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ShowTarNumText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowTarNumText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ShowTarNumText.Location = new System.Drawing.Point(0, 0);
            this.lb_ShowTarNumText.Name = "lb_ShowTarNumText";
            this.lb_ShowTarNumText.Size = new System.Drawing.Size(135, 23);
            this.lb_ShowTarNumText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ShowTarNumText.TabIndex = 0;
            this.lb_ShowTarNumText.Text = "累积点云数：";
            this.lb_ShowTarNumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel47
            // 
            this.uiPanel47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.Controls.Add(this.uiPanel48);
            this.uiPanel47.Controls.Add(this.uiPanel49);
            this.uiPanel47.Controls.Add(this.uiPanel50);
            this.uiPanel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel47.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel47.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel47.Location = new System.Drawing.Point(10, 66);
            this.uiPanel47.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel47.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel47.Name = "uiPanel47";
            this.uiPanel47.Opacity = ((byte)(180));
            this.uiPanel47.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel47.Radius = 1;
            this.uiPanel47.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel47.Size = new System.Drawing.Size(280, 25);
            this.uiPanel47.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel47.TabIndex = 18;
            this.uiPanel47.Text = null;
            this.uiPanel47.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel48
            // 
            this.uiPanel48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.Controls.Add(this.lb_TarNum);
            this.uiPanel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel48.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel48.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel48.Location = new System.Drawing.Point(145, 0);
            this.uiPanel48.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel48.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel48.Name = "uiPanel48";
            this.uiPanel48.Opacity = ((byte)(180));
            this.uiPanel48.Radius = 10;
            this.uiPanel48.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel48.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel48.Size = new System.Drawing.Size(135, 23);
            this.uiPanel48.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel48.TabIndex = 11;
            this.uiPanel48.Text = null;
            this.uiPanel48.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TarNum
            // 
            this.lb_TarNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TarNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_TarNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_TarNum.Location = new System.Drawing.Point(0, 0);
            this.lb_TarNum.Name = "lb_TarNum";
            this.lb_TarNum.Size = new System.Drawing.Size(135, 23);
            this.lb_TarNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TarNum.TabIndex = 1;
            this.lb_TarNum.Text = "0";
            this.lb_TarNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel49
            // 
            this.uiPanel49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel49.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel49.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel49.Location = new System.Drawing.Point(135, 0);
            this.uiPanel49.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel49.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel49.Name = "uiPanel49";
            this.uiPanel49.Opacity = ((byte)(180));
            this.uiPanel49.Radius = 10;
            this.uiPanel49.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel49.Size = new System.Drawing.Size(10, 23);
            this.uiPanel49.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel49.TabIndex = 10;
            this.uiPanel49.Text = null;
            this.uiPanel49.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel50
            // 
            this.uiPanel50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.Controls.Add(this.lb_TarNumText);
            this.uiPanel50.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel50.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel50.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel50.Location = new System.Drawing.Point(0, 0);
            this.uiPanel50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel50.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel50.Name = "uiPanel50";
            this.uiPanel50.Opacity = ((byte)(180));
            this.uiPanel50.Radius = 10;
            this.uiPanel50.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel50.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel50.Size = new System.Drawing.Size(135, 23);
            this.uiPanel50.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel50.TabIndex = 9;
            this.uiPanel50.Text = null;
            this.uiPanel50.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TarNumText
            // 
            this.lb_TarNumText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TarNumText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TarNumText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TarNumText.Location = new System.Drawing.Point(0, 0);
            this.lb_TarNumText.Name = "lb_TarNumText";
            this.lb_TarNumText.Size = new System.Drawing.Size(135, 23);
            this.lb_TarNumText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TarNumText.TabIndex = 0;
            this.lb_TarNumText.Text = "周期点云数：";
            this.lb_TarNumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel64
            // 
            this.uiPanel64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.Controls.Add(this.uiPanel65);
            this.uiPanel64.Controls.Add(this.uiPanel66);
            this.uiPanel64.Controls.Add(this.uiPanel67);
            this.uiPanel64.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel64.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel64.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel64.Location = new System.Drawing.Point(10, 41);
            this.uiPanel64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel64.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel64.Name = "uiPanel64";
            this.uiPanel64.Opacity = ((byte)(180));
            this.uiPanel64.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel64.Radius = 1;
            this.uiPanel64.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel64.Size = new System.Drawing.Size(280, 25);
            this.uiPanel64.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel64.TabIndex = 17;
            this.uiPanel64.Text = null;
            this.uiPanel64.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel65
            // 
            this.uiPanel65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.Controls.Add(this.lb_CumulativeFrames);
            this.uiPanel65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel65.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel65.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel65.Location = new System.Drawing.Point(145, 0);
            this.uiPanel65.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel65.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel65.Name = "uiPanel65";
            this.uiPanel65.Opacity = ((byte)(180));
            this.uiPanel65.Radius = 10;
            this.uiPanel65.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel65.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel65.Size = new System.Drawing.Size(135, 23);
            this.uiPanel65.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel65.TabIndex = 11;
            this.uiPanel65.Text = null;
            this.uiPanel65.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CumulativeFrames
            // 
            this.lb_CumulativeFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CumulativeFrames.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CumulativeFrames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_CumulativeFrames.Location = new System.Drawing.Point(0, 0);
            this.lb_CumulativeFrames.Name = "lb_CumulativeFrames";
            this.lb_CumulativeFrames.Size = new System.Drawing.Size(135, 23);
            this.lb_CumulativeFrames.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CumulativeFrames.TabIndex = 1;
            this.lb_CumulativeFrames.Text = "1";
            this.lb_CumulativeFrames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel66
            // 
            this.uiPanel66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel66.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel66.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel66.Location = new System.Drawing.Point(135, 0);
            this.uiPanel66.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel66.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel66.Name = "uiPanel66";
            this.uiPanel66.Opacity = ((byte)(180));
            this.uiPanel66.Radius = 10;
            this.uiPanel66.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel66.Size = new System.Drawing.Size(10, 23);
            this.uiPanel66.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel66.TabIndex = 10;
            this.uiPanel66.Text = null;
            this.uiPanel66.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel67
            // 
            this.uiPanel67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.Controls.Add(this.lb_CumulativeFramesText);
            this.uiPanel67.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel67.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel67.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel67.Location = new System.Drawing.Point(0, 0);
            this.uiPanel67.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel67.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel67.Name = "uiPanel67";
            this.uiPanel67.Opacity = ((byte)(180));
            this.uiPanel67.Radius = 10;
            this.uiPanel67.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel67.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel67.Size = new System.Drawing.Size(135, 23);
            this.uiPanel67.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel67.TabIndex = 9;
            this.uiPanel67.Text = null;
            this.uiPanel67.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CumulativeFramesText
            // 
            this.lb_CumulativeFramesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CumulativeFramesText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CumulativeFramesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_CumulativeFramesText.Location = new System.Drawing.Point(0, 0);
            this.lb_CumulativeFramesText.Name = "lb_CumulativeFramesText";
            this.lb_CumulativeFramesText.Size = new System.Drawing.Size(135, 23);
            this.lb_CumulativeFramesText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CumulativeFramesText.TabIndex = 0;
            this.lb_CumulativeFramesText.Text = "点云累计帧数：";
            this.lb_CumulativeFramesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel42
            // 
            this.uiPanel42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel42.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel42.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel42.Location = new System.Drawing.Point(10, 31);
            this.uiPanel42.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel42.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel42.Name = "uiPanel42";
            this.uiPanel42.Opacity = ((byte)(180));
            this.uiPanel42.Radius = 10;
            this.uiPanel42.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel42.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel42.Size = new System.Drawing.Size(280, 10);
            this.uiPanel42.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel42.TabIndex = 16;
            this.uiPanel42.Text = null;
            this.uiPanel42.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel63
            // 
            this.uiPanel63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.Controls.Add(this.lb_RadarInfo);
            this.uiPanel63.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel63.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel63.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel63.Location = new System.Drawing.Point(10, 10);
            this.uiPanel63.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel63.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel63.Name = "uiPanel63";
            this.uiPanel63.Opacity = ((byte)(180));
            this.uiPanel63.Radius = 10;
            this.uiPanel63.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel63.Size = new System.Drawing.Size(280, 21);
            this.uiPanel63.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel63.TabIndex = 12;
            this.uiPanel63.Text = null;
            this.uiPanel63.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_RadarInfo
            // 
            this.lb_RadarInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_RadarInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_RadarInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_RadarInfo.Location = new System.Drawing.Point(0, 0);
            this.lb_RadarInfo.Name = "lb_RadarInfo";
            this.lb_RadarInfo.Size = new System.Drawing.Size(145, 21);
            this.lb_RadarInfo.Style = Sunny.UI.UIStyle.Custom;
            this.lb_RadarInfo.TabIndex = 2;
            this.lb_RadarInfo.Text = "信息展示区";
            this.lb_RadarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel5
            // 
            this.uiPanel5.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel5.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel5.Location = new System.Drawing.Point(0, 211);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Opacity = ((byte)(180));
            this.uiPanel5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel5.Size = new System.Drawing.Size(300, 10);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 11;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_ConnParamsArea
            // 
            this.pan_ConnParamsArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.Controls.Add(this.pan_Conn);
            this.pan_ConnParamsArea.Controls.Add(this.uiPanel33);
            this.pan_ConnParamsArea.Controls.Add(this.uiPanel3);
            this.pan_ConnParamsArea.Controls.Add(this.lb_ConnParamsAreaTitle);
            this.pan_ConnParamsArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ConnParamsArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_ConnParamsArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_ConnParamsArea.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_ConnParamsArea.Location = new System.Drawing.Point(0, 0);
            this.pan_ConnParamsArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_ConnParamsArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_ConnParamsArea.Name = "pan_ConnParamsArea";
            this.pan_ConnParamsArea.Opacity = ((byte)(180));
            this.pan_ConnParamsArea.Padding = new System.Windows.Forms.Padding(10);
            this.pan_ConnParamsArea.Radius = 10;
            this.pan_ConnParamsArea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ConnParamsArea.Size = new System.Drawing.Size(300, 211);
            this.pan_ConnParamsArea.Style = Sunny.UI.UIStyle.Custom;
            this.pan_ConnParamsArea.TabIndex = 5;
            this.pan_ConnParamsArea.Text = null;
            this.pan_ConnParamsArea.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Conn
            // 
            this.pan_Conn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.Controls.Add(this.pan_Params_CANFD);
            this.pan_Conn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Conn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Conn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Conn.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Conn.Location = new System.Drawing.Point(10, 41);
            this.pan_Conn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Conn.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Conn.Name = "pan_Conn";
            this.pan_Conn.Opacity = ((byte)(180));
            this.pan_Conn.Radius = 10;
            this.pan_Conn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pan_Conn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Conn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Conn.Size = new System.Drawing.Size(280, 125);
            this.pan_Conn.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Conn.TabIndex = 15;
            this.pan_Conn.Text = null;
            this.pan_Conn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Params_CANFD
            // 
            this.pan_Params_CANFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.Controls.Add(this.uiPanel72);
            this.pan_Params_CANFD.Controls.Add(this.uiPanel17);
            this.pan_Params_CANFD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Params_CANFD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Params_CANFD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Params_CANFD.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Params_CANFD.Location = new System.Drawing.Point(0, 0);
            this.pan_Params_CANFD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Params_CANFD.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Params_CANFD.Name = "pan_Params_CANFD";
            this.pan_Params_CANFD.Opacity = ((byte)(180));
            this.pan_Params_CANFD.Radius = 10;
            this.pan_Params_CANFD.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pan_Params_CANFD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Params_CANFD.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Params_CANFD.Size = new System.Drawing.Size(280, 125);
            this.pan_Params_CANFD.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Params_CANFD.TabIndex = 16;
            this.pan_Params_CANFD.Text = null;
            this.pan_Params_CANFD.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel72
            // 
            this.uiPanel72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.Controls.Add(this.pan_CANParams);
            this.uiPanel72.Controls.Add(this.pan_CANFDParams);
            this.uiPanel72.Controls.Add(this.pan_COMParams);
            this.uiPanel72.Controls.Add(this.pan_TCPParams);
            this.uiPanel72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel72.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel72.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel72.Location = new System.Drawing.Point(0, 25);
            this.uiPanel72.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel72.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel72.Name = "uiPanel72";
            this.uiPanel72.Opacity = ((byte)(180));
            this.uiPanel72.Radius = 10;
            this.uiPanel72.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel72.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel72.Size = new System.Drawing.Size(280, 100);
            this.uiPanel72.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel72.TabIndex = 17;
            this.uiPanel72.Text = null;
            this.uiPanel72.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_CANParams
            // 
            this.pan_CANParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.Controls.Add(this.uiPanel102);
            this.pan_CANParams.Controls.Add(this.uiPanel106);
            this.pan_CANParams.Controls.Add(this.uiPanel110);
            this.pan_CANParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_CANParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_CANParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_CANParams.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_CANParams.Location = new System.Drawing.Point(0, 0);
            this.pan_CANParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_CANParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_CANParams.Name = "pan_CANParams";
            this.pan_CANParams.Opacity = ((byte)(180));
            this.pan_CANParams.Radius = 10;
            this.pan_CANParams.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANParams.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_CANParams.Size = new System.Drawing.Size(280, 100);
            this.pan_CANParams.Style = Sunny.UI.UIStyle.Custom;
            this.pan_CANParams.TabIndex = 21;
            this.pan_CANParams.Text = null;
            this.pan_CANParams.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel102
            // 
            this.uiPanel102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.Controls.Add(this.uiPanel103);
            this.uiPanel102.Controls.Add(this.uiPanel104);
            this.uiPanel102.Controls.Add(this.uiPanel105);
            this.uiPanel102.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel102.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel102.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel102.Location = new System.Drawing.Point(0, 64);
            this.uiPanel102.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel102.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel102.Name = "uiPanel102";
            this.uiPanel102.Opacity = ((byte)(180));
            this.uiPanel102.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel102.Radius = 10;
            this.uiPanel102.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel102.Size = new System.Drawing.Size(280, 32);
            this.uiPanel102.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel102.TabIndex = 22;
            this.uiPanel102.Text = null;
            this.uiPanel102.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel103
            // 
            this.uiPanel103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.Controls.Add(this.lb_CANBaudStr);
            this.uiPanel103.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel103.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel103.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel103.Location = new System.Drawing.Point(145, 0);
            this.uiPanel103.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel103.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel103.Name = "uiPanel103";
            this.uiPanel103.Opacity = ((byte)(180));
            this.uiPanel103.Radius = 10;
            this.uiPanel103.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel103.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel103.Size = new System.Drawing.Size(135, 30);
            this.uiPanel103.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel103.TabIndex = 11;
            this.uiPanel103.Text = null;
            this.uiPanel103.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CANBaudStr
            // 
            this.lb_CANBaudStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CANBaudStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_CANBaudStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_CANBaudStr.Location = new System.Drawing.Point(0, 0);
            this.lb_CANBaudStr.Name = "lb_CANBaudStr";
            this.lb_CANBaudStr.Size = new System.Drawing.Size(135, 30);
            this.lb_CANBaudStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CANBaudStr.TabIndex = 1;
            this.lb_CANBaudStr.Text = "1Mbps";
            this.lb_CANBaudStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel104
            // 
            this.uiPanel104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel104.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel104.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel104.Location = new System.Drawing.Point(135, 0);
            this.uiPanel104.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel104.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel104.Name = "uiPanel104";
            this.uiPanel104.Opacity = ((byte)(180));
            this.uiPanel104.Radius = 10;
            this.uiPanel104.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel104.Size = new System.Drawing.Size(10, 30);
            this.uiPanel104.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel104.TabIndex = 10;
            this.uiPanel104.Text = null;
            this.uiPanel104.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel105
            // 
            this.uiPanel105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.Controls.Add(this.lb_CANBaud);
            this.uiPanel105.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel105.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel105.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel105.Location = new System.Drawing.Point(0, 0);
            this.uiPanel105.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel105.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel105.Name = "uiPanel105";
            this.uiPanel105.Opacity = ((byte)(180));
            this.uiPanel105.Radius = 10;
            this.uiPanel105.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel105.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel105.Size = new System.Drawing.Size(135, 30);
            this.uiPanel105.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel105.TabIndex = 9;
            this.uiPanel105.Text = null;
            this.uiPanel105.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CANBaud
            // 
            this.lb_CANBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CANBaud.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CANBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_CANBaud.Location = new System.Drawing.Point(0, 0);
            this.lb_CANBaud.Name = "lb_CANBaud";
            this.lb_CANBaud.Size = new System.Drawing.Size(135, 30);
            this.lb_CANBaud.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CANBaud.TabIndex = 0;
            this.lb_CANBaud.Text = "波特率：";
            this.lb_CANBaud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel106
            // 
            this.uiPanel106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.Controls.Add(this.uiPanel107);
            this.uiPanel106.Controls.Add(this.uiPanel108);
            this.uiPanel106.Controls.Add(this.uiPanel109);
            this.uiPanel106.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel106.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel106.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel106.Location = new System.Drawing.Point(0, 32);
            this.uiPanel106.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel106.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel106.Name = "uiPanel106";
            this.uiPanel106.Opacity = ((byte)(180));
            this.uiPanel106.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel106.Radius = 10;
            this.uiPanel106.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel106.Size = new System.Drawing.Size(280, 32);
            this.uiPanel106.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel106.TabIndex = 21;
            this.uiPanel106.Text = null;
            this.uiPanel106.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel107
            // 
            this.uiPanel107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.Controls.Add(this.lb_ChannelIndexStrCAN);
            this.uiPanel107.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel107.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel107.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel107.Location = new System.Drawing.Point(145, 0);
            this.uiPanel107.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel107.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel107.Name = "uiPanel107";
            this.uiPanel107.Opacity = ((byte)(180));
            this.uiPanel107.Radius = 10;
            this.uiPanel107.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel107.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel107.Size = new System.Drawing.Size(135, 30);
            this.uiPanel107.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel107.TabIndex = 11;
            this.uiPanel107.Text = null;
            this.uiPanel107.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChannelIndexStrCAN
            // 
            this.lb_ChannelIndexStrCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ChannelIndexStrCAN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_ChannelIndexStrCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_ChannelIndexStrCAN.Location = new System.Drawing.Point(0, 0);
            this.lb_ChannelIndexStrCAN.Name = "lb_ChannelIndexStrCAN";
            this.lb_ChannelIndexStrCAN.Size = new System.Drawing.Size(135, 30);
            this.lb_ChannelIndexStrCAN.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ChannelIndexStrCAN.TabIndex = 1;
            this.lb_ChannelIndexStrCAN.Text = "0";
            this.lb_ChannelIndexStrCAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel108
            // 
            this.uiPanel108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel108.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel108.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel108.Location = new System.Drawing.Point(135, 0);
            this.uiPanel108.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel108.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel108.Name = "uiPanel108";
            this.uiPanel108.Opacity = ((byte)(180));
            this.uiPanel108.Radius = 10;
            this.uiPanel108.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel108.Size = new System.Drawing.Size(10, 30);
            this.uiPanel108.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel108.TabIndex = 10;
            this.uiPanel108.Text = null;
            this.uiPanel108.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel109
            // 
            this.uiPanel109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.Controls.Add(this.lb_ChannelIndexCAN);
            this.uiPanel109.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel109.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel109.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel109.Location = new System.Drawing.Point(0, 0);
            this.uiPanel109.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel109.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel109.Name = "uiPanel109";
            this.uiPanel109.Opacity = ((byte)(180));
            this.uiPanel109.Radius = 10;
            this.uiPanel109.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel109.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel109.Size = new System.Drawing.Size(135, 30);
            this.uiPanel109.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel109.TabIndex = 9;
            this.uiPanel109.Text = null;
            this.uiPanel109.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChannelIndexCAN
            // 
            this.lb_ChannelIndexCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ChannelIndexCAN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChannelIndexCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ChannelIndexCAN.Location = new System.Drawing.Point(0, 0);
            this.lb_ChannelIndexCAN.Name = "lb_ChannelIndexCAN";
            this.lb_ChannelIndexCAN.Size = new System.Drawing.Size(135, 30);
            this.lb_ChannelIndexCAN.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ChannelIndexCAN.TabIndex = 0;
            this.lb_ChannelIndexCAN.Text = "通道号：";
            this.lb_ChannelIndexCAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel110
            // 
            this.uiPanel110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.Controls.Add(this.uiPanel111);
            this.uiPanel110.Controls.Add(this.uiPanel112);
            this.uiPanel110.Controls.Add(this.uiPanel113);
            this.uiPanel110.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel110.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel110.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel110.Location = new System.Drawing.Point(0, 0);
            this.uiPanel110.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel110.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel110.Name = "uiPanel110";
            this.uiPanel110.Opacity = ((byte)(180));
            this.uiPanel110.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel110.Radius = 10;
            this.uiPanel110.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel110.Size = new System.Drawing.Size(280, 32);
            this.uiPanel110.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel110.TabIndex = 18;
            this.uiPanel110.Text = null;
            this.uiPanel110.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel111
            // 
            this.uiPanel111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.Controls.Add(this.lb_DeviceIndexStrCAN);
            this.uiPanel111.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel111.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel111.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel111.Location = new System.Drawing.Point(145, 0);
            this.uiPanel111.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel111.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel111.Name = "uiPanel111";
            this.uiPanel111.Opacity = ((byte)(180));
            this.uiPanel111.Radius = 10;
            this.uiPanel111.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel111.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel111.Size = new System.Drawing.Size(135, 30);
            this.uiPanel111.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel111.TabIndex = 11;
            this.uiPanel111.Text = null;
            this.uiPanel111.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceIndexStrCAN
            // 
            this.lb_DeviceIndexStrCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceIndexStrCAN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_DeviceIndexStrCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_DeviceIndexStrCAN.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceIndexStrCAN.Name = "lb_DeviceIndexStrCAN";
            this.lb_DeviceIndexStrCAN.Size = new System.Drawing.Size(135, 30);
            this.lb_DeviceIndexStrCAN.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceIndexStrCAN.TabIndex = 1;
            this.lb_DeviceIndexStrCAN.Text = "0";
            this.lb_DeviceIndexStrCAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel112
            // 
            this.uiPanel112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel112.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel112.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel112.Location = new System.Drawing.Point(135, 0);
            this.uiPanel112.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel112.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel112.Name = "uiPanel112";
            this.uiPanel112.Opacity = ((byte)(180));
            this.uiPanel112.Radius = 10;
            this.uiPanel112.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel112.Size = new System.Drawing.Size(10, 30);
            this.uiPanel112.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel112.TabIndex = 10;
            this.uiPanel112.Text = null;
            this.uiPanel112.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel113
            // 
            this.uiPanel113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.Controls.Add(this.lb_DeviceIndexCAN);
            this.uiPanel113.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel113.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel113.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel113.Location = new System.Drawing.Point(0, 0);
            this.uiPanel113.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel113.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel113.Name = "uiPanel113";
            this.uiPanel113.Opacity = ((byte)(180));
            this.uiPanel113.Radius = 10;
            this.uiPanel113.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel113.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel113.Size = new System.Drawing.Size(135, 30);
            this.uiPanel113.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel113.TabIndex = 9;
            this.uiPanel113.Text = null;
            this.uiPanel113.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceIndexCAN
            // 
            this.lb_DeviceIndexCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceIndexCAN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DeviceIndexCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_DeviceIndexCAN.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceIndexCAN.Name = "lb_DeviceIndexCAN";
            this.lb_DeviceIndexCAN.Size = new System.Drawing.Size(135, 30);
            this.lb_DeviceIndexCAN.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceIndexCAN.TabIndex = 0;
            this.lb_DeviceIndexCAN.Text = "设备索引号：";
            this.lb_DeviceIndexCAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_CANFDParams
            // 
            this.pan_CANFDParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.Controls.Add(this.uiPanel29);
            this.pan_CANFDParams.Controls.Add(this.uiPanel25);
            this.pan_CANFDParams.Controls.Add(this.uiPanel59);
            this.pan_CANFDParams.Controls.Add(this.uiPanel21);
            this.pan_CANFDParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_CANFDParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_CANFDParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_CANFDParams.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_CANFDParams.Location = new System.Drawing.Point(0, 0);
            this.pan_CANFDParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_CANFDParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_CANFDParams.Name = "pan_CANFDParams";
            this.pan_CANFDParams.Opacity = ((byte)(180));
            this.pan_CANFDParams.Radius = 10;
            this.pan_CANFDParams.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pan_CANFDParams.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_CANFDParams.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_CANFDParams.Size = new System.Drawing.Size(280, 100);
            this.pan_CANFDParams.Style = Sunny.UI.UIStyle.Custom;
            this.pan_CANFDParams.TabIndex = 18;
            this.pan_CANFDParams.Text = null;
            this.pan_CANFDParams.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel29
            // 
            this.uiPanel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.Controls.Add(this.uiPanel30);
            this.uiPanel29.Controls.Add(this.uiPanel31);
            this.uiPanel29.Controls.Add(this.uiPanel32);
            this.uiPanel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel29.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel29.Location = new System.Drawing.Point(0, 75);
            this.uiPanel29.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel29.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel29.Name = "uiPanel29";
            this.uiPanel29.Opacity = ((byte)(180));
            this.uiPanel29.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel29.Radius = 10;
            this.uiPanel29.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel29.Size = new System.Drawing.Size(280, 25);
            this.uiPanel29.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel29.TabIndex = 23;
            this.uiPanel29.Text = null;
            this.uiPanel29.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel30
            // 
            this.uiPanel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.Controls.Add(this.lb_DbitBaudStr);
            this.uiPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel30.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel30.Location = new System.Drawing.Point(145, 0);
            this.uiPanel30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel30.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel30.Name = "uiPanel30";
            this.uiPanel30.Opacity = ((byte)(180));
            this.uiPanel30.Radius = 10;
            this.uiPanel30.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel30.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel30.Size = new System.Drawing.Size(135, 23);
            this.uiPanel30.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel30.TabIndex = 11;
            this.uiPanel30.Text = null;
            this.uiPanel30.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DbitBaudStr
            // 
            this.lb_DbitBaudStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DbitBaudStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_DbitBaudStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_DbitBaudStr.Location = new System.Drawing.Point(0, 0);
            this.lb_DbitBaudStr.Name = "lb_DbitBaudStr";
            this.lb_DbitBaudStr.Size = new System.Drawing.Size(135, 23);
            this.lb_DbitBaudStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DbitBaudStr.TabIndex = 1;
            this.lb_DbitBaudStr.Text = "4Mbps 75%";
            this.lb_DbitBaudStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel31
            // 
            this.uiPanel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel31.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel31.Location = new System.Drawing.Point(135, 0);
            this.uiPanel31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel31.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel31.Name = "uiPanel31";
            this.uiPanel31.Opacity = ((byte)(180));
            this.uiPanel31.Radius = 10;
            this.uiPanel31.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel31.Size = new System.Drawing.Size(10, 23);
            this.uiPanel31.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel31.TabIndex = 10;
            this.uiPanel31.Text = null;
            this.uiPanel31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel32
            // 
            this.uiPanel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.Controls.Add(this.lb_DbitBaud);
            this.uiPanel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel32.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel32.Location = new System.Drawing.Point(0, 0);
            this.uiPanel32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel32.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel32.Name = "uiPanel32";
            this.uiPanel32.Opacity = ((byte)(180));
            this.uiPanel32.Radius = 10;
            this.uiPanel32.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel32.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel32.Size = new System.Drawing.Size(135, 23);
            this.uiPanel32.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel32.TabIndex = 9;
            this.uiPanel32.Text = null;
            this.uiPanel32.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DbitBaud
            // 
            this.lb_DbitBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DbitBaud.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DbitBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_DbitBaud.Location = new System.Drawing.Point(0, 0);
            this.lb_DbitBaud.Name = "lb_DbitBaud";
            this.lb_DbitBaud.Size = new System.Drawing.Size(135, 23);
            this.lb_DbitBaud.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DbitBaud.TabIndex = 0;
            this.lb_DbitBaud.Text = "数据域波特率：";
            this.lb_DbitBaud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel25
            // 
            this.uiPanel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.Controls.Add(this.uiPanel26);
            this.uiPanel25.Controls.Add(this.uiPanel27);
            this.uiPanel25.Controls.Add(this.uiPanel28);
            this.uiPanel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel25.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel25.Location = new System.Drawing.Point(0, 50);
            this.uiPanel25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel25.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel25.Name = "uiPanel25";
            this.uiPanel25.Opacity = ((byte)(180));
            this.uiPanel25.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel25.Radius = 10;
            this.uiPanel25.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel25.Size = new System.Drawing.Size(280, 25);
            this.uiPanel25.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel25.TabIndex = 22;
            this.uiPanel25.Text = null;
            this.uiPanel25.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel26
            // 
            this.uiPanel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.Controls.Add(this.lb_AbitBaudStr);
            this.uiPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel26.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel26.Location = new System.Drawing.Point(145, 0);
            this.uiPanel26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel26.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel26.Name = "uiPanel26";
            this.uiPanel26.Opacity = ((byte)(180));
            this.uiPanel26.Radius = 10;
            this.uiPanel26.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel26.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel26.Size = new System.Drawing.Size(135, 23);
            this.uiPanel26.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel26.TabIndex = 11;
            this.uiPanel26.Text = null;
            this.uiPanel26.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_AbitBaudStr
            // 
            this.lb_AbitBaudStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_AbitBaudStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_AbitBaudStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_AbitBaudStr.Location = new System.Drawing.Point(0, 0);
            this.lb_AbitBaudStr.Name = "lb_AbitBaudStr";
            this.lb_AbitBaudStr.Size = new System.Drawing.Size(135, 23);
            this.lb_AbitBaudStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_AbitBaudStr.TabIndex = 1;
            this.lb_AbitBaudStr.Text = "1Mbps 80%";
            this.lb_AbitBaudStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel27
            // 
            this.uiPanel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel27.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel27.Location = new System.Drawing.Point(135, 0);
            this.uiPanel27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel27.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel27.Name = "uiPanel27";
            this.uiPanel27.Opacity = ((byte)(180));
            this.uiPanel27.Radius = 10;
            this.uiPanel27.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel27.Size = new System.Drawing.Size(10, 23);
            this.uiPanel27.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel27.TabIndex = 10;
            this.uiPanel27.Text = null;
            this.uiPanel27.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel28
            // 
            this.uiPanel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.Controls.Add(this.lb_AbitBaud);
            this.uiPanel28.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel28.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel28.Location = new System.Drawing.Point(0, 0);
            this.uiPanel28.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel28.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel28.Name = "uiPanel28";
            this.uiPanel28.Opacity = ((byte)(180));
            this.uiPanel28.Radius = 10;
            this.uiPanel28.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel28.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel28.Size = new System.Drawing.Size(135, 23);
            this.uiPanel28.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel28.TabIndex = 9;
            this.uiPanel28.Text = null;
            this.uiPanel28.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_AbitBaud
            // 
            this.lb_AbitBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_AbitBaud.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AbitBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_AbitBaud.Location = new System.Drawing.Point(0, 0);
            this.lb_AbitBaud.Name = "lb_AbitBaud";
            this.lb_AbitBaud.Size = new System.Drawing.Size(135, 23);
            this.lb_AbitBaud.Style = Sunny.UI.UIStyle.Custom;
            this.lb_AbitBaud.TabIndex = 0;
            this.lb_AbitBaud.Text = "仲裁域波特率：";
            this.lb_AbitBaud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel59
            // 
            this.uiPanel59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.Controls.Add(this.uiPanel60);
            this.uiPanel59.Controls.Add(this.uiPanel61);
            this.uiPanel59.Controls.Add(this.uiPanel62);
            this.uiPanel59.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel59.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel59.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel59.Location = new System.Drawing.Point(0, 25);
            this.uiPanel59.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel59.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel59.Name = "uiPanel59";
            this.uiPanel59.Opacity = ((byte)(180));
            this.uiPanel59.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel59.Radius = 10;
            this.uiPanel59.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel59.Size = new System.Drawing.Size(280, 25);
            this.uiPanel59.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel59.TabIndex = 21;
            this.uiPanel59.Text = null;
            this.uiPanel59.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel60
            // 
            this.uiPanel60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.Controls.Add(this.lb_ChannelIndexStr);
            this.uiPanel60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel60.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel60.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel60.Location = new System.Drawing.Point(145, 0);
            this.uiPanel60.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel60.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel60.Name = "uiPanel60";
            this.uiPanel60.Opacity = ((byte)(180));
            this.uiPanel60.Radius = 10;
            this.uiPanel60.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel60.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel60.Size = new System.Drawing.Size(135, 23);
            this.uiPanel60.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel60.TabIndex = 11;
            this.uiPanel60.Text = null;
            this.uiPanel60.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChannelIndexStr
            // 
            this.lb_ChannelIndexStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ChannelIndexStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_ChannelIndexStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_ChannelIndexStr.Location = new System.Drawing.Point(0, 0);
            this.lb_ChannelIndexStr.Name = "lb_ChannelIndexStr";
            this.lb_ChannelIndexStr.Size = new System.Drawing.Size(135, 23);
            this.lb_ChannelIndexStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ChannelIndexStr.TabIndex = 1;
            this.lb_ChannelIndexStr.Text = "0";
            this.lb_ChannelIndexStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel61
            // 
            this.uiPanel61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel61.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel61.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel61.Location = new System.Drawing.Point(135, 0);
            this.uiPanel61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel61.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel61.Name = "uiPanel61";
            this.uiPanel61.Opacity = ((byte)(180));
            this.uiPanel61.Radius = 10;
            this.uiPanel61.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel61.Size = new System.Drawing.Size(10, 23);
            this.uiPanel61.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel61.TabIndex = 10;
            this.uiPanel61.Text = null;
            this.uiPanel61.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel62
            // 
            this.uiPanel62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.Controls.Add(this.lb_ChannelIndex);
            this.uiPanel62.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel62.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel62.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel62.Location = new System.Drawing.Point(0, 0);
            this.uiPanel62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel62.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel62.Name = "uiPanel62";
            this.uiPanel62.Opacity = ((byte)(180));
            this.uiPanel62.Radius = 10;
            this.uiPanel62.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel62.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel62.Size = new System.Drawing.Size(135, 23);
            this.uiPanel62.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel62.TabIndex = 9;
            this.uiPanel62.Text = null;
            this.uiPanel62.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ChannelIndex
            // 
            this.lb_ChannelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ChannelIndex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChannelIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ChannelIndex.Location = new System.Drawing.Point(0, 0);
            this.lb_ChannelIndex.Name = "lb_ChannelIndex";
            this.lb_ChannelIndex.Size = new System.Drawing.Size(135, 23);
            this.lb_ChannelIndex.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ChannelIndex.TabIndex = 0;
            this.lb_ChannelIndex.Text = "通道号：";
            this.lb_ChannelIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel21
            // 
            this.uiPanel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.Controls.Add(this.uiPanel22);
            this.uiPanel21.Controls.Add(this.uiPanel23);
            this.uiPanel21.Controls.Add(this.uiPanel24);
            this.uiPanel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel21.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel21.Location = new System.Drawing.Point(0, 0);
            this.uiPanel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel21.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel21.Name = "uiPanel21";
            this.uiPanel21.Opacity = ((byte)(180));
            this.uiPanel21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel21.Radius = 10;
            this.uiPanel21.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel21.Size = new System.Drawing.Size(280, 25);
            this.uiPanel21.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel21.TabIndex = 18;
            this.uiPanel21.Text = null;
            this.uiPanel21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel22
            // 
            this.uiPanel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.Controls.Add(this.lb_DeviceIndexStr);
            this.uiPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel22.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel22.Location = new System.Drawing.Point(145, 0);
            this.uiPanel22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel22.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel22.Name = "uiPanel22";
            this.uiPanel22.Opacity = ((byte)(180));
            this.uiPanel22.Radius = 10;
            this.uiPanel22.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel22.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel22.Size = new System.Drawing.Size(135, 23);
            this.uiPanel22.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel22.TabIndex = 11;
            this.uiPanel22.Text = null;
            this.uiPanel22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceIndexStr
            // 
            this.lb_DeviceIndexStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceIndexStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_DeviceIndexStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_DeviceIndexStr.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceIndexStr.Name = "lb_DeviceIndexStr";
            this.lb_DeviceIndexStr.Size = new System.Drawing.Size(135, 23);
            this.lb_DeviceIndexStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceIndexStr.TabIndex = 1;
            this.lb_DeviceIndexStr.Text = "0";
            this.lb_DeviceIndexStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel23
            // 
            this.uiPanel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel23.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel23.Location = new System.Drawing.Point(135, 0);
            this.uiPanel23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel23.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel23.Name = "uiPanel23";
            this.uiPanel23.Opacity = ((byte)(180));
            this.uiPanel23.Radius = 10;
            this.uiPanel23.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel23.Size = new System.Drawing.Size(10, 23);
            this.uiPanel23.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel23.TabIndex = 10;
            this.uiPanel23.Text = null;
            this.uiPanel23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel24
            // 
            this.uiPanel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.Controls.Add(this.lb_DeviceIndex);
            this.uiPanel24.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel24.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel24.Location = new System.Drawing.Point(0, 0);
            this.uiPanel24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel24.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel24.Name = "uiPanel24";
            this.uiPanel24.Opacity = ((byte)(180));
            this.uiPanel24.Radius = 10;
            this.uiPanel24.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel24.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel24.Size = new System.Drawing.Size(135, 23);
            this.uiPanel24.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel24.TabIndex = 9;
            this.uiPanel24.Text = null;
            this.uiPanel24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceIndex
            // 
            this.lb_DeviceIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceIndex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DeviceIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_DeviceIndex.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceIndex.Name = "lb_DeviceIndex";
            this.lb_DeviceIndex.Size = new System.Drawing.Size(135, 23);
            this.lb_DeviceIndex.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceIndex.TabIndex = 0;
            this.lb_DeviceIndex.Text = "设备索引号：";
            this.lb_DeviceIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_COMParams
            // 
            this.pan_COMParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.Controls.Add(this.uiPanel79);
            this.pan_COMParams.Controls.Add(this.uiPanel88);
            this.pan_COMParams.Controls.Add(this.uiPanel89);
            this.pan_COMParams.Controls.Add(this.uiPanel93);
            this.pan_COMParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_COMParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_COMParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_COMParams.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_COMParams.Location = new System.Drawing.Point(0, 0);
            this.pan_COMParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_COMParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_COMParams.Name = "pan_COMParams";
            this.pan_COMParams.Opacity = ((byte)(180));
            this.pan_COMParams.Radius = 10;
            this.pan_COMParams.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_COMParams.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_COMParams.Size = new System.Drawing.Size(280, 100);
            this.pan_COMParams.Style = Sunny.UI.UIStyle.Custom;
            this.pan_COMParams.TabIndex = 20;
            this.pan_COMParams.Text = null;
            this.pan_COMParams.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel79
            // 
            this.uiPanel79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.Controls.Add(this.uiPanel80);
            this.uiPanel79.Controls.Add(this.uiPanel81);
            this.uiPanel79.Controls.Add(this.uiPanel87);
            this.uiPanel79.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel79.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel79.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel79.Location = new System.Drawing.Point(0, 65);
            this.uiPanel79.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel79.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel79.Name = "uiPanel79";
            this.uiPanel79.Opacity = ((byte)(180));
            this.uiPanel79.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel79.Radius = 10;
            this.uiPanel79.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel79.Size = new System.Drawing.Size(280, 25);
            this.uiPanel79.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel79.TabIndex = 23;
            this.uiPanel79.Text = null;
            this.uiPanel79.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel80
            // 
            this.uiPanel80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.Controls.Add(this.lb_COMBaudStr);
            this.uiPanel80.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel80.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel80.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel80.Location = new System.Drawing.Point(145, 0);
            this.uiPanel80.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel80.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel80.Name = "uiPanel80";
            this.uiPanel80.Opacity = ((byte)(180));
            this.uiPanel80.Radius = 10;
            this.uiPanel80.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel80.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel80.Size = new System.Drawing.Size(135, 23);
            this.uiPanel80.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel80.TabIndex = 11;
            this.uiPanel80.Text = null;
            this.uiPanel80.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_COMBaudStr
            // 
            this.lb_COMBaudStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_COMBaudStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_COMBaudStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_COMBaudStr.Location = new System.Drawing.Point(0, 0);
            this.lb_COMBaudStr.Name = "lb_COMBaudStr";
            this.lb_COMBaudStr.Size = new System.Drawing.Size(135, 23);
            this.lb_COMBaudStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_COMBaudStr.TabIndex = 1;
            this.lb_COMBaudStr.Text = "115200";
            this.lb_COMBaudStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel81
            // 
            this.uiPanel81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel81.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel81.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel81.Location = new System.Drawing.Point(135, 0);
            this.uiPanel81.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel81.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel81.Name = "uiPanel81";
            this.uiPanel81.Opacity = ((byte)(180));
            this.uiPanel81.Radius = 10;
            this.uiPanel81.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel81.Size = new System.Drawing.Size(10, 23);
            this.uiPanel81.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel81.TabIndex = 10;
            this.uiPanel81.Text = null;
            this.uiPanel81.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel87
            // 
            this.uiPanel87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.Controls.Add(this.lb_COMBaud);
            this.uiPanel87.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel87.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel87.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel87.Location = new System.Drawing.Point(0, 0);
            this.uiPanel87.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel87.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel87.Name = "uiPanel87";
            this.uiPanel87.Opacity = ((byte)(180));
            this.uiPanel87.Radius = 10;
            this.uiPanel87.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel87.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel87.Size = new System.Drawing.Size(135, 23);
            this.uiPanel87.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel87.TabIndex = 9;
            this.uiPanel87.Text = null;
            this.uiPanel87.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_COMBaud
            // 
            this.lb_COMBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_COMBaud.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_COMBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_COMBaud.Location = new System.Drawing.Point(0, 0);
            this.lb_COMBaud.Name = "lb_COMBaud";
            this.lb_COMBaud.Size = new System.Drawing.Size(135, 23);
            this.lb_COMBaud.Style = Sunny.UI.UIStyle.Custom;
            this.lb_COMBaud.TabIndex = 0;
            this.lb_COMBaud.Text = "波特率：";
            this.lb_COMBaud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel88
            // 
            this.uiPanel88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel88.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel88.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel88.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel88.Location = new System.Drawing.Point(0, 45);
            this.uiPanel88.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel88.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel88.Name = "uiPanel88";
            this.uiPanel88.Opacity = ((byte)(180));
            this.uiPanel88.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel88.Radius = 10;
            this.uiPanel88.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel88.Size = new System.Drawing.Size(280, 20);
            this.uiPanel88.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel88.TabIndex = 22;
            this.uiPanel88.Text = null;
            this.uiPanel88.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel89
            // 
            this.uiPanel89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.Controls.Add(this.uiPanel90);
            this.uiPanel89.Controls.Add(this.uiPanel91);
            this.uiPanel89.Controls.Add(this.uiPanel92);
            this.uiPanel89.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel89.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel89.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel89.Location = new System.Drawing.Point(0, 20);
            this.uiPanel89.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel89.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel89.Name = "uiPanel89";
            this.uiPanel89.Opacity = ((byte)(180));
            this.uiPanel89.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel89.Radius = 10;
            this.uiPanel89.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel89.Size = new System.Drawing.Size(280, 25);
            this.uiPanel89.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel89.TabIndex = 21;
            this.uiPanel89.Text = null;
            this.uiPanel89.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel90
            // 
            this.uiPanel90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.Controls.Add(this.lb_COMNoStr);
            this.uiPanel90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel90.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel90.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel90.Location = new System.Drawing.Point(145, 0);
            this.uiPanel90.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel90.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel90.Name = "uiPanel90";
            this.uiPanel90.Opacity = ((byte)(180));
            this.uiPanel90.Radius = 10;
            this.uiPanel90.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel90.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel90.Size = new System.Drawing.Size(135, 23);
            this.uiPanel90.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel90.TabIndex = 11;
            this.uiPanel90.Text = null;
            this.uiPanel90.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_COMNoStr
            // 
            this.lb_COMNoStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_COMNoStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_COMNoStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_COMNoStr.Location = new System.Drawing.Point(0, 0);
            this.lb_COMNoStr.Name = "lb_COMNoStr";
            this.lb_COMNoStr.Size = new System.Drawing.Size(135, 23);
            this.lb_COMNoStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_COMNoStr.TabIndex = 1;
            this.lb_COMNoStr.Text = "COM1";
            this.lb_COMNoStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel91
            // 
            this.uiPanel91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel91.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel91.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel91.Location = new System.Drawing.Point(135, 0);
            this.uiPanel91.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel91.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel91.Name = "uiPanel91";
            this.uiPanel91.Opacity = ((byte)(180));
            this.uiPanel91.Radius = 10;
            this.uiPanel91.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel91.Size = new System.Drawing.Size(10, 23);
            this.uiPanel91.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel91.TabIndex = 10;
            this.uiPanel91.Text = null;
            this.uiPanel91.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel92
            // 
            this.uiPanel92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.Controls.Add(this.lb_COMNo);
            this.uiPanel92.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel92.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel92.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel92.Location = new System.Drawing.Point(0, 0);
            this.uiPanel92.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel92.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel92.Name = "uiPanel92";
            this.uiPanel92.Opacity = ((byte)(180));
            this.uiPanel92.Radius = 10;
            this.uiPanel92.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel92.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel92.Size = new System.Drawing.Size(135, 23);
            this.uiPanel92.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel92.TabIndex = 9;
            this.uiPanel92.Text = null;
            this.uiPanel92.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_COMNo
            // 
            this.lb_COMNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_COMNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_COMNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_COMNo.Location = new System.Drawing.Point(0, 0);
            this.lb_COMNo.Name = "lb_COMNo";
            this.lb_COMNo.Size = new System.Drawing.Size(135, 23);
            this.lb_COMNo.Style = Sunny.UI.UIStyle.Custom;
            this.lb_COMNo.TabIndex = 0;
            this.lb_COMNo.Text = "串口号：";
            this.lb_COMNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel93
            // 
            this.uiPanel93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel93.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel93.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel93.Location = new System.Drawing.Point(0, 0);
            this.uiPanel93.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel93.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel93.Name = "uiPanel93";
            this.uiPanel93.Opacity = ((byte)(180));
            this.uiPanel93.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel93.Radius = 10;
            this.uiPanel93.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel93.Size = new System.Drawing.Size(280, 20);
            this.uiPanel93.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel93.TabIndex = 18;
            this.uiPanel93.Text = null;
            this.uiPanel93.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_TCPParams
            // 
            this.pan_TCPParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.Controls.Add(this.uiPanel74);
            this.pan_TCPParams.Controls.Add(this.uiPanel78);
            this.pan_TCPParams.Controls.Add(this.uiPanel82);
            this.pan_TCPParams.Controls.Add(this.uiPanel86);
            this.pan_TCPParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_TCPParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_TCPParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_TCPParams.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_TCPParams.Location = new System.Drawing.Point(0, 0);
            this.pan_TCPParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_TCPParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_TCPParams.Name = "pan_TCPParams";
            this.pan_TCPParams.Opacity = ((byte)(180));
            this.pan_TCPParams.Radius = 10;
            this.pan_TCPParams.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TCPParams.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_TCPParams.Size = new System.Drawing.Size(280, 100);
            this.pan_TCPParams.Style = Sunny.UI.UIStyle.Custom;
            this.pan_TCPParams.TabIndex = 19;
            this.pan_TCPParams.Text = null;
            this.pan_TCPParams.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel74
            // 
            this.uiPanel74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.Controls.Add(this.uiPanel75);
            this.uiPanel74.Controls.Add(this.uiPanel76);
            this.uiPanel74.Controls.Add(this.uiPanel77);
            this.uiPanel74.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel74.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel74.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel74.Location = new System.Drawing.Point(0, 65);
            this.uiPanel74.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel74.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel74.Name = "uiPanel74";
            this.uiPanel74.Opacity = ((byte)(180));
            this.uiPanel74.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel74.Radius = 10;
            this.uiPanel74.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel74.Size = new System.Drawing.Size(280, 25);
            this.uiPanel74.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel74.TabIndex = 23;
            this.uiPanel74.Text = null;
            this.uiPanel74.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel75
            // 
            this.uiPanel75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.Controls.Add(this.lb_DevicePort);
            this.uiPanel75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel75.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel75.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel75.Location = new System.Drawing.Point(145, 0);
            this.uiPanel75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel75.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel75.Name = "uiPanel75";
            this.uiPanel75.Opacity = ((byte)(180));
            this.uiPanel75.Radius = 10;
            this.uiPanel75.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel75.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel75.Size = new System.Drawing.Size(135, 23);
            this.uiPanel75.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel75.TabIndex = 11;
            this.uiPanel75.Text = null;
            this.uiPanel75.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DevicePort
            // 
            this.lb_DevicePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DevicePort.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_DevicePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_DevicePort.Location = new System.Drawing.Point(0, 0);
            this.lb_DevicePort.Name = "lb_DevicePort";
            this.lb_DevicePort.Size = new System.Drawing.Size(135, 23);
            this.lb_DevicePort.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DevicePort.TabIndex = 1;
            this.lb_DevicePort.Text = "50000";
            this.lb_DevicePort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel76
            // 
            this.uiPanel76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel76.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel76.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel76.Location = new System.Drawing.Point(135, 0);
            this.uiPanel76.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel76.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel76.Name = "uiPanel76";
            this.uiPanel76.Opacity = ((byte)(180));
            this.uiPanel76.Radius = 10;
            this.uiPanel76.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel76.Size = new System.Drawing.Size(10, 23);
            this.uiPanel76.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel76.TabIndex = 10;
            this.uiPanel76.Text = null;
            this.uiPanel76.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel77
            // 
            this.uiPanel77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.Controls.Add(this.lb_DevicePortText);
            this.uiPanel77.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel77.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel77.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel77.Location = new System.Drawing.Point(0, 0);
            this.uiPanel77.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel77.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel77.Name = "uiPanel77";
            this.uiPanel77.Opacity = ((byte)(180));
            this.uiPanel77.Radius = 10;
            this.uiPanel77.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel77.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel77.Size = new System.Drawing.Size(135, 23);
            this.uiPanel77.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel77.TabIndex = 9;
            this.uiPanel77.Text = null;
            this.uiPanel77.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DevicePortText
            // 
            this.lb_DevicePortText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DevicePortText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DevicePortText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_DevicePortText.Location = new System.Drawing.Point(0, 0);
            this.lb_DevicePortText.Name = "lb_DevicePortText";
            this.lb_DevicePortText.Size = new System.Drawing.Size(135, 23);
            this.lb_DevicePortText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DevicePortText.TabIndex = 0;
            this.lb_DevicePortText.Text = "设备端口：";
            this.lb_DevicePortText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel78
            // 
            this.uiPanel78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel78.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel78.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel78.Location = new System.Drawing.Point(0, 45);
            this.uiPanel78.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel78.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel78.Name = "uiPanel78";
            this.uiPanel78.Opacity = ((byte)(180));
            this.uiPanel78.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel78.Radius = 10;
            this.uiPanel78.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel78.Size = new System.Drawing.Size(280, 20);
            this.uiPanel78.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel78.TabIndex = 22;
            this.uiPanel78.Text = null;
            this.uiPanel78.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel82
            // 
            this.uiPanel82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.Controls.Add(this.uiPanel83);
            this.uiPanel82.Controls.Add(this.uiPanel84);
            this.uiPanel82.Controls.Add(this.uiPanel85);
            this.uiPanel82.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel82.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel82.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel82.Location = new System.Drawing.Point(0, 20);
            this.uiPanel82.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel82.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel82.Name = "uiPanel82";
            this.uiPanel82.Opacity = ((byte)(180));
            this.uiPanel82.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel82.Radius = 10;
            this.uiPanel82.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel82.Size = new System.Drawing.Size(280, 25);
            this.uiPanel82.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel82.TabIndex = 21;
            this.uiPanel82.Text = null;
            this.uiPanel82.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel83
            // 
            this.uiPanel83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.Controls.Add(this.lb_DeviceAddress);
            this.uiPanel83.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel83.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel83.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel83.Location = new System.Drawing.Point(145, 0);
            this.uiPanel83.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel83.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel83.Name = "uiPanel83";
            this.uiPanel83.Opacity = ((byte)(180));
            this.uiPanel83.Radius = 10;
            this.uiPanel83.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel83.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel83.Size = new System.Drawing.Size(135, 23);
            this.uiPanel83.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel83.TabIndex = 11;
            this.uiPanel83.Text = null;
            this.uiPanel83.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceAddress
            // 
            this.lb_DeviceAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_DeviceAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_DeviceAddress.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceAddress.Name = "lb_DeviceAddress";
            this.lb_DeviceAddress.Size = new System.Drawing.Size(135, 23);
            this.lb_DeviceAddress.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceAddress.TabIndex = 1;
            this.lb_DeviceAddress.Text = "192.168.10.123";
            this.lb_DeviceAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel84
            // 
            this.uiPanel84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel84.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel84.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel84.Location = new System.Drawing.Point(135, 0);
            this.uiPanel84.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel84.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel84.Name = "uiPanel84";
            this.uiPanel84.Opacity = ((byte)(180));
            this.uiPanel84.Radius = 10;
            this.uiPanel84.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel84.Size = new System.Drawing.Size(10, 23);
            this.uiPanel84.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel84.TabIndex = 10;
            this.uiPanel84.Text = null;
            this.uiPanel84.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel85
            // 
            this.uiPanel85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.Controls.Add(this.lb_DeviceAddressText);
            this.uiPanel85.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel85.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel85.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel85.Location = new System.Drawing.Point(0, 0);
            this.uiPanel85.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel85.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel85.Name = "uiPanel85";
            this.uiPanel85.Opacity = ((byte)(180));
            this.uiPanel85.Radius = 10;
            this.uiPanel85.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel85.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel85.Size = new System.Drawing.Size(135, 23);
            this.uiPanel85.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel85.TabIndex = 9;
            this.uiPanel85.Text = null;
            this.uiPanel85.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceAddressText
            // 
            this.lb_DeviceAddressText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DeviceAddressText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DeviceAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_DeviceAddressText.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceAddressText.Name = "lb_DeviceAddressText";
            this.lb_DeviceAddressText.Size = new System.Drawing.Size(135, 23);
            this.lb_DeviceAddressText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceAddressText.TabIndex = 0;
            this.lb_DeviceAddressText.Text = "设备地址：";
            this.lb_DeviceAddressText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel86
            // 
            this.uiPanel86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel86.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel86.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel86.Location = new System.Drawing.Point(0, 0);
            this.uiPanel86.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel86.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel86.Name = "uiPanel86";
            this.uiPanel86.Opacity = ((byte)(180));
            this.uiPanel86.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel86.Radius = 10;
            this.uiPanel86.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel86.Size = new System.Drawing.Size(280, 20);
            this.uiPanel86.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel86.TabIndex = 18;
            this.uiPanel86.Text = null;
            this.uiPanel86.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel17
            // 
            this.uiPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.Controls.Add(this.uiPanel18);
            this.uiPanel17.Controls.Add(this.uiPanel19);
            this.uiPanel17.Controls.Add(this.uiPanel20);
            this.uiPanel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel17.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel17.Location = new System.Drawing.Point(0, 0);
            this.uiPanel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel17.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel17.Name = "uiPanel17";
            this.uiPanel17.Opacity = ((byte)(180));
            this.uiPanel17.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel17.Radius = 10;
            this.uiPanel17.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiPanel17.Size = new System.Drawing.Size(280, 25);
            this.uiPanel17.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel17.TabIndex = 15;
            this.uiPanel17.Text = null;
            this.uiPanel17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel18
            // 
            this.uiPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Controls.Add(this.lb_RadarTypeStr);
            this.uiPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel18.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel18.Location = new System.Drawing.Point(145, 0);
            this.uiPanel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel18.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel18.Name = "uiPanel18";
            this.uiPanel18.Opacity = ((byte)(180));
            this.uiPanel18.Radius = 10;
            this.uiPanel18.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel18.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel18.Size = new System.Drawing.Size(135, 23);
            this.uiPanel18.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel18.TabIndex = 11;
            this.uiPanel18.Text = null;
            this.uiPanel18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_RadarTypeStr
            // 
            this.lb_RadarTypeStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_RadarTypeStr.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.lb_RadarTypeStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_RadarTypeStr.Location = new System.Drawing.Point(0, 0);
            this.lb_RadarTypeStr.Name = "lb_RadarTypeStr";
            this.lb_RadarTypeStr.Size = new System.Drawing.Size(135, 23);
            this.lb_RadarTypeStr.Style = Sunny.UI.UIStyle.Custom;
            this.lb_RadarTypeStr.TabIndex = 1;
            this.lb_RadarTypeStr.Text = "UCM211";
            this.lb_RadarTypeStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel19
            // 
            this.uiPanel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel19.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel19.Location = new System.Drawing.Point(135, 0);
            this.uiPanel19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel19.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel19.Name = "uiPanel19";
            this.uiPanel19.Opacity = ((byte)(180));
            this.uiPanel19.Radius = 10;
            this.uiPanel19.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel19.Size = new System.Drawing.Size(10, 23);
            this.uiPanel19.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel19.TabIndex = 10;
            this.uiPanel19.Text = null;
            this.uiPanel19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel20
            // 
            this.uiPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.Controls.Add(this.lb_RadarType);
            this.uiPanel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel20.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel20.Location = new System.Drawing.Point(0, 0);
            this.uiPanel20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel20.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel20.Name = "uiPanel20";
            this.uiPanel20.Opacity = ((byte)(180));
            this.uiPanel20.Radius = 10;
            this.uiPanel20.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel20.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel20.Size = new System.Drawing.Size(135, 23);
            this.uiPanel20.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel20.TabIndex = 9;
            this.uiPanel20.Text = null;
            this.uiPanel20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_RadarType
            // 
            this.lb_RadarType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_RadarType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RadarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_RadarType.Location = new System.Drawing.Point(0, 0);
            this.lb_RadarType.Name = "lb_RadarType";
            this.lb_RadarType.Size = new System.Drawing.Size(135, 23);
            this.lb_RadarType.Style = Sunny.UI.UIStyle.Custom;
            this.lb_RadarType.TabIndex = 0;
            this.lb_RadarType.Text = "雷达名称：";
            this.lb_RadarType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel33
            // 
            this.uiPanel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.Controls.Add(this.uiPanel34);
            this.uiPanel33.Controls.Add(this.uiPanel35);
            this.uiPanel33.Controls.Add(this.uiPanel36);
            this.uiPanel33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel33.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel33.Location = new System.Drawing.Point(10, 166);
            this.uiPanel33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel33.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel33.Name = "uiPanel33";
            this.uiPanel33.Opacity = ((byte)(180));
            this.uiPanel33.Radius = 10;
            this.uiPanel33.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel33.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel33.Size = new System.Drawing.Size(280, 35);
            this.uiPanel33.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel33.TabIndex = 14;
            this.uiPanel33.Text = null;
            this.uiPanel33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel34
            // 
            this.uiPanel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.Controls.Add(this.btn_Start);
            this.uiPanel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel34.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel34.Location = new System.Drawing.Point(145, 0);
            this.uiPanel34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel34.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel34.Name = "uiPanel34";
            this.uiPanel34.Opacity = ((byte)(180));
            this.uiPanel34.Radius = 10;
            this.uiPanel34.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel34.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel34.Size = new System.Drawing.Size(135, 35);
            this.uiPanel34.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel34.TabIndex = 11;
            this.uiPanel34.Text = null;
            this.uiPanel34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Start.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Start.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Start.ForePressColor = System.Drawing.Color.Red;
            this.btn_Start.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_Start.Location = new System.Drawing.Point(0, 0);
            this.btn_Start.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Start.RectPressColor = System.Drawing.Color.Red;
            this.btn_Start.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_Start.Size = new System.Drawing.Size(135, 35);
            this.btn_Start.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "启动扫描";
            this.btn_Start.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // uiPanel35
            // 
            this.uiPanel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel35.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel35.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel35.Location = new System.Drawing.Point(135, 0);
            this.uiPanel35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel35.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel35.Name = "uiPanel35";
            this.uiPanel35.Opacity = ((byte)(180));
            this.uiPanel35.Radius = 10;
            this.uiPanel35.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel35.Size = new System.Drawing.Size(10, 35);
            this.uiPanel35.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel35.TabIndex = 10;
            this.uiPanel35.Text = null;
            this.uiPanel35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel36
            // 
            this.uiPanel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.Controls.Add(this.btn_Connect);
            this.uiPanel36.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel36.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel36.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel36.Location = new System.Drawing.Point(0, 0);
            this.uiPanel36.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel36.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel36.Name = "uiPanel36";
            this.uiPanel36.Opacity = ((byte)(180));
            this.uiPanel36.Radius = 10;
            this.uiPanel36.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel36.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel36.Size = new System.Drawing.Size(135, 35);
            this.uiPanel36.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel36.TabIndex = 9;
            this.uiPanel36.Text = null;
            this.uiPanel36.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Connect.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Connect.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Connect.ForePressColor = System.Drawing.Color.Red;
            this.btn_Connect.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_Connect.Location = new System.Drawing.Point(0, 0);
            this.btn_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Connect.RectPressColor = System.Drawing.Color.Red;
            this.btn_Connect.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_Connect.Size = new System.Drawing.Size(135, 35);
            this.btn_Connect.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "连接配置";
            this.btn_Connect.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel3.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel3.Location = new System.Drawing.Point(10, 31);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Opacity = ((byte)(180));
            this.uiPanel3.Radius = 10;
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel3.Size = new System.Drawing.Size(280, 10);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 9;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ConnParamsAreaTitle
            // 
            this.lb_ConnParamsAreaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_ConnParamsAreaTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lb_ConnParamsAreaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_ConnParamsAreaTitle.Location = new System.Drawing.Point(10, 10);
            this.lb_ConnParamsAreaTitle.Name = "lb_ConnParamsAreaTitle";
            this.lb_ConnParamsAreaTitle.Size = new System.Drawing.Size(280, 21);
            this.lb_ConnParamsAreaTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ConnParamsAreaTitle.TabIndex = 1;
            this.lb_ConnParamsAreaTitle.Text = "雷达连接参数";
            this.lb_ConnParamsAreaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Theme,
            this.menuItem_VideoPreview,
            this.ts_TrackData,
            this.ts_RadarFunction,
            this.ts_FilterTrackIds,
            this.ts_ShowInfo});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.ShowImageMargin = false;
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(135, 136);
            this.uiContextMenuStrip1.Style = Sunny.UI.UIStyle.Custom;
            // 
            // ts_Theme
            // 
            this.ts_Theme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_Theme.Name = "ts_Theme";
            this.ts_Theme.Size = new System.Drawing.Size(134, 22);
            this.ts_Theme.Text = "主题";
            // 
            // menuItem_VideoPreview
            // 
            this.menuItem_VideoPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.menuItem_VideoPreview.Name = "menuItem_VideoPreview";
            this.menuItem_VideoPreview.Size = new System.Drawing.Size(134, 22);
            this.menuItem_VideoPreview.Text = "视频预览";
            this.menuItem_VideoPreview.Click += new System.EventHandler(this.menuItem_VideoPreview_Click);
            // 
            // ts_TrackData
            // 
            this.ts_TrackData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_TrackData.Name = "ts_TrackData";
            this.ts_TrackData.Size = new System.Drawing.Size(134, 22);
            this.ts_TrackData.Text = "俯视图(XY平面)";
            this.ts_TrackData.Click += new System.EventHandler(this.ts_TrackData_Click);
            // 
            // ts_RadarFunction
            // 
            this.ts_RadarFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_RadarAlive_SR75,
            this.ts_RadarUpgrade_SR75,
            this.ts_RadarUpgrade_UCM211});
            this.ts_RadarFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_RadarFunction.Name = "ts_RadarFunction";
            this.ts_RadarFunction.Size = new System.Drawing.Size(134, 22);
            this.ts_RadarFunction.Text = "雷达功能";
            // 
            // ts_RadarAlive_SR75
            // 
            this.ts_RadarAlive_SR75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ts_RadarAlive_SR75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_RadarAlive_SR75.Name = "ts_RadarAlive_SR75";
            this.ts_RadarAlive_SR75.Size = new System.Drawing.Size(177, 22);
            this.ts_RadarAlive_SR75.Text = "雷达激活(SR75)";
            this.ts_RadarAlive_SR75.Click += new System.EventHandler(this.btn_RadarAlive_Click);
            // 
            // ts_RadarUpgrade_SR75
            // 
            this.ts_RadarUpgrade_SR75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ts_RadarUpgrade_SR75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_RadarUpgrade_SR75.Name = "ts_RadarUpgrade_SR75";
            this.ts_RadarUpgrade_SR75.Size = new System.Drawing.Size(177, 22);
            this.ts_RadarUpgrade_SR75.Text = "雷达升级(SR75)";
            this.ts_RadarUpgrade_SR75.Click += new System.EventHandler(this.btn_RadarUpgrade_Click);
            // 
            // ts_RadarUpgrade_UCM211
            // 
            this.ts_RadarUpgrade_UCM211.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ts_RadarUpgrade_UCM211.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_RadarUpgrade_UCM211.Name = "ts_RadarUpgrade_UCM211";
            this.ts_RadarUpgrade_UCM211.Size = new System.Drawing.Size(177, 22);
            this.ts_RadarUpgrade_UCM211.Text = "雷达升级(UCM211)";
            this.ts_RadarUpgrade_UCM211.Click += new System.EventHandler(this.ts_RadarUpgrade_UCM211_Click);
            // 
            // ts_FilterTrackIds
            // 
            this.ts_FilterTrackIds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_FilterTrackIds.Name = "ts_FilterTrackIds";
            this.ts_FilterTrackIds.Size = new System.Drawing.Size(134, 22);
            this.ts_FilterTrackIds.Text = "过滤目标";
            this.ts_FilterTrackIds.Click += new System.EventHandler(this.ts_FilterTrackIds_Click);
            // 
            // ts_ShowInfo
            // 
            this.ts_ShowInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_GpsInfoData,
            this.ts_FcInfoData});
            this.ts_ShowInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_ShowInfo.Name = "ts_ShowInfo";
            this.ts_ShowInfo.Size = new System.Drawing.Size(134, 22);
            this.ts_ShowInfo.Text = "信息查看";
            // 
            // ts_GpsInfoData
            // 
            this.ts_GpsInfoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ts_GpsInfoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_GpsInfoData.Name = "ts_GpsInfoData";
            this.ts_GpsInfoData.Size = new System.Drawing.Size(180, 22);
            this.ts_GpsInfoData.Text = "GPS信息";
            this.ts_GpsInfoData.Click += new System.EventHandler(this.ts_GpsInfoData_Click);
            // 
            // ts_FcInfoData
            // 
            this.ts_FcInfoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ts_FcInfoData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ts_FcInfoData.Name = "ts_FcInfoData";
            this.ts_FcInfoData.Size = new System.Drawing.Size(180, 22);
            this.ts_FcInfoData.Text = "飞控信息";
            this.ts_FcInfoData.Click += new System.EventHandler(this.ts_FcInfoData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.pan_Main);
            this.ExtendBox = true;
            this.ExtendMenu = this.uiContextMenuStrip1;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowIcon = false;
            this.ShowRect = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "点云成像上位机";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleFont = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pan_Main.ResumeLayout(false);
            this.pan_Right.ResumeLayout(false);
            this.pan_Left.ResumeLayout(false);
            this.uiPanel56.ResumeLayout(false);
            this.uiPanel57.ResumeLayout(false);
            this.pan_ControlArea.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.uiPanel37.ResumeLayout(false);
            this.uiPanel38.ResumeLayout(false);
            this.uiPanel40.ResumeLayout(false);
            this.uiPanel12.ResumeLayout(false);
            this.uiPanel13.ResumeLayout(false);
            this.uiPanel15.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel16.ResumeLayout(false);
            this.uiPanel97.ResumeLayout(false);
            this.uiPanel99.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.uiPanel11.ResumeLayout(false);
            this.uiPanel43.ResumeLayout(false);
            this.uiPanel44.ResumeLayout(false);
            this.uiPanel46.ResumeLayout(false);
            this.uiPanel51.ResumeLayout(false);
            this.uiPanel52.ResumeLayout(false);
            this.uiPanel54.ResumeLayout(false);
            this.uiPanel73.ResumeLayout(false);
            this.uiPanel94.ResumeLayout(false);
            this.uiPanel96.ResumeLayout(false);
            this.uiPanel68.ResumeLayout(false);
            this.uiPanel69.ResumeLayout(false);
            this.uiPanel71.ResumeLayout(false);
            this.uiPanel47.ResumeLayout(false);
            this.uiPanel48.ResumeLayout(false);
            this.uiPanel50.ResumeLayout(false);
            this.uiPanel64.ResumeLayout(false);
            this.uiPanel65.ResumeLayout(false);
            this.uiPanel67.ResumeLayout(false);
            this.uiPanel63.ResumeLayout(false);
            this.pan_ConnParamsArea.ResumeLayout(false);
            this.pan_Conn.ResumeLayout(false);
            this.pan_Params_CANFD.ResumeLayout(false);
            this.uiPanel72.ResumeLayout(false);
            this.pan_CANParams.ResumeLayout(false);
            this.uiPanel102.ResumeLayout(false);
            this.uiPanel103.ResumeLayout(false);
            this.uiPanel105.ResumeLayout(false);
            this.uiPanel106.ResumeLayout(false);
            this.uiPanel107.ResumeLayout(false);
            this.uiPanel109.ResumeLayout(false);
            this.uiPanel110.ResumeLayout(false);
            this.uiPanel111.ResumeLayout(false);
            this.uiPanel113.ResumeLayout(false);
            this.pan_CANFDParams.ResumeLayout(false);
            this.uiPanel29.ResumeLayout(false);
            this.uiPanel30.ResumeLayout(false);
            this.uiPanel32.ResumeLayout(false);
            this.uiPanel25.ResumeLayout(false);
            this.uiPanel26.ResumeLayout(false);
            this.uiPanel28.ResumeLayout(false);
            this.uiPanel59.ResumeLayout(false);
            this.uiPanel60.ResumeLayout(false);
            this.uiPanel62.ResumeLayout(false);
            this.uiPanel21.ResumeLayout(false);
            this.uiPanel22.ResumeLayout(false);
            this.uiPanel24.ResumeLayout(false);
            this.pan_COMParams.ResumeLayout(false);
            this.uiPanel79.ResumeLayout(false);
            this.uiPanel80.ResumeLayout(false);
            this.uiPanel87.ResumeLayout(false);
            this.uiPanel89.ResumeLayout(false);
            this.uiPanel90.ResumeLayout(false);
            this.uiPanel92.ResumeLayout(false);
            this.pan_TCPParams.ResumeLayout(false);
            this.uiPanel74.ResumeLayout(false);
            this.uiPanel75.ResumeLayout(false);
            this.uiPanel77.ResumeLayout(false);
            this.uiPanel82.ResumeLayout(false);
            this.uiPanel83.ResumeLayout(false);
            this.uiPanel85.ResumeLayout(false);
            this.uiPanel17.ResumeLayout(false);
            this.uiPanel18.ResumeLayout(false);
            this.uiPanel20.ResumeLayout(false);
            this.uiPanel33.ResumeLayout(false);
            this.uiPanel34.ResumeLayout(false);
            this.uiPanel36.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel pan_Main;
        private Sunny.UI.UIPanel pan_Left;
        private Sunny.UI.UIPanel pan_Right;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel pan_ConnParamsArea;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel lb_ConnParamsAreaTitle;
        private Sunny.UI.UIPanel pan_ControlArea;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel12;
        private Sunny.UI.UIPanel uiPanel13;
        private Sunny.UI.UIButton btn_SystemSet;
        private Sunny.UI.UIPanel uiPanel14;
        private Sunny.UI.UIPanel uiPanel15;
        private Sunny.UI.UIButton btn_ResetView;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UILabel lb_ControlAreaTitle;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel37;
        private Sunny.UI.UIPanel uiPanel38;
        private Sunny.UI.UIButton btn_StopReplay;
        private Sunny.UI.UIPanel uiPanel39;
        private Sunny.UI.UIPanel uiPanel40;
        private Sunny.UI.UIButton btn_DataReplay;
        private Sunny.UI.UIPanel uiPanel41;
        private Sunny.UI.UIPanel uiPanel56;
        private Sunny.UI.UIPanel uiPanel57;
        private Sunny.UI.UIPanel uiPanel55;
        private Kitware.VTK.RenderWindowControl renderWindowControl1;
        private UCM_Tools.ExtendControls.TransparentOverlayPanel textOverlayPanel;
        private Sunny.UI.UIPanel pan_Conn;
        private Sunny.UI.UIPanel uiPanel33;
        private Sunny.UI.UIPanel uiPanel34;
        private Sunny.UI.UIButton btn_Start;
        private Sunny.UI.UIPanel uiPanel35;
        private Sunny.UI.UIPanel uiPanel36;
        private Sunny.UI.UIButton btn_Connect;
        private Sunny.UI.UIPanel pan_Params_CANFD;
        private Sunny.UI.UIPanel uiPanel17;
        private Sunny.UI.UIPanel uiPanel18;
        private Sunny.UI.UILabel lb_RadarTypeStr;
        private Sunny.UI.UIPanel uiPanel19;
        private Sunny.UI.UIPanel uiPanel20;
        private Sunny.UI.UILabel lb_RadarType;
        private FolderBrowserDialog folderBrowserDialog1;
        private Sunny.UI.UILabel lb_SystemInfo;
        private Sunny.UI.UIRichTextBox rtb_SystemMessage;
        private Sunny.UI.UIPanel uiPanel58;
        private Sunny.UI.UIPanel uiPanel42;
        private Sunny.UI.UIPanel uiPanel63;
        private Sunny.UI.UILabel lb_RadarInfo;
        private Sunny.UI.UIPanel uiPanel64;
        private Sunny.UI.UIPanel uiPanel65;
        private Sunny.UI.UILabel lb_CumulativeFrames;
        private Sunny.UI.UIPanel uiPanel66;
        private Sunny.UI.UIPanel uiPanel67;
        private Sunny.UI.UILabel lb_CumulativeFramesText;
        private Sunny.UI.UIPanel uiPanel68;
        private Sunny.UI.UIPanel uiPanel69;
        private Sunny.UI.UILabel lb_ShowTarNum;
        private Sunny.UI.UIPanel uiPanel70;
        private Sunny.UI.UIPanel uiPanel71;
        private Sunny.UI.UILabel lb_ShowTarNumText;
        private Sunny.UI.UIPanel uiPanel47;
        private Sunny.UI.UIPanel uiPanel48;
        private Sunny.UI.UILabel lb_TarNum;
        private Sunny.UI.UIPanel uiPanel49;
        private Sunny.UI.UIPanel uiPanel50;
        private Sunny.UI.UILabel lb_TarNumText;
        private Sunny.UI.UIPanel uiPanel72;
        private Sunny.UI.UIPanel pan_CANFDParams;
        private Sunny.UI.UIPanel uiPanel29;
        private Sunny.UI.UIPanel uiPanel30;
        private Sunny.UI.UILabel lb_DbitBaudStr;
        private Sunny.UI.UIPanel uiPanel31;
        private Sunny.UI.UIPanel uiPanel32;
        private Sunny.UI.UILabel lb_DbitBaud;
        private Sunny.UI.UIPanel uiPanel25;
        private Sunny.UI.UIPanel uiPanel59;
        private Sunny.UI.UIPanel uiPanel60;
        private Sunny.UI.UILabel lb_ChannelIndexStr;
        private Sunny.UI.UIPanel uiPanel61;
        private Sunny.UI.UIPanel uiPanel62;
        private Sunny.UI.UILabel lb_ChannelIndex;
        private Sunny.UI.UIPanel uiPanel21;
        private Sunny.UI.UIPanel uiPanel22;
        private Sunny.UI.UIPanel uiPanel23;
        private Sunny.UI.UIPanel uiPanel24;
        private Sunny.UI.UILabel lb_DeviceIndex;
        private Sunny.UI.UIPanel pan_TCPParams;
        private Sunny.UI.UIPanel uiPanel78;
        private Sunny.UI.UIPanel uiPanel86;
        private Sunny.UI.UIPanel uiPanel74;
        private Sunny.UI.UIPanel uiPanel75;
        private Sunny.UI.UILabel lb_DevicePort;
        private Sunny.UI.UIPanel uiPanel76;
        private Sunny.UI.UIPanel uiPanel77;
        private Sunny.UI.UILabel lb_DevicePortText;
        private Sunny.UI.UIPanel uiPanel82;
        private Sunny.UI.UIPanel uiPanel83;
        private Sunny.UI.UILabel lb_DeviceAddress;
        private Sunny.UI.UIPanel uiPanel84;
        private Sunny.UI.UIPanel uiPanel85;
        private Sunny.UI.UILabel lb_DeviceAddressText;
        private Sunny.UI.UIPanel uiPanel26;
        private Sunny.UI.UILabel lb_AbitBaudStr;
        private Sunny.UI.UIPanel uiPanel27;
        private Sunny.UI.UIPanel uiPanel28;
        private Sunny.UI.UILabel lb_AbitBaud;
        private Sunny.UI.UILabel lb_DeviceIndexStr;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private ToolStripMenuItem menuItem_VideoPreview;
        private UIPanel pan_COMParams;
        private UIPanel uiPanel79;
        private UIPanel uiPanel80;
        private UILabel lb_COMBaudStr;
        private UIPanel uiPanel81;
        private UIPanel uiPanel87;
        private UILabel lb_COMBaud;
        private UIPanel uiPanel88;
        private UIPanel uiPanel89;
        private UIPanel uiPanel90;
        private UILabel lb_COMNoStr;
        private UIPanel uiPanel91;
        private UIPanel uiPanel92;
        private UILabel lb_COMNo;
        private UIPanel uiPanel93;
        private UIPanel uiPanel43;
        private UIPanel uiPanel44;
        private UILabel lb_Version;
        private UIPanel uiPanel45;
        private UIPanel uiPanel46;
        private UILabel lb_VersionText;
        private UIPanel uiPanel51;
        private UIPanel uiPanel52;
        private UILabel lb_FrameNum;
        private UIPanel uiPanel53;
        private UIPanel uiPanel54;
        private UILabel lb_FrameNumText;
        private UIPanel uiPanel73;
        private UIPanel uiPanel94;
        private UILabel lb_TrackNum;
        private UIPanel uiPanel95;
        private UIPanel uiPanel96;
        private UILabel lb_TrackNumText;
        private ToolStripMenuItem ts_Theme;
        private ToolStripMenuItem ts_TrackData;
        private UIPanel pan_CANParams;
        private UIPanel uiPanel102;
        private UIPanel uiPanel103;
        private UILabel lb_CANBaudStr;
        private UIPanel uiPanel104;
        private UIPanel uiPanel105;
        private UILabel lb_CANBaud;
        private UIPanel uiPanel106;
        private UIPanel uiPanel107;
        private UILabel lb_ChannelIndexStrCAN;
        private UIPanel uiPanel108;
        private UIPanel uiPanel109;
        private UILabel lb_ChannelIndexCAN;
        private UIPanel uiPanel110;
        private UIPanel uiPanel111;
        private UILabel lb_DeviceIndexStrCAN;
        private UIPanel uiPanel112;
        private UIPanel uiPanel113;
        private UILabel lb_DeviceIndexCAN;
        private ToolStripMenuItem ts_RadarFunction;
        private ToolStripMenuItem ts_RadarUpgrade_SR75;
        private ToolStripMenuItem ts_RadarUpgrade_UCM211;
        private ToolStripMenuItem ts_RadarAlive_SR75;
        private UIPanel uiPanel7;
        private UIPanel uiPanel9;
        private UILabel lb_Gps;
        private UIPanel uiPanel10;
        private UIPanel uiPanel11;
        private UILabel lb_GpsText;
        private ToolStripMenuItem ts_FilterTrackIds;
        private UIPanel uiPanel16;
        private UIPanel uiPanel97;
        private UILabel lb_Fc;
        private UIPanel uiPanel98;
        private UIPanel uiPanel99;
        private UILabel lb_FcText;
        private ToolStripMenuItem ts_ShowInfo;
        private ToolStripMenuItem ts_GpsInfoData;
        private ToolStripMenuItem ts_FcInfoData;
    }
}
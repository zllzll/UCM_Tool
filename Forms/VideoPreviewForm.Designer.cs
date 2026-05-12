using UCM_Tools.ExtendControls;

namespace UCM_Tools.Forms
{
    partial class VideoPreviewForm
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
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.gb_ControlBox = new Sunny.UI.UIGroupBox();
            this.uiPanel18 = new Sunny.UI.UIPanel();
            this.rtb_DeviceMessage = new Sunny.UI.UIRichTextBox();
            this.uiPanel15 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel17 = new Sunny.UI.UIPanel();
            this.lb_DeviceInfo = new Sunny.UI.UILabel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel16 = new Sunny.UI.UIPanel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiPanel11 = new Sunny.UI.UIPanel();
            this.btn_StopPreview = new Sunny.UI.UIButton();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.btn_StartPreview = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.cmb_Devices = new Sunny.UI.UIComboBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.lb_USBDeviceNum = new Sunny.UI.UILabel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.lb_DevicesList = new Sunny.UI.UILabel();
            this.pan_Video = new Sunny.UI.UIPanel();
            this.lb_Fps = new UCM_Tools.ExtendControls.TransparentLabel();
            this.lb_State = new UCM_Tools.ExtendControls.TransparentLabel();
            this.pan_RTSP = new Sunny.UI.UIPanel();
            this.tb_RtspAddress = new Sunny.UI.UITextBox();
            this.contextMenuStripVideo = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.led_State = new Sunny.UI.UILedBulb();
            this.pan_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.gb_ControlBox.SuspendLayout();
            this.uiPanel18.SuspendLayout();
            this.uiPanel15.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            this.uiPanel11.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.pan_Video.SuspendLayout();
            this.pan_RTSP.SuspendLayout();
            this.contextMenuStripVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Main
            // 
            this.pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.Controls.Add(this.uiSplitContainer1);
            this.pan_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Main.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Main.Location = new System.Drawing.Point(2, 35);
            this.pan_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Main.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Main.Name = "pan_Main";
            this.pan_Main.Padding = new System.Windows.Forms.Padding(2, 5, 5, 5);
            this.pan_Main.Radius = 0;
            this.pan_Main.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
            this.pan_Main.Size = new System.Drawing.Size(996, 563);
            this.pan_Main.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Main.TabIndex = 2;
            this.pan_Main.Text = null;
            this.pan_Main.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiSplitContainer1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.HandleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSplitContainer1.HandleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSplitContainer1.Location = new System.Drawing.Point(2, 5);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.gb_ControlBox);
            this.uiSplitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6, 5, 5, 5);
            this.uiSplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiSplitContainer1.Panel1MinSize = 10;
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.pan_Video);
            this.uiSplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiSplitContainer1.Panel2MinSize = 10;
            this.uiSplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiSplitContainer1.Size = new System.Drawing.Size(989, 553);
            this.uiSplitContainer1.SplitterDistance = 295;
            this.uiSplitContainer1.SplitterWidth = 10;
            this.uiSplitContainer1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSplitContainer1.TabIndex = 0;
            // 
            // gb_ControlBox
            // 
            this.gb_ControlBox.Controls.Add(this.uiPanel18);
            this.gb_ControlBox.Controls.Add(this.uiPanel15);
            this.gb_ControlBox.Controls.Add(this.uiPanel5);
            this.gb_ControlBox.Controls.Add(this.uiPanel1);
            this.gb_ControlBox.Controls.Add(this.uiPanel4);
            this.gb_ControlBox.Controls.Add(this.uiPanel2);
            this.gb_ControlBox.Controls.Add(this.uiPanel3);
            this.gb_ControlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_ControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ControlBox.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ControlBox.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ControlBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gb_ControlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.gb_ControlBox.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_ControlBox.Location = new System.Drawing.Point(6, 5);
            this.gb_ControlBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_ControlBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.gb_ControlBox.Name = "gb_ControlBox";
            this.gb_ControlBox.Padding = new System.Windows.Forms.Padding(1, 32, 10, 2);
            this.gb_ControlBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ControlBox.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ControlBox.Size = new System.Drawing.Size(284, 543);
            this.gb_ControlBox.TabIndex = 0;
            this.gb_ControlBox.Text = "控制面板";
            this.gb_ControlBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gb_ControlBox.TitleTop = 10;
            // 
            // uiPanel18
            // 
            this.uiPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Controls.Add(this.rtb_DeviceMessage);
            this.uiPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel18.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel18.Location = new System.Drawing.Point(1, 184);
            this.uiPanel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel18.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel18.Name = "uiPanel18";
            this.uiPanel18.Opacity = ((byte)(180));
            this.uiPanel18.Padding = new System.Windows.Forms.Padding(15, 2, 5, 2);
            this.uiPanel18.Radius = 10;
            this.uiPanel18.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel18.Size = new System.Drawing.Size(273, 357);
            this.uiPanel18.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel18.TabIndex = 25;
            this.uiPanel18.Text = null;
            this.uiPanel18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_DeviceMessage
            // 
            this.rtb_DeviceMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_DeviceMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.rtb_DeviceMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.rtb_DeviceMessage.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rtb_DeviceMessage.Location = new System.Drawing.Point(15, 2);
            this.rtb_DeviceMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_DeviceMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtb_DeviceMessage.Name = "rtb_DeviceMessage";
            this.rtb_DeviceMessage.Padding = new System.Windows.Forms.Padding(2);
            this.rtb_DeviceMessage.ReadOnly = true;
            this.rtb_DeviceMessage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtb_DeviceMessage.ScrollBarStyleInherited = false;
            this.rtb_DeviceMessage.ShowText = false;
            this.rtb_DeviceMessage.Size = new System.Drawing.Size(253, 353);
            this.rtb_DeviceMessage.Style = Sunny.UI.UIStyle.Custom;
            this.rtb_DeviceMessage.TabIndex = 11;
            this.rtb_DeviceMessage.Text = "未连接";
            this.rtb_DeviceMessage.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // uiPanel15
            // 
            this.uiPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Controls.Add(this.uiLabel2);
            this.uiPanel15.Controls.Add(this.uiPanel17);
            this.uiPanel15.Controls.Add(this.lb_DeviceInfo);
            this.uiPanel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel15.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel15.Location = new System.Drawing.Point(1, 154);
            this.uiPanel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel15.Name = "uiPanel15";
            this.uiPanel15.Opacity = ((byte)(180));
            this.uiPanel15.Radius = 10;
            this.uiPanel15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel15.Size = new System.Drawing.Size(273, 30);
            this.uiPanel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel15.TabIndex = 24;
            this.uiPanel15.Text = null;
            this.uiPanel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.uiLabel2.Location = new System.Drawing.Point(160, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.uiLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiLabel2.Size = new System.Drawing.Size(113, 30);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 20;
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel17
            // 
            this.uiPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel17.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel17.Location = new System.Drawing.Point(150, 0);
            this.uiPanel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel17.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel17.Name = "uiPanel17";
            this.uiPanel17.Opacity = ((byte)(180));
            this.uiPanel17.Radius = 10;
            this.uiPanel17.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel17.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel17.Size = new System.Drawing.Size(10, 30);
            this.uiPanel17.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel17.TabIndex = 19;
            this.uiPanel17.Text = null;
            this.uiPanel17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DeviceInfo
            // 
            this.lb_DeviceInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_DeviceInfo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lb_DeviceInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_DeviceInfo.Location = new System.Drawing.Point(0, 0);
            this.lb_DeviceInfo.Name = "lb_DeviceInfo";
            this.lb_DeviceInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_DeviceInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_DeviceInfo.Size = new System.Drawing.Size(150, 30);
            this.lb_DeviceInfo.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DeviceInfo.TabIndex = 18;
            this.lb_DeviceInfo.Text = "📋 设备信息 : ";
            this.lb_DeviceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel5
            // 
            this.uiPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.Controls.Add(this.uiPanel16);
            this.uiPanel5.Controls.Add(this.uiPanel7);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel5.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel5.Location = new System.Drawing.Point(1, 108);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Opacity = ((byte)(180));
            this.uiPanel5.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.uiPanel5.Radius = 10;
            this.uiPanel5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel5.Size = new System.Drawing.Size(273, 46);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 23;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel16
            // 
            this.uiPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel16.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel16.Location = new System.Drawing.Point(15, 35);
            this.uiPanel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel16.Name = "uiPanel16";
            this.uiPanel16.Opacity = ((byte)(180));
            this.uiPanel16.Radius = 10;
            this.uiPanel16.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel16.Size = new System.Drawing.Size(253, 10);
            this.uiPanel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel16.TabIndex = 12;
            this.uiPanel16.Text = null;
            this.uiPanel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            this.uiPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Controls.Add(this.uiPanel11);
            this.uiPanel7.Controls.Add(this.uiPanel10);
            this.uiPanel7.Controls.Add(this.uiPanel9);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel7.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel7.Location = new System.Drawing.Point(15, 0);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Opacity = ((byte)(180));
            this.uiPanel7.Radius = 10;
            this.uiPanel7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel7.Size = new System.Drawing.Size(253, 35);
            this.uiPanel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel7.TabIndex = 11;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel11
            // 
            this.uiPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Controls.Add(this.btn_StopPreview);
            this.uiPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel11.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel11.Location = new System.Drawing.Point(131, 0);
            this.uiPanel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel11.Name = "uiPanel11";
            this.uiPanel11.Opacity = ((byte)(180));
            this.uiPanel11.Radius = 10;
            this.uiPanel11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel11.Size = new System.Drawing.Size(122, 35);
            this.uiPanel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel11.TabIndex = 11;
            this.uiPanel11.Text = null;
            this.uiPanel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StopPreview
            // 
            this.btn_StopPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StopPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StopPreview.Enabled = false;
            this.btn_StopPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_StopPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_StopPreview.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_StopPreview.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_StopPreview.ForePressColor = System.Drawing.Color.Red;
            this.btn_StopPreview.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_StopPreview.Location = new System.Drawing.Point(0, 0);
            this.btn_StopPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_StopPreview.Name = "btn_StopPreview";
            this.btn_StopPreview.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StopPreview.RectPressColor = System.Drawing.Color.Red;
            this.btn_StopPreview.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_StopPreview.Size = new System.Drawing.Size(122, 35);
            this.btn_StopPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btn_StopPreview.TabIndex = 1;
            this.btn_StopPreview.Text = "⏹ 停止预览";
            this.btn_StopPreview.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StopPreview.Click += new System.EventHandler(this.btn_StopPreview_Click);
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
            this.uiPanel10.Location = new System.Drawing.Point(121, 0);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Opacity = ((byte)(180));
            this.uiPanel10.Radius = 10;
            this.uiPanel10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(10, 35);
            this.uiPanel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel10.TabIndex = 10;
            this.uiPanel10.Text = null;
            this.uiPanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel9
            // 
            this.uiPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Controls.Add(this.btn_StartPreview);
            this.uiPanel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel9.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel9.Location = new System.Drawing.Point(0, 0);
            this.uiPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel9.Name = "uiPanel9";
            this.uiPanel9.Opacity = ((byte)(180));
            this.uiPanel9.Radius = 10;
            this.uiPanel9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel9.Size = new System.Drawing.Size(121, 35);
            this.uiPanel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel9.TabIndex = 9;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StartPreview
            // 
            this.btn_StartPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_StartPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_StartPreview.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_StartPreview.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_StartPreview.ForePressColor = System.Drawing.Color.Red;
            this.btn_StartPreview.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_StartPreview.Location = new System.Drawing.Point(0, 0);
            this.btn_StartPreview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_StartPreview.Name = "btn_StartPreview";
            this.btn_StartPreview.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_StartPreview.RectPressColor = System.Drawing.Color.Red;
            this.btn_StartPreview.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_StartPreview.Size = new System.Drawing.Size(121, 35);
            this.btn_StartPreview.Style = Sunny.UI.UIStyle.Custom;
            this.btn_StartPreview.TabIndex = 0;
            this.btn_StartPreview.Text = "▶ 启动预览";
            this.btn_StartPreview.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartPreview.Click += new System.EventHandler(this.btn_StartPreview_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel1.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel1.Location = new System.Drawing.Point(1, 95);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Opacity = ((byte)(180));
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel1.Size = new System.Drawing.Size(273, 13);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 22;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Controls.Add(this.cmb_Devices);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel4.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel4.Location = new System.Drawing.Point(1, 65);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Opacity = ((byte)(180));
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.uiPanel4.Radius = 10;
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel4.Size = new System.Drawing.Size(273, 30);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.TabIndex = 21;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Devices
            // 
            this.cmb_Devices.DataSource = null;
            this.cmb_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Devices.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_Devices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_Devices.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_Devices.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_Devices.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_Devices.Location = new System.Drawing.Point(15, 0);
            this.cmb_Devices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Devices.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_Devices.Name = "cmb_Devices";
            this.cmb_Devices.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_Devices.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Devices.Size = new System.Drawing.Size(253, 30);
            this.cmb_Devices.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_Devices.SymbolSize = 24;
            this.cmb_Devices.TabIndex = 27;
            this.cmb_Devices.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_Devices.Watermark = "";
            this.cmb_Devices.DropDown += new System.EventHandler(this.cmb_Devices_DropDown);
            this.cmb_Devices.DropDownClosed += new System.EventHandler(this.cmb_Devices_DropDownClosed);
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel2.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel2.Location = new System.Drawing.Point(1, 62);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Opacity = ((byte)(180));
            this.uiPanel2.Radius = 10;
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel2.Size = new System.Drawing.Size(273, 3);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 20;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.Controls.Add(this.lb_USBDeviceNum);
            this.uiPanel3.Controls.Add(this.uiPanel6);
            this.uiPanel3.Controls.Add(this.lb_DevicesList);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel3.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel3.Location = new System.Drawing.Point(1, 32);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Opacity = ((byte)(180));
            this.uiPanel3.Radius = 10;
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiPanel3.Size = new System.Drawing.Size(273, 30);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 18;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_USBDeviceNum
            // 
            this.lb_USBDeviceNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_USBDeviceNum.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lb_USBDeviceNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_USBDeviceNum.Location = new System.Drawing.Point(160, 0);
            this.lb_USBDeviceNum.Name = "lb_USBDeviceNum";
            this.lb_USBDeviceNum.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_USBDeviceNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_USBDeviceNum.Size = new System.Drawing.Size(113, 30);
            this.lb_USBDeviceNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_USBDeviceNum.TabIndex = 20;
            this.lb_USBDeviceNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiPanel6
            // 
            this.uiPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel6.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel6.Location = new System.Drawing.Point(150, 0);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Opacity = ((byte)(180));
            this.uiPanel6.Radius = 10;
            this.uiPanel6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel6.Size = new System.Drawing.Size(10, 30);
            this.uiPanel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel6.TabIndex = 19;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DevicesList
            // 
            this.lb_DevicesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_DevicesList.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lb_DevicesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_DevicesList.Location = new System.Drawing.Point(0, 0);
            this.lb_DevicesList.Name = "lb_DevicesList";
            this.lb_DevicesList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_DevicesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_DevicesList.Size = new System.Drawing.Size(150, 30);
            this.lb_DevicesList.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DevicesList.TabIndex = 18;
            this.lb_DevicesList.Text = "📹设备列表 : ";
            this.lb_DevicesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_Video
            // 
            this.pan_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_Video.Controls.Add(this.led_State);
            this.pan_Video.Controls.Add(this.lb_Fps);
            this.pan_Video.Controls.Add(this.lb_State);
            this.pan_Video.Controls.Add(this.pan_RTSP);
            this.pan_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Video.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Video.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Video.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Video.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Video.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Video.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Video.Location = new System.Drawing.Point(0, 0);
            this.pan_Video.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Video.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Video.Name = "pan_Video";
            this.pan_Video.Opacity = ((byte)(180));
            this.pan_Video.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Video.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Video.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Video.Size = new System.Drawing.Size(684, 553);
            this.pan_Video.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Video.TabIndex = 4;
            this.pan_Video.Text = null;
            this.pan_Video.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Fps
            // 
            this.lb_Fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Fps.BackColor = System.Drawing.Color.Transparent;
            this.lb_Fps.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fps.ForeColor = System.Drawing.Color.Lime;
            this.lb_Fps.Location = new System.Drawing.Point(546, 523);
            this.lb_Fps.Name = "lb_Fps";
            this.lb_Fps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Fps.Size = new System.Drawing.Size(138, 26);
            this.lb_Fps.TabIndex = 27;
            this.lb_Fps.Text = "FPS : 0.0";
            this.lb_Fps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_State
            // 
            this.lb_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_State.BackColor = System.Drawing.Color.Transparent;
            this.lb_State.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lb_State.Location = new System.Drawing.Point(44, 523);
            this.lb_State.Name = "lb_State";
            this.lb_State.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_State.Size = new System.Drawing.Size(138, 26);
            this.lb_State.TabIndex = 25;
            this.lb_State.Text = "离线";
            this.lb_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pan_RTSP
            // 
            this.pan_RTSP.BackColor = System.Drawing.Color.Transparent;
            this.pan_RTSP.Controls.Add(this.tb_RtspAddress);
            this.pan_RTSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_RTSP.FillColor = System.Drawing.Color.Transparent;
            this.pan_RTSP.FillColor2 = System.Drawing.Color.Transparent;
            this.pan_RTSP.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_RTSP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_RTSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_RTSP.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_RTSP.Location = new System.Drawing.Point(0, 0);
            this.pan_RTSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_RTSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_RTSP.Name = "pan_RTSP";
            this.pan_RTSP.Opacity = ((byte)(180));
            this.pan_RTSP.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pan_RTSP.Radius = 10;
            this.pan_RTSP.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_RTSP.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_RTSP.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_RTSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pan_RTSP.Size = new System.Drawing.Size(684, 30);
            this.pan_RTSP.Style = Sunny.UI.UIStyle.Custom;
            this.pan_RTSP.TabIndex = 24;
            this.pan_RTSP.Text = null;
            this.pan_RTSP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pan_RTSP.Visible = false;
            // 
            // tb_RtspAddress
            // 
            this.tb_RtspAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_RtspAddress.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_RtspAddress.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_RtspAddress.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_RtspAddress.ButtonStyleInherited = false;
            this.tb_RtspAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RtspAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_RtspAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RtspAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_RtspAddress.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_RtspAddress.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_RtspAddress.Location = new System.Drawing.Point(5, 0);
            this.tb_RtspAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RtspAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_RtspAddress.Multiline = true;
            this.tb_RtspAddress.Name = "tb_RtspAddress";
            this.tb_RtspAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tb_RtspAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RtspAddress.ScrollBarStyleInherited = false;
            this.tb_RtspAddress.ShowText = false;
            this.tb_RtspAddress.Size = new System.Drawing.Size(674, 30);
            this.tb_RtspAddress.Style = Sunny.UI.UIStyle.Custom;
            this.tb_RtspAddress.TabIndex = 25;
            this.tb_RtspAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_RtspAddress.Watermark = "rtsp address";
            // 
            // contextMenuStripVideo
            // 
            this.contextMenuStripVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contextMenuStripVideo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripVideo.Name = "uiContextMenuStrip1";
            this.contextMenuStripVideo.ShowImageMargin = false;
            this.contextMenuStripVideo.Size = new System.Drawing.Size(98, 26);
            this.contextMenuStripVideo.Style = Sunny.UI.UIStyle.Custom;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem1.Text = "视频预览";
            // 
            // led_State
            // 
            this.led_State.BackColor = System.Drawing.Color.Transparent;
            this.led_State.Color = System.Drawing.Color.Gray;
            this.led_State.Location = new System.Drawing.Point(4, 520);
            this.led_State.Name = "led_State";
            this.led_State.Size = new System.Drawing.Size(32, 32);
            this.led_State.TabIndex = 28;
            this.led_State.Text = "uiLedBulb1";
            // 
            // VideoPreviewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.pan_Main);
            this.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Name = "VideoPreviewForm";
            this.Padding = new System.Windows.Forms.Padding(2, 35, 2, 2);
            this.RectColor = System.Drawing.Color.Transparent;
            this.ShowIcon = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "视频预览";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPreviewForm_FormClosing);
            this.Load += new System.EventHandler(this.VideoPreviewForm_Load);
            this.pan_Main.ResumeLayout(false);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.gb_ControlBox.ResumeLayout(false);
            this.uiPanel18.ResumeLayout(false);
            this.uiPanel15.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            this.uiPanel11.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.pan_Video.ResumeLayout(false);
            this.pan_RTSP.ResumeLayout(false);
            this.contextMenuStripVideo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pan_Main;
        private Sunny.UI.UIContextMenuStrip contextMenuStripVideo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UIGroupBox gb_ControlBox;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel lb_DevicesList;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cmb_Devices;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel16;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel11;
        private Sunny.UI.UIButton btn_StopPreview;
        private Sunny.UI.UIPanel uiPanel10;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIButton btn_StartPreview;
        private Sunny.UI.UILabel lb_USBDeviceNum;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel18;
        private Sunny.UI.UIPanel uiPanel15;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIPanel uiPanel17;
        private Sunny.UI.UILabel lb_DeviceInfo;
        private Sunny.UI.UIRichTextBox rtb_DeviceMessage;
        private Sunny.UI.UIPanel pan_Video;
        private Sunny.UI.UIPanel pan_RTSP;
        private Sunny.UI.UITextBox tb_RtspAddress;
        private TransparentLabel lb_State;
        private TransparentLabel lb_Fps;
        private Sunny.UI.UILedBulb led_State;
    }
}
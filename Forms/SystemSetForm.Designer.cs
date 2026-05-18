using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UCM_Tools.Forms
{
    partial class SystemSetForm
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
            this.pan_Left = new Sunny.UI.UIPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.btn_Save = new Sunny.UI.UIButton();
            this.uiPanel86 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiPanel43 = new Sunny.UI.UIPanel();
            this.uiPanel44 = new Sunny.UI.UIPanel();
            this.uiPanel48 = new Sunny.UI.UIPanel();
            this.pan_TarTextEnable = new Sunny.UI.UIPanel();
            this.uiPanel169 = new Sunny.UI.UIPanel();
            this.cb_Confidence = new Sunny.UI.UICheckBox();
            this.uiPanel168 = new Sunny.UI.UIPanel();
            this.uiPanel167 = new Sunny.UI.UIPanel();
            this.cb_AngleH = new Sunny.UI.UICheckBox();
            this.uiPanel166 = new Sunny.UI.UIPanel();
            this.uiPanel165 = new Sunny.UI.UIPanel();
            this.cb_Velocity = new Sunny.UI.UICheckBox();
            this.uiPanel164 = new Sunny.UI.UIPanel();
            this.uiPanel53 = new Sunny.UI.UIPanel();
            this.cb_Z = new Sunny.UI.UICheckBox();
            this.uiPanel54 = new Sunny.UI.UIPanel();
            this.uiPanel46 = new Sunny.UI.UIPanel();
            this.cb_Y = new Sunny.UI.UICheckBox();
            this.uiPanel52 = new Sunny.UI.UIPanel();
            this.uiPanel49 = new Sunny.UI.UIPanel();
            this.cb_X = new Sunny.UI.UICheckBox();
            this.uiPanel50 = new Sunny.UI.UIPanel();
            this.uiPanel51 = new Sunny.UI.UIPanel();
            this.cb_ID = new Sunny.UI.UICheckBox();
            this.uiPanel105 = new Sunny.UI.UIPanel();
            this.uiPanel47 = new Sunny.UI.UIPanel();
            this.cb_DisplayTrackText = new Sunny.UI.UICheckBox();
            this.uiPanel42 = new Sunny.UI.UIPanel();
            this.lb_TextParams = new Sunny.UI.UILabel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel99 = new Sunny.UI.UIPanel();
            this.uiPanel100 = new Sunny.UI.UIPanel();
            this.uiPanel101 = new Sunny.UI.UIPanel();
            this.uiPanel102 = new Sunny.UI.UIPanel();
            this.uiPanel103 = new Sunny.UI.UIPanel();
            this.uiPanel109 = new Sunny.UI.UIPanel();
            this.uiPanel110 = new Sunny.UI.UIPanel();
            this.uiPanel113 = new Sunny.UI.UIPanel();
            this.uiPanel114 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tb_FrameCycle = new Sunny.UI.UITextBox();
            this.uiPanel115 = new Sunny.UI.UIPanel();
            this.lb_FrameCycle = new Sunny.UI.UILabel();
            this.uiPanel159 = new Sunny.UI.UIPanel();
            this.uiPanel107 = new Sunny.UI.UIPanel();
            this.cmb_ReplayDataFormat = new Sunny.UI.UIComboBox();
            this.uiPanel108 = new Sunny.UI.UIPanel();
            this.lb_ReplayDataFormat = new Sunny.UI.UILabel();
            this.uiPanel111 = new Sunny.UI.UIPanel();
            this.lb_DataReplayParams = new Sunny.UI.UILabel();
            this.uiPanel98 = new Sunny.UI.UIPanel();
            this.uiPanel58 = new Sunny.UI.UIPanel();
            this.uiPanel77 = new Sunny.UI.UIPanel();
            this.uiPanel87 = new Sunny.UI.UIPanel();
            this.uiPanel78 = new Sunny.UI.UIPanel();
            this.uiPanel79 = new Sunny.UI.UIPanel();
            this.uiPanel80 = new Sunny.UI.UIPanel();
            this.uiPanel85 = new Sunny.UI.UIPanel();
            this.tb_FilePath = new Sunny.UI.UIRichTextBox();
            this.uiPanel82 = new Sunny.UI.UIPanel();
            this.uiPanel84 = new Sunny.UI.UIPanel();
            this.uiPanel81 = new Sunny.UI.UIPanel();
            this.lb_FileSizeUnit = new Sunny.UI.UILabel();
            this.tb_FileSize = new Sunny.UI.UITextBox();
            this.uiPanel83 = new Sunny.UI.UIPanel();
            this.lb_FileSize = new Sunny.UI.UILabel();
            this.uiPanel106 = new Sunny.UI.UIPanel();
            this.uiPanel89 = new Sunny.UI.UIPanel();
            this.cb_TargetSave = new Sunny.UI.UICheckBox();
            this.uiPanel90 = new Sunny.UI.UIPanel();
            this.lb_SaveDataParams = new Sunny.UI.UILabel();
            this.uiPanel88 = new Sunny.UI.UIPanel();
            this.pan_ControlArea = new Sunny.UI.UIPanel();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.pan_HeightColor = new Sunny.UI.UIPanel();
            this.uiPanel57 = new Sunny.UI.UIPanel();
            this.color_Red = new Sunny.UI.UIBreadcrumb();
            this.uiPanel56 = new Sunny.UI.UIPanel();
            this.tb_RedValue = new Sunny.UI.UITextBox();
            this.uiPanel55 = new Sunny.UI.UIPanel();
            this.color_Orange = new Sunny.UI.UIBreadcrumb();
            this.uiPanel41 = new Sunny.UI.UIPanel();
            this.tb_OrangeValue = new Sunny.UI.UITextBox();
            this.uiPanel40 = new Sunny.UI.UIPanel();
            this.color_Yellow = new Sunny.UI.UIBreadcrumb();
            this.uiPanel39 = new Sunny.UI.UIPanel();
            this.tb_YellowValue = new Sunny.UI.UITextBox();
            this.uiPanel38 = new Sunny.UI.UIPanel();
            this.color_Green = new Sunny.UI.UIBreadcrumb();
            this.uiPanel37 = new Sunny.UI.UIPanel();
            this.tb_GreenValue = new Sunny.UI.UITextBox();
            this.uiPanel16 = new Sunny.UI.UIPanel();
            this.color_Cyan = new Sunny.UI.UIBreadcrumb();
            this.uiPanel15 = new Sunny.UI.UIPanel();
            this.tb_CyanValue = new Sunny.UI.UITextBox();
            this.uiPanel14 = new Sunny.UI.UIPanel();
            this.color_Blue = new Sunny.UI.UIBreadcrumb();
            this.uiPanel13 = new Sunny.UI.UIPanel();
            this.tb_BlueValue = new Sunny.UI.UITextBox();
            this.pan_Purple = new Sunny.UI.UIPanel();
            this.color_Purple = new Sunny.UI.UIBreadcrumb();
            this.uiPanel140 = new Sunny.UI.UIPanel();
            this.uiPanel12 = new Sunny.UI.UIPanel();
            this.rb_HeightColor = new Sunny.UI.UIRadioButton();
            this.uiPanel11 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.rb_DefaultColor = new Sunny.UI.UIRadioButton();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.lb_ColorTitle = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.pan_GraphParams = new Sunny.UI.UIPanel();
            this.pan_Graph = new Sunny.UI.UIPanel();
            this.uiPanel142 = new Sunny.UI.UIPanel();
            this.uiPanel143 = new Sunny.UI.UIPanel();
            this.uiPanel144 = new Sunny.UI.UIPanel();
            this.tb_TrackTextSize = new Sunny.UI.UITextBox();
            this.uiPanel145 = new Sunny.UI.UIPanel();
            this.uiPanel146 = new Sunny.UI.UIPanel();
            this.lb_TrackTextSize = new Sunny.UI.UILabel();
            this.uiPanel147 = new Sunny.UI.UIPanel();
            this.uiPanel148 = new Sunny.UI.UIPanel();
            this.cp_TrackTextColor = new Sunny.UI.UIColorPicker();
            this.uiPanel149 = new Sunny.UI.UIPanel();
            this.uiPanel150 = new Sunny.UI.UIPanel();
            this.lb_TrackTextColor = new Sunny.UI.UILabel();
            this.uiPanel151 = new Sunny.UI.UIPanel();
            this.uiPanel152 = new Sunny.UI.UIPanel();
            this.tb_ZMax = new Sunny.UI.UITextBox();
            this.uiPanel153 = new Sunny.UI.UIPanel();
            this.uiPanel154 = new Sunny.UI.UIPanel();
            this.lb_ZMax = new Sunny.UI.UILabel();
            this.uiPanel155 = new Sunny.UI.UIPanel();
            this.uiPanel156 = new Sunny.UI.UIPanel();
            this.cmb_CumulativeFramesType = new Sunny.UI.UIComboBox();
            this.uiPanel157 = new Sunny.UI.UIPanel();
            this.uiPanel158 = new Sunny.UI.UIPanel();
            this.lb_CumulativeFramesType = new Sunny.UI.UILabel();
            this.uiPanel141 = new Sunny.UI.UIPanel();
            this.uiPanel123 = new Sunny.UI.UIPanel();
            this.uiPanel124 = new Sunny.UI.UIPanel();
            this.uiPanel125 = new Sunny.UI.UIPanel();
            this.tb_MaxTrajectoryNum = new Sunny.UI.UITextBox();
            this.uiPanel126 = new Sunny.UI.UIPanel();
            this.uiPanel127 = new Sunny.UI.UIPanel();
            this.lb_MaxTrajectoryNum = new Sunny.UI.UILabel();
            this.uiPanel128 = new Sunny.UI.UIPanel();
            this.uiPanel129 = new Sunny.UI.UIPanel();
            this.cp_TrackColor = new Sunny.UI.UIColorPicker();
            this.uiPanel130 = new Sunny.UI.UIPanel();
            this.uiPanel131 = new Sunny.UI.UIPanel();
            this.lb_TrackColor = new Sunny.UI.UILabel();
            this.uiPanel132 = new Sunny.UI.UIPanel();
            this.uiPanel133 = new Sunny.UI.UIPanel();
            this.tb_ZMin = new Sunny.UI.UITextBox();
            this.uiPanel134 = new Sunny.UI.UIPanel();
            this.uiPanel135 = new Sunny.UI.UIPanel();
            this.lb_ZMin = new Sunny.UI.UILabel();
            this.uiPanel136 = new Sunny.UI.UIPanel();
            this.uiPanel137 = new Sunny.UI.UIPanel();
            this.tb_CumulativeFrames = new Sunny.UI.UITextBox();
            this.uiPanel138 = new Sunny.UI.UIPanel();
            this.uiPanel139 = new Sunny.UI.UIPanel();
            this.lb_CumulativeFramesText = new Sunny.UI.UILabel();
            this.uiPanel104 = new Sunny.UI.UIPanel();
            this.uiPanel29 = new Sunny.UI.UIPanel();
            this.uiPanel112 = new Sunny.UI.UIPanel();
            this.uiPanel116 = new Sunny.UI.UIPanel();
            this.cp_TrackTrajectoryColor = new Sunny.UI.UIColorPicker();
            this.uiPanel117 = new Sunny.UI.UIPanel();
            this.uiPanel118 = new Sunny.UI.UIPanel();
            this.lb_TrackTrajectoryColor = new Sunny.UI.UILabel();
            this.uiPanel65 = new Sunny.UI.UIPanel();
            this.uiPanel66 = new Sunny.UI.UIPanel();
            this.tb_TrackSize = new Sunny.UI.UITextBox();
            this.uiPanel67 = new Sunny.UI.UIPanel();
            this.uiPanel68 = new Sunny.UI.UIPanel();
            this.lb_TrackSize = new Sunny.UI.UILabel();
            this.uiPanel69 = new Sunny.UI.UIPanel();
            this.uiPanel70 = new Sunny.UI.UIPanel();
            this.tb_YStep = new Sunny.UI.UITextBox();
            this.uiPanel71 = new Sunny.UI.UIPanel();
            this.uiPanel72 = new Sunny.UI.UIPanel();
            this.lb_YStep = new Sunny.UI.UILabel();
            this.uiPanel73 = new Sunny.UI.UIPanel();
            this.uiPanel74 = new Sunny.UI.UIPanel();
            this.tb_XStep = new Sunny.UI.UITextBox();
            this.uiPanel75 = new Sunny.UI.UIPanel();
            this.uiPanel76 = new Sunny.UI.UIPanel();
            this.lb_XStep = new Sunny.UI.UILabel();
            this.uiPanel64 = new Sunny.UI.UIPanel();
            this.pan_Graph_Middle = new Sunny.UI.UIPanel();
            this.uiPanel160 = new Sunny.UI.UIPanel();
            this.uiPanel161 = new Sunny.UI.UIPanel();
            this.cmb_TrackColorMode = new Sunny.UI.UIComboBox();
            this.uiPanel162 = new Sunny.UI.UIPanel();
            this.uiPanel163 = new Sunny.UI.UIPanel();
            this.lb_TrackColorMode = new Sunny.UI.UILabel();
            this.uiPanel94 = new Sunny.UI.UIPanel();
            this.uiPanel95 = new Sunny.UI.UIPanel();
            this.tb_TrackTrajectoryLineWidth = new Sunny.UI.UITextBox();
            this.uiPanel96 = new Sunny.UI.UIPanel();
            this.uiPanel97 = new Sunny.UI.UIPanel();
            this.lb_TrackTrajectoryLineWidth = new Sunny.UI.UILabel();
            this.uiPanel30 = new Sunny.UI.UIPanel();
            this.uiPanel31 = new Sunny.UI.UIPanel();
            this.tb_PointSize = new Sunny.UI.UITextBox();
            this.uiPanel32 = new Sunny.UI.UIPanel();
            this.uiPanel33 = new Sunny.UI.UIPanel();
            this.lb_PointSize = new Sunny.UI.UILabel();
            this.uiPanel34 = new Sunny.UI.UIPanel();
            this.uiPanel35 = new Sunny.UI.UIPanel();
            this.tb_YMax = new Sunny.UI.UITextBox();
            this.uiPanel36 = new Sunny.UI.UIPanel();
            this.uiPanel59 = new Sunny.UI.UIPanel();
            this.lb_YMax = new Sunny.UI.UILabel();
            this.uiPanel60 = new Sunny.UI.UIPanel();
            this.uiPanel61 = new Sunny.UI.UIPanel();
            this.tb_XMax = new Sunny.UI.UITextBox();
            this.uiPanel62 = new Sunny.UI.UIPanel();
            this.uiPanel63 = new Sunny.UI.UIPanel();
            this.lb_XMax = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pan_Graph_Left = new Sunny.UI.UIPanel();
            this.uiPanel119 = new Sunny.UI.UIPanel();
            this.uiPanel120 = new Sunny.UI.UIPanel();
            this.tb_TrackTrajectoryOuttime = new Sunny.UI.UITextBox();
            this.uiPanel121 = new Sunny.UI.UIPanel();
            this.uiPanel122 = new Sunny.UI.UIPanel();
            this.lb_TrackTrajectoryOuttime = new Sunny.UI.UILabel();
            this.uiPanel45 = new Sunny.UI.UIPanel();
            this.uiPanel91 = new Sunny.UI.UIPanel();
            this.cmb_ShowTrackTrajectory = new Sunny.UI.UIComboBox();
            this.uiPanel92 = new Sunny.UI.UIPanel();
            this.uiPanel93 = new Sunny.UI.UIPanel();
            this.lb_ShowTrackTrajectory = new Sunny.UI.UILabel();
            this.uiPanel25 = new Sunny.UI.UIPanel();
            this.uiPanel26 = new Sunny.UI.UIPanel();
            this.cmb_ShowType = new Sunny.UI.UIComboBox();
            this.uiPanel27 = new Sunny.UI.UIPanel();
            this.uiPanel28 = new Sunny.UI.UIPanel();
            this.lb_ShowType = new Sunny.UI.UILabel();
            this.uiPanel21 = new Sunny.UI.UIPanel();
            this.uiPanel22 = new Sunny.UI.UIPanel();
            this.tb_YMin = new Sunny.UI.UITextBox();
            this.uiPanel23 = new Sunny.UI.UIPanel();
            this.uiPanel24 = new Sunny.UI.UIPanel();
            this.lb_YMin = new Sunny.UI.UILabel();
            this.uiPanel17 = new Sunny.UI.UIPanel();
            this.uiPanel18 = new Sunny.UI.UIPanel();
            this.tb_XMin = new Sunny.UI.UITextBox();
            this.uiPanel19 = new Sunny.UI.UIPanel();
            this.uiPanel20 = new Sunny.UI.UIPanel();
            this.lb_XMin = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.lb_GraphTitle = new Sunny.UI.UILabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pan_Main.SuspendLayout();
            this.pan_Left.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel43.SuspendLayout();
            this.uiPanel44.SuspendLayout();
            this.uiPanel48.SuspendLayout();
            this.pan_TarTextEnable.SuspendLayout();
            this.uiPanel169.SuspendLayout();
            this.uiPanel167.SuspendLayout();
            this.uiPanel165.SuspendLayout();
            this.uiPanel53.SuspendLayout();
            this.uiPanel46.SuspendLayout();
            this.uiPanel49.SuspendLayout();
            this.uiPanel51.SuspendLayout();
            this.uiPanel47.SuspendLayout();
            this.uiPanel99.SuspendLayout();
            this.uiPanel100.SuspendLayout();
            this.uiPanel101.SuspendLayout();
            this.uiPanel102.SuspendLayout();
            this.uiPanel103.SuspendLayout();
            this.uiPanel109.SuspendLayout();
            this.uiPanel114.SuspendLayout();
            this.uiPanel115.SuspendLayout();
            this.uiPanel107.SuspendLayout();
            this.uiPanel108.SuspendLayout();
            this.uiPanel58.SuspendLayout();
            this.uiPanel77.SuspendLayout();
            this.uiPanel87.SuspendLayout();
            this.uiPanel78.SuspendLayout();
            this.uiPanel79.SuspendLayout();
            this.uiPanel80.SuspendLayout();
            this.uiPanel85.SuspendLayout();
            this.uiPanel81.SuspendLayout();
            this.uiPanel83.SuspendLayout();
            this.uiPanel89.SuspendLayout();
            this.pan_ControlArea.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            this.pan_HeightColor.SuspendLayout();
            this.uiPanel57.SuspendLayout();
            this.uiPanel56.SuspendLayout();
            this.uiPanel55.SuspendLayout();
            this.uiPanel41.SuspendLayout();
            this.uiPanel40.SuspendLayout();
            this.uiPanel39.SuspendLayout();
            this.uiPanel38.SuspendLayout();
            this.uiPanel37.SuspendLayout();
            this.uiPanel16.SuspendLayout();
            this.uiPanel15.SuspendLayout();
            this.uiPanel14.SuspendLayout();
            this.uiPanel13.SuspendLayout();
            this.pan_Purple.SuspendLayout();
            this.uiPanel12.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.pan_GraphParams.SuspendLayout();
            this.pan_Graph.SuspendLayout();
            this.uiPanel142.SuspendLayout();
            this.uiPanel143.SuspendLayout();
            this.uiPanel144.SuspendLayout();
            this.uiPanel146.SuspendLayout();
            this.uiPanel147.SuspendLayout();
            this.uiPanel148.SuspendLayout();
            this.uiPanel150.SuspendLayout();
            this.uiPanel151.SuspendLayout();
            this.uiPanel152.SuspendLayout();
            this.uiPanel154.SuspendLayout();
            this.uiPanel155.SuspendLayout();
            this.uiPanel156.SuspendLayout();
            this.uiPanel158.SuspendLayout();
            this.uiPanel123.SuspendLayout();
            this.uiPanel124.SuspendLayout();
            this.uiPanel125.SuspendLayout();
            this.uiPanel127.SuspendLayout();
            this.uiPanel128.SuspendLayout();
            this.uiPanel129.SuspendLayout();
            this.uiPanel131.SuspendLayout();
            this.uiPanel132.SuspendLayout();
            this.uiPanel133.SuspendLayout();
            this.uiPanel135.SuspendLayout();
            this.uiPanel136.SuspendLayout();
            this.uiPanel137.SuspendLayout();
            this.uiPanel139.SuspendLayout();
            this.uiPanel29.SuspendLayout();
            this.uiPanel112.SuspendLayout();
            this.uiPanel116.SuspendLayout();
            this.uiPanel118.SuspendLayout();
            this.uiPanel65.SuspendLayout();
            this.uiPanel66.SuspendLayout();
            this.uiPanel68.SuspendLayout();
            this.uiPanel69.SuspendLayout();
            this.uiPanel70.SuspendLayout();
            this.uiPanel72.SuspendLayout();
            this.uiPanel73.SuspendLayout();
            this.uiPanel74.SuspendLayout();
            this.uiPanel76.SuspendLayout();
            this.pan_Graph_Middle.SuspendLayout();
            this.uiPanel160.SuspendLayout();
            this.uiPanel161.SuspendLayout();
            this.uiPanel163.SuspendLayout();
            this.uiPanel94.SuspendLayout();
            this.uiPanel95.SuspendLayout();
            this.uiPanel97.SuspendLayout();
            this.uiPanel30.SuspendLayout();
            this.uiPanel31.SuspendLayout();
            this.uiPanel33.SuspendLayout();
            this.uiPanel34.SuspendLayout();
            this.uiPanel35.SuspendLayout();
            this.uiPanel59.SuspendLayout();
            this.uiPanel60.SuspendLayout();
            this.uiPanel61.SuspendLayout();
            this.uiPanel63.SuspendLayout();
            this.pan_Graph_Left.SuspendLayout();
            this.uiPanel119.SuspendLayout();
            this.uiPanel120.SuspendLayout();
            this.uiPanel122.SuspendLayout();
            this.uiPanel45.SuspendLayout();
            this.uiPanel91.SuspendLayout();
            this.uiPanel93.SuspendLayout();
            this.uiPanel25.SuspendLayout();
            this.uiPanel26.SuspendLayout();
            this.uiPanel28.SuspendLayout();
            this.uiPanel21.SuspendLayout();
            this.uiPanel22.SuspendLayout();
            this.uiPanel24.SuspendLayout();
            this.uiPanel17.SuspendLayout();
            this.uiPanel18.SuspendLayout();
            this.uiPanel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Main
            // 
            this.pan_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.pan_Main.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Main.Size = new System.Drawing.Size(1180, 655);
            this.pan_Main.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Main.TabIndex = 1;
            this.pan_Main.Text = null;
            this.pan_Main.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Left
            // 
            this.pan_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.Controls.Add(this.uiPanel6);
            this.pan_Left.Controls.Add(this.uiPanel86);
            this.pan_Left.Controls.Add(this.uiPanel4);
            this.pan_Left.Controls.Add(this.uiPanel5);
            this.pan_Left.Controls.Add(this.uiPanel99);
            this.pan_Left.Controls.Add(this.uiPanel98);
            this.pan_Left.Controls.Add(this.uiPanel58);
            this.pan_Left.Controls.Add(this.uiPanel88);
            this.pan_Left.Controls.Add(this.pan_ControlArea);
            this.pan_Left.Controls.Add(this.uiPanel2);
            this.pan_Left.Controls.Add(this.pan_GraphParams);
            this.pan_Left.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.pan_Left.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Left.Size = new System.Drawing.Size(1180, 655);
            this.pan_Left.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Left.TabIndex = 3;
            this.pan_Left.Text = null;
            this.pan_Left.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            this.uiPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Controls.Add(this.btn_Save);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel6.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel6.Location = new System.Drawing.Point(0, 604);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Opacity = ((byte)(180));
            this.uiPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel6.Radius = 10;
            this.uiPanel6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Size = new System.Drawing.Size(1180, 50);
            this.uiPanel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel6.TabIndex = 32;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Save.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Save.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Save.ForePressColor = System.Drawing.Color.Red;
            this.btn_Save.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(523, 7);
            this.btn_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.RectPressColor = System.Drawing.Color.Red;
            this.btn_Save.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_Save.Size = new System.Drawing.Size(135, 35);
            this.btn_Save.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存参数";
            this.btn_Save.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
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
            this.uiPanel86.Location = new System.Drawing.Point(0, 594);
            this.uiPanel86.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel86.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel86.Name = "uiPanel86";
            this.uiPanel86.Opacity = ((byte)(180));
            this.uiPanel86.Radius = 10;
            this.uiPanel86.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel86.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel86.Size = new System.Drawing.Size(1180, 10);
            this.uiPanel86.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel86.TabIndex = 31;
            this.uiPanel86.Text = null;
            this.uiPanel86.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Controls.Add(this.uiPanel43);
            this.uiPanel4.Controls.Add(this.uiPanel42);
            this.uiPanel4.Controls.Add(this.lb_TextParams);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel4.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel4.Location = new System.Drawing.Point(0, 515);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Opacity = ((byte)(180));
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel4.Radius = 10;
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Size = new System.Drawing.Size(1180, 79);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.TabIndex = 30;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel43
            // 
            this.uiPanel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.Controls.Add(this.uiPanel44);
            this.uiPanel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel43.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel43.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel43.Location = new System.Drawing.Point(10, 41);
            this.uiPanel43.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel43.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel43.Name = "uiPanel43";
            this.uiPanel43.Opacity = ((byte)(180));
            this.uiPanel43.Radius = 10;
            this.uiPanel43.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel43.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel43.Size = new System.Drawing.Size(1160, 28);
            this.uiPanel43.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel43.TabIndex = 11;
            this.uiPanel43.Text = null;
            this.uiPanel43.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel44
            // 
            this.uiPanel44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.Controls.Add(this.uiPanel48);
            this.uiPanel44.Controls.Add(this.uiPanel105);
            this.uiPanel44.Controls.Add(this.uiPanel47);
            this.uiPanel44.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel44.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel44.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel44.Location = new System.Drawing.Point(0, 0);
            this.uiPanel44.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel44.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel44.Name = "uiPanel44";
            this.uiPanel44.Opacity = ((byte)(180));
            this.uiPanel44.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel44.Radius = 10;
            this.uiPanel44.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel44.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel44.Size = new System.Drawing.Size(1160, 35);
            this.uiPanel44.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel44.TabIndex = 16;
            this.uiPanel44.Text = null;
            this.uiPanel44.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel48
            // 
            this.uiPanel48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.Controls.Add(this.pan_TarTextEnable);
            this.uiPanel48.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel48.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel48.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel48.Location = new System.Drawing.Point(150, 0);
            this.uiPanel48.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel48.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel48.Name = "uiPanel48";
            this.uiPanel48.Opacity = ((byte)(180));
            this.uiPanel48.Padding = new System.Windows.Forms.Padding(20, 0, 0, 2);
            this.uiPanel48.Radius = 10;
            this.uiPanel48.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel48.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel48.Size = new System.Drawing.Size(1010, 35);
            this.uiPanel48.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel48.TabIndex = 21;
            this.uiPanel48.Text = null;
            this.uiPanel48.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_TarTextEnable
            // 
            this.pan_TarTextEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.Controls.Add(this.uiPanel169);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel168);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel167);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel166);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel165);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel164);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel53);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel54);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel46);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel52);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel49);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel50);
            this.pan_TarTextEnable.Controls.Add(this.uiPanel51);
            this.pan_TarTextEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_TarTextEnable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_TarTextEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_TarTextEnable.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_TarTextEnable.Location = new System.Drawing.Point(20, 0);
            this.pan_TarTextEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_TarTextEnable.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_TarTextEnable.Name = "pan_TarTextEnable";
            this.pan_TarTextEnable.Opacity = ((byte)(180));
            this.pan_TarTextEnable.Radius = 10;
            this.pan_TarTextEnable.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_TarTextEnable.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_TarTextEnable.Size = new System.Drawing.Size(990, 33);
            this.pan_TarTextEnable.Style = Sunny.UI.UIStyle.Custom;
            this.pan_TarTextEnable.TabIndex = 18;
            this.pan_TarTextEnable.Text = null;
            this.pan_TarTextEnable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel169
            // 
            this.uiPanel169.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.Controls.Add(this.cb_Confidence);
            this.uiPanel169.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel169.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel169.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel169.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel169.Location = new System.Drawing.Point(780, 0);
            this.uiPanel169.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel169.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel169.Name = "uiPanel169";
            this.uiPanel169.Opacity = ((byte)(180));
            this.uiPanel169.Radius = 10;
            this.uiPanel169.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel169.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel169.Size = new System.Drawing.Size(100, 33);
            this.uiPanel169.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel169.TabIndex = 21;
            this.uiPanel169.Text = null;
            this.uiPanel169.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Confidence
            // 
            this.cb_Confidence.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_Confidence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Confidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Confidence.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Confidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_Confidence.Location = new System.Drawing.Point(0, 0);
            this.cb_Confidence.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Confidence.Name = "cb_Confidence";
            this.cb_Confidence.Size = new System.Drawing.Size(100, 33);
            this.cb_Confidence.Style = Sunny.UI.UIStyle.Custom;
            this.cb_Confidence.TabIndex = 2;
            this.cb_Confidence.Text = "置信度(C)";
            this.cb_Confidence.CheckedChanged += new System.EventHandler(this.cb_Confidence_CheckedChanged);
            // 
            // uiPanel168
            // 
            this.uiPanel168.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel168.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel168.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel168.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel168.Location = new System.Drawing.Point(750, 0);
            this.uiPanel168.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel168.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel168.Name = "uiPanel168";
            this.uiPanel168.Opacity = ((byte)(180));
            this.uiPanel168.Radius = 10;
            this.uiPanel168.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel168.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel168.Size = new System.Drawing.Size(30, 33);
            this.uiPanel168.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel168.TabIndex = 20;
            this.uiPanel168.Text = null;
            this.uiPanel168.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel167
            // 
            this.uiPanel167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.Controls.Add(this.cb_AngleH);
            this.uiPanel167.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel167.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel167.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel167.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel167.Location = new System.Drawing.Point(650, 0);
            this.uiPanel167.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel167.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel167.Name = "uiPanel167";
            this.uiPanel167.Opacity = ((byte)(180));
            this.uiPanel167.Radius = 10;
            this.uiPanel167.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel167.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel167.Size = new System.Drawing.Size(100, 33);
            this.uiPanel167.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel167.TabIndex = 19;
            this.uiPanel167.Text = null;
            this.uiPanel167.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_AngleH
            // 
            this.cb_AngleH.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_AngleH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_AngleH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_AngleH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AngleH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_AngleH.Location = new System.Drawing.Point(0, 0);
            this.cb_AngleH.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_AngleH.Name = "cb_AngleH";
            this.cb_AngleH.Size = new System.Drawing.Size(100, 33);
            this.cb_AngleH.Style = Sunny.UI.UIStyle.Custom;
            this.cb_AngleH.TabIndex = 2;
            this.cb_AngleH.Text = "水平角度(A)";
            this.cb_AngleH.CheckedChanged += new System.EventHandler(this.cb_AngleH_CheckedChanged);
            // 
            // uiPanel166
            // 
            this.uiPanel166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel166.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel166.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel166.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel166.Location = new System.Drawing.Point(620, 0);
            this.uiPanel166.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel166.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel166.Name = "uiPanel166";
            this.uiPanel166.Opacity = ((byte)(180));
            this.uiPanel166.Radius = 10;
            this.uiPanel166.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel166.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel166.Size = new System.Drawing.Size(30, 33);
            this.uiPanel166.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel166.TabIndex = 18;
            this.uiPanel166.Text = null;
            this.uiPanel166.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel165
            // 
            this.uiPanel165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.Controls.Add(this.cb_Velocity);
            this.uiPanel165.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel165.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel165.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel165.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel165.Location = new System.Drawing.Point(520, 0);
            this.uiPanel165.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel165.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel165.Name = "uiPanel165";
            this.uiPanel165.Opacity = ((byte)(180));
            this.uiPanel165.Radius = 10;
            this.uiPanel165.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel165.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel165.Size = new System.Drawing.Size(100, 33);
            this.uiPanel165.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel165.TabIndex = 17;
            this.uiPanel165.Text = null;
            this.uiPanel165.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Velocity
            // 
            this.cb_Velocity.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_Velocity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Velocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Velocity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Velocity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_Velocity.Location = new System.Drawing.Point(0, 0);
            this.cb_Velocity.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Velocity.Name = "cb_Velocity";
            this.cb_Velocity.Size = new System.Drawing.Size(100, 33);
            this.cb_Velocity.Style = Sunny.UI.UIStyle.Custom;
            this.cb_Velocity.TabIndex = 2;
            this.cb_Velocity.Text = "目标速度(V)";
            this.cb_Velocity.CheckedChanged += new System.EventHandler(this.cb_Velocity_CheckedChanged);
            // 
            // uiPanel164
            // 
            this.uiPanel164.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel164.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel164.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel164.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel164.Location = new System.Drawing.Point(490, 0);
            this.uiPanel164.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel164.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel164.Name = "uiPanel164";
            this.uiPanel164.Opacity = ((byte)(180));
            this.uiPanel164.Radius = 10;
            this.uiPanel164.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel164.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel164.Size = new System.Drawing.Size(30, 33);
            this.uiPanel164.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel164.TabIndex = 16;
            this.uiPanel164.Text = null;
            this.uiPanel164.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel53
            // 
            this.uiPanel53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.Controls.Add(this.cb_Z);
            this.uiPanel53.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel53.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel53.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel53.Location = new System.Drawing.Point(390, 0);
            this.uiPanel53.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel53.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel53.Name = "uiPanel53";
            this.uiPanel53.Opacity = ((byte)(180));
            this.uiPanel53.Radius = 10;
            this.uiPanel53.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel53.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel53.Size = new System.Drawing.Size(100, 33);
            this.uiPanel53.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel53.TabIndex = 15;
            this.uiPanel53.Text = null;
            this.uiPanel53.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Z
            // 
            this.cb_Z.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_Z.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Z.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_Z.Location = new System.Drawing.Point(0, 0);
            this.cb_Z.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Z.Name = "cb_Z";
            this.cb_Z.Size = new System.Drawing.Size(100, 33);
            this.cb_Z.Style = Sunny.UI.UIStyle.Custom;
            this.cb_Z.TabIndex = 2;
            this.cb_Z.Text = "目标高度(Z)";
            this.cb_Z.CheckedChanged += new System.EventHandler(this.cb_Z_CheckedChanged);
            // 
            // uiPanel54
            // 
            this.uiPanel54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel54.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel54.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel54.Location = new System.Drawing.Point(360, 0);
            this.uiPanel54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel54.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel54.Name = "uiPanel54";
            this.uiPanel54.Opacity = ((byte)(180));
            this.uiPanel54.Radius = 10;
            this.uiPanel54.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel54.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel54.Size = new System.Drawing.Size(30, 33);
            this.uiPanel54.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel54.TabIndex = 14;
            this.uiPanel54.Text = null;
            this.uiPanel54.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel46
            // 
            this.uiPanel46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.Controls.Add(this.cb_Y);
            this.uiPanel46.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel46.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel46.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel46.Location = new System.Drawing.Point(260, 0);
            this.uiPanel46.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel46.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel46.Name = "uiPanel46";
            this.uiPanel46.Opacity = ((byte)(180));
            this.uiPanel46.Radius = 10;
            this.uiPanel46.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel46.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel46.Size = new System.Drawing.Size(100, 33);
            this.uiPanel46.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel46.TabIndex = 13;
            this.uiPanel46.Text = null;
            this.uiPanel46.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Y
            // 
            this.cb_Y.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_Y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Y.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_Y.Location = new System.Drawing.Point(0, 0);
            this.cb_Y.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_Y.Name = "cb_Y";
            this.cb_Y.Size = new System.Drawing.Size(100, 33);
            this.cb_Y.Style = Sunny.UI.UIStyle.Custom;
            this.cb_Y.TabIndex = 2;
            this.cb_Y.Text = "纵向距离(Y)";
            this.cb_Y.CheckedChanged += new System.EventHandler(this.cb_Y_CheckedChanged);
            // 
            // uiPanel52
            // 
            this.uiPanel52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel52.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel52.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel52.Location = new System.Drawing.Point(230, 0);
            this.uiPanel52.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel52.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel52.Name = "uiPanel52";
            this.uiPanel52.Opacity = ((byte)(180));
            this.uiPanel52.Radius = 10;
            this.uiPanel52.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel52.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel52.Size = new System.Drawing.Size(30, 33);
            this.uiPanel52.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel52.TabIndex = 12;
            this.uiPanel52.Text = null;
            this.uiPanel52.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel49
            // 
            this.uiPanel49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.Controls.Add(this.cb_X);
            this.uiPanel49.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel49.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel49.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel49.Location = new System.Drawing.Point(130, 0);
            this.uiPanel49.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel49.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel49.Name = "uiPanel49";
            this.uiPanel49.Opacity = ((byte)(180));
            this.uiPanel49.Radius = 10;
            this.uiPanel49.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel49.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel49.Size = new System.Drawing.Size(100, 33);
            this.uiPanel49.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel49.TabIndex = 11;
            this.uiPanel49.Text = null;
            this.uiPanel49.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_X
            // 
            this.cb_X.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_X.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_X.Location = new System.Drawing.Point(0, 0);
            this.cb_X.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_X.Name = "cb_X";
            this.cb_X.Size = new System.Drawing.Size(100, 33);
            this.cb_X.Style = Sunny.UI.UIStyle.Custom;
            this.cb_X.TabIndex = 2;
            this.cb_X.Text = "横向距离(X)";
            this.cb_X.CheckedChanged += new System.EventHandler(this.cb_X_CheckedChanged);
            // 
            // uiPanel50
            // 
            this.uiPanel50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel50.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel50.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel50.Location = new System.Drawing.Point(100, 0);
            this.uiPanel50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel50.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel50.Name = "uiPanel50";
            this.uiPanel50.Opacity = ((byte)(180));
            this.uiPanel50.Radius = 10;
            this.uiPanel50.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel50.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel50.Size = new System.Drawing.Size(30, 33);
            this.uiPanel50.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel50.TabIndex = 10;
            this.uiPanel50.Text = null;
            this.uiPanel50.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel51
            // 
            this.uiPanel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.Controls.Add(this.cb_ID);
            this.uiPanel51.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel51.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel51.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel51.Location = new System.Drawing.Point(0, 0);
            this.uiPanel51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel51.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel51.Name = "uiPanel51";
            this.uiPanel51.Opacity = ((byte)(180));
            this.uiPanel51.Radius = 10;
            this.uiPanel51.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel51.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel51.Size = new System.Drawing.Size(100, 33);
            this.uiPanel51.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel51.TabIndex = 9;
            this.uiPanel51.Text = null;
            this.uiPanel51.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_ID
            // 
            this.cb_ID.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_ID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_ID.Location = new System.Drawing.Point(0, 0);
            this.cb_ID.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(100, 33);
            this.cb_ID.Style = Sunny.UI.UIStyle.Custom;
            this.cb_ID.TabIndex = 1;
            this.cb_ID.Text = "目标编号(ID)";
            this.cb_ID.CheckedChanged += new System.EventHandler(this.cb_ID_CheckedChanged);
            // 
            // uiPanel105
            // 
            this.uiPanel105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel105.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel105.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel105.Location = new System.Drawing.Point(120, 0);
            this.uiPanel105.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel105.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel105.Name = "uiPanel105";
            this.uiPanel105.Opacity = ((byte)(180));
            this.uiPanel105.Radius = 10;
            this.uiPanel105.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel105.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel105.Size = new System.Drawing.Size(30, 33);
            this.uiPanel105.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel105.TabIndex = 20;
            this.uiPanel105.Text = null;
            this.uiPanel105.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel47
            // 
            this.uiPanel47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.Controls.Add(this.cb_DisplayTrackText);
            this.uiPanel47.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel47.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel47.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel47.Location = new System.Drawing.Point(0, 0);
            this.uiPanel47.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel47.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel47.Name = "uiPanel47";
            this.uiPanel47.Opacity = ((byte)(180));
            this.uiPanel47.Radius = 10;
            this.uiPanel47.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel47.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel47.Size = new System.Drawing.Size(120, 33);
            this.uiPanel47.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel47.TabIndex = 9;
            this.uiPanel47.Text = null;
            this.uiPanel47.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_DisplayTrackText
            // 
            this.cb_DisplayTrackText.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_DisplayTrackText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_DisplayTrackText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_DisplayTrackText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DisplayTrackText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_DisplayTrackText.Location = new System.Drawing.Point(0, 0);
            this.cb_DisplayTrackText.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_DisplayTrackText.Name = "cb_DisplayTrackText";
            this.cb_DisplayTrackText.Size = new System.Drawing.Size(120, 33);
            this.cb_DisplayTrackText.Style = Sunny.UI.UIStyle.Custom;
            this.cb_DisplayTrackText.TabIndex = 0;
            this.cb_DisplayTrackText.Text = "显示跟踪文本";
            this.cb_DisplayTrackText.CheckedChanged += new System.EventHandler(this.cb_DisplayTrackText_CheckedChanged);
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
            this.uiPanel42.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel42.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel42.TabIndex = 10;
            this.uiPanel42.Text = null;
            this.uiPanel42.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TextParams
            // 
            this.lb_TextParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_TextParams.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_TextParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_TextParams.Location = new System.Drawing.Point(10, 10);
            this.lb_TextParams.Name = "lb_TextParams";
            this.lb_TextParams.Size = new System.Drawing.Size(1160, 21);
            this.lb_TextParams.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TextParams.TabIndex = 1;
            this.lb_TextParams.Text = "跟踪文本参数";
            this.lb_TextParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel5.Location = new System.Drawing.Point(0, 505);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Opacity = ((byte)(180));
            this.uiPanel5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel5.Size = new System.Drawing.Size(1180, 10);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 29;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel99
            // 
            this.uiPanel99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.Controls.Add(this.uiPanel100);
            this.uiPanel99.Controls.Add(this.uiPanel111);
            this.uiPanel99.Controls.Add(this.lb_DataReplayParams);
            this.uiPanel99.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel99.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel99.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel99.Location = new System.Drawing.Point(0, 424);
            this.uiPanel99.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel99.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel99.Name = "uiPanel99";
            this.uiPanel99.Opacity = ((byte)(180));
            this.uiPanel99.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel99.Radius = 10;
            this.uiPanel99.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel99.Size = new System.Drawing.Size(1180, 81);
            this.uiPanel99.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel99.TabIndex = 26;
            this.uiPanel99.Text = null;
            this.uiPanel99.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel100
            // 
            this.uiPanel100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.Controls.Add(this.uiPanel101);
            this.uiPanel100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel100.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel100.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel100.Location = new System.Drawing.Point(10, 41);
            this.uiPanel100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel100.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel100.Name = "uiPanel100";
            this.uiPanel100.Opacity = ((byte)(180));
            this.uiPanel100.Radius = 10;
            this.uiPanel100.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel100.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel100.Size = new System.Drawing.Size(1160, 30);
            this.uiPanel100.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel100.TabIndex = 11;
            this.uiPanel100.Text = null;
            this.uiPanel100.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel101
            // 
            this.uiPanel101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.Controls.Add(this.uiPanel102);
            this.uiPanel101.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel101.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel101.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel101.Location = new System.Drawing.Point(0, 0);
            this.uiPanel101.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel101.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel101.Name = "uiPanel101";
            this.uiPanel101.Opacity = ((byte)(180));
            this.uiPanel101.Padding = new System.Windows.Forms.Padding(20, 0, 0, 2);
            this.uiPanel101.Radius = 10;
            this.uiPanel101.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel101.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel101.Size = new System.Drawing.Size(1160, 37);
            this.uiPanel101.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel101.TabIndex = 17;
            this.uiPanel101.Text = null;
            this.uiPanel101.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel102
            // 
            this.uiPanel102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.Controls.Add(this.uiPanel103);
            this.uiPanel102.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel102.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel102.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel102.Location = new System.Drawing.Point(20, 0);
            this.uiPanel102.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel102.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel102.Name = "uiPanel102";
            this.uiPanel102.Opacity = ((byte)(180));
            this.uiPanel102.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel102.Radius = 10;
            this.uiPanel102.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel102.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel102.Size = new System.Drawing.Size(1140, 35);
            this.uiPanel102.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel102.TabIndex = 18;
            this.uiPanel102.Text = null;
            this.uiPanel102.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel103
            // 
            this.uiPanel103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.Controls.Add(this.uiPanel109);
            this.uiPanel103.Controls.Add(this.uiPanel159);
            this.uiPanel103.Controls.Add(this.uiPanel107);
            this.uiPanel103.Controls.Add(this.uiPanel108);
            this.uiPanel103.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel103.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel103.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel103.Location = new System.Drawing.Point(0, 0);
            this.uiPanel103.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel103.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel103.Name = "uiPanel103";
            this.uiPanel103.Opacity = ((byte)(180));
            this.uiPanel103.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel103.Radius = 10;
            this.uiPanel103.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel103.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel103.Size = new System.Drawing.Size(1140, 35);
            this.uiPanel103.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel103.TabIndex = 16;
            this.uiPanel103.Text = null;
            this.uiPanel103.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel109
            // 
            this.uiPanel109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.Controls.Add(this.uiPanel110);
            this.uiPanel109.Controls.Add(this.uiPanel113);
            this.uiPanel109.Controls.Add(this.uiPanel114);
            this.uiPanel109.Controls.Add(this.uiPanel115);
            this.uiPanel109.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel109.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel109.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel109.Location = new System.Drawing.Point(735, 0);
            this.uiPanel109.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel109.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel109.Name = "uiPanel109";
            this.uiPanel109.Opacity = ((byte)(180));
            this.uiPanel109.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel109.Radius = 10;
            this.uiPanel109.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel109.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel109.Size = new System.Drawing.Size(405, 35);
            this.uiPanel109.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel109.TabIndex = 20;
            this.uiPanel109.Text = null;
            this.uiPanel109.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel110
            // 
            this.uiPanel110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel110.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel110.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel110.Location = new System.Drawing.Point(210, 0);
            this.uiPanel110.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel110.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel110.Name = "uiPanel110";
            this.uiPanel110.Opacity = ((byte)(180));
            this.uiPanel110.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel110.Radius = 10;
            this.uiPanel110.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel110.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel110.Size = new System.Drawing.Size(195, 33);
            this.uiPanel110.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel110.TabIndex = 19;
            this.uiPanel110.Text = null;
            this.uiPanel110.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel113
            // 
            this.uiPanel113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel113.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel113.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel113.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel113.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel113.Location = new System.Drawing.Point(200, 0);
            this.uiPanel113.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel113.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel113.Name = "uiPanel113";
            this.uiPanel113.Opacity = ((byte)(180));
            this.uiPanel113.Radius = 10;
            this.uiPanel113.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel113.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel113.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel113.Size = new System.Drawing.Size(10, 33);
            this.uiPanel113.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel113.TabIndex = 12;
            this.uiPanel113.Text = null;
            this.uiPanel113.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel114
            // 
            this.uiPanel114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.Controls.Add(this.uiLabel2);
            this.uiPanel114.Controls.Add(this.tb_FrameCycle);
            this.uiPanel114.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel114.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel114.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel114.Location = new System.Drawing.Point(100, 0);
            this.uiPanel114.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel114.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel114.Name = "uiPanel114";
            this.uiPanel114.Opacity = ((byte)(180));
            this.uiPanel114.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel114.Radius = 10;
            this.uiPanel114.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel114.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel114.Size = new System.Drawing.Size(100, 33);
            this.uiPanel114.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel114.TabIndex = 11;
            this.uiPanel114.Text = null;
            this.uiPanel114.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uiLabel2.Location = new System.Drawing.Point(65, 3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(29, 27);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "ms";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_FrameCycle
            // 
            this.tb_FrameCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_FrameCycle.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_FrameCycle.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_FrameCycle.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_FrameCycle.ButtonStyleInherited = false;
            this.tb_FrameCycle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_FrameCycle.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_FrameCycle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FrameCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_FrameCycle.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_FrameCycle.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_FrameCycle.Location = new System.Drawing.Point(0, 3);
            this.tb_FrameCycle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_FrameCycle.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_FrameCycle.Name = "tb_FrameCycle";
            this.tb_FrameCycle.Padding = new System.Windows.Forms.Padding(5);
            this.tb_FrameCycle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FrameCycle.ScrollBarStyleInherited = false;
            this.tb_FrameCycle.ShowText = false;
            this.tb_FrameCycle.Size = new System.Drawing.Size(65, 27);
            this.tb_FrameCycle.Style = Sunny.UI.UIStyle.Custom;
            this.tb_FrameCycle.TabIndex = 0;
            this.tb_FrameCycle.Text = "0";
            this.tb_FrameCycle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_FrameCycle.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_FrameCycle.Watermark = "";
            // 
            // uiPanel115
            // 
            this.uiPanel115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.Controls.Add(this.lb_FrameCycle);
            this.uiPanel115.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel115.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel115.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel115.Location = new System.Drawing.Point(0, 0);
            this.uiPanel115.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel115.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel115.Name = "uiPanel115";
            this.uiPanel115.Opacity = ((byte)(180));
            this.uiPanel115.Radius = 10;
            this.uiPanel115.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel115.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel115.Size = new System.Drawing.Size(100, 33);
            this.uiPanel115.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel115.TabIndex = 9;
            this.uiPanel115.Text = null;
            this.uiPanel115.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FrameCycle
            // 
            this.lb_FrameCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FrameCycle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FrameCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_FrameCycle.Location = new System.Drawing.Point(0, 0);
            this.lb_FrameCycle.Name = "lb_FrameCycle";
            this.lb_FrameCycle.Size = new System.Drawing.Size(100, 33);
            this.lb_FrameCycle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FrameCycle.TabIndex = 0;
            this.lb_FrameCycle.Text = "帧周期：";
            this.lb_FrameCycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel159
            // 
            this.uiPanel159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel159.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel159.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel159.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel159.Location = new System.Drawing.Point(705, 0);
            this.uiPanel159.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel159.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel159.Name = "uiPanel159";
            this.uiPanel159.Opacity = ((byte)(180));
            this.uiPanel159.Radius = 10;
            this.uiPanel159.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel159.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel159.Size = new System.Drawing.Size(30, 33);
            this.uiPanel159.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel159.TabIndex = 19;
            this.uiPanel159.Text = null;
            this.uiPanel159.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel107
            // 
            this.uiPanel107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.Controls.Add(this.cmb_ReplayDataFormat);
            this.uiPanel107.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel107.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel107.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel107.Location = new System.Drawing.Point(100, 0);
            this.uiPanel107.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel107.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel107.Name = "uiPanel107";
            this.uiPanel107.Opacity = ((byte)(180));
            this.uiPanel107.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel107.Radius = 10;
            this.uiPanel107.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel107.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel107.Size = new System.Drawing.Size(605, 33);
            this.uiPanel107.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel107.TabIndex = 11;
            this.uiPanel107.Text = null;
            this.uiPanel107.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ReplayDataFormat
            // 
            this.cmb_ReplayDataFormat.DataSource = null;
            this.cmb_ReplayDataFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ReplayDataFormat.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_ReplayDataFormat.DropDownWidth = 100;
            this.cmb_ReplayDataFormat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ReplayDataFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ReplayDataFormat.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_ReplayDataFormat.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ReplayDataFormat.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_ReplayDataFormat.Location = new System.Drawing.Point(0, 3);
            this.cmb_ReplayDataFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ReplayDataFormat.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_ReplayDataFormat.Name = "cmb_ReplayDataFormat";
            this.cmb_ReplayDataFormat.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_ReplayDataFormat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ReplayDataFormat.Size = new System.Drawing.Size(605, 27);
            this.cmb_ReplayDataFormat.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_ReplayDataFormat.SymbolSize = 24;
            this.cmb_ReplayDataFormat.TabIndex = 2;
            this.cmb_ReplayDataFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmb_ReplayDataFormat.Watermark = "";
            // 
            // uiPanel108
            // 
            this.uiPanel108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.Controls.Add(this.lb_ReplayDataFormat);
            this.uiPanel108.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel108.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel108.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel108.Location = new System.Drawing.Point(0, 0);
            this.uiPanel108.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel108.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel108.Name = "uiPanel108";
            this.uiPanel108.Opacity = ((byte)(180));
            this.uiPanel108.Radius = 10;
            this.uiPanel108.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel108.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel108.Size = new System.Drawing.Size(100, 33);
            this.uiPanel108.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel108.TabIndex = 9;
            this.uiPanel108.Text = null;
            this.uiPanel108.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ReplayDataFormat
            // 
            this.lb_ReplayDataFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ReplayDataFormat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ReplayDataFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ReplayDataFormat.Location = new System.Drawing.Point(0, 0);
            this.lb_ReplayDataFormat.Name = "lb_ReplayDataFormat";
            this.lb_ReplayDataFormat.Size = new System.Drawing.Size(100, 33);
            this.lb_ReplayDataFormat.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ReplayDataFormat.TabIndex = 0;
            this.lb_ReplayDataFormat.Text = "数据格式：";
            this.lb_ReplayDataFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel111
            // 
            this.uiPanel111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel111.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel111.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel111.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel111.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel111.Location = new System.Drawing.Point(10, 31);
            this.uiPanel111.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel111.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel111.Name = "uiPanel111";
            this.uiPanel111.Opacity = ((byte)(180));
            this.uiPanel111.Radius = 10;
            this.uiPanel111.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel111.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel111.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel111.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel111.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel111.TabIndex = 10;
            this.uiPanel111.Text = null;
            this.uiPanel111.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DataReplayParams
            // 
            this.lb_DataReplayParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_DataReplayParams.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_DataReplayParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_DataReplayParams.Location = new System.Drawing.Point(10, 10);
            this.lb_DataReplayParams.Name = "lb_DataReplayParams";
            this.lb_DataReplayParams.Size = new System.Drawing.Size(1160, 21);
            this.lb_DataReplayParams.Style = Sunny.UI.UIStyle.Custom;
            this.lb_DataReplayParams.TabIndex = 1;
            this.lb_DataReplayParams.Text = "数据回放参数";
            this.lb_DataReplayParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel98
            // 
            this.uiPanel98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel98.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel98.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel98.Location = new System.Drawing.Point(0, 414);
            this.uiPanel98.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel98.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel98.Name = "uiPanel98";
            this.uiPanel98.Opacity = ((byte)(180));
            this.uiPanel98.Radius = 10;
            this.uiPanel98.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel98.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel98.Size = new System.Drawing.Size(1180, 10);
            this.uiPanel98.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel98.TabIndex = 25;
            this.uiPanel98.Text = null;
            this.uiPanel98.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel58
            // 
            this.uiPanel58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.Controls.Add(this.uiPanel77);
            this.uiPanel58.Controls.Add(this.uiPanel90);
            this.uiPanel58.Controls.Add(this.lb_SaveDataParams);
            this.uiPanel58.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel58.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel58.Location = new System.Drawing.Point(0, 332);
            this.uiPanel58.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel58.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel58.Name = "uiPanel58";
            this.uiPanel58.Opacity = ((byte)(180));
            this.uiPanel58.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel58.Radius = 10;
            this.uiPanel58.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel58.Size = new System.Drawing.Size(1180, 82);
            this.uiPanel58.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel58.TabIndex = 18;
            this.uiPanel58.Text = null;
            this.uiPanel58.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel77
            // 
            this.uiPanel77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.Controls.Add(this.uiPanel87);
            this.uiPanel77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel77.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel77.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel77.Location = new System.Drawing.Point(10, 41);
            this.uiPanel77.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel77.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel77.Name = "uiPanel77";
            this.uiPanel77.Opacity = ((byte)(180));
            this.uiPanel77.Radius = 10;
            this.uiPanel77.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel77.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel77.Size = new System.Drawing.Size(1160, 31);
            this.uiPanel77.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel77.TabIndex = 11;
            this.uiPanel77.Text = null;
            this.uiPanel77.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel87
            // 
            this.uiPanel87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.Controls.Add(this.uiPanel78);
            this.uiPanel87.Controls.Add(this.uiPanel106);
            this.uiPanel87.Controls.Add(this.uiPanel89);
            this.uiPanel87.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.uiPanel87.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel87.Radius = 10;
            this.uiPanel87.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel87.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel87.Size = new System.Drawing.Size(1160, 35);
            this.uiPanel87.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel87.TabIndex = 16;
            this.uiPanel87.Text = null;
            this.uiPanel87.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel78
            // 
            this.uiPanel78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.Controls.Add(this.uiPanel79);
            this.uiPanel78.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel78.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel78.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel78.Location = new System.Drawing.Point(130, 0);
            this.uiPanel78.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel78.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel78.Name = "uiPanel78";
            this.uiPanel78.Opacity = ((byte)(180));
            this.uiPanel78.Padding = new System.Windows.Forms.Padding(20, 0, 0, 2);
            this.uiPanel78.Radius = 10;
            this.uiPanel78.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel78.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel78.Size = new System.Drawing.Size(1030, 37);
            this.uiPanel78.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel78.TabIndex = 21;
            this.uiPanel78.Text = null;
            this.uiPanel78.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel79
            // 
            this.uiPanel79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.Controls.Add(this.uiPanel80);
            this.uiPanel79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel79.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel79.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel79.Location = new System.Drawing.Point(20, 0);
            this.uiPanel79.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel79.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel79.Name = "uiPanel79";
            this.uiPanel79.Opacity = ((byte)(180));
            this.uiPanel79.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel79.Radius = 10;
            this.uiPanel79.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel79.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel79.Size = new System.Drawing.Size(1010, 35);
            this.uiPanel79.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel79.TabIndex = 18;
            this.uiPanel79.Text = null;
            this.uiPanel79.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel80
            // 
            this.uiPanel80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.Controls.Add(this.uiPanel85);
            this.uiPanel80.Controls.Add(this.uiPanel82);
            this.uiPanel80.Controls.Add(this.uiPanel84);
            this.uiPanel80.Controls.Add(this.uiPanel81);
            this.uiPanel80.Controls.Add(this.uiPanel83);
            this.uiPanel80.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel80.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel80.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel80.Location = new System.Drawing.Point(0, 0);
            this.uiPanel80.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel80.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel80.Name = "uiPanel80";
            this.uiPanel80.Opacity = ((byte)(180));
            this.uiPanel80.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel80.Radius = 10;
            this.uiPanel80.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel80.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel80.Size = new System.Drawing.Size(1010, 35);
            this.uiPanel80.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel80.TabIndex = 16;
            this.uiPanel80.Text = null;
            this.uiPanel80.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel85
            // 
            this.uiPanel85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.Controls.Add(this.tb_FilePath);
            this.uiPanel85.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel85.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel85.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel85.Location = new System.Drawing.Point(230, 0);
            this.uiPanel85.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel85.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel85.Name = "uiPanel85";
            this.uiPanel85.Opacity = ((byte)(180));
            this.uiPanel85.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel85.Radius = 10;
            this.uiPanel85.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel85.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel85.Size = new System.Drawing.Size(780, 33);
            this.uiPanel85.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel85.TabIndex = 19;
            this.uiPanel85.Text = null;
            this.uiPanel85.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_FilePath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_FilePath.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tb_FilePath.Location = new System.Drawing.Point(0, 3);
            this.tb_FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_FilePath.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Padding = new System.Windows.Forms.Padding(2);
            this.tb_FilePath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FilePath.ScrollBarStyleInherited = false;
            this.tb_FilePath.ShowText = false;
            this.tb_FilePath.Size = new System.Drawing.Size(780, 27);
            this.tb_FilePath.Style = Sunny.UI.UIStyle.Custom;
            this.tb_FilePath.TabIndex = 11;
            this.tb_FilePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_FilePath.DoubleClick += new System.EventHandler(this.tb_FilePath_DoubleClick);
            // 
            // uiPanel82
            // 
            this.uiPanel82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel82.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel82.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel82.Location = new System.Drawing.Point(200, 0);
            this.uiPanel82.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel82.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel82.Name = "uiPanel82";
            this.uiPanel82.Opacity = ((byte)(180));
            this.uiPanel82.Radius = 10;
            this.uiPanel82.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel82.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel82.Size = new System.Drawing.Size(30, 33);
            this.uiPanel82.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel82.TabIndex = 18;
            this.uiPanel82.Text = null;
            this.uiPanel82.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel84
            // 
            this.uiPanel84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel84.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel84.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel84.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel84.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel84.Location = new System.Drawing.Point(190, 0);
            this.uiPanel84.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel84.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel84.Name = "uiPanel84";
            this.uiPanel84.Opacity = ((byte)(180));
            this.uiPanel84.Radius = 10;
            this.uiPanel84.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel84.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel84.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel84.Size = new System.Drawing.Size(10, 33);
            this.uiPanel84.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel84.TabIndex = 12;
            this.uiPanel84.Text = null;
            this.uiPanel84.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel81
            // 
            this.uiPanel81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.Controls.Add(this.lb_FileSizeUnit);
            this.uiPanel81.Controls.Add(this.tb_FileSize);
            this.uiPanel81.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel81.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel81.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel81.Location = new System.Drawing.Point(100, 0);
            this.uiPanel81.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel81.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel81.Name = "uiPanel81";
            this.uiPanel81.Opacity = ((byte)(180));
            this.uiPanel81.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel81.Radius = 10;
            this.uiPanel81.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel81.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel81.Size = new System.Drawing.Size(90, 33);
            this.uiPanel81.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel81.TabIndex = 11;
            this.uiPanel81.Text = null;
            this.uiPanel81.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lb_FileSizeUnit
            // 
            this.lb_FileSizeUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_FileSizeUnit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FileSizeUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_FileSizeUnit.Location = new System.Drawing.Point(65, 3);
            this.lb_FileSizeUnit.Name = "lb_FileSizeUnit";
            this.lb_FileSizeUnit.Size = new System.Drawing.Size(18, 27);
            this.lb_FileSizeUnit.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FileSizeUnit.TabIndex = 1;
            this.lb_FileSizeUnit.Text = "M";
            this.lb_FileSizeUnit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_FileSize
            // 
            this.tb_FileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_FileSize.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_FileSize.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_FileSize.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_FileSize.ButtonStyleInherited = false;
            this.tb_FileSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_FileSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_FileSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_FileSize.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_FileSize.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_FileSize.Location = new System.Drawing.Point(0, 3);
            this.tb_FileSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_FileSize.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_FileSize.Name = "tb_FileSize";
            this.tb_FileSize.Padding = new System.Windows.Forms.Padding(5);
            this.tb_FileSize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_FileSize.ScrollBarStyleInherited = false;
            this.tb_FileSize.ShowText = false;
            this.tb_FileSize.Size = new System.Drawing.Size(65, 27);
            this.tb_FileSize.Style = Sunny.UI.UIStyle.Custom;
            this.tb_FileSize.TabIndex = 0;
            this.tb_FileSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_FileSize.Watermark = "";
            // 
            // uiPanel83
            // 
            this.uiPanel83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.Controls.Add(this.lb_FileSize);
            this.uiPanel83.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel83.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel83.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel83.Location = new System.Drawing.Point(0, 0);
            this.uiPanel83.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel83.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel83.Name = "uiPanel83";
            this.uiPanel83.Opacity = ((byte)(180));
            this.uiPanel83.Radius = 10;
            this.uiPanel83.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel83.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel83.Size = new System.Drawing.Size(100, 33);
            this.uiPanel83.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel83.TabIndex = 9;
            this.uiPanel83.Text = null;
            this.uiPanel83.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FileSize
            // 
            this.lb_FileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_FileSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_FileSize.Location = new System.Drawing.Point(0, 0);
            this.lb_FileSize.Name = "lb_FileSize";
            this.lb_FileSize.Size = new System.Drawing.Size(100, 33);
            this.lb_FileSize.Style = Sunny.UI.UIStyle.Custom;
            this.lb_FileSize.TabIndex = 0;
            this.lb_FileSize.Text = "文本大小：";
            this.lb_FileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel106
            // 
            this.uiPanel106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel106.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel106.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel106.Location = new System.Drawing.Point(100, 0);
            this.uiPanel106.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel106.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel106.Name = "uiPanel106";
            this.uiPanel106.Opacity = ((byte)(180));
            this.uiPanel106.Radius = 10;
            this.uiPanel106.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel106.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel106.Size = new System.Drawing.Size(30, 33);
            this.uiPanel106.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel106.TabIndex = 20;
            this.uiPanel106.Text = null;
            this.uiPanel106.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel89
            // 
            this.uiPanel89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.Controls.Add(this.cb_TargetSave);
            this.uiPanel89.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel89.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel89.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel89.Location = new System.Drawing.Point(0, 0);
            this.uiPanel89.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel89.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel89.Name = "uiPanel89";
            this.uiPanel89.Opacity = ((byte)(180));
            this.uiPanel89.Radius = 10;
            this.uiPanel89.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel89.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel89.Size = new System.Drawing.Size(100, 33);
            this.uiPanel89.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel89.TabIndex = 9;
            this.uiPanel89.Text = null;
            this.uiPanel89.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TargetSave
            // 
            this.cb_TargetSave.CheckBoxColor = System.Drawing.Color.Red;
            this.cb_TargetSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_TargetSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_TargetSave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TargetSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cb_TargetSave.Location = new System.Drawing.Point(0, 0);
            this.cb_TargetSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.cb_TargetSave.Name = "cb_TargetSave";
            this.cb_TargetSave.Size = new System.Drawing.Size(100, 33);
            this.cb_TargetSave.Style = Sunny.UI.UIStyle.Custom;
            this.cb_TargetSave.TabIndex = 0;
            this.cb_TargetSave.Text = "存储使能";
            this.cb_TargetSave.CheckedChanged += new System.EventHandler(this.cb_TargetSave_CheckedChanged);
            // 
            // uiPanel90
            // 
            this.uiPanel90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel90.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel90.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel90.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel90.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel90.Location = new System.Drawing.Point(10, 31);
            this.uiPanel90.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel90.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel90.Name = "uiPanel90";
            this.uiPanel90.Opacity = ((byte)(180));
            this.uiPanel90.Radius = 10;
            this.uiPanel90.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel90.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel90.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel90.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel90.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel90.TabIndex = 10;
            this.uiPanel90.Text = null;
            this.uiPanel90.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_SaveDataParams
            // 
            this.lb_SaveDataParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_SaveDataParams.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_SaveDataParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_SaveDataParams.Location = new System.Drawing.Point(10, 10);
            this.lb_SaveDataParams.Name = "lb_SaveDataParams";
            this.lb_SaveDataParams.Size = new System.Drawing.Size(1160, 21);
            this.lb_SaveDataParams.Style = Sunny.UI.UIStyle.Custom;
            this.lb_SaveDataParams.TabIndex = 1;
            this.lb_SaveDataParams.Text = "目标存储参数";
            this.lb_SaveDataParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel88.Location = new System.Drawing.Point(0, 322);
            this.uiPanel88.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel88.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel88.Name = "uiPanel88";
            this.uiPanel88.Opacity = ((byte)(180));
            this.uiPanel88.Radius = 10;
            this.uiPanel88.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel88.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel88.Size = new System.Drawing.Size(1180, 10);
            this.uiPanel88.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel88.TabIndex = 17;
            this.uiPanel88.Text = null;
            this.uiPanel88.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_ControlArea
            // 
            this.pan_ControlArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Controls.Add(this.uiPanel10);
            this.pan_ControlArea.Controls.Add(this.uiPanel7);
            this.pan_ControlArea.Controls.Add(this.uiPanel8);
            this.pan_ControlArea.Controls.Add(this.lb_ColorTitle);
            this.pan_ControlArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ControlArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_ControlArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_ControlArea.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_ControlArea.Location = new System.Drawing.Point(0, 235);
            this.pan_ControlArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_ControlArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_ControlArea.Name = "pan_ControlArea";
            this.pan_ControlArea.Opacity = ((byte)(180));
            this.pan_ControlArea.Padding = new System.Windows.Forms.Padding(10);
            this.pan_ControlArea.Radius = 10;
            this.pan_ControlArea.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_ControlArea.Size = new System.Drawing.Size(1180, 87);
            this.pan_ControlArea.Style = Sunny.UI.UIStyle.Custom;
            this.pan_ControlArea.TabIndex = 14;
            this.pan_ControlArea.Text = null;
            this.pan_ControlArea.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel10
            // 
            this.uiPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel10.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel10.Location = new System.Drawing.Point(10, 76);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Opacity = ((byte)(180));
            this.uiPanel10.Radius = 10;
            this.uiPanel10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel10.TabIndex = 20;
            this.uiPanel10.Text = null;
            this.uiPanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            this.uiPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Controls.Add(this.pan_HeightColor);
            this.uiPanel7.Controls.Add(this.uiPanel140);
            this.uiPanel7.Controls.Add(this.uiPanel12);
            this.uiPanel7.Controls.Add(this.uiPanel11);
            this.uiPanel7.Controls.Add(this.uiPanel9);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel7.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel7.Location = new System.Drawing.Point(10, 41);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Opacity = ((byte)(180));
            this.uiPanel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel7.Radius = 10;
            this.uiPanel7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel7.Size = new System.Drawing.Size(1160, 35);
            this.uiPanel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel7.TabIndex = 19;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_HeightColor
            // 
            this.pan_HeightColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.Controls.Add(this.uiPanel57);
            this.pan_HeightColor.Controls.Add(this.uiPanel56);
            this.pan_HeightColor.Controls.Add(this.uiPanel55);
            this.pan_HeightColor.Controls.Add(this.uiPanel41);
            this.pan_HeightColor.Controls.Add(this.uiPanel40);
            this.pan_HeightColor.Controls.Add(this.uiPanel39);
            this.pan_HeightColor.Controls.Add(this.uiPanel38);
            this.pan_HeightColor.Controls.Add(this.uiPanel37);
            this.pan_HeightColor.Controls.Add(this.uiPanel16);
            this.pan_HeightColor.Controls.Add(this.uiPanel15);
            this.pan_HeightColor.Controls.Add(this.uiPanel14);
            this.pan_HeightColor.Controls.Add(this.uiPanel13);
            this.pan_HeightColor.Controls.Add(this.pan_Purple);
            this.pan_HeightColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_HeightColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_HeightColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_HeightColor.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_HeightColor.Location = new System.Drawing.Point(302, 0);
            this.pan_HeightColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_HeightColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_HeightColor.Name = "pan_HeightColor";
            this.pan_HeightColor.Opacity = ((byte)(180));
            this.pan_HeightColor.Radius = 10;
            this.pan_HeightColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_HeightColor.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_HeightColor.Size = new System.Drawing.Size(858, 35);
            this.pan_HeightColor.Style = Sunny.UI.UIStyle.Custom;
            this.pan_HeightColor.TabIndex = 23;
            this.pan_HeightColor.Text = null;
            this.pan_HeightColor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel57
            // 
            this.uiPanel57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.Controls.Add(this.color_Red);
            this.uiPanel57.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel57.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel57.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel57.Location = new System.Drawing.Point(665, 0);
            this.uiPanel57.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel57.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel57.Name = "uiPanel57";
            this.uiPanel57.Opacity = ((byte)(180));
            this.uiPanel57.Radius = 10;
            this.uiPanel57.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel57.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel57.Size = new System.Drawing.Size(60, 35);
            this.uiPanel57.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel57.TabIndex = 23;
            this.uiPanel57.Text = null;
            this.uiPanel57.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Red
            // 
            this.color_Red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Red.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Red.ForeColor = System.Drawing.Color.Black;
            this.color_Red.ItemWidth = 151;
            this.color_Red.Location = new System.Drawing.Point(0, 0);
            this.color_Red.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Red.Name = "color_Red";
            this.color_Red.SelectedColor = System.Drawing.Color.Red;
            this.color_Red.Size = new System.Drawing.Size(60, 35);
            this.color_Red.Style = Sunny.UI.UIStyle.Custom;
            this.color_Red.TabIndex = 10;
            this.color_Red.Text = "红";
            this.color_Red.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel56
            // 
            this.uiPanel56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.Controls.Add(this.tb_RedValue);
            this.uiPanel56.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel56.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel56.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel56.Location = new System.Drawing.Point(614, 0);
            this.uiPanel56.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel56.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel56.Name = "uiPanel56";
            this.uiPanel56.Opacity = ((byte)(180));
            this.uiPanel56.Radius = 10;
            this.uiPanel56.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel56.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel56.Size = new System.Drawing.Size(51, 35);
            this.uiPanel56.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel56.TabIndex = 22;
            this.uiPanel56.Text = null;
            this.uiPanel56.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_RedValue
            // 
            this.tb_RedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_RedValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_RedValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_RedValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_RedValue.ButtonStyleInherited = false;
            this.tb_RedValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_RedValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_RedValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_RedValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_RedValue.Location = new System.Drawing.Point(0, 0);
            this.tb_RedValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RedValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_RedValue.Name = "tb_RedValue";
            this.tb_RedValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_RedValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_RedValue.ScrollBarStyleInherited = false;
            this.tb_RedValue.ShowText = false;
            this.tb_RedValue.Size = new System.Drawing.Size(51, 35);
            this.tb_RedValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_RedValue.TabIndex = 2;
            this.tb_RedValue.Text = "0";
            this.tb_RedValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_RedValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_RedValue.Watermark = "";
            // 
            // uiPanel55
            // 
            this.uiPanel55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.Controls.Add(this.color_Orange);
            this.uiPanel55.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel55.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel55.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel55.Location = new System.Drawing.Point(554, 0);
            this.uiPanel55.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel55.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel55.Name = "uiPanel55";
            this.uiPanel55.Opacity = ((byte)(180));
            this.uiPanel55.Radius = 10;
            this.uiPanel55.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel55.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel55.Size = new System.Drawing.Size(60, 35);
            this.uiPanel55.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel55.TabIndex = 21;
            this.uiPanel55.Text = null;
            this.uiPanel55.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Orange
            // 
            this.color_Orange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Orange.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Orange.ForeColor = System.Drawing.Color.Black;
            this.color_Orange.ItemWidth = 151;
            this.color_Orange.Location = new System.Drawing.Point(0, 0);
            this.color_Orange.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Orange.Name = "color_Orange";
            this.color_Orange.SelectedColor = System.Drawing.Color.Orange;
            this.color_Orange.Size = new System.Drawing.Size(60, 35);
            this.color_Orange.Style = Sunny.UI.UIStyle.Custom;
            this.color_Orange.TabIndex = 10;
            this.color_Orange.Text = "橙";
            this.color_Orange.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel41
            // 
            this.uiPanel41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.Controls.Add(this.tb_OrangeValue);
            this.uiPanel41.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel41.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel41.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel41.Location = new System.Drawing.Point(503, 0);
            this.uiPanel41.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel41.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel41.Name = "uiPanel41";
            this.uiPanel41.Opacity = ((byte)(180));
            this.uiPanel41.Radius = 10;
            this.uiPanel41.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel41.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel41.Size = new System.Drawing.Size(51, 35);
            this.uiPanel41.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel41.TabIndex = 20;
            this.uiPanel41.Text = null;
            this.uiPanel41.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_OrangeValue
            // 
            this.tb_OrangeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_OrangeValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_OrangeValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_OrangeValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_OrangeValue.ButtonStyleInherited = false;
            this.tb_OrangeValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_OrangeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_OrangeValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_OrangeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_OrangeValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_OrangeValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_OrangeValue.Location = new System.Drawing.Point(0, 0);
            this.tb_OrangeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_OrangeValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_OrangeValue.Name = "tb_OrangeValue";
            this.tb_OrangeValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_OrangeValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_OrangeValue.ScrollBarStyleInherited = false;
            this.tb_OrangeValue.ShowText = false;
            this.tb_OrangeValue.Size = new System.Drawing.Size(51, 35);
            this.tb_OrangeValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_OrangeValue.TabIndex = 2;
            this.tb_OrangeValue.Text = "0";
            this.tb_OrangeValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_OrangeValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_OrangeValue.Watermark = "";
            // 
            // uiPanel40
            // 
            this.uiPanel40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.Controls.Add(this.color_Yellow);
            this.uiPanel40.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel40.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel40.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel40.Location = new System.Drawing.Point(443, 0);
            this.uiPanel40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel40.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel40.Name = "uiPanel40";
            this.uiPanel40.Opacity = ((byte)(180));
            this.uiPanel40.Radius = 10;
            this.uiPanel40.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel40.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel40.Size = new System.Drawing.Size(60, 35);
            this.uiPanel40.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel40.TabIndex = 19;
            this.uiPanel40.Text = null;
            this.uiPanel40.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Yellow
            // 
            this.color_Yellow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Yellow.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Yellow.ForeColor = System.Drawing.Color.Black;
            this.color_Yellow.ItemWidth = 151;
            this.color_Yellow.Location = new System.Drawing.Point(0, 0);
            this.color_Yellow.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Yellow.Name = "color_Yellow";
            this.color_Yellow.SelectedColor = System.Drawing.Color.Yellow;
            this.color_Yellow.Size = new System.Drawing.Size(60, 35);
            this.color_Yellow.Style = Sunny.UI.UIStyle.Custom;
            this.color_Yellow.TabIndex = 10;
            this.color_Yellow.Text = "黄";
            this.color_Yellow.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel39
            // 
            this.uiPanel39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.Controls.Add(this.tb_YellowValue);
            this.uiPanel39.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel39.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel39.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel39.Location = new System.Drawing.Point(392, 0);
            this.uiPanel39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel39.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel39.Name = "uiPanel39";
            this.uiPanel39.Opacity = ((byte)(180));
            this.uiPanel39.Radius = 10;
            this.uiPanel39.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel39.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel39.Size = new System.Drawing.Size(51, 35);
            this.uiPanel39.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel39.TabIndex = 18;
            this.uiPanel39.Text = null;
            this.uiPanel39.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_YellowValue
            // 
            this.tb_YellowValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YellowValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_YellowValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_YellowValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_YellowValue.ButtonStyleInherited = false;
            this.tb_YellowValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_YellowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_YellowValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_YellowValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YellowValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YellowValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YellowValue.Location = new System.Drawing.Point(0, 0);
            this.tb_YellowValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_YellowValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_YellowValue.Name = "tb_YellowValue";
            this.tb_YellowValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_YellowValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YellowValue.ScrollBarStyleInherited = false;
            this.tb_YellowValue.ShowText = false;
            this.tb_YellowValue.Size = new System.Drawing.Size(51, 35);
            this.tb_YellowValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_YellowValue.TabIndex = 2;
            this.tb_YellowValue.Text = "0";
            this.tb_YellowValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_YellowValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_YellowValue.Watermark = "";
            // 
            // uiPanel38
            // 
            this.uiPanel38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.Controls.Add(this.color_Green);
            this.uiPanel38.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel38.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel38.Location = new System.Drawing.Point(332, 0);
            this.uiPanel38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel38.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel38.Name = "uiPanel38";
            this.uiPanel38.Opacity = ((byte)(180));
            this.uiPanel38.Radius = 10;
            this.uiPanel38.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel38.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel38.Size = new System.Drawing.Size(60, 35);
            this.uiPanel38.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel38.TabIndex = 17;
            this.uiPanel38.Text = null;
            this.uiPanel38.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Green
            // 
            this.color_Green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Green.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Green.ForeColor = System.Drawing.Color.Black;
            this.color_Green.ItemWidth = 151;
            this.color_Green.Location = new System.Drawing.Point(0, 0);
            this.color_Green.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Green.Name = "color_Green";
            this.color_Green.SelectedColor = System.Drawing.Color.Green;
            this.color_Green.Size = new System.Drawing.Size(60, 35);
            this.color_Green.Style = Sunny.UI.UIStyle.Custom;
            this.color_Green.TabIndex = 10;
            this.color_Green.Text = "绿";
            this.color_Green.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel37
            // 
            this.uiPanel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.Controls.Add(this.tb_GreenValue);
            this.uiPanel37.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel37.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel37.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel37.Location = new System.Drawing.Point(281, 0);
            this.uiPanel37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel37.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel37.Name = "uiPanel37";
            this.uiPanel37.Opacity = ((byte)(180));
            this.uiPanel37.Radius = 10;
            this.uiPanel37.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel37.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel37.Size = new System.Drawing.Size(51, 35);
            this.uiPanel37.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel37.TabIndex = 16;
            this.uiPanel37.Text = null;
            this.uiPanel37.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_GreenValue
            // 
            this.tb_GreenValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_GreenValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_GreenValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_GreenValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_GreenValue.ButtonStyleInherited = false;
            this.tb_GreenValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GreenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_GreenValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GreenValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_GreenValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_GreenValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_GreenValue.Location = new System.Drawing.Point(0, 0);
            this.tb_GreenValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_GreenValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_GreenValue.Name = "tb_GreenValue";
            this.tb_GreenValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_GreenValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_GreenValue.ScrollBarStyleInherited = false;
            this.tb_GreenValue.ShowText = false;
            this.tb_GreenValue.Size = new System.Drawing.Size(51, 35);
            this.tb_GreenValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_GreenValue.TabIndex = 2;
            this.tb_GreenValue.Text = "0";
            this.tb_GreenValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_GreenValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_GreenValue.Watermark = "";
            // 
            // uiPanel16
            // 
            this.uiPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Controls.Add(this.color_Cyan);
            this.uiPanel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel16.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel16.Location = new System.Drawing.Point(221, 0);
            this.uiPanel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel16.Name = "uiPanel16";
            this.uiPanel16.Opacity = ((byte)(180));
            this.uiPanel16.Radius = 10;
            this.uiPanel16.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel16.Size = new System.Drawing.Size(60, 35);
            this.uiPanel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel16.TabIndex = 15;
            this.uiPanel16.Text = null;
            this.uiPanel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Cyan
            // 
            this.color_Cyan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Cyan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Cyan.ForeColor = System.Drawing.Color.Black;
            this.color_Cyan.ItemWidth = 151;
            this.color_Cyan.Location = new System.Drawing.Point(0, 0);
            this.color_Cyan.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Cyan.Name = "color_Cyan";
            this.color_Cyan.SelectedColor = System.Drawing.Color.Cyan;
            this.color_Cyan.Size = new System.Drawing.Size(60, 35);
            this.color_Cyan.Style = Sunny.UI.UIStyle.Custom;
            this.color_Cyan.TabIndex = 10;
            this.color_Cyan.Text = "青";
            this.color_Cyan.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel15
            // 
            this.uiPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Controls.Add(this.tb_CyanValue);
            this.uiPanel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel15.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel15.Location = new System.Drawing.Point(170, 0);
            this.uiPanel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel15.Name = "uiPanel15";
            this.uiPanel15.Opacity = ((byte)(180));
            this.uiPanel15.Radius = 10;
            this.uiPanel15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel15.Size = new System.Drawing.Size(51, 35);
            this.uiPanel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel15.TabIndex = 14;
            this.uiPanel15.Text = null;
            this.uiPanel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CyanValue
            // 
            this.tb_CyanValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_CyanValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_CyanValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_CyanValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_CyanValue.ButtonStyleInherited = false;
            this.tb_CyanValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CyanValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CyanValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CyanValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_CyanValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CyanValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CyanValue.Location = new System.Drawing.Point(0, 0);
            this.tb_CyanValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_CyanValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_CyanValue.Name = "tb_CyanValue";
            this.tb_CyanValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_CyanValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CyanValue.ScrollBarStyleInherited = false;
            this.tb_CyanValue.ShowText = false;
            this.tb_CyanValue.Size = new System.Drawing.Size(51, 35);
            this.tb_CyanValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_CyanValue.TabIndex = 2;
            this.tb_CyanValue.Text = "0";
            this.tb_CyanValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_CyanValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_CyanValue.Watermark = "";
            // 
            // uiPanel14
            // 
            this.uiPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.Controls.Add(this.color_Blue);
            this.uiPanel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel14.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel14.Location = new System.Drawing.Point(110, 0);
            this.uiPanel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel14.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel14.Name = "uiPanel14";
            this.uiPanel14.Opacity = ((byte)(180));
            this.uiPanel14.Radius = 10;
            this.uiPanel14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel14.Size = new System.Drawing.Size(60, 35);
            this.uiPanel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel14.TabIndex = 13;
            this.uiPanel14.Text = null;
            this.uiPanel14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Blue
            // 
            this.color_Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Blue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Blue.ForeColor = System.Drawing.Color.Black;
            this.color_Blue.ItemWidth = 151;
            this.color_Blue.Location = new System.Drawing.Point(0, 0);
            this.color_Blue.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Blue.Name = "color_Blue";
            this.color_Blue.SelectedColor = System.Drawing.Color.Blue;
            this.color_Blue.Size = new System.Drawing.Size(60, 35);
            this.color_Blue.Style = Sunny.UI.UIStyle.Custom;
            this.color_Blue.TabIndex = 10;
            this.color_Blue.Text = "蓝";
            this.color_Blue.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel13
            // 
            this.uiPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.Controls.Add(this.tb_BlueValue);
            this.uiPanel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel13.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel13.Location = new System.Drawing.Point(60, 0);
            this.uiPanel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel13.Name = "uiPanel13";
            this.uiPanel13.Opacity = ((byte)(180));
            this.uiPanel13.Radius = 10;
            this.uiPanel13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel13.Size = new System.Drawing.Size(50, 35);
            this.uiPanel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel13.TabIndex = 12;
            this.uiPanel13.Text = null;
            this.uiPanel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_BlueValue
            // 
            this.tb_BlueValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_BlueValue.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_BlueValue.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_BlueValue.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_BlueValue.ButtonStyleInherited = false;
            this.tb_BlueValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_BlueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_BlueValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BlueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_BlueValue.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_BlueValue.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_BlueValue.Location = new System.Drawing.Point(0, 0);
            this.tb_BlueValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_BlueValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_BlueValue.Name = "tb_BlueValue";
            this.tb_BlueValue.Padding = new System.Windows.Forms.Padding(5);
            this.tb_BlueValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_BlueValue.ScrollBarStyleInherited = false;
            this.tb_BlueValue.ShowText = false;
            this.tb_BlueValue.Size = new System.Drawing.Size(50, 35);
            this.tb_BlueValue.Style = Sunny.UI.UIStyle.Custom;
            this.tb_BlueValue.TabIndex = 2;
            this.tb_BlueValue.Text = "0";
            this.tb_BlueValue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_BlueValue.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_BlueValue.Watermark = "";
            // 
            // pan_Purple
            // 
            this.pan_Purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.Controls.Add(this.color_Purple);
            this.pan_Purple.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_Purple.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Purple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Purple.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Purple.Location = new System.Drawing.Point(0, 0);
            this.pan_Purple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Purple.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Purple.Name = "pan_Purple";
            this.pan_Purple.Opacity = ((byte)(180));
            this.pan_Purple.Radius = 10;
            this.pan_Purple.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Purple.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Purple.Size = new System.Drawing.Size(60, 35);
            this.pan_Purple.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Purple.TabIndex = 9;
            this.pan_Purple.Text = null;
            this.pan_Purple.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // color_Purple
            // 
            this.color_Purple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color_Purple.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_Purple.ForeColor = System.Drawing.Color.Black;
            this.color_Purple.ItemWidth = 151;
            this.color_Purple.Location = new System.Drawing.Point(0, 0);
            this.color_Purple.MinimumSize = new System.Drawing.Size(1, 1);
            this.color_Purple.Name = "color_Purple";
            this.color_Purple.SelectedColor = System.Drawing.Color.Purple;
            this.color_Purple.Size = new System.Drawing.Size(60, 35);
            this.color_Purple.Style = Sunny.UI.UIStyle.Custom;
            this.color_Purple.TabIndex = 10;
            this.color_Purple.Text = "紫";
            this.color_Purple.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            // 
            // uiPanel140
            // 
            this.uiPanel140.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel140.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel140.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel140.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel140.Location = new System.Drawing.Point(251, 0);
            this.uiPanel140.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel140.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel140.Name = "uiPanel140";
            this.uiPanel140.Opacity = ((byte)(180));
            this.uiPanel140.Radius = 10;
            this.uiPanel140.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel140.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel140.Size = new System.Drawing.Size(51, 33);
            this.uiPanel140.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel140.TabIndex = 13;
            this.uiPanel140.Text = null;
            this.uiPanel140.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel12
            // 
            this.uiPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Controls.Add(this.rb_HeightColor);
            this.uiPanel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel12.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel12.Location = new System.Drawing.Point(151, 0);
            this.uiPanel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel12.Name = "uiPanel12";
            this.uiPanel12.Opacity = ((byte)(180));
            this.uiPanel12.Radius = 10;
            this.uiPanel12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel12.Size = new System.Drawing.Size(100, 33);
            this.uiPanel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel12.TabIndex = 12;
            this.uiPanel12.Text = null;
            this.uiPanel12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_HeightColor
            // 
            this.rb_HeightColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_HeightColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_HeightColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_HeightColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rb_HeightColor.Location = new System.Drawing.Point(0, 0);
            this.rb_HeightColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.rb_HeightColor.Name = "rb_HeightColor";
            this.rb_HeightColor.RadioButtonColor = System.Drawing.Color.Red;
            this.rb_HeightColor.Size = new System.Drawing.Size(100, 33);
            this.rb_HeightColor.Style = Sunny.UI.UIStyle.Custom;
            this.rb_HeightColor.TabIndex = 0;
            this.rb_HeightColor.Text = "按高度分层";
            this.rb_HeightColor.CheckedChanged += new System.EventHandler(this.rb_HeightColor_CheckedChanged);
            // 
            // uiPanel11
            // 
            this.uiPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel11.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel11.Location = new System.Drawing.Point(100, 0);
            this.uiPanel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel11.Name = "uiPanel11";
            this.uiPanel11.Opacity = ((byte)(180));
            this.uiPanel11.Radius = 10;
            this.uiPanel11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel11.Size = new System.Drawing.Size(51, 33);
            this.uiPanel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel11.TabIndex = 11;
            this.uiPanel11.Text = null;
            this.uiPanel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel9
            // 
            this.uiPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Controls.Add(this.rb_DefaultColor);
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
            this.uiPanel9.Size = new System.Drawing.Size(100, 33);
            this.uiPanel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel9.TabIndex = 10;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rb_DefaultColor
            // 
            this.rb_DefaultColor.Checked = true;
            this.rb_DefaultColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_DefaultColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_DefaultColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_DefaultColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rb_DefaultColor.Location = new System.Drawing.Point(0, 0);
            this.rb_DefaultColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.rb_DefaultColor.Name = "rb_DefaultColor";
            this.rb_DefaultColor.RadioButtonColor = System.Drawing.Color.Red;
            this.rb_DefaultColor.Size = new System.Drawing.Size(100, 33);
            this.rb_DefaultColor.Style = Sunny.UI.UIStyle.Custom;
            this.rb_DefaultColor.TabIndex = 0;
            this.rb_DefaultColor.Text = "默认颜色";
            this.rb_DefaultColor.CheckedChanged += new System.EventHandler(this.rb_DefaultColor_CheckedChanged);
            // 
            // uiPanel8
            // 
            this.uiPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel8.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel8.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel8.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel8.Location = new System.Drawing.Point(10, 31);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.Opacity = ((byte)(180));
            this.uiPanel8.Radius = 10;
            this.uiPanel8.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel8.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel8.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel8.TabIndex = 17;
            this.uiPanel8.Text = null;
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ColorTitle
            // 
            this.lb_ColorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_ColorTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_ColorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_ColorTitle.Location = new System.Drawing.Point(10, 10);
            this.lb_ColorTitle.Name = "lb_ColorTitle";
            this.lb_ColorTitle.Size = new System.Drawing.Size(1160, 21);
            this.lb_ColorTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ColorTitle.TabIndex = 0;
            this.lb_ColorTitle.Text = "点云颜色配置";
            this.lb_ColorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel2.Location = new System.Drawing.Point(0, 225);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Opacity = ((byte)(180));
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel2.Size = new System.Drawing.Size(1180, 10);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 13;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_GraphParams
            // 
            this.pan_GraphParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.Controls.Add(this.pan_Graph);
            this.pan_GraphParams.Controls.Add(this.uiPanel3);
            this.pan_GraphParams.Controls.Add(this.lb_GraphTitle);
            this.pan_GraphParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_GraphParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_GraphParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_GraphParams.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_GraphParams.Location = new System.Drawing.Point(0, 0);
            this.pan_GraphParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_GraphParams.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_GraphParams.Name = "pan_GraphParams";
            this.pan_GraphParams.Opacity = ((byte)(180));
            this.pan_GraphParams.Padding = new System.Windows.Forms.Padding(10);
            this.pan_GraphParams.Radius = 10;
            this.pan_GraphParams.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_GraphParams.Size = new System.Drawing.Size(1180, 225);
            this.pan_GraphParams.Style = Sunny.UI.UIStyle.Custom;
            this.pan_GraphParams.TabIndex = 5;
            this.pan_GraphParams.Text = null;
            this.pan_GraphParams.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Graph
            // 
            this.pan_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.Controls.Add(this.uiPanel142);
            this.pan_Graph.Controls.Add(this.uiPanel141);
            this.pan_Graph.Controls.Add(this.uiPanel123);
            this.pan_Graph.Controls.Add(this.uiPanel104);
            this.pan_Graph.Controls.Add(this.uiPanel29);
            this.pan_Graph.Controls.Add(this.uiPanel64);
            this.pan_Graph.Controls.Add(this.pan_Graph_Middle);
            this.pan_Graph.Controls.Add(this.uiPanel1);
            this.pan_Graph.Controls.Add(this.pan_Graph_Left);
            this.pan_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Graph.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Graph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Graph.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Graph.Location = new System.Drawing.Point(10, 41);
            this.pan_Graph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Graph.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Graph.Name = "pan_Graph";
            this.pan_Graph.Opacity = ((byte)(180));
            this.pan_Graph.Radius = 10;
            this.pan_Graph.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Graph.Size = new System.Drawing.Size(1160, 174);
            this.pan_Graph.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Graph.TabIndex = 15;
            this.pan_Graph.Text = null;
            this.pan_Graph.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel142
            // 
            this.uiPanel142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.Controls.Add(this.uiPanel143);
            this.uiPanel142.Controls.Add(this.uiPanel147);
            this.uiPanel142.Controls.Add(this.uiPanel151);
            this.uiPanel142.Controls.Add(this.uiPanel155);
            this.uiPanel142.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel142.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel142.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel142.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel142.Location = new System.Drawing.Point(940, 0);
            this.uiPanel142.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel142.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel142.Name = "uiPanel142";
            this.uiPanel142.Opacity = ((byte)(180));
            this.uiPanel142.Radius = 10;
            this.uiPanel142.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel142.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel142.Size = new System.Drawing.Size(210, 174);
            this.uiPanel142.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel142.TabIndex = 24;
            this.uiPanel142.Text = null;
            this.uiPanel142.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel143
            // 
            this.uiPanel143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.Controls.Add(this.uiPanel144);
            this.uiPanel143.Controls.Add(this.uiPanel145);
            this.uiPanel143.Controls.Add(this.uiPanel146);
            this.uiPanel143.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel143.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel143.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel143.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel143.Location = new System.Drawing.Point(0, 105);
            this.uiPanel143.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel143.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel143.Name = "uiPanel143";
            this.uiPanel143.Opacity = ((byte)(180));
            this.uiPanel143.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel143.Radius = 10;
            this.uiPanel143.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel143.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel143.Size = new System.Drawing.Size(210, 35);
            this.uiPanel143.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel143.TabIndex = 18;
            this.uiPanel143.Text = null;
            this.uiPanel143.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel144
            // 
            this.uiPanel144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.Controls.Add(this.tb_TrackTextSize);
            this.uiPanel144.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel144.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel144.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel144.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel144.Location = new System.Drawing.Point(110, 0);
            this.uiPanel144.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel144.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel144.Name = "uiPanel144";
            this.uiPanel144.Opacity = ((byte)(180));
            this.uiPanel144.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel144.Radius = 10;
            this.uiPanel144.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel144.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel144.Size = new System.Drawing.Size(100, 33);
            this.uiPanel144.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel144.TabIndex = 11;
            this.uiPanel144.Text = null;
            this.uiPanel144.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TrackTextSize
            // 
            this.tb_TrackTextSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTextSize.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_TrackTextSize.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_TrackTextSize.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_TrackTextSize.ButtonStyleInherited = false;
            this.tb_TrackTextSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TrackTextSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TrackTextSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrackTextSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTextSize.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTextSize.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTextSize.Location = new System.Drawing.Point(0, 3);
            this.tb_TrackTextSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TrackTextSize.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_TrackTextSize.Name = "tb_TrackTextSize";
            this.tb_TrackTextSize.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TrackTextSize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTextSize.ScrollBarStyleInherited = false;
            this.tb_TrackTextSize.ShowText = false;
            this.tb_TrackTextSize.Size = new System.Drawing.Size(100, 27);
            this.tb_TrackTextSize.Style = Sunny.UI.UIStyle.Custom;
            this.tb_TrackTextSize.TabIndex = 4;
            this.tb_TrackTextSize.Text = "0";
            this.tb_TrackTextSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_TrackTextSize.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_TrackTextSize.Watermark = "";
            // 
            // uiPanel145
            // 
            this.uiPanel145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel145.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel145.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel145.Location = new System.Drawing.Point(100, 0);
            this.uiPanel145.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel145.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel145.Name = "uiPanel145";
            this.uiPanel145.Opacity = ((byte)(180));
            this.uiPanel145.Radius = 10;
            this.uiPanel145.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel145.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel145.Size = new System.Drawing.Size(10, 33);
            this.uiPanel145.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel145.TabIndex = 10;
            this.uiPanel145.Text = null;
            this.uiPanel145.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel146
            // 
            this.uiPanel146.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.Controls.Add(this.lb_TrackTextSize);
            this.uiPanel146.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel146.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel146.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel146.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel146.Location = new System.Drawing.Point(0, 0);
            this.uiPanel146.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel146.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel146.Name = "uiPanel146";
            this.uiPanel146.Opacity = ((byte)(180));
            this.uiPanel146.Radius = 10;
            this.uiPanel146.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel146.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel146.Size = new System.Drawing.Size(100, 33);
            this.uiPanel146.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel146.TabIndex = 9;
            this.uiPanel146.Text = null;
            this.uiPanel146.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackTextSize
            // 
            this.lb_TrackTextSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackTextSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackTextSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackTextSize.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackTextSize.Name = "lb_TrackTextSize";
            this.lb_TrackTextSize.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackTextSize.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackTextSize.TabIndex = 5;
            this.lb_TrackTextSize.Text = "跟踪文本大小：";
            this.lb_TrackTextSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel147
            // 
            this.uiPanel147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.Controls.Add(this.uiPanel148);
            this.uiPanel147.Controls.Add(this.uiPanel149);
            this.uiPanel147.Controls.Add(this.uiPanel150);
            this.uiPanel147.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel147.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel147.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel147.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel147.Location = new System.Drawing.Point(0, 70);
            this.uiPanel147.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel147.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel147.Name = "uiPanel147";
            this.uiPanel147.Opacity = ((byte)(180));
            this.uiPanel147.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel147.Radius = 10;
            this.uiPanel147.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel147.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel147.Size = new System.Drawing.Size(210, 35);
            this.uiPanel147.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel147.TabIndex = 17;
            this.uiPanel147.Text = null;
            this.uiPanel147.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel148
            // 
            this.uiPanel148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.Controls.Add(this.cp_TrackTextColor);
            this.uiPanel148.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel148.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel148.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel148.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel148.Location = new System.Drawing.Point(110, 0);
            this.uiPanel148.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel148.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel148.Name = "uiPanel148";
            this.uiPanel148.Opacity = ((byte)(180));
            this.uiPanel148.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel148.Radius = 10;
            this.uiPanel148.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel148.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel148.Size = new System.Drawing.Size(100, 33);
            this.uiPanel148.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel148.TabIndex = 11;
            this.uiPanel148.Text = null;
            this.uiPanel148.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cp_TrackTextColor
            // 
            this.cp_TrackTextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cp_TrackTextColor.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cp_TrackTextColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTextColor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTextColor.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTextColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_TrackTextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cp_TrackTextColor.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp_TrackTextColor.Location = new System.Drawing.Point(0, 3);
            this.cp_TrackTextColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cp_TrackTextColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cp_TrackTextColor.Name = "cp_TrackTextColor";
            this.cp_TrackTextColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cp_TrackTextColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTextColor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTextColor.Size = new System.Drawing.Size(100, 27);
            this.cp_TrackTextColor.SymbolSize = 24;
            this.cp_TrackTextColor.TabIndex = 21;
            this.cp_TrackTextColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cp_TrackTextColor.Value = System.Drawing.Color.Red;
            this.cp_TrackTextColor.Watermark = "";
            // 
            // uiPanel149
            // 
            this.uiPanel149.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel149.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel149.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel149.Location = new System.Drawing.Point(100, 0);
            this.uiPanel149.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel149.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel149.Name = "uiPanel149";
            this.uiPanel149.Opacity = ((byte)(180));
            this.uiPanel149.Radius = 10;
            this.uiPanel149.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel149.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel149.Size = new System.Drawing.Size(10, 33);
            this.uiPanel149.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel149.TabIndex = 10;
            this.uiPanel149.Text = null;
            this.uiPanel149.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel150
            // 
            this.uiPanel150.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.Controls.Add(this.lb_TrackTextColor);
            this.uiPanel150.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel150.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel150.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel150.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel150.Location = new System.Drawing.Point(0, 0);
            this.uiPanel150.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel150.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel150.Name = "uiPanel150";
            this.uiPanel150.Opacity = ((byte)(180));
            this.uiPanel150.Radius = 10;
            this.uiPanel150.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel150.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel150.Size = new System.Drawing.Size(100, 33);
            this.uiPanel150.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel150.TabIndex = 9;
            this.uiPanel150.Text = null;
            this.uiPanel150.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackTextColor
            // 
            this.lb_TrackTextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackTextColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackTextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackTextColor.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackTextColor.Name = "lb_TrackTextColor";
            this.lb_TrackTextColor.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackTextColor.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackTextColor.TabIndex = 4;
            this.lb_TrackTextColor.Text = "跟踪文本颜色：";
            this.lb_TrackTextColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel151
            // 
            this.uiPanel151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.Controls.Add(this.uiPanel152);
            this.uiPanel151.Controls.Add(this.uiPanel153);
            this.uiPanel151.Controls.Add(this.uiPanel154);
            this.uiPanel151.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel151.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel151.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel151.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel151.Location = new System.Drawing.Point(0, 35);
            this.uiPanel151.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel151.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel151.Name = "uiPanel151";
            this.uiPanel151.Opacity = ((byte)(180));
            this.uiPanel151.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel151.Radius = 10;
            this.uiPanel151.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel151.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel151.Size = new System.Drawing.Size(210, 35);
            this.uiPanel151.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel151.TabIndex = 16;
            this.uiPanel151.Text = null;
            this.uiPanel151.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel152
            // 
            this.uiPanel152.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.Controls.Add(this.tb_ZMax);
            this.uiPanel152.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel152.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel152.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel152.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel152.Location = new System.Drawing.Point(110, 0);
            this.uiPanel152.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel152.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel152.Name = "uiPanel152";
            this.uiPanel152.Opacity = ((byte)(180));
            this.uiPanel152.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel152.Radius = 10;
            this.uiPanel152.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel152.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel152.Size = new System.Drawing.Size(100, 33);
            this.uiPanel152.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel152.TabIndex = 11;
            this.uiPanel152.Text = null;
            this.uiPanel152.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ZMax
            // 
            this.tb_ZMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_ZMax.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_ZMax.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_ZMax.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_ZMax.ButtonStyleInherited = false;
            this.tb_ZMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ZMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ZMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_ZMax.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ZMax.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ZMax.Location = new System.Drawing.Point(0, 3);
            this.tb_ZMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ZMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_ZMax.Name = "tb_ZMax";
            this.tb_ZMax.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ZMax.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMax.ScrollBarStyleInherited = false;
            this.tb_ZMax.ShowText = false;
            this.tb_ZMax.Size = new System.Drawing.Size(100, 27);
            this.tb_ZMax.Style = Sunny.UI.UIStyle.Custom;
            this.tb_ZMax.TabIndex = 2;
            this.tb_ZMax.Text = "0";
            this.tb_ZMax.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_ZMax.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_ZMax.Watermark = "";
            // 
            // uiPanel153
            // 
            this.uiPanel153.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel153.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel153.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel153.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel153.Location = new System.Drawing.Point(100, 0);
            this.uiPanel153.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel153.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel153.Name = "uiPanel153";
            this.uiPanel153.Opacity = ((byte)(180));
            this.uiPanel153.Radius = 10;
            this.uiPanel153.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel153.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel153.Size = new System.Drawing.Size(10, 33);
            this.uiPanel153.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel153.TabIndex = 10;
            this.uiPanel153.Text = null;
            this.uiPanel153.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel154
            // 
            this.uiPanel154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.Controls.Add(this.lb_ZMax);
            this.uiPanel154.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel154.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel154.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel154.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel154.Location = new System.Drawing.Point(0, 0);
            this.uiPanel154.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel154.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel154.Name = "uiPanel154";
            this.uiPanel154.Opacity = ((byte)(180));
            this.uiPanel154.Radius = 10;
            this.uiPanel154.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel154.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel154.Size = new System.Drawing.Size(100, 33);
            this.uiPanel154.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel154.TabIndex = 9;
            this.uiPanel154.Text = null;
            this.uiPanel154.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ZMax
            // 
            this.lb_ZMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ZMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ZMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ZMax.Location = new System.Drawing.Point(0, 0);
            this.lb_ZMax.Name = "lb_ZMax";
            this.lb_ZMax.Size = new System.Drawing.Size(100, 33);
            this.lb_ZMax.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ZMax.TabIndex = 1;
            this.lb_ZMax.Text = "Z轴最大值：";
            this.lb_ZMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel155
            // 
            this.uiPanel155.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.Controls.Add(this.uiPanel156);
            this.uiPanel155.Controls.Add(this.uiPanel157);
            this.uiPanel155.Controls.Add(this.uiPanel158);
            this.uiPanel155.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel155.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel155.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel155.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel155.Location = new System.Drawing.Point(0, 0);
            this.uiPanel155.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel155.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel155.Name = "uiPanel155";
            this.uiPanel155.Opacity = ((byte)(180));
            this.uiPanel155.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel155.Radius = 10;
            this.uiPanel155.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel155.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel155.Size = new System.Drawing.Size(210, 35);
            this.uiPanel155.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel155.TabIndex = 15;
            this.uiPanel155.Text = null;
            this.uiPanel155.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel156
            // 
            this.uiPanel156.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.Controls.Add(this.cmb_CumulativeFramesType);
            this.uiPanel156.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel156.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel156.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel156.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel156.Location = new System.Drawing.Point(110, 0);
            this.uiPanel156.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel156.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel156.Name = "uiPanel156";
            this.uiPanel156.Opacity = ((byte)(180));
            this.uiPanel156.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel156.Radius = 10;
            this.uiPanel156.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel156.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel156.Size = new System.Drawing.Size(100, 33);
            this.uiPanel156.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel156.TabIndex = 11;
            this.uiPanel156.Text = null;
            this.uiPanel156.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_CumulativeFramesType
            // 
            this.cmb_CumulativeFramesType.DataSource = null;
            this.cmb_CumulativeFramesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_CumulativeFramesType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_CumulativeFramesType.DropDownWidth = 100;
            this.cmb_CumulativeFramesType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CumulativeFramesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_CumulativeFramesType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_CumulativeFramesType.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_CumulativeFramesType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_CumulativeFramesType.Location = new System.Drawing.Point(0, 3);
            this.cmb_CumulativeFramesType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_CumulativeFramesType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_CumulativeFramesType.Name = "cmb_CumulativeFramesType";
            this.cmb_CumulativeFramesType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_CumulativeFramesType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_CumulativeFramesType.Size = new System.Drawing.Size(100, 27);
            this.cmb_CumulativeFramesType.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_CumulativeFramesType.SymbolSize = 24;
            this.cmb_CumulativeFramesType.TabIndex = 3;
            this.cmb_CumulativeFramesType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_CumulativeFramesType.Watermark = "";
            // 
            // uiPanel157
            // 
            this.uiPanel157.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel157.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel157.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel157.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel157.Location = new System.Drawing.Point(100, 0);
            this.uiPanel157.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel157.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel157.Name = "uiPanel157";
            this.uiPanel157.Opacity = ((byte)(180));
            this.uiPanel157.Radius = 10;
            this.uiPanel157.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel157.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel157.Size = new System.Drawing.Size(10, 33);
            this.uiPanel157.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel157.TabIndex = 10;
            this.uiPanel157.Text = null;
            this.uiPanel157.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel158
            // 
            this.uiPanel158.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.Controls.Add(this.lb_CumulativeFramesType);
            this.uiPanel158.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel158.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel158.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel158.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel158.Location = new System.Drawing.Point(0, 0);
            this.uiPanel158.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel158.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel158.Name = "uiPanel158";
            this.uiPanel158.Opacity = ((byte)(180));
            this.uiPanel158.Radius = 10;
            this.uiPanel158.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel158.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel158.Size = new System.Drawing.Size(100, 33);
            this.uiPanel158.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel158.TabIndex = 9;
            this.uiPanel158.Text = null;
            this.uiPanel158.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CumulativeFramesType
            // 
            this.lb_CumulativeFramesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CumulativeFramesType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CumulativeFramesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_CumulativeFramesType.Location = new System.Drawing.Point(0, 0);
            this.lb_CumulativeFramesType.Name = "lb_CumulativeFramesType";
            this.lb_CumulativeFramesType.Size = new System.Drawing.Size(100, 33);
            this.lb_CumulativeFramesType.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CumulativeFramesType.TabIndex = 2;
            this.lb_CumulativeFramesType.Text = "累计帧数方式：";
            this.lb_CumulativeFramesType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel141
            // 
            this.uiPanel141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel141.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel141.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel141.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel141.Location = new System.Drawing.Point(915, 0);
            this.uiPanel141.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel141.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel141.Name = "uiPanel141";
            this.uiPanel141.Opacity = ((byte)(180));
            this.uiPanel141.Radius = 10;
            this.uiPanel141.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel141.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel141.Size = new System.Drawing.Size(25, 174);
            this.uiPanel141.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel141.TabIndex = 23;
            this.uiPanel141.Text = null;
            this.uiPanel141.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel123
            // 
            this.uiPanel123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.Controls.Add(this.uiPanel124);
            this.uiPanel123.Controls.Add(this.uiPanel128);
            this.uiPanel123.Controls.Add(this.uiPanel132);
            this.uiPanel123.Controls.Add(this.uiPanel136);
            this.uiPanel123.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel123.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel123.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel123.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel123.Location = new System.Drawing.Point(705, 0);
            this.uiPanel123.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel123.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel123.Name = "uiPanel123";
            this.uiPanel123.Opacity = ((byte)(180));
            this.uiPanel123.Radius = 10;
            this.uiPanel123.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel123.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel123.Size = new System.Drawing.Size(210, 174);
            this.uiPanel123.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel123.TabIndex = 22;
            this.uiPanel123.Text = null;
            this.uiPanel123.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel124
            // 
            this.uiPanel124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.Controls.Add(this.uiPanel125);
            this.uiPanel124.Controls.Add(this.uiPanel126);
            this.uiPanel124.Controls.Add(this.uiPanel127);
            this.uiPanel124.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel124.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel124.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel124.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel124.Location = new System.Drawing.Point(0, 105);
            this.uiPanel124.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel124.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel124.Name = "uiPanel124";
            this.uiPanel124.Opacity = ((byte)(180));
            this.uiPanel124.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel124.Radius = 10;
            this.uiPanel124.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel124.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel124.Size = new System.Drawing.Size(210, 35);
            this.uiPanel124.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel124.TabIndex = 18;
            this.uiPanel124.Text = null;
            this.uiPanel124.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel125
            // 
            this.uiPanel125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.Controls.Add(this.tb_MaxTrajectoryNum);
            this.uiPanel125.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel125.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel125.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel125.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel125.Location = new System.Drawing.Point(110, 0);
            this.uiPanel125.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel125.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel125.Name = "uiPanel125";
            this.uiPanel125.Opacity = ((byte)(180));
            this.uiPanel125.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel125.Radius = 10;
            this.uiPanel125.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel125.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel125.Size = new System.Drawing.Size(100, 33);
            this.uiPanel125.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel125.TabIndex = 11;
            this.uiPanel125.Text = null;
            this.uiPanel125.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_MaxTrajectoryNum
            // 
            this.tb_MaxTrajectoryNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_MaxTrajectoryNum.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_MaxTrajectoryNum.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_MaxTrajectoryNum.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_MaxTrajectoryNum.ButtonStyleInherited = false;
            this.tb_MaxTrajectoryNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MaxTrajectoryNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_MaxTrajectoryNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaxTrajectoryNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_MaxTrajectoryNum.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_MaxTrajectoryNum.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_MaxTrajectoryNum.Location = new System.Drawing.Point(0, 3);
            this.tb_MaxTrajectoryNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_MaxTrajectoryNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_MaxTrajectoryNum.Name = "tb_MaxTrajectoryNum";
            this.tb_MaxTrajectoryNum.Padding = new System.Windows.Forms.Padding(5);
            this.tb_MaxTrajectoryNum.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_MaxTrajectoryNum.ScrollBarStyleInherited = false;
            this.tb_MaxTrajectoryNum.ShowText = false;
            this.tb_MaxTrajectoryNum.Size = new System.Drawing.Size(100, 27);
            this.tb_MaxTrajectoryNum.Style = Sunny.UI.UIStyle.Custom;
            this.tb_MaxTrajectoryNum.TabIndex = 4;
            this.tb_MaxTrajectoryNum.Text = "0";
            this.tb_MaxTrajectoryNum.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_MaxTrajectoryNum.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_MaxTrajectoryNum.Watermark = "";
            // 
            // uiPanel126
            // 
            this.uiPanel126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel126.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel126.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel126.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel126.Location = new System.Drawing.Point(100, 0);
            this.uiPanel126.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel126.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel126.Name = "uiPanel126";
            this.uiPanel126.Opacity = ((byte)(180));
            this.uiPanel126.Radius = 10;
            this.uiPanel126.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel126.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel126.Size = new System.Drawing.Size(10, 33);
            this.uiPanel126.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel126.TabIndex = 10;
            this.uiPanel126.Text = null;
            this.uiPanel126.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel127
            // 
            this.uiPanel127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.Controls.Add(this.lb_MaxTrajectoryNum);
            this.uiPanel127.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel127.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel127.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel127.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel127.Location = new System.Drawing.Point(0, 0);
            this.uiPanel127.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel127.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel127.Name = "uiPanel127";
            this.uiPanel127.Opacity = ((byte)(180));
            this.uiPanel127.Radius = 10;
            this.uiPanel127.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel127.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel127.Size = new System.Drawing.Size(100, 33);
            this.uiPanel127.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel127.TabIndex = 9;
            this.uiPanel127.Text = null;
            this.uiPanel127.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_MaxTrajectoryNum
            // 
            this.lb_MaxTrajectoryNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_MaxTrajectoryNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaxTrajectoryNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_MaxTrajectoryNum.Location = new System.Drawing.Point(0, 0);
            this.lb_MaxTrajectoryNum.Name = "lb_MaxTrajectoryNum";
            this.lb_MaxTrajectoryNum.Size = new System.Drawing.Size(100, 33);
            this.lb_MaxTrajectoryNum.Style = Sunny.UI.UIStyle.Custom;
            this.lb_MaxTrajectoryNum.TabIndex = 5;
            this.lb_MaxTrajectoryNum.Text = "单轨迹数量：";
            this.lb_MaxTrajectoryNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel128
            // 
            this.uiPanel128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.Controls.Add(this.uiPanel129);
            this.uiPanel128.Controls.Add(this.uiPanel130);
            this.uiPanel128.Controls.Add(this.uiPanel131);
            this.uiPanel128.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel128.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel128.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel128.Location = new System.Drawing.Point(0, 70);
            this.uiPanel128.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel128.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel128.Name = "uiPanel128";
            this.uiPanel128.Opacity = ((byte)(180));
            this.uiPanel128.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel128.Radius = 10;
            this.uiPanel128.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel128.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel128.Size = new System.Drawing.Size(210, 35);
            this.uiPanel128.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel128.TabIndex = 17;
            this.uiPanel128.Text = null;
            this.uiPanel128.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel129
            // 
            this.uiPanel129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.Controls.Add(this.cp_TrackColor);
            this.uiPanel129.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel129.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel129.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel129.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel129.Location = new System.Drawing.Point(110, 0);
            this.uiPanel129.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel129.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel129.Name = "uiPanel129";
            this.uiPanel129.Opacity = ((byte)(180));
            this.uiPanel129.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel129.Radius = 10;
            this.uiPanel129.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel129.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel129.Size = new System.Drawing.Size(100, 33);
            this.uiPanel129.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel129.TabIndex = 11;
            this.uiPanel129.Text = null;
            this.uiPanel129.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cp_TrackColor
            // 
            this.cp_TrackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cp_TrackColor.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cp_TrackColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackColor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackColor.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_TrackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cp_TrackColor.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp_TrackColor.Location = new System.Drawing.Point(0, 3);
            this.cp_TrackColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cp_TrackColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cp_TrackColor.Name = "cp_TrackColor";
            this.cp_TrackColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cp_TrackColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackColor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackColor.Size = new System.Drawing.Size(100, 27);
            this.cp_TrackColor.SymbolSize = 24;
            this.cp_TrackColor.TabIndex = 21;
            this.cp_TrackColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cp_TrackColor.Value = System.Drawing.Color.Red;
            this.cp_TrackColor.Watermark = "";
            // 
            // uiPanel130
            // 
            this.uiPanel130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel130.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel130.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel130.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel130.Location = new System.Drawing.Point(100, 0);
            this.uiPanel130.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel130.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel130.Name = "uiPanel130";
            this.uiPanel130.Opacity = ((byte)(180));
            this.uiPanel130.Radius = 10;
            this.uiPanel130.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel130.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel130.Size = new System.Drawing.Size(10, 33);
            this.uiPanel130.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel130.TabIndex = 10;
            this.uiPanel130.Text = null;
            this.uiPanel130.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel131
            // 
            this.uiPanel131.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.Controls.Add(this.lb_TrackColor);
            this.uiPanel131.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel131.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel131.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel131.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel131.Location = new System.Drawing.Point(0, 0);
            this.uiPanel131.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel131.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel131.Name = "uiPanel131";
            this.uiPanel131.Opacity = ((byte)(180));
            this.uiPanel131.Radius = 10;
            this.uiPanel131.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel131.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel131.Size = new System.Drawing.Size(100, 33);
            this.uiPanel131.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel131.TabIndex = 9;
            this.uiPanel131.Text = null;
            this.uiPanel131.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackColor
            // 
            this.lb_TrackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackColor.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackColor.Name = "lb_TrackColor";
            this.lb_TrackColor.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackColor.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackColor.TabIndex = 3;
            this.lb_TrackColor.Text = "跟踪颜色：";
            this.lb_TrackColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel132
            // 
            this.uiPanel132.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.Controls.Add(this.uiPanel133);
            this.uiPanel132.Controls.Add(this.uiPanel134);
            this.uiPanel132.Controls.Add(this.uiPanel135);
            this.uiPanel132.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel132.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel132.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel132.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel132.Location = new System.Drawing.Point(0, 35);
            this.uiPanel132.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel132.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel132.Name = "uiPanel132";
            this.uiPanel132.Opacity = ((byte)(180));
            this.uiPanel132.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel132.Radius = 10;
            this.uiPanel132.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel132.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel132.Size = new System.Drawing.Size(210, 35);
            this.uiPanel132.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel132.TabIndex = 16;
            this.uiPanel132.Text = null;
            this.uiPanel132.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel133
            // 
            this.uiPanel133.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.Controls.Add(this.tb_ZMin);
            this.uiPanel133.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel133.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel133.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel133.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel133.Location = new System.Drawing.Point(110, 0);
            this.uiPanel133.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel133.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel133.Name = "uiPanel133";
            this.uiPanel133.Opacity = ((byte)(180));
            this.uiPanel133.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel133.Radius = 10;
            this.uiPanel133.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel133.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel133.Size = new System.Drawing.Size(100, 33);
            this.uiPanel133.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel133.TabIndex = 11;
            this.uiPanel133.Text = null;
            this.uiPanel133.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ZMin
            // 
            this.tb_ZMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_ZMin.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_ZMin.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_ZMin.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_ZMin.ButtonStyleInherited = false;
            this.tb_ZMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ZMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ZMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_ZMin.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ZMin.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ZMin.Location = new System.Drawing.Point(0, 3);
            this.tb_ZMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_ZMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_ZMin.Name = "tb_ZMin";
            this.tb_ZMin.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ZMin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ZMin.ScrollBarStyleInherited = false;
            this.tb_ZMin.ShowText = false;
            this.tb_ZMin.Size = new System.Drawing.Size(100, 27);
            this.tb_ZMin.Style = Sunny.UI.UIStyle.Custom;
            this.tb_ZMin.TabIndex = 2;
            this.tb_ZMin.Text = "0";
            this.tb_ZMin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_ZMin.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_ZMin.Watermark = "";
            // 
            // uiPanel134
            // 
            this.uiPanel134.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel134.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel134.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel134.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel134.Location = new System.Drawing.Point(100, 0);
            this.uiPanel134.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel134.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel134.Name = "uiPanel134";
            this.uiPanel134.Opacity = ((byte)(180));
            this.uiPanel134.Radius = 10;
            this.uiPanel134.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel134.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel134.Size = new System.Drawing.Size(10, 33);
            this.uiPanel134.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel134.TabIndex = 10;
            this.uiPanel134.Text = null;
            this.uiPanel134.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel135
            // 
            this.uiPanel135.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.Controls.Add(this.lb_ZMin);
            this.uiPanel135.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel135.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel135.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel135.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel135.Location = new System.Drawing.Point(0, 0);
            this.uiPanel135.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel135.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel135.Name = "uiPanel135";
            this.uiPanel135.Opacity = ((byte)(180));
            this.uiPanel135.Radius = 10;
            this.uiPanel135.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel135.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel135.Size = new System.Drawing.Size(100, 33);
            this.uiPanel135.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel135.TabIndex = 9;
            this.uiPanel135.Text = null;
            this.uiPanel135.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ZMin
            // 
            this.lb_ZMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ZMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ZMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ZMin.Location = new System.Drawing.Point(0, 0);
            this.lb_ZMin.Name = "lb_ZMin";
            this.lb_ZMin.Size = new System.Drawing.Size(100, 33);
            this.lb_ZMin.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ZMin.TabIndex = 1;
            this.lb_ZMin.Text = "Z轴最小值：";
            this.lb_ZMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel136
            // 
            this.uiPanel136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.Controls.Add(this.uiPanel137);
            this.uiPanel136.Controls.Add(this.uiPanel138);
            this.uiPanel136.Controls.Add(this.uiPanel139);
            this.uiPanel136.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel136.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel136.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel136.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel136.Location = new System.Drawing.Point(0, 0);
            this.uiPanel136.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel136.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel136.Name = "uiPanel136";
            this.uiPanel136.Opacity = ((byte)(180));
            this.uiPanel136.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel136.Radius = 10;
            this.uiPanel136.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel136.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel136.Size = new System.Drawing.Size(210, 35);
            this.uiPanel136.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel136.TabIndex = 15;
            this.uiPanel136.Text = null;
            this.uiPanel136.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel137
            // 
            this.uiPanel137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.Controls.Add(this.tb_CumulativeFrames);
            this.uiPanel137.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel137.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel137.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel137.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel137.Location = new System.Drawing.Point(110, 0);
            this.uiPanel137.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel137.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel137.Name = "uiPanel137";
            this.uiPanel137.Opacity = ((byte)(180));
            this.uiPanel137.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel137.Radius = 10;
            this.uiPanel137.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel137.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel137.Size = new System.Drawing.Size(100, 33);
            this.uiPanel137.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel137.TabIndex = 11;
            this.uiPanel137.Text = null;
            this.uiPanel137.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CumulativeFrames
            // 
            this.tb_CumulativeFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_CumulativeFrames.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_CumulativeFrames.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_CumulativeFrames.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_CumulativeFrames.ButtonStyleInherited = false;
            this.tb_CumulativeFrames.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CumulativeFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CumulativeFrames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CumulativeFrames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_CumulativeFrames.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CumulativeFrames.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_CumulativeFrames.Location = new System.Drawing.Point(0, 3);
            this.tb_CumulativeFrames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_CumulativeFrames.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_CumulativeFrames.Name = "tb_CumulativeFrames";
            this.tb_CumulativeFrames.Padding = new System.Windows.Forms.Padding(5);
            this.tb_CumulativeFrames.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_CumulativeFrames.ScrollBarStyleInherited = false;
            this.tb_CumulativeFrames.ShowText = false;
            this.tb_CumulativeFrames.Size = new System.Drawing.Size(100, 27);
            this.tb_CumulativeFrames.Style = Sunny.UI.UIStyle.Custom;
            this.tb_CumulativeFrames.TabIndex = 2;
            this.tb_CumulativeFrames.Text = "0";
            this.tb_CumulativeFrames.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_CumulativeFrames.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_CumulativeFrames.Watermark = "";
            // 
            // uiPanel138
            // 
            this.uiPanel138.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel138.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel138.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel138.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel138.Location = new System.Drawing.Point(100, 0);
            this.uiPanel138.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel138.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel138.Name = "uiPanel138";
            this.uiPanel138.Opacity = ((byte)(180));
            this.uiPanel138.Radius = 10;
            this.uiPanel138.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel138.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel138.Size = new System.Drawing.Size(10, 33);
            this.uiPanel138.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel138.TabIndex = 10;
            this.uiPanel138.Text = null;
            this.uiPanel138.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel139
            // 
            this.uiPanel139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.Controls.Add(this.lb_CumulativeFramesText);
            this.uiPanel139.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel139.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel139.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel139.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel139.Location = new System.Drawing.Point(0, 0);
            this.uiPanel139.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel139.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel139.Name = "uiPanel139";
            this.uiPanel139.Opacity = ((byte)(180));
            this.uiPanel139.Radius = 10;
            this.uiPanel139.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel139.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel139.Size = new System.Drawing.Size(100, 33);
            this.uiPanel139.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel139.TabIndex = 9;
            this.uiPanel139.Text = null;
            this.uiPanel139.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CumulativeFramesText
            // 
            this.lb_CumulativeFramesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CumulativeFramesText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CumulativeFramesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_CumulativeFramesText.Location = new System.Drawing.Point(0, 0);
            this.lb_CumulativeFramesText.Name = "lb_CumulativeFramesText";
            this.lb_CumulativeFramesText.Size = new System.Drawing.Size(100, 33);
            this.lb_CumulativeFramesText.Style = Sunny.UI.UIStyle.Custom;
            this.lb_CumulativeFramesText.TabIndex = 1;
            this.lb_CumulativeFramesText.Text = "累计显示帧数：";
            this.lb_CumulativeFramesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel104.Location = new System.Drawing.Point(680, 0);
            this.uiPanel104.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel104.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel104.Name = "uiPanel104";
            this.uiPanel104.Opacity = ((byte)(180));
            this.uiPanel104.Radius = 10;
            this.uiPanel104.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel104.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel104.Size = new System.Drawing.Size(25, 174);
            this.uiPanel104.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel104.TabIndex = 21;
            this.uiPanel104.Text = null;
            this.uiPanel104.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel29
            // 
            this.uiPanel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.Controls.Add(this.uiPanel112);
            this.uiPanel29.Controls.Add(this.uiPanel65);
            this.uiPanel29.Controls.Add(this.uiPanel69);
            this.uiPanel29.Controls.Add(this.uiPanel73);
            this.uiPanel29.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel29.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel29.Location = new System.Drawing.Point(470, 0);
            this.uiPanel29.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel29.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel29.Name = "uiPanel29";
            this.uiPanel29.Opacity = ((byte)(180));
            this.uiPanel29.Radius = 10;
            this.uiPanel29.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel29.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel29.Size = new System.Drawing.Size(210, 174);
            this.uiPanel29.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel29.TabIndex = 20;
            this.uiPanel29.Text = null;
            this.uiPanel29.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel112
            // 
            this.uiPanel112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.Controls.Add(this.uiPanel116);
            this.uiPanel112.Controls.Add(this.uiPanel117);
            this.uiPanel112.Controls.Add(this.uiPanel118);
            this.uiPanel112.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel112.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel112.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel112.Location = new System.Drawing.Point(0, 105);
            this.uiPanel112.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel112.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel112.Name = "uiPanel112";
            this.uiPanel112.Opacity = ((byte)(180));
            this.uiPanel112.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel112.Radius = 10;
            this.uiPanel112.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel112.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel112.Size = new System.Drawing.Size(210, 35);
            this.uiPanel112.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel112.TabIndex = 18;
            this.uiPanel112.Text = null;
            this.uiPanel112.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel116
            // 
            this.uiPanel116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.Controls.Add(this.cp_TrackTrajectoryColor);
            this.uiPanel116.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel116.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel116.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel116.Location = new System.Drawing.Point(110, 0);
            this.uiPanel116.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel116.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel116.Name = "uiPanel116";
            this.uiPanel116.Opacity = ((byte)(180));
            this.uiPanel116.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel116.Radius = 10;
            this.uiPanel116.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel116.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel116.Size = new System.Drawing.Size(100, 33);
            this.uiPanel116.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel116.TabIndex = 11;
            this.uiPanel116.Text = null;
            this.uiPanel116.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cp_TrackTrajectoryColor
            // 
            this.cp_TrackTrajectoryColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cp_TrackTrajectoryColor.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cp_TrackTrajectoryColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTrajectoryColor.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTrajectoryColor.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTrajectoryColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_TrackTrajectoryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cp_TrackTrajectoryColor.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp_TrackTrajectoryColor.Location = new System.Drawing.Point(0, 3);
            this.cp_TrackTrajectoryColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cp_TrackTrajectoryColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.cp_TrackTrajectoryColor.Name = "cp_TrackTrajectoryColor";
            this.cp_TrackTrajectoryColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cp_TrackTrajectoryColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTrajectoryColor.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cp_TrackTrajectoryColor.Size = new System.Drawing.Size(100, 27);
            this.cp_TrackTrajectoryColor.SymbolSize = 24;
            this.cp_TrackTrajectoryColor.TabIndex = 21;
            this.cp_TrackTrajectoryColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cp_TrackTrajectoryColor.Value = System.Drawing.Color.Red;
            this.cp_TrackTrajectoryColor.Watermark = "";
            // 
            // uiPanel117
            // 
            this.uiPanel117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel117.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel117.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel117.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel117.Location = new System.Drawing.Point(100, 0);
            this.uiPanel117.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel117.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel117.Name = "uiPanel117";
            this.uiPanel117.Opacity = ((byte)(180));
            this.uiPanel117.Radius = 10;
            this.uiPanel117.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel117.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel117.Size = new System.Drawing.Size(10, 33);
            this.uiPanel117.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel117.TabIndex = 10;
            this.uiPanel117.Text = null;
            this.uiPanel117.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel118
            // 
            this.uiPanel118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.Controls.Add(this.lb_TrackTrajectoryColor);
            this.uiPanel118.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel118.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel118.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel118.Location = new System.Drawing.Point(0, 0);
            this.uiPanel118.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel118.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel118.Name = "uiPanel118";
            this.uiPanel118.Opacity = ((byte)(180));
            this.uiPanel118.Radius = 10;
            this.uiPanel118.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel118.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel118.Size = new System.Drawing.Size(100, 33);
            this.uiPanel118.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel118.TabIndex = 9;
            this.uiPanel118.Text = null;
            this.uiPanel118.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackTrajectoryColor
            // 
            this.lb_TrackTrajectoryColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackTrajectoryColor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackTrajectoryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackTrajectoryColor.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackTrajectoryColor.Name = "lb_TrackTrajectoryColor";
            this.lb_TrackTrajectoryColor.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackTrajectoryColor.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackTrajectoryColor.TabIndex = 4;
            this.lb_TrackTrajectoryColor.Text = "轨迹颜色：";
            this.lb_TrackTrajectoryColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel65
            // 
            this.uiPanel65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.Controls.Add(this.uiPanel66);
            this.uiPanel65.Controls.Add(this.uiPanel67);
            this.uiPanel65.Controls.Add(this.uiPanel68);
            this.uiPanel65.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel65.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel65.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel65.Location = new System.Drawing.Point(0, 70);
            this.uiPanel65.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel65.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel65.Name = "uiPanel65";
            this.uiPanel65.Opacity = ((byte)(180));
            this.uiPanel65.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel65.Radius = 10;
            this.uiPanel65.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel65.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel65.Size = new System.Drawing.Size(210, 35);
            this.uiPanel65.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel65.TabIndex = 17;
            this.uiPanel65.Text = null;
            this.uiPanel65.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel66
            // 
            this.uiPanel66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.Controls.Add(this.tb_TrackSize);
            this.uiPanel66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel66.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel66.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel66.Location = new System.Drawing.Point(110, 0);
            this.uiPanel66.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel66.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel66.Name = "uiPanel66";
            this.uiPanel66.Opacity = ((byte)(180));
            this.uiPanel66.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel66.Radius = 10;
            this.uiPanel66.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel66.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel66.Size = new System.Drawing.Size(100, 33);
            this.uiPanel66.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel66.TabIndex = 11;
            this.uiPanel66.Text = null;
            this.uiPanel66.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TrackSize
            // 
            this.tb_TrackSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackSize.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_TrackSize.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_TrackSize.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_TrackSize.ButtonStyleInherited = false;
            this.tb_TrackSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TrackSize.DecimalPlaces = 1;
            this.tb_TrackSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TrackSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrackSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackSize.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackSize.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackSize.Location = new System.Drawing.Point(0, 3);
            this.tb_TrackSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TrackSize.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_TrackSize.Name = "tb_TrackSize";
            this.tb_TrackSize.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TrackSize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackSize.ScrollBarStyleInherited = false;
            this.tb_TrackSize.ShowText = false;
            this.tb_TrackSize.Size = new System.Drawing.Size(100, 27);
            this.tb_TrackSize.Style = Sunny.UI.UIStyle.Custom;
            this.tb_TrackSize.TabIndex = 3;
            this.tb_TrackSize.Text = "0.0";
            this.tb_TrackSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_TrackSize.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tb_TrackSize.Watermark = "";
            // 
            // uiPanel67
            // 
            this.uiPanel67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel67.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel67.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel67.Location = new System.Drawing.Point(100, 0);
            this.uiPanel67.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel67.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel67.Name = "uiPanel67";
            this.uiPanel67.Opacity = ((byte)(180));
            this.uiPanel67.Radius = 10;
            this.uiPanel67.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel67.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel67.Size = new System.Drawing.Size(10, 33);
            this.uiPanel67.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel67.TabIndex = 10;
            this.uiPanel67.Text = null;
            this.uiPanel67.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel68
            // 
            this.uiPanel68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.Controls.Add(this.lb_TrackSize);
            this.uiPanel68.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel68.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel68.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel68.Location = new System.Drawing.Point(0, 0);
            this.uiPanel68.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel68.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel68.Name = "uiPanel68";
            this.uiPanel68.Opacity = ((byte)(180));
            this.uiPanel68.Radius = 10;
            this.uiPanel68.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel68.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel68.Size = new System.Drawing.Size(100, 33);
            this.uiPanel68.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel68.TabIndex = 9;
            this.uiPanel68.Text = null;
            this.uiPanel68.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackSize
            // 
            this.lb_TrackSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackSize.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackSize.Name = "lb_TrackSize";
            this.lb_TrackSize.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackSize.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackSize.TabIndex = 2;
            this.lb_TrackSize.Text = "跟踪大小：";
            this.lb_TrackSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel69
            // 
            this.uiPanel69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.Controls.Add(this.uiPanel70);
            this.uiPanel69.Controls.Add(this.uiPanel71);
            this.uiPanel69.Controls.Add(this.uiPanel72);
            this.uiPanel69.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel69.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel69.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel69.Location = new System.Drawing.Point(0, 35);
            this.uiPanel69.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel69.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel69.Name = "uiPanel69";
            this.uiPanel69.Opacity = ((byte)(180));
            this.uiPanel69.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel69.Radius = 10;
            this.uiPanel69.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel69.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel69.Size = new System.Drawing.Size(210, 35);
            this.uiPanel69.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel69.TabIndex = 16;
            this.uiPanel69.Text = null;
            this.uiPanel69.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel70
            // 
            this.uiPanel70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.Controls.Add(this.tb_YStep);
            this.uiPanel70.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel70.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel70.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel70.Location = new System.Drawing.Point(110, 0);
            this.uiPanel70.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel70.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel70.Name = "uiPanel70";
            this.uiPanel70.Opacity = ((byte)(180));
            this.uiPanel70.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel70.Radius = 10;
            this.uiPanel70.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel70.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel70.Size = new System.Drawing.Size(100, 33);
            this.uiPanel70.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel70.TabIndex = 11;
            this.uiPanel70.Text = null;
            this.uiPanel70.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_YStep
            // 
            this.tb_YStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YStep.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_YStep.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_YStep.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_YStep.ButtonStyleInherited = false;
            this.tb_YStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_YStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_YStep.DoubleValue = 3D;
            this.tb_YStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_YStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YStep.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YStep.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YStep.IntValue = 3;
            this.tb_YStep.Location = new System.Drawing.Point(0, 3);
            this.tb_YStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_YStep.Minimum = 3D;
            this.tb_YStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_YStep.Name = "tb_YStep";
            this.tb_YStep.Padding = new System.Windows.Forms.Padding(5);
            this.tb_YStep.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YStep.ScrollBarStyleInherited = false;
            this.tb_YStep.ShowText = false;
            this.tb_YStep.Size = new System.Drawing.Size(100, 27);
            this.tb_YStep.Style = Sunny.UI.UIStyle.Custom;
            this.tb_YStep.TabIndex = 1;
            this.tb_YStep.Text = "3";
            this.tb_YStep.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_YStep.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_YStep.Watermark = "";
            // 
            // uiPanel71
            // 
            this.uiPanel71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel71.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel71.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel71.Location = new System.Drawing.Point(100, 0);
            this.uiPanel71.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel71.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel71.Name = "uiPanel71";
            this.uiPanel71.Opacity = ((byte)(180));
            this.uiPanel71.Radius = 10;
            this.uiPanel71.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel71.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel71.Size = new System.Drawing.Size(10, 33);
            this.uiPanel71.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel71.TabIndex = 10;
            this.uiPanel71.Text = null;
            this.uiPanel71.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel72
            // 
            this.uiPanel72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.Controls.Add(this.lb_YStep);
            this.uiPanel72.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel72.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel72.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel72.Location = new System.Drawing.Point(0, 0);
            this.uiPanel72.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel72.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel72.Name = "uiPanel72";
            this.uiPanel72.Opacity = ((byte)(180));
            this.uiPanel72.Radius = 10;
            this.uiPanel72.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel72.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel72.Size = new System.Drawing.Size(100, 33);
            this.uiPanel72.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel72.TabIndex = 9;
            this.uiPanel72.Text = null;
            this.uiPanel72.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_YStep
            // 
            this.lb_YStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_YStep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_YStep.Location = new System.Drawing.Point(0, 0);
            this.lb_YStep.Name = "lb_YStep";
            this.lb_YStep.Size = new System.Drawing.Size(100, 33);
            this.lb_YStep.Style = Sunny.UI.UIStyle.Custom;
            this.lb_YStep.TabIndex = 0;
            this.lb_YStep.Text = "Y轴步长：";
            this.lb_YStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel73
            // 
            this.uiPanel73.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.Controls.Add(this.uiPanel74);
            this.uiPanel73.Controls.Add(this.uiPanel75);
            this.uiPanel73.Controls.Add(this.uiPanel76);
            this.uiPanel73.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel73.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel73.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel73.Location = new System.Drawing.Point(0, 0);
            this.uiPanel73.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel73.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel73.Name = "uiPanel73";
            this.uiPanel73.Opacity = ((byte)(180));
            this.uiPanel73.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel73.Radius = 10;
            this.uiPanel73.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel73.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel73.Size = new System.Drawing.Size(210, 35);
            this.uiPanel73.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel73.TabIndex = 15;
            this.uiPanel73.Text = null;
            this.uiPanel73.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel74
            // 
            this.uiPanel74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.Controls.Add(this.tb_XStep);
            this.uiPanel74.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel74.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel74.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel74.Location = new System.Drawing.Point(110, 0);
            this.uiPanel74.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel74.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel74.Name = "uiPanel74";
            this.uiPanel74.Opacity = ((byte)(180));
            this.uiPanel74.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel74.Radius = 10;
            this.uiPanel74.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel74.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel74.Size = new System.Drawing.Size(100, 33);
            this.uiPanel74.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel74.TabIndex = 11;
            this.uiPanel74.Text = null;
            this.uiPanel74.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_XStep
            // 
            this.tb_XStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XStep.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_XStep.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_XStep.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_XStep.ButtonStyleInherited = false;
            this.tb_XStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_XStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_XStep.DoubleValue = 3D;
            this.tb_XStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_XStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XStep.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XStep.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XStep.IntValue = 3;
            this.tb_XStep.Location = new System.Drawing.Point(0, 3);
            this.tb_XStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_XStep.Minimum = 3D;
            this.tb_XStep.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_XStep.Name = "tb_XStep";
            this.tb_XStep.Padding = new System.Windows.Forms.Padding(5);
            this.tb_XStep.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XStep.ScrollBarStyleInherited = false;
            this.tb_XStep.ShowText = false;
            this.tb_XStep.Size = new System.Drawing.Size(100, 27);
            this.tb_XStep.Style = Sunny.UI.UIStyle.Custom;
            this.tb_XStep.TabIndex = 0;
            this.tb_XStep.Text = "3";
            this.tb_XStep.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_XStep.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_XStep.Watermark = "";
            // 
            // uiPanel75
            // 
            this.uiPanel75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel75.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel75.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel75.Location = new System.Drawing.Point(100, 0);
            this.uiPanel75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel75.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel75.Name = "uiPanel75";
            this.uiPanel75.Opacity = ((byte)(180));
            this.uiPanel75.Radius = 10;
            this.uiPanel75.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel75.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel75.Size = new System.Drawing.Size(10, 33);
            this.uiPanel75.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel75.TabIndex = 10;
            this.uiPanel75.Text = null;
            this.uiPanel75.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel76
            // 
            this.uiPanel76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.Controls.Add(this.lb_XStep);
            this.uiPanel76.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel76.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel76.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel76.Location = new System.Drawing.Point(0, 0);
            this.uiPanel76.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel76.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel76.Name = "uiPanel76";
            this.uiPanel76.Opacity = ((byte)(180));
            this.uiPanel76.Radius = 10;
            this.uiPanel76.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel76.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel76.Size = new System.Drawing.Size(100, 33);
            this.uiPanel76.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel76.TabIndex = 9;
            this.uiPanel76.Text = null;
            this.uiPanel76.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_XStep
            // 
            this.lb_XStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_XStep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_XStep.Location = new System.Drawing.Point(0, 0);
            this.lb_XStep.Name = "lb_XStep";
            this.lb_XStep.Size = new System.Drawing.Size(100, 33);
            this.lb_XStep.Style = Sunny.UI.UIStyle.Custom;
            this.lb_XStep.TabIndex = 0;
            this.lb_XStep.Text = "X轴步长：";
            this.lb_XStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel64
            // 
            this.uiPanel64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel64.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel64.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel64.Location = new System.Drawing.Point(445, 0);
            this.uiPanel64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel64.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel64.Name = "uiPanel64";
            this.uiPanel64.Opacity = ((byte)(180));
            this.uiPanel64.Radius = 10;
            this.uiPanel64.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel64.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel64.Size = new System.Drawing.Size(25, 174);
            this.uiPanel64.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel64.TabIndex = 19;
            this.uiPanel64.Text = null;
            this.uiPanel64.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Graph_Middle
            // 
            this.pan_Graph_Middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.Controls.Add(this.uiPanel160);
            this.pan_Graph_Middle.Controls.Add(this.uiPanel94);
            this.pan_Graph_Middle.Controls.Add(this.uiPanel30);
            this.pan_Graph_Middle.Controls.Add(this.uiPanel34);
            this.pan_Graph_Middle.Controls.Add(this.uiPanel60);
            this.pan_Graph_Middle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_Graph_Middle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Graph_Middle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Graph_Middle.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Graph_Middle.Location = new System.Drawing.Point(235, 0);
            this.pan_Graph_Middle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Graph_Middle.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Graph_Middle.Name = "pan_Graph_Middle";
            this.pan_Graph_Middle.Opacity = ((byte)(180));
            this.pan_Graph_Middle.Radius = 10;
            this.pan_Graph_Middle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Middle.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Graph_Middle.Size = new System.Drawing.Size(210, 174);
            this.pan_Graph_Middle.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Graph_Middle.TabIndex = 18;
            this.pan_Graph_Middle.Text = null;
            this.pan_Graph_Middle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel160
            // 
            this.uiPanel160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.Controls.Add(this.uiPanel161);
            this.uiPanel160.Controls.Add(this.uiPanel162);
            this.uiPanel160.Controls.Add(this.uiPanel163);
            this.uiPanel160.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel160.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel160.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel160.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel160.Location = new System.Drawing.Point(0, 140);
            this.uiPanel160.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel160.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel160.Name = "uiPanel160";
            this.uiPanel160.Opacity = ((byte)(180));
            this.uiPanel160.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel160.Radius = 10;
            this.uiPanel160.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel160.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel160.Size = new System.Drawing.Size(210, 35);
            this.uiPanel160.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel160.TabIndex = 19;
            this.uiPanel160.Text = null;
            this.uiPanel160.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel161
            // 
            this.uiPanel161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.Controls.Add(this.cmb_TrackColorMode);
            this.uiPanel161.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel161.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel161.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel161.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel161.Location = new System.Drawing.Point(110, 0);
            this.uiPanel161.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel161.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel161.Name = "uiPanel161";
            this.uiPanel161.Opacity = ((byte)(180));
            this.uiPanel161.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel161.Radius = 10;
            this.uiPanel161.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel161.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel161.Size = new System.Drawing.Size(100, 33);
            this.uiPanel161.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel161.TabIndex = 11;
            this.uiPanel161.Text = null;
            this.uiPanel161.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_TrackColorMode
            // 
            this.cmb_TrackColorMode.DataSource = null;
            this.cmb_TrackColorMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_TrackColorMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_TrackColorMode.DropDownWidth = 100;
            this.cmb_TrackColorMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TrackColorMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_TrackColorMode.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_TrackColorMode.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_TrackColorMode.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_TrackColorMode.Location = new System.Drawing.Point(0, 3);
            this.cmb_TrackColorMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_TrackColorMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_TrackColorMode.Name = "cmb_TrackColorMode";
            this.cmb_TrackColorMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_TrackColorMode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_TrackColorMode.Size = new System.Drawing.Size(100, 27);
            this.cmb_TrackColorMode.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_TrackColorMode.SymbolSize = 24;
            this.cmb_TrackColorMode.TabIndex = 7;
            this.cmb_TrackColorMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_TrackColorMode.Watermark = "";
            // 
            // uiPanel162
            // 
            this.uiPanel162.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel162.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel162.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel162.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel162.Location = new System.Drawing.Point(100, 0);
            this.uiPanel162.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel162.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel162.Name = "uiPanel162";
            this.uiPanel162.Opacity = ((byte)(180));
            this.uiPanel162.Radius = 10;
            this.uiPanel162.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel162.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel162.Size = new System.Drawing.Size(10, 33);
            this.uiPanel162.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel162.TabIndex = 10;
            this.uiPanel162.Text = null;
            this.uiPanel162.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel163
            // 
            this.uiPanel163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.Controls.Add(this.lb_TrackColorMode);
            this.uiPanel163.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel163.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel163.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel163.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel163.Location = new System.Drawing.Point(0, 0);
            this.uiPanel163.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel163.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel163.Name = "uiPanel163";
            this.uiPanel163.Opacity = ((byte)(180));
            this.uiPanel163.Radius = 10;
            this.uiPanel163.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel163.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel163.Size = new System.Drawing.Size(100, 33);
            this.uiPanel163.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel163.TabIndex = 9;
            this.uiPanel163.Text = null;
            this.uiPanel163.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackColorMode
            // 
            this.lb_TrackColorMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackColorMode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackColorMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackColorMode.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackColorMode.Name = "lb_TrackColorMode";
            this.lb_TrackColorMode.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackColorMode.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackColorMode.TabIndex = 3;
            this.lb_TrackColorMode.Text = "跟踪颜色模式：";
            this.lb_TrackColorMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel94
            // 
            this.uiPanel94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.Controls.Add(this.uiPanel95);
            this.uiPanel94.Controls.Add(this.uiPanel96);
            this.uiPanel94.Controls.Add(this.uiPanel97);
            this.uiPanel94.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel94.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel94.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel94.Location = new System.Drawing.Point(0, 105);
            this.uiPanel94.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel94.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel94.Name = "uiPanel94";
            this.uiPanel94.Opacity = ((byte)(180));
            this.uiPanel94.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel94.Radius = 10;
            this.uiPanel94.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel94.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel94.Size = new System.Drawing.Size(210, 35);
            this.uiPanel94.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel94.TabIndex = 18;
            this.uiPanel94.Text = null;
            this.uiPanel94.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel95
            // 
            this.uiPanel95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.Controls.Add(this.tb_TrackTrajectoryLineWidth);
            this.uiPanel95.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel95.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel95.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel95.Location = new System.Drawing.Point(110, 0);
            this.uiPanel95.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel95.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel95.Name = "uiPanel95";
            this.uiPanel95.Opacity = ((byte)(180));
            this.uiPanel95.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel95.Radius = 10;
            this.uiPanel95.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel95.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel95.Size = new System.Drawing.Size(100, 33);
            this.uiPanel95.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel95.TabIndex = 11;
            this.uiPanel95.Text = null;
            this.uiPanel95.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TrackTrajectoryLineWidth
            // 
            this.tb_TrackTrajectoryLineWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTrajectoryLineWidth.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_TrackTrajectoryLineWidth.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_TrackTrajectoryLineWidth.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_TrackTrajectoryLineWidth.ButtonStyleInherited = false;
            this.tb_TrackTrajectoryLineWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TrackTrajectoryLineWidth.DecimalPlaces = 1;
            this.tb_TrackTrajectoryLineWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TrackTrajectoryLineWidth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrackTrajectoryLineWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTrajectoryLineWidth.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTrajectoryLineWidth.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTrajectoryLineWidth.Location = new System.Drawing.Point(0, 3);
            this.tb_TrackTrajectoryLineWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TrackTrajectoryLineWidth.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_TrackTrajectoryLineWidth.Name = "tb_TrackTrajectoryLineWidth";
            this.tb_TrackTrajectoryLineWidth.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TrackTrajectoryLineWidth.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryLineWidth.ScrollBarStyleInherited = false;
            this.tb_TrackTrajectoryLineWidth.ShowText = false;
            this.tb_TrackTrajectoryLineWidth.Size = new System.Drawing.Size(100, 27);
            this.tb_TrackTrajectoryLineWidth.Style = Sunny.UI.UIStyle.Custom;
            this.tb_TrackTrajectoryLineWidth.TabIndex = 4;
            this.tb_TrackTrajectoryLineWidth.Text = "0.0";
            this.tb_TrackTrajectoryLineWidth.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_TrackTrajectoryLineWidth.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tb_TrackTrajectoryLineWidth.Watermark = "";
            // 
            // uiPanel96
            // 
            this.uiPanel96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel96.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel96.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel96.Location = new System.Drawing.Point(100, 0);
            this.uiPanel96.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel96.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel96.Name = "uiPanel96";
            this.uiPanel96.Opacity = ((byte)(180));
            this.uiPanel96.Radius = 10;
            this.uiPanel96.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel96.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel96.Size = new System.Drawing.Size(10, 33);
            this.uiPanel96.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel96.TabIndex = 10;
            this.uiPanel96.Text = null;
            this.uiPanel96.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel97
            // 
            this.uiPanel97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.Controls.Add(this.lb_TrackTrajectoryLineWidth);
            this.uiPanel97.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel97.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel97.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel97.Location = new System.Drawing.Point(0, 0);
            this.uiPanel97.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel97.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel97.Name = "uiPanel97";
            this.uiPanel97.Opacity = ((byte)(180));
            this.uiPanel97.Radius = 10;
            this.uiPanel97.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel97.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel97.Size = new System.Drawing.Size(100, 33);
            this.uiPanel97.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel97.TabIndex = 9;
            this.uiPanel97.Text = null;
            this.uiPanel97.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackTrajectoryLineWidth
            // 
            this.lb_TrackTrajectoryLineWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackTrajectoryLineWidth.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackTrajectoryLineWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackTrajectoryLineWidth.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackTrajectoryLineWidth.Name = "lb_TrackTrajectoryLineWidth";
            this.lb_TrackTrajectoryLineWidth.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackTrajectoryLineWidth.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackTrajectoryLineWidth.TabIndex = 7;
            this.lb_TrackTrajectoryLineWidth.Text = "轨迹线宽：";
            this.lb_TrackTrajectoryLineWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel30
            // 
            this.uiPanel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.Controls.Add(this.uiPanel31);
            this.uiPanel30.Controls.Add(this.uiPanel32);
            this.uiPanel30.Controls.Add(this.uiPanel33);
            this.uiPanel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel30.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel30.Location = new System.Drawing.Point(0, 70);
            this.uiPanel30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel30.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel30.Name = "uiPanel30";
            this.uiPanel30.Opacity = ((byte)(180));
            this.uiPanel30.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel30.Radius = 10;
            this.uiPanel30.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel30.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel30.Size = new System.Drawing.Size(210, 35);
            this.uiPanel30.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel30.TabIndex = 17;
            this.uiPanel30.Text = null;
            this.uiPanel30.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel31
            // 
            this.uiPanel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.Controls.Add(this.tb_PointSize);
            this.uiPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel31.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel31.Location = new System.Drawing.Point(110, 0);
            this.uiPanel31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel31.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel31.Name = "uiPanel31";
            this.uiPanel31.Opacity = ((byte)(180));
            this.uiPanel31.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel31.Radius = 10;
            this.uiPanel31.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel31.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel31.Size = new System.Drawing.Size(100, 33);
            this.uiPanel31.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel31.TabIndex = 11;
            this.uiPanel31.Text = null;
            this.uiPanel31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_PointSize
            // 
            this.tb_PointSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_PointSize.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_PointSize.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_PointSize.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_PointSize.ButtonStyleInherited = false;
            this.tb_PointSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_PointSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_PointSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PointSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_PointSize.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_PointSize.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_PointSize.Location = new System.Drawing.Point(0, 3);
            this.tb_PointSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_PointSize.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_PointSize.Name = "tb_PointSize";
            this.tb_PointSize.Padding = new System.Windows.Forms.Padding(5);
            this.tb_PointSize.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PointSize.ScrollBarStyleInherited = false;
            this.tb_PointSize.ShowText = false;
            this.tb_PointSize.Size = new System.Drawing.Size(100, 27);
            this.tb_PointSize.Style = Sunny.UI.UIStyle.Custom;
            this.tb_PointSize.TabIndex = 3;
            this.tb_PointSize.Text = "0";
            this.tb_PointSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_PointSize.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_PointSize.Watermark = "";
            // 
            // uiPanel32
            // 
            this.uiPanel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel32.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel32.Location = new System.Drawing.Point(100, 0);
            this.uiPanel32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel32.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel32.Name = "uiPanel32";
            this.uiPanel32.Opacity = ((byte)(180));
            this.uiPanel32.Radius = 10;
            this.uiPanel32.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel32.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel32.Size = new System.Drawing.Size(10, 33);
            this.uiPanel32.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel32.TabIndex = 10;
            this.uiPanel32.Text = null;
            this.uiPanel32.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel33
            // 
            this.uiPanel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.Controls.Add(this.lb_PointSize);
            this.uiPanel33.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel33.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel33.Location = new System.Drawing.Point(0, 0);
            this.uiPanel33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel33.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel33.Name = "uiPanel33";
            this.uiPanel33.Opacity = ((byte)(180));
            this.uiPanel33.Radius = 10;
            this.uiPanel33.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel33.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel33.Size = new System.Drawing.Size(100, 33);
            this.uiPanel33.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel33.TabIndex = 9;
            this.uiPanel33.Text = null;
            this.uiPanel33.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PointSize
            // 
            this.lb_PointSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PointSize.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PointSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_PointSize.Location = new System.Drawing.Point(0, 0);
            this.lb_PointSize.Name = "lb_PointSize";
            this.lb_PointSize.Size = new System.Drawing.Size(100, 33);
            this.lb_PointSize.Style = Sunny.UI.UIStyle.Custom;
            this.lb_PointSize.TabIndex = 2;
            this.lb_PointSize.Text = "点云大小：";
            this.lb_PointSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel34
            // 
            this.uiPanel34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.Controls.Add(this.uiPanel35);
            this.uiPanel34.Controls.Add(this.uiPanel36);
            this.uiPanel34.Controls.Add(this.uiPanel59);
            this.uiPanel34.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel34.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel34.Location = new System.Drawing.Point(0, 35);
            this.uiPanel34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel34.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel34.Name = "uiPanel34";
            this.uiPanel34.Opacity = ((byte)(180));
            this.uiPanel34.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel34.Radius = 10;
            this.uiPanel34.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel34.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel34.Size = new System.Drawing.Size(210, 35);
            this.uiPanel34.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel34.TabIndex = 16;
            this.uiPanel34.Text = null;
            this.uiPanel34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel35
            // 
            this.uiPanel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.Controls.Add(this.tb_YMax);
            this.uiPanel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel35.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel35.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel35.Location = new System.Drawing.Point(110, 0);
            this.uiPanel35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel35.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel35.Name = "uiPanel35";
            this.uiPanel35.Opacity = ((byte)(180));
            this.uiPanel35.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel35.Radius = 10;
            this.uiPanel35.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel35.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel35.Size = new System.Drawing.Size(100, 33);
            this.uiPanel35.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel35.TabIndex = 11;
            this.uiPanel35.Text = null;
            this.uiPanel35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_YMax
            // 
            this.tb_YMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YMax.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_YMax.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_YMax.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_YMax.ButtonStyleInherited = false;
            this.tb_YMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_YMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_YMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_YMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YMax.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YMax.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YMax.Location = new System.Drawing.Point(0, 3);
            this.tb_YMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_YMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_YMax.Name = "tb_YMax";
            this.tb_YMax.Padding = new System.Windows.Forms.Padding(5);
            this.tb_YMax.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMax.ScrollBarStyleInherited = false;
            this.tb_YMax.ShowText = false;
            this.tb_YMax.Size = new System.Drawing.Size(100, 27);
            this.tb_YMax.Style = Sunny.UI.UIStyle.Custom;
            this.tb_YMax.TabIndex = 1;
            this.tb_YMax.Text = "0";
            this.tb_YMax.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_YMax.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_YMax.Watermark = "";
            // 
            // uiPanel36
            // 
            this.uiPanel36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel36.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel36.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel36.Location = new System.Drawing.Point(100, 0);
            this.uiPanel36.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel36.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel36.Name = "uiPanel36";
            this.uiPanel36.Opacity = ((byte)(180));
            this.uiPanel36.Radius = 10;
            this.uiPanel36.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel36.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel36.Size = new System.Drawing.Size(10, 33);
            this.uiPanel36.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel36.TabIndex = 10;
            this.uiPanel36.Text = null;
            this.uiPanel36.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel59
            // 
            this.uiPanel59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.Controls.Add(this.lb_YMax);
            this.uiPanel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel59.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel59.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel59.Location = new System.Drawing.Point(0, 0);
            this.uiPanel59.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel59.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel59.Name = "uiPanel59";
            this.uiPanel59.Opacity = ((byte)(180));
            this.uiPanel59.Radius = 10;
            this.uiPanel59.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel59.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel59.Size = new System.Drawing.Size(100, 33);
            this.uiPanel59.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel59.TabIndex = 9;
            this.uiPanel59.Text = null;
            this.uiPanel59.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_YMax
            // 
            this.lb_YMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_YMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_YMax.Location = new System.Drawing.Point(0, 0);
            this.lb_YMax.Name = "lb_YMax";
            this.lb_YMax.Size = new System.Drawing.Size(100, 33);
            this.lb_YMax.Style = Sunny.UI.UIStyle.Custom;
            this.lb_YMax.TabIndex = 0;
            this.lb_YMax.Text = "Y轴最大值：";
            this.lb_YMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel60
            // 
            this.uiPanel60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.Controls.Add(this.uiPanel61);
            this.uiPanel60.Controls.Add(this.uiPanel62);
            this.uiPanel60.Controls.Add(this.uiPanel63);
            this.uiPanel60.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel60.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel60.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel60.Location = new System.Drawing.Point(0, 0);
            this.uiPanel60.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel60.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel60.Name = "uiPanel60";
            this.uiPanel60.Opacity = ((byte)(180));
            this.uiPanel60.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel60.Radius = 10;
            this.uiPanel60.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel60.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel60.Size = new System.Drawing.Size(210, 35);
            this.uiPanel60.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel60.TabIndex = 15;
            this.uiPanel60.Text = null;
            this.uiPanel60.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel61
            // 
            this.uiPanel61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.Controls.Add(this.tb_XMax);
            this.uiPanel61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel61.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel61.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel61.Location = new System.Drawing.Point(110, 0);
            this.uiPanel61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel61.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel61.Name = "uiPanel61";
            this.uiPanel61.Opacity = ((byte)(180));
            this.uiPanel61.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel61.Radius = 10;
            this.uiPanel61.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel61.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel61.Size = new System.Drawing.Size(100, 33);
            this.uiPanel61.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel61.TabIndex = 11;
            this.uiPanel61.Text = null;
            this.uiPanel61.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_XMax
            // 
            this.tb_XMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XMax.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_XMax.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_XMax.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_XMax.ButtonStyleInherited = false;
            this.tb_XMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_XMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_XMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_XMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XMax.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XMax.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XMax.Location = new System.Drawing.Point(0, 3);
            this.tb_XMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_XMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_XMax.Name = "tb_XMax";
            this.tb_XMax.Padding = new System.Windows.Forms.Padding(5);
            this.tb_XMax.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMax.ScrollBarStyleInherited = false;
            this.tb_XMax.ShowText = false;
            this.tb_XMax.Size = new System.Drawing.Size(100, 27);
            this.tb_XMax.Style = Sunny.UI.UIStyle.Custom;
            this.tb_XMax.TabIndex = 0;
            this.tb_XMax.Text = "0";
            this.tb_XMax.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_XMax.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_XMax.Watermark = "";
            // 
            // uiPanel62
            // 
            this.uiPanel62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel62.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel62.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel62.Location = new System.Drawing.Point(100, 0);
            this.uiPanel62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel62.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel62.Name = "uiPanel62";
            this.uiPanel62.Opacity = ((byte)(180));
            this.uiPanel62.Radius = 10;
            this.uiPanel62.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel62.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel62.Size = new System.Drawing.Size(10, 33);
            this.uiPanel62.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel62.TabIndex = 10;
            this.uiPanel62.Text = null;
            this.uiPanel62.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel63
            // 
            this.uiPanel63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.Controls.Add(this.lb_XMax);
            this.uiPanel63.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel63.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel63.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel63.Location = new System.Drawing.Point(0, 0);
            this.uiPanel63.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel63.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel63.Name = "uiPanel63";
            this.uiPanel63.Opacity = ((byte)(180));
            this.uiPanel63.Radius = 10;
            this.uiPanel63.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel63.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel63.Size = new System.Drawing.Size(100, 33);
            this.uiPanel63.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel63.TabIndex = 9;
            this.uiPanel63.Text = null;
            this.uiPanel63.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_XMax
            // 
            this.lb_XMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_XMax.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_XMax.Location = new System.Drawing.Point(0, 0);
            this.lb_XMax.Name = "lb_XMax";
            this.lb_XMax.Size = new System.Drawing.Size(100, 33);
            this.lb_XMax.Style = Sunny.UI.UIStyle.Custom;
            this.lb_XMax.TabIndex = 0;
            this.lb_XMax.Text = "X轴最大值：";
            this.lb_XMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel1.Location = new System.Drawing.Point(210, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Opacity = ((byte)(180));
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(25, 174);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 17;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Graph_Left
            // 
            this.pan_Graph_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.Controls.Add(this.uiPanel119);
            this.pan_Graph_Left.Controls.Add(this.uiPanel45);
            this.pan_Graph_Left.Controls.Add(this.uiPanel25);
            this.pan_Graph_Left.Controls.Add(this.uiPanel21);
            this.pan_Graph_Left.Controls.Add(this.uiPanel17);
            this.pan_Graph_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_Graph_Left.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Graph_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Graph_Left.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Graph_Left.Location = new System.Drawing.Point(0, 0);
            this.pan_Graph_Left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Graph_Left.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Graph_Left.Name = "pan_Graph_Left";
            this.pan_Graph_Left.Opacity = ((byte)(180));
            this.pan_Graph_Left.Radius = 10;
            this.pan_Graph_Left.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Graph_Left.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Graph_Left.Size = new System.Drawing.Size(210, 174);
            this.pan_Graph_Left.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Graph_Left.TabIndex = 16;
            this.pan_Graph_Left.Text = null;
            this.pan_Graph_Left.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel119
            // 
            this.uiPanel119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.Controls.Add(this.uiPanel120);
            this.uiPanel119.Controls.Add(this.uiPanel121);
            this.uiPanel119.Controls.Add(this.uiPanel122);
            this.uiPanel119.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel119.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel119.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel119.Location = new System.Drawing.Point(0, 140);
            this.uiPanel119.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel119.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel119.Name = "uiPanel119";
            this.uiPanel119.Opacity = ((byte)(180));
            this.uiPanel119.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel119.Radius = 10;
            this.uiPanel119.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel119.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel119.Size = new System.Drawing.Size(210, 35);
            this.uiPanel119.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel119.TabIndex = 19;
            this.uiPanel119.Text = null;
            this.uiPanel119.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel120
            // 
            this.uiPanel120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.Controls.Add(this.tb_TrackTrajectoryOuttime);
            this.uiPanel120.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel120.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel120.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel120.Location = new System.Drawing.Point(110, 0);
            this.uiPanel120.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel120.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel120.Name = "uiPanel120";
            this.uiPanel120.Opacity = ((byte)(180));
            this.uiPanel120.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel120.Radius = 10;
            this.uiPanel120.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel120.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel120.Size = new System.Drawing.Size(100, 33);
            this.uiPanel120.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel120.TabIndex = 11;
            this.uiPanel120.Text = null;
            this.uiPanel120.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TrackTrajectoryOuttime
            // 
            this.tb_TrackTrajectoryOuttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTrajectoryOuttime.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_TrackTrajectoryOuttime.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_TrackTrajectoryOuttime.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_TrackTrajectoryOuttime.ButtonStyleInherited = false;
            this.tb_TrackTrajectoryOuttime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TrackTrajectoryOuttime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TrackTrajectoryOuttime.DoubleValue = 1000D;
            this.tb_TrackTrajectoryOuttime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrackTrajectoryOuttime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_TrackTrajectoryOuttime.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTrajectoryOuttime.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_TrackTrajectoryOuttime.IntValue = 1000;
            this.tb_TrackTrajectoryOuttime.Location = new System.Drawing.Point(0, 3);
            this.tb_TrackTrajectoryOuttime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_TrackTrajectoryOuttime.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_TrackTrajectoryOuttime.Name = "tb_TrackTrajectoryOuttime";
            this.tb_TrackTrajectoryOuttime.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TrackTrajectoryOuttime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_TrackTrajectoryOuttime.ScrollBarStyleInherited = false;
            this.tb_TrackTrajectoryOuttime.ShowText = false;
            this.tb_TrackTrajectoryOuttime.Size = new System.Drawing.Size(100, 27);
            this.tb_TrackTrajectoryOuttime.Style = Sunny.UI.UIStyle.Custom;
            this.tb_TrackTrajectoryOuttime.TabIndex = 5;
            this.tb_TrackTrajectoryOuttime.Text = "1000";
            this.tb_TrackTrajectoryOuttime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_TrackTrajectoryOuttime.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_TrackTrajectoryOuttime.Watermark = "";
            // 
            // uiPanel121
            // 
            this.uiPanel121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel121.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel121.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel121.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel121.Location = new System.Drawing.Point(100, 0);
            this.uiPanel121.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel121.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel121.Name = "uiPanel121";
            this.uiPanel121.Opacity = ((byte)(180));
            this.uiPanel121.Radius = 10;
            this.uiPanel121.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel121.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel121.Size = new System.Drawing.Size(10, 33);
            this.uiPanel121.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel121.TabIndex = 10;
            this.uiPanel121.Text = null;
            this.uiPanel121.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel122
            // 
            this.uiPanel122.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.Controls.Add(this.lb_TrackTrajectoryOuttime);
            this.uiPanel122.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel122.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel122.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel122.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel122.Location = new System.Drawing.Point(0, 0);
            this.uiPanel122.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel122.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel122.Name = "uiPanel122";
            this.uiPanel122.Opacity = ((byte)(180));
            this.uiPanel122.Radius = 10;
            this.uiPanel122.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel122.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel122.Size = new System.Drawing.Size(100, 33);
            this.uiPanel122.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel122.TabIndex = 9;
            this.uiPanel122.Text = null;
            this.uiPanel122.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_TrackTrajectoryOuttime
            // 
            this.lb_TrackTrajectoryOuttime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TrackTrajectoryOuttime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrackTrajectoryOuttime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_TrackTrajectoryOuttime.Location = new System.Drawing.Point(0, 0);
            this.lb_TrackTrajectoryOuttime.Name = "lb_TrackTrajectoryOuttime";
            this.lb_TrackTrajectoryOuttime.Size = new System.Drawing.Size(100, 33);
            this.lb_TrackTrajectoryOuttime.Style = Sunny.UI.UIStyle.Custom;
            this.lb_TrackTrajectoryOuttime.TabIndex = 6;
            this.lb_TrackTrajectoryOuttime.Text = "轨迹超时(ms)：";
            this.lb_TrackTrajectoryOuttime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel45
            // 
            this.uiPanel45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.Controls.Add(this.uiPanel91);
            this.uiPanel45.Controls.Add(this.uiPanel92);
            this.uiPanel45.Controls.Add(this.uiPanel93);
            this.uiPanel45.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel45.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel45.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel45.Location = new System.Drawing.Point(0, 105);
            this.uiPanel45.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel45.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel45.Name = "uiPanel45";
            this.uiPanel45.Opacity = ((byte)(180));
            this.uiPanel45.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel45.Radius = 10;
            this.uiPanel45.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel45.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel45.Size = new System.Drawing.Size(210, 35);
            this.uiPanel45.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel45.TabIndex = 18;
            this.uiPanel45.Text = null;
            this.uiPanel45.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel91
            // 
            this.uiPanel91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.Controls.Add(this.cmb_ShowTrackTrajectory);
            this.uiPanel91.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel91.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel91.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel91.Location = new System.Drawing.Point(110, 0);
            this.uiPanel91.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel91.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel91.Name = "uiPanel91";
            this.uiPanel91.Opacity = ((byte)(180));
            this.uiPanel91.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel91.Radius = 10;
            this.uiPanel91.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel91.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel91.Size = new System.Drawing.Size(100, 33);
            this.uiPanel91.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel91.TabIndex = 11;
            this.uiPanel91.Text = null;
            this.uiPanel91.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ShowTrackTrajectory
            // 
            this.cmb_ShowTrackTrajectory.DataSource = null;
            this.cmb_ShowTrackTrajectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ShowTrackTrajectory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_ShowTrackTrajectory.DropDownWidth = 100;
            this.cmb_ShowTrackTrajectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShowTrackTrajectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ShowTrackTrajectory.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_ShowTrackTrajectory.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ShowTrackTrajectory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_ShowTrackTrajectory.Location = new System.Drawing.Point(0, 3);
            this.cmb_ShowTrackTrajectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ShowTrackTrajectory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_ShowTrackTrajectory.Name = "cmb_ShowTrackTrajectory";
            this.cmb_ShowTrackTrajectory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_ShowTrackTrajectory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowTrackTrajectory.Size = new System.Drawing.Size(100, 27);
            this.cmb_ShowTrackTrajectory.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_ShowTrackTrajectory.SymbolSize = 24;
            this.cmb_ShowTrackTrajectory.TabIndex = 7;
            this.cmb_ShowTrackTrajectory.Text = "显示";
            this.cmb_ShowTrackTrajectory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmb_ShowTrackTrajectory.Watermark = "";
            // 
            // uiPanel92
            // 
            this.uiPanel92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel92.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel92.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel92.Location = new System.Drawing.Point(100, 0);
            this.uiPanel92.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel92.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel92.Name = "uiPanel92";
            this.uiPanel92.Opacity = ((byte)(180));
            this.uiPanel92.Radius = 10;
            this.uiPanel92.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel92.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel92.Size = new System.Drawing.Size(10, 33);
            this.uiPanel92.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel92.TabIndex = 10;
            this.uiPanel92.Text = null;
            this.uiPanel92.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel93
            // 
            this.uiPanel93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.Controls.Add(this.lb_ShowTrackTrajectory);
            this.uiPanel93.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.uiPanel93.Radius = 10;
            this.uiPanel93.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel93.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel93.Size = new System.Drawing.Size(100, 33);
            this.uiPanel93.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel93.TabIndex = 9;
            this.uiPanel93.Text = null;
            this.uiPanel93.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ShowTrackTrajectory
            // 
            this.lb_ShowTrackTrajectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ShowTrackTrajectory.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowTrackTrajectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ShowTrackTrajectory.Location = new System.Drawing.Point(0, 0);
            this.lb_ShowTrackTrajectory.Name = "lb_ShowTrackTrajectory";
            this.lb_ShowTrackTrajectory.Size = new System.Drawing.Size(100, 33);
            this.lb_ShowTrackTrajectory.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ShowTrackTrajectory.TabIndex = 6;
            this.lb_ShowTrackTrajectory.Text = "跟踪轨迹：";
            this.lb_ShowTrackTrajectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel25.Location = new System.Drawing.Point(0, 70);
            this.uiPanel25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel25.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel25.Name = "uiPanel25";
            this.uiPanel25.Opacity = ((byte)(180));
            this.uiPanel25.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel25.Radius = 10;
            this.uiPanel25.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel25.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel25.Size = new System.Drawing.Size(210, 35);
            this.uiPanel25.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel25.TabIndex = 17;
            this.uiPanel25.Text = null;
            this.uiPanel25.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel26
            // 
            this.uiPanel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.Controls.Add(this.cmb_ShowType);
            this.uiPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel26.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel26.Location = new System.Drawing.Point(110, 0);
            this.uiPanel26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel26.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel26.Name = "uiPanel26";
            this.uiPanel26.Opacity = ((byte)(180));
            this.uiPanel26.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel26.Radius = 10;
            this.uiPanel26.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel26.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel26.Size = new System.Drawing.Size(100, 33);
            this.uiPanel26.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel26.TabIndex = 11;
            this.uiPanel26.Text = null;
            this.uiPanel26.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_ShowType
            // 
            this.cmb_ShowType.DataSource = null;
            this.cmb_ShowType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_ShowType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_ShowType.DropDownWidth = 100;
            this.cmb_ShowType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShowType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ShowType.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_ShowType.ItemFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmb_ShowType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.ItemSelectForeColor = System.Drawing.Color.Red;
            this.cmb_ShowType.Location = new System.Drawing.Point(0, 3);
            this.cmb_ShowType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ShowType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_ShowType.Name = "cmb_ShowType";
            this.cmb_ShowType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_ShowType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ShowType.Size = new System.Drawing.Size(100, 27);
            this.cmb_ShowType.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_ShowType.SymbolSize = 24;
            this.cmb_ShowType.TabIndex = 6;
            this.cmb_ShowType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_ShowType.Watermark = "";
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
            this.uiPanel27.Location = new System.Drawing.Point(100, 0);
            this.uiPanel27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel27.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel27.Name = "uiPanel27";
            this.uiPanel27.Opacity = ((byte)(180));
            this.uiPanel27.Radius = 10;
            this.uiPanel27.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel27.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel27.Size = new System.Drawing.Size(10, 33);
            this.uiPanel27.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel27.TabIndex = 10;
            this.uiPanel27.Text = null;
            this.uiPanel27.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel28
            // 
            this.uiPanel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.Controls.Add(this.lb_ShowType);
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
            this.uiPanel28.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel28.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel28.Size = new System.Drawing.Size(100, 33);
            this.uiPanel28.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel28.TabIndex = 9;
            this.uiPanel28.Text = null;
            this.uiPanel28.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ShowType
            // 
            this.lb_ShowType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ShowType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_ShowType.Location = new System.Drawing.Point(0, 0);
            this.lb_ShowType.Name = "lb_ShowType";
            this.lb_ShowType.Size = new System.Drawing.Size(100, 33);
            this.lb_ShowType.Style = Sunny.UI.UIStyle.Custom;
            this.lb_ShowType.TabIndex = 5;
            this.lb_ShowType.Text = "显示方案：";
            this.lb_ShowType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel21.Location = new System.Drawing.Point(0, 35);
            this.uiPanel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel21.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel21.Name = "uiPanel21";
            this.uiPanel21.Opacity = ((byte)(180));
            this.uiPanel21.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.uiPanel21.Radius = 10;
            this.uiPanel21.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel21.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel21.Size = new System.Drawing.Size(210, 35);
            this.uiPanel21.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel21.TabIndex = 16;
            this.uiPanel21.Text = null;
            this.uiPanel21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel22
            // 
            this.uiPanel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.Controls.Add(this.tb_YMin);
            this.uiPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel22.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel22.Location = new System.Drawing.Point(110, 0);
            this.uiPanel22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel22.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel22.Name = "uiPanel22";
            this.uiPanel22.Opacity = ((byte)(180));
            this.uiPanel22.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel22.Radius = 10;
            this.uiPanel22.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel22.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel22.Size = new System.Drawing.Size(100, 33);
            this.uiPanel22.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel22.TabIndex = 11;
            this.uiPanel22.Text = null;
            this.uiPanel22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_YMin
            // 
            this.tb_YMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YMin.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_YMin.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_YMin.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_YMin.ButtonStyleInherited = false;
            this.tb_YMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_YMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_YMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_YMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_YMin.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YMin.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_YMin.Location = new System.Drawing.Point(0, 3);
            this.tb_YMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_YMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_YMin.Name = "tb_YMin";
            this.tb_YMin.Padding = new System.Windows.Forms.Padding(5);
            this.tb_YMin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_YMin.ScrollBarStyleInherited = false;
            this.tb_YMin.ShowText = false;
            this.tb_YMin.Size = new System.Drawing.Size(100, 27);
            this.tb_YMin.Style = Sunny.UI.UIStyle.Custom;
            this.tb_YMin.TabIndex = 1;
            this.tb_YMin.Text = "0";
            this.tb_YMin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_YMin.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_YMin.Watermark = "";
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
            this.uiPanel23.Location = new System.Drawing.Point(100, 0);
            this.uiPanel23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel23.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel23.Name = "uiPanel23";
            this.uiPanel23.Opacity = ((byte)(180));
            this.uiPanel23.Radius = 10;
            this.uiPanel23.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel23.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel23.Size = new System.Drawing.Size(10, 33);
            this.uiPanel23.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel23.TabIndex = 10;
            this.uiPanel23.Text = null;
            this.uiPanel23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel24
            // 
            this.uiPanel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.Controls.Add(this.lb_YMin);
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
            this.uiPanel24.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel24.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel24.Size = new System.Drawing.Size(100, 33);
            this.uiPanel24.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel24.TabIndex = 9;
            this.uiPanel24.Text = null;
            this.uiPanel24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_YMin
            // 
            this.lb_YMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_YMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_YMin.Location = new System.Drawing.Point(0, 0);
            this.lb_YMin.Name = "lb_YMin";
            this.lb_YMin.Size = new System.Drawing.Size(100, 33);
            this.lb_YMin.Style = Sunny.UI.UIStyle.Custom;
            this.lb_YMin.TabIndex = 0;
            this.lb_YMin.Text = "Y轴最小值：";
            this.lb_YMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel17.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel17.Size = new System.Drawing.Size(210, 35);
            this.uiPanel17.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel17.TabIndex = 15;
            this.uiPanel17.Text = null;
            this.uiPanel17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel18
            // 
            this.uiPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Controls.Add(this.tb_XMin);
            this.uiPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel18.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel18.Location = new System.Drawing.Point(110, 0);
            this.uiPanel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel18.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel18.Name = "uiPanel18";
            this.uiPanel18.Opacity = ((byte)(180));
            this.uiPanel18.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel18.Radius = 10;
            this.uiPanel18.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel18.Size = new System.Drawing.Size(100, 33);
            this.uiPanel18.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel18.TabIndex = 11;
            this.uiPanel18.Text = null;
            this.uiPanel18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_XMin
            // 
            this.tb_XMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XMin.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_XMin.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_XMin.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_XMin.ButtonStyleInherited = false;
            this.tb_XMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_XMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_XMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_XMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_XMin.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XMin.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_XMin.Location = new System.Drawing.Point(0, 3);
            this.tb_XMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_XMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_XMin.Name = "tb_XMin";
            this.tb_XMin.Padding = new System.Windows.Forms.Padding(5);
            this.tb_XMin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_XMin.ScrollBarStyleInherited = false;
            this.tb_XMin.ShowText = false;
            this.tb_XMin.Size = new System.Drawing.Size(100, 27);
            this.tb_XMin.Style = Sunny.UI.UIStyle.Custom;
            this.tb_XMin.TabIndex = 0;
            this.tb_XMin.Text = "0";
            this.tb_XMin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_XMin.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tb_XMin.Watermark = "";
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
            this.uiPanel19.Location = new System.Drawing.Point(100, 0);
            this.uiPanel19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel19.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel19.Name = "uiPanel19";
            this.uiPanel19.Opacity = ((byte)(180));
            this.uiPanel19.Radius = 10;
            this.uiPanel19.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel19.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel19.Size = new System.Drawing.Size(10, 33);
            this.uiPanel19.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel19.TabIndex = 10;
            this.uiPanel19.Text = null;
            this.uiPanel19.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel20
            // 
            this.uiPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.Controls.Add(this.lb_XMin);
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
            this.uiPanel20.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel20.Size = new System.Drawing.Size(100, 33);
            this.uiPanel20.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel20.TabIndex = 9;
            this.uiPanel20.Text = null;
            this.uiPanel20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_XMin
            // 
            this.lb_XMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_XMin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lb_XMin.Location = new System.Drawing.Point(0, 0);
            this.lb_XMin.Name = "lb_XMin";
            this.lb_XMin.Size = new System.Drawing.Size(100, 33);
            this.lb_XMin.Style = Sunny.UI.UIStyle.Custom;
            this.lb_XMin.TabIndex = 0;
            this.lb_XMin.Text = "X轴最小值：";
            this.lb_XMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiPanel3.Size = new System.Drawing.Size(1160, 10);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 9;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_GraphTitle
            // 
            this.lb_GraphTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_GraphTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.lb_GraphTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lb_GraphTitle.Location = new System.Drawing.Point(10, 10);
            this.lb_GraphTitle.Name = "lb_GraphTitle";
            this.lb_GraphTitle.Size = new System.Drawing.Size(1160, 21);
            this.lb_GraphTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lb_GraphTitle.TabIndex = 1;
            this.lb_GraphTitle.Text = "图表参数";
            this.lb_GraphTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SystemSetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1200, 710);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.pan_Main);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MaximizeBox = false;
            this.Name = "SystemSetForm";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowIcon = false;
            this.ShowRect = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "系统参数配置";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.SystemSetForm_Load);
            this.pan_Main.ResumeLayout(false);
            this.pan_Left.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel43.ResumeLayout(false);
            this.uiPanel44.ResumeLayout(false);
            this.uiPanel48.ResumeLayout(false);
            this.pan_TarTextEnable.ResumeLayout(false);
            this.uiPanel169.ResumeLayout(false);
            this.uiPanel167.ResumeLayout(false);
            this.uiPanel165.ResumeLayout(false);
            this.uiPanel53.ResumeLayout(false);
            this.uiPanel46.ResumeLayout(false);
            this.uiPanel49.ResumeLayout(false);
            this.uiPanel51.ResumeLayout(false);
            this.uiPanel47.ResumeLayout(false);
            this.uiPanel99.ResumeLayout(false);
            this.uiPanel100.ResumeLayout(false);
            this.uiPanel101.ResumeLayout(false);
            this.uiPanel102.ResumeLayout(false);
            this.uiPanel103.ResumeLayout(false);
            this.uiPanel109.ResumeLayout(false);
            this.uiPanel114.ResumeLayout(false);
            this.uiPanel115.ResumeLayout(false);
            this.uiPanel107.ResumeLayout(false);
            this.uiPanel108.ResumeLayout(false);
            this.uiPanel58.ResumeLayout(false);
            this.uiPanel77.ResumeLayout(false);
            this.uiPanel87.ResumeLayout(false);
            this.uiPanel78.ResumeLayout(false);
            this.uiPanel79.ResumeLayout(false);
            this.uiPanel80.ResumeLayout(false);
            this.uiPanel85.ResumeLayout(false);
            this.uiPanel81.ResumeLayout(false);
            this.uiPanel83.ResumeLayout(false);
            this.uiPanel89.ResumeLayout(false);
            this.pan_ControlArea.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            this.pan_HeightColor.ResumeLayout(false);
            this.uiPanel57.ResumeLayout(false);
            this.uiPanel56.ResumeLayout(false);
            this.uiPanel55.ResumeLayout(false);
            this.uiPanel41.ResumeLayout(false);
            this.uiPanel40.ResumeLayout(false);
            this.uiPanel39.ResumeLayout(false);
            this.uiPanel38.ResumeLayout(false);
            this.uiPanel37.ResumeLayout(false);
            this.uiPanel16.ResumeLayout(false);
            this.uiPanel15.ResumeLayout(false);
            this.uiPanel14.ResumeLayout(false);
            this.uiPanel13.ResumeLayout(false);
            this.pan_Purple.ResumeLayout(false);
            this.uiPanel12.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.pan_GraphParams.ResumeLayout(false);
            this.pan_Graph.ResumeLayout(false);
            this.uiPanel142.ResumeLayout(false);
            this.uiPanel143.ResumeLayout(false);
            this.uiPanel144.ResumeLayout(false);
            this.uiPanel146.ResumeLayout(false);
            this.uiPanel147.ResumeLayout(false);
            this.uiPanel148.ResumeLayout(false);
            this.uiPanel150.ResumeLayout(false);
            this.uiPanel151.ResumeLayout(false);
            this.uiPanel152.ResumeLayout(false);
            this.uiPanel154.ResumeLayout(false);
            this.uiPanel155.ResumeLayout(false);
            this.uiPanel156.ResumeLayout(false);
            this.uiPanel158.ResumeLayout(false);
            this.uiPanel123.ResumeLayout(false);
            this.uiPanel124.ResumeLayout(false);
            this.uiPanel125.ResumeLayout(false);
            this.uiPanel127.ResumeLayout(false);
            this.uiPanel128.ResumeLayout(false);
            this.uiPanel129.ResumeLayout(false);
            this.uiPanel131.ResumeLayout(false);
            this.uiPanel132.ResumeLayout(false);
            this.uiPanel133.ResumeLayout(false);
            this.uiPanel135.ResumeLayout(false);
            this.uiPanel136.ResumeLayout(false);
            this.uiPanel137.ResumeLayout(false);
            this.uiPanel139.ResumeLayout(false);
            this.uiPanel29.ResumeLayout(false);
            this.uiPanel112.ResumeLayout(false);
            this.uiPanel116.ResumeLayout(false);
            this.uiPanel118.ResumeLayout(false);
            this.uiPanel65.ResumeLayout(false);
            this.uiPanel66.ResumeLayout(false);
            this.uiPanel68.ResumeLayout(false);
            this.uiPanel69.ResumeLayout(false);
            this.uiPanel70.ResumeLayout(false);
            this.uiPanel72.ResumeLayout(false);
            this.uiPanel73.ResumeLayout(false);
            this.uiPanel74.ResumeLayout(false);
            this.uiPanel76.ResumeLayout(false);
            this.pan_Graph_Middle.ResumeLayout(false);
            this.uiPanel160.ResumeLayout(false);
            this.uiPanel161.ResumeLayout(false);
            this.uiPanel163.ResumeLayout(false);
            this.uiPanel94.ResumeLayout(false);
            this.uiPanel95.ResumeLayout(false);
            this.uiPanel97.ResumeLayout(false);
            this.uiPanel30.ResumeLayout(false);
            this.uiPanel31.ResumeLayout(false);
            this.uiPanel33.ResumeLayout(false);
            this.uiPanel34.ResumeLayout(false);
            this.uiPanel35.ResumeLayout(false);
            this.uiPanel59.ResumeLayout(false);
            this.uiPanel60.ResumeLayout(false);
            this.uiPanel61.ResumeLayout(false);
            this.uiPanel63.ResumeLayout(false);
            this.pan_Graph_Left.ResumeLayout(false);
            this.uiPanel119.ResumeLayout(false);
            this.uiPanel120.ResumeLayout(false);
            this.uiPanel122.ResumeLayout(false);
            this.uiPanel45.ResumeLayout(false);
            this.uiPanel91.ResumeLayout(false);
            this.uiPanel93.ResumeLayout(false);
            this.uiPanel25.ResumeLayout(false);
            this.uiPanel26.ResumeLayout(false);
            this.uiPanel28.ResumeLayout(false);
            this.uiPanel21.ResumeLayout(false);
            this.uiPanel22.ResumeLayout(false);
            this.uiPanel24.ResumeLayout(false);
            this.uiPanel17.ResumeLayout(false);
            this.uiPanel18.ResumeLayout(false);
            this.uiPanel20.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel pan_Main;
        private FolderBrowserDialog folderBrowserDialog1;
        private Sunny.UI.UIPanel pan_Left;
        private Sunny.UI.UIPanel pan_ControlArea;
        private Sunny.UI.UILabel lb_ColorTitle;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel pan_GraphParams;
        private Sunny.UI.UIPanel pan_Graph;
        private Sunny.UI.UIPanel pan_Graph_Left;
        private Sunny.UI.UIPanel uiPanel25;
        private Sunny.UI.UIPanel uiPanel26;
        private Sunny.UI.UIPanel uiPanel27;
        private Sunny.UI.UIPanel uiPanel28;
        private Sunny.UI.UIPanel uiPanel21;
        private Sunny.UI.UIPanel uiPanel22;
        private Sunny.UI.UIPanel uiPanel23;
        private Sunny.UI.UIPanel uiPanel24;
        private Sunny.UI.UILabel lb_YMin;
        private Sunny.UI.UIPanel uiPanel17;
        private Sunny.UI.UIPanel uiPanel18;
        private Sunny.UI.UIPanel uiPanel19;
        private Sunny.UI.UIPanel uiPanel20;
        private Sunny.UI.UILabel lb_XMin;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel lb_GraphTitle;
        private Sunny.UI.UITextBox tb_XMin;
        private Sunny.UI.UITextBox tb_YMin;
        private Sunny.UI.UIPanel pan_Graph_Middle;
        private Sunny.UI.UIPanel uiPanel30;
        private Sunny.UI.UIPanel uiPanel31;
        private Sunny.UI.UIPanel uiPanel32;
        private Sunny.UI.UIPanel uiPanel33;
        private Sunny.UI.UIPanel uiPanel34;
        private Sunny.UI.UIPanel uiPanel35;
        private Sunny.UI.UITextBox tb_YMax;
        private Sunny.UI.UIPanel uiPanel36;
        private Sunny.UI.UIPanel uiPanel59;
        private Sunny.UI.UILabel lb_YMax;
        private Sunny.UI.UIPanel uiPanel60;
        private Sunny.UI.UIPanel uiPanel61;
        private Sunny.UI.UITextBox tb_XMax;
        private Sunny.UI.UIPanel uiPanel62;
        private Sunny.UI.UIPanel uiPanel63;
        private Sunny.UI.UILabel lb_XMax;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel64;
        private Sunny.UI.UIPanel uiPanel29;
        private Sunny.UI.UIPanel uiPanel65;
        private Sunny.UI.UIPanel uiPanel66;
        private Sunny.UI.UIPanel uiPanel67;
        private Sunny.UI.UIPanel uiPanel68;
        private Sunny.UI.UIPanel uiPanel69;
        private Sunny.UI.UIPanel uiPanel70;
        private Sunny.UI.UITextBox tb_YStep;
        private Sunny.UI.UIPanel uiPanel71;
        private Sunny.UI.UIPanel uiPanel72;
        private Sunny.UI.UILabel lb_YStep;
        private Sunny.UI.UIPanel uiPanel73;
        private Sunny.UI.UIPanel uiPanel74;
        private Sunny.UI.UITextBox tb_XStep;
        private Sunny.UI.UIPanel uiPanel75;
        private Sunny.UI.UIPanel uiPanel76;
        private Sunny.UI.UILabel lb_XStep;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UIPanel uiPanel10;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIRadioButton rb_DefaultColor;
        private Sunny.UI.UIPanel uiPanel12;
        private Sunny.UI.UIRadioButton rb_HeightColor;
        private Sunny.UI.UIPanel uiPanel11;
        private Sunny.UI.UIPanel uiPanel88;
        private Sunny.UI.UIPanel uiPanel58;
        private Sunny.UI.UIPanel uiPanel77;
        private Sunny.UI.UIPanel uiPanel87;
        private Sunny.UI.UIPanel uiPanel89;
        private Sunny.UI.UICheckBox cb_TargetSave;
        private Sunny.UI.UIPanel uiPanel90;
        private Sunny.UI.UILabel lb_SaveDataParams;
        private Sunny.UI.UIPanel uiPanel45;
        private Sunny.UI.UIPanel uiPanel91;
        private Sunny.UI.UIPanel uiPanel92;
        private Sunny.UI.UIPanel uiPanel93;
        private Sunny.UI.UIPanel uiPanel94;
        private Sunny.UI.UIPanel uiPanel95;
        private Sunny.UI.UIPanel uiPanel96;
        private Sunny.UI.UIPanel uiPanel97;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel43;
        private Sunny.UI.UIPanel uiPanel44;
        private Sunny.UI.UIPanel uiPanel47;
        private Sunny.UI.UICheckBox cb_DisplayTrackText;
        private Sunny.UI.UIPanel uiPanel42;
        private Sunny.UI.UILabel lb_TextParams;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel99;
        private Sunny.UI.UIPanel uiPanel100;
        private Sunny.UI.UIPanel uiPanel101;
        private Sunny.UI.UIPanel uiPanel102;
        private Sunny.UI.UIPanel uiPanel103;
        private Sunny.UI.UIPanel uiPanel107;
        private Sunny.UI.UIPanel uiPanel108;
        private Sunny.UI.UILabel lb_ReplayDataFormat;
        private Sunny.UI.UIPanel uiPanel111;
        private Sunny.UI.UILabel lb_DataReplayParams;
        private Sunny.UI.UIPanel uiPanel98;
        private Sunny.UI.UIComboBox cmb_ReplayDataFormat;
        private Sunny.UI.UIPanel uiPanel112;
        private Sunny.UI.UIPanel uiPanel116;
        private Sunny.UI.UIPanel uiPanel117;
        private Sunny.UI.UIPanel uiPanel118;
        private Sunny.UI.UIPanel uiPanel119;
        private Sunny.UI.UIPanel uiPanel120;
        private Sunny.UI.UIPanel uiPanel121;
        private Sunny.UI.UIPanel uiPanel122;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIButton btn_Save;
        private Sunny.UI.UIPanel uiPanel86;
        private Sunny.UI.UIPanel uiPanel123;
        private Sunny.UI.UIPanel uiPanel124;
        private Sunny.UI.UIPanel uiPanel125;
        private Sunny.UI.UIPanel uiPanel126;
        private Sunny.UI.UIPanel uiPanel127;
        private Sunny.UI.UIPanel uiPanel128;
        private Sunny.UI.UIPanel uiPanel129;
        private Sunny.UI.UIPanel uiPanel130;
        private Sunny.UI.UIPanel uiPanel131;
        private Sunny.UI.UIPanel uiPanel132;
        private Sunny.UI.UIPanel uiPanel133;
        private Sunny.UI.UIPanel uiPanel134;
        private Sunny.UI.UIPanel uiPanel135;
        private Sunny.UI.UIPanel uiPanel136;
        private Sunny.UI.UIPanel uiPanel137;
        private Sunny.UI.UIPanel uiPanel138;
        private Sunny.UI.UIPanel uiPanel139;
        private Sunny.UI.UIPanel uiPanel104;
        private Sunny.UI.UIPanel pan_HeightColor;
        private Sunny.UI.UIPanel uiPanel57;
        private Sunny.UI.UIBreadcrumb color_Red;
        private Sunny.UI.UIPanel uiPanel56;
        private Sunny.UI.UITextBox tb_RedValue;
        private Sunny.UI.UIPanel uiPanel55;
        private Sunny.UI.UIBreadcrumb color_Orange;
        private Sunny.UI.UIPanel uiPanel41;
        private Sunny.UI.UITextBox tb_OrangeValue;
        private Sunny.UI.UIPanel uiPanel40;
        private Sunny.UI.UIBreadcrumb color_Yellow;
        private Sunny.UI.UIPanel uiPanel39;
        private Sunny.UI.UITextBox tb_YellowValue;
        private Sunny.UI.UIPanel uiPanel38;
        private Sunny.UI.UIBreadcrumb color_Green;
        private Sunny.UI.UIPanel uiPanel37;
        private Sunny.UI.UITextBox tb_GreenValue;
        private Sunny.UI.UIPanel uiPanel16;
        private Sunny.UI.UIBreadcrumb color_Cyan;
        private Sunny.UI.UIPanel uiPanel15;
        private Sunny.UI.UITextBox tb_CyanValue;
        private Sunny.UI.UIPanel uiPanel14;
        private Sunny.UI.UIBreadcrumb color_Blue;
        private Sunny.UI.UIPanel uiPanel13;
        private Sunny.UI.UITextBox tb_BlueValue;
        private Sunny.UI.UIPanel pan_Purple;
        private Sunny.UI.UIBreadcrumb color_Purple;
        private Sunny.UI.UIPanel uiPanel140;
        private Sunny.UI.UIPanel uiPanel142;
        private Sunny.UI.UIPanel uiPanel143;
        private Sunny.UI.UIPanel uiPanel144;
        private Sunny.UI.UIPanel uiPanel145;
        private Sunny.UI.UIPanel uiPanel146;
        private Sunny.UI.UIPanel uiPanel147;
        private Sunny.UI.UIPanel uiPanel148;
        private Sunny.UI.UIPanel uiPanel149;
        private Sunny.UI.UIPanel uiPanel150;
        private Sunny.UI.UIPanel uiPanel151;
        private Sunny.UI.UIPanel uiPanel152;
        private Sunny.UI.UIPanel uiPanel153;
        private Sunny.UI.UIPanel uiPanel154;
        private Sunny.UI.UIPanel uiPanel155;
        private Sunny.UI.UIPanel uiPanel156;
        private Sunny.UI.UIComboBox cmb_CumulativeFramesType;
        private Sunny.UI.UIPanel uiPanel157;
        private Sunny.UI.UIPanel uiPanel158;
        private Sunny.UI.UILabel lb_CumulativeFramesType;
        private Sunny.UI.UIPanel uiPanel141;
        private Sunny.UI.UITextBox tb_CumulativeFrames;
        private Sunny.UI.UILabel lb_CumulativeFramesText;
        private Sunny.UI.UITextBox tb_ZMax;
        private Sunny.UI.UILabel lb_ZMax;
        private Sunny.UI.UITextBox tb_ZMin;
        private Sunny.UI.UILabel lb_ZMin;
        private Sunny.UI.UITextBox tb_TrackSize;
        private Sunny.UI.UILabel lb_TrackSize;
        private Sunny.UI.UITextBox tb_PointSize;
        private Sunny.UI.UILabel lb_PointSize;
        private Sunny.UI.UIComboBox cmb_ShowType;
        private Sunny.UI.UILabel lb_ShowType;
        private Sunny.UI.UILabel lb_TrackColor;
        private Sunny.UI.UIColorPicker cp_TrackColor;
        private Sunny.UI.UIColorPicker cp_TrackTextColor;
        private Sunny.UI.UILabel lb_TrackTextColor;
        private Sunny.UI.UIComboBox cmb_ShowTrackTrajectory;
        private Sunny.UI.UILabel lb_ShowTrackTrajectory;
        private Sunny.UI.UILabel lb_TrackTrajectoryLineWidth;
        private Sunny.UI.UITextBox tb_TrackTrajectoryLineWidth;
        private Sunny.UI.UITextBox tb_MaxTrajectoryNum;
        private Sunny.UI.UILabel lb_MaxTrajectoryNum;
        private Sunny.UI.UIColorPicker cp_TrackTrajectoryColor;
        private Sunny.UI.UILabel lb_TrackTrajectoryColor;
        private Sunny.UI.UIPanel uiPanel48;
        private Sunny.UI.UIPanel pan_TarTextEnable;
        private Sunny.UI.UIPanel uiPanel53;
        private Sunny.UI.UICheckBox cb_Z;
        private Sunny.UI.UIPanel uiPanel54;
        private Sunny.UI.UIPanel uiPanel46;
        private Sunny.UI.UICheckBox cb_Y;
        private Sunny.UI.UIPanel uiPanel52;
        private Sunny.UI.UIPanel uiPanel49;
        private Sunny.UI.UICheckBox cb_X;
        private Sunny.UI.UIPanel uiPanel50;
        private Sunny.UI.UIPanel uiPanel51;
        private Sunny.UI.UICheckBox cb_ID;
        private Sunny.UI.UIPanel uiPanel105;
        private Sunny.UI.UIPanel uiPanel109;
        private Sunny.UI.UIPanel uiPanel110;
        private Sunny.UI.UIPanel uiPanel113;
        private Sunny.UI.UIPanel uiPanel114;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tb_FrameCycle;
        private Sunny.UI.UIPanel uiPanel115;
        private Sunny.UI.UILabel lb_FrameCycle;
        private Sunny.UI.UIPanel uiPanel159;
        private Sunny.UI.UIPanel uiPanel78;
        private Sunny.UI.UIPanel uiPanel79;
        private Sunny.UI.UIPanel uiPanel80;
        private Sunny.UI.UIPanel uiPanel85;
        private Sunny.UI.UIRichTextBox tb_FilePath;
        private Sunny.UI.UIPanel uiPanel82;
        private Sunny.UI.UIPanel uiPanel84;
        private Sunny.UI.UIPanel uiPanel81;
        private Sunny.UI.UILabel lb_FileSizeUnit;
        private Sunny.UI.UITextBox tb_FileSize;
        private Sunny.UI.UIPanel uiPanel83;
        private Sunny.UI.UILabel lb_FileSize;
        private Sunny.UI.UIPanel uiPanel106;
        private Sunny.UI.UITextBox tb_TrackTextSize;
        private Sunny.UI.UILabel lb_TrackTextSize;
        private Sunny.UI.UITextBox tb_TrackTrajectoryOuttime;
        private Sunny.UI.UILabel lb_TrackTrajectoryOuttime;
        private Sunny.UI.UIPanel uiPanel160;
        private Sunny.UI.UIPanel uiPanel161;
        private Sunny.UI.UIPanel uiPanel162;
        private Sunny.UI.UIPanel uiPanel163;
        private Sunny.UI.UILabel lb_TrackColorMode;
        private Sunny.UI.UIComboBox cmb_TrackColorMode;
        private Sunny.UI.UIPanel uiPanel165;
        private Sunny.UI.UICheckBox cb_Velocity;
        private Sunny.UI.UIPanel uiPanel164;
        private Sunny.UI.UIPanel uiPanel167;
        private Sunny.UI.UICheckBox cb_AngleH;
        private Sunny.UI.UIPanel uiPanel166;
        private Sunny.UI.UIPanel uiPanel168;
        private Sunny.UI.UIPanel uiPanel169;
        private Sunny.UI.UICheckBox cb_Confidence;
    }
}
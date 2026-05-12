using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UCM_Tools.Forms
{
    partial class RadarAliveForm
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
            this.pan_Alive = new Sunny.UI.UIPanel();
            this.uiPanel13 = new Sunny.UI.UIPanel();
            this.uiPanel14 = new Sunny.UI.UIPanel();
            this.tb_Result = new Sunny.UI.UITextBox();
            this.uiPanel15 = new Sunny.UI.UIPanel();
            this.uiPanel16 = new Sunny.UI.UIPanel();
            this.btn_Result = new Sunny.UI.UIButton();
            this.uiPanel12 = new Sunny.UI.UIPanel();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.tb_KeyID = new Sunny.UI.UITextBox();
            this.uiPanel10 = new Sunny.UI.UIPanel();
            this.uiPanel11 = new Sunny.UI.UIPanel();
            this.btn_KeyID = new Sunny.UI.UIButton();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.tb_HardwareID = new Sunny.UI.UITextBox();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.btn_HardwareID = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.panel1 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.tb_AliveStatus = new Sunny.UI.UITextBox();
            this.uiPanel18 = new Sunny.UI.UIPanel();
            this.uiPanel20 = new Sunny.UI.UIPanel();
            this.btn_AliveStatus = new Sunny.UI.UIButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pan_Main.SuspendLayout();
            this.pan_Left.SuspendLayout();
            this.pan_Alive.SuspendLayout();
            this.uiPanel13.SuspendLayout();
            this.uiPanel14.SuspendLayout();
            this.uiPanel16.SuspendLayout();
            this.uiPanel8.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.uiPanel11.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
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
            this.pan_Main.Size = new System.Drawing.Size(588, 187);
            this.pan_Main.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Main.TabIndex = 1;
            this.pan_Main.Text = null;
            this.pan_Main.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Left
            // 
            this.pan_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.Controls.Add(this.pan_Alive);
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
            this.pan_Left.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.pan_Left.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Left.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pan_Left.Size = new System.Drawing.Size(588, 187);
            this.pan_Left.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Left.TabIndex = 3;
            this.pan_Left.Text = null;
            this.pan_Left.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_Alive
            // 
            this.pan_Alive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.Controls.Add(this.uiPanel13);
            this.pan_Alive.Controls.Add(this.uiPanel12);
            this.pan_Alive.Controls.Add(this.uiPanel8);
            this.pan_Alive.Controls.Add(this.uiPanel7);
            this.pan_Alive.Controls.Add(this.uiPanel3);
            this.pan_Alive.Controls.Add(this.uiPanel2);
            this.pan_Alive.Controls.Add(this.panel1);
            this.pan_Alive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Alive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_Alive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pan_Alive.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pan_Alive.Location = new System.Drawing.Point(0, 0);
            this.pan_Alive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_Alive.MinimumSize = new System.Drawing.Size(1, 1);
            this.pan_Alive.Name = "pan_Alive";
            this.pan_Alive.Opacity = ((byte)(180));
            this.pan_Alive.Padding = new System.Windows.Forms.Padding(10);
            this.pan_Alive.Radius = 10;
            this.pan_Alive.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pan_Alive.Size = new System.Drawing.Size(588, 187);
            this.pan_Alive.Style = Sunny.UI.UIStyle.Custom;
            this.pan_Alive.TabIndex = 5;
            this.pan_Alive.Text = null;
            this.pan_Alive.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel13
            // 
            this.uiPanel13.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel13.Controls.Add(this.uiPanel14);
            this.uiPanel13.Controls.Add(this.uiPanel15);
            this.uiPanel13.Controls.Add(this.uiPanel16);
            this.uiPanel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel13.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel13.Location = new System.Drawing.Point(10, 139);
            this.uiPanel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel13.Name = "uiPanel13";
            this.uiPanel13.Opacity = ((byte)(180));
            this.uiPanel13.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel13.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel13.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel13.Size = new System.Drawing.Size(568, 33);
            this.uiPanel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel13.TabIndex = 18;
            this.uiPanel13.Text = null;
            this.uiPanel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel14
            // 
            this.uiPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.Controls.Add(this.tb_Result);
            this.uiPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.uiPanel14.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel14.Radius = 10;
            this.uiPanel14.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel14.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel14.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel14.Size = new System.Drawing.Size(458, 33);
            this.uiPanel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel14.TabIndex = 13;
            this.uiPanel14.Text = null;
            this.uiPanel14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Result
            // 
            this.tb_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_Result.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_Result.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_Result.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_Result.ButtonStyleInherited = false;
            this.tb_Result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Result.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_Result.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Result.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Result.Location = new System.Drawing.Point(0, 3);
            this.tb_Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Result.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Result.ReadOnly = true;
            this.tb_Result.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Result.ScrollBarStyleInherited = false;
            this.tb_Result.ShowText = false;
            this.tb_Result.Size = new System.Drawing.Size(458, 27);
            this.tb_Result.Style = Sunny.UI.UIStyle.Custom;
            this.tb_Result.TabIndex = 4;
            this.tb_Result.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_Result.Watermark = "";
            // 
            // uiPanel15
            // 
            this.uiPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel15.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel15.Location = new System.Drawing.Point(100, 0);
            this.uiPanel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel15.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel15.Name = "uiPanel15";
            this.uiPanel15.Opacity = ((byte)(180));
            this.uiPanel15.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel15.Radius = 10;
            this.uiPanel15.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel15.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel15.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel15.Size = new System.Drawing.Size(10, 33);
            this.uiPanel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel15.TabIndex = 12;
            this.uiPanel15.Text = null;
            this.uiPanel15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel16
            // 
            this.uiPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Controls.Add(this.btn_Result);
            this.uiPanel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel16.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel16.Location = new System.Drawing.Point(0, 0);
            this.uiPanel16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel16.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel16.Name = "uiPanel16";
            this.uiPanel16.Opacity = ((byte)(180));
            this.uiPanel16.Radius = 10;
            this.uiPanel16.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel16.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel16.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel16.Size = new System.Drawing.Size(100, 33);
            this.uiPanel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel16.TabIndex = 10;
            this.uiPanel16.Text = null;
            this.uiPanel16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Result
            // 
            this.btn_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Result.Enabled = false;
            this.btn_Result.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Result.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Result.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_Result.ForePressColor = System.Drawing.Color.Red;
            this.btn_Result.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_Result.Location = new System.Drawing.Point(0, 0);
            this.btn_Result.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Result.RectPressColor = System.Drawing.Color.Red;
            this.btn_Result.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_Result.Size = new System.Drawing.Size(100, 33);
            this.btn_Result.Style = Sunny.UI.UIStyle.Custom;
            this.btn_Result.TabIndex = 1;
            this.btn_Result.Text = "激活结果";
            this.btn_Result.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uiPanel12
            // 
            this.uiPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel12.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel12.Location = new System.Drawing.Point(10, 129);
            this.uiPanel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel12.Name = "uiPanel12";
            this.uiPanel12.Opacity = ((byte)(180));
            this.uiPanel12.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel12.Radius = 10;
            this.uiPanel12.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel12.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel12.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel12.Size = new System.Drawing.Size(568, 10);
            this.uiPanel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel12.TabIndex = 17;
            this.uiPanel12.Text = null;
            this.uiPanel12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel8
            // 
            this.uiPanel8.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel8.Controls.Add(this.uiPanel9);
            this.uiPanel8.Controls.Add(this.uiPanel10);
            this.uiPanel8.Controls.Add(this.uiPanel11);
            this.uiPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel8.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel8.Location = new System.Drawing.Point(10, 96);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.Opacity = ((byte)(180));
            this.uiPanel8.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel8.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel8.Size = new System.Drawing.Size(568, 33);
            this.uiPanel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel8.TabIndex = 16;
            this.uiPanel8.Text = null;
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel9
            // 
            this.uiPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Controls.Add(this.tb_KeyID);
            this.uiPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel9.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel9.Location = new System.Drawing.Point(110, 0);
            this.uiPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel9.Name = "uiPanel9";
            this.uiPanel9.Opacity = ((byte)(180));
            this.uiPanel9.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel9.Radius = 10;
            this.uiPanel9.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel9.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel9.Size = new System.Drawing.Size(458, 33);
            this.uiPanel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel9.TabIndex = 13;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_KeyID
            // 
            this.tb_KeyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_KeyID.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_KeyID.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_KeyID.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_KeyID.ButtonStyleInherited = false;
            this.tb_KeyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_KeyID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_KeyID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KeyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_KeyID.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_KeyID.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_KeyID.Location = new System.Drawing.Point(0, 3);
            this.tb_KeyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_KeyID.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_KeyID.Name = "tb_KeyID";
            this.tb_KeyID.Padding = new System.Windows.Forms.Padding(5);
            this.tb_KeyID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_KeyID.ScrollBarStyleInherited = false;
            this.tb_KeyID.ShowText = false;
            this.tb_KeyID.Size = new System.Drawing.Size(458, 27);
            this.tb_KeyID.Style = Sunny.UI.UIStyle.Custom;
            this.tb_KeyID.TabIndex = 4;
            this.tb_KeyID.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_KeyID.Watermark = "";
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
            this.uiPanel10.Location = new System.Drawing.Point(100, 0);
            this.uiPanel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.Opacity = ((byte)(180));
            this.uiPanel10.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel10.Radius = 10;
            this.uiPanel10.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel10.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel10.Size = new System.Drawing.Size(10, 33);
            this.uiPanel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel10.TabIndex = 12;
            this.uiPanel10.Text = null;
            this.uiPanel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel11
            // 
            this.uiPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.Controls.Add(this.btn_KeyID);
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
            this.uiPanel11.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel11.Size = new System.Drawing.Size(100, 33);
            this.uiPanel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel11.TabIndex = 10;
            this.uiPanel11.Text = null;
            this.uiPanel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_KeyID
            // 
            this.btn_KeyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KeyID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KeyID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_KeyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_KeyID.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_KeyID.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_KeyID.ForePressColor = System.Drawing.Color.Red;
            this.btn_KeyID.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_KeyID.Location = new System.Drawing.Point(0, 0);
            this.btn_KeyID.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_KeyID.Name = "btn_KeyID";
            this.btn_KeyID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_KeyID.RectPressColor = System.Drawing.Color.Red;
            this.btn_KeyID.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_KeyID.Size = new System.Drawing.Size(100, 33);
            this.btn_KeyID.Style = Sunny.UI.UIStyle.Custom;
            this.btn_KeyID.TabIndex = 1;
            this.btn_KeyID.Text = "写入密钥";
            this.btn_KeyID.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KeyID.Click += new System.EventHandler(this.btn_KeyID_Click);
            // 
            // uiPanel7
            // 
            this.uiPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel7.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel7.Location = new System.Drawing.Point(10, 86);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Opacity = ((byte)(180));
            this.uiPanel7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel7.Radius = 10;
            this.uiPanel7.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel7.Size = new System.Drawing.Size(568, 10);
            this.uiPanel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel7.TabIndex = 15;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Controls.Add(this.uiPanel4);
            this.uiPanel3.Controls.Add(this.uiPanel5);
            this.uiPanel3.Controls.Add(this.uiPanel6);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel3.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel3.Location = new System.Drawing.Point(10, 53);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Opacity = ((byte)(180));
            this.uiPanel3.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel3.Size = new System.Drawing.Size(568, 33);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.TabIndex = 14;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Controls.Add(this.tb_HardwareID);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel4.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel4.Location = new System.Drawing.Point(110, 0);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Opacity = ((byte)(180));
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel4.Radius = 10;
            this.uiPanel4.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.Size = new System.Drawing.Size(458, 33);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.TabIndex = 13;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_HardwareID
            // 
            this.tb_HardwareID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_HardwareID.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_HardwareID.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_HardwareID.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_HardwareID.ButtonStyleInherited = false;
            this.tb_HardwareID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_HardwareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_HardwareID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HardwareID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_HardwareID.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_HardwareID.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_HardwareID.Location = new System.Drawing.Point(0, 3);
            this.tb_HardwareID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_HardwareID.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_HardwareID.Name = "tb_HardwareID";
            this.tb_HardwareID.Padding = new System.Windows.Forms.Padding(5);
            this.tb_HardwareID.ReadOnly = true;
            this.tb_HardwareID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_HardwareID.ScrollBarStyleInherited = false;
            this.tb_HardwareID.ShowText = false;
            this.tb_HardwareID.Size = new System.Drawing.Size(458, 27);
            this.tb_HardwareID.Style = Sunny.UI.UIStyle.Custom;
            this.tb_HardwareID.TabIndex = 3;
            this.tb_HardwareID.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_HardwareID.Watermark = "";
            // 
            // uiPanel5
            // 
            this.uiPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel5.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel5.Location = new System.Drawing.Point(100, 0);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Opacity = ((byte)(180));
            this.uiPanel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel5.Radius = 10;
            this.uiPanel5.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel5.Size = new System.Drawing.Size(10, 33);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 12;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            this.uiPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Controls.Add(this.btn_HardwareID);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel6.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel6.Location = new System.Drawing.Point(0, 0);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Opacity = ((byte)(180));
            this.uiPanel6.Radius = 10;
            this.uiPanel6.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel6.Size = new System.Drawing.Size(100, 33);
            this.uiPanel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel6.TabIndex = 10;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_HardwareID
            // 
            this.btn_HardwareID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HardwareID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_HardwareID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_HardwareID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_HardwareID.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_HardwareID.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_HardwareID.ForePressColor = System.Drawing.Color.Red;
            this.btn_HardwareID.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_HardwareID.Location = new System.Drawing.Point(0, 0);
            this.btn_HardwareID.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_HardwareID.Name = "btn_HardwareID";
            this.btn_HardwareID.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_HardwareID.RectPressColor = System.Drawing.Color.Red;
            this.btn_HardwareID.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_HardwareID.Size = new System.Drawing.Size(100, 33);
            this.btn_HardwareID.Style = Sunny.UI.UIStyle.Custom;
            this.btn_HardwareID.TabIndex = 1;
            this.btn_HardwareID.Text = "硬件ID";
            this.btn_HardwareID.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HardwareID.Click += new System.EventHandler(this.btn_HardwareID_Click);
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
            this.uiPanel2.Location = new System.Drawing.Point(10, 43);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Opacity = ((byte)(180));
            this.uiPanel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel2.Radius = 10;
            this.uiPanel2.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel2.Size = new System.Drawing.Size(568, 10);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.TabIndex = 13;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.uiPanel1);
            this.panel1.Controls.Add(this.uiPanel18);
            this.panel1.Controls.Add(this.uiPanel20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel1.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Opacity = ((byte)(180));
            this.panel1.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.panel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.panel1.Size = new System.Drawing.Size(568, 33);
            this.panel1.Style = Sunny.UI.UIStyle.Custom;
            this.panel1.TabIndex = 12;
            this.panel1.Text = null;
            this.panel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Controls.Add(this.tb_AliveStatus);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel1.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel1.Location = new System.Drawing.Point(110, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Opacity = ((byte)(180));
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(458, 33);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 13;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_AliveStatus
            // 
            this.tb_AliveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_AliveStatus.ButtonForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_AliveStatus.ButtonForePressColor = System.Drawing.Color.Red;
            this.tb_AliveStatus.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ButtonRectPressColor = System.Drawing.Color.Red;
            this.tb_AliveStatus.ButtonStyleInherited = false;
            this.tb_AliveStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_AliveStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AliveStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AliveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_AliveStatus.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_AliveStatus.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_AliveStatus.Location = new System.Drawing.Point(0, 3);
            this.tb_AliveStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_AliveStatus.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_AliveStatus.Name = "tb_AliveStatus";
            this.tb_AliveStatus.Padding = new System.Windows.Forms.Padding(5);
            this.tb_AliveStatus.ReadOnly = true;
            this.tb_AliveStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_AliveStatus.ScrollBarStyleInherited = false;
            this.tb_AliveStatus.ShowText = false;
            this.tb_AliveStatus.Size = new System.Drawing.Size(458, 27);
            this.tb_AliveStatus.Style = Sunny.UI.UIStyle.Custom;
            this.tb_AliveStatus.TabIndex = 4;
            this.tb_AliveStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb_AliveStatus.Watermark = "";
            // 
            // uiPanel18
            // 
            this.uiPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.uiPanel18.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPanel18.Location = new System.Drawing.Point(100, 0);
            this.uiPanel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel18.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel18.Name = "uiPanel18";
            this.uiPanel18.Opacity = ((byte)(180));
            this.uiPanel18.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uiPanel18.Radius = 10;
            this.uiPanel18.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel18.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel18.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel18.Size = new System.Drawing.Size(10, 33);
            this.uiPanel18.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel18.TabIndex = 12;
            this.uiPanel18.Text = null;
            this.uiPanel18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel20
            // 
            this.uiPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.Controls.Add(this.btn_AliveStatus);
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
            this.uiPanel20.RadiusSides = Sunny.UI.UICornerRadiusSides.All;
            this.uiPanel20.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiPanel20.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel20.Size = new System.Drawing.Size(100, 33);
            this.uiPanel20.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel20.TabIndex = 10;
            this.uiPanel20.Text = null;
            this.uiPanel20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AliveStatus
            // 
            this.btn_AliveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AliveStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AliveStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btn_AliveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_AliveStatus.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AliveStatus.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btn_AliveStatus.ForePressColor = System.Drawing.Color.Red;
            this.btn_AliveStatus.ForeSelectedColor = System.Drawing.Color.Red;
            this.btn_AliveStatus.Location = new System.Drawing.Point(0, 0);
            this.btn_AliveStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AliveStatus.Name = "btn_AliveStatus";
            this.btn_AliveStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AliveStatus.RectPressColor = System.Drawing.Color.Red;
            this.btn_AliveStatus.RectSelectedColor = System.Drawing.Color.Red;
            this.btn_AliveStatus.Size = new System.Drawing.Size(100, 33);
            this.btn_AliveStatus.Style = Sunny.UI.UIStyle.Custom;
            this.btn_AliveStatus.TabIndex = 1;
            this.btn_AliveStatus.Text = "激活状态";
            this.btn_AliveStatus.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AliveStatus.Click += new System.EventHandler(this.btn_AliveStatus_Click);
            // 
            // RadarAliveForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(608, 242);
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ControlBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.pan_Main);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MaximizeBox = false;
            this.Name = "RadarAliveForm";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ShowIcon = false;
            this.ShowRect = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "雷达激活";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.RadarAliveForm_Load);
            this.pan_Main.ResumeLayout(false);
            this.pan_Left.ResumeLayout(false);
            this.pan_Alive.ResumeLayout(false);
            this.uiPanel13.ResumeLayout(false);
            this.uiPanel14.ResumeLayout(false);
            this.uiPanel16.ResumeLayout(false);
            this.uiPanel8.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.uiPanel11.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel20.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel pan_Main;
        private FolderBrowserDialog folderBrowserDialog1;
        private Sunny.UI.UIPanel pan_Left;
        private Sunny.UI.UIPanel pan_Alive;
        private Sunny.UI.UIPanel panel1;
        private Sunny.UI.UIPanel uiPanel20;
        private Sunny.UI.UIPanel uiPanel18;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btn_AliveStatus;
        private Sunny.UI.UIPanel uiPanel13;
        private Sunny.UI.UIPanel uiPanel14;
        private Sunny.UI.UIPanel uiPanel15;
        private Sunny.UI.UIPanel uiPanel16;
        private Sunny.UI.UIButton btn_Result;
        private Sunny.UI.UIPanel uiPanel12;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIPanel uiPanel10;
        private Sunny.UI.UIPanel uiPanel11;
        private Sunny.UI.UIButton btn_KeyID;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIButton btn_HardwareID;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox tb_HardwareID;
        private Sunny.UI.UITextBox tb_Result;
        private Sunny.UI.UITextBox tb_KeyID;
        private Sunny.UI.UITextBox tb_AliveStatus;
    }
}
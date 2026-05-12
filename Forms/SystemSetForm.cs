using UCM_Tools.Config;
using UCM_Tools.MessageBoxEx;
using UCM_Tools.Radar;
using UCM_Tools.Tools;
using CommonLib;
using Kitware.VTK;
using LogProc;
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
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UCM_Tools.CAN_Conn.CAN_Function;
using static Sunny.UI.RandomColor;

namespace UCM_Tools.Forms
{
    public partial class SystemSetForm : UIForm
    {


        #region 初始化
        public SystemSetForm()
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            
        }
        
        private void SystemSetForm_Load(object sender, EventArgs e)
        {
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            LoadLanguage();
            InitControls();
        }

        #region 语言加载
        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("MainForm", "btn_SystemSet");
                lb_GraphTitle.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_GraphTitle");
                this.lb_XMin.Text = MultiLanguage.LanguageText("SystemSetForm", "XMin");
                this.lb_XMax.Text = MultiLanguage.LanguageText("SystemSetForm", "XMax");
                this.lb_XStep.Text = MultiLanguage.LanguageText("SystemSetForm", "XStep");
                this.lb_YMin.Text = MultiLanguage.LanguageText("SystemSetForm", "YMin");
                this.lb_YMax.Text = MultiLanguage.LanguageText("SystemSetForm", "YMax");
                this.lb_YStep.Text = MultiLanguage.LanguageText("SystemSetForm", "YStep");
                this.lb_ZMin.Text = MultiLanguage.LanguageText("SystemSetForm", "ZMin");
                this.lb_ZMax.Text = MultiLanguage.LanguageText("SystemSetForm", "ZMax");
                this.lb_PointSize.Text = MultiLanguage.LanguageText("SystemSetForm", "PointSize");
                this.lb_TrackSize.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackSize");
                lb_CumulativeFramesText.Text = MultiLanguage.LanguageText("SystemSetForm", "CumulativeFramesText");
                lb_CumulativeFramesType.Text = MultiLanguage.LanguageText("SystemSetForm", "CumulativeTypeText");
                cmb_CumulativeFramesType.Items.Clear();
                cmb_CumulativeFramesType.Items.AddRange(new object[] { MultiLanguage.LanguageText("SystemSetForm", "CumulativeKeep"), MultiLanguage.LanguageText("SystemSetForm", "CumulativeClear") });
                lb_ShowType.Text = MultiLanguage.LanguageText("SystemSetForm", "ShowType");
                cmb_ShowType.Items.Clear();
                cmb_ShowType.Items.AddRange(new object[] { MultiLanguage.LanguageText("SystemSetForm", "ShowType_PointAndTrack"), MultiLanguage.LanguageText("SystemSetForm", "ShowType_Point"), MultiLanguage.LanguageText("SystemSetForm", "ShowType_Track") });
                lb_TrackColor.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackColor");
                lb_TrackTextColor.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTextColor");
                lb_TrackTextSize.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTextSize");
                lb_ShowTrackTrajectory.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTrajectory");
                cmb_ShowTrackTrajectory.Items.Clear();
                cmb_ShowTrackTrajectory.Items.AddRange(new object[] { MultiLanguage.LanguageText("SystemSetForm", "Item_Show"), MultiLanguage.LanguageText("SystemSetForm", "Item_Hide") });
                lb_TrackTrajectoryLineWidth.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTrajectoryWidth");
                lb_TrackTrajectoryColor.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTrajectoryColor");
                lb_MaxTrajectoryNum.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackTrajectoryNum");
                lb_TrackTrajectoryOuttime.Text = MultiLanguage.LanguageText("SystemSetForm", "TrajectoryOuttime");
                lb_TrackColorMode.Text = MultiLanguage.LanguageText("SystemSetForm", "TrackColorMode");
                cmb_TrackColorMode.Items.Clear();
                cmb_TrackColorMode.Items.AddRange(new object[] { MultiLanguage.LanguageText("SystemSetForm", "Default"), MultiLanguage.LanguageText("SystemSetForm", "DivByID") });

                lb_TextParams.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_TextParams");
                cb_DisplayTrackText.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_DisplayTrackText");
                cb_ID.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_ID");
                cb_X.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_X");
                cb_Y.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_Y");
                cb_Z.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_Z");
                cb_Velocity.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_V");
                cb_AngleH.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_A");
                cb_Confidence.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_C");

                lb_ColorTitle.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_ColorTitle");
                rb_DefaultColor.Text = MultiLanguage.LanguageText("SystemSetForm", "rb_DefaultColor");
                rb_HeightColor.Text = MultiLanguage.LanguageText("SystemSetForm", "rb_HeightColor");
                color_Red.Text = MultiLanguage.LanguageText("SystemSetForm", "Red");
                color_Orange.Text = MultiLanguage.LanguageText("SystemSetForm", "Orange");
                color_Yellow.Text = MultiLanguage.LanguageText("SystemSetForm", "Yellow");
                color_Green.Text = MultiLanguage.LanguageText("SystemSetForm", "Green");
                color_Cyan.Text = MultiLanguage.LanguageText("SystemSetForm", "Cyan");
                color_Blue.Text = MultiLanguage.LanguageText("SystemSetForm", "Blue");
                color_Purple.Text = MultiLanguage.LanguageText("SystemSetForm", "Purple");

                lb_SaveDataParams.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_SaveDataParams");
                cb_TargetSave.Text = MultiLanguage.LanguageText("SystemSetForm", "cb_TargetSave");
                lb_FileSize.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_FileSize");
                lb_FileSizeUnit.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_FileSizeUnit");

                lb_DataReplayParams.Text = MultiLanguage.LanguageText("SystemSetForm", "lb_DataReplayParams");
                lb_ReplayDataFormat.Text = MultiLanguage.LanguageText("SystemSetForm", "DataFormat");
                lb_FrameCycle.Text = MultiLanguage.LanguageText("SystemSetForm", "FrameCycle");
                btn_Save.Text = MultiLanguage.LanguageText("CurrencyInfo", "Save");
            }
            catch (Exception ex) { Log.Error($"SystemSetForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }
        #endregion 语言加载

        #region 控件初始化
        private void InitControls()
        {
            try
            {
                tb_XMin.Text = SystemSetting.XMin + "";
                tb_XMax.Text = SystemSetting.XMax + "";
                tb_XStep.Text = SystemSetting.XStep + "";
                tb_YMin.Text = SystemSetting.YMin + "";
                tb_YMax.Text = SystemSetting.YMax + "";
                tb_YStep.Text = SystemSetting.YStep + "";
                tb_ZMin.Text = SystemSetting.ZMin + "";
                tb_ZMax.Text = SystemSetting.ZMax + "";
                tb_PointSize.Text = SystemSetting.PointSize + "";
                tb_TrackSize.Text = SystemSetting.TrackSize + "";
                tb_CumulativeFrames.Text = SystemSetting.CumulativeFrameNum + "";
                cmb_CumulativeFramesType.SelectedIndex = SystemSetting.CumulativeFrameType > 0 
                    && SystemSetting.CumulativeFrameType < cmb_CumulativeFramesType.Items.Count ? SystemSetting.CumulativeFrameType : 0;
                cmb_ShowType.SelectedIndex = SystemSetting.DisplayTargetType > 0 
                    && SystemSetting.DisplayTargetType < cmb_ShowType.Items.Count ? SystemSetting.DisplayTargetType : 0;
                cp_TrackColor.Value = SystemSetting.TrackColor;
                cp_TrackTextColor.Value = SystemSetting.TrackTextColor;
                tb_TrackTextSize.Text = SystemSetting.TrackTextSize+"";
                cmb_ShowTrackTrajectory.SelectedIndex = SystemSetting.DisplayTrackTrajectory ? 0 : 1;
                tb_TrackTrajectoryLineWidth.Text = SystemSetting.TrackTrajectoryLineWidth + "";
                cp_TrackTrajectoryColor.Value = SystemSetting.TrackTrajectoryColor;
                tb_MaxTrajectoryNum.Text = SystemSetting.TrackTrajectoryPointCount + "";
                tb_TrackTrajectoryOuttime.Text = SystemSetting.TrackTrajectoryTime + "";
                cmb_TrackColorMode.SelectedIndex = SystemSetting.TrackColorMode >= 0
                    && SystemSetting.TrackColorMode < cmb_TrackColorMode.Items.Count ? SystemSetting.TrackColorMode : -1;

                cb_DisplayTrackText.Checked = SystemSetting.DisplayTrackText;
                cb_ID.Checked = SystemSetting.Tar_ID;
                cb_X.Checked = SystemSetting.Tar_X;
                cb_Y.Checked = SystemSetting.Tar_Y;
                cb_Z.Checked = SystemSetting.Tar_Z;
                cb_Velocity.Checked = SystemSetting.Tar_V;
                cb_AngleH.Checked = SystemSetting.Tar_A;
                cb_Confidence.Checked = SystemSetting.Tar_C;
                cb_DisplayTrackText_CheckedChanged(null, null);

                rb_DefaultColor.Checked = SystemSetting.Default_Color;
                rb_HeightColor.Checked = !SystemSetting.Default_Color;
                tb_RedValue.Text = SystemSetting.RedValue + "";
                tb_OrangeValue.Text = SystemSetting.OrangeValue + "";
                tb_YellowValue.Text = SystemSetting.YellowValue + "";
                tb_GreenValue.Text = SystemSetting.GreenValue + "";
                tb_CyanValue.Text = SystemSetting.CyanValue + "";
                tb_BlueValue.Text = SystemSetting.BlueValue + "";
                rb_DefaultColor_CheckedChanged(null, null);

                cb_TargetSave.Checked = SystemSetting.TargetData;
                tb_FileSize.Text = SystemSetting.FileSize.ToString();
                tb_FilePath.Text = SystemSetting.FileRoute;
                tb_FileSize.TextChanged += new EventHandler(tb_FileSize_TextChanged);
                tb_FileSize.KeyDown += new KeyEventHandler(tb_FileSize_KeyDown);

                cmb_ReplayDataFormat.Items.Clear();
                cmb_ReplayDataFormat.Items.Add($"{MultiLanguage.LanguageText("SystemSetForm", "DataFormat")}0 (*******************  xyz_data **************************)");
                cmb_ReplayDataFormat.Items.Add($"{MultiLanguage.LanguageText("SystemSetForm", "DataFormat")}1 (frame_id,range,azimuth,elevation,velocity,snr,v_ego_x,v_ego_y,v_ego_z)");
                cmb_ReplayDataFormat.Items.Add($"{MultiLanguage.LanguageText("SystemSetForm", "DataFormat")}2 (*******************  point_track_data **************************)");
                cmb_ReplayDataFormat.SelectedIndex = SystemSetting.DataReplayFormatType >= cmb_ReplayDataFormat.Items.Count && SystemSetting.DataReplayFormatType < 0 ? 0 : SystemSetting.DataReplayFormatType;
                tb_FrameCycle.Text = SystemSetting.DataReplayFrameCycle.ToString();

            }
            catch (Exception ex) { Log.Error($"SystemSetForm InitControls() Ex\r\n{ex.ToString()}"); }
        }
        #endregion 控件初始化

        #region 文本显示
        private void cb_ID_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_ID = cb_ID.Checked;
        }

        private void cb_X_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_X = cb_X.Checked;
        }

        private void cb_Y_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_Y = cb_Y.Checked;
        }

        private void cb_Z_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_Z = cb_Z.Checked;
        }

        private void cb_Velocity_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_V = cb_Velocity.Checked;
        }

        private void cb_AngleH_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_A = cb_AngleH.Checked;
        }
        private void cb_Confidence_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.Tar_C = cb_Confidence.Checked;
        }

        private void cb_DisplayTrackText_CheckedChanged(object sender, EventArgs e)
        {
            pan_TarTextEnable.Enabled = cb_DisplayTrackText.Checked;
            SystemSetting.DisplayTrackText = cb_DisplayTrackText.Checked;
        }
        #endregion 文本显示

        #region 颜色
        private void rb_DefaultColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_DefaultColor.Checked)
            {
                rb_HeightColor.Checked = false;
                pan_HeightColor.Enabled = false;
            }
            else
            {
                rb_HeightColor.Checked = true;
                pan_HeightColor.Enabled = true;
            }
            
        }

        private void rb_HeightColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_HeightColor.Checked)
            {
                rb_DefaultColor.Checked = false;
                pan_HeightColor.Enabled = true;
            }
            else
            {
                rb_DefaultColor.Checked = true;
                pan_HeightColor.Enabled = false;
            }

        }
        #endregion 颜色

        #region 文件存储
        private string _lastValidText = "1";   // 上一次合法文本
        private int _lastValidValue = 1;      // 上一次合法值
        private bool _isRollingBack = false;    // 防止递归触发
        private readonly Regex _regex = new Regex(@"^[1-9]\d*$");

        private void tb_FileSize_TextChanged(object sender, EventArgs e)
        {
            if (_isRollingBack) return;   // 正在回滚，避免递归

            string txt = tb_FileSize.Text.Trim();

            // 空串暂时允许，回滚到旧值
            if (!string.IsNullOrEmpty(txt) && _regex.IsMatch(txt) && int.TryParse(txt, out int val) && val >= 1)
            {
                // 合法：更新记忆
                _lastValidText = txt;
                _lastValidValue = val;
            }
            else
                RollBack();
            SystemSetting.FileSize = _lastValidValue;
        }

        private void tb_FileSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down) return;

            var tb = (TextBox)sender;
            if (!int.TryParse(tb.Text, out int val)) return;   // 不是int就忽略

            val += (e.KeyCode == Keys.Up ? 1 : -1) * SystemSetting.FileSize;
            if (val < 1)
            {
                e.Handled = true;
                return;
            }
            tb.Text = val.ToString();
            tb.SelectAll();            // 可选：按完直接全选
            SystemSetting.FileSize = val;
        }

        private void RollBack()
        {
            _isRollingBack = true;
            tb_FileSize.Text = _lastValidText;
            tb_FileSize.SelectionStart = tb_FileSize.Text.Length;   // 光标放到末尾
            _isRollingBack = false;
        }
        private void tb_FilePath_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog ofd = new FolderBrowserDialog();
                ofd.Description = MultiLanguage.LanguageText("ErrorInfo", "SelectFilePath");
                if (ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    tb_FilePath.Text = ofd.SelectedPath;
                    SystemSetting.FileRoute = ofd.SelectedPath;
                }
            }
            catch (Exception) { }
        }

        private void cb_TargetSave_CheckedChanged(object sender, EventArgs e)
        {
            SystemSetting.TargetData = cb_TargetSave.Checked;
        }
        #endregion 文件存储

        #endregion 初始化

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_XMin.Text) || string.IsNullOrEmpty(tb_XMax.Text) || string.IsNullOrEmpty(tb_XStep.Text) ||
                    string.IsNullOrEmpty(tb_YMin.Text) || string.IsNullOrEmpty(tb_YMax.Text) || string.IsNullOrEmpty(tb_YStep.Text) ||
                    string.IsNullOrEmpty(tb_ZMin.Text) || string.IsNullOrEmpty(tb_ZMax.Text) || string.IsNullOrEmpty(tb_PointSize.Text))
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "DataEmpty"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int xStep = 0,yStep = 0;
                bool b_xStep = int.TryParse(tb_XStep.Text, out xStep);
                bool b_yStep = int.TryParse(tb_YStep.Text, out yStep);
                if(!b_xStep || !b_yStep || xStep<3 || yStep < 3)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "StepError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int pointSize = int.Parse(tb_PointSize.Text);
                if (pointSize <= 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "PointSizeError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                double trackSize = 0;
                bool b_TrackSize = double.TryParse(tb_TrackSize.Text,out trackSize);
                if (trackSize <= 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "TrackSizeError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int cumulativeFrames = int.Parse(tb_CumulativeFrames.Text);
                if (cumulativeFrames <= 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "AccFrameError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int cumulativeType = cmb_CumulativeFramesType.SelectedIndex;
                if (cumulativeType < 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "AccFrameTypeError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int showType = cmb_ShowType.SelectedIndex;
                if (showType < 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "ShowTypeError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int replayDataFormat = cmb_ReplayDataFormat.SelectedIndex;
                if(replayDataFormat < 0)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "DataFormatError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                int frameCycle = 0;
                bool b_frameCycle = int.TryParse(tb_FrameCycle.Text, out frameCycle);
                if(!b_frameCycle || frameCycle < 20)
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "FrameCycleError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                ///只能是0(显示)和1(隐藏)
                int showTrackTrajectory = cmb_ShowTrackTrajectory.SelectedIndex;
                if (showTrackTrajectory < 0 || showTrackTrajectory > 1) 
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "ShowTrackTrajectoryError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return;
                }
                float lineWidth = 0;
                bool b_lineWidth = float.TryParse(tb_TrackTrajectoryLineWidth.Text, out lineWidth);
                if (!b_lineWidth || lineWidth <= 0)
                {
                    return;
                }
                int maxCount = -1;
                bool b_maxCount = int.TryParse(tb_MaxTrajectoryNum.Text, out maxCount);
                if (!b_maxCount || maxCount < 0)
                {
                    return;
                }
                int trackTextSize = 0;
                bool b_trackTextSize = int.TryParse(tb_TrackTextSize.Text, out trackTextSize);
                if (!b_trackTextSize || trackTextSize <= 0)
                {
                    return;
                }
                int trackOuttime = 0;
                bool b_trackOuttime = int.TryParse(tb_TrackTrajectoryOuttime.Text, out trackOuttime);
                if (!b_trackOuttime || trackOuttime <= 0)
                {
                    return;
                }
                int trackColorMode = cmb_TrackColorMode.SelectedIndex;
                if (trackColorMode < 0)
                {
                    return;
                }
                if (!rb_DefaultColor.Checked)
                {
                    if (PubClass.ReNum(pan_HeightColor) > 0)
                    {
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "HeightColorEmpty"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return;
                    }
                    int red = 0, orange = 0, yellow = 0, green = 0, cyan = 0, blue = 0;
                    bool b_Red = int.TryParse(tb_RedValue.Text, out red);
                    bool b_Orange = int.TryParse(tb_OrangeValue.Text, out orange);
                    bool b_Yellow = int.TryParse(tb_YellowValue.Text, out yellow);
                    bool b_Green = int.TryParse(tb_GreenValue.Text, out green);
                    bool b_Cyan = int.TryParse(tb_CyanValue.Text, out cyan);
                    bool b_Blue = int.TryParse(tb_BlueValue.Text, out blue);
                    if (!b_Red || !b_Orange || !b_Yellow || !b_Green || !b_Cyan || !b_Blue || 
                        !(red > orange && orange > yellow && yellow > green && green > cyan && cyan > blue))
                    {
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "HeightColorError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return;
                        
                    }
                    SystemSetting.RedValue = red;
                    SystemSetting.OrangeValue = orange;
                    SystemSetting.YellowValue = yellow;
                    SystemSetting.GreenValue = green;
                    SystemSetting.CyanValue = cyan;
                    SystemSetting.BlueValue = blue;
                }
                SystemSetting.Default_Color = rb_DefaultColor.Checked;
                SystemSetting.XMin = int.Parse(tb_XMin.Text);
                SystemSetting.XMax = int.Parse(tb_XMax.Text);
                SystemSetting.XStep = int.Parse(tb_XStep.Text);
                SystemSetting.YMin = int.Parse(tb_YMin.Text);
                SystemSetting.YMax = int.Parse(tb_YMax.Text);
                SystemSetting.YStep = int.Parse(tb_YStep.Text);
                SystemSetting.ZMin = int.Parse(tb_ZMin.Text);
                SystemSetting.ZMax = int.Parse(tb_ZMax.Text);
                SystemSetting.PointSize = pointSize;
                SystemSetting.TrackSize = trackSize;
                SystemSetting.CumulativeFrameNum = cumulativeFrames;
                SystemSetting.CumulativeFrameType = cumulativeType;
                SystemSetting.DisplayTargetType = showType;
                SystemSetting.DataReplayFormatType = replayDataFormat;
                SystemSetting.DataReplayFrameCycle = frameCycle;
                SystemSetting.TrackColor = cp_TrackColor.Value;
                SystemSetting.TrackTextColor = cp_TrackTextColor.Value;
                SystemSetting.TrackColorMode = trackColorMode;
                SystemSetting.TrackTextSize =trackTextSize;
                SystemSetting.DisplayTrackTrajectory = showTrackTrajectory == 0;
                SystemSetting.TrackTrajectoryLineWidth = lineWidth;
                SystemSetting.TrackTrajectoryColor = cp_TrackTrajectoryColor.Value;
                SystemSetting.TrackTrajectoryTime = trackOuttime;
                SystemSetting.TrackTrajectoryPointCount = maxCount;
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "SaveSuccess"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
            }
            catch 
            {
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "SaveDataEx"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
            }
        }

        
    }

}

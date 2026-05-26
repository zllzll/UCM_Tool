using CommonLib;
using LogProc;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.Models;
using UCM_Tools.Tools;

namespace UCM_Tools.Forms
{
    public partial class FCInfoForm : UIForm
    {
        /// <summary>
        /// object图表
        /// </summary>
        NplotCls myplot_Object = new NplotCls();
        public FCInfoForm()
        {
            InitializeComponent();
            // 设置窗体双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // 设置面板双缓冲
            SetDoubleBuffered(pan_Main);
        }
        // 辅助方法：通过反射设置控件的DoubleBuffered属性
        private void SetDoubleBuffered(Control ctrl)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
                ?.SetValue(ctrl, true);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // 启用复合双缓冲，所有子控件会一起缓冲绘制
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
        private void FCInfoForm_Load(object sender, EventArgs e)
        {
            //初始化主题
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);

            LoadLanguage();
            ClearControlValue();
            MainForm.fcInfoDataReceived += new MainForm.FcInfoDataDelegate(ReceiveData);
            MainForm.connInfoDataReceived += new MainForm.ConnInfoDataDelegate(ReceiveConnData);
        }



        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("FCInfoForm", "FCInfoTitle");
                lb_InfoArea.Text = MultiLanguage.LanguageText("FCInfoForm", "FCInfo");
                lb_GPSLocValidText.Text = MultiLanguage.LanguageText("FCInfoForm", "GPSLocValid");
                lb_UavAttitudeValidText.Text = MultiLanguage.LanguageText("FCInfoForm", "UAVAttitude");
                lb_GpsLongText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Longitude");
                lb_GpsLatText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Latitude");
                lb_GpsHeightText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Altitude");
                lb_AGLText.Text = MultiLanguage.LanguageText("FCInfoForm", "AGL");
                lb_VNText.Text = MultiLanguage.LanguageText("FCInfoForm", "VN");
                lb_VEText.Text = MultiLanguage.LanguageText("FCInfoForm", "VE");
                lb_VDText.Text = MultiLanguage.LanguageText("FCInfoForm", "VD");
                lb_RollText.Text = MultiLanguage.LanguageText("FCInfoForm", "RollAngle");
                lb_PitchText.Text = MultiLanguage.LanguageText("FCInfoForm", "PitchAngle");
                lb_YawText.Text = MultiLanguage.LanguageText("FCInfoForm", "YawAngle");
                lb_RollSpeedText.Text = MultiLanguage.LanguageText("FCInfoForm", "RollSpeed");
                lb_PitchSpeedText.Text = MultiLanguage.LanguageText("FCInfoForm", "PitchSpeed");
                lb_YawSpeedText.Text = MultiLanguage.LanguageText("FCInfoForm", "YawSpeed");
                
            }
            catch (Exception ex) { Log.Error($"MainForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }

        private void ReceiveData(FCData data)
        {
            try
            {
                this.BeginInvoke((EventHandler)delegate
                {
                    lb_GPSLocValid.Text = data != null && data.GpsLocValid ? "Yes" : "No";
                    lb_UavAttitudeValid.Text = data != null && data.UavAttitudeValid ? "Yes" : "No";
                    lb_GpsLong.Text = data == null || !data.GpsLocValid ? "Invalid" : data.GpsLong.ToString("F7");
                    lb_GpsLat.Text = data == null || !data.GpsLocValid ? "Invalid" : data.GpsLat.ToString("F7");
                    lb_GpsHeight.Text = data == null || !data.GpsLocValid ? "Invalid" : data.GpsHeight.ToString("F7");
                    lb_AGL.Text = data == null || !data.GpsLocValid ? "Invalid" : data.AGL.ToString("F7");
                    lb_VN.Text = data == null || !data.GpsLocValid ? "Invalid" : data.VN.ToString("F7");
                    lb_VE.Text = data == null || !data.GpsLocValid ? "Invalid" : data.VE.ToString("F7");
                    lb_VD.Text = data == null || !data.GpsLocValid ? "Invalid" : data.VD.ToString("F7");
                    lb_Roll.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.RollAngle.ToString("F7");
                    lb_Pitch.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.PitchAngle.ToString("F7");
                    lb_Yaw.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.YawAngle.ToString("F7");
                    lb_RollSpeed.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.RollSpeed.ToString("F7");
                    lb_PitchSpeed.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.PitchSpeed.ToString("F7");
                    lb_YawSpeed.Text = data == null || !data.UavAttitudeValid ? "Invalid" : data.YawSpeed.ToString("F7");
                });
            }
            catch (Exception ex)
            {
                Log.Error($"SetValueToGraph Ex\r\n{ex.ToString()}");
            }
        }

        private void ReceiveConnData(ConnState dataConn)
        {
            if(dataConn!= ConnState.Connected)
            {
                this.BeginInvoke((EventHandler)delegate
                {
                    ClearControlValue();
                });
            }
        }

        private void ClearControlValue()
        {
            lb_GPSLocValid.Text = "No";
            lb_UavAttitudeValid.Text = "No";
            lb_GpsLong.Text = "---";
            lb_GpsLat.Text = "---";
            lb_GpsHeight.Text = "---";
            lb_AGL.Text = "---";
            lb_VN.Text = "---";
            lb_VE.Text = "---";
            lb_VD.Text = "---";
            lb_Roll.Text = "---";
            lb_Pitch.Text = "---";
            lb_Yaw.Text = "---";
            lb_RollSpeed.Text = "---";
            lb_PitchSpeed.Text = "---";
            lb_YawSpeed.Text = "---";
        }

        private void FCInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDispose();
        }

        public void FormDispose()
        {
            MainForm.fcInfoDataReceived -= ReceiveData;
            MainForm.connInfoDataReceived -= ReceiveConnData;
        }
    }
}

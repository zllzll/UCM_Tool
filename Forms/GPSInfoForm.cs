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
    public partial class GPSInfoForm : UIForm
    {
        /// <summary>
        /// object图表
        /// </summary>
        NplotCls myplot_Object = new NplotCls();
        public GPSInfoForm()
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
        private void GPSInfoForm_Load(object sender, EventArgs e)
        {
            //初始化主题
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);

            LoadLanguage();
            ClearControlValue();
            MainForm.gpsInfoDataReceived += new MainForm.GpsInfoDataDelegate(ReceiveData);
            MainForm.connInfoDataReceived += new MainForm.ConnInfoDataDelegate(ReceiveConnData);
        }

        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("GPSInfoForm", "GPSInfoTitle");
                lb_InfoArea.Text = MultiLanguage.LanguageText("GPSInfoForm", "GPSInfo");
                lb_AccX1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"X1";
                lb_AccY1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"Y1";
                lb_AccZ1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"Z1";
                lb_AvX1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"X1";
                lb_AvY1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"Y1";
                lb_AvZ1Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"Z1";
                lb_AccX2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"X2";
                lb_AccY2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"Y2";
                lb_AccZ2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Acc")+"Z2";
                lb_AvX2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"X2";
                lb_AvY2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"Y2";
                lb_AvZ2Text.Text = MultiLanguage.LanguageText("GPSInfoForm", "Av")+"Z2";
                lb_GpsLongText.Text = "GPS"+MultiLanguage.LanguageText("GPSInfoForm", "Longitude");
                lb_GpsLatText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Latitude");
                lb_GpsHeightText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Altitude");
                lb_GpsSpeedText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Velocity");
                lb_GpsDeclinationText.Text = "GPS" + MultiLanguage.LanguageText("GPSInfoForm", "Declination");
            }
            catch (Exception ex) { Log.Error($"MainForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }

        private void ReceiveData(IMUAndGPSData data)
        {
            try
            {
                this.BeginInvoke((EventHandler)delegate
                {
                    lb_AccX1.Text = data == null || data.AccX1 == -32768 ? "Invalid" : data.AccX1.ToString("F7");
                    lb_AccY1.Text = data == null || data.AccY1 == -32768 ? "Invalid" : data.AccY1.ToString("F7");
                    lb_AccZ1.Text = data == null || data.AccZ1 == -32768 ? "Invalid" : data.AccZ1.ToString("F7");
                    lb_AvX1.Text = data == null || data.AVX1 == -32768 ? "Invalid" : data.AVX1.ToString("F7");
                    lb_AvY1.Text = data == null || data.AVY1 == -32768 ? "Invalid" : data.AVY1.ToString("F7");
                    lb_AvZ1.Text = data == null || data.AVZ1 == -32768 ? "Invalid" : data.AVZ1.ToString("F7");
                    lb_AccX2.Text = data == null || data.AccX2 == -32768 ? "Invalid" : data.AccX2.ToString("F7");
                    lb_AccY2.Text = data == null || data.AccY2 == -32768 ? "Invalid" : data.AccY2.ToString("F7");
                    lb_AccZ2.Text = data == null || data.AccZ2 == -32768 ? "Invalid" : data.AccZ2.ToString("F7");
                    lb_AvX2.Text = data == null || data.AVX2 == -32768 ? "Invalid" : data.AVX2.ToString("F7");
                    lb_AvY2.Text = data == null || data.AVY2 == -32768 ? "Invalid" : data.AVY2.ToString("F7");
                    lb_AvZ2.Text = data == null || data.AVZ2 == -32768 ? "Invalid" : data.AVZ2.ToString("F7");
                    lb_GpsLong.Text = data == null || data.GpsLong == -2147483648 ? "Invalid" : data.GpsLong.ToString("F7");
                    lb_GpsLat.Text = data == null || data.GpsLat == -2147483648 ? "Invalid" : data.GpsLat.ToString("F7");
                    lb_GpsHeight.Text = data == null || data.GpsHeight == -2147483648 ? "Invalid" : data.GpsHeight.ToString("F7");
                    lb_GpsSpeed.Text = data == null || data.GpsSpeed == -32768 ? "Invalid" : data.GpsSpeed.ToString("F7");
                    lb_GpsDeclination.Text = data == null || data.GpsDeclination == -32768 ? "Invalid" : data.GpsDeclination.ToString("F7");
                });
            }
            catch (Exception ex)
            {
                Log.Error($"SetValueToGraph Ex\r\n{ex.ToString()}");
            }
        }
        private void ReceiveConnData(ConnState dataConn)
        {
            if (dataConn != ConnState.Connected)
            {
                this.BeginInvoke((EventHandler)delegate
                {
                    ClearControlValue();
                });
            }
        }
        private void ClearControlValue()
        {
            lb_AccX1.Text = "---";
            lb_AccY1.Text = "---";
            lb_AccZ1.Text = "---";
            lb_AvX1.Text = "---";
            lb_AvY1.Text = "---";
            lb_AvZ1.Text = "---";
            lb_AccX2.Text = "---";
            lb_AccY2.Text = "---";
            lb_AccZ2.Text = "---";
            lb_AvX2.Text = "---";
            lb_AvY2.Text = "---";
            lb_AvZ2.Text = "---";
            lb_GpsLong.Text = "---";
            lb_GpsLat.Text = "---";
            lb_GpsHeight.Text = "---";
            lb_GpsSpeed.Text = "---";
            lb_GpsDeclination.Text = "---";
        }

        private void GPSInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDispose();
        }

        public void FormDispose()
        {
            MainForm.gpsInfoDataReceived -= ReceiveData;
            MainForm.connInfoDataReceived -= ReceiveConnData;
        }
    }
}

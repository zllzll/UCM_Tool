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
    public partial class RadarAliveForm : UIForm
    {
        RadarClass _radar = null;
        List<byte> hardwareIdList = new List<byte>();
        bool? isSuccess = null;
        #region 初始化
        public RadarAliveForm(RadarClass radar)
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            _radar = radar;
            hardwareIdList.Clear();
            _radar.hardwareIdEvent += _radar_hardwareIdEvent;
            _radar.aliveStatusEvent += _radar_aliveStatusEvent;
            _radar.keyIdRespEvent += _radar_keyIdRespEvent;
        }

        private void RadarAliveForm_Load(object sender, EventArgs e)
        {
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            LoadLanguage();
        }

        #region 语言加载
        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarAlive");
                btn_AliveStatus.Text = MultiLanguage.LanguageText("RadarAliveForm", "AliveStatus");
                btn_HardwareID.Text = MultiLanguage.LanguageText("RadarAliveForm", "GetHardwareID");
                btn_KeyID.Text = MultiLanguage.LanguageText("RadarAliveForm", "WriteKey");
                btn_Result.Text = MultiLanguage.LanguageText("RadarAliveForm", "AliveResult");
            }
            catch (Exception ex) { Log.Error($"RadarAliveForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }
        #endregion 语言加载

        private void RadarAliveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _radar.hardwareIdEvent -= _radar_hardwareIdEvent;
            _radar.aliveStatusEvent -= _radar_aliveStatusEvent;
            _radar.keyIdRespEvent -= _radar_keyIdRespEvent;
        }
        #endregion 初始化

        private void _radar_keyIdRespEvent(bool success)
        {
            isSuccess = success;
        }

        private void _radar_aliveStatusEvent(bool alive)
        {
            isSuccess = alive;
        }

        private void _radar_hardwareIdEvent(byte[] hardwareId)
        {
            hardwareIdList.AddRange(hardwareId);
        }

        private void EnableControls(bool b)
        {
            btn_AliveStatus.Enabled = b;
            btn_HardwareID.Enabled = b;
            btn_KeyID.Enabled = b;
            tb_KeyID.Enabled = b;
        }

        private void btn_AliveStatus_Click(object sender, EventArgs e)
        {
            if (_radar == null || !_radar._bOpen)
            {
                tb_Result.Text = MultiLanguage.LanguageText("ErrorInfo", "NotConnect");
                return;
            }
            tb_AliveStatus.Text = "";
            tb_Result.Text = "";
            isSuccess = null;
            EnableControls(false);
            Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();
                try
                {
                    _radar.SendCmd(RadarCommand.ReadAliveStatus);
                    sw.Start();
                    while (sw.ElapsedMilliseconds < 5000)
                    {
                        if (isSuccess != null)
                            break;
                        Thread.Sleep(10);
                    }
                }
                catch
                {

                }
                finally
                {
                    sw.Stop();
                    this.Invoke((EventHandler)delegate
                    {
                        if (isSuccess != null)
                            tb_AliveStatus.Text = isSuccess == true ? MultiLanguage.LanguageText("ErrorInfo", "Alived") : MultiLanguage.LanguageText("ErrorInfo", "Unalive");
                        else
                            tb_Result.Text = MultiLanguage.LanguageText("ErrorInfo", "NotGetAliveStatus");
                        EnableControls(true);
                    });
                }
            });

        }

        private void btn_HardwareID_Click(object sender, EventArgs e)
        {
            hardwareIdList.Clear();
            if (_radar == null || !_radar._bOpen)
            {
                tb_Result.Text = MultiLanguage.LanguageText("ErrorInfo", "NotConnect");
                return;
            }
            tb_HardwareID.Text = "";
            tb_Result.Text = "";
            isSuccess = null;
            EnableControls(false);
            Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();
                try
                {
                    _radar.SendCmd(RadarCommand.ReadHardwareId, null, false);
                    sw.Start();
                    while (sw.ElapsedMilliseconds < 5000)
                    {
                        if (hardwareIdList.Count == 16)
                            break;
                        Thread.Sleep(10);
                    }
                }
                catch
                {

                }
                finally
                {
                    sw.Stop();
                    this.Invoke((EventHandler)delegate
                    {
                        tb_HardwareID.Text = hardwareIdList.Count == 16 ? BitConverter.ToString(hardwareIdList.ToArray()) : "";
                        EnableControls(true);
                    });
                }
                hardwareIdList.Clear();
            });
        }

        private void btn_KeyID_Click(object sender, EventArgs e)
        {
            if (_radar == null || !_radar._bOpen)
            {
                tb_Result.Text = MultiLanguage.LanguageText("ErrorInfo", "NotConnect");
                return;
            }
            string[] str_key = tb_KeyID.Text.Split('-');
            if (str_key == null || str_key.Length != 16)
            {
                tb_Result.Text = MultiLanguage.LanguageText("ErrorInfo", "AliveKeyError");
                return;
            }
            List<byte> byte_key = new List<byte>();

            //字符串转字节
            for (int i = 0; i < str_key.Length; i++)
                byte_key.Add((byte)Convert.ToInt16(str_key[i].Trim(), 16));
            tb_Result.Text = "";
            isSuccess = null;
            EnableControls(false);
            Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();
                try
                {
                    //分两帧发送密钥
                    List<byte> byte_Send1 = byte_key.Take(8).ToList();
                    List<byte> byte_Send2 = byte_key.Skip(8).Take(8).ToList();

                    _radar.SendCmd(RadarCommand.WriteKeyId, byte_Send1.ToArray(), false);
                    Thread.Sleep(5);
                    _radar.SendCmd(RadarCommand.WriteKeyId, byte_Send2.ToArray(), false);
                    sw.Start();
                    while (sw.ElapsedMilliseconds < 5000)
                    {
                        if (isSuccess != null)
                            break;
                        Thread.Sleep(10);
                    }
                }
                catch
                {

                }
                finally
                {
                    sw.Stop();
                    this.Invoke((EventHandler)delegate
                    {
                        tb_Result.Text = isSuccess == true ? MultiLanguage.LanguageText("ErrorInfo", "AliveSuccessed") : MultiLanguage.LanguageText("ErrorInfo", "AliveFailed");
                        EnableControls(true);
                    });
                }
            });
        }



    }

}

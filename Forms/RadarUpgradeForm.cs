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
using ZLGCAN;
using static UCM_Tools.CAN_Conn.CAN_Function;
using static Sunny.UI.RandomColor;

namespace UCM_Tools.Forms
{
    public partial class RadarUpgradeForm : UIForm
    {
        private System.Timers.Timer str_UpTimer = new System.Timers.Timer(1000);

        int second = 0;
        RadarClass _radar = null;
        bool _isRecv = false;
        List<can_frame> _recvList = new List<can_frame>();
        #region 初始化
        public RadarUpgradeForm(RadarClass radar)
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            _radar = radar;
            _radar.versionEvent += _radar_versionEvent;
            _radar.frameEvent += _radar_frameEvent;
        }
        ///// <summary>
        ///// 左上到右下渐变
        ///// </summary>
        ///// <param name="e"></param>
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);

        //    using (LinearGradientBrush brush = new LinearGradientBrush(
        //        this.ClientRectangle,
        //        Color.FromArgb(26, 10, 10),  // #1a0a0a
        //        Color.FromArgb(10, 10, 10),  // #0a0a0a
        //        LinearGradientMode.ForwardDiagonal))
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}
        bool isClosing = false;
        private void RadarUpgradeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                isClosing = true;
                str_UpTimer.Enabled = false;
                _radar.versionEvent -= _radar_versionEvent;
                _radar.frameEvent -= _radar_frameEvent;
                _isRecv = false;
                thread?.Abort();
            }
            catch { }
        }



        private void RadarUpgradeForm_Load(object sender, EventArgs e)
        {
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            LoadLanguage();
            UpTime();

        }
        #endregion 初始化
        private void _radar_frameEvent(uint frameId, byte[] frameData)
        {
            //Console.WriteLine($"{frameId.ToString("X4")}-{BitConverter.ToString(frameData)}");
            if (_isRecv)
            {
                lock (_recvList)
                    _recvList.Add(new can_frame() { can_id = frameId, data = frameData });
            }
        }

        private void _radar_versionEvent(string version)
        {
            string ver = version;
            this.Invoke((EventHandler)delegate { tb_Version.Text = $"v{ver}"; });
        }
        

        private void LoadLanguage()
        {
            this.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarUpgrade");
            btn_File.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_File");
            btn_Version.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_Version");
            btn_Upgrade.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_Upgrade");
        }
        #region 串口升级计时

        /// <summary>
        /// 串口识别
        /// </summary>
        private void UpTime()
        {
            //到达时间的时候执行事件；
            str_UpTimer.Elapsed += new System.Timers.ElapsedEventHandler(upTime);
            //设置是执行一次（false）还是一直执行(true)；
            str_UpTimer.AutoReset = true;
        }

        /// <summary>
        /// COM识别方法
        /// </summary>
        private void upTime(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    second++;
                    lb_UpgradeTime.Text = addZero((second / 60).ToString(), 2) + " : " + addZero((second % 60).ToString(), 2);
                }));
            }
            catch (Exception) { }
        }
        private string addZero(string str, int length)
        {
            if (str.Length < length)
            {
                int div = length - str.Length;
                for (int i = 0; i < div; i++)
                {
                    str = "0" + str;
                }
            }

            return str;
        }

        #endregion 串口升级计时

        private void btn_File_Click(object sender, EventArgs e)
        {
            tb_Upgrade.Text = "";
            open_File.Filter = "Bin File|*.Bin;*.bin|Hex File|*.Hex;*.hex";
            if (open_File.ShowDialog().Equals(DialogResult.OK))
            {
                tb_File.Text = System.IO.Path.GetFullPath(open_File.FileName);
                //读文件
                byte[] file_Data = PubClass.ReadFileData(tb_File.Text);
                if (file_Data == null || file_Data.Length <= 16)
                {
                    tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "FileError");
                    return;
                }
            }
        }
        private void EnableControls(bool b)
        {
            btn_File.Enabled = b;
            btn_Version.Enabled = b;
            btn_Upgrade.Enabled = b;
        }
        private void btn_Version_Click(object sender, EventArgs e)
        {
            tb_Upgrade.Text = "";
            tb_Version.Text = "";
            lb_UpgradeTime.Text = "00:00";
            if (_radar == null || !_radar._bOpen)
            {
                tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "NotConnect");
                return;
            }
            _radar.SendCmd(RadarCommand.ReadSoftwareVersion);
        }
        Thread thread = null;
        private void btn_Upgrade_Click(object sender, EventArgs e)
        {
            lb_UpgradeTime.Text = "00:00";
            tb_Upgrade.Text = "";
            tb_Version.Text = "V0.0.0";
            if (_radar == null || !_radar._bOpen)
            {
                tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "NotConnect");
                return;
            }
            byte[] file_Data = PubClass.ReadFileData(tb_File.Text);
            if (file_Data == null || file_Data.Length <= 16)
            {
                tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "FileError");
                return;
            }
            thread = new Thread(Upgrade);
            thread.IsBackground = true;
            thread.Start(file_Data);
        }

        private void Upgrade(object data)
        {
            byte[] fileBytes = data as byte[];
            Stopwatch sw = new Stopwatch();
            try
            {
                str_UpTimer.Start();
                this.Invoke((EventHandler)delegate { EnableControls(false); tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "EnterUpgrade"); pb_Upgrade.Maximum = fileBytes.Length / 800 + 5; pb_Upgrade.Value = 1; });
                _radar.SendCmd(RadarCommand.EnterUpgrade);
                Thread.Sleep(150);
                #region Erase File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "EarsingFile"); });
                List<can_frame> cans = null;
                _isRecv = true;
                _recvList.Clear();
                _radar.SendCmd(RadarCommand.EarseFile, addRadarId: false);
                sw.Restart();
                bool? isOk = null;
                while (sw.ElapsedMilliseconds < 15000)
                {
                    lock (_recvList)
                    {
                        cans = _recvList.ToList();
                        _recvList.Clear();
                    }
                    foreach (can_frame frame in cans)
                    {
                        if (frame.can_id == 0x102)
                        {
                            isOk = frame.data[0] == 0x0F;
                            break;
                        }
                    }
                    if (isOk != null)
                        break;
                    Thread.Sleep(10);
                }
                sw.Stop();
                if (isOk != true)
                {
                    this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "EarseFileFailed"); });
                    return;
                }
                #endregion Erase File

                #region Send File
                int i = 0;
                int frameNum = 0;
                List<byte> list = new List<byte>();
                byte[] str_EffData = new byte[8];
                byte[] str_FrameData = new byte[8];
                while (i < fileBytes.Length)
                {
                    for (int num = 0; num < 8; num++)
                    {
                        if (fileBytes.Length - 1 - i >= 0)
                        {
                            str_EffData[num] = fileBytes[i];
                        }
                        else//若最后一次发送数据不足八位 补0xFF
                        {
                            str_EffData[num] = 0xFF;
                        }
                        i++;
                    }
                    _radar.SendCmd(RadarCommand.SendFile, str_EffData, false);
                    if(SystemSetting.SendWaitTime>0)
                        Thread.Sleep(SystemSetting.SendWaitTime);
                    byte t = PubClass.GetCheckSum(str_EffData, 0, str_EffData.Length);
                    list.Add(t);
                    frameNum++;
                    if (frameNum == 100 || i >= fileBytes.Length)
                    {
                        Thread.Sleep(1);
                        byte[] crc16Check = PubClass.CRC16_Modbus(list);
                        if (crc16Check.Length != 2)
                        {
                            crc16Check = new byte[2] { 0, 0 };
                        }
                        list.Clear();
                        str_FrameData = new byte[] { (byte)((frameNum >> 8) & 0xFF), (byte)(frameNum & 0xFF), 0, 0, 0, 0, 0, 0 };
                        str_FrameData[6] = crc16Check[0];
                        str_FrameData[7] = crc16Check[1];
                        _radar.SendCmd(RadarCommand.SendFileCheck, str_FrameData, false);
                        sw.Restart();
                        isOk = null;
                        cans = null;
                        while (sw.ElapsedMilliseconds < 1000)
                        {
                            lock (_recvList)
                            {
                                cans = _recvList.ToList();
                                _recvList.Clear();
                            }
                            foreach (can_frame frame in cans)
                            {
                                if (frame.can_id == 0x105)
                                {
                                    isOk = frame.data[0] == 0x0F;
                                    break;
                                }
                            }
                            if (isOk != null)
                                break;
                            Thread.Sleep(1);
                        }
                        sw.Stop();
                        if (isOk != true)
                        {
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "SendFileFailed"); });
                            return;
                        }
                        this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "SendingFile")} {(i <= fileBytes.Length ? i : fileBytes.Length)}/{fileBytes.Length}"; pb_Upgrade.Value++; });
                        frameNum = 0;
                    }
                }
                #endregion Send File

                #region upgrade File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "Upgrading"); pb_Upgrade.Value++; });
                cans = null;
                _recvList.Clear();
                _radar.SendCmd(RadarCommand.StartUpgrade, addRadarId: false);
                sw.Restart();
                isOk = null;
                while (sw.ElapsedMilliseconds < 20000)
                {
                    lock (_recvList)
                    {
                        cans = _recvList.ToList();
                        _recvList.Clear();
                    }
                    foreach (can_frame frame in cans)
                    {
                        if (frame.can_id == 0x109)
                        {
                            isOk = frame.data[0] == 0x0F;
                            break;
                        }
                    }
                    if (isOk != null)
                        break;
                    Thread.Sleep(10);
                }
                sw.Stop();
                if (isOk == true)
                    this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeSuccessed"); pb_Upgrade.Value = pb_Upgrade.Maximum; });
                else
                    this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeFailed"); });
                return;
                #endregion upgrade File
            }
            catch { }
            finally
            {
                _isRecv = false;
                sw.Stop();
                str_UpTimer.Stop();
                if (!isClosing)
                    this.Invoke((EventHandler)delegate { EnableControls(true); });
            }
        }
    }

}

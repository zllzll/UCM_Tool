using CommonLib;
using LogProc;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.MessageBoxEx;
using UCM_Tools.Models;
using UCM_Tools.Radar;
using UCM_Tools.Radar.Communication;
using UCM_Tools.Radar.Protocols;
using UCM_Tools.Radar.Protocols.UpgradeProtocol;
using UCM_Tools.Tools;
using ZLGCAN;
using static Kitware.VTK.vtkGenericEnSightReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UCM_Tools.CAN_Conn.CAN_Function;
using static UCM_Tools.Tools.PubClass;

namespace UCM_Tools.Forms
{
    public partial class UpgradeForm : UIForm
    {
        ConnParams connParams = new ConnParams();
        IConn conn = null;
        /// <summary>
        /// 雷达类型
        /// </summary>
        private ConfigXMLRadar.Project str_Project;

        private System.Timers.Timer str_UpTimer = new System.Timers.Timer(1000);

        int second = 0;

        bool isClosing = false;

        Thread thread = null;

        bool _isRecv = false;
        ConcurrentQueue<ConnData> _recvQueue = new ConcurrentQueue<ConnData>();
        List<byte> _recvBytesList = new List<byte>();

        /// <summary>
        /// 每帧文件数据字节数
        /// </summary>
        private const int LENGTH_DATA_FRAME = 1024;
        public UpgradeForm()
        {
            InitializeComponent();
            // 设置窗体双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
        
        private void UpgradeForm_Load(object sender, EventArgs e)
        {
            //初始化主题
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);

            LoadLanguage();
            InitControls();
            RadarModel();
            UpTime();
        }

        #region 语言加载
        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("MainForm", "ts_RadarUpgrade");
                btn_File.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_File");
                btn_Version.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_Version");
                btn_Upgrade.Text = MultiLanguage.LanguageText("UpgradeForm", "btn_Upgrade");

                lb_RadarType.Text = MultiLanguage.LanguageText("ConnectSettingForm", "RadarType");
                lb_ConnType.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ConnType");
                lb_DeviceType.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DeviceName");
                lb_DeviceIndex.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DeviceIndex");
                lb_ChannelIndex.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ChannelIndex");
                lb_ABitBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "ABitBaud");
                lb_DBitBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DBitBaud");
                lb_CANFDStandard.Text = MultiLanguage.LanguageText("ConnectSettingForm", "CANFDStandard");
                lb_CANBaud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "CANBaud");

                lb_DeviceAddress.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DeviceAddress");
                lb_DevicePort.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DevicePort");

                lb_COM_No.Text = MultiLanguage.LanguageText("ConnectSettingForm", "SerialNum");
                lb_COM_Baud.Text = MultiLanguage.LanguageText("ConnectSettingForm", "CANBaud");
                lb_Parity.Text = MultiLanguage.LanguageText("ConnectSettingForm", "SeriaParity");
                lb_DataBit.Text = MultiLanguage.LanguageText("ConnectSettingForm", "DataBit");
                lb_StopBit.Text = MultiLanguage.LanguageText("ConnectSettingForm", "StopBit");
            }
            catch (Exception ex) { Log.Error($"ConnectSetForm LoadLanguage() Ex\r\n{ex.ToString()}"); }
        }
        #endregion 语言加载

        #region 控件初始化
        private void InitControls()
        {
            try
            {
                cmb_CANFactory.Items.Clear();
                EnumCls.EnumDescriptionToComboBox<CAN_Factory>(cmb_CANFactory);
                string company = EnumCls.GetEnumDescription<CAN_Factory>(SystemSetting.CAN_Company);
                if (cmb_CANFactory.Items.Contains(company))
                    cmb_CANFactory.Text = company;
                else if (cmb_CANFactory.Items.Count > 0)
                    cmb_CANFactory.SelectedIndex = 0;
                else
                    cmb_CANFactory.SelectedIndex = -1;
                //CANFD标准
                cmb_CANFDStandard.SelectedIndex = SystemSetting.CANFD_Standard;
                //CANFD仲裁域波特率
                cmb_ABit.Items.Clear();
                EnumCls.EnumDescriptionToComboBox<CANFD_BAUD_ARBITRATE>(cmb_ABit);
                cmb_ABit.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CANFD_BAUD_ARBITRATE>((int)SystemSetting.CANFD_Baud_Abit));
                //CANFD数据域波特率
                cmb_DBit.Items.Clear();
                EnumCls.EnumDescriptionToComboBox<CANFD_BAUD_DATA>(cmb_DBit);
                cmb_DBit.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CANFD_BAUD_DATA>((int)SystemSetting.CANFD_Baud_Dbit));

                cmb_CAN_Baud.Items.Clear();
                EnumCls.EnumDescriptionToComboBox<CAN_BAUD>(cmb_CAN_Baud);
                cmb_CAN_Baud.Text = EnumCls.GetEnumDescription(EnumCls.ConvertEnumToString<CAN_BAUD>((int)SystemSetting.CAN_Baud));
                //设备索引
                cmb_CANIndex.SelectedIndex = (int)SystemSetting.CAN_Index;
                cmb_ChannelIndex.SelectedIndex = SystemSetting.CAN_Channel;

                tb_DeviceAddress.Text = SystemSetting.TCP_IP;
                tb_DevicePort.Text = $"{SystemSetting.TCP_Port}";
                cmb_COM_No_DropDown(null, null);
                cmb_COM_No.SelectedIndex = cmb_COM_No.Items.IndexOf(SystemSetting.COM_No);
                EnumCls.EnumDescriptionToComboBox<SerialPortBaudRates>(cmb_COM_Baud);//加载COM波特率
                cmb_COM_Baud.SelectedIndex = cmb_COM_Baud.Items.IndexOf(SystemSetting.COM_Baud.ToString());
                EnumCls.EnumDescriptionToComboBox<SerialPortDatabits>(cmb_DataBit);//加载COM数据位
                cmb_DataBit.SelectedIndex = cmb_DataBit.Items.IndexOf(SystemSetting.COM_DataBit);
                EnumCls.EnumDescriptionToComboBox<Stopbits>(cmb_StopBit);//加载COM停止位
                cmb_StopBit.SelectedIndex = cmb_StopBit.Items.IndexOf(SystemSetting.COM_StopBit);
                EnumCls.EnumDescriptionToComboBox<ParityEnum>(cmb_Parity);//加载COM检验位
                cmb_Parity.SelectedIndex = cmb_Parity.Items.IndexOf(SystemSetting.COM_Parity);

            }
            catch (Exception ex) { Log.Error($"ConnectSetForm InitControls() Ex\r\n{ex.ToString()}"); }
        }
        private void cmb_CANFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设备类型
            cmb_DeviceType.Items.Clear();
            if (cmb_CANFactory.SelectedIndex < 0)
                return;
            EnumCls.EnumDescriptionToComboBox<ZLG_CAN_TYPE>(cmb_DeviceType);
            if (EnumCls.GetEnum<CAN_Factory>(cmb_CANFactory.Text) == CAN_Factory.CX)
            {
                cmb_DeviceType.Items.Remove(EnumCls.GetEnumDescription<ZLG_CAN_TYPE>(ZLG_CAN_TYPE.USBCAN1));
                cmb_DeviceType.Items.Remove(EnumCls.GetEnumDescription<ZLG_CAN_TYPE>(ZLG_CAN_TYPE.USBCAN2));
            }

            if (cmb_DeviceType.Items.Contains(SystemSetting.Zlg_CAN_Type))
                cmb_DeviceType.Text = SystemSetting.Zlg_CAN_Type;
            else if (cmb_DeviceType.Items.Count > 0)
                cmb_DeviceType.SelectedIndex = 0;
            else
                cmb_DeviceType.SelectedIndex = -1;
        }
        private void cmb_DeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCANFD_200U), true) == 0)
            {

                pan_CANParams.BringToFront();
                pan_CANParams.Dock = DockStyle.Fill;
                pan_CANFD.BringToFront();
                pan_CANFD.Dock = DockStyle.Fill;
            }
            else if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0)
            {

                pan_USBCAN.BringToFront();
                pan_USBCAN.Dock = DockStyle.Fill;
            }
            _ConnSelectedIndexChanged(null, null);
        }
        #endregion 控件初始化

        #region 雷达型号

        /// <summary>
        /// 读取雷达型号
        /// </summary>
        public void RadarModel()
        {
            this.cmb_RadarType.Items.Clear();
            List<RadarType> radarTypes = new List<RadarType>();
            str_Project = ConfigXMLRadar.getInstance().OpenXML();
            foreach (ConfigXMLRadar.RadarType radar in str_Project.radar)
            {
                if (radar.id == "0")//去掉id=0的雷达型号
                    continue;
                radarTypes.Add(new RadarType() { RadarNo = radar.id, RadarName = radar.name });

            }
            cmb_RadarType.DataSource = radarTypes;
            cmb_RadarType.ValueMember = "RadarNo";
            cmb_RadarType.DisplayMember = "RadarName";
            if (cmb_RadarType.Items.Contains(SystemSetting.RadarType))
            {
                cmb_RadarType.SelectedIndex = cmb_RadarType.Items.IndexOf(SystemSetting.RadarType);
            }
            else if (cmb_RadarType.Items.Count > 0)
                cmb_RadarType.SelectedIndex = 0;
            else
                cmb_RadarType.SelectedIndex = -1;
        }

        /// <summary>
        /// 型号选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _SelectedIndexChanged(object sender, EventArgs e)
        {
            RadarConn();
        }

        /// <summary>
        /// 雷达型号选取对应的连接方式
        /// </summary>
        private void RadarConn()
        {
            if (String.IsNullOrEmpty(cmb_RadarType.Text)) return;
            for (int k = 0; k < str_Project.radar.Count; k++)
            {
                if (cmb_RadarType.Text.Equals(str_Project.radar[k].name))
                {
                    cmb_ConnType.Items.Clear();
                    string[] connectTypeArray = str_Project.radar[k].communication.Split(',');
                    for (int i = 0; i < connectTypeArray.Length; i++)
                    {
                        cmb_ConnType.Items.Add(connectTypeArray[i]);
                    }
                }
            }
            if (cmb_ConnType.Items.Contains(SystemSetting.ConnType))
            {
                cmb_ConnType.SelectedIndex = cmb_ConnType.Items.IndexOf(SystemSetting.ConnType);
            }
            else if (cmb_ConnType.Items.Count > 0)
                cmb_ConnType.SelectedIndex = 0;
            else
                cmb_ConnType.SelectedIndex = -1;
        }

        /// <summary>
        /// 通讯选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ConnSelectedIndexChanged(object sender, EventArgs e)
        {
            string way = cmb_ConnType.Text;
            int width = 0;
            if (!uiPanel67.Visible && !uiPanel71.Visible)
                width = -43;
            if (string.Compare("CAN", way, true) == 0 && string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCANFD_200U), true) == 0)
            {
                pan_CAN.BringToFront();
                uiPanel34.Height = 184;
                this.Height = 490 + width;
            }
            else if (string.Compare("CAN", way, true) == 0 && (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0))
            {
                pan_CAN.BringToFront();
                uiPanel34.Height = 144;
                this.Height = 450 + width;
            }
            else if (string.Compare("TCP", way, true) == 0)
            {
                pan_TCP.BringToFront();
                uiPanel34.Height = 61;
                this.Height = 367 + width;
            }
            else if (string.Compare("COM", way, true) == 0)
            {
                pan_COM.BringToFront();
                uiPanel34.Height = 138;
                this.Height = 444 + width;
            }
        }

        #endregion 雷达型号

        private void cmb_COM_No_DropDown(object sender, EventArgs e)
        {
            PubClass.GetSerial(cmb_COM_No, SystemSetting.COM_No);
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

        #region 通讯
        private async Task<bool> StartConnAsync()
        {
            try
            {
                StoptConn();

                if (string.IsNullOrEmpty(cmb_RadarType.Text) || string.IsNullOrEmpty(cmb_ConnType.Text))
                {
                    //雷达型号和通讯类型为空
                    return false;
                }
                
                if (string.Compare(cmb_ConnType.Text, "TCP", true) == 0)
                {
                    string ip = tb_DeviceAddress.Text;
                    int port = tb_DevicePort.IntValue;
                    if (string.IsNullOrEmpty(ip) || !PubClass.IsIP(ip) || string.IsNullOrEmpty(tb_DevicePort.Text) || port <= 0)
                    {
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "ConnParamsError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return false;
                    }
                    connParams.ConnType = "TCP";
                    connParams.IP = ip;
                    connParams.Port = port;
                    connParams.Zlg_CAN_Type = cmb_DeviceType.Text;
                }
                else if (string.Compare(cmb_ConnType.Text, "COM", true) == 0)
                {
                    string comNo = cmb_COM_No.Text;
                    string comBaud = cmb_COM_Baud.Text;
                    string comParity = cmb_Parity.Text;
                    string comDataBit = cmb_DataBit.Text;
                    string comStopBit = cmb_StopBit.Text;
                    if (string.IsNullOrEmpty(comNo) || string.IsNullOrEmpty(comBaud) || string.IsNullOrEmpty(comParity) || string.IsNullOrEmpty(comDataBit) || string.IsNullOrEmpty(comStopBit))
                    {
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "ConnParamsError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return false;
                    }
                    connParams.ConnType = "COM";
                    connParams.COM_No = comNo;
                    connParams.COM_Baud = int.Parse(comBaud);
                    connParams.COM_Parity = comParity;
                    connParams.COM_StopBit = comStopBit;
                    connParams.COM_DataBit = comDataBit;
                }
                else if (string.Compare(cmb_ConnType.Text, "CAN", true) == 0)
                {
                    if (string.IsNullOrEmpty(cmb_CANFactory.Text) || string.IsNullOrEmpty(cmb_DeviceType.Text) || string.IsNullOrEmpty(cmb_CANIndex.Text) || string.IsNullOrEmpty(cmb_ChannelIndex.Text))
                    {
                        //设备名称/设备号/通道号为空
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "DataEmpty"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return false;
                    }
                    if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCANFD_200U), true) == 0)
                    {
                        if (string.IsNullOrEmpty(cmb_ABit.Text) || string.IsNullOrEmpty(cmb_DBit.Text) || string.IsNullOrEmpty(cmb_CANFDStandard.Text))
                        {
                            //仲裁域/数据域/标准为空
                            UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "DataEmpty"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                            return false;
                        }

                        connParams.Zlg_Type = "CANFD";
                        connParams.CANFD_Baud_Abit = (uint)EnumCls.GetEnum<CANFD_BAUD_ARBITRATE>(cmb_ABit.Text);
                        connParams.CANFD_Baud_Dbit = (uint)EnumCls.GetEnum<CANFD_BAUD_DATA>(cmb_DBit.Text);
                        connParams.CANFD_Standard = cmb_CANFDStandard.SelectedIndex;
                    }
                    else if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0)
                    {
                        connParams.Zlg_Type = "CAN";
                        connParams.CAN_Baud = (uint)EnumCls.GetEnum<CAN_BAUD>(cmb_CAN_Baud.Text);

                    }
                    connParams.ConnType = "CAN";
                    connParams.CAN_Company = EnumCls.GetEnum<CAN_Factory>(cmb_CANFactory.Text);
                    connParams.Zlg_CAN_Type = cmb_DeviceType.Text;
                    connParams.CAN_Index = (uint)cmb_CANIndex.SelectedIndex;
                    connParams.CAN_Channel = cmb_ChannelIndex.SelectedIndex;
                }
                else
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "NoSupportConnType"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return false;
                }
                conn = ProtocolManage.InitConn(string.Compare(connParams.ConnType, "CAN", true) == 0 ? "CANFD" : connParams.ConnType);
                conn.connParams = connParams;
                if (conn != null && !await conn.OpenDevice())
                {
                    UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "DeviceConnectFailed"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                    return false;
                }
                conn.OnRecvConnDataEvent += Conn_OnRecvConnDataEvent;
                return true;

            }
            catch
            {
                return false;
            }
        }

        private void Conn_OnRecvConnDataEvent(ConnData connDataList)
        {
            try
            {
                if (_isRecv)
                {
                    if (conn is Conn_COM || conn is Conn_TCP)
                    {
                        lock (_recvBytesList)
                        {
                            _recvBytesList.AddRange(connDataList.Datas);
                        }
                    }
                    else if(conn is Conn_CANFD)
                        _recvQueue.Enqueue(connDataList);
                    
                }
            }
            catch(Exception ex)
            {
                Log.Error($"UpgradeForm Conn_OnRecvConnDataEvent Ex\r\n{ex.ToString()}");
            }
        }

        private void StoptConn()
        {
            try
            {
                try
                {
                    thread?.Abort();
                    thread = null;
                }
                catch { }
                if (conn != null)
                {
                    conn.OnRecvConnDataEvent -= Conn_OnRecvConnDataEvent;
                    conn.CloseDevice();
                }
                conn = null;
            }
            catch {}
        }
        #endregion 通讯

        private void btn_File_Click(object sender, EventArgs e)
        {
            tb_Upgrade.Text = "";
            open_File.Filter = "Tgz File|*.Tgz;*.tgz|Bin File|*.Bin;*.bin|Hex File|*.Hex;*.hex";
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
            cmb_RadarType.Enabled = b;
            cmb_ConnType.Enabled = b;
            cmb_DeviceType.Enabled = b;
            cmb_CANIndex.Enabled = b;
            cmb_ChannelIndex.Enabled = b;
            cmb_CANFDStandard.Enabled = b;
            cmb_ABit.Enabled = b;
            cmb_DBit.Enabled = b;
            cmb_CAN_Baud.Enabled = b;
            cmb_COM_No.Enabled = b;
            cmb_COM_Baud.Enabled = b;
            cmb_Parity.Enabled = b;
            cmb_DataBit.Enabled = b;
            cmb_StopBit.Enabled = b;
            tb_DeviceAddress.Enabled = b;
            tb_DevicePort.Enabled = b;
            btn_File.Enabled = b;
            btn_Version.Enabled = b;
            btn_Upgrade.Enabled = b;
        }
        private async void btn_Version_Click(object sender, EventArgs e)
        {
            tb_Upgrade.Text = "";
            tb_Version.Text = "";
            lb_UpgradeTime.Text = "00:00";
            if (!(await StartConnAsync()))
            {
                return;
            }
            RadarType radarType = cmb_RadarType.SelectedItem as RadarType;
            thread = new Thread(()=>ReadVersion(radarType.RadarNo));
            thread.IsBackground = true;
            thread.Start();
        }

        private void ReadVersion(string radarIndex)
        {
            string version = string.Empty;
            try
            {
                switch (radarIndex)
                {
                    case "1"://对应UCM211
                        if (conn is Conn_CANFD)
                            version = ReadVersion_UCM211_CAN();
                        else if (conn is Conn_TCP || conn is Conn_COM)
                            version = ReadVersion_UCM211_Bytes();
                        else
                        {
                            //无对应通讯方式du
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "NoSupportConnType"); });
                        }

                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
            finally
            {
                StoptConn();
                if (!isClosing)
                    this.Invoke((EventHandler)delegate { EnableControls(true); });
            }
        }

        private string ReadVersion_UCM211_CAN()
        {
            return string.Empty;
        }

        private string ReadVersion_UCM211_Bytes()
        {
            Stopwatch sw = new Stopwatch();
            string version = string.Empty;
            try
            {
                #region 读版本
                List<byte> bytesTemp = new List<byte>();
                _isRecv = true;
                _recvBytesList.Clear();
                Protocol_UCM211_Bytes pro = new Protocol_UCM211_Bytes();
                ConnData cmd = pro.PackFrame(RadarCommand.ReadSoftwareVersion);
                cmd.ConnType = connParams.ConnType;
                conn.SendCmd(cmd);
                sw.Restart();
                while (sw.ElapsedMilliseconds < 5000)
                {
                    lock (_recvBytesList)
                    {
                        bytesTemp.AddRange(_recvBytesList);
                        _recvBytesList.Clear();
                    }
                    if(GetFullFrame_UCM211(ref bytesTemp,out byte[] frame,out int frameType) && frameType==1)
                    {
                        //命令字
                        byte[] cmdByte;
                        int index = 2;

                        cmdByte = new byte[10];
                        Array.Copy(frame, index, cmdByte, 0, cmdByte.Length);
                        index += 10;


                        string command = Encoding.ASCII.GetString(cmdByte)?.Replace("\0", "");
                        //返回值
                        int returnValue = BitConverter.ToInt32(frame, index);
                        index += 4;
                        //标志
                        int flags = BitConverter.ToInt32(frame, index);
                        index += 4;
                        //内容长度
                        int size = BitConverter.ToInt32(frame, index);
                        index += 4;
                        byte[] data = null;
                        if (size > 0)
                        {
                            data = new byte[size];
                            Array.Copy(frame, index, data, 0, data.Length);
                            //Log.Debug("Recev Params data:0x" + BitConverter.ToString(data).Replace("-", " 0x"));
                        }
                        if (string.Compare(FuncTYType.getVer.ToString(), command, true) == 0)//版本获取回复
                        {
                            //版本号
                            if (returnValue == 0 && data != null && data.Length > 0)
                            {
                                version = Encoding.ASCII.GetString(data);
                                break;
                            }
                        }
                    }
                }
                sw.Stop();
                #endregion 读版本
            }
            catch (Exception ex) 
            {
                Log.Error($"ReadVersion Ex\r\n{ex.ToString()}");
                version = string.Empty;
            }
            finally
            {
                _isRecv = false;
                sw.Stop();
            }
            return version;
        }

        private async void btn_Upgrade_Click(object sender, EventArgs e)
        {
            lb_UpgradeTime.Text = "00:00";
            tb_Upgrade.Text = "";
            tb_Version.Text = "V0.0.0";
            byte[] file_Data = PubClass.ReadFileData(tb_File.Text);
            if (file_Data == null || file_Data.Length <= 16)
            {
                tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeFileError");
                return;
            }
            if (!(await StartConnAsync()))
            {
                return;
            }
            RadarType radarType = cmb_RadarType.SelectedItem as RadarType;
            thread = new Thread(()=>Upgrade(radarType.RadarNo, file_Data));
            thread.IsBackground = true;
            thread.Start();
        }
        private void Upgrade(string radarIndex,byte[] data)
        {
            bool isSuccess = false;
            try
            {
                switch (radarIndex)
                {
                    case "1"://对应UCM211
                        if (conn is Conn_CANFD)
                            isSuccess = UpgradeCAN(data);
                        else if (conn is Conn_TCP || conn is Conn_COM)
                            isSuccess = UpgradeBytes(data);
                        else
                        {
                            //无对应通讯方式升级NoSupportConnType
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "NoSupportConnType"); });
                            isSuccess = false;
                        }

                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                Log.Error($"Upgrade(string radarIndex,byte[] data) Ex\r\n{ex.ToString()}");
            }
            finally
            {
                StoptConn();
                if (!isClosing)
                    this.Invoke((EventHandler)delegate 
                    { 
                        EnableControls(true);
                        if (isSuccess)
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "UpgradeSuccessed")}"; pb_Upgrade.Value = pb_Upgrade.Maximum; });
                        else
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeFailed"); });
                    });
            }
        }

        private bool UpgradeCAN(byte[] fileBytes)
        {
            if (fileBytes == null || fileBytes.Length <= 0 || fileBytes.Length > 0x7FFFFFFF)
            {
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeFileError"); });//文件错误
                return false;
            }
            int byteSum = fileBytes.Length;
            Stopwatch sw = new Stopwatch();
            try
            {
                str_UpTimer.Start();
                // 进入升级模式
                this.Invoke((EventHandler)delegate { EnableControls(false); tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "EnterUpgrade"); pb_Upgrade.Maximum = byteSum / 800 + 5; pb_Upgrade.Value = 1; });
                Protocol_UCM211_CAN protocol_UCM211_CAN = new Protocol_UCM211_CAN();
                ConnData connData = protocol_UCM211_CAN.PackFrame(RadarCommand.EnterUpgrade);
                _recvQueue.Clear();
                conn.SendCmd(connData);
                Thread.Sleep(10);
                #region Earse File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "EarsingFile"); pb_Upgrade.Value++; });
                

                connData = protocol_UCM211_CAN.PackFrame(RadarCommand.EarseFile);
                _recvQueue.Clear();
                Console.WriteLine($"_recvQueue:{_recvQueue.Count}");
                _isRecv = true;
                conn.SendCmd(connData);
                sw.Restart();
                bool? isOk = null;
                while (sw.ElapsedMilliseconds < 5000)
                {
                    while (_recvQueue.TryDequeue(out ConnData frame))
                    {
                        if (sw.ElapsedMilliseconds > 5000)
                            break;
                        //Console.WriteLine(frame.FrameID.ToString("X4"));
                        if (frame.FrameID == 0x102)
                        {
                            isOk = frame.Datas[0] == 0x0F;
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
                    return false;
                }
                #endregion Earse File

                #region Send File
                int i = 0;
                int frameNum = 0;
                List<byte> list = new List<byte>();
                byte[] str_EffData = new byte[8];
                byte[] str_FrameData = new byte[8];
                List<ConnData> fileFrame = new List<ConnData>();
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
                    connData = protocol_UCM211_CAN.PackFrame(RadarCommand.SendFile, str_EffData, false);
                    fileFrame.Add(connData);
                    //conn.SendCmd(connData);
                    //if (SystemSetting.SendWaitTime > 0)
                    //    Thread.Sleep(SystemSetting.SendWaitTime);
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
                        _recvQueue.Clear();
                        connData = protocol_UCM211_CAN.PackFrame(RadarCommand.SendFileCheck, str_FrameData, false);
                        fileFrame.Add(connData);
                        // conn.SendCmd(connData);
                        if (conn is Conn_CANFD)
                        {
                            bool b =  ((Conn_CANFD)conn).SendCmd(fileFrame);
                            //Console.WriteLine(b);
                        }
                        sw.Restart();
                        isOk = null;

                        while (sw.ElapsedMilliseconds < 5000)
                        {
                            while (_recvQueue.TryDequeue(out ConnData frame))
                            {
                                if (sw.ElapsedMilliseconds > 5000)
                                    break;
                                if (frame.FrameID == 0x105)
                                {
                                    isOk = frame.Datas[0] == 0x0F;
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
                            return false;
                        }
                        this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "SendingFile")} {(i <= fileBytes.Length ? i : fileBytes.Length)}/{fileBytes.Length}"; pb_Upgrade.Value++; });
                        frameNum = 0;
                        fileFrame.Clear();
                    }
                }
                #endregion Send File

                #region upgrade File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "Upgrading"); pb_Upgrade.Value++; });
                _recvQueue.Clear();
                connData = protocol_UCM211_CAN.PackFrame(RadarCommand.StartUpgrade,addRadarId: false);
                conn.SendCmd(connData);
                sw.Restart();
                isOk = null;
                while (sw.ElapsedMilliseconds < 5000)
                {
                    while (_recvQueue.TryDequeue(out ConnData frame))
                    {
                        if (sw.ElapsedMilliseconds > 1000)
                            break;
                        if (frame.FrameID == 0x109)
                        {
                            isOk = frame.Datas[0] == 0x0F;
                            break;
                        }
                    }

                    if (isOk != null)
                        break;
                    Thread.Sleep(1);
                }
                sw.Stop();
                //if (isOk == true && SystemSetting.WaitUpgradeEndTime > 0)
                //{
                //    sw.Restart();
                //    while (sw.ElapsedMilliseconds < SystemSetting.WaitUpgradeEndTime)
                //    {
                //        Thread.Sleep(10);
                //    }
                //    sw.Stop();
                //}
                return isOk == true;
                #endregion upgrade File
            }
            catch (Exception ex)
            {
                Log.Error($"UpgradeBytes Ex\r\n{ex.ToString()}");
                return false;
            }
            finally
            {
                _isRecv = false;
                sw.Stop();
                str_UpTimer.Stop();
                second = 0;
            }
        }

        private bool UpgradeBytes(byte[] fileBytes)
        {
            if(fileBytes==null || fileBytes.Length <= 0 || fileBytes.Length > 0x7FFFFFFF)
            {
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradeFileError"); });//文件错误
                return false;
            }
            int byteSum = fileBytes.Length;
            Stopwatch sw = new Stopwatch();
            try
            {
                str_UpTimer.Start();
                // 升级准备
                this.Invoke((EventHandler)delegate { EnableControls(false); tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradePreparation"); pb_Upgrade.Maximum = byteSum / LENGTH_DATA_FRAME + 5; pb_Upgrade.Value = 1; });
                List<byte> cmd = Upgrade_UCM211_Bytes.PackageUpgradeProtocol(0x01, BitConverter.GetBytes(byteSum).ToList());
                Protocol_UCM211_Bytes pro = new Protocol_UCM211_Bytes();
                List<byte> bytes = new List<byte>();
                bytes.AddRange(BitConverter.GetBytes(1)); bytes.AddRange(BitConverter.GetBytes(0)); bytes.AddRange(BitConverter.GetBytes(0));
                ConnData connData = pro.PackFrame(RadarCommand.EnterUpgrade, bytes.ToArray());
                conn.SendCmd(connData);
                Thread.Sleep(10);
                #region 升级准备
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradePreparation"); pb_Upgrade.Value++; });//升级准备
                List<byte> bytesTemp = new List<byte>();
                _isRecv = true;
                _recvBytesList.Clear();
                cmd = Upgrade_UCM211_Bytes.PackageUpgradeProtocol(0x01, BitConverter.GetBytes(byteSum).ToList());
                conn.SendCmd(new ConnData() { ConnType = connParams.ConnType, Datas = cmd, Length = cmd.Count });
                sw.Restart();
                bool? isOk = null;
                while (sw.ElapsedMilliseconds < 5000)
                {
                    lock (_recvBytesList)
                    {
                        bytesTemp.AddRange(_recvBytesList);
                        _recvBytesList.Clear();
                    }
                    while (bytesTemp.Count >= 8)
                    {
                        if (sw.ElapsedMilliseconds > 5000)
                            break;
                        if (bytesTemp[0] != 0xEB || bytesTemp[1] != 0xCD || bytesTemp[2] != 0x03 || bytesTemp[3] != 0x00 || bytesTemp[4] != 0x05 || bytesTemp[5] != 0x01 || bytesTemp[7] != PubClass.GetCheckSum(bytesTemp.ToArray(), 2, 5))
                        {
                            bytesTemp.RemoveAt(0);
                            continue;
                        }
                        if(bytesTemp[6]==0x0A)
                            isOk = true;
                        else
                            isOk = false;
                        break;
                    }
                    
                    if (isOk != null)
                        break;
                    Thread.Sleep(10);
                }
                sw.Stop();
                if (isOk != true)
                {
                    this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "UpgradePreparationFailed"); });
                    return false;
                }
                #endregion 升级准备

                #region Send File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "DataTransport"); pb_Upgrade.Value++; });//升级准备
                int sendCount = 0;
                int sended = 0;
                List<byte> listData = new List<byte>();
                while (sended < byteSum)
                {
                    listData.Clear();
                    //LENGTH_COM_DATA_FRAME个数据
                    for (int nu = 0; nu < LENGTH_DATA_FRAME; nu++)
                    {
                        if (byteSum - 1 - sended >= 0)
                        {
                            listData.Add(fileBytes[sended]);
                            sended++;
                        }
                    }
                    bool isResend = false;
                    int resendCount = 0;
                    do
                    {
                        cmd = Upgrade_UCM211_Bytes.PackageUpgradeProtocol(0x02, Upgrade_UCM211_Bytes.PackageUpgradeWriteData(LENGTH_DATA_FRAME * sendCount, listData));
                        _recvBytesList.Clear();
                        conn.SendCmd(new ConnData() { ConnType = connParams.ConnType, Datas = cmd, Length = cmd.Count });
                        bytesTemp.Clear();
                        sw.Restart();
                        isOk = null;
                        while (sw.ElapsedMilliseconds < 5000)
                        {
                            lock (_recvBytesList)
                            {
                                bytesTemp.AddRange(_recvBytesList);
                                _recvBytesList.Clear();
                            }
                            while (bytesTemp.Count >= 8)
                            {
                                if (sw.ElapsedMilliseconds > 5000)
                                    break;
                                if (bytesTemp[0] != 0xEB || bytesTemp[1] != 0xCD || bytesTemp[2] != 0x03 || bytesTemp[3] != 0x00 || bytesTemp[4] != 0x05 || bytesTemp[5] != 0x02 || bytesTemp[7] != PubClass.GetCheckSum(bytesTemp.ToArray(), 2, 5))
                                {
                                    bytesTemp.RemoveAt(0);
                                    continue;
                                }
                                if (bytesTemp[6] == 0x0A)
                                {
                                    isOk = true;
                                    break;
                                }
                                else
                                {
                                    isOk = false;
                                    isResend = bytesTemp[6] == 0x0F;
                                    if (bytesTemp[6] == 0x1F)
                                        this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "DataTransportFailed")}"; });
                                    else
                                        this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "DataTransport")} {sended}/{byteSum}Bytes {MultiLanguage.LanguageText("ErrorInfo", "CheckFailedResend")}"; });
                                    break;
                                }
                            }
                            if (isResend) //重发
                            {
                                Log.Debug($"resend---{sended}/{byteSum}Bytes");
                                resendCount++;
                                isResend = false;
                                break;
                            }
                            isResend = false;
                            if (isOk == true)//成功
                                break;
                            else if (isOk == false)//失败
                                return false;
                        }
                        sw.Stop();
                        if (sw.ElapsedMilliseconds > 5000 || resendCount > 3)//超时或3次重发判定失败
                        {
                            this.Invoke((EventHandler)delegate { tb_Upgrade.Text = $"{MultiLanguage.LanguageText("ErrorInfo", "DataTransportFailed")}"; });
                            return false;
                        }
                    } while (isResend);

                    if (sended < byteSum)
                        this.Invoke((EventHandler)delegate { pb_Upgrade.Value++; tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "DataTransport") + sended + "/" + byteSum + "Bytes"; });
                    else
                        this.Invoke((EventHandler)delegate { pb_Upgrade.Value++; tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "DataTransportFinish"); });
                    sendCount++;
                }
                #endregion Send File

                #region upgrade File
                this.Invoke((EventHandler)delegate { tb_Upgrade.Text = MultiLanguage.LanguageText("ErrorInfo", "DataTransportFinish"); pb_Upgrade.Value++; });
                cmd = Upgrade_UCM211_Bytes.PackageUpgradeProtocol(0x03, new List<byte>());
                _recvBytesList.Clear();
                conn.SendCmd(new ConnData() { ConnType = connParams.ConnType, Datas = cmd, Length = cmd.Count });
                bytesTemp.Clear();
                sw.Restart();
                isOk = null;
                while (sw.ElapsedMilliseconds < 5000)
                {
                    lock (_recvBytesList)
                    {
                        bytesTemp.AddRange(_recvBytesList);
                        _recvBytesList.Clear();
                    }
                    while (bytesTemp.Count >= 8)
                    {
                        if (sw.ElapsedMilliseconds > 5000)
                            break;
                        if (bytesTemp[0] != 0xEB || bytesTemp[1] != 0xCD || bytesTemp[2] != 0x03 || bytesTemp[3] != 0x00 || bytesTemp[4] != 0x05 || bytesTemp[5] != 0x03 || bytesTemp[7] != PubClass.GetCheckSum(bytesTemp.ToArray(), 2, 5))
                        {
                            bytesTemp.RemoveAt(0);
                            continue;
                        }
                        if (bytesTemp[6] == 0x0A)
                            isOk = true;
                        else
                            isOk = false;
                        break;
                    }

                    if (isOk != null)
                        break;
                    Thread.Sleep(10);
                }
                sw.Stop();
                
                if (isOk == true && SystemSetting.WaitUpgradeEndTime > 0)
                {
                    sw.Restart();
                    while (sw.ElapsedMilliseconds < SystemSetting.WaitUpgradeEndTime)
                    {
                        Thread.Sleep(10);
                    }
                    sw.Stop();
                }
                return isOk == true;
                #endregion upgrade File
            }
            catch (Exception ex)
            {
                Log.Error($"UpgradeBytes Ex\r\n{ex.ToString()}");
                return false; 
            }
            finally
            {
                _isRecv = false;
                sw.Stop();
                str_UpTimer.Stop();
                second = 0;
            }
        }

        private void UpgradeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDispose();
        }

        public void FormDispose()
        {
            try
            {
                isClosing = true;
                str_UpTimer.Enabled = false;
                second = 0;
                StoptConn();
                thread?.Abort();
            }
            catch { }
        }

        #region MyRegion
        public bool GetFullFrame_UCM211(ref List<byte> bytes,out byte[] frame,out int frameType)
        {
            frame = null;
            frameType = -1;
            if (bytes == null || bytes.Count <= 0)
                return false;
            byte[] buff = bytes?.ToArray();
            try
            {
                int first = 0, second = 0;
                while (bytes.Count >= 24)
                {
                    first = Array.IndexOf(buff, 0xA5);
                    second = Array.IndexOf(buff, 0x5A);
                    if ((first < 0 && second < 0) || (first < 0 && second >= 0 && (buff.Length - 1) != second) || (first >= 0 && second < 0 && (buff.Length - 1) != first))
                    {
                        Array.Resize(ref buff, 0);
                        bytes = buff.ToList();
                        return false;
                    }
                    else if ((first < 0 && second >= 0 && (buff.Length - 1) == second) || (first >= 0 && second < 0 && (buff.Length - 1) == first))
                    {
                        bytes = buff.ToList();
                        return false;
                    }
                    if (second < 0)
                    {
                        bytes = buff.ToList();
                        return false;
                    }
                    if (second - first == 1)//目标帧
                    {
                        buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                        if (buff.Length < 4)
                        {
                            bytes = buff.ToList();
                            return false;
                        }

                        int dataModelTotalLen = BitConverter.ToUInt16(buff, 2);// (buff[2] << 8) + buff[3];//数据模块字节长度
                        if (buff.Length < dataModelTotalLen + 5)//列表长度必须大于一帧长度
                        {
                            bytes = buff.ToList();
                            return false;
                        }
                        if (buff.Length < 7)//确保能获取到基础信息长度
                        {
                            bytes = buff.ToList();
                            return false;
                        }
                        int totalIndex = 4;
                        if (buff[totalIndex] != 0xA7 || buff[totalIndex + 1] != 0x7A || buff[4 + dataModelTotalLen] != PubClass.GetCheckSum(buff, 4, dataModelTotalLen))//总校验和基础信息模块头需相等
                        {
                            first = Array.IndexOf(buff, 0xA5, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return false;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                            continue;
                        }

                        int dataBaseLen = buff[totalIndex + 2];//整个基本信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                        byte[] baseData = buff.Skip(4).Take(dataBaseLen).ToArray();
                        int baseIndex = 3;//基础模块信息
                        int dataStatus = baseData[baseIndex];
                        baseIndex++;
                        int TarNum = baseData[baseIndex]; //目标数量
                        baseIndex += 1;
                        int perTarByteNum = baseData[baseIndex];//每个目标信息字节数
                        baseIndex++;
                        int tarLenForBaseData = ((TarNum == 0 || perTarByteNum == 0) ? 0 : TarNum * perTarByteNum + 5);
                        int year = baseData[baseIndex];//年份偏移值
                        baseIndex++;
                        int month = baseData[baseIndex];//月
                        baseIndex++;
                        int day = baseData[baseIndex];//日
                        baseIndex++;
                        int hour = baseData[baseIndex];//时
                        baseIndex++;
                        int minutes = baseData[baseIndex];//分
                        baseIndex++;
                        int seconds = baseData[baseIndex];//秒
                        baseIndex++;
                        int millSeconds = BitConverter.ToUInt16(baseData, baseIndex);//(baseData[baseIndex] << 8) + baseData[baseIndex + 1];//毫秒
                        baseIndex += 2;
                        string time = $"{1900 + year}-{month.ToString().PadLeft(2, '0')}-{day.ToString().PadLeft(2, '0')} {hour.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}.{millSeconds.ToString().PadLeft(3, '0')}";
                        int deviceFlag = BitConverter.ToUInt16(baseData, baseIndex);//设备标识
                        baseIndex += 2;
                        int clusterNum = BitConverter.ToUInt16(baseData, baseIndex); //BitConverter.ToInt32(baseData.Skip(baseIndex).Take(4).ToArray(), 0);//点云数量
                        baseIndex += 2;
                        int perTarByteNumCluster = baseData[baseIndex];//每个点云信息字节数
                        baseIndex += 1;
                        int clusterLenForBaseData = ((clusterNum == 0 || perTarByteNumCluster == 0) ? 0 : clusterNum * perTarByteNumCluster + 5);
                        byte baseDataCheck = baseData[baseIndex];
                        baseIndex++;
                        int dataTotalLength = dataBaseLen + tarLenForBaseData + clusterLenForBaseData;

                        if (dataTotalLength != dataModelTotalLen || baseDataCheck != PubClass.GetCheckSum(baseData, 0, dataBaseLen - 1))//总数据长度和基础模块算出来的长度需相等且基础模块校验通过
                        {
                            first = Array.IndexOf(buff, 0xA5, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return false;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                            continue;
                        }
                        totalIndex += dataBaseLen;//总下标
                        if (TarNum * perTarByteNum > 0)//表示有目标模块
                        {
                            if (buff[totalIndex] != 0xA8 || buff[totalIndex + 1] != 0x8A)
                            {
                                first = Array.IndexOf(buff, 0xA5, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return false;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            int tarBaseLen = BitConverter.ToUInt16(buff, totalIndex + 2);//整个目标信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                            byte[] tarBaseData = buff.Skip(totalIndex).Take(tarBaseLen).ToArray();
                            if (tarLenForBaseData != tarBaseLen || tarBaseData[tarBaseLen - 1] != PubClass.GetCheckSum(tarBaseData, 0, tarBaseLen - 1))
                            {
                                first = Array.IndexOf(buff, 0xA5, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return false;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            totalIndex += tarBaseLen;
                        }

                        if (clusterNum * perTarByteNumCluster > 0)//表示有点云模块
                        {
                            if (buff[totalIndex] != 0xA9 || buff[totalIndex + 1] != 0x9A)
                            {
                                first = Array.IndexOf(buff, 0xA5, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return false;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            int clusterBaseLen = BitConverter.ToUInt16(buff, totalIndex + 2);//整个点云信息模块数据长度，包括信息帧头、基本信息、模块数据长度以及校验和
                            byte[] clusterBaseData = buff.Skip(totalIndex).Take(clusterBaseLen).ToArray();
                            if (clusterLenForBaseData != clusterBaseLen || clusterBaseData[clusterBaseLen - 1] != PubClass.GetCheckSum(clusterBaseData, 0, clusterBaseLen - 1))
                            {
                                first = Array.IndexOf(buff, 0xA5, first + 1);
                                if (first < 0)
                                {
                                    Array.Resize(ref buff, 0);
                                    bytes = buff.ToList();
                                    return false;
                                }
                                buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                                continue;
                            }
                            totalIndex += clusterBaseLen;
                        }
                        totalIndex++;
                        frame = new byte[totalIndex];
                        Array.Copy(buff, 0, frame, 0, totalIndex);
                        buff = buff.Skip(frame.Length).Take(buff.Length - frame.Length).ToArray();
                        bytes = buff.ToList();
                        frameType = 0;//目标帧
                        return true;
                    }
                    else if (second - first == -1)//回复帧
                    {
                        buff = buff.Skip(second).Take(buff.Length - second).ToArray();//跳过前面无用的字节
                        if (buff.Length < 4)
                        {
                            bytes = buff.ToList();
                            return false;
                        }
                        //获取参数回复帧帧头
                        if (buff[0] != 0x5A || buff[1] != 0xA5)
                        {
                            first = Array.IndexOf(buff, 0xA5, first + 1);
                            if (first < 0)
                            {
                                Array.Resize(ref buff, 0);
                                bytes = buff.ToList();
                                return false;
                            }
                            buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                        }

                        if (buff.Length < 24)
                        {
                            bytes = buff.ToList();
                            return false;
                        }
                        UInt32 size = BitConverter.ToUInt32(buff, 20);
                        if (buff.Length < (24 + size))
                        {
                            bytes = buff.ToList();
                            return false;
                        }
                        frame = new byte[24 + size];
                        Array.Copy(buff, 0, frame, 0, 24 + size);
                        buff = buff.Skip(frame.Length).Take(buff.Length - frame.Length).ToArray();
                        bytes = buff.ToList();
                        frameType = 1;
                        return true;
                    }
                    else if (first >= 0 && second >= 0 && Math.Abs(first - second) > 1)//防止查到下标相差大的两个头字节
                    {
                        int index = first > second ? second : first;
                        buff = buff.Skip(index + 1).Take(buff.Length - index).ToArray();
                    }
                    else
                    {
                        first = Array.IndexOf(buff, 0xA5, first + 1);
                        if (first < 0)
                        {
                            Array.Resize(ref buff, 0);
                            bytes = buff.ToList();
                            return false;
                        }
                        buff = buff.Skip(first).Take(buff.Length - first).ToArray();
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Log.Error($"Protocol_UCM211_Bytes GetFullFrame Ex\r\n{ex.ToString()}");
                return false;
            }
        }
        #endregion
    }
}

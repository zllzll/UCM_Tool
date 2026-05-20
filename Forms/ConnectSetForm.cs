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
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.MessageBoxEx;
using UCM_Tools.Radar;
using UCM_Tools.Tools;
using static OpenCvSharp.ConnectedComponents;
using static Sunny.UI.RandomColor;
using static UCM_Tools.CAN_Conn.CAN_Function;
using static UCM_Tools.Tools.PubClass;

namespace UCM_Tools.Forms
{
    public partial class ConnectSetForm : UIForm
    {
        /// <summary>
        /// 雷达类型
        /// </summary>
        private ConfigXMLRadar.Project str_Project;

        #region 初始化
        public ConnectSetForm()
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            
        }
        
        private void ConnectSetForm_Load(object sender, EventArgs e)
        {
            //初始化主题
            SunnyUIHelper.SetTheme(this,SystemSetting.ThemeColor);
            LoadLanguage();
            InitControls();
            RadarModel();
        }

        #region 语言加载
        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("MainForm", "ts_Connect");
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
                btn_Save.Text = MultiLanguage.LanguageText("CurrencyInfo", "Save");

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
            else if(string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0)
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
            str_Project = ConfigXMLRadar.getInstance().OpenXML();
            foreach (ConfigXMLRadar.RadarType radar in str_Project.radar)
            {
                ComboBox _comboxItem = new ComboBox();
                _comboxItem.Text = radar.name;
                cmb_RadarType.Items.Add(_comboxItem.Text);
                _comboxItem.Tag = radar.id;
            }

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
            if (string.Compare("CAN", way, true) == 0 && string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCANFD_200U), true) == 0)
            {
                pan_CAN.BringToFront();
                uiPanel34.Height = 184;
                this.Height = 363;
            }
            else if (string.Compare("CAN", way, true) == 0 && (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0))
            {
                pan_CAN.BringToFront();
                uiPanel34.Height = 144;
                this.Height = 323;
            }
            else if (string.Compare("TCP", way, true) == 0 || string.Compare("UDP", way, true) == 0)
            {
                pan_TCP.BringToFront();
                uiPanel34.Height = 61;
                this.Height = 240;
            }
            else if (string.Compare("COM", way, true) == 0)
            {
                pan_COM.BringToFront();
                uiPanel34.Height = 138;
                this.Height = 317;
            }
        }

        #endregion 雷达型号

        #endregion 初始化

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_RadarType.Text) || string.IsNullOrEmpty(cmb_ConnType.Text))
                {
                    //雷达型号和通讯类型为空
                    return;
                }
                if(string.Compare(cmb_ConnType.Text, "TCP", true) == 0 || string.Compare(cmb_ConnType.Text, "UDP", true) == 0)
                {
                    string ip = tb_DeviceAddress.Text;
                    int port = tb_DevicePort.IntValue;
                    if (string.IsNullOrEmpty(ip) || !PubClass.IsIP(ip) || string.IsNullOrEmpty(tb_DevicePort.Text) || port <= 0)
                    {
                        UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "ConnParamsError"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
                        return;
                    }
                    SystemSetting.ConnType = cmb_ConnType.Text.ToUpper();
                    SystemSetting.TCP_IP = ip;
                    SystemSetting.TCP_Port = port;
                    SystemSetting.Zlg_CAN_Type = cmb_DeviceType.Text;
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
                        return;
                    }
                    SystemSetting.ConnType = "COM";
                    SystemSetting.COM_No = comNo;
                    SystemSetting.COM_Baud = int.Parse(comBaud);
                    SystemSetting.COM_Parity = comParity;
                    SystemSetting.COM_StopBit = comStopBit;
                    SystemSetting.COM_DataBit = comDataBit;
                }
                else if (string.Compare(cmb_ConnType.Text, "CAN", true) == 0)
                {
                    if (string.IsNullOrEmpty(cmb_CANFactory.Text) || string.IsNullOrEmpty(cmb_DeviceType.Text) || string.IsNullOrEmpty(cmb_CANIndex.Text) || string.IsNullOrEmpty(cmb_ChannelIndex.Text))
                    {
                        //设备名称/设备号/通道号为空
                        return;
                    }
                    if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCANFD_200U), true) == 0)
                    {
                        if (string.IsNullOrEmpty(cmb_ABit.Text) || string.IsNullOrEmpty(cmb_DBit.Text) || string.IsNullOrEmpty(cmb_CANFDStandard.Text))
                        {
                            //仲裁域/数据域/标准为空
                            return;
                        }

                        SystemSetting.Zlg_Type = "CANFD";
                        SystemSetting.CANFD_Baud_Abit = (uint)EnumCls.GetEnum<CANFD_BAUD_ARBITRATE>(cmb_ABit.Text);
                        SystemSetting.CANFD_Baud_Dbit = (uint)EnumCls.GetEnum<CANFD_BAUD_DATA>(cmb_DBit.Text);
                        SystemSetting.CANFD_Standard = cmb_CANFDStandard.SelectedIndex;
                    }
                    else if (string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN1), true) == 0 || string.Compare(cmb_DeviceType.Text, EnumCls.GetEnumDescription(ZLG_CAN_TYPE.USBCAN2), true) == 0)
                    {
                        SystemSetting.Zlg_Type = "CAN";
                        SystemSetting.CAN_Baud = (uint)EnumCls.GetEnum<CAN_BAUD>(cmb_CAN_Baud.Text);

                    }
                    SystemSetting.ConnType = "CAN";
                    SystemSetting.CAN_Company = EnumCls.GetEnum<CAN_Factory>(cmb_CANFactory.Text);
                    SystemSetting.Zlg_CAN_Type = cmb_DeviceType.Text;
                    SystemSetting.CAN_Index = (uint)cmb_CANIndex.SelectedIndex;
                    SystemSetting.CAN_Channel = cmb_ChannelIndex.SelectedIndex;
                }
                SystemSetting.RadarType = cmb_RadarType.Text;
                
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "SaveSuccess"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"),false, SunnyUIHelper.DefaultThreme);

            }
            catch
            {
                UIMessageBoxEx.ShowMessageDialog(MultiLanguage.LanguageText("ErrorInfo", "SaveDataEx"), MultiLanguage.LanguageText("CurrencyInfo", "Prompt"), false, SunnyUIHelper.DefaultThreme);
            }
        }

        private void cmb_COM_No_DropDown(object sender, EventArgs e)
        {
            PubClass.GetSerial(cmb_COM_No, SystemSetting.COM_No);
        }

        
    }

}

using CommonLib;
using LogProc;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using UCM_Tools.Config;

namespace UCM_Tools.Tools
{
    public static class PubClass
    {
        #region 变量

        private static string path = string.Empty;

        private static Dictionary<string, string> properties = null;

        /// <summary>
        /// 鼠标移动位置变量
        /// </summary>
        private static Point mouseOff;

        /// <summary>
        /// 标签是否为左键
        /// </summary>
        private static bool leftFlag;

        /// <summary>
        /// 当前坐标
        /// </summary>
        public static Point str_Coordinate;
        public const double ε = 1e-12;
        public const string timeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        #endregion 变量

        #region Ping

        /// <summary>
        /// Ping
        /// </summary>
        public static bool Ping(string str_ip)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(str_ip);
            if (reply.Status != IPStatus.Success)
            {
                return false;
            }
            return true;
        }

        #endregion Ping

        #region 窗口移动

        /// <summary>
        /// 窗口移动
        /// </summary>
        public static void CarriagEvent(Panel pan)
        {
            str_Coordinate = pan.Location;
            pan.MouseDown += new System.Windows.Forms.MouseEventHandler(_MouseDown);
            pan.MouseMove += new System.Windows.Forms.MouseEventHandler(_MouseMove);
            pan.MouseUp += new System.Windows.Forms.MouseEventHandler(_MouseUp);
        }

        public static void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        public static void _MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                str_Coordinate = mouseSet;
            }
        }

        public static void _MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        #endregion 窗口移动

        #region 端口检测

        /// <summary>
        /// 端口检测
        /// </summary>
        public static bool PortInUse(int port)
        {
            bool inUse = false;

            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                {
                    inUse = true;
                    break;
                }
            }

            return inUse;
        }

        #endregion 端口检测

        #region 盘符判断

        /// <summary>
        /// 盘符判断
        /// </summary>
        public static bool DriverExists(string str_DriverName)
        {
            return System.IO.Directory.GetLogicalDrives().Contains(str_DriverName);
        }

        #endregion 盘符判断

        #region 角度范围

        /// <summary>
        /// 角度范围
        /// </summary>
        public static bool CheckPlotAzimuth(float azimuth, float str_Az)
        {
            //float str_Az = float.Parse(ConfigXML.GetKeyString("AzimuthAngle", "10")) / 2;
            try
            {
                if (-str_Az > azimuth)
                {
                    return false;
                }
                if (str_Az < azimuth)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion 角度范围

        #region 连接方式

        /// <summary>
        /// 连接方式
        /// </summary>
        public enum ModeType
        {
            UDP,
            COM,
            CAN,
            TCP
        }

        #endregion 连接方式

        #region 内存回收

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        #endregion 内存回收

        #region 微秒级别延时
        [DllImport("kernel32.dll")]
        public static extern short QueryPerformanceCounter(ref long x);
        [DllImport("kernel32.dll")]
        public static extern short QueryPerformanceFrequency(ref long x);

        public static void delay(long delay_Time)
        {
            long stop_Value = 0;
            long start_Value = 0;
            long freq = 0;
            long n = 0;

            QueryPerformanceFrequency(ref freq);
            long count = delay_Time * freq / 1000000;
            QueryPerformanceCounter(ref start_Value);

            while (n < count)
            {
                QueryPerformanceCounter(ref stop_Value);
                n = stop_Value - start_Value;
            }
        }
        [DllImport("kernel32.dll")]
        public static extern int CreateWaitableTimer(int lpTimerAttributes, bool bManualReset, int lpTimerName);
        [DllImport("kernel32.dll")]
        public static extern bool SetWaitableTimer(int hTimer,ref long pDueTime,int lPeriod,int pfnCompletionRoutine,int lpArgToCompletionRoutine,bool fResume);
        [DllImport("user32.dll")]
        public static extern bool MsgWaitForMultipleObjects(uint nCount,ref int pHandles,bool bWaitAll,int dwMilliseconds,uint dwWakeMask);
        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(int hObject);
        public const int NULL = 0;
        public const int QS_TIMER = 0x10;
        public static void UsDelay(int us)
        {
            long duetime = -10 * us;
            int hWaitTimer = CreateWaitableTimer(NULL, true, NULL);
            SetWaitableTimer(hWaitTimer, ref duetime, 0, NULL, NULL, false);
            while (MsgWaitForMultipleObjects(1, ref hWaitTimer, false, Timeout.Infinite, QS_TIMER)) ;
            CloseHandle(hWaitTimer);
        }
        #endregion 微秒级别延时

        #region 输入限制

        public static void _KeyPressInt(object sender, KeyPressEventArgs e)
        {
            RestrictIn(sender, "HO", e);
        }

        public static void _KeyPressUInt(object sender, KeyPressEventArgs e)
        {
            RestrictIn(sender, "NU", e);
        }

        public static void _KeyPressFloat(object sender, KeyPressEventArgs e)
        {
            RestrictIn(sender, "HP", e);
        }

        /// <summary>
        /// 输入限制
        /// </summary>
        public static void RestrictIn(object sender, string type, KeyPressEventArgs e)
        {
            e.Handled = true;

            TextBox tb = sender as TextBox;
            //获取文本框中未选中字符串
            string str = tb.Text.Remove(tb.SelectionStart, tb.SelectionLength);
            string newStr = str.Insert(tb.SelectionStart, e.KeyChar.ToString());

            switch (type)
            {
                case "HP":
                    if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)8 || e.KeyChar == '-' || e.KeyChar == '.')
                    {
                        e.Handled = false;
                    }
                    break;

                case "NU":
                    if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)8)
                    {
                        e.Handled = false;
                    }
                    if (e.KeyChar == '0' && newStr.Length != 1 && newStr.IndexOf('0') == 0)
                    {
                        e.Handled = true;
                    }
                    if (tb.Text == "0")
                    {
                        e.Handled = true;
                    }
                    break;

                case "HO":
                    if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)8 || e.KeyChar == '-')
                    {
                        e.Handled = false;
                    }
                    if (e.KeyChar == '\b')
                    {
                        newStr = newStr.Replace('\b', ' ').Trim();
                    }
                    //只能有一次负号
                    if (e.KeyChar == 45 && str.Contains('-'))
                    {
                        e.Handled = true;
                    }
                    //负号只能在第一位
                    if (e.KeyChar == '-' && newStr.IndexOf('-') != 0)
                    {
                        e.Handled = true;
                    }
                    if (newStr.Contains("-0"))
                    {
                        e.Handled = true;
                    }
                    if (newStr.Contains("00") && newStr.IndexOf("00") == 0)
                    {
                        e.Handled = true;
                    }
                    break;

                case "NP":
                    if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (Char)8 || e.KeyChar == '.')
                    {
                        e.Handled = false;
                    }
                    break;
            }
        }

        #endregion 输入限制

        #region 安防发送

        /// <summary>
        ///安防发送
        /// </summary>
        public static void Send(string ip, string message)
        {
            UdpClient _uc = new UdpClient(0);
            _uc.Connect(ip, 8100);
            byte[] sendBytes = HexToByte(message);
            _uc.Send(sendBytes, sendBytes.Length);
            _uc.Close();
        }

        #endregion 安防发送

        #region 串口数据

        /// <summary>
        /// 串口数据位列表（5,6,7,8）
        /// </summary>
        public enum SerialPortDatabits : int
        {
            [Description("5")]
            FiveBits = 5,
            [Description("6")]
            SixBits = 6,
            [Description("7")]
            SeventBits = 7,
            [Description("8")]
            EightBits = 8
        }

        /// <summary>
        /// 串口波特率列表。
        /// </summary>
        public enum SerialPortBaudRates : int
        {
            //BaudRate_75 = 75,
            //BaudRate_110 = 110,
            //BaudRate_150 = 150,
            //BaudRate_300 = 300,
            //BaudRate_600 = 600,
            //BaudRate_1200 = 1200,
            //BaudRate_2400 = 2400,
            //BaudRate_4800 = 4800,
            //BaudRate_9600 = 9600,
            //BaudRate_14400 = 14400,
            //BaudRate_19200 = 19200,
            //BaudRate_38400 = 38400,
            //BaudRate_57600 = 57600,
            [Description("115200")]
            BaudRate_115200 = 115200,
            [Description("230400")]
            BaudRate_230400 = 230400,
            [Description("460800")]
            BaudRate_460800 = 460800,
            [Description("512000")]
            BaudRate_512000 = 512000,
            [Description("921600")]
            BaudRate_921600 = 921600
        }

        /// <summary>
        /// 串口停止位列表
        /// </summary>
        public enum Stopbits
        {
            [Description("One")]
            One = 1,
            //[Description("1.5")]
            //OnePointFive = 3,
            [Description("One")]
            Two = 2,
        }

        /// <summary>
        /// 串口停止位列表
        /// </summary>
        public enum ParityEnum
        {
            [Description("None")]
            None = 1,
            [Description("Odd")]
            Odd = 2,
            [Description("Even")]
            Even = 3,
            //[Description("Mark")]
            //Mark = 4,
            //[Description("Space")]
            //Space = 5,
        }
        #endregion 串口数据

        #region 为空验证

        /// <summary>
        /// 为空验证
        /// </summary>
        public static int ReNum(Panel pan)
        {
            int str_Num = 0;
            foreach (Control c in pan.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = c as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        str_Num++;
                        break;
                    }
                }
            }
            return str_Num;
        }

        public static int ReNum(UIPanel pan)
        {
            int str_Num = 0;
            foreach (Control c in pan.Controls)
            {
                if (c is UITextBox)
                {
                    UITextBox txt = c as UITextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        str_Num++;
                        break;
                    }
                }
            }
            return str_Num;
        }

        #endregion 为空验证

        #region 升级工具

        /// <summary>
        /// 加载配置文件
        /// </summary>
        public static void loadConfig(string strFileName)
        {
            try
            {
                properties = new Dictionary<string, string>(0);
                //首先判断是否配置是否已经加载,如果没有加载，则完成加载动作
                if (properties != null)
                {
                    //创建XML文档对象
                    XmlDocument doc = new XmlDocument();
                    //获得配置文件的全路径字符串
                    //加载配置文件内容
                    doc.Load(strFileName);
                    //找出名称为“argue”的所有元素
                    XmlNodeList nodes = doc.GetElementsByTagName("argue");
                    //循环把这些KEY和VALUE插入到MAP中
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        //获得当前元素的key属性和value属性
                        XmlAttribute key = nodes[i].Attributes["key"];
                        XmlAttribute value = nodes[i].Attributes["value"];
                        //插入到MAP中
                        properties.Add(key.InnerText, value.InnerText);
                    }
                }
            }
            catch (Exception _ex)
            {
                throw new Exception(_ex.Message);
            }
        }

        /// <summary>
        /// 获取对应名字属性的值
        /// </summary>
        public static string getConfigProperties(string propertiesName)
        {
            return properties[propertiesName];
        }

        /// <summary>
        /// 设置对应名字属性的值
        /// </summary>
        public static bool setConfigPropterties(string key, string value, string file)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(file);
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName("argue");//获取所有子节点
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                    if (xe.GetAttribute("key") == key)//如果key属性值为“key”
                    {
                        xe.SetAttribute("key", key);//则修改该属性为“newkey”
                        xe.SetAttribute("value", value);
                        properties.Remove(key);
                        properties.Add(key, value);
                        break;
                    }
                }
                xmlDoc.Save(file);//保存。
                return true;
            }
            catch (Exception _ex)
            {
                throw new Exception(_ex.StackTrace);
            }
        }

        #endregion 升级工具

        #region 格式转换

        /// <summary>
        /// 转换十六进制字符串到字节数组
        /// </summary>
        /// <param name="msg">待转换字符串</param>
        /// <returns>字节数组</returns>
        public static byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");//移除空格

            byte[] comBuffer = new byte[msg.Length / 2];
            for (int i = 0; i < msg.Length; i += 2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            }

            return comBuffer;
        }

        /// <summary>
        /// 转换字节数组到十六进制字符串
        /// </summary>
        /// <param name="comByte">待转换字节数组</param>
        /// <returns>十六进制字符串</returns>
        public static string ByteToHex(byte[] comByte)
        {
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            foreach (byte data in comByte)
            {
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            }

            return builder.ToString().ToUpper();
        }

        /// <summary>
        /// Struct转换为Byte
        /// </summary>
        public static byte[] StructToBytes(object structObj)
        {
            int size = Marshal.SizeOf(structObj);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structObj, buffer, false);
                byte[] bytes = new byte[size];
                Marshal.Copy(buffer, bytes, 0, size);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        /// BytesToStruct
        /// </summary>
        public static object BytesToStruct(byte[] buf, Type structType)
        {
            IntPtr buffer = Marshal.AllocHGlobal(buf.Length);
            try
            {
                Marshal.Copy(buf, 0, buffer, buf.Length);
                return Marshal.PtrToStructure(buffer, structType);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// <summary>
        /// 实现各进制数间的转换。ConvertBase("15",10,16)表示将十进制数15转换为16进制的数。
        /// </summary>
        /// <param name="value">要转换的值,即原值</param>
        /// <param name="from">原值的进制,只能是2,8,10,16四个值。</param>
        /// <param name="to">要转换到的目标进制，只能是2,8,10,16四个值。</param>
        public static string ConvertBase(string value, int from, int to)
        {
            try
            {
                int intValue = Convert.ToInt32(value, from);  //先转成10进制
                string result = Convert.ToString(intValue, to);  //再转成目标进制
                if (to == 2)
                {
                    int resultLength = result.Length;  //获取二进制的长度
                    switch (resultLength)
                    {
                        case 7:
                            result = "0" + result;
                            break;

                        case 6:
                            result = "00" + result;
                            break;

                        case 5:
                            result = "000" + result;
                            break;

                        case 4:
                            result = "0000" + result;
                            break;

                        case 3:
                            result = "00000" + result;
                            break;
                    }
                }
                return result;
            }
            catch { return "0"; }
        }

        #endregion 格式转换

        #region 数据保存

        /// <summary>
        /// 数据保存
        /// </summary>
        public static void SaveData(string str_DataType, string context, string FileNum)
        {
            CreateDirectory(ConfigXML.GetKeyString("FileRoute", "C:\\NSM_Data\\") + "\\" + str_DataType + "\\");
            string str_num = ConfigXML.GetKeyString(FileNum, "1");//文件编号
            string str_Time = ConfigXML.GetKeyString("CurrTime", "2017-12-07");//文件编号
            try
            {
                if (!str_Time.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
                {
                    ConfigXML.SetKeyValue(FileNum, "1");
                    str_num = ConfigXML.GetKeyString(FileNum, "1");//文件编号
                }
                path = ConfigXML.GetKeyString("FileRoute", "C:\\NSM_Data\\") + "\\" + str_DataType + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + str_num + ".txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                FileInfo feInfo = new FileInfo(path);
                if (feInfo.CreationTime < DateTime.Today)
                {
                    ConfigXML.SetKeyValue(FileNum, "1");
                    str_num = ConfigXML.GetKeyString(FileNum, "1");//文件编号
                }
                long size = (feInfo.Length / 1024 / 1024);
                if (size >= long.Parse(ConfigXML.GetKeyString("FileSize", "16")))
                {
                    ConfigXML.SetKeyValue(FileNum, (int.Parse(ConfigXML.GetKeyString(FileNum, "1")) + 1).ToString());
                    str_num = ConfigXML.GetKeyString(FileNum, "1");//文件编号
                }
                path = ConfigXML.GetKeyString("FileRoute", "C:\\NSM_Data\\") + "\\" + str_DataType + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + str_num + ".txt";
                SaveText(path, context);
                ConfigXML.SetKeyValue("CurrTime", DateTime.Now.ToString("yyyy-MM-dd"));
            }
            catch { }
        }

        /// <summary>
        /// 将内容存储到Txt文档
        /// </summary>
        private static void SaveText(string path, string context)
        {
            try
            {
                byte[] info = new UTF8Encoding().GetBytes(context);
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                fs.Write(info, 0, info.Length);
                fs.Flush();
                fs.Close();
            }
            catch { }
        }

        private static void AddText(BufferedStream bs, string text)
        {
            byte[] info = new UTF8Encoding().GetBytes(text);
            bs.Write(info, 0, info.Length);
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        public static void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        #endregion 数据保存

        #region 获取随机数

        /// <summary>
        /// 获取随机数
        /// </summary>
        public static int GetRandom(int minNumber, int maxNumber)
        {
            Random _ran = new Random();
            int _num = _ran.Next(minNumber, maxNumber);
            return _num;
        }

        #endregion 获取随机数

        #region Excel数据导出

        /// <summary>
        /// Excel数据导出
        /// </summary>
        //public static int ExportExcels(DataGridView myDGV)
        //{
        //    string saveFileName = "";
        //    SaveFileDialog saveDialog = new SaveFileDialog();
        //    saveDialog.DefaultExt = "xls";
        //    saveDialog.Filter = "Excel文件|*.xls";
        //    saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd");
        //    saveDialog.ShowDialog();
        //    saveFileName = saveDialog.FileName;
        //    if (saveFileName.IndexOf(":") < 0) return -1;
        //    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        //    if (xlApp == null) return 0;
        //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
        //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
        //    //写入标题
        //    for (int i = 0; i < myDGV.ColumnCount; i++)
        //    {
        //        worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
        //    }
        //    //写入数值
        //    for (int r = 0; r < myDGV.Rows.Count; r++)
        //    {
        //        for (int i = 0; i < myDGV.ColumnCount; i++)
        //        {
        //            worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
        //        }
        //        System.Windows.Forms.Application.DoEvents();
        //    }
        //    worksheet.Columns.EntireColumn.AutoFit();
        //    if (saveFileName != "")
        //    {
        //        try
        //        {
        //            workbook.Saved = true;
        //            workbook.SaveCopyAs(saveFileName);
        //        }
        //        catch (Exception _ex) { Log.Error("Excel导出：" + _ex.ToString()); }
        //    }
        //    xlApp.Quit();
        //    GC.Collect();
        //    return 1;
        //}

        #endregion Excel数据导出

        #region 判断对象是否为空

        /// <summary>
        /// 判断对象是否为空，为空返回true
        /// </summary>
        public static bool IsNullOrEmpty<T>(T data)
        {
            //如果为null
            if (data == null)
            {
                return true;
            }

            //如果为""
            if (data.GetType() == typeof(String))
            {
                if (string.IsNullOrEmpty(data.ToString().Trim()))
                {
                    return true;
                }
            }

            //如果为DBNull
            if (data.GetType() == typeof(DBNull))
            {
                return true;
            }

            //不为空
            return false;
        }

        #endregion 判断对象是否为空

        #region 验证IP地址是否合法

        /// <summary>
        /// 验证IP地址是否合法
        /// </summary>
        public static bool IsIP(string ip)
        {
            //如果为空，认为验证合格
            if (IsNullOrEmpty(ip))
            {
                return false;
            }

            //清除要验证字符串中的空格
            ip = ip.Trim();

            //模式字符串
            string pattern = @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$";

            //验证
            return IsMatch(ip, pattern);
        }

        #endregion 验证IP地址是否合法

        #region 验证数据绝对值相等

        /// <summary>
        /// 验证数据绝对值相等
        /// </summary>
        public static bool CheckDataEquals(float a, float b)
        {
            bool flag = false;
            if (Math.Abs(a).Equals(Math.Abs(b)))
            {
                flag = true;
            }
            return flag;
        }

        #endregion 验证数据绝对值相等

        #region 判断DataGridView重复数据

        /// <summary>
        /// 判断重复数据
        /// </summary>
        public static int RepetitionData(DataGridView dgv, string str)
        {
            Dictionary<string, int> addDict = new Dictionary<string, int>();

            //记录要删除掉的索引值
            List<int> removeList = new List<int>();
            //循环datagrid
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //判断字典中存在了相同的值.就把当前的索引添加到待删除的记录中，这里判断的是Md5Code列
                if (addDict.ContainsKey(dgv.Rows[i].Cells[str].Value.ToString()))
                {
                    removeList.Add(i);
                }
                else
                {
                    //不存在就添加到字典中
                    addDict.Add(dgv.Rows[i].Cells[str].Value.ToString(), i);
                }
            }
            return removeList.Count;
        }

        public static int RepetitionData(DataGridView dgv, string strF, string strS)
        {
            Dictionary<string, string> addDict = new Dictionary<string, string>();

            //记录要删除掉的索引值
            List<int> removeList = new List<int>();
            //循环datagrid
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                //判断字典中存在了相同的值.就把当前的索引添加到待删除的记录中，这里判断的是Md5Code列
                if (addDict.ContainsKey(dgv.Rows[i].Cells[strF].Value.ToString()) && addDict.ContainsValue(dgv.Rows[i].Cells[strS].Value.ToString()))
                {
                    removeList.Add(i);
                }
                else
                {
                    //不存在就添加到字典中
                    addDict.Add(dgv.Rows[i].Cells[strF].Value.ToString(), dgv.Rows[i].Cells[strS].Value.ToString());
                }
            }
            return removeList.Count;
        }

        #endregion 判断DataGridView重复数据

        #region 验证输入字符串是否与模式字符串匹配

        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true
        /// </summary>
        public static bool IsMatch(string input, string pattern)
        {
            return IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 验证输入字符串是否与模式字符串匹配，匹配返回true
        /// </summary>
        public static bool IsMatch(string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }

        #endregion 验证输入字符串是否与模式字符串匹配

        #region 验证返回

        /// <summary>
        /// 验证返回连接方式
        /// </summary>
        public static string ReturnConnent(int flag)
        {
            if (flag == 0x00)
            {
                return "COM";
            }
            else
            {
                return "CAN";
            }
        }

        #endregion 验证返回

        #region 判断字符串是否是浮点数
        public static bool IsFloat(string str)
        {
            //如果为空，认为验证合格
            if (IsNullOrEmpty(str))
            {
                return false;
            }

            //清除要验证字符串中的空格
            str = str.Trim();

            //模式字符串
            string pattern = @"^(-?\d+)(\.\d+)?$";

            //验证
            return IsMatch(str, pattern);
        }
        #endregion 判断字符串是否是浮点数

        #region 程序唯一实例
        /// <summary>
        /// 该函数设置由不同线程产生的窗口的显示状态
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分</param>
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零</returns>
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary>
        ///  该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。
        ///  系统给创建前台窗口的线程分配的权限稍高于其他线程。 
        /// </summary>
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄</param>
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零</returns>
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);



        private const int SW_SHOWNOMAL = 1;
        private static void HandleRunningInstance(Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, SW_SHOWNOMAL);//显示
            //当到最前端
            SetForegroundWindow(instance.MainWindowHandle);
        }
        private static Process RuningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] Processes = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process in Processes)
            {
                if (process.Id != currentProcess.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == currentProcess.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }
            return null;
        }

        //确保唯一程序实例
        public static void EnsureUniqueInstance()
        {
            Process process = RuningInstance();

            if (process != null)
            {
                if (MessageBox.Show(process.ProcessName + " 已在运行中，将强制关闭程序并重新启动","警告",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    process.Kill();//关闭正在运行的进程

                    System.Threading.Thread.Sleep(2000);//等待进程结束
                }
                else
                {
                    HandleRunningInstance(process);//将正在运行的进程显示在前台
                    System.Environment.Exit(1);
                }

                return;
            }
        }
        #endregion 程序唯一实例

        public static void GetSerial(UIComboBox cmb, string com)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports.Length == 0) { cmb.Items.Clear(); return; }
            if (ports.Length < cmb.Items.Count)
            {
                cmb.Items.Clear();
                cmb.Items.AddRange(ports);
                if (cmb.Items.Contains(com))
                    cmb.SelectedIndex = cmb.Items.IndexOf(com);
                else
                    cmb.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < ports.Length; i++)
                {
                    if (!cmb.Items.Contains(ports[i]))
                    {
                        cmb.Items.Add(ports[i]);
                        if (cmb.Items.Contains(com))
                        {
                            cmb.SelectedIndex = cmb.Items.IndexOf(com);
                        }
                        if (i == 0)
                        {
                            cmb.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 控件在父控件中居中
        /// </summary>
        /// <param name="ctr">要设置的控件</param>
        /// <param name="isLR">左右居中</param>
        /// <param name="isUD">上下居中</param>
        /// <returns></returns>
        public static bool CenterCtr(Control ctr, bool isLR, bool isUD)
        {
            Control pCtr = ctr.Parent;
            int x = isLR ? ((pCtr.Width - ctr.Width) / 2) : ctr.Location.X;
            int y = isUD ? ((pCtr.Height - ctr.Height) / 2) : ctr.Location.Y;
            ctr.Location = new System.Drawing.Point(x, y);
            return true;
        }

        //根据不同平台加载不同dll路径
        public static bool LoadCANFDDLLPath(string folder)
        {
            try
            {
                //库文件路径
                string libPath = System.IO.Path.Combine(Environment.CurrentDirectory, folder);

                //根据软件运行模式设置库文件的路径
                //if (string.Compare("CX",SystemSetting.CANFactory,false) == 0)
                //{
                //    libPath = System.IO.Path.Combine(libPath, "CX");
                //}
                //else
                //{
                //    libPath = System.IO.Path.Combine(libPath, "ZLG");
                //}
                libPath = System.IO.Path.Combine(libPath, "CX2_11");
                //获取当前环境变量Path的值
                var path = Environment.GetEnvironmentVariable("Path");
                //添加库路径到环境变量中
                path += (";" + libPath + ";");
                //设置环境变量
                Environment.SetEnvironmentVariable("Path", path);

                // LogProc.Log.Debug("添加了环境变量" + libPath);

                return true;
            }
            catch (Exception ex)
            {
                LogProc.Log.Error(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 1. 判断字符串是否像文件夹路径（不含文件名）
        /// 2. 盘符是否存在
        /// 3. 文件夹是否存在 → 不存在则自动创建（含多级）
        /// </summary>
        /// <param name="path">待校验路径</param>
        /// <returns>合法且最终存在返回 true，否则 false</returns>
        public static bool EnsureFolderPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;

            /* ① 基本格式检查：必须是根目录或目录分隔符结尾，或不含非法字符 */
            bool likeFolder = path.EndsWith(Path.DirectorySeparatorChar.ToString()) ||
                  path.EndsWith(Path.AltDirectorySeparatorChar.ToString()) ||
                  !Path.HasExtension(path);   // 没有扩展名
            if (!likeFolder) return false;

            /* ② 盘符检查（仅 Windows 路径） */
            if (Path.IsPathRooted(path) && path.Length >= 3 && path[1] == ':')
            {
                string drive = path.Substring(0, 1).ToUpperInvariant();
                if (!DriveInfo.GetDrives().Any(d => d.Name.StartsWith(drive)))
                    return false;   // 盘符不存在
            }

            /* ③ 存在性检查 + 自动创建 */
            if (Directory.Exists(path)) return true;

            try
            {
                Directory.CreateDirectory(path);   // 一次性创建多级
                return true;
            }
            catch { return false; }
        }

        #region 读文件数据
        /// <summary>
        /// 读文件数据
        /// </summary>
        /// <param name="str_Path"></param>
        /// <returns></returns>
        public static byte[] ReadFileData(string str_Path)
        {
            try
            {
                FileStream fs = new FileStream(str_Path, FileMode.Open, FileAccess.Read);
                //固件数据
                byte[] str_Data = new byte[fs.Length];
                int str_Read = fs.Read(str_Data, 0, str_Data.Length);
                fs.Flush();
                fs.Close();
                return str_Data;
            }
            catch (Exception _ex)
            {
                Log.Error("ReadFileData Ex\r\n" + _ex.ToString());
                return null;
            }
        }
        #endregion 读文件数据

        #region 校验和
        /// <summary>
        /// 获取检验和
        /// </summary>
        /// <param name="byteCheck"></param>
        /// <param name="bufOffset">起始位</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public static byte GetCheckSum(byte[] buf, int bufOffset, int len)
        {
            byte check_sum = 0;
            for (int i = bufOffset; i < len + bufOffset; i++)
            {
                if (i == bufOffset)
                {
                    check_sum = buf[i];
                }
                else
                {
                    check_sum += buf[i];
                }
            }
            //返回校验和
            return check_sum;
        }
        #endregion 校验和

        #region CRC16检验
        public static byte[] CRC16_Modbus(List<byte> buf)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            for (int i = 0; i < buf.Count; i++)
            {
                crc ^= buf[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            byte[] result = BitConverter.GetBytes(crc);
            return result;
        }
        #endregion CRC16检验

        #region 无符号整数转有符号整数
        public static int BitNumToInt(int value, int bitNum)
        {
            int maxValue = (int)Math.Pow(2, bitNum);
            value = value & (maxValue - 1);
            return value > (maxValue / 2 - 1) ? value - (maxValue - 1) - 1 : value;
        }
        public static int Bit21ToInt(int value)
        {
            value = value & 0x1fffff;
            return value > 1048575 ? value - 0x1FFFFF - 1 : value;
        }
        #endregion 无符号整数转有符号整数

        #region 根据ID颜色配比
        private static readonly Dictionary<uint, Tuple<byte, byte, byte>> ColorCache =
        new Dictionary<uint, Tuple<byte, byte, byte>>();
        /// <summary>
        /// 根据ID生成唯一颜色（高对比度）
        /// </summary>
        public static void GetColorById(uint id, out byte r, out byte g, out byte b)
        {
            // 缓存避免重复计算
            if (ColorCache.TryGetValue(id, out var cached))
            {
                r = cached.Item1;
                g = cached.Item2;
                b = cached.Item3;
                return;
            }

            // 使用黄金角分布
            double phi = (id * 0.618033988749895) % 1.0;

            // 对低ID（0-15）使用预设高对比色，确保小数量时绝对区分
            if (id < 16)
            {
                switch (id)
                {
                    case 0: r = 255; g = 0; b = 0; break;      // 红
                    case 1: r = 0; g = 150; b = 255; break;    // 蓝
                    case 2: r = 0; g = 200; b = 0; break;      // 绿
                    case 3: r = 255; g = 200; b = 0; break;    // 黄
                    case 4: r = 128; g = 0; b = 255; break;    // 紫
                    case 5: r = 255; g = 100; b = 0; break;    // 橙
                    case 6: r = 0; g = 255; b = 255; break;    // 青
                    case 7: r = 255; g = 0; b = 200; break;    // 玫红
                    case 8: r = 100; g = 255; b = 100; break;  // 浅绿
                    case 9: r = 0; g = 80; b = 160; break;     // 深蓝
                    case 10: r = 255; g = 150; b = 150; break; // 粉
                    case 11: r = 150; g = 75; b = 0; break;    // 棕
                    case 12: r = 128; g = 128; b = 128; break; // 灰
                    case 13: r = 0; g = 128; b = 128; break;   // 深青
                    case 14: r = 255; g = 255; b = 150; break; // 浅黄
                    default: r = 200; g = 200; b = 255; break; // 浅紫
                }
            }
            else
            {
                // HSV转RGB，确保鲜艳度
                HsvToRgb(phi, 0.85, 0.95, out r, out g, out b);
            }

            ColorCache[id] = Tuple.Create(r, g, b);
        }

        private static void HsvToRgb(double h, double s, double v, out byte r, out byte g, out byte b)
        {
            double r_d, g_d, b_d;

            int i = (int)(h * 6);
            double f = h * 6 - i;
            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            switch (i % 6)
            {
                case 0: r_d = v; g_d = t; b_d = p; break;
                case 1: r_d = q; g_d = v; b_d = p; break;
                case 2: r_d = p; g_d = v; b_d = t; break;
                case 3: r_d = p; g_d = q; b_d = v; break;
                case 4: r_d = t; g_d = p; b_d = v; break;
                default: r_d = v; g_d = p; b_d = q; break;
            }

            r = (byte)(r_d * 255);
            g = (byte)(g_d * 255);
            b = (byte)(b_d * 255);
        }

        #endregion 根据ID颜色配比

        #region 切换主题
        public static void SetTheme(UIBaseForm form,UIStyle style)
        {
            form.Style = UIStyle.Inherited;
            form.SetInheritedStyle(style);
            UIStyleHelper.SetChildUIStyle(form, style);
            UIStyleHelper.SetChildCustomStyle(form,style);
            SetGlobalStyle(form, style);
        }
        /// <summary>
        /// 递归设置所有 SunnyUI 控件的 StyleCustomMode 为 false
        /// </summary>
        private static void SetGlobalStyle(Control parent, UIStyle style)
        {
            if (parent.Controls == null || parent.Controls.Count <= 0)
                return;
            foreach (Control ctrl in parent.Controls)
            {
                //ctrl.Style = UIStyle.Inherited;
                //ctrl.SetInheritedStyle(style);
                UIStyleHelper.SetChildUIStyle(ctrl, style);
                //parent.SetChildCustomStyle(style);
                UIStyleHelper.SetChildCustomStyle(ctrl, style);
                // 递归处理子容器
                if (ctrl.HasChildren)
                {
                    SetGlobalStyle(ctrl,style);
                }
            }
        }
        #endregion 切换主题
    }
}
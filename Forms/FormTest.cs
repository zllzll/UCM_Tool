using UCM_Tools.CAN_Conn;
using UCM_Tools.Config;
using UCM_Tools.Radar;
using UCM_Tools.Radar.Protocols;
using UCM_Tools.Tools;
using CommonLib;
using LogProc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UCM_Tools.Forms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }
        string path = string.Empty;
        private CancellationTokenSource _cancellationTokenSource;
        bool nextLine = false;
        private void button1_Click(object sender, EventArgs e)
        {
            open_File.Filter = "CSV File|*.CSV;*.csv";
            if (open_File.ShowDialog().Equals(DialogResult.OK))
            {
                path = System.IO.Path.GetFullPath(open_File.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pathNoFile = Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(path) || !PubClass.EnsureFolderPath(pathNoFile) || !File.Exists(path))
            {
                MessageBox.Show($"【{path}】文件不存在");
                return;
            }
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            // 线程 1：读取文件并填充队列
            new Thread(() =>
            {
                try
                {
                    if (token.IsCancellationRequested) return;
                    var file = File.ReadAllLines(path);

                    if (token.IsCancellationRequested) return;

                    int lineNum = 1;//行数
                    foreach (var line in file)
                    {
                        if (lineNum == 1)
                        {
                            lineNum++;
                            nextLine = true;
                            continue;
                        }
                        while (!nextLine)
                        {
                            Thread.Sleep(1);
                        }
                        nextLine = false;
                        if (token.IsCancellationRequested) return;

                        string[] strings = line.Split(',');
                        if (strings.Length == 11 || string.IsNullOrEmpty(strings[5]) || string.IsNullOrEmpty(strings[10]))
                        {
                            string[] hexValues = strings[10].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            byte[] byteArray = new byte[hexValues.Length];
                            try
                            {
                                uint id = Convert.ToUInt32(strings[5], 16);
                                for (int i = 0; i < hexValues.Length; i++)
                                {
                                    byteArray[i] = Convert.ToByte(hexValues[i], 16);
                                }
                                if (byteArray.Length % 8 != 0)
                                {
                                    MessageBox.Show($"文件中第{lineNum}行第11列字节数据不是8的倍数");
                                }
                                handleData(lineNum, id, byteArray);
                            }
                            catch
                            {
                                MessageBox.Show($"文件中第{lineNum}行第6/11列数据异常");
                            }

                        }
                        else
                        {
                            MessageBox.Show($"文件中第{lineNum}行列数不是11列或者第11列为空");
                        }
                        lineNum++;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    nextLine = false;
                }
            }).Start();
        }

        public void handleData(int line,uint can_id, byte[] data)
        {
            try
            {
                StringBuilder msg = new StringBuilder($"第{line}行  CANID:0x{can_id:X3} 数据长度:{data.Length}\r\n数据:{BitConverter.ToString(data).Replace('-', ' ')}\r\n解析后：\r\n");
                switch (can_id & 0xF0F)
                {
                    case 0x60A:
                    case 0x600:
                        int tarSum = data[0] * 256 + data[1];
                        int cycleSum = data[2] *256+ data[3];
                        byte subFrameSum = data[5];
                        msg.Append($"目标数：{tarSum} 循环计数：{cycleSum} 子帧数：{subFrameSum}\r\n");
                        break;
                    case 0x60B:
                    case 0x701:
                        int count = data.Length / 8;
                        for (int i = 0; i < count; i++)
                        {
                            int startIndex = i * 8;
                            TargetInfo.RadarTargetInfoStruct target = new TargetInfo.RadarTargetInfoStruct();
                            //X坐标
                            decimal obj_DistLat = ((0x07 & data[startIndex + 2]) << 8) + data[startIndex + 3];
                            obj_DistLat = obj_DistLat * 0.05M - 50;
                            //obj_DistLat = obj_DistLat - 51.15;
                            //Y坐标
                            decimal obj_DistLong = (data[startIndex + 1] << 5) + ((data[startIndex + 2] >> 3) & 0x1f);
                            obj_DistLong = (obj_DistLong * 0.05M) - 100;
                            //Z坐标
                            decimal obj_Z = ((data[startIndex + 5] & 0x3f) << 3) + ((data[startIndex + 6] >> 5) & 0x07);
                            obj_Z = obj_Z * 0.25M - 64;
                            //速度Y
                            decimal obj_Vrelong = (data[startIndex + 4] << 2) + ((data[startIndex + 5] >> 6) & 0x03);
                            obj_Vrelong = obj_Vrelong * 0.05M - 16;
                            //目标类型
                            double obj_DynProp = (data[startIndex + 6] & 0x07);
                            //目标类型
                            double obj_Class = (data[startIndex + 6] & 0x18) >> 3;

                            uint tarId = data[startIndex + 0];
                            double rcs = data[startIndex + 7];//canfd_frame.data[startIndex + 6] * 0.5 - 64;
                            target.ID = tarId;
                            target.Num = tarId;
                            target.XAxis = (double)obj_DistLat;
                            target.YAxis = (double)obj_DistLong;
                            target.ZAxis = (double)obj_Z;
                            target.Range = Math.Sqrt(target.XAxis * target.XAxis + target.YAxis * target.YAxis);
                            target.PAngle = (Math.Atan2(target.XAxis, target.YAxis) * 180 / Math.PI);
                            target.TAngle = (Math.Atan2(target.ZAxis, target.YAxis) * 180 / Math.PI);
                            target.Class = (int)obj_Class;
                            target.Vy = (double)obj_Vrelong;
                            target.Velocity = target.Vy;
                            //Console.WriteLine($"{target.Velocity}\r\n");
                            target.RCS = rcs;

                            target.Type = (int)obj_DynProp;
                            target.RadarType = "SR75";
                            msg.Append($"X：{target.XAxis.ToString("f6")} Y：{target.YAxis.ToString("f6")} Z：{target.ZAxis.ToString("f6")} V：{target.Velocity.ToString("f6")} R：{target.Range.ToString("f6")} RCS：{target.RCS.ToString("f6")}\r\n");
                        }
                        break;
                    case 0x700:
                        msg.Append($"版本号：V{data[0]}.{data[1]}.{data[2]}");

                        break;
                    case 0x201:
                    case 0x501:
                    case 0x303: //硬件ID
                    case 0x305: //写入密钥回复
                        msg.Append($"未解析");
                        break;
                }
                this.Invoke(new Action(() => { richTextBox1.Text = msg.ToString(); }));
            }
            catch (Exception _ex)
            {
                Log.Error("处理CANFD接收数据异常\r\n" + _ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nextLine = true;
        }
    }
}

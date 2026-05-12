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
using UCM_Tools.Tools;

namespace UCM_Tools.Forms
{
    public partial class TrackNplotForm : UIForm
    {
        /// <summary>
        /// object图表
        /// </summary>
        NplotCls myplot_Object = new NplotCls();
        public TrackNplotForm()
        {
            InitializeComponent();
            // 设置窗体双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // 设置面板双缓冲
            SetDoubleBuffered(pan_Main);
            SetDoubleBuffered(plot_Object);
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
        private void TrackNplotForm_Load(object sender, EventArgs e)
        {
            //初始化主题
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);

            //LoadLanguage();
            this.Text = MultiLanguage.LanguageText("MainForm", "XY2DView");
            InitGraph();
            MainForm.trackDataReceived += new MainForm.TrackDataDelegate(ReceiveData);
        }

        public void InitGraph()
        {
            myplot_Object.Init(plot_Object, SystemSetting.XMin, SystemSetting.XMax, SystemSetting.YMin, SystemSetting.YMax, "X", "Y");
            // 确保NPlot控件的双缓冲 - 需要访问其内部Surface控件
            if (plot_Object.Controls.Count > 0)
            {
                Control surface = plot_Object.Controls[0]; // NPlot通常有一个Surface子控件
                surface.GetType().GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)
                    ?.SetValue(surface, true);
            }
        }

        #region 调整大小时保持控制区宽度
        private int _fixedPanelWidthCollapsed = 10; // 收缩宽度
        private int _fixedPanelWidthExtended = 295; // 展开宽度

        #endregion 调整大小时保持控制区宽度

        #region 自定义拖动实现窗体大小变化
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int HT_LEFT = 0xA;
        private const int HT_RIGHT = 0xB;
        private const int HT_TOP = 0xC;
        private const int HT_TOPLEFT = 0xD;
        private const int HT_TOPRIGHT = 0xE;
        private const int HT_BOTTOM = 0xF;
        private const int HT_BOTTOMLEFT = 0x10;
        private const int HT_BOTTOMRIGHT = 0x11;

        // 边框检测宽度
        private const int BorderWidth = 4;

        protected override void WndProc(ref Message m)
        {
            // 在调整大小期间暂停绘制
            if (m.Msg == 0x0112 && (m.WParam.ToInt32() & 0xFFF0) == 0xF000) // WM_SYSCOMMAND + SC_SIZE
            {
                plot_Object.SuspendLayout();
                base.WndProc(ref m);
                plot_Object.ResumeLayout(true);
                return;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                // 获取鼠标位置
                Point cursor = this.PointToClient(new Point((int)m.LParam));

                // 判断鼠标位置并返回对应的 hit-test 值
                if (cursor.X <= BorderWidth && cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOPLEFT;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth && cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOPRIGHT;
                else if (cursor.X <= BorderWidth && cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOMLEFT;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth && cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOMRIGHT;
                else if (cursor.X <= BorderWidth)
                    m.Result = (IntPtr)HT_LEFT;
                else if (cursor.Y <= BorderWidth)
                    m.Result = (IntPtr)HT_TOP;
                else if (cursor.X >= this.ClientSize.Width - BorderWidth)
                    m.Result = (IntPtr)HT_RIGHT;
                else if (cursor.Y >= this.ClientSize.Height - BorderWidth)
                    m.Result = (IntPtr)HT_BOTTOM;
            }
        }
        #endregion 自定义拖动实现窗体大小变化


        private void ReceiveData(List<TargetInfo.RadarTargetInfoStruct> targetList)
        {
            try
            {
                List<double> _X = new List<double>();                 //当前显示横轴
                List<double> _Y = new List<double>();                //当前显示纵轴
                List<string> _PlotText = new List<string>();        //当前显示文本

                if (targetList != null && targetList.Count >= 0)
                {
                    foreach (var target in targetList)
                    {
                       StringBuilder sb = new StringBuilder();
                        if (SystemSetting.DisplayTrackText)
                        {
                            sb.Append($"{(SystemSetting.Tar_ID ? $"ID={target.ID} " : "")}{(SystemSetting.Tar_X ? $"X={target.XAxis.ToString("f2")} " : "")}{(SystemSetting.Tar_Y ? $"Y={target.YAxis.ToString("f2")} " : "")}");
                            sb.Append($"{(SystemSetting.Tar_Z ? $"Z={target.ZAxis.ToString("f2")} " : "")}{(SystemSetting.Tar_V ? $"V={target.Velocity.ToString("f2")} " : "")}{(SystemSetting.Tar_A ? $"A={target.PAngle.ToString("f2")} " : "")}");
                            sb.Append($"{(SystemSetting.Tar_C ? $"C={target.Confidence.ToString()} " : "")}");
                        }
                        _X.Add(target.XAxis);
                        _Y.Add(target.YAxis);
                        _PlotText.Add(sb.ToString().Trim());
                    }
                }
                //将目标赋值到图标上
                myplot_Object.SetCurrentValueToNplot(_X, _Y, _PlotText);
                this.BeginInvoke((EventHandler)delegate
                {
                    plot_Object.Invalidate();
                });
            }
            catch (Exception ex)
            {
                Log.Error($"SetValueToGraph Ex\r\n{ex.ToString()}");
            }
        }

        private void TrackNplotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormDispose();
        }

        public void FormDispose()
        {
            MainForm.trackDataReceived -= new MainForm.TrackDataDelegate(ReceiveData);
        }
    }
}

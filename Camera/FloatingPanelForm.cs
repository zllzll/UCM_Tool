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

namespace UCM_Tools.Camera
{
    public partial class FloatingPanelForm : UIForm
    {
        private bool _isPanelExpanded = true;
        private Point _lastMousePosition;
        private bool _isDragging = false;

        public FloatingPanelForm()
        {
            InitializeComponent();

            SetupFlowLayoutPanel();
            SetupToggleButton();
        }

        private void SetupFlowLayoutPanel()
        {
            // 基础配置
            uiFlowLayoutPanel1.Dock = DockStyle.Left;
            uiFlowLayoutPanel1.Width = 280;
            uiFlowLayoutPanel1.AutoScroll = true;
            uiFlowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // 垂直排列
            uiFlowLayoutPanel1.WrapContents = false;

            // 添加示例控件
            for (int i = 0; i < 20; i++)
            {
                var button = new UIButton
                {
                    Text = $"Item {i + 1}",
                    Height = 40,
                    Dock = DockStyle.Top,
                    //Symbol = 61818 + i
                };
                uiFlowLayoutPanel1.Controls.Add(button);
            }

            // 启用拖动
            uiFlowLayoutPanel1.MouseDown += FlowPanel_MouseDown;
            uiFlowLayoutPanel1.MouseMove += FlowPanel_MouseMove;
            uiFlowLayoutPanel1.MouseUp += FlowPanel_MouseUp;
        }

        private void SetupToggleButton()
        {
            uiHeaderButton1.Text = "导航菜单";
            uiHeaderButton1.Symbol = 61544;
            uiHeaderButton1.Click += ToggleButton_Click;
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            _isPanelExpanded = !_isPanelExpanded;

            uiHeaderButton1.Symbol = _isPanelExpanded ? 61544 : 61523;

            // 使用动画效果
            var timer = new Timer { Interval = 10 };
            int targetWidth = _isPanelExpanded ? 280 : 0;
            int step = (targetWidth - uiFlowLayoutPanel1.Width) / 20;

            timer.Tick += (s, args) =>
            {
                uiFlowLayoutPanel1.Width += step;

                if (Math.Abs(uiFlowLayoutPanel1.Width - targetWidth) < Math.Abs(step))
                {
                    uiFlowLayoutPanel1.Width = targetWidth;
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        private void FlowPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && uiFlowLayoutPanel1.VerticalScroll.Visible)
            {
                _isDragging = true;
                _lastMousePosition = e.Location;
                uiFlowLayoutPanel1.Cursor = Cursors.Hand;
            }
        }

        private void FlowPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int deltaY = e.Location.Y - _lastMousePosition.Y;
                int newValue = uiFlowLayoutPanel1.VerticalScroll.Value - deltaY;

                newValue = Math.Max(0, Math.Min(newValue, uiFlowLayoutPanel1.VerticalScroll.Maximum));
                uiFlowLayoutPanel1.VerticalScroll.Value = newValue;

                _lastMousePosition = e.Location;
            }
        }

        private void FlowPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            uiFlowLayoutPanel1.Cursor = Cursors.Default;
        }
    }
}

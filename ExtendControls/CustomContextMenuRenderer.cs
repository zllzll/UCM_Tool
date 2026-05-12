using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCM_Tools.ExtendControls
{
     public class CustomContextMenuRenderer:ToolStripProfessionalRenderer
    {
        private readonly Color _borderColor;
        private readonly Color _selectionColor;
        private readonly Color _selectionBorderColor;
        private readonly Color _selectionTextColor;
        private readonly Color _normalTextColor = Color.FromArgb(255, 100, 100);
        private readonly Color _backColor = Color.FromArgb(10, 0, 0);
        public CustomContextMenuRenderer(Color borderColor, Color selectionColor, Color selectionBorderColor, Color selectionTextColor)
        {
            _borderColor = borderColor;
            _selectionColor = selectionColor;
            _selectionBorderColor = selectionBorderColor;
            _selectionTextColor = selectionTextColor;
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            using (var pen = new Pen(_borderColor))
            {
                var rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        // 渲染菜单项背景（选中/悬停效果）
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            // 检查是否选中或鼠标悬停
            if (e.Item.Selected || e.Item.Pressed)
            {
                // 获取菜单项的绘制区域
                var rect = new Rectangle(2, 0, e.Item.Width - 4, e.Item.Height);

                // 填充选中背景色
                using (var brush = new SolidBrush(_selectionColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                // 可选：绘制选中边框
                using (var pen = new Pen(_selectionBorderColor))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
            else
            {
                // 未选中时调用基类默认渲染
                base.OnRenderMenuItemBackground(e);
                // 获取菜单项的绘制区域
                var rect = new Rectangle(2, 0, e.Item.Width - 4, e.Item.Height);

                // 填充背景色
                using (var brush = new SolidBrush(_backColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }
        // 渲染菜单项文字（关键方法）
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // 根据是否选中设置文字颜色
            e.TextColor = e.Item.Selected ? _selectionTextColor : _normalTextColor;

            // 调用基类方法渲染文字
            base.OnRenderItemText(e);
        }
    }
}

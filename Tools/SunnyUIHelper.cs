using CommonLib;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.ExtendControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UCM_Tools.Tools
{
    public static class SunnyUIHelper
    {
        public static UIStyle DefaultThreme = UIStyle.Blue; 
        public static void SetTheme(UIForm form, string styleText)
        {
            try
            {
                if (string.Compare(styleText, "Default", false) == 0)
                {
                    SunnyUIHelper.SwitchTDefaultTheme(form);
                    DefaultThreme = UIStyle.Custom;
                }
                else
                {
                    UIStyle style = EnumEx.ToEnum<UIStyle>(styleText, false);
                    SunnyUIHelper.SwitchToBuiltinTheme(form, style);
                    DefaultThreme = style;
                }
                SystemSetting.ThemeColor = styleText;
                
            }
            catch (Exception ex)
            {
                LogHelper.Error($"MainForm SetTheme() Ex\r\n{ex.ToString()} ");
            }
        }

        // 调用此方法切换到指定内置主题（如 UIStyle.Blue, UIStyle.Orange 等）
        public static void SwitchToBuiltinTheme(UIForm form,UIStyle theme)
        {
            if (theme == UIStyle.Custom) return;

            // 递归清除所有控件的自定义颜色并应用主题
            ApplyThemeToControls(form.Controls, theme);
            form.BackColor = Color.Empty; // 清除窗体背景色
            form.ControlBoxFillHoverColor = Color.Empty;
            form.ControlBoxCloseFillHoverColor = Color.Empty;
            form.ControlBoxForeColor = Color.Empty;
            form.ForeColor = Color.Empty;
            form.RectColor = Color.Empty;
            form.TitleColor = Color.Empty;
            form.TitleForeColor = Color.Empty;
            if (form.ExtendMenu != null)
            {
                form.ExtendMenu.BackColor = Color.Empty;
                form.ExtendMenu.Renderer = null;
                if (form.ExtendMenu.Items != null && form.ExtendMenu.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem item in form.ExtendMenu.Items)
                    {
                        item.BackColor = Color.Empty;
                        item.ForeColor = Color.Empty;
                        ApplyToolStripMenuItem(item, Color.Empty, Color.Empty);
                    }
                }
                form.ExtendMenu.StyleCustomMode = false;
                form.ExtendMenu.Style = theme;
            }
                
            form.StyleCustomMode = false;
            // 设置窗体主题
            form.Style = theme;
            form.Invalidate();
        }
        private static void ApplyToolStripMenuItem(ToolStripMenuItem itemTemp,Color backColor,Color foreColor)
        {
            if (itemTemp == null || itemTemp.DropDownItems==null || itemTemp.DropDownItems.Count <= 0) return;
            itemTemp.DropDown.Renderer = backColor == Color.Empty ? null : new CustomContextMenuRenderer(Color.FromArgb(150, 0, 0), Color.FromArgb(40, 0, 0), Color.FromArgb(150, 0, 0), Color.FromArgb(255, 153, 153));
            itemTemp.DropDown.BackColor = backColor == Color.Empty ? Color.Empty : Color.FromArgb(10, 10, 10);
            foreach (ToolStripMenuItem item in itemTemp.DropDownItems)
            {
                item.BackColor = backColor;
                item.ForeColor = foreColor;
                item.Image = null;
                item.ImageTransparentColor = backColor;
                ApplyToolStripMenuItem(item,backColor,foreColor);
            }
        }
        private static void ApplyThemeToControls(Control.ControlCollection controls, UIStyle theme)
        {
            foreach (Control ctrl in controls)
            {
                // 根据控件类型清除显式颜色，让主题颜色生效
                switch (ctrl)
                {
                    case UIPanel panel:
                        panel.BackColor = Color.Empty;
                        panel.FillColor = Color.Empty;
                        panel.FillColor2 = Color.Empty;
                        panel.RectColor = Color.Empty;
                        panel.FillDisableColor = Color.Empty;
                        panel.RectDisableColor = Color.Empty;
                        panel.ForeColor = Color.Empty;
                        panel.ForeDisableColor = Color.Empty;
                        panel.StyleCustomMode = false;
                        panel.Style = theme;
                        break;

                    case UIButton btn:
                        btn.BackColor = Color.Empty;
                        btn.FillColor = Color.Empty;
                        btn.FillColor2 = Color.Empty;
                        btn.RectColor = Color.Empty;
                        btn.FillHoverColor = Color.Empty;
                        btn.FillPressColor = Color.Empty;
                        btn.FillSelectedColor = Color.Empty;
                        btn.FillDisableColor = Color.Empty;
                        btn.RectHoverColor = Color.Empty;
                        btn.RectPressColor = Color.Empty;
                        btn.RectSelectedColor = Color.Empty;
                        btn.RectDisableColor = Color.Empty;
                        btn.ForeColor = Color.Empty;
                        btn.ForeHoverColor = Color.Empty;
                        btn.ForePressColor = Color.Empty;
                        btn.ForeSelectedColor = Color.Empty;
                        btn.ForeDisableColor = Color.Empty;
                        btn.StyleCustomMode = false;
                        btn.Style = theme;
                        break;

                    case UILabel lbl:
                        lbl.ForeColor = Color.Empty;
                        lbl.BackColor = Color.Empty;
                        lbl.StyleCustomMode = false;
                        lbl.Style = theme;
                        break;

                    case UIContextMenuStrip menu:
                        menu.BackColor = Color.Empty;
                        menu.ForeColor = Color.Empty;
                        menu.StyleCustomMode = false;
                        menu.Style = theme;
                        break;
                    case UIProcessBar bar:
                        bar.BackColor = Color.Empty;
                        bar.ForeColor = Color.Empty;
                        bar.StyleCustomMode = false;
                        bar.Style = theme;
                        break;
                    case UISplitContainer splitContainer:
                        splitContainer.ArrowColor = Color.Empty;
                        splitContainer.ForeColor = Color.Empty;
                        splitContainer.BackColor = Color.Empty;
                        splitContainer.BarColor = Color.Empty;
                        splitContainer.HandleColor = Color.Empty;
                        splitContainer.HandleHoverColor = Color.Empty;
                        splitContainer.StyleCustomMode = false;
                        splitContainer.Style = theme;
                        break;
                    case UIRadioButton rb:
                        rb.BackColor = Color.Empty;
                        rb.ForeColor = Color.Empty;
                        rb.RadioButtonColor = Color.Empty;
                        rb.StyleCustomMode = false;
                        rb.Style = theme;
                        break;
                    case UICheckBox cb:
                        cb.BackColor = Color.Empty;
                        cb.ForeColor = Color.Empty;
                        cb.CheckBoxColor = Color.Empty;
                        cb.StyleCustomMode = false;
                        cb.Style = theme;
                        break;
                }

                // 递归处理子控件（关键！因为控件嵌套在UIPanel中）
                if (ctrl.HasChildren)
                {
                    ApplyThemeToControls(ctrl.Controls, theme);
                }
            }
        }

        // 调用此方法切换到指定内置主题（如 UIStyle.Blue, UIStyle.Orange 等）
        public static void SwitchTDefaultTheme(UIForm form)
        {
            // 递归清除所有控件的自定义颜色并应用主题
            ApplyDefaultThemeToControls(form.Controls);
            form.BackColor = Color.FromArgb(20,0,0); // 设置窗体背景色
            form.ControlBoxFillHoverColor = Color.FromArgb(60, 0, 0);
            form.ControlBoxCloseFillHoverColor = Color.FromArgb(60, 0, 0);
            form.ControlBoxForeColor = Color.FromArgb(255, 153, 153);
            form.ForeColor = Color.FromArgb(255, 100, 100);
            form.RectColor = Color.FromArgb(204, 0, 0);
            form.TitleColor = Color.FromArgb(30, 0, 0);
            form.TitleForeColor = Color.FromArgb(255, 100, 100);
            if (form.ExtendMenu != null)
            {
                form.ExtendMenu.BackColor = Color.FromArgb(10, 10, 10);
                form.ExtendMenu.Renderer = new CustomContextMenuRenderer(Color.FromArgb(150, 0, 0), Color.FromArgb(40, 0, 0), Color.FromArgb(150, 0, 0), Color.FromArgb(255, 153, 153));
                if (form.ExtendMenu.Items != null && form.ExtendMenu.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem item in form.ExtendMenu.Items)
                    {
                        item.BackColor = Color.FromArgb(10, 10, 10);
                        item.ForeColor = Color.FromArgb(255, 100, 100);
                        ApplyToolStripMenuItem(item, Color.FromArgb(10, 10, 10), Color.FromArgb(255, 100, 100));
                    }
                }
                form.ExtendMenu.StyleCustomMode = true;
                form.ExtendMenu.Style = UIStyle.Custom;
            }
            form.StyleCustomMode = true;
            // 设置窗体主题
            form.Style = UIStyle.Custom;
            form.Invalidate();
        }

        private static void ApplyDefaultThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // 根据控件类型清除显式颜色，让主题颜色生效
                switch (ctrl)
                {
                    case UIPanel panel:
                        panel.BackColor = Color.FromArgb(20, 0, 0);
                        panel.FillColor = Color.FromArgb(20, 0, 0);
                        panel.FillColor2 = Color.FromArgb(20, 0, 0);
                        panel.RectColor = Color.FromArgb(150, 0, 0);
                        panel.FillDisableColor = Color.FromArgb(100, 0, 0);
                        panel.RectDisableColor = Color.FromArgb(80, 0, 0);
                        panel.ForeColor = Color.FromArgb(255, 100, 100);
                        panel.ForeDisableColor = Color.FromArgb(128, 64, 64);
                        panel.StyleCustomMode = true;
                        panel.Style = UIStyle.Custom;
                        break;

                    case UIButton btn:
                        btn.BackColor = Color.FromArgb(20, 0, 0);
                        btn.FillColor = Color.FromArgb(20, 0, 0);
                        btn.FillColor2 = Color.FromArgb(20, 0, 0);
                        btn.RectColor = Color.FromArgb(150, 0, 0);
                        btn.FillHoverColor = Color.FromArgb(60, 0, 0);
                        btn.FillPressColor = Color.FromArgb(80, 0, 0);
                        btn.FillSelectedColor = Color.FromArgb(100,0,0);
                        btn.FillDisableColor = Color.FromArgb(100, 0, 0);
                        btn.RectHoverColor = Color.FromArgb(200, 0, 0);
                        btn.RectPressColor = Color.Red;
                        btn.RectSelectedColor = Color.Red;
                        btn.RectDisableColor = Color.FromArgb(80, 0, 0);
                        btn.ForeColor = Color.FromArgb(255, 100, 100);
                        btn.ForeHoverColor = Color.FromArgb(255, 153, 153);
                        btn.ForePressColor = Color.Red;
                        btn.ForeSelectedColor = Color.Red;
                        btn.ForeDisableColor = Color.FromArgb(128, 64, 64);
                        btn.StyleCustomMode = true;
                        btn.Style = UIStyle.Custom;
                        break;

                    case UILabel lbl:
                        lbl.ForeColor = Color.FromArgb(255, 102, 102);
                        lbl.BackColor = Color.FromArgb(20, 0, 0);
                        lbl.StyleCustomMode = true;
                        lbl.Style = UIStyle.Custom;
                        break;

                    case UIContextMenuStrip menu:
                        menu.BackColor = Color.FromArgb(10, 10, 10);
                        menu.ForeColor = Color.FromArgb(255, 100,100);
                        menu.StyleCustomMode = true;
                        menu.Style = UIStyle.Custom;
                        break;
                    case UIProcessBar bar:
                        bar.BackColor = Color.FromArgb(15, 0, 0);
                        bar.FillColor = Color.FromArgb(15, 0, 0);
                        bar.ForeColor = Color.FromArgb(255, 100, 100);
                        bar.RectColor = Color.FromArgb(150, 0, 0);
                        bar.StyleCustomMode = true;
                        bar.Style = UIStyle.Custom;
                        break;
                    case UISplitContainer splitContainer:
                        splitContainer.ArrowColor = Color.FromArgb(255, 100, 100);
                        splitContainer.ForeColor = Color.FromArgb(255, 100, 100);
                        splitContainer.BackColor = Color.FromArgb(20, 0, 0);
                        splitContainer.BarColor = Color.FromArgb(20, 0, 0);
                        splitContainer.HandleColor = Color.FromArgb(20, 0, 0);
                        splitContainer.HandleHoverColor = Color.FromArgb(20, 0, 0);
                        splitContainer.StyleCustomMode = true;
                        splitContainer.Style = UIStyle.Custom;
                        break;
                    case UIRadioButton rb:
                        rb.BackColor = Color.FromArgb(20, 0, 0);
                        rb.ForeColor = Color.FromArgb(255, 153, 153);
                        rb.RadioButtonColor = Color.Red;
                        rb.StyleCustomMode = true;
                        rb.Style = UIStyle.Custom;
                        break;
                    case UICheckBox cb:
                        cb.BackColor = Color.FromArgb(20, 0, 0);
                        cb.ForeColor = Color.FromArgb(255, 153, 153);
                        cb.CheckBoxColor = Color.Red;
                        cb.StyleCustomMode = true;
                        cb.Style = UIStyle.Custom;
                        break;
                }

                // 递归处理子控件（关键！因为控件嵌套在UIPanel中）
                if (ctrl.HasChildren)
                {
                    ApplyDefaultThemeToControls(ctrl.Controls);
                }
            }
        }
    }
}

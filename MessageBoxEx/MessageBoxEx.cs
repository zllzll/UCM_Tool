using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCM_Tools.MessageBoxEx
{
    public static class UIMessageBoxEx
    {
        public static void Show(string message, bool showMask = false, int delay = 0)
        {
            Show(message, UIStyles.CurrentResources.InfoTitle, UIStyle.Blue, UIMessageBoxButtons.OK, showMask, delay);
        }

        public static void ShowInfo(string message, bool showMask = false, int delay = 0)
        {
            Show(message, UIStyles.CurrentResources.InfoTitle, UIStyles.Style, UIMessageBoxButtons.OK, showMask, delay);
        }

        public static void ShowSuccess(string message, bool showMask = false, int delay = 0)
        {
            Show(message, UIStyles.CurrentResources.SuccessTitle, UIStyle.Green, UIMessageBoxButtons.OK, showMask, delay);
        }

        public static void ShowWarning(string message, bool showMask = false, int delay = 0)
        {
            Show(message, UIStyles.CurrentResources.WarningTitle, UIStyle.Orange, UIMessageBoxButtons.OK, showMask, delay);
        }

        public static void ShowError(string message, bool showMask = false, int delay = 0)
        {
            Show(message, UIStyles.CurrentResources.ErrorTitle, UIStyle.Red, UIMessageBoxButtons.OK, showMask, delay);
        }

        public static bool ShowAsk(string message, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Ok)
        {
            return ShowMessageDialog(message, UIStyles.CurrentResources.AskTitle, showCancel: true, UIStyle.Blue, showMask, defaultButton);
        }

        public static bool Show(string message, string title, UIStyle style = UIStyle.Blue, UIMessageBoxButtons buttons = UIMessageBoxButtons.OK, bool showMask = false, int delay = 0)
        {
            return ShowMessageDialog(message, title, buttons == UIMessageBoxButtons.OKCancel, style, showMask, UIMessageDialogButtons.Ok, delay);
        }

        public static bool ShowMessageDialog(string message, string title, bool showCancel, UIStyle style, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Ok, int delay = 0)
        {
            return ShowMessageDialog(null, message, title, showCancel, style, showMask, defaultButton, delay);
        }

        public static void ShowInfo2(string message, bool showMask = false, int delay = 0)
        {
            ShowMessageDialog2(UIStyles.CurrentResources.InfoTitle, message, UINotifierType.INFO, showMask, UIMessageDialogButtons.Ok, delay);
        }

        public static void ShowSuccess2(string message, bool showMask = false, int delay = 0)
        {
            ShowMessageDialog2(UIStyles.CurrentResources.SuccessTitle, message, UINotifierType.OK, showMask, UIMessageDialogButtons.Ok, delay);
        }

        public static void ShowWarning2(string message, bool showMask = false, int delay = 0)
        {
            ShowMessageDialog2(UIStyles.CurrentResources.WarningTitle, message, UINotifierType.WARNING, showMask, UIMessageDialogButtons.Ok, delay);
        }

        public static void ShowError2(string message, bool showMask = false, int delay = 0)
        {
            ShowMessageDialog2(UIStyles.CurrentResources.ErrorTitle, message, UINotifierType.ERROR, showMask, UIMessageDialogButtons.Ok, delay);
        }

        public static bool ShowAsk2(string message, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Ok)
        {
            return ShowMessageDialog2(UIStyles.CurrentResources.AskTitle, message, UINotifierType.Ask, showMask, defaultButton);
        }

        public static bool ShowMessageDialog2(string title, string message, UINotifierType noteType, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Cancel, int delay = 0)
        {
            return ShowMessageDialog2(null, title, message, noteType, showMask, defaultButton, delay);
        }

        public static bool ShowMessageDialog(Form owner, string message, string title, bool showCancel, UIStyle style, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Ok, int delay = 0)
        {
            bool screenCenter = GetShowOnScreenCenter(showMask, owner);
            if (owner == null)
            {
                using (UIMessageExForm uIMessageForm = new UIMessageExForm())
                {
                    uIMessageForm.ShowMessage(message, title, showCancel, style);
                    uIMessageForm.DefaultButton = (showCancel ? defaultButton : UIMessageDialogButtons.Ok);
                    uIMessageForm.Delay = delay;
                    return uIMessageForm.ShowForm(null, screenCenter, showMask);
                }
            }

            return owner.ThreadSafeCall(delegate
            {
                using (UIMessageExForm uIMessageForm2 = new UIMessageExForm())
                {
                    uIMessageForm2.ShowMessage(message, title, showCancel, style);
                    uIMessageForm2.DefaultButton = (showCancel ? defaultButton : UIMessageDialogButtons.Ok);
                    uIMessageForm2.Delay = delay;
                    return uIMessageForm2.ShowForm(owner, screenCenter, showMask);
                }
            });
        }

        public static bool ShowMessageDialog2(Form owner, string title, string message, UINotifierType noteType, bool showMask = false, UIMessageDialogButtons defaultButton = UIMessageDialogButtons.Cancel, int delay = 0)
        {
            bool screenCenter = GetShowOnScreenCenter(showMask, owner);
            if (owner == null)
            {
                using (UIMessageForm2 uIMessageForm = new UIMessageForm2(title, message, noteType, defaultButton))
                {
                    uIMessageForm.Delay = delay;
                    return uIMessageForm.ShowForm(null, screenCenter, showMask);
                }
            }

            return owner.ThreadSafeCall(delegate
            {
                using (UIMessageForm2 uIMessageForm2 = new UIMessageForm2(title, message, noteType, defaultButton))
                {
                    uIMessageForm2.Delay = delay;
                    return uIMessageForm2.ShowForm(owner, screenCenter, showMask);
                }
            });
        }

        private static bool GetShowOnScreenCenter(bool showMask, Form owner)
        {
            if (showMask)
            {
                return true;
            }

            if (owner == null)
            {
                return true;
            }

            if (owner.TopLevel)
            {
                return false;
            }

            if (owner.ParentForm == null)
            {
                return true;
            }

            return false;
        }

        internal static bool ShowForm(this UIForm frm, Form owner, bool screenCenter, bool showMask)
        {
            frm.Owner = owner;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = frm.Size.GetLocation(owner, screenCenter);
            frm.ShowInTaskbar = false;
            frm.TopMost = true;
            frm.Render();
            if (showMask)
            {
                return frm.ShowDialogWithMask() == DialogResult.OK;
            }

            return frm.ShowDialog() == DialogResult.OK;
        }

        internal static DialogResult ShowFormWithResult(this UIForm frm, Form owner, bool screenCenter, bool showMask)
        {
            frm.Owner = owner;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = frm.Size.GetLocation(owner, screenCenter);
            frm.ShowInTaskbar = false;
            frm.TopMost = true;
            frm.Render();
            if (!showMask)
            {
                return frm.ShowDialog();
            }

            return frm.ShowDialogWithMask();
        }

        private static Point GetLocation(this Size size, Form owner, bool screenCenter)
        {
            Rectangle bounds = Screen.GetBounds(SystemEx.GetCursorPos());
            if (screenCenter || owner == null)
            {
                return new Point(bounds.Left + bounds.Width / 2 - size.Width / 2, bounds.Top + bounds.Height / 2 - size.Height / 2);
            }

            Form form = (owner.TopLevel ? owner : owner.ParentForm);
            if (form == null)
            {
                return new Point(bounds.Left + bounds.Width / 2 - size.Width / 2, bounds.Top + bounds.Height / 2 - size.Height / 2);
            }

            return new Point(form.Left + form.Width / 2 - size.Width / 2, form.Top + form.Height / 2 - size.Height / 2);
        }
    }
}

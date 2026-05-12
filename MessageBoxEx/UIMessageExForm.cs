using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UCM_Tools.MessageBoxEx
{
    public partial class UIMessageExForm : UIForm
    {
        private bool _showCancel = true;

        private int delay;

        private string text = "";

        

        private Timer timer1;

        public bool IsOK { get; private set; }

        public bool ShowCancel
        {
            get
            {
                return _showCancel;
            }
            set
            {
                _showCancel = value;
                btnCancel.Visible = value;
                OnSizeChanged(null);
            }
        }

        public UIMessageDialogButtons DefaultButton { get; set; }

        public int Delay
        {
            set
            {
                if (value > 0)
                {
                    delay = value / 1000;
                    timer1.Start();
                }
            }
        }

        public UIMessageExForm()
        {
            InitializeComponent();
            btnOK.Text = UIStyles.CurrentResources.OK;
            btnCancel.Text = UIStyles.CurrentResources.Cancel;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (btnOK != null && btnCancel != null)
            {
                if (_showCancel)
                {
                    UIButton uIButton = btnOK;
                    int width = (btnCancel.Width = base.Width / 2 - 2);
                    uIButton.Width = width;
                    btnCancel.Left = btnOK.Left + btnOK.Width - 1;
                    btnCancel.Width = base.Width - btnCancel.Left - 2;
                }
                else
                {
                    btnOK.Width = base.Width - 4;
                }

                btnCancel.Left = btnOK.Right - 1;
            }
        }

        protected override void DoEnter()
        {
            base.DoEnter();
            if (!ShowCancel)
            {
                btnOK_Click(null, null);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            IsOK = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            IsOK = false;
            Close();
        }

        public override void SetStyleColor(UIBaseStyle uiColor)
        {
            base.SetStyleColor(uiColor);
            if (btnCancel != null)
            {
                btnCancel.SetStyleColor(uiColor);
                btnCancel.FillColor = BackColor;
                btnCancel.RectColor = Color.FromArgb(36, uiColor.ButtonRectColor);
                btnCancel.ForeColor = uiColor.LabelForeColor;
            }

            if (btnOK != null)
            {
                btnOK.SetStyleColor(uiColor);
                btnOK.FillColor = BackColor;
                btnOK.RectColor = Color.FromArgb(36, uiColor.ButtonRectColor);
                btnOK.ForeColor = uiColor.LabelForeColor;
            }

            if (lbMsg != null)
            {
                lbMsg.SetStyleColor(uiColor);
                lbMsg.ForeColor = uiColor.LabelForeColor;
                lbMsg.BackColor = uiColor.PlainColor;
                lbMsg.FillColor = uiColor.PlainColor;
                lbMsg.SelectionColor = base.RectColor;
                lbMsg.ScrollBarColor = uiColor.RectColor;
            }
        }

        public void ShowMessage(string message, string title, bool showCancel, UIStyle style = UIStyle.Blue)
        {
            base.Style = style;
            Text = title;
            lbMsg.Text = message;
            ShowCancel = showCancel;
            UIButton uIButton = btnOK;
            bool showFocusColor = (btnCancel.ShowFocusColor = showCancel);
            uIButton.ShowFocusColor = showFocusColor;
        }

        private void UIMessageForm_Shown(object sender, EventArgs e)
        {
            if (ShowCancel)
            {
                if (DefaultButton == UIMessageDialogButtons.Ok)
                {
                    btnOK.Focus();
                }
                else
                {
                    btnCancel.Focus();
                }
            }

            if (delay > 0)
            {
                if (text == "")
                {
                    text = Text;
                }

                Text = text + " [" + delay + "]";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            delay--;
            Text = text + " [" + delay + "]";
            if (delay <= 0)
            {
                Close();
            }
        }

        private void UIMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }


        
    }
}

using CommonLib;
using LogProc;
using Sunny.UI;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UCM_Tools.Config;
using UCM_Tools.MessageBoxEx;
using UCM_Tools.Tools;

namespace UCM_Tools.Forms
{
    public partial class TrackFilterForm : UIForm
    {
        public static event Action FilterChanged;

        public TrackFilterForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            tb_Ids.Text = SystemSetting.FilterTrackIds ?? "";
        }

        private void TrackFilterForm_Load(object sender, EventArgs e)
        {
            SunnyUIHelper.SetTheme(this, SystemSetting.ThemeColor);
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            try
            {
                this.Text = MultiLanguage.LanguageText("TrackFilterForm", "FilterIdTitle");
                lb_Title.Text = MultiLanguage.LanguageText("TrackFilterForm", "lb_Title");
                lb_Example.Text = MultiLanguage.LanguageText("TrackFilterForm", "lb_Example");
                btn_Save.Text = MultiLanguage.LanguageText("TrackFilterForm", "btn_Save");
                btn_Cancel.Text = MultiLanguage.LanguageText("TrackFilterForm", "btn_Cancel");
            }
            catch (Exception ex)
            {
                LogProc.Log.Error($"TrackFilterForm LoadLanguage Ex\r\n{ex}");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string input = tb_Ids.Text.Trim();
            if (!string.IsNullOrEmpty(input) && !Regex.IsMatch(input, @"^\d+(,\d+)*$"))
            {
                UIMessageBoxEx.ShowMessageDialog(
                    MultiLanguage.LanguageText("ErrorInfo", "FilterIdFormatError"),
                    MultiLanguage.LanguageText("CurrencyInfo", "Prompt"),
                    false, SunnyUIHelper.DefaultThreme);
                return;
            }
            SystemSetting.FilterTrackIds = input;
            FilterChanged?.Invoke();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

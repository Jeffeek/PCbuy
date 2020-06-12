using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TRPO_Project.Forms.HelpText;

namespace TRPO_Project
{
    public partial class HelpForm : MetroForm, IThemeChange
    {
        #region Variables

        private CurrentLanguage _currentLanguage = CurrentLanguage.English;
        private RussianLanguage _russianLanguage = new RussianLanguage();
        private EnglishLanguage _englishLanguage = new EnglishLanguage();
        private MetroThemeStyle _currentThemeStyle;
        private Point lastPoint;

        #endregion

        #region Constructor

        public HelpForm(MetroThemeStyle theme)
        {
            InitializeComponent();
            _currentThemeStyle = theme;
            ReadThemeAsync();
        }
        
        #endregion

        #region Theme

        public async void ChangeMetroControls(ProgramTheme obj)
        {
            this.Theme = _currentThemeStyle;
            tabHelp.Theme = _currentThemeStyle;
            tabHelp.Controls.OfType<MetroTabPage>()
                                            .ToList()
                                            .ForEach(x => x.Theme = _currentThemeStyle);

        }

        public async void ChangeNonMetroControls(ProgramTheme obj)
        {
            labelMainWindow.ForeColor = _currentThemeStyle == MetroThemeStyle.Light ? Color.Black : Color.White;
            labelOrderBasket.ForeColor = _currentThemeStyle == MetroThemeStyle.Light ? Color.Black : Color.White;
            labelProfile.ForeColor = _currentThemeStyle == MetroThemeStyle.Light ? Color.Black : Color.White;
        }

        public async void ReadThemeAsync()
        {
            ChangeMetroControls(null);
            ChangeNonMetroControls(null);
        }
        
        #endregion

        #region Moving

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panelHead_MouseDown(object sender, MouseEventArgs e) => lastPoint = e.Location;
        
        #endregion

        #region PageTextChanging

        private void ChangeTextAsync()
        {
            ChangeFirstPage();
            ChangeSecondPage();
            ChangeThirdPage();
        }

        private async void ChangeFirstPage()
        {
            labelMainWindow.Text = _currentLanguage == CurrentLanguage.Russian ? _russianLanguage.MainWindowText : _englishLanguage.MainWindowText;
        }

        private async void ChangeSecondPage()
        {
            labelProfile.Text = _currentLanguage == CurrentLanguage.Russian ? _russianLanguage.ProfileWindowText : _englishLanguage.ProfileWindowText;
        }

        private async void ChangeThirdPage()
        {
            labelOrderBasket.Text = _currentLanguage == CurrentLanguage.Russian ? _russianLanguage.BasketWindowText : _englishLanguage.BasketWindowText;
        }
        
        #endregion

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentLanguage = comboBoxLanguage.Text == "RUSSIAN" ? CurrentLanguage.Russian : CurrentLanguage.English;

            ChangeTextAsync();
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e) => Close();

    }
}

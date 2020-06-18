using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using TRPO_Project.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System.Runtime.Serialization.Json;
using Guna.UI.WinForms;

namespace TRPO_Project
{
    public partial class formProfile : MetroForm, IThemeChange
    {
        #region variables

        private int userID;
        private MetroForm mainForm;
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private bool isADMIN;
        private Point lastPoint;
        private GunaCirclePictureBox ChoosedPalette;

        #endregion

        #region Constructor
        public formProfile(formUSER formF,int ID)
        {
            InitializeComponent();
            SetScaling();
            mainForm = formF;
            userID = ID;
            ReadThemeAsync();
            isADMIN = false;
            bunifuMaterialTextboxEMAIL.Text = takeAlogin();
            bunifuMaterialTextboxPASS.Text = takeApassword();          
            pictureBoxPROFILE.Image = takeANimg();
        }

        public formProfile(formADMIN formF, int ID)
        {
            InitializeComponent();
            SetScaling();
            mainForm = formF;
            userID = ID;
            ReadThemeAsync();
            isADMIN = true;
            linkLabelDELETEprofile.Visible = false;
            bunifuMaterialTextboxEMAIL.Text = takeAlogin();
            bunifuMaterialTextboxPASS.Text = takeApassword();
            pictureBoxPROFILE.Image = takeANimg();
        }
        #endregion

        #region RequestForEmail&Pass
        private string takeAlogin()
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT email from LOGin where id={userID}", sql_con))
                {
                    string login = sql_cmd.ExecuteScalar().ToString();
                    return login;
                }
            }
        }
        private string takeApassword()
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT password from LOGin where id={userID}", sql_con))
                {
                    string password = sql_cmd.ExecuteScalar().ToString();
                    return password;
                }
            }
        }
        private Image takeANimg()
        {
            Image profileImage;
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT ProfilePicture from LOGin where id={userID}", sql_con))
                {
                    using (FileStream IMUR = new FileStream(sql_cmd.ExecuteScalar().ToString(), FileMode.Open))
                    {
                        profileImage = Image.FromStream(IMUR);
                    }
                }
            }

            return profileImage;
        }
        #endregion

        #region Link&PicClicked
        private void pictureBoxCHANGEpassVisibility_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextboxPASS.Focus();
            if (bunifuMaterialTextboxPASS.isPassword)
            {
                pictureBoxCHANGEpassVisibility.Image = Resources.eye_show;
                bunifuMaterialTextboxPASS.isPassword = false;
            }
            else
            {
                pictureBoxCHANGEpassVisibility.Image = Resources.eye_hide;
                bunifuMaterialTextboxPASS.isPassword = true;
            }
        }

        private void linkLabelCHANGEprofilePIC_Click(object sender, EventArgs e)
        {
            if (openFileDialogchangeAprofilePIC.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialogchangeAprofilePIC.FileName;
                using (FileStream FS = new FileStream(fileName, FileMode.Open))
                {
                    pictureBoxPROFILE.Image = Image.FromStream(FS);
                    pictureBoxPROFILE.Update();
                    Image IMG = Image.FromStream(FS);
                    if (!isADMIN)
                    {
                        File.Delete($@"{Directory.GetCurrentDirectory()}\USERsPIC\id{userID}_USER.png");
                        File.Copy(fileName, $@"{Directory.GetCurrentDirectory()}\USERsPIC\id{userID}_USER.png");
                        (mainForm as formUSER)?.SetNewProfilePicture(IMG);
                    }
                    else
                    {
                        File.Delete($@"{Directory.GetCurrentDirectory()}\USERsPIC\id{userID}_ADMIN.png");
                        File.Copy(fileName, $@"{Directory.GetCurrentDirectory()}\USERsPIC\id{userID}_ADMIN.png");
                        (mainForm as formADMIN)?.SetNewProfilePicture(IMG);
                    }
                }
            }
        }

        private void linkLabelDELETEprofile_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "ARE YOU SURE?", "DELETE PROFILE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                result = MetroMessageBox.Show(this, "ARE YOU SURE SURE?! DON'T IGNORE IT", "DELETE PROFILE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
                    {
                        sql_con.Open();
                        using (sql_cmd = new SQLiteCommand($"DELETE FROM LOGin WHERE id={userID}", sql_con))
                        {
                            sql_cmd.ExecuteNonQuery();
                            DeleteUserFromJSON();
                            File.Delete($"{Directory.GetCurrentDirectory()}\\USERsPIC\\id{userID}_USER.png");
                            MetroMessageBox.Show(this, "SUCCESS! YOUR PROFILE WAS DELETED", "DELETE PROFILE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                    }
                }
            }
        }

        private void DeleteUserFromJSON()
        {
            List<ProgramTheme> themes = new List<ProgramTheme>();

            using (FileStream file = new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<ProgramTheme>));
                themes = jsonSerializer.ReadObject(file) as List<ProgramTheme>;
            }

            themes.Remove(themes.Find(x => x.UserID == userID));

            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json", "");
            using (FileStream file = new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json", FileMode.OpenOrCreate))
            {                
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<ProgramTheme>));
                jsonSerializer.WriteObject(file, themes);
            }
        }

        #endregion

        #region CHANGE PASS

        #region TextChanges

        private void textBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text.Length > 5)
            {
                textBoxNewPass.ForeColor = Color.SpringGreen;
                if (textBoxNewPass.Text == textBoxRepeatNewPass.Text)
                {
                    buttonApplyNewPassword.Image = Resources.ok_48px;
                    buttonApplyNewPassword.BaseColor1 = Color.MediumSeaGreen;
                    buttonApplyNewPassword.Enabled = true;
                }
            }
            else
            {
                textBoxNewPass.ForeColor = Color.Crimson;
                buttonApplyNewPassword.Image = Resources.X;
                buttonApplyNewPassword.BaseColor1 = Color.SlateGray;
                buttonApplyNewPassword.Enabled = false;
            }

            textBoxNewPass.FocusedBorderColor = textBoxNewPass.ForeColor;
        }

        private void textBoxRepeatNewPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRepeatNewPass.Text.Length > 5)
            {
                if (textBoxRepeatNewPass.Text == textBoxNewPass.Text)
                {
                    buttonApplyNewPassword.Image = Resources.ok_48px;
                    buttonApplyNewPassword.BaseColor1 = Color.MediumSeaGreen;
                    buttonApplyNewPassword.Enabled = true;
                    textBoxRepeatNewPass.ForeColor = Color.SpringGreen;
                }
            }
            else
            {
                textBoxRepeatNewPass.ForeColor = Color.Crimson;
                buttonApplyNewPassword.Image = Resources.X;
                buttonApplyNewPassword.BaseColor1 = Color.SlateGray;
                buttonApplyNewPassword.Enabled = false;
            }

            textBoxRepeatNewPass.FocusedBorderColor = textBoxRepeatNewPass.ForeColor;
        }

        #endregion

        #region Button&LabelClick

        private void linkLabelCHANGEpass_Click(object sender, EventArgs e)
        {
            if (xuiSlidingPanelPassChange.Collapsed)
            {
                linkLabelCHANGEprofilePIC.Enabled = false;
                linkLabelCHANGEprofilePIC.Enabled = false;
                imageButtonSettings.Enabled = false;
                pictureBoxCHANGEpassVisibility.Enabled = false;
            }
            else
            {
                linkLabelCHANGEprofilePIC.Enabled = true;
                linkLabelDELETEprofile.Enabled = true;
                imageButtonSettings.Enabled = true;
                pictureBoxCHANGEpassVisibility.Enabled = true;
            }
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            textBoxNewPass.UseSystemPasswordChar = !textBoxNewPass.UseSystemPasswordChar;
            buttonHidePassword.Image = textBoxNewPass.UseSystemPasswordChar ? Resources.eye_hide : Resources.eye_show;
        }

        private void buttonApplyNewPassword_Click(object sender, EventArgs e)
        {
            string oldPASS;
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT password FROM LOGin WHERE id={userID}", sql_con))
                {
                    oldPASS = sql_cmd.ExecuteScalar().ToString();
                }
            }


            if (textBoxNewPass.Text == textBoxRepeatNewPass.Text && textBoxNewPass.Text.Length > 5)
            {
                if (oldPASS == textBoxNewPass.Text)
                {
                    MetroMessageBox.Show(this, "YOU CAN'T UPDATE YOUR PASS BY THIS WAY!", "SMTH WENT WRONG!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (sql_con =
                        new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
                    {
                        sql_con.Open();
                        using (sql_cmd =
                            new SQLiteCommand($"UPDATE LOGin SET password='{textBoxNewPass.Text}' WHERE id={userID}",
                                sql_con))
                        {
                            sql_cmd.ExecuteNonQuery();
                            MetroMessageBox.Show(this, "YOUR PASSWORD WAS UPDATED!", "SUCCESS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }

                    bunifuMaterialTextboxPASS.Text = textBoxNewPass.Text;
                    xuiSlidingPanelPassChange.Collapsed = true;
                    imageButtonSettings.Enabled = true;
                    pictureBoxCHANGEpassVisibility.Enabled = true;
                }
            }

            textBoxNewPass.Text = string.Empty;
            textBoxRepeatNewPass.Text = string.Empty;
        }

        #endregion

        #endregion

        #region MovingForm
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void panelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        #endregion

        #region Theme

        public void ChangeMetroControls(ProgramTheme OBJ)
        {
            Theme = OBJ.Theme == ETheme.Light ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
            linkLabelCHANGEprofilePIC.Theme = OBJ.Theme == ETheme.Light ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
        }

        public void ChangeNonMetroControls(ProgramTheme OBJ)
        {
            switchTheme.Checked = OBJ.Theme == ETheme.Dark;
            pictureBoxPROFILE.BackColor = OBJ.Theme == ETheme.Dark ? Color.DimGray : Color.WhiteSmoke;
            labelChangeTheme.ForeColor = OBJ.Theme == ETheme.Dark ? Color.Black : Color.White;
            labelChangeTheme.Text = OBJ.Theme == ETheme.Dark ? "Dark theme" : "Light theme";
            circlePictureBoxBL.BackColor = OBJ.BottomLeft;
            circlePictureBoxTL.BackColor = OBJ.TopLeft;
            circlePictureBoxBR.BackColor = OBJ.BottomRight;
            circlePictureBoxTR.BackColor = OBJ.TopRight;
            labelFontColor.LinkColor = OBJ.FontColor;
        }

        public async void ReadThemeAsync()
        {
            try
            {
                List<ProgramTheme> themes;
                using (FileStream file = new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json",
                    FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonSerializer =
                        new DataContractJsonSerializer(typeof(List<ProgramTheme>));

                    themes = jsonSerializer.ReadObject(file) as List<ProgramTheme>;
                }

                if (themes.Count(x => x.UserID == userID) > 0)
                {
                    ProgramTheme ThemeOBJ = themes.Find(x => x.UserID == userID);
                    ChangeNonMetroControls(ThemeOBJ);
                    ChangeMetroControls(ThemeOBJ);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Произошла ошибка при дисериализации: \n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Settings

        private void buttonReloadTheme_Click(object sender, EventArgs e)
        {
            switchTheme.Checked = true;
            labelFontColor.LinkColor = Color.Cyan;
            circlePictureBoxBL.BackColor = Color.Black;
            circlePictureBoxBR.BackColor = Color.MediumTurquoise;
            circlePictureBoxTL.BackColor = Color.DarkOrchid;
            circlePictureBoxTR.BackColor = Color.MediumSlateBlue;
        }

        private void labelFontColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fontColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                labelFontColor.LinkColor = fontColorDialog.Color;
            }
        }

        private void ChangeColorPalette_labels(string choosed)
        {
            labelPaletteBL.ForeColor = Color.MintCream;
            labelPaletteTL.ForeColor = Color.MintCream;
            labelPaletteBR.ForeColor = Color.MintCream;
            labelPaletteTR.ForeColor = Color.MintCream;
            if (choosed == "BL")
            {
                labelPaletteBL.ForeColor = Color.DeepPink;
            }
            else if (choosed == "TL")
            {
                labelPaletteTL.ForeColor = Color.DeepPink;
            }
            else if (choosed == "BR")
            {
                labelPaletteBR.ForeColor = Color.DeepPink;
            }
            else if (choosed == "TR")
            {
                labelPaletteTR.ForeColor = Color.DeepPink;
            }
        }

        private void imageButtonSettings_Click(object sender, EventArgs e)
        {
            if (xuiSlidingPanelSettings.Collapsed)
            {
                linkLabelDELETEprofile.Enabled = false;
                pictureBoxCHANGEpassVisibility.Enabled = false;
            }
            else
            {
                linkLabelDELETEprofile.Enabled = true;
                pictureBoxCHANGEpassVisibility.Enabled = true;
            }
        }

        private void gunaTileButtonApplySettings_Click(object sender, EventArgs e)
        {
            List<ProgramTheme> themes;
            ETheme ChoosedTheme = switchTheme.Checked ? ETheme.Dark : ETheme.Light;
            Color TR = circlePictureBoxTR.BackColor;
            Color TL = circlePictureBoxTL.BackColor;
            Color BR = circlePictureBoxBR.BackColor;
            Color BL = circlePictureBoxBL.BackColor;
            Color Font = labelFontColor.LinkColor;

            try
            {
                using (FileStream file =
                    new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json",
                        FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonSerializer =
                        new DataContractJsonSerializer(typeof(List<ProgramTheme>));
                    themes = jsonSerializer.ReadObject(file) as List<ProgramTheme>;
                }
            }
            catch (Exception ex)
            {
                themes = new List<ProgramTheme>();
            }

            themes.Remove(themes.Find(x => x.UserID == userID));

            themes.Add(new ProgramTheme(ChoosedTheme, userID) { BottomLeft = BL, BottomRight = BR, TopLeft = TL, TopRight = TR, FontColor = Font});
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json", "");
            using (FileStream file = new FileStream($"{Directory.GetCurrentDirectory()}\\ThemeModel\\ThemeSettings.json", FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<ProgramTheme>));
                jsonSerializer.WriteObject(file, themes);
            }
            MetroMessageBox.Show(this, "The program will be reloaded", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void colorPalette_ColorChanged(object sender, EventArgs e)
        {
            if (ChoosedPalette != null)
            {
                ChoosedPalette.BackColor = colorPalette.SelectedColor;
            }
            else
            {
                MetroMessageBox.Show(this, "Choose an aim for colorizing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region DpiScaling

        private void SetScaling()
        {
            xuiSlidingPanelPassChange.PanelWidthExpanded =
                (int) (xuiSlidingPanelPassChange.PanelWidthExpanded * ScaleControls.Scale * 1.05);
            xuiSlidingPanelSettings.PanelWidthExpanded =
                (int) (xuiSlidingPanelSettings.PanelWidthExpanded * ScaleControls.Scale * 1.05);

            xuiSlidingPanelPassChange.Controls
                                            .OfType<GunaTextBox>()
                                            .ToList()
                                            .ForEach(x => x.Height = (int)(x.Height / ScaleControls.Scale));
            xuiSlidingPanelSettings.Controls
                                            .OfType<GunaTextBox>()
                                            .ToList()
                                            .ForEach(x => x.Height = (int)(x.Height / ScaleControls.Scale));

            buttonHidePassword.Size = new Size((int)(buttonHidePassword.Width / ScaleControls.Scale),
                                                (int)(buttonHidePassword.Height / ScaleControls.Scale));

        }

        #endregion

        #region Load&Quit

        private void formProfile_Load(object sender, EventArgs e)
        {
            SpeedUpPanel();
            StartTransation.ShowAsyc(this);
            switchTheme.CheckedChanged += (a, b) =>
            {
                labelChangeTheme.ForeColor = switchTheme.Checked ? Color.Black : Color.White;
                labelChangeTheme.Text = switchTheme.Checked ? "Dark theme" : "Light theme";
            };
            circlePictureBoxBL.Click += (a, b) => 
            {
                ChoosedPalette = circlePictureBoxBL;
                ChangeColorPalette_labels("BL");
            };
            circlePictureBoxTL.Click += (a, b) => 
            { 
                ChoosedPalette = circlePictureBoxTL;
                ChangeColorPalette_labels("TL");
            };
            circlePictureBoxBR.Click += (a, b) => 
            { 
                ChoosedPalette = circlePictureBoxBR;
                ChangeColorPalette_labels("BR");
            };
            circlePictureBoxTR.Click += (a, b) => 
            { 
                ChoosedPalette = circlePictureBoxTR;
                ChangeColorPalette_labels("TR");
            };
            
        }

        private void SpeedUpPanel()
        {
            xuiSlidingPanelSettings.Collapsed = false;
            xuiSlidingPanelSettings.Collapsed = true;
        }


        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBoxes(readonlySettings)

        private void bunifuMaterialTextboxPASS_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void bunifuMaterialTextboxEMAIL_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        #endregion

    }
}

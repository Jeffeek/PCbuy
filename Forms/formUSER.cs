using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using System.Data.Sql;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Threading;
using System.Runtime.Serialization.Json;

namespace TRPO_Project
{
    public partial class formUSER : MetroForm, IThemeChange
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private Point lastPoint;
        private List<PCinfo> LObjects = new List<PCinfo>(); // объекты главной формы
        private List<PC> AllPCList = new List<PC>();
        private int userID;
        #endregion

        #region Constructors
        public formUSER(int id)
        {
            InitializeComponent();
            userID = id;
            ReadThemeAsync();
            FormStartTransition.ShowAsyc(this);
            GetInfoIntoComboBoxes();
            SetPictureProfile();
            FillPC();
            metroComboBoxTYPEofPC.SelectedIndex = 0;
            metroComboBoxCPUsort.SelectedIndex = 0;
            metroComboBoxGPUsort.SelectedIndex = 0;
            metroComboBoxRAM.SelectedIndex = 0;
        }
        #endregion

        #region PictureBOXclick
        private void pictureBoxProductBIN_Click(object sender, EventArgs e)
        {
            Form BIN = new BIN(userID);           
            BIN.ShowDialog(this);
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            formProfile FP = new formProfile(this, userID);
            FP.ShowDialog(this);
        }

        #endregion

        #region PriceBOXfunctions

        private void textBox_PRICE_Leave(object sender, EventArgs e)
        {
            if (!textBox_PRICE.Text.Contains("$") && textBox_PRICE.Text.Length < 2)
            {
                textBox_PRICE.Text = "$0-9999";
                textBox_PRICE.ForeColor = Color.Gray;
            }
            else if (!textBox_PRICE.Text.Contains("$") && textBox_PRICE.Text.Length > 0)
            {
                textBox_PRICE.Text = "$" + textBox_PRICE.Text;
            }
            else
            {
                if (textBox_PRICE.Text.Contains("$") && textBox_PRICE.Text.Length < 2)
                {
                    textBox_PRICE.Text = "$0-9999";
                }
                textBox_PRICE.ForeColor = Color.Gray;
            }
        }

        private void textBox_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == 45 && !textBox_PRICE.Text.Contains("-"))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_PRICE_Enter(object sender, EventArgs e)
        {
            textBox_PRICE.Text = string.Empty;
            textBox_PRICE.Text += ("$");
            textBox_PRICE.ForeColor = Color.Black;
        }
        #endregion

        #region Display List
        private void bunifuImageButtonSORT_Click(object sender, EventArgs e)
        {
            bunifuImageButtonSORT.Focus();
            ProgressBar.Visible = true;

            #region ParseInputPrice
            List<int> priceReaderInt = textBox_PRICE.Text
                                                        .Split('$', '-')
                                                        .ToList()
                                                        .Where(x => x != string.Empty)
                                                        .ToList()
                                                        .ConvertAll(x => Convert.ToInt32(x));

            if (!textBox_PRICE.Text.Contains("-"))
            {
                priceReaderInt.Add(priceReaderInt[0]);
            }

            if (priceReaderInt.Count > 1)
            {
                if (priceReaderInt[1] < priceReaderInt[0])
                {
                    MetroMessageBox.Show(this, "Second filter num bigger than first!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_PRICE.Focus();
                    ProgressBar.Value = 0;
                    ProgressBar.Visible = false;
                    return;
                }
            }
            #endregion

            var ToDisplay = new List<PC>(AllPCList.Where(x => x.COST >= priceReaderInt[0] && x.COST <= priceReaderInt[1]));

            if (metroComboBoxTYPEofPC.Text != "TYPE")
            {
                ToDisplay = ToDisplay.Where(x => x.TYPE == metroComboBoxTYPEofPC.Text)?.ToList();
            }
            if (metroComboBoxCPUsort.Text != "CPU")
            {
                ToDisplay = ToDisplay.Where(x => x.CPU == metroComboBoxCPUsort.Text)?.ToList();
            }
            if (metroComboBoxGPUsort.Text != "GPU")
            {
                ToDisplay = ToDisplay.Where(x => x.GPU == metroComboBoxGPUsort.Text)?.ToList();
            }
            if (metroComboBoxRAM.Text != "RAM")
            {

                ToDisplay = ToDisplay.Where(x => x.RAM == int.Parse(metroComboBoxRAM.Text.Replace(" GB", "")))?.ToList();
            }

            if (ToDisplay.Count == 0)
            {
                ProgressBar.Visible = false;
                MetroMessageBox.Show(this, "NO PC MATCHES", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DisplayListAsync(ToDisplay);
        }

        private async void DisplayListAsync(List<PC> Listed)
        {
            if (LObjects.Count > 0)
            {
                foreach (var elem in LObjects)
                {
                    this.Controls.Remove(elem);
                    elem.Dispose();
                }
                LObjects.Clear();
            }
            int Y = (int)(88*ScaleControls.Scale);
            this.Refresh();
            ProgressBar.Value = 0;
            ProgressBar.Enabled = true;
            int oneElementPercentage = 100 / Listed.Count;
            int deltaY = (int) (230 * ScaleControls.Scale);
            foreach (var pc in Listed)
            {
                int _percentage = 0;
                await Task.Delay(30);
                while (_percentage != oneElementPercentage)
                {
                    ProgressBar.Value++;
                    _percentage++;
                }
                PCinfo OBJ = new PCinfo(pc) { isAdmin = false };
                LObjects.Add(OBJ);
                OBJ.Location = new Point(0, Y);
                Y += deltaY;
                OBJ.BackColor = Theme == MetroThemeStyle.Dark ? Color.FromArgb(17, 17, 17) : Color.White;
                OBJ.Anchor = AnchorStyles.Top;
                this.Controls.Add(OBJ);
            }
            ProgressBar.Enabled = false;
            ProgressBar.Visible = false;
        }
        #endregion 

        #region ComboBOXfill&textCHANGES
        private void GetInfoIntoComboBoxes()
        {

            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand("SELECT DISTINCT CPU from PCdb", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        metroComboBoxCPUsort.Items.Add(reader.GetString(0));
                    }

                }
                using (sql_cmd = new SQLiteCommand("SELECT DISTINCT typeOfPC from PCdb", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        metroComboBoxTYPEofPC.Items.Add(reader.GetString(0));
                    }
                }
                using (sql_cmd = new SQLiteCommand("SELECT DISTINCT GPU from PCdb", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        metroComboBoxGPUsort.Items.Add(reader.GetString(0));
                    }

                }
                using (sql_cmd = new SQLiteCommand("SELECT DISTINCT RAM from PCdb ORDER BY RAM", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       metroComboBoxRAM.Items.Add(Convert.ToString(reader.GetInt32(0)) + " GB");
                    }
                }
            }
        }

        #endregion

        #region SetPicture
        public void SetPictureProfile()
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT ProfilePicture FROM LOGin WHERE id={userID}", sql_con))
                {
                    using (FileStream fs = new FileStream(sql_cmd.ExecuteScalar().ToString(), FileMode.Open))
                    {
                        pictureBoxProfile.Image = Image.FromStream(fs);
                    }
                }
            }
        }
        public void SetNewProfilePicture(Image IMG)
        {
            pictureBoxProfile.Image = IMG;
            pictureBoxProfile.Update();           
        }
        #endregion

        #region FillingOBJECTS
        private void FillPC()
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand("SELECT * FROM PCdb", sql_con))
                {
                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Image img;
                            using (var IMGstream = new FileStream(reader.GetString(6), FileMode.Open))
                            {
                                img = Image.FromStream(IMGstream);
                            }
                            PC OBJ = new PC(reader.GetString(1), reader.GetInt32(0), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(2), img);
                            AllPCList.Add(OBJ);
                        }
                    }
                }
            }
        }
        #endregion

        #region ControlButtons
        private void button_backToLoginForm_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "ARE YOU SURE THAT YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }


        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
        }

        public void ChangeNonMetroControls(ProgramTheme OBJ)
        {
            groupBoxHEAD.GradientBottomLeft = OBJ.BottomLeft;
            groupBoxHEAD.GradientBottomRight = OBJ.BottomRight;
            groupBoxHEAD.GradientTopLeft = OBJ.TopLeft;
            groupBoxHEAD.GradientTopRight = OBJ.TopRight;
            groupBoxHEAD.Controls.OfType<Label>().Select(x => x.ForeColor = OBJ.FontColor).ToList();
            groupBoxHEAD.Refresh();
        }

        public void ReadThemeAsync()
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this.Theme);
            helpForm.Show(this);
        }
    }
}

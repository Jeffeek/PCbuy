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
using TRPO_Project.Properties;

namespace TRPO_Project
{
    public partial class formADMIN : MetroForm
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private static List<PCinfo> OBJects = new List<PCinfo>(); // объекты главной формы
        private static List<PC> AllPCList = new List<PC>();
        public static List<int> BINid = new List<int>(); //лист корзины юзера
        private int userID;
        #endregion

        #region Constructor
        public formADMIN(int id)
        {
            InitializeComponent();
            FormStartTransition.ShowAsyc(this);
            userID = id;
            GetInfoIntoComboBoxes();
            SetPictureProfile();
            FillPC();
            metroComboBoxTYPEofPC.SelectedIndex = 0;
            metroComboBoxCPUsort.SelectedIndex = 0;
            metroComboBoxGPUsort.SelectedIndex = 0;
            metroComboBoxRAM.SelectedIndex = 0;

        }

        #endregion

        #region FillingOBJECTS
        private void FillPC()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand("SELECT * FROM PCdb",sql_con))
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

        #region PictureBOXclick
        private void pictureBoxProductBIN_Click(object sender, EventArgs e)
        {
            Form BIN = new BIN(true, userID);
            BIN.ShowDialog(this);
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            formProfile FP = new formProfile(this, userID);
            FP.ShowDialog(this);
        }

        #endregion

        #region Display List
        private void bunifuImageButtonSORT_Click(object sender, EventArgs e)
        {
            bunifuImageButtonSORT.Focus();
            xuiCircleProgressBar1.Visible = true;

            #region ParseInputPrice
            string[] PriceReaderSTR = textBox_PRICE.Text.Split('$', '-');

            int[] PriceReaderINT = Array.Empty<int>();
            if (PriceReaderSTR.Length == 2)
            {
                PriceReaderINT = new int[PriceReaderSTR.Length];
                PriceReaderINT[1] = Convert.ToInt32(PriceReaderSTR[1]);
            }
            else if (PriceReaderSTR.Length == 3)
            {
                PriceReaderINT = new int[PriceReaderSTR.Length - 1];
            }

            for (int i = 1; i < PriceReaderSTR.Length; i++)
            {
                PriceReaderINT[i - 1] = Convert.ToInt32(PriceReaderSTR[i]);
            }
            if (PriceReaderINT.Length > 1)
            {
                if (PriceReaderINT[1] < PriceReaderINT[0])
                {
                    MessageBox.Show("Второе число фильтра по цене больше первого!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_PRICE.Focus();
                    xuiCircleProgressBar1.percentage = 0;
                    xuiCircleProgressBar1.Visible = false;
                    return;
                }
            }
            #endregion

            var ToDisplay = new List<PC>(AllPCList.Where(x => x.COST >= PriceReaderINT[0] && x.COST <= PriceReaderINT[1]));

            if (metroComboBoxTYPEofPC.Text != "<не выбрано>")
            {
                ToDisplay = ToDisplay.Where(x => x.TYPE == metroComboBoxTYPEofPC.Text).ToList();
            }    
            if (metroComboBoxCPUsort.Text != "<не выбрано>")
            {
                ToDisplay = ToDisplay.Where(x => x.CPU == metroComboBoxCPUsort.Text).ToList();
            }
            if (metroComboBoxGPUsort.Text != "<не выбрано>")
            {
                ToDisplay = ToDisplay.Where(x => x.GPU == metroComboBoxGPUsort.Text).ToList();
            }
            if (metroComboBoxRAM.Text.Trim(' ', 'G', 'B') != "<не выбрано>")
            {
                ToDisplay = ToDisplay.Where(x => x.RAM == Convert.ToInt32(metroComboBoxRAM.Text.Trim(' ', 'G', 'B'))).ToList();
            }

            if (ToDisplay.Count == 0)
            {
                xuiCircleProgressBar1.Visible = false;
                MetroMessageBox.Show(this, "NO PC MATCHES", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DisplayListAsync(ToDisplay);
        }

        private async Task DisplayListAsync(List<PC>Listed)
        {
            if (OBJects.Count > 0)
            {
                foreach (var elem in OBJects)
                {
                    this.Controls.Remove(elem);
                    elem.Dispose();
                }
                OBJects.Clear();
            }
            int Y = 110;
            this.Refresh();
            xuiCircleProgressBar1.percentage = 0;
            xuiCircleProgressBar1.Enabled = true;
            int Final = 100 / Listed.Count;
            foreach (var pc in Listed)
            {
                int P = 0;
                await Task.Delay(30).ConfigureAwait(true);
                while (P != Final)
                {
                    xuiCircleProgressBar1.Percentage++;
                    P++;
                }
                PCinfo OBJ = new PCinfo(pc.TYPE, pc.ID, pc.CPU, pc.GPU, pc.RAM, pc.COST, pc.IMG) { isAdmin = true };
                OBJects.Add(OBJ);
                OBJ.Location = new Point(0, Y);
                Y += 270;
                this.Controls.Add(OBJ);
            }
            xuiCircleProgressBar1.Enabled = false;
            xuiCircleProgressBar1.Visible = false;
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

        private void textBox_PRICE_Enter(object sender, EventArgs e)
        {
            textBox_PRICE.Text = string.Empty;
            textBox_PRICE.Text += ("$");
            textBox_PRICE.ForeColor = Color.Black;
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
        #endregion

        #region ComboBOXfill&textCHANGES
        private void GetInfoIntoComboBoxes()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
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

        private void metroComboBoxTYPEofPC_Enter(object sender, EventArgs e)
        {
            metroComboBoxTYPEofPC.Text = "";
            metroComboBoxTYPEofPC.ForeColor = Color.Black;
        }

        private void metroComboBoxTYPEofPC_Leave(object sender, EventArgs e)
        {
            if (metroComboBoxTYPEofPC.SelectedIndex < 0)
            {
                metroComboBoxTYPEofPC.Text = "TYPEofPC";
                metroComboBoxTYPEofPC.ForeColor = Color.Black;
            }
            else
            {
                metroComboBoxTYPEofPC.Text = metroComboBoxTYPEofPC.SelectedItem.ToString();
                metroComboBoxTYPEofPC.ForeColor = Color.Gray;
            }
        }

        private void metroComboBoxCPUsort_Enter(object sender, EventArgs e)
        {
            metroComboBoxCPUsort.Text = "";
            metroComboBoxCPUsort.ForeColor = Color.Black;
        }

        private void metroComboBoxCPUsort_Leave(object sender, EventArgs e)
        {
            if (metroComboBoxCPUsort.SelectedIndex < 0)
            {
                metroComboBoxCPUsort.Text = "CPU";
                metroComboBoxCPUsort.ForeColor = Color.Black;
            }
            else
            {
                metroComboBoxCPUsort.Text = metroComboBoxCPUsort.SelectedItem.ToString();
                metroComboBoxCPUsort.ForeColor = Color.Gray;
            }
        }

        private void metroComboBoxGPUsort_Enter(object sender, EventArgs e)
        {
            metroComboBoxGPUsort.Text = "";
            metroComboBoxGPUsort.ForeColor = Color.Black;
        }

        private void metroComboBoxGPUsort_Leave(object sender, EventArgs e)
        {
            if (metroComboBoxGPUsort.SelectedIndex < 0)
            {
                metroComboBoxGPUsort.Text = "GPU";
                metroComboBoxGPUsort.ForeColor = Color.Black;
            }
            else
            {
                metroComboBoxGPUsort.Text = metroComboBoxGPUsort.SelectedItem.ToString();
                metroComboBoxGPUsort.ForeColor = Color.Gray;
            }
        }

        private void metroComboBoxRAM_Enter(object sender, EventArgs e)
        {
            metroComboBoxRAM.Text = "";
            metroComboBoxRAM.ForeColor = Color.Black;
        }

        private void metroComboBoxRAM_Leave(object sender, EventArgs e)
        {

            if (metroComboBoxRAM.SelectedIndex < 0)
            {
                metroComboBoxRAM.Text = "RAM";
                metroComboBoxRAM.ForeColor = Color.Black;
            }
            else
            {
                metroComboBoxRAM.Text = metroComboBoxRAM.SelectedItem.ToString();
                metroComboBoxRAM.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region SetPicture
        public void SetPictureProfile()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT ProfilePicture FROM LOGin WHERE id={userID}", sql_con))
                {
                    using (FileStream fs = new FileStream(sql_cmd.ExecuteScalar().ToString(), FileMode.Open))
                    {
                        pictureBoxProfile1.Image = Image.FromStream(fs);
                    }
                }
            }
        }
        public void SetNewProfilePicture(Image IMG)
        {
            pictureBoxProfile1.Image = IMG;
            pictureBoxProfile1.Update();
        }
        #endregion

        #region ControlButtonsClick
        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bunifuImageButtonADMINPANEL_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanel = new AdminPanelForm();
            adminPanel.ShowDialog(this);
        }
        private void button_backToLoginForm_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "ARE YOU SURE THAT YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        #endregion
    }
}

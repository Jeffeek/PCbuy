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

namespace TRPO_Project
{
    public partial class formUSER : MetroForm
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private static bool isMINUS = true;
        private static List<PCinfo> OBJects = new List<PCinfo>(); // объекты главной формы
        internal static List<int> BINid = new List<int>(); //лист корзины юзера
        private int userID;
        #endregion

        #region Constructors
        public formUSER(int id)
        {
            InitializeComponent();
            FormStartTransition.ShowAsyc(this);
            userID = id;
            GetInfoIntoComboBoxes();
            SetPictureProfile();
            metroComboBoxTYPEofPC.SelectedIndex = 0;
            metroComboBoxCPUsort.SelectedIndex = 0;
            metroComboBoxGPUsort.SelectedIndex = 0;
            metroComboBoxRAM.SelectedIndex = 0;
        }
        #endregion

        #region PictureBOXclick
        private void pictureBoxProductBIN1_Click(object sender, EventArgs e)
        {
            Form BIN = new BIN(false, userID);           
            BIN.ShowDialog(this);
        }

        private void pictureBoxProfile1_Click(object sender, EventArgs e)
        {
            formProfile FP = new formProfile(this, userID);
            FP.ShowDialog(this);
        }

        #endregion

        #region buttonsClick

        private void bunifuThinButtonSORT_Click(object sender, EventArgs e)
        {
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
                }
            }
            #endregion

            List<int> IDs = new List<int>();
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand(sql_con))
                {                  
                    string TYPEind = metroComboBoxTYPEofPC.Text,
                           CPUind = metroComboBoxCPUsort.Text,
                           GPUind = metroComboBoxGPUsort.Text,
                           RAMind = metroComboBoxRAM.Text.Trim(' ', 'G', 'B');
                    SQLiteDataReader reader;
                    int CountID = 0;
                    #region CheckComboBOXES
                    //0000
                    if (TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && GPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = $"select id from PCdb where PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                    }
                    //0001
                    else if (RAMind != "<не выбрано>" && CPUind == "<не выбрано>" && GPUind == "<не выбрано>" && TYPEind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                    }
                    //0010
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }                      
                    }
                    //0011
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //0100
                    else if (GPUind == "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //0101
                    else if (GPUind == "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //0110
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //0111
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1000
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1001
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "'and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1010
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1011
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1100
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1101
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1110
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    //1111
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                        
                    }
                    #endregion
                    if (CountID == 0)
                    {
                        xuiCircleProgressBar1.Visible = false;
                        MessageBox.Show("Нет подходящих компудахтеров");
                        if (OBJects.Count > 0)
                        {
                            for (int j = OBJects.Count - 1; j > -1; j--)
                            {
                                ControlRemoveOBJ(j);
                                xuiCircleProgressBar1.percentage = 0;
                                xuiCircleProgressBar1.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        CreateObject(IDs);
                    }
                }
            }
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {     
            Application.Exit();
        }
        #endregion

        #region PriceBOXfunctions

        private void textBox_PRICE_OnValueChanged(object sender, EventArgs e)
        {
            if (textBox_PRICE.Text.Contains("-"))
            {
                isMINUS = true;
            }
            else
            {
                isMINUS = false;
            }
        }

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
                if (e.KeyChar == 45 && !isMINUS)
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
            isMINUS = true;
            textBox_PRICE.Text = string.Empty;
            textBox_PRICE.Text += ("$");
            textBox_PRICE.ForeColor = Color.Black;
        }
        #endregion

        #region Create&DeleteOBJECTS
        private void ControlRemoveOBJ(int j)
        {  
            this.Controls.Remove(OBJects[j]);
            OBJects[j].Dispose();
        }
        
        private async void CreateObject(List<int> IDs)
        {
            int Final = 100 / IDs.Count;
            int Y = 110;
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                this.Refresh();
                this.Enabled = false;
                sql_con.Open();
                xuiCircleProgressBar1.percentage = 0;
                if (OBJects.Count > 0)
                {
                    for (int j = OBJects.Count - 1; j > -1; j--)
                    {
                        ControlRemoveOBJ(j);
                    }
                    OBJects.Clear();
                }
                for (int j = 0; j < IDs.Count; j++)
                {
                    int P = 0;
                    await Task.Delay(60).ConfigureAwait(true);
                    using (sql_cmd = new SQLiteCommand($"SELECT * FROM PCdb WHERE id={IDs[j]}", sql_con))
                    {
                        xuiCircleProgressBar1.Enabled = true;
                        while (P != Final)
                        {
                            xuiCircleProgressBar1.Percentage++;
                            P++;
                        }
                        if (j == IDs.Count - 1 && xuiCircleProgressBar1.percentage != 100)
                        {
                            xuiCircleProgressBar1.percentage += (100 - xuiCircleProgressBar1.percentage);
                        }
                        #region FindCPU&GPU&RAMstringLABELS
                        int IDofPC = 0;
                        string TYPE = string.Empty;
                        string CPU = string.Empty;
                        string GPU = string.Empty;
                        int RAM = 0;
                        int COST = 0;
                        string PATHtoIMG = string.Empty;
                        using (var reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IDofPC = reader.GetInt32(0);
                                TYPE = reader.GetString(1);
                                COST = reader.GetInt32(2);
                                CPU = reader.GetString(3);
                                GPU = reader.GetString(4);
                                RAM = reader.GetInt32(5);
                                PATHtoIMG = reader.GetString(6);
                            }
                        }
                        Image IMG;
                        using (FileStream fs = new FileStream(PATHtoIMG, FileMode.Open))
                        {
                            IMG = Image.FromStream(fs);
                        }
                        PCinfo OBJ = new PCinfo(TYPE, IDofPC, CPU, GPU, RAM, COST, IMG) { isAdmin = false };
                        OBJects.Add(OBJ);
                        OBJ.Location = new Point(0, Y);
                        Y += 270;
                        this.Controls.Add(OBJ);
                        #endregion
                    }
                }
                this.Enabled = true;
                xuiCircleProgressBar1.Enabled = false;
                xuiCircleProgressBar1.Visible = false;
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

            List<int> IDs = new List<int>();
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand(sql_con))
                {
                    string TYPEind = metroComboBoxTYPEofPC.Text,
                           CPUind = metroComboBoxCPUsort.Text,
                           GPUind = metroComboBoxGPUsort.Text,
                           RAMind = metroComboBoxRAM.Text.Trim(' ', 'G', 'B');
                    SQLiteDataReader reader;
                    int CountID = 0;
                    #region CheckComboBOXES
                    //0000
                    if (TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && GPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = $"select id from PCdb where PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                    }
                    //0001
                    else if (RAMind != "<не выбрано>" && CPUind == "<не выбрано>" && GPUind == "<не выбрано>" && TYPEind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                    }
                    //0010
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }
                    }
                    //0011
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //0100
                    else if (GPUind == "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //0101
                    else if (GPUind == "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //0110
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //0111
                    else if (GPUind != "<не выбрано>" && TYPEind == "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where CPU='" + metroComboBoxCPUsort.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1000
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1001
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "'and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1010
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1011
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind == "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1100
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1101
                    else if (GPUind == "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1110
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind == "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and CPU='" + metroComboBoxCPUsort.Text + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    //1111
                    else if (GPUind != "<не выбрано>" && TYPEind != "<не выбрано>" && CPUind != "<не выбрано>" && RAMind != "<не выбрано>")
                    {
                        sql_cmd.CommandText = "select id from PCdb where typeOfPC='" + metroComboBoxTYPEofPC.Text + "' and GPU='" + metroComboBoxGPUsort.Text + "' and CPU='" + metroComboBoxCPUsort.Text + "' and RAM='" + RAMind + $"' and PRICE BETWEEN {PriceReaderINT[0]} AND {PriceReaderINT[1]} ORDER BY PRICE DESC;";
                        reader = sql_cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            IDs.Add(reader.GetInt32(0));
                            CountID++;
                        }

                    }
                    #endregion
                    if (CountID == 0)
                    {
                        xuiCircleProgressBar1.Visible = false;
                        MetroMessageBox.Show(this, "NO PC MATCHES", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        CreateObject(IDs);
                    }
                }
            }
        }

        private void button_backToLoginForm_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "ARE YOU SURE THAT YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                //Close();
                //formLogIn logIn = new formLogIn();
                //logIn.Show();
            }
        }

        private void formUSER_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButtonHIDE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

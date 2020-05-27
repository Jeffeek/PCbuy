using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using MetroFramework;
using MetroFramework.Forms;
using TRPO_Project.Properties;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using MetroFramework.Controls;
using Guna.UI.WinForms;

namespace TRPO_Project
{
    public partial class AdminPanelForm : MetroForm, IThemeChange
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter dataAdapter;
        private int userID;
        int LASTid = 0;
        private Point lastPoint;
        #endregion

        #region constructor
        public AdminPanelForm(int UserID)
        {
            InitializeComponent();
            userID = UserID;
            ReadThemeAsync().Wait();
            FormTransition.ShowAsyc(this);
        }

        #endregion

        #region FillGrids
        private void FillPcDataGrid()
        {
            using (dataAdapter = new SQLiteDataAdapter("SELECT * FROM PCdb", sql_con))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                PCDataGrid.DataSource = table;
            }
        }

        private void FillUsersDataGrid()
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM LOGin", sql_con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                UsersDataGrid.DataSource = table;
            }
        }

        private void FillInquiryDataGrid()
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Orders", sql_con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                InquiryDataGrid.DataSource = table;
            }
        }

        #endregion

        #region ButtonsClick
        private void bunifuImageButtonAPPLYnewPROD_Click(object sender, EventArgs e)
        {
            string NEWtypeOFpc = bunifuMetroTextboxADDprodType.Text;
            string NEWcpu = bunifuMetroTextboxADDprodCPU.Text;
            string NEWgpu = bunifuMetroTextboxADDprodGPU.Text;
            string NEWram = bunifuMetroTextboxADDprodRAM.Text;
            string NEWprice = bunifuMetroTextboxADDprodPRICE.Text;
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($@"INSERT INTO PCdb (typeOfPC, CPU, GPU, RAM, PRICE, IMAGEpc) VALUES('{NEWtypeOFpc}', '{NEWcpu}', '{NEWgpu}', {NEWram}, {NEWprice}, 'PCsIMAGES\id{LASTid}.png')", sql_con))
                {
                    sql_cmd.ExecuteNonQuery();
                }
                using (FileStream FS = new FileStream(openFileDialogADDproduct.FileName, FileMode.Open))
                {
                    bunifuImageButtonNEWpic.Image = Image.FromStream(FS);
                }
                File.Copy(openFileDialogADDproduct.FileName, $@"PCsIMAGES\id{LASTid}.png");
                FillPcDataGrid();
                comboBoxSELECT_id_product.AddItem(Convert.ToString(LASTid));
            }
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e) => Close();

        private void bunifuImageButtonNEWpic_Click(object sender, EventArgs e)
        {
            var result = openFileDialogADDproduct.ShowDialog();
            if (result == DialogResult.OK && bunifuMetroTextboxADDprodCPU.Text.Length > 0 && bunifuMetroTextboxADDprodGPU.Text.Length > 0 && bunifuMetroTextboxADDprodRAM.Text.Length > 0 && bunifuMetroTextboxADDprodType.Text.Length > 0)
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand("SELECT MAX(id) FROM PCdb", sql_con))
                    {
                        LASTid = int.Parse(sql_cmd.ExecuteScalar().ToString());
                        LASTid++;
                    }
                }
                bunifuImageButtonAPPLYnewPROD.Enabled = true;
                bunifuImageButtonAPPLYnewPROD.Image = Resources.ok;
                bunifuImageButtonAPPLYnewPROD.BackColor = Color.LightGreen;
                using (FileStream FS = new FileStream(openFileDialogADDproduct.FileName, FileMode.Open))
                {
                    bunifuImageButtonNEWpic.Image = Image.FromStream(FS);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "SOMETHING WENT WRONG, BRO!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuImageButtonAPPLYnewPROD.Enabled = false;
                bunifuImageButtonAPPLYnewPROD.Image = Resources.X;
                bunifuImageButtonAPPLYnewPROD.BackColor = Color.SlateGray;
            }
        }

        private void bunifuImageButtonAPPLYchanges_Click(object sender, EventArgs e)
        {
            if (comboBoxCHANGEVALUE_byid_product.selectedValue != "IMAGE")
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand($"UPDATE PCdb SET {comboBoxCHANGEVALUE_byid_product.selectedValue}='{gunaLineTextBoxNEWvalue.Text}' WHERE id={bunifuCustomDataGridVIEWinfoAboutONEprod[0, 0].Value}", sql_con))
                    {
                        sql_cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                File.Replace(openFileDialogCHANGE_PIC.FileName, (string)bunifuCustomDataGridVIEWinfoAboutONEprod[6, 0].Value, openFileDialogCHANGE_PIC.FileName + ".JOPA");
                File.Delete(openFileDialogCHANGE_PIC.FileName + ".JOPA");
            }
            gunaLineTextBoxNEWvalue.Text = string.Empty;
            comboBoxSELECT_id_product_onItemSelected(null, null);
            MetroMessageBox.Show(this, "INFORMATION WAS CHANGED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuImageButtonNEWpcIMG_Click(object sender, EventArgs e)
        {
            var result = openFileDialogCHANGE_PIC.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (FileStream FS = new FileStream(openFileDialogCHANGE_PIC.FileName, FileMode.OpenOrCreate))
                {
                    bunifuImageButtonNEWpcIMG.Image = Image.FromStream(FS);
                }
            }
        }

        private void bunifuImageButton_DeleteProd_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "DELETE?", "ARE YOU SURE THAT YOU WANT TO REMOVE THIS PRODUCT FROM DATABASE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand($"DELETE FROM PCdb WHERE id={comboBoxSELECT_id_product.selectedValue}", sql_con))
                    {
                        sql_cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "SUCCESS!", "THE PRODUCT WAS DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rEFRESHToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        private void buttonShowGraphic_Click(object sender, EventArgs e)
        {
            GraphicForm graphicFORM = new GraphicForm();
            graphicFORM.Show(this);
        }

        private void bunifuImageButtonHIDE_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion

        #region KeyPress
        private void bunifuMetroTextboxADDprodPRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuMetroTextboxADDprodRAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaLineTextBoxNEWvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxCHANGEVALUE_byid_product.selectedValue == "RAM")
            {
                if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || gunaLineTextBoxNEWvalue.Text.Length > 4)
                {
                    e.Handled = true;
                }
            }
        }

        private void gunaLineTextBoxNEWvalue_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBoxNEWvalue.Text.Length > 0)
            {
                bunifuImageButtonAPPLYchanges.Enabled = true;
                bunifuImageButtonAPPLYchanges.Image = Resources.ok;
                bunifuImageButtonAPPLYchanges.BackColor = Color.SeaGreen;
            }
            else
            {
                bunifuImageButtonAPPLYchanges.Enabled = false;
                bunifuImageButtonAPPLYchanges.Image = Resources.X;
                bunifuImageButtonAPPLYchanges.BackColor = Color.Gray;
            }
        }

        #endregion

        #region ComboBoxMethods

        private void FillIdInComboBoxes()
        {
            comboBoxSELECT_id_product.Clear();
            using (sql_cmd = new SQLiteCommand("SELECT id FROM PCdb", sql_con))
            {
                using (SQLiteDataReader reader = sql_cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxSELECT_id_product.AddItem(Convert.ToString(reader.GetInt32(0)));
                    }
                }
            }
        }
        private void comboBoxSELECT_id_product_onItemSelected(object sender, EventArgs e)
        {
            bunifuImageButton_DeleteProd.Enabled = true;
            comboBoxCHANGEVALUE_byid_product.Enabled = true;
            if (bunifuCustomDataGridVIEWinfoAboutONEprod.Rows.Count == 0)
            {
                bunifuCustomDataGridVIEWinfoAboutONEprod.Rows.Add();
            }
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM PCdb WHERE id={comboBoxSELECT_id_product.selectedValue}", sql_con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                bunifuCustomDataGridVIEWinfoAboutONEprod.DataSource = table;
                using (FileStream FS = new FileStream((string)bunifuCustomDataGridVIEWinfoAboutONEprod[6,0].Value, FileMode.Open))
                {
                    gunaCirclePictureBoxPC_ONE.Image = Image.FromStream(FS);
                }
            }
        }
        private void comboBoxCHANGEVALUE_byid_product_onItemSelected(object sender, EventArgs e)
        {
            gunaLineTextBoxNEWvalue.Enabled = true;
            if (comboBoxCHANGEVALUE_byid_product.selectedValue == "IMAGE")
            {
                gunaLabelNEWvalue.Visible = false;
                gunaLineTextBoxNEWvalue.Visible = false;
                bunifuImageButtonNEWpcIMG.Visible = true;
                gunaLabelNEWpcPIC.Visible = true;
                using (FileStream FS = new FileStream(Convert.ToString(bunifuCustomDataGridVIEWinfoAboutONEprod[6, 0].Value), FileMode.OpenOrCreate))
                {
                    bunifuImageButtonNEWpcIMG.Image = Image.FromStream(FS);
                }
            }
            else
            {
                gunaLabelNEWvalue.Visible = true;
                gunaLineTextBoxNEWvalue.Visible = true;
                bunifuImageButtonNEWpcIMG.Visible = false;
                gunaLabelNEWpcPIC.Visible = false;
            }
        }

        #endregion

        #region CellMouseClick

        private void PCDataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (FileStream FR = new FileStream(Convert.ToString(PCDataGrid[6, e.RowIndex].Value), FileMode.Open))
                {
                    gunaCirclePictureBoxPC.Image = Image.FromStream(FR);
                }
                if (PCDataGrid[3, e.RowIndex].Value.ToString().StartsWith("Intel"))
                {
                    gunaCirclePictureBoxGPU.Image = Resources.intel;
                }
                else if (PCDataGrid[3, e.RowIndex].Value.ToString().StartsWith("AMD"))
                {
                    gunaCirclePictureBoxGPU.Image = Resources.amd;
                }

                if (PCDataGrid[4, e.RowIndex].Value.ToString().StartsWith("Radeon"))
                {
                    gunaCirclePictureBoxCPU.Image = Resources.AMD_Radeon;
                }
                else if (PCDataGrid[4, e.RowIndex].Value.ToString().StartsWith("NVIDIA"))
                {
                    gunaCirclePictureBoxCPU.Image = Resources.nvidia;
                }
                else if (PCDataGrid[4, e.RowIndex].Value.ToString().StartsWith("NONE"))
                {
                    gunaCirclePictureBoxCPU.Image = Resources.delete2;
                }

            }
        }

        private void UsersDataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (var IMGstream = new FileStream(Convert.ToString(UsersDataGrid[4, e.RowIndex].Value), FileMode.Open))
                    CirclePictureBoxUSER.Image = Image.FromStream(IMGstream);
            }
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

        private void bunifuCustomDataGridVIEWinfoAboutONEprod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 1:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 0;
                        break;
                    }
                case 2:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 1;
                        break;
                    }
                case 3:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 2;
                        break;
                    }
                case 4:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 3;
                        break;
                    }
                case 5:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 4;
                        break;
                    }
                case 6:
                    {
                        comboBoxCHANGEVALUE_byid_product.selectedIndex = 5;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                FillPcDataGrid();
                FillIdInComboBoxes();
                FillUsersDataGrid();
                FillInquiryDataGrid();
            }
            comboBoxSELECT_id_product.selectedIndex = 0;
        }
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\DataBases\\TRPO.db"))
            {
                sql_con.Open();
                FillUsersDataGrid();
                FillInquiryDataGrid();
                FillPcDataGrid();
                FillIdInComboBoxes();
            }
        }
        


        #region ThemeChange
        public void ChangeMetroControls(ProgramTheme OBJ)
        {
            Theme = OBJ.Theme == ETheme.Light ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
            tabControlAdmin.Theme = OBJ.Theme == ETheme.Light ? MetroThemeStyle.Light : MetroThemeStyle.Dark;

            foreach (var tab in tabControlAdmin.TabPages.OfType<MetroTabPage>())
            {
                tab.BackColor = OBJ.Theme == ETheme.Light ? Color.White : Color.Black;
            }
        }

        public void ChangeNonMetroControls(ProgramTheme OBJ)
        {
            bunifuCustomDataGridVIEWinfoAboutONEprod.BackgroundColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17,17,17);
            gunaLineTextBoxNEWvalue.BackColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            UsersDataGrid.BackgroundColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            PCDataGrid.BackgroundColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            InquiryDataGrid.BackgroundColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            buttonShowGraphic.BackColor = OBJ.Theme == ETheme.Light ? Color.White : Color.Black;
            bunifuImageButtonNEWpic.BackColor = OBJ.Theme == ETheme.Light ? Color.LightGray : Color.DimGray;

            foreach(var ctrl in tabControlAdmin.TabPages[1].Controls.OfType<GunaLabel>())
            {
                ctrl.BackColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            }

            foreach (var ctrl in tabControlAdmin.TabPages[3].Controls.OfType<GunaCirclePictureBox>())
            {
                ctrl.BaseColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            }


            gunaLineTextBoxNEWvalue.BackColor = OBJ.Theme == ETheme.Light ? Color.WhiteSmoke : Color.FromArgb(17, 17, 17);
            tabPage1.BackColor = OBJ.Theme == ETheme.Light ? Color.White : Color.Black;
        }

        public async Task ReadThemeAsync()
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

    }
}

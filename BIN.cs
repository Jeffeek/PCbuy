using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Bunifu.Framework.UI;
using TRPO_Project.Properties;
using Guna.UI.WinForms;
using Guna.UI.Lib;
using System.IO;

namespace TRPO_Project
{
    public partial class BIN : MetroForm
    {
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private bool IsAdmin;
        private int userID;
        private int CounterForDeleting;
        private List<int> IDsOfPCinBIN = new List<int>();

        public BIN(bool isAdmin, int userID)
        {
            InitializeComponent();
            FormStartTransition.ShowAsyc(this);
            IsAdmin = isAdmin;
            this.userID = userID;
            metroLabelID.Text += userID;
            if (isAdmin)
                IDsOfPCinBIN = formADMIN.BINid.ToList();
            else
                IDsOfPCinBIN = formUSER.BINid.ToList();
            CreateListOfProducts();

            if (IDsOfPCinBIN.Count > 0)
            {
                imageButtonCONFIRMorder.BackColor = Color.SeaGreen;
                imageButtonCONFIRMorder.Enabled = true;
                imageButtonCONFIRMorder.Image = Resources.ok;
            }
        }

        private void CreateListOfProducts()
        {
            for (int i = 0; i < IDsOfPCinBIN.Count; i++)
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
                {
                    sql_con.Open();
                    sql_cmd = new SQLiteCommand(sql_con);
                    string CPU, GPU, RAM, pathOfPCIMG, COST;
                    Image IMG;
                    GunaLabel CPU_label = new GunaLabel();
                    GunaLabel GPU_label = new GunaLabel();
                    GunaLabel RAM_label = new GunaLabel();
                    GunaLabel COST_label = new GunaLabel();
                    BunifuImageButton IMGpb = new BunifuImageButton();
                    BunifuImageButton deleteProductButton = new BunifuImageButton();
                    tabControlPRODUCTs.TabPages.Add($"PC: {i + 1}");
                    tabControlPRODUCTs.TabPages[i].Name = Convert.ToString(IDsOfPCinBIN[i]);
                    tabControlPRODUCTs.TabPages[i].BackColor = Color.FromArgb(171717);


                    #region takeINFaboutID              
                    sql_cmd.CommandText = $"SELECT CPU from PCdb where id={IDsOfPCinBIN[i]};";
                    CPU = sql_cmd.ExecuteScalar().ToString();
                    CPU_label.Text = "CPU: " + CPU;
                    CPU_label.Location = new Point(10, 50);
                    CPU_label.Visible = true;
                    CPU_label.Size = new Size(200, 15);
                    CPU_label.ForeColor = Color.DarkCyan;
                    CPU_label.Font = new Font("Unispace", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    tabControlPRODUCTs.TabPages[i].Controls.Add(CPU_label);

                    sql_cmd.CommandText = $"SELECT GPU from PCdb where id={IDsOfPCinBIN[i]};";
                    GPU = sql_cmd.ExecuteScalar().ToString();
                    GPU_label.Text = "GPU: " + GPU;
                    GPU_label.Location = new Point(10, 75);
                    GPU_label.Visible = true;
                    GPU_label.Size = new Size(200, 15);
                    GPU_label.ForeColor = Color.DarkCyan;
                    GPU_label.Font = new Font("Unispace", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    tabControlPRODUCTs.TabPages[i].Controls.Add(GPU_label);

                    sql_cmd.CommandText = $"SELECT RAM from PCdb where id={IDsOfPCinBIN[i]};";
                    RAM = sql_cmd.ExecuteScalar().ToString();
                    RAM_label.Text = "RAM: " + RAM + "GB";
                    RAM_label.Location = new Point(10, 100);
                    RAM_label.Visible = true;
                    RAM_label.Size = new Size(200, 15);
                    RAM_label.ForeColor = Color.DarkCyan;
                    RAM_label.Font = new Font("Unispace", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    tabControlPRODUCTs.TabPages[i].Controls.Add(RAM_label);

                    sql_cmd.CommandText = $"SELECT PRICE from PCdb where id={IDsOfPCinBIN[i]};";
                    COST = sql_cmd.ExecuteScalar().ToString();
                    COST_label.Text = "PRICE: " + COST + "$";
                    COST_label.Location = new Point(10, 125);
                    COST_label.Visible = true;
                    COST_label.Size = new Size(200, 15);
                    COST_label.ForeColor = Color.OrangeRed;
                    COST_label.Font = new Font("Unispace", 8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    tabControlPRODUCTs.TabPages[i].Controls.Add(COST_label);

                    sql_cmd.CommandText = $"SELECT IMAGEpc from PCdb where id={IDsOfPCinBIN[i]};";
                    pathOfPCIMG = sql_cmd.ExecuteScalar().ToString();
                    IMG = new Bitmap(@pathOfPCIMG);
                    IMGpb.Image = IMG;
                    IMGpb.Visible = true;
                    IMGpb.Size = new Size(190, 173);
                    IMGpb.SizeMode = PictureBoxSizeMode.StretchImage;
                    IMGpb.Location = new Point(245, 14);
                    IMGpb.Zoom = 5;
                    tabControlPRODUCTs.TabPages[i].Controls.Add(IMGpb);

                    deleteProductButton.Image = Resources.trash;
                    deleteProductButton.Location = new Point(tabControlPRODUCTs.Location.X, 10);
                    deleteProductButton.SizeMode = PictureBoxSizeMode.StretchImage;
                    deleteProductButton.Size = new Size(30, 30);
                    deleteProductButton.BackColor = Color.Transparent;
                    tabControlPRODUCTs.TabPages[i].Controls.Add(deleteProductButton);


                    deleteProductButton.Click += (s, e) =>
                    {
                        if (IDsOfPCinBIN.Count > 0)
                        {
                            IDsOfPCinBIN.Remove(int.Parse(tabControlPRODUCTs.SelectedTab.Name));
                        }
                        tabControlPRODUCTs.TabPages.Remove(tabControlPRODUCTs.SelectedTab);
                        if (tabControlPRODUCTs.TabCount == 0)
                        {
                            imageButtonCONFIRMorder.BackColor = Color.SlateGray;
                            imageButtonCONFIRMorder.Enabled = false;
                            imageButtonCONFIRMorder.Image = Resources.X;
                        }
                    };
                    #endregion
                }
            }
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                formADMIN.BINid = IDsOfPCinBIN;
            }
            else
            {
                formUSER.BINid = IDsOfPCinBIN;
            }
            this.Close();
        }

        private void imageButtonCONFIRMorder_Click(object sender, EventArgs e)
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
            {
                sql_con.Open();
                string IDs = string.Empty;
                int SUMofOrder = 0;
                foreach (var ID in IDsOfPCinBIN)
                {
                    IDs += Convert.ToString(ID) + " | ";
                    using (sql_cmd = new SQLiteCommand($"SELECT PRICE FROM PCdb WHERE id={ID}", sql_con))
                    {
                        SUMofOrder += Convert.ToInt32(sql_cmd.ExecuteScalar().ToString());
                    }
                }
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand($"INSERT INTO Orders(userID, pcIDs, PRICEall, Date) VALUES({userID}, '{IDs}', {SUMofOrder},'{DateTime.Now}')", sql_con))
                    {
                        sql_cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "YOUR ORDER WAS CONFIRMED!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabControlPRODUCTs.TabPages.Clear();
                        if (IsAdmin)
                        {
                            IDsOfPCinBIN.Clear();
                            formADMIN.BINid.Clear();
                        }
                        else
                        {
                            IDsOfPCinBIN.Clear();
                            formUSER.BINid.Clear();
                        }
                    }
                }
            }
            Close();
        }
    }
}

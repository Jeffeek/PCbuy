using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using TRPO_Project.Properties;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Threading;
using XanderUI.Designers;
using XanderUI;

namespace TRPO_Project
{
    public partial class formProfile : MetroForm
    {
        #region variables
        private bool isPASSvisible = false;
        private int userID;
        private formUSER userU;
        private formADMIN userA;
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private bool isADMIN;

        
        #endregion

        #region Constructor
        public formProfile(formUSER formF,int ID)
        {
            InitializeComponent();
            userID = ID;
            userU = formF;
            isADMIN = false;
            bunifuMaterialTextboxEMAIL.Text = takeAlogin();
            bunifuMaterialTextboxPASS.Text = takeApassword();          
            takeANimg();
        }

        public formProfile(formADMIN formF, int ID)
        {
            InitializeComponent();
            userID = ID;
            userA = formF;
            isADMIN = true;
            linkLabelDELETEprofile.Visible = false;
            bunifuMaterialTextboxEMAIL.Text = takeAlogin();
            bunifuMaterialTextboxPASS.Text = takeApassword();
            takeANimg();
        }
        #endregion

        #region RequestForEmail&Pass
        private string takeAlogin()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
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
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT password from LOGin where id={userID}", sql_con))
                {
                    string password = sql_cmd.ExecuteScalar().ToString();
                    return password;
                }
            }
        }
        private void takeANimg()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT ProfilePicture from LOGin where id={userID}", sql_con))
                {
                    using (FileStream IMUR = new FileStream(sql_cmd.ExecuteScalar().ToString(), FileMode.Open))
                    {
                        pictureBoxPROFILE.Image = Image.FromStream(IMUR);
                    }
                }
            }
        }
        #endregion

        #region Link&PicClicked
        private void pictureBoxCHANGEpassVisibility_Click(object sender, EventArgs e)
        {
            if (isPASSvisible)
            {
                pictureBoxCHANGEpassVisibility.Image = Resources.eye_hide;
                isPASSvisible = false;
                bunifuMaterialTextboxPASS.isPassword = true;
            }
            else
            {
                pictureBoxCHANGEpassVisibility.Image = Resources.eye_show;
                isPASSvisible = true;
                bunifuMaterialTextboxPASS.isPassword = false;
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
                        File.Delete($@"USERsPIC\id{userID}_USER.png");
                        File.Copy(fileName, $@"USERsPIC\id{userID}_USER.png");
                        userU.SetNewProfilePicture(IMG);
                    }
                    else
                    {
                        File.Delete($@"USERsPIC\id{userID}_ADMIN.png");
                        File.Copy(fileName, $@"USERsPIC\id{userID}_ADMIN.png");
                        userA.SetNewProfilePicture(IMG);
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
                    using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
                    {
                        sql_con.Open();
                        using (sql_cmd = new SQLiteCommand($"DELETE FROM LOGin WHERE id={userID}", sql_con))
                        {
                            sql_cmd.ExecuteNonQuery();
                            File.Delete($"USERsPIC\\id{userID}_USER.png");
                            MetroMessageBox.Show(this, "SUCCESS! YOUR PROFILE WAS DELETED", "DELETE PROFILE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                    }
                }
            }
        }
        #endregion

        #region FormClosed
        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"USERsPIC\temp\tempik.png"))
            {
                File.Delete(@"USERsPIC\temp\tempik.png");
            }
            this.Close();
        }
        #endregion

        #region CHANGE PASS

        #region textBOXleave 

        private void bunifuMetroTextboxNewPassFirst_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextboxNewPassFirst.Text.Length < 6)
            {
                bunifuMetroTextboxNewPassFirst.Text = "NEW PASSWORD";
                MetroMessageBox.Show(this, "YOUR NEW PASSWORD IS INCORRECT! MIN LENGHT IS 6");
                bunifuMetroTextboxNewPassFirst.isPassword = false;
                bunifuMetroTextboxNewPassFirst.ForeColor = Color.LightGray;
            }
        }
        private void bunifuMetroTextboxNewPassSecond_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextboxNewPassSecond.Text.Length == 0)
            {
                bunifuMetroTextboxNewPassSecond.isPassword = false;
                bunifuMetroTextboxNewPassSecond.Text = "REPEAT YOUR PASSWORD";
                bunifuMetroTextboxNewPassSecond.ForeColor = Color.LightGray;
            }
        }
        #endregion

        #region textBOXenter 
        private void bunifuMetroTextboxNewPassFirst_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextboxNewPassFirst.Text = "";
            bunifuMetroTextboxNewPassFirst.isPassword = true;
        }
        private void bunifuMetroTextboxNewPassSecond_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextboxNewPassSecond.Text = "";
            bunifuMetroTextboxNewPassSecond.isPassword = true;
        }

        #endregion

        #region textBOXValueChange 

        private void bunifuMetroTextboxNewPassFirst_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMetroTextboxNewPassFirst.Text.Length < 6)
            {
                bunifuMetroTextboxNewPassFirst.ForeColor = Color.Red;
            }
            else if (bunifuMetroTextboxNewPassFirst.Text.Length > 5)
            {
                bunifuMetroTextboxNewPassFirst.ForeColor = Color.Green;
            }
        }

        private void bunifuMetroTextboxNewPassSecond_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMetroTextboxNewPassSecond.Text == bunifuMetroTextboxNewPassFirst.Text)
            {
                bunifuMetroTextboxNewPassSecond.ForeColor = Color.Green;
                bunifuImageButtonApplyNewPassword.Enabled = true;
            }
            else
            {
                bunifuMetroTextboxNewPassSecond.ForeColor = Color.Red;
                bunifuImageButtonApplyNewPassword.Enabled = false;
            }
        }
        #endregion

        #region ApplyButton 
        private void bunifuImageButtonApplyNewPassword_Click(object sender, EventArgs e)
        {
            string oldPASS;
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT password FROM LOGin WHERE id={userID}", sql_con))
                {
                    oldPASS = sql_cmd.ExecuteScalar().ToString();
                }
            }


            if (bunifuMetroTextboxNewPassFirst.Text == bunifuMetroTextboxNewPassSecond.Text && bunifuMetroTextboxNewPassSecond.Text.Length > 5)
            {
                if (oldPASS == bunifuMetroTextboxNewPassFirst.Text)
                {
                    MetroMessageBox.Show(this, "YOU CAN'T UPDATE YOUR PASS BY THIS WAY!", "SMTH WENT WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bunifuMetroTextboxNewPassFirst.Text = "NEW PASSWORD";
                    bunifuMetroTextboxNewPassSecond.Text = "REPEAT YOUR PASSWORD";
                    bunifuMetroTextboxNewPassFirst.isPassword = false;
                    bunifuMetroTextboxNewPassSecond.isPassword = false;
                    bunifuMetroTextboxNewPassFirst.ForeColor = Color.LightGray;
                    bunifuMetroTextboxNewPassSecond.ForeColor = Color.LightGray;
                }
                else
                {
                    using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
                    {
                        sql_con.Open();
                        using (sql_cmd = new SQLiteCommand($"UPDATE LOGin SET password='{bunifuMetroTextboxNewPassFirst.Text}' WHERE id={userID}", sql_con))
                        {
                            sql_cmd.ExecuteNonQuery();
                            MetroMessageBox.Show(this, "YOUR PASSWORD WAS UPDATED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bunifuMaterialTextboxPASS.Text = bunifuMetroTextboxNewPassFirst.Text;
                        }
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}

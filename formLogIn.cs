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
using System.Resources;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.Threading;
using Bunifu.Framework.UI;
using Bunifu.Framework;
using Bunifu.Framework.Lib;
using Bunifu;
using BunifuAnimatorNS;
using TRPO_Project.Properties;

namespace TRPO_Project
{
    public partial class formLogIn : MetroForm
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private string LOGIN;
        internal static bool isADMIN = new bool();
        private string PASS;
        #endregion

        #region constructors
        public formLogIn()
        {
            InitializeComponent();
            ImageButtonAPPLYlogin.Enabled = false;
            FormStartTransition.ShowAsyc(this);
            //TODO: убери автолог
            textboxEMAILlogin.text = "mishamine26@gmail.com";
            textboxPASSlogin.text = "123456";
        }
        //возврат в окно
        public formLogIn(string emailPASTE)
        {
            InitializeComponent();
            textboxEMAILlogin.text = emailPASTE;
            ImageButtonAPPLYlogin.Enabled = false;
        }
        #endregion

        #region CHECKemail&passCORRECTON&isADMIN_FP

        private bool CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;
            }
            if (email.IndexOf(".") == -1 || (email.Length - 3) < email.IndexOf("."))
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;

            }
            if ((email.IndexOf(",") >= 0) || (email.IndexOf(";") >= 0) || (email.IndexOf(" ") >= 0))
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;

            }
            int dog = email.IndexOf("@");
            if (dog == -1)
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;

            }
            if ((dog < 1) || (dog > email.Length - 5))
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;

            }
            if ((email.ElementAt(dog - 1) == '.') || (email.ElementAt(dog + 1) == '.'))
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                return false;
            }
            else
            {
                if (textboxPASSlogin.text.Length > 5)
                {
                    ImageButtonAPPLYlogin.Enabled = true;
                }
                textboxEMAILlogin.ForeColor = Color.LimeGreen;
                return true;
            }
        }
        private void CheckPASS()
        {
            if (textboxPASSlogin.text.Length > 5 && textboxPASSlogin.text.Length < 25)
            {
                if (textboxPASSlogin.text.Length > 5)
                {
                    ImageButtonAPPLYlogin.Enabled = true;
                }
                textboxPASSlogin.ForeColor = Color.LimeGreen;
            }
            else
            {
                ImageButtonAPPLYlogin.Enabled = false;
                textboxPASSlogin.ForeColor = Color.Crimson;
            }

        }
        private bool CheckFORadmin()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                using (sql_cmd = new SQLiteCommand($"SELECT isAdmin FROM LOGin WHERE email='{LOGIN}';", sql_con))
                {
                    sql_con.Open();
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    reader.Read();
                    int isAd = reader.GetInt32(0);
                    if (isAd == 0)
                    {
                        reader.Close();
                        return false; //если юзер
                    }
                    else
                    {
                        reader.Close();
                        return true; //если админ
                    }
                }
            }
        }
        private int GetUserID()
        {
            using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand("SELECT id FROM LOGin WHERE email='" + LOGIN + "';", sql_con))
                {
                    int n = Convert.ToInt32(sql_cmd.ExecuteScalar().ToString());
                    sql_con.Close();
                    return n;
                }
            }
        }
        #endregion

        #region textBOXchanges
        private void bunifuTextboxEMAIL_OnTextChange(object sender, EventArgs e)
        {
            string email = textboxEMAILlogin.text;
            CheckEmail(email);
        }
        private void bunifuTextboxPASS_OnTextChange(object sender, EventArgs e)
        {
            CheckPASS();
        }
        private void bunifuImageButtonAPPLYlogin_EnabledChanged(object sender, EventArgs e)
        {
            if (CheckEmail(textboxEMAILlogin.text) && textboxPASSlogin.text.Length > 5)
            {
                ImageButtonAPPLYlogin.Image = Properties.Resources.ok;
                ImageButtonAPPLYlogin.BackColor = Color.SeaGreen;
            }
            else
            {
                ImageButtonAPPLYlogin.Image = Properties.Resources.X;
                ImageButtonAPPLYlogin.BackColor = Color.Gray;
            }
        }
        #endregion

        #region labelLINKclick
        ////при нажатии на ЗАБЫЛ ПАРОЛЬ
        private void metroLinkRegister_Click(object sender, EventArgs e)
        {
            if (xuiSlidingPanelREGISTRATION.Collapsed)
            {
                xuiSlidingPanelREGISTRATION.Visible = true;
            }
            else
            {
                xuiSlidingPanelREGISTRATION.Visible = false;
            }
        }
        #endregion

        #region buttonLOGINclick
        private void bunifuImageButtonAPPLYlogin_Click(object sender, EventArgs e)
        {
            buttonAnimate.ColorAnimate(ImageButtonAPPLYlogin, Color.MediumSeaGreen, XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 1);
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
            {
                string email = textboxEMAILlogin.text, password = textboxPASSlogin.text;
                LOGIN = email;
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand("SELECT id FROM LOGin WHERE email='" + email + "' and password='" + password + "';", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        isADMIN = CheckFORadmin();
                        MetroMessageBox.Show(this, "WELL DONE! LOGGED IN", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (isADMIN)
                        {
                            formADMIN MainForm = new formADMIN(GetUserID());
                            MainForm.Show();
                        }
                        else
                        {
                            formUSER MainForm = new formUSER(GetUserID());
                            MainForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "LOGIN or PASSWORD is incorrect", "UNSUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Load&CloseFORM
        private void formLogIn_Load(object sender, EventArgs e)
        {
            this.textboxPASSlogin._TextBox.PasswordChar = '*';
            this.xuiSlidingPanelForgotPass.CollapseControl = this.bunifuImageButtonBACK;
            this.xuiSlidingPanelREGISTRATION.CollapseControl = this.bunifuImageButtonBACK_Reg;
        }

        private void bunifuImageButtonEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Forgost Password Slider

        #region CHECKmailINbd
        private bool CheckEmailForgotPassword(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(email))
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;
            }
            if (email.IndexOf(".") == -1 || (email.Length - 3) < email.IndexOf("."))
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                return false;
            }
            if ((email.IndexOf(",") >= 0) || (email.IndexOf(";") >= 0) || (email.IndexOf(" ") >= 0))
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;
            }
            int dog = email.IndexOf("@");
            if (dog == -1)
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;

            }
            if ((dog < 1) || (dog > email.Length - 5))
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;

            }
            if ((email.ElementAt(dog - 1) == '.') || (email.ElementAt(dog + 1) == '.'))
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;

            }
            if (email.Length >= 30)
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(255, 0, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
                return false;
            }
            else
            {
                textBox_ForgotPass.ForeColor = Color.FromArgb(0, 255, 0);
                bunifuImageButtonAPPLYforgotPassword.Enabled = true;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.ok;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SeaGreen;
                return true;
            }
        }

        private void bunifuImageButtonAPPLYforgotPassword_Click(object sender, EventArgs e)
        {
            string checkEMAIL = textBox_ForgotPass.Text;
            try
            {
                using (sql_con = new SQLiteConnection("TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand("SELECT password FROM LOGin WHERE email='" + checkEMAIL + "';", sql_con))
                    {
                        using (SQLiteDataReader reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.HasRows)
                                {
                                    MetroMessageBox.Show(this, "Found your account! \nPassword: " + reader.GetString(0), "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    textBox_ForgotPass.Text = string.Empty;
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "DO NOT find your account!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox_ForgotPass.Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //поиск по базе
        private void textBox_ForgotPass_TextChanged(object sender, EventArgs e)
        {
            string EMAIL = textBox_ForgotPass.Text;
            CheckEmailForgotPassword(EMAIL);
        }

        #endregion

        #endregion

        #region Registration Slider
        private bool isPASScorrect = false;
        private bool isRepeatPASScorrect = false;
        private bool isLOGINcorrect = false;
        #region CHECKcorrectionEMAIL&password
        private bool CheckEmailRegistration(string email)
        {
            if (email.Length == 0)
            {
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                isLOGINcorrect = false;
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;
            }
            if (email.IndexOf(".") == -1 || (email.Length - 3) < email.IndexOf("."))
            {
                isLOGINcorrect = false;
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;
            }
            if ((email.IndexOf(",") >= 0) || (email.IndexOf(";") >= 0) || (email.IndexOf(" ") >= 0))
            {
                isLOGINcorrect = false;
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;

            }
            int dog = email.IndexOf("@");
            if (dog == -1)
            {
                isLOGINcorrect = false;
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;

            }
            if ((dog < 1) || (dog > email.Length - 5))
            {
                isLOGINcorrect = false;
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;

            }
            if ((email.ElementAt(dog - 1) == '.') || (email.ElementAt(dog + 1) == '.'))
            {
                isLOGINcorrect = false;
                textBoxEMAIL_reg.ForeColor = Color.FromArgb(255, 0, 0);
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
                return false;

            }
            else
            {
                isLOGINcorrect = true;
                textBoxEMAIL_reg.ForeColor = Color.SpringGreen;
                if (isPASScorrect && isRepeatPASScorrect)
                {
                    ButtonREGISTER.Image = Resources.ok;
                    ButtonREGISTER.BackColor = Color.SeaGreen;
                    ButtonREGISTER.Enabled = true;
                }
                return true;
            }
        }

        private void textBoxEMAIL_TextChanged(object sender, EventArgs e)
        {
            string e_mail = textBoxEMAIL_reg.Text;
            CheckEmailRegistration(e_mail);
        }
        private void textBoxREPEAT_PASS_TextChanged(object sender, EventArgs e)
        {
            if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text)
            {
                textBoxREPEAT_PASS_reg.ForeColor = Color.SpringGreen;
                isRepeatPASScorrect = true;
                if (CheckEmailRegistration(textBoxEMAIL_reg.Text))
                {
                    ButtonREGISTER.Image = Resources.ok;
                    ButtonREGISTER.BackColor = Color.SeaGreen;
                    ButtonREGISTER.Enabled = true;
                }
            }
            else
            {
                textBoxREPEAT_PASS_reg.ForeColor = Color.Red;
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
            }
        }
        private void textBoxPASS_TextChanged(object sender, EventArgs e)
        {
            PASS = textBoxPASS_reg.Text;
            if (PASS.Length < 6)
            {
                textBoxPASS_reg.ForeColor = Color.Red;
                ButtonREGISTER.Enabled = false;
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                isPASScorrect = false;
            }
            else
            {
                isPASScorrect = true;
                textBoxPASS_reg.ForeColor = Color.SpringGreen;
                if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text && CheckEmailRegistration(textBoxEMAIL_reg.Text))
                {
                    ButtonREGISTER.Image = Resources.ok;
                    ButtonREGISTER.BackColor = Color.SeaGreen;
                    ButtonREGISTER.Enabled = true;
                    textBoxREPEAT_PASS_reg.ForeColor = Color.SpringGreen;
                }
                else
                {
                    if (textBoxREPEAT_PASS_reg.Text != textBoxPASS_reg.Text)
                    {
                        textBoxREPEAT_PASS_reg.ForeColor = Color.Red;
                        isRepeatPASScorrect = false;
                    }
                    else if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text)
                    {
                        textBoxREPEAT_PASS_reg.ForeColor = Color.SpringGreen;
                        isRepeatPASScorrect = true;
                    }
                    ButtonREGISTER.Enabled = false;
                    ButtonREGISTER.Image = Resources.X;
                    ButtonREGISTER.BackColor = Color.SlateGray;
                }
            }
        }
        #endregion

        #region tryingToApplyNewUSER
        private void ButtonREGISTER_Click(object sender, EventArgs e)
        {
            try
            {
                if (isRepeatPASScorrect && isPASScorrect && isLOGINcorrect)
                {
                    using (sql_con = new SQLiteConnection("Data Source=TRPO.db"))
                    {
                        sql_con.Open();
                        sql_cmd = new SQLiteCommand("SELECT MAX(id) FROM LOGin", sql_con);
                        int J = Convert.ToInt32(sql_cmd.ExecuteScalar().ToString());
                        using (sql_cmd = new SQLiteCommand($@"INSERT INTO LOGin(email,password,isAdmin,ProfilePicture) VALUES('{textBoxEMAIL_reg.Text}', '{textBoxPASS_reg.Text}', 0, 'USERsPIC\id{++J}_USER.png');", sql_con))
                        {
                            sql_cmd.ExecuteNonQuery();
                            File.Copy(@"USERsPIC\idDEFAULT_USER.png", $@"USERsPIC\id{J}_USER.png");
                            MetroMessageBox.Show(this, "Поздравляю!\nРегистрация успешно завершена!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textboxEMAILlogin.Text = textBoxEMAIL_reg.Text;
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "ERROR", "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (!isLOGINcorrect)
                    {
                        textBoxEMAIL_reg.Text = "";
                        textBoxREPEAT_PASS_reg.Text = "";
                        textBoxPASS_reg.Text = "";
                    }
                    else if ((!isPASScorrect || !isRepeatPASScorrect) && isLOGINcorrect)
                    {
                        textBoxREPEAT_PASS_reg.Text = "";
                        textBoxPASS_reg.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "ERROR \n" + ex.Message, "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        private void metroLinkForgotPassword_Click(object sender, EventArgs e)
        {
            if (xuiSlidingPanelForgotPass.Collapsed)
            {
                xuiSlidingPanelForgotPass.Visible = true;
            }
        }
    }
}

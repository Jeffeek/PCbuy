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
using System.Data.SQLite;
using MetroFramework;
using MetroFramework.Forms;
using TRPO_Project.Properties;
using System.Net.Mail;
using System.Net;

namespace TRPO_Project
{
    
    public partial class formLogIn : MetroForm
    {
        #region variables&collections
        private SQLiteConnection sql_con; // connection
        private SQLiteCommand sql_cmd;
        private static readonly Random randNum = new Random();
        string SendNum = randNum.Next(1000, 9999).ToString();
        #endregion

        #region constructor
        public formLogIn()
        {
            InitializeComponent();
            FormStartTransition.ShowAsyc(this);
            //TODO: убери автолог
            textboxEMAILlogin.text = "mishamine26@gmail.com";
            textboxPASSlogin.text = "123456";
        }
        #endregion

        #region CHECKemail&passCORRECTON

        private bool CheckEmailForCorrection(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            if (email.IndexOf(".") == -1 || (email.Length - 3) < email.IndexOf("."))
            {
                return false;
            }
            if ((email.IndexOf(",") >= 0) || (email.IndexOf(";") >= 0) || (email.IndexOf(" ") >= 0))
            {
                return false;
            }
            int dog = email.IndexOf("@");
            if (dog == -1)
            {
                return false;
            }
            if ((dog < 1) || (dog > email.Length - 5))
            {
                return false;
            }
            if ((email.ElementAt(dog - 1) == '.') || (email.ElementAt(dog + 1) == '.'))
            {
                return false;
            }
            return true;
        }
        private bool CheckPasswordForCorrection(string pass)
        {
            if (pass.Length > 5 && pass.Length < 25)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region CheckForAdmin&GetUserID
        private bool CheckFORadmin(string LOGIN)
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
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

        private int GetUserID(string LOGIN)
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT id FROM LOGin WHERE email='{LOGIN}';", sql_con))
                {
                    return Convert.ToInt32(sql_cmd.ExecuteScalar().ToString());
                }
            }
        }

        #endregion

        #region textBOXchanges
        private void bunifuTextboxEMAILlogin_OnTextChange(object sender, EventArgs e)
        {
            if (CheckEmailForCorrection(textboxEMAILlogin.text))
            {
                textboxEMAILlogin.ForeColor = Color.SpringGreen;
                if (CheckPasswordForCorrection(textboxPASSlogin.text))
                {
                    textboxPASSlogin.ForeColor = Color.SpringGreen;
                    ImageButtonAPPLYlogin.Enabled = true;
                    ImageButtonAPPLYlogin.Image = Resources.ok;
                    ImageButtonAPPLYlogin.BackColor = Color.SeaGreen;
                }
                else
                {
                    ImageButtonAPPLYlogin.Enabled = false;
                    ImageButtonAPPLYlogin.Image = Resources.X;
                    ImageButtonAPPLYlogin.BackColor = Color.SlateGray;
                }
            }
            else
            {
                textboxEMAILlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                ImageButtonAPPLYlogin.Image = Resources.X;
                ImageButtonAPPLYlogin.BackColor = Color.SlateGray;
            }
        }
        private void bunifuTextboxPASSlogin_OnTextChange(object sender, EventArgs e)
      {
            if (CheckPasswordForCorrection(textboxPASSlogin.text))
            {
                textboxPASSlogin.ForeColor = Color.SpringGreen;
                if (CheckEmailForCorrection(textboxEMAILlogin.text))
                {
                    textboxEMAILlogin.ForeColor = Color.SpringGreen;
                    ImageButtonAPPLYlogin.Enabled = true;
                    ImageButtonAPPLYlogin.Image = Resources.ok;
                    ImageButtonAPPLYlogin.BackColor = Color.SeaGreen;
                }
                else
                {
                    ImageButtonAPPLYlogin.Enabled = false;
                    ImageButtonAPPLYlogin.Image = Resources.X;
                    ImageButtonAPPLYlogin.BackColor = Color.SlateGray;
                }
            }
            else
            {
                textboxPASSlogin.ForeColor = Color.Crimson;
                ImageButtonAPPLYlogin.Enabled = false;
                ImageButtonAPPLYlogin.Image = Resources.X;
                ImageButtonAPPLYlogin.BackColor = Color.SlateGray;
            }
        }
        #endregion

        #region EmailSend
        //проверка высыланием рандомного номера на почту(для регистрации и для случая того, если пользователь забыл пароль)
        private void SendMessage(string EmailTo)
        {
            string smtpEmail = "smtp.jeffeekpcbuy@gmail.com";
            string smtpPassword = "9Pocan1337";
            MailAddress SMTPfrom = new MailAddress(smtpEmail, "Jeffeek inc.");
            MailAddress toUser = new MailAddress(EmailTo);
            MailMessage Message = new MailMessage(SMTPfrom, toUser)
            {
                Subject = "Protection Code",
                Body = $"<h1>{SendNum}</h1>",
                IsBodyHtml = true
            };
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(smtpEmail, smtpPassword),
                EnableSsl = true
            };
            smtp.Send(Message);
        }

        //отсылка сообщения об успешной регистрации
        private void SendMessage(string EmailTo, string password)
        {
            string smtpEmail = "smtp.jeffeekpcbuy@gmail.com";
            string smtpPassword = "9Pocan1337";
            MailAddress SMTPfrom = new MailAddress(smtpEmail, "Jeffeek inc.");
            MailAddress toUser = new MailAddress(EmailTo);
            MailMessage Message = new MailMessage(SMTPfrom, toUser)
            {
                Subject = "Successful registration",
                Body = $"<h1>Успешная регистрация в приложении PCbuy</h1>\n<h2>Логин: {EmailTo}</h2>\n<h2>Пароль: {password}</h2>",
                IsBodyHtml = true
            };
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(smtpEmail, smtpPassword),
                EnableSsl = true
            };
            smtp.Send(Message);
        }

        #endregion

        #region labelLINKclick
        ////при нажатии на ЗАБЫЛ ПАРОЛЬ
        private void metroLinkRegister_Click(object sender, EventArgs e)
        {
            textBoxPASS_reg.Text = string.Empty;
            textBoxREPEAT_PASS_reg.Text = string.Empty;
            textBoxEMAIL_reg.Text = string.Empty;
        }

        private void metroLinkForgotPassword_Click(object sender, EventArgs e)
        {
            textboxPASSlogin.Enabled = false;
            textboxEMAILlogin.Enabled = false;
            metroLinkRegister.Enabled = false;
            ImageButtonAPPLYlogin.Enabled = false;
            textBox_ForgotPass.Text = string.Empty;
            gunaLineTextBoxCheckSendedNum.Visible = false;
            imageButtonCheckNum.Visible = false;
        }
        #endregion

        #region buttonLOGINclick
        private void bunifuImageButtonAPPLYlogin_Click(object sender, EventArgs e)
        {
            buttonAnimate.ColorAnimate(ImageButtonAPPLYlogin, Color.MediumSeaGreen, XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 1);
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
            {
                string email = textboxEMAILlogin.text, password = textboxPASSlogin.text;
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT id FROM LOGin WHERE email='{email}' and password='{password}'", sql_con))
                {
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MetroMessageBox.Show(this, "WELL DONE! LOGGED IN", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (CheckFORadmin(email))
                        {
                            formADMIN MainForm = new formADMIN(GetUserID(email));
                            MainForm.Show();
                        }
                        else
                        {
                            formUSER MainForm = new formUSER(GetUserID(email));
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
            Application.Exit();
        }
        #endregion

        #region Forgost Password Slider        
        private void bunifuImageButtonAPPLYforgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
                {
                    sql_con.Open();
                    using (sql_cmd = new SQLiteCommand($"SELECT password FROM LOGin WHERE email='{textBox_ForgotPass.Text}';", sql_con))
                    {
                        using (SQLiteDataReader reader = sql_cmd.ExecuteReader())
                        {
                            reader.Read();
                            if (reader.HasRows)
                            {
                                gunaLineTextBoxCheckSendedNum.Visible = true;
                                imageButtonCheckNum.Visible = true;
                                MetroMessageBox.Show(this, "Found your account! Check your email for protectcode. Paste it in textbox below!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SendMessage(textBox_ForgotPass.Text);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "WE DO NOT find your account!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_ForgotPass.Text = string.Empty;
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
        private void textBox_ForgotPass_TextChanged(object sender, EventArgs e)
        {
            if (CheckEmailForCorrection(textBox_ForgotPass.Text))
            {
                textBox_ForgotPass.ForeColor = Color.SeaGreen;
                bunifuImageButtonAPPLYforgotPassword.Enabled = true;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.ok;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SeaGreen;
            }
            else
            {              
                textBox_ForgotPass.ForeColor = Color.Crimson;
                bunifuImageButtonAPPLYforgotPassword.Enabled = false;
                bunifuImageButtonAPPLYforgotPassword.Image = Resources.X;
                bunifuImageButtonAPPLYforgotPassword.BackColor = Color.SlateGray;
            }
        }     
        private void imageButtonCheckNum_Click(object sender, EventArgs e)
        {
            if (gunaLineTextBoxCheckSendedNum.Text == SendNum)
            {
                MetroMessageBox.Show(this, $"Yeah, here is your password: {GetForgotedPassword(textBox_ForgotPass.Text)}");
            }
            else
            {
                if (MetroMessageBox.Show(this, "The protection number is wrong! We can send it again, should we?", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    SendNum = randNum.Next(1000, 9999).ToString();
                    textBox_ForgotPass.Text = textBox_ForgotPass.Text;
                    bunifuImageButtonAPPLYforgotPassword_Click(null, null);
                }
            }
            xuiSlidingPanelForgotPass.Collapsed = true;
            gunaLineTextBoxCheckSendedNum.Visible = false;
            imageButtonCheckNum.Visible = false;
        }
        private string GetForgotedPassword(string FPemail)
        {
            using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
            {
                sql_con.Open();
                using (sql_cmd = new SQLiteCommand($"SELECT password FROM LOGin WHERE email='{FPemail}'", sql_con))
                {
                    return sql_cmd.ExecuteScalar().ToString();
                }
            }
        }    
        private void gunaLineTextBoxCheckSendedNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && gunaLineTextBoxCheckSendedNum.Text.Length == 3)
            {
                e.Handled = true;
            }
            if (textBoxProtectionCode_reg.Text.Length == 3)
            {
                buttonProtectionCode_reg.Enabled = true;
                buttonProtectionCode_reg.BackColor = Color.SeaGreen;
                buttonProtectionCode_reg.Image = Resources.ok;
            }
            else if (textBoxProtectionCode_reg.Text.Length < 3)
            {
                buttonProtectionCode_reg.Enabled = false;
                buttonProtectionCode_reg.BackColor = Color.SlateGray;
                buttonProtectionCode_reg.Image = Resources.delete2;
            }
        }
        private void gunaLineTextBoxCheckSendedNum_TextChanged(object sender, EventArgs e)
        {
            if (gunaLineTextBoxCheckSendedNum.Text.Length == 4)
            {
                imageButtonCheckNum.Enabled = true;
                imageButtonCheckNum.BackColor = Color.SeaGreen;
                imageButtonCheckNum.Image = Resources.ok;
            }
            else
            {
                if (gunaLineTextBoxCheckSendedNum.Text.Length < 4)
                {
                    imageButtonCheckNum.Enabled = false;
                    imageButtonCheckNum.BackColor = Color.SlateGray;
                    imageButtonCheckNum.Image = Resources.delete2;
                }
                else if (gunaLineTextBoxCheckSendedNum.Text.Length > 4)
                {
                    gunaLineTextBoxCheckSendedNum.Text = gunaLineTextBoxCheckSendedNum.Text.Remove(gunaLineTextBoxCheckSendedNum.Text.Length - 1);
                    imageButtonCheckNum.Focus();
                }
            }
        }
        private void bunifuImageButtonBACK_Click(object sender, EventArgs e)
        {
            textboxPASSlogin.Enabled = true;
            textboxEMAILlogin.Enabled = true;
            metroLinkRegister.Enabled = true;
            ImageButtonAPPLYlogin.Enabled = true;
        }

        #endregion

        #region Registration Slider

        #region CHECKcorrectionEMAIL&password

        private void textBoxEMAIL_TextChanged(object sender, EventArgs e)
        {
            if (CheckEmailForCorrection(textBoxEMAIL_reg.Text))
            {
                textBoxEMAIL_reg.ForeColor = Color.SpringGreen;
                if (CheckPasswordForCorrection(textBoxPASS_reg.Text) && textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text)
                {
                    ButtonREGISTER.Image = Resources.ok;
                    ButtonREGISTER.BackColor = Color.SeaGreen;
                    ButtonREGISTER.Enabled = true;
                }
            }
            else
            {
                textBoxEMAIL_reg.ForeColor = Color.Crimson;
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
                ButtonREGISTER.Enabled = false;
            }
        }
        private void textBoxREPEAT_PASS_TextChanged(object sender, EventArgs e)
        {
            if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text)
            {
                textBoxREPEAT_PASS_reg.ForeColor = Color.SpringGreen;
                if (CheckEmailForCorrection(textBoxEMAIL_reg.Text))
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
            if (!CheckPasswordForCorrection(textBoxPASS_reg.Text))
            {
                textBoxPASS_reg.ForeColor = Color.Red;
                ButtonREGISTER.Enabled = false;
                ButtonREGISTER.Image = Resources.X;
                ButtonREGISTER.BackColor = Color.SlateGray;
            }
            else
            {
                textBoxPASS_reg.ForeColor = Color.SpringGreen;
                if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text && CheckEmailForCorrection(textBoxEMAIL_reg.Text))
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
                    }
                    else if (textBoxREPEAT_PASS_reg.Text == textBoxPASS_reg.Text)
                    {
                        textBoxREPEAT_PASS_reg.ForeColor = Color.SpringGreen;
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
                if (textBoxREPEAT_PASS_reg.Text == textBoxREPEAT_PASS_reg.Text && CheckPasswordForCorrection(textBoxPASS_reg.Text) && CheckEmailForCorrection(textBoxEMAIL_reg.Text))
                {
                    using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
                    {
                        sql_con.Open();
                        using (sql_cmd = new SQLiteCommand($"SELECT id FROM LOGin WHERE email='{textBoxEMAIL_reg.Text}'",sql_con))
                        {
                            if (sql_cmd.ExecuteScalar() != null)
                            {
                                MetroMessageBox.Show(this, "User with this email is already exists", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBoxEMAIL_reg.Text = "";
                                textBoxREPEAT_PASS_reg.Text = "";
                                textBoxPASS_reg.Text = "";
                                return;
                            }
                        }

                        SendNum = randNum.Next(1000, 9999).ToString();
                        SendMessage(textBoxEMAIL_reg.Text);
                        buttonProtectionCode_reg.Visible = true;
                        textBoxProtectionCode_reg.Visible = true;
                        MetroMessageBox.Show(this, "Protection Code was sended to your email. Paste it in the textbox at right and push the button", "Check email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "ERROR", "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxEMAIL_reg.Text = "";
                    textBoxREPEAT_PASS_reg.Text = "";
                    textBoxPASS_reg.Text = "";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "ERROR \n" + ex.Message, "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterNewUser()
        {
            try
            {
                using (sql_con = new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}\\TRPO.db"))
                {
                    sql_con.Open();
                    int lastID;
                    using (sql_cmd = new SQLiteCommand("SELECT COUNT(0) FROM LOGin", sql_con))
                        lastID = Convert.ToInt32(sql_cmd.ExecuteScalar().ToString());
                    lastID++;
                    using (sql_cmd = new SQLiteCommand($@"INSERT INTO LOGin(email,password,isAdmin,ProfilePicture) VALUES('{textBoxEMAIL_reg.Text}', '{textBoxPASS_reg.Text}', 0, 'USERsPIC\id{lastID}_USER.png');", sql_con))
                    {
                        sql_cmd.ExecuteNonQuery();
                        File.Copy($@"{Directory.GetCurrentDirectory()}\USERsPIC\idDEFAULT_USER.png", $@"{Directory.GetCurrentDirectory()}\USERsPIC\id{lastID}_USER.png");
                        MetroMessageBox.Show(this, "Поздравляю!\nРегистрация успешно завершена!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        SendMessage(textBoxEMAIL_reg.Text, textBoxPASS_reg.Text);
                        textboxEMAILlogin.text = textBoxEMAIL_reg.Text;
                        textBoxEMAIL_reg.Text = "";
                        textBoxREPEAT_PASS_reg.Text = "";
                        textBoxPASS_reg.Text = "";
                        xuiSlidingPanelREGISTRATION.Collapsed = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "ERROR \n" + ex.Message, "NOPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void textBoxProtectionCode_reg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuImageButtonBACK_Reg_Click(object sender, EventArgs e)
        {
            buttonProtectionCode_reg.Visible = false;
            textBoxProtectionCode_reg.Visible = false;
        }

        private void buttonProtectionCode_reg_Click(object sender, EventArgs e)
        {
            if (textBoxProtectionCode_reg.Text == SendNum)
            {
                RegisterNewUser();
            }
            else
            {
                MetroMessageBox.Show(this, "The num is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxProtectionCode_reg_OnValueChanged(object sender, EventArgs e)
        {
            if (textBoxProtectionCode_reg.Text.Length == 4)
            {
                buttonProtectionCode_reg.Enabled = true;
                buttonProtectionCode_reg.BackColor = Color.SeaGreen;
                buttonProtectionCode_reg.Image = Resources.ok;
            }
            else
            {
                if (textBoxProtectionCode_reg.Text.Length < 4)
                {
                    buttonProtectionCode_reg.Enabled = false;
                    buttonProtectionCode_reg.BackColor = Color.SlateGray;
                    buttonProtectionCode_reg.Image = Resources.delete2;
                }
                else if (textBoxProtectionCode_reg.Text.Length > 4)
                {
                    textBoxProtectionCode_reg.Text = textBoxProtectionCode_reg.Text.Remove(textBoxProtectionCode_reg.Text.Length - 1);
                    buttonProtectionCode_reg.Focus();
                }
            }
        }

        #endregion      

        #region MovingForm
        private Point lastPoint;
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
        
    }
}

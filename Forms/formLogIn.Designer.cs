using System.Drawing;

namespace TRPO_Project
{
    partial class FormLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.metroLinkRegister = new MetroFramework.Controls.MetroLink();
            this.metroLinkForgotPassword = new MetroFramework.Controls.MetroLink();
            this.EMAILlabel = new MetroFramework.Controls.MetroLabel();
            this.PASSlabel = new MetroFramework.Controls.MetroLabel();
            this.buttonAnimate = new XanderUI.XUIObjectAnimator();
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.EllipseForm = new XanderUI.XUIObjectEllipse();
            this.xuiSlidingPanelForgotPass = new XanderUI.XUISlidingPanel();
            this.imageButtonCheckNum = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLineTextBoxCheckSendedNum = new Guna.UI.WinForms.GunaLineTextBox();
            this.bunifuImageButtonBACK = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonAPPLYforgotPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.textBox_ForgotPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.labelREGISTRATION = new System.Windows.Forms.Label();
            this.xuiSlidingPanelREGISTRATION = new XanderUI.XUISlidingPanel();
            this.buttonProtectionCode_reg = new Guna.UI.WinForms.GunaCircleButton();
            this.textBoxProtectionCode_reg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonREGISTER = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxREPEAT_PASS_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.textBoxPASS_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.textBoxEMAIL_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuImageButtonBACK_Reg = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.ImageButtonAPPLYlogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.textboxPASSlogin = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxEMAILlogin = new Bunifu.Framework.UI.BunifuTextbox();
            this.xuiSlidingPanelForgotPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonAPPLYforgotPassword)).BeginInit();
            this.xuiSlidingPanelREGISTRATION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonREGISTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK_Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageButtonAPPLYlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLinkRegister
            // 
            this.metroLinkRegister.BackColor = System.Drawing.Color.Transparent;
            this.metroLinkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkRegister.ForeColor = System.Drawing.Color.Aqua;
            this.metroLinkRegister.Location = new System.Drawing.Point(266, 209);
            this.metroLinkRegister.Name = "metroLinkRegister";
            this.metroLinkRegister.Size = new System.Drawing.Size(75, 23);
            this.metroLinkRegister.TabIndex = 8;
            this.metroLinkRegister.Text = "Register";
            this.metroLinkRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkRegister.UseCustomForeColor = true;
            this.metroLinkRegister.UseSelectable = true;
            this.metroLinkRegister.Click += new System.EventHandler(this.metroLinkRegister_Click);
            // 
            // metroLinkForgotPassword
            // 
            this.metroLinkForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkForgotPassword.ForeColor = System.Drawing.Color.Aqua;
            this.metroLinkForgotPassword.Location = new System.Drawing.Point(52, 209);
            this.metroLinkForgotPassword.Name = "metroLinkForgotPassword";
            this.metroLinkForgotPassword.Size = new System.Drawing.Size(106, 23);
            this.metroLinkForgotPassword.TabIndex = 9;
            this.metroLinkForgotPassword.Text = "Forgot password";
            this.metroLinkForgotPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkForgotPassword.UseCustomForeColor = true;
            this.metroLinkForgotPassword.UseSelectable = true;
            this.metroLinkForgotPassword.Click += new System.EventHandler(this.metroLinkForgotPassword_Click);
            // 
            // EMAILlabel
            // 
            this.EMAILlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMAILlabel.AutoSize = true;
            this.EMAILlabel.BackColor = System.Drawing.Color.Transparent;
            this.EMAILlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.EMAILlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.EMAILlabel.ForeColor = System.Drawing.Color.HotPink;
            this.EMAILlabel.Location = new System.Drawing.Point(164, 36);
            this.EMAILlabel.Name = "EMAILlabel";
            this.EMAILlabel.Size = new System.Drawing.Size(67, 25);
            this.EMAILlabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.EMAILlabel.TabIndex = 12;
            this.EMAILlabel.Text = "EMAIL";
            this.EMAILlabel.UseCustomBackColor = true;
            this.EMAILlabel.UseCustomForeColor = true;
            this.EMAILlabel.UseStyleColors = true;
            // 
            // PASSlabel
            // 
            this.PASSlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PASSlabel.AutoSize = true;
            this.PASSlabel.BackColor = System.Drawing.Color.Transparent;
            this.PASSlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PASSlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PASSlabel.ForeColor = System.Drawing.Color.HotPink;
            this.PASSlabel.Location = new System.Drawing.Point(141, 95);
            this.PASSlabel.Name = "PASSlabel";
            this.PASSlabel.Size = new System.Drawing.Size(112, 25);
            this.PASSlabel.TabIndex = 13;
            this.PASSlabel.Text = "PASSWORD";
            this.PASSlabel.UseCustomBackColor = true;
            this.PASSlabel.UseCustomForeColor = true;
            this.PASSlabel.UseMnemonic = false;
            this.PASSlabel.UseStyleColors = true;
            // 
            // FormStartTransition
            // 
            this.FormStartTransition.Delay = 1;
            // 
            // EllipseForm
            // 
            this.EllipseForm.CornerRadius = 15;
            this.EllipseForm.EffectedControl = this;
            this.EllipseForm.EffectedForm = this;
            // 
            // xuiSlidingPanelForgotPass
            // 
            this.xuiSlidingPanelForgotPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xuiSlidingPanelForgotPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xuiSlidingPanelForgotPass.BottomLeft = System.Drawing.Color.Plum;
            this.xuiSlidingPanelForgotPass.BottomRight = System.Drawing.Color.Aquamarine;
            this.xuiSlidingPanelForgotPass.CollapseControl = this.metroLinkForgotPassword;
            this.xuiSlidingPanelForgotPass.Collapsed = true;
            this.xuiSlidingPanelForgotPass.Controls.Add(this.imageButtonCheckNum);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.gunaLineTextBoxCheckSendedNum);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.bunifuImageButtonBACK);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.bunifuImageButtonAPPLYforgotPassword);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.gunaLabel1);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.textBox_ForgotPass);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.labelREGISTRATION);
            this.xuiSlidingPanelForgotPass.HideControls = false;
            this.xuiSlidingPanelForgotPass.Location = new System.Drawing.Point(0, 30);
            this.xuiSlidingPanelForgotPass.Name = "xuiSlidingPanelForgotPass";
            this.xuiSlidingPanelForgotPass.PanelWidthCollapsed = 0;
            this.xuiSlidingPanelForgotPass.PanelWidthExpanded = 240;
            this.xuiSlidingPanelForgotPass.PrimerColor = System.Drawing.Color.LightGreen;
            this.xuiSlidingPanelForgotPass.Size = new System.Drawing.Size(0, 216);
            this.xuiSlidingPanelForgotPass.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanelForgotPass.TabIndex = 16;
            this.xuiSlidingPanelForgotPass.TopLeft = System.Drawing.SystemColors.Highlight;
            this.xuiSlidingPanelForgotPass.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // imageButtonCheckNum
            // 
            this.imageButtonCheckNum.Animated = true;
            this.imageButtonCheckNum.AnimationHoverSpeed = 0.07F;
            this.imageButtonCheckNum.AnimationSpeed = 0.03F;
            this.imageButtonCheckNum.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonCheckNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageButtonCheckNum.BaseColor = System.Drawing.Color.SlateGray;
            this.imageButtonCheckNum.BorderColor = System.Drawing.Color.Black;
            this.imageButtonCheckNum.BorderSize = 1;
            this.imageButtonCheckNum.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonCheckNum.Enabled = false;
            this.imageButtonCheckNum.FocusedColor = System.Drawing.Color.Cyan;
            this.imageButtonCheckNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imageButtonCheckNum.ForeColor = System.Drawing.Color.White;
            this.imageButtonCheckNum.Image = global::TRPO_Project.Properties.Resources.delete2;
            this.imageButtonCheckNum.ImageSize = new System.Drawing.Size(52, 52);
            this.imageButtonCheckNum.Location = new System.Drawing.Point(111, 162);
            this.imageButtonCheckNum.Name = "imageButtonCheckNum";
            this.imageButtonCheckNum.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.imageButtonCheckNum.OnHoverBorderColor = System.Drawing.Color.Black;
            this.imageButtonCheckNum.OnHoverForeColor = System.Drawing.Color.White;
            this.imageButtonCheckNum.OnHoverImage = null;
            this.imageButtonCheckNum.OnPressedColor = System.Drawing.Color.Black;
            this.imageButtonCheckNum.OnPressedDepth = 50;
            this.imageButtonCheckNum.Size = new System.Drawing.Size(55, 55);
            this.imageButtonCheckNum.TabIndex = 26;
            this.imageButtonCheckNum.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.imageButtonCheckNum.UseTransfarantBackground = true;
            this.imageButtonCheckNum.Visible = false;
            this.imageButtonCheckNum.Click += new System.EventHandler(this.imageButtonCheckNum_Click);
            // 
            // gunaLineTextBoxCheckSendedNum
            // 
            this.gunaLineTextBoxCheckSendedNum.Animated = true;
            this.gunaLineTextBoxCheckSendedNum.BackColor = System.Drawing.Color.LavenderBlush;
            this.gunaLineTextBoxCheckSendedNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBoxCheckSendedNum.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBoxCheckSendedNum.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBoxCheckSendedNum.ForeColor = System.Drawing.Color.SeaGreen;
            this.gunaLineTextBoxCheckSendedNum.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLineTextBoxCheckSendedNum.Location = new System.Drawing.Point(25, 177);
            this.gunaLineTextBoxCheckSendedNum.Name = "gunaLineTextBoxCheckSendedNum";
            this.gunaLineTextBoxCheckSendedNum.PasswordChar = '\0';
            this.gunaLineTextBoxCheckSendedNum.Size = new System.Drawing.Size(72, 25);
            this.gunaLineTextBoxCheckSendedNum.TabIndex = 24;
            this.gunaLineTextBoxCheckSendedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaLineTextBoxCheckSendedNum.Visible = false;
            this.gunaLineTextBoxCheckSendedNum.TextChanged += new System.EventHandler(this.gunaLineTextBoxCheckSendedNum_TextChanged);
            this.gunaLineTextBoxCheckSendedNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaLineTextBoxCheckSendedNum_KeyPress);
            // 
            // bunifuImageButtonBACK
            // 
            this.bunifuImageButtonBACK.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonBACK.Image = global::TRPO_Project.Properties.Resources.back;
            this.bunifuImageButtonBACK.ImageActive = null;
            this.bunifuImageButtonBACK.Location = new System.Drawing.Point(199, 178);
            this.bunifuImageButtonBACK.Name = "bunifuImageButtonBACK";
            this.bunifuImageButtonBACK.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButtonBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBACK.TabIndex = 23;
            this.bunifuImageButtonBACK.TabStop = false;
            this.bunifuImageButtonBACK.Zoom = 10;
            this.bunifuImageButtonBACK.Click += new System.EventHandler(this.bunifuImageButtonBACK_Click);
            // 
            // bunifuImageButtonAPPLYforgotPassword
            // 
            this.bunifuImageButtonAPPLYforgotPassword.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuImageButtonAPPLYforgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonAPPLYforgotPassword.Enabled = false;
            this.bunifuImageButtonAPPLYforgotPassword.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonAPPLYforgotPassword.ImageActive = null;
            this.bunifuImageButtonAPPLYforgotPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButtonAPPLYforgotPassword.Location = new System.Drawing.Point(23, 110);
            this.bunifuImageButtonAPPLYforgotPassword.Name = "bunifuImageButtonAPPLYforgotPassword";
            this.bunifuImageButtonAPPLYforgotPassword.Size = new System.Drawing.Size(202, 40);
            this.bunifuImageButtonAPPLYforgotPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonAPPLYforgotPassword.TabIndex = 22;
            this.bunifuImageButtonAPPLYforgotPassword.TabStop = false;
            this.bunifuImageButtonAPPLYforgotPassword.Zoom = 10;
            this.bunifuImageButtonAPPLYforgotPassword.Click += new System.EventHandler(this.bunifuImageButtonAPPLYforgotPassword_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Unispace", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.gunaLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLabel1.Location = new System.Drawing.Point(89, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "EMAIL";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            // 
            // textBox_ForgotPass
            // 
            this.textBox_ForgotPass.Animated = true;
            this.textBox_ForgotPass.BackColor = System.Drawing.Color.Thistle;
            this.textBox_ForgotPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_ForgotPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox_ForgotPass.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ForgotPass.ForeColor = System.Drawing.Color.Snow;
            this.textBox_ForgotPass.LineColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox_ForgotPass.Location = new System.Drawing.Point(23, 76);
            this.textBox_ForgotPass.Name = "textBox_ForgotPass";
            this.textBox_ForgotPass.PasswordChar = '\0';
            this.textBox_ForgotPass.Size = new System.Drawing.Size(202, 28);
            this.textBox_ForgotPass.TabIndex = 20;
            this.textBox_ForgotPass.TextChanged += new System.EventHandler(this.textBox_ForgotPass_TextChanged);
            // 
            // labelREGISTRATION
            // 
            this.labelREGISTRATION.AutoEllipsis = true;
            this.labelREGISTRATION.AutoSize = true;
            this.labelREGISTRATION.BackColor = System.Drawing.Color.Transparent;
            this.labelREGISTRATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelREGISTRATION.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelREGISTRATION.ForeColor = System.Drawing.Color.MintCream;
            this.labelREGISTRATION.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelREGISTRATION.Location = new System.Drawing.Point(19, 6);
            this.labelREGISTRATION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelREGISTRATION.Name = "labelREGISTRATION";
            this.labelREGISTRATION.Size = new System.Drawing.Size(207, 25);
            this.labelREGISTRATION.TabIndex = 19;
            this.labelREGISTRATION.Text = "FORGOT PASSWORD";
            // 
            // xuiSlidingPanelREGISTRATION
            // 
            this.xuiSlidingPanelREGISTRATION.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xuiSlidingPanelREGISTRATION.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xuiSlidingPanelREGISTRATION.BottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiSlidingPanelREGISTRATION.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiSlidingPanelREGISTRATION.CollapseControl = this.metroLinkRegister;
            this.xuiSlidingPanelREGISTRATION.Collapsed = true;
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.buttonProtectionCode_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxProtectionCode_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.bunifuCustomLabel1);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.ButtonREGISTER);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxREPEAT_PASS_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxPASS_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxEMAIL_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel3);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel2);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel4);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.bunifuImageButtonBACK_Reg);
            this.xuiSlidingPanelREGISTRATION.HideControls = false;
            this.xuiSlidingPanelREGISTRATION.Location = new System.Drawing.Point(25, 30);
            this.xuiSlidingPanelREGISTRATION.Name = "xuiSlidingPanelREGISTRATION";
            this.xuiSlidingPanelREGISTRATION.PanelWidthCollapsed = 0;
            this.xuiSlidingPanelREGISTRATION.PanelWidthExpanded = 345;
            this.xuiSlidingPanelREGISTRATION.PrimerColor = System.Drawing.Color.Black;
            this.xuiSlidingPanelREGISTRATION.Size = new System.Drawing.Size(0, 217);
            this.xuiSlidingPanelREGISTRATION.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanelREGISTRATION.TabIndex = 24;
            this.xuiSlidingPanelREGISTRATION.TopLeft = System.Drawing.Color.LightSeaGreen;
            this.xuiSlidingPanelREGISTRATION.TopRight = System.Drawing.Color.DarkGreen;
            // 
            // buttonProtectionCode_reg
            // 
            this.buttonProtectionCode_reg.AnimationHoverSpeed = 0.11F;
            this.buttonProtectionCode_reg.AnimationSpeed = 0.3F;
            this.buttonProtectionCode_reg.BackColor = System.Drawing.Color.Transparent;
            this.buttonProtectionCode_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProtectionCode_reg.BaseColor = System.Drawing.Color.SlateGray;
            this.buttonProtectionCode_reg.BorderColor = System.Drawing.Color.Black;
            this.buttonProtectionCode_reg.BorderSize = 1;
            this.buttonProtectionCode_reg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonProtectionCode_reg.Enabled = false;
            this.buttonProtectionCode_reg.FocusedColor = System.Drawing.Color.Empty;
            this.buttonProtectionCode_reg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonProtectionCode_reg.ForeColor = System.Drawing.Color.Plum;
            this.buttonProtectionCode_reg.Image = global::TRPO_Project.Properties.Resources.delete2;
            this.buttonProtectionCode_reg.ImageSize = new System.Drawing.Size(52, 52);
            this.buttonProtectionCode_reg.Location = new System.Drawing.Point(268, 82);
            this.buttonProtectionCode_reg.Name = "buttonProtectionCode_reg";
            this.buttonProtectionCode_reg.OnHoverBaseColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonProtectionCode_reg.OnHoverBorderColor = System.Drawing.Color.SlateBlue;
            this.buttonProtectionCode_reg.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonProtectionCode_reg.OnHoverImage = null;
            this.buttonProtectionCode_reg.OnPressedColor = System.Drawing.Color.Plum;
            this.buttonProtectionCode_reg.OnPressedDepth = 50;
            this.buttonProtectionCode_reg.Size = new System.Drawing.Size(58, 55);
            this.buttonProtectionCode_reg.TabIndex = 35;
            this.buttonProtectionCode_reg.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.buttonProtectionCode_reg.UseTransfarantBackground = true;
            this.buttonProtectionCode_reg.Visible = false;
            this.buttonProtectionCode_reg.Click += new System.EventHandler(this.buttonProtectionCode_reg_Click);
            // 
            // textBoxProtectionCode_reg
            // 
            this.textBoxProtectionCode_reg.BackColor = System.Drawing.Color.LightPink;
            this.textBoxProtectionCode_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxProtectionCode_reg.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProtectionCode_reg.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProtectionCode_reg.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxProtectionCode_reg.HintText = "";
            this.textBoxProtectionCode_reg.isPassword = false;
            this.textBoxProtectionCode_reg.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxProtectionCode_reg.LineIdleColor = System.Drawing.Color.Cyan;
            this.textBoxProtectionCode_reg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxProtectionCode_reg.LineThickness = 3;
            this.textBoxProtectionCode_reg.Location = new System.Drawing.Point(268, 51);
            this.textBoxProtectionCode_reg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProtectionCode_reg.Name = "textBoxProtectionCode_reg";
            this.textBoxProtectionCode_reg.Size = new System.Drawing.Size(58, 24);
            this.textBoxProtectionCode_reg.TabIndex = 32;
            this.textBoxProtectionCode_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProtectionCode_reg.Visible = false;
            this.textBoxProtectionCode_reg.OnValueChanged += new System.EventHandler(this.textBoxProtectionCode_reg_OnValueChanged);
            this.textBoxProtectionCode_reg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProtectionCode_reg_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Snow;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 25);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "REGISTRATION";
            // 
            // ButtonREGISTER
            // 
            this.ButtonREGISTER.BackColor = System.Drawing.Color.SlateGray;
            this.ButtonREGISTER.Enabled = false;
            this.ButtonREGISTER.Image = global::TRPO_Project.Properties.Resources.X;
            this.ButtonREGISTER.ImageActive = null;
            this.ButtonREGISTER.Location = new System.Drawing.Point(38, 177);
            this.ButtonREGISTER.Name = "ButtonREGISTER";
            this.ButtonREGISTER.Size = new System.Drawing.Size(155, 37);
            this.ButtonREGISTER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonREGISTER.TabIndex = 31;
            this.ButtonREGISTER.TabStop = false;
            this.ButtonREGISTER.Zoom = 10;
            this.ButtonREGISTER.Click += new System.EventHandler(this.ButtonREGISTER_Click);
            // 
            // textBoxREPEAT_PASS_reg
            // 
            this.textBoxREPEAT_PASS_reg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxREPEAT_PASS_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxREPEAT_PASS_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxREPEAT_PASS_reg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxREPEAT_PASS_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxREPEAT_PASS_reg.LineColor = System.Drawing.Color.BlueViolet;
            this.textBoxREPEAT_PASS_reg.Location = new System.Drawing.Point(6, 149);
            this.textBoxREPEAT_PASS_reg.Name = "textBoxREPEAT_PASS_reg";
            this.textBoxREPEAT_PASS_reg.PasswordChar = '●';
            this.textBoxREPEAT_PASS_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxREPEAT_PASS_reg.TabIndex = 30;
            this.textBoxREPEAT_PASS_reg.UseSystemPasswordChar = true;
            this.textBoxREPEAT_PASS_reg.TextChanged += new System.EventHandler(this.textBoxREPEAT_PASS_TextChanged);
            // 
            // textBoxPASS_reg
            // 
            this.textBoxPASS_reg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxPASS_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPASS_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxPASS_reg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPASS_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxPASS_reg.LineColor = System.Drawing.Color.BlueViolet;
            this.textBoxPASS_reg.Location = new System.Drawing.Point(6, 100);
            this.textBoxPASS_reg.Name = "textBoxPASS_reg";
            this.textBoxPASS_reg.PasswordChar = '●';
            this.textBoxPASS_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxPASS_reg.TabIndex = 29;
            this.textBoxPASS_reg.UseSystemPasswordChar = true;
            this.textBoxPASS_reg.TextChanged += new System.EventHandler(this.textBoxPASS_TextChanged);
            // 
            // textBoxEMAIL_reg
            // 
            this.textBoxEMAIL_reg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxEMAIL_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEMAIL_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxEMAIL_reg.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMAIL_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxEMAIL_reg.LineColor = System.Drawing.Color.BlueViolet;
            this.textBoxEMAIL_reg.Location = new System.Drawing.Point(6, 51);
            this.textBoxEMAIL_reg.Name = "textBoxEMAIL_reg";
            this.textBoxEMAIL_reg.PasswordChar = '\0';
            this.textBoxEMAIL_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxEMAIL_reg.TabIndex = 28;
            this.textBoxEMAIL_reg.TextChanged += new System.EventHandler(this.textBoxEMAIL_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Violet;
            this.gunaLabel3.Location = new System.Drawing.Point(34, 128);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 19);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "REPEAT PASSWORD";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Plum;
            this.gunaLabel2.Location = new System.Drawing.Point(71, 79);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 19);
            this.gunaLabel2.TabIndex = 26;
            this.gunaLabel2.Text = "PASSWORD";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Thistle;
            this.gunaLabel4.Location = new System.Drawing.Point(88, 30);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(59, 19);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "EMAIL";
            // 
            // bunifuImageButtonBACK_Reg
            // 
            this.bunifuImageButtonBACK_Reg.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBACK_Reg.Image = global::TRPO_Project.Properties.Resources.back;
            this.bunifuImageButtonBACK_Reg.ImageActive = null;
            this.bunifuImageButtonBACK_Reg.Location = new System.Drawing.Point(304, 179);
            this.bunifuImageButtonBACK_Reg.Name = "bunifuImageButtonBACK_Reg";
            this.bunifuImageButtonBACK_Reg.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButtonBACK_Reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBACK_Reg.TabIndex = 23;
            this.bunifuImageButtonBACK_Reg.TabStop = false;
            this.bunifuImageButtonBACK_Reg.Zoom = 10;
            this.bunifuImageButtonBACK_Reg.Click += new System.EventHandler(this.bunifuImageButtonBACK_Reg_Click);
            // 
            // panelHead
            // 
            this.panelHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Location = new System.Drawing.Point(-2, 5);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(400, 26);
            this.panelHead.TabIndex = 25;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.Red;
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(370, 8);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 15;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // ImageButtonAPPLYlogin
            // 
            this.ImageButtonAPPLYlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonAPPLYlogin.BackColor = System.Drawing.Color.Gray;
            this.ImageButtonAPPLYlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButtonAPPLYlogin.Enabled = false;
            this.ImageButtonAPPLYlogin.Image = global::TRPO_Project.Properties.Resources.X;
            this.ImageButtonAPPLYlogin.ImageActive = null;
            this.ImageButtonAPPLYlogin.Location = new System.Drawing.Point(52, 157);
            this.ImageButtonAPPLYlogin.Name = "ImageButtonAPPLYlogin";
            this.ImageButtonAPPLYlogin.Size = new System.Drawing.Size(290, 52);
            this.ImageButtonAPPLYlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageButtonAPPLYlogin.TabIndex = 14;
            this.ImageButtonAPPLYlogin.TabStop = false;
            this.ImageButtonAPPLYlogin.Zoom = 10;
            this.ImageButtonAPPLYlogin.Click += new System.EventHandler(this.bunifuImageButtonAPPLYlogin_Click);
            // 
            // textboxPASSlogin
            // 
            this.textboxPASSlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPASSlogin.BackColor = System.Drawing.Color.Black;
            this.textboxPASSlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxPASSlogin.BackgroundImage")));
            this.textboxPASSlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxPASSlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPASSlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPASSlogin.ForeColor = System.Drawing.Color.SpringGreen;
            this.textboxPASSlogin.Icon = ((System.Drawing.Image)(resources.GetObject("textboxPASSlogin.Icon")));
            this.textboxPASSlogin.Location = new System.Drawing.Point(52, 123);
            this.textboxPASSlogin.Name = "textboxPASSlogin";
            this.textboxPASSlogin.Size = new System.Drawing.Size(290, 28);
            this.textboxPASSlogin.TabIndex = 11;
            this.textboxPASSlogin.text = "";
            this.textboxPASSlogin.OnTextChange += new System.EventHandler(this.bunifuTextboxPASSlogin_OnTextChange);
            // 
            // textboxEMAILlogin
            // 
            this.textboxEMAILlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxEMAILlogin.BackColor = System.Drawing.Color.Black;
            this.textboxEMAILlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxEMAILlogin.BackgroundImage")));
            this.textboxEMAILlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxEMAILlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxEMAILlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textboxEMAILlogin.ForeColor = System.Drawing.Color.SpringGreen;
            this.textboxEMAILlogin.Icon = ((System.Drawing.Image)(resources.GetObject("textboxEMAILlogin.Icon")));
            this.textboxEMAILlogin.Location = new System.Drawing.Point(52, 64);
            this.textboxEMAILlogin.Name = "textboxEMAILlogin";
            this.textboxEMAILlogin.Size = new System.Drawing.Size(290, 28);
            this.textboxEMAILlogin.TabIndex = 10;
            this.textboxEMAILlogin.text = "";
            this.textboxEMAILlogin.OnTextChange += new System.EventHandler(this.bunifuTextboxEMAILlogin_OnTextChange);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 247);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.xuiSlidingPanelREGISTRATION);
            this.Controls.Add(this.xuiSlidingPanelForgotPass);
            this.Controls.Add(this.ImageButtonAPPLYlogin);
            this.Controls.Add(this.PASSlabel);
            this.Controls.Add(this.EMAILlabel);
            this.Controls.Add(this.textboxPASSlogin);
            this.Controls.Add(this.textboxEMAILlogin);
            this.Controls.Add(this.metroLinkForgotPassword);
            this.Controls.Add(this.metroLinkRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormLogIn";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formLogIn_Load);
            this.xuiSlidingPanelForgotPass.ResumeLayout(false);
            this.xuiSlidingPanelForgotPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonAPPLYforgotPassword)).EndInit();
            this.xuiSlidingPanelREGISTRATION.ResumeLayout(false);
            this.xuiSlidingPanelREGISTRATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonREGISTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK_Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageButtonAPPLYlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink metroLinkForgotPassword;
        private MetroFramework.Controls.MetroLink metroLinkRegister;
        private Bunifu.Framework.UI.BunifuTextbox textboxPASSlogin;
        private Bunifu.Framework.UI.BunifuTextbox textboxEMAILlogin;
        private Bunifu.Framework.UI.BunifuImageButton ImageButtonAPPLYlogin;
        private MetroFramework.Controls.MetroLabel PASSlabel;
        private MetroFramework.Controls.MetroLabel EMAILlabel;
        private XanderUI.XUIObjectAnimator buttonAnimate;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private XanderUI.XUIObjectEllipse EllipseForm;
        private XanderUI.XUISlidingPanel xuiSlidingPanelForgotPass;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBACK;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonAPPLYforgotPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox textBox_ForgotPass;
        private System.Windows.Forms.Label labelREGISTRATION;
        private XanderUI.XUISlidingPanel xuiSlidingPanelREGISTRATION;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBACK_Reg;
        private Bunifu.Framework.UI.BunifuImageButton ButtonREGISTER;
        private Guna.UI.WinForms.GunaLineTextBox textBoxREPEAT_PASS_reg;
        private Guna.UI.WinForms.GunaLineTextBox textBoxPASS_reg;
        private Guna.UI.WinForms.GunaLineTextBox textBoxEMAIL_reg;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelHead;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBoxCheckSendedNum;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxProtectionCode_reg;
        private Guna.UI.WinForms.GunaCircleButton buttonProtectionCode_reg;
        private Guna.UI.WinForms.GunaCircleButton imageButtonCheckNum;
    }
}


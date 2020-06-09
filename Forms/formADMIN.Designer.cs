namespace TRPO_Project
{
    partial class formADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formADMIN));
            this.ProgressBar = new XanderUI.XUICircleProgressBar();
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.EllipseForm = new XanderUI.XUIObjectEllipse();
            this.button_backToLoginForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBoxHEAD = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelPRICE = new System.Windows.Forms.Label();
            this.bunifuImageButtonSORT = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButtonADMINPANEL = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelCPU = new System.Windows.Forms.Label();
            this.pictureBoxProductBIN = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroComboBoxCPUsort = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTYPEofPC = new MetroFramework.Controls.MetroComboBox();
            this.labelTYPEofPC = new System.Windows.Forms.Label();
            this.metroComboBoxGPUsort = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxRAM = new MetroFramework.Controls.MetroComboBox();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonHelp = new Guna.UI.WinForms.GunaGradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.button_backToLoginForm)).BeginInit();
            this.groupBoxHEAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonADMINPANEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductBIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.AnimationSpeed = 10;
            this.ProgressBar.FilledColor = System.Drawing.Color.LightBlue;
            this.ProgressBar.FilledColorAlpha = 90;
            this.ProgressBar.FilledThickness = 40;
            this.ProgressBar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.IsAnimated = false;
            this.ProgressBar.Location = new System.Drawing.Point(540, 240);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Percentage = 0;
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.ShowText = true;
            this.ProgressBar.Size = new System.Drawing.Size(225, 225);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.TextColor = System.Drawing.Color.LightSeaGreen;
            this.ProgressBar.TextSize = 30;
            this.ProgressBar.UnFilledColor = System.Drawing.Color.PaleGreen;
            this.ProgressBar.UnfilledThickness = 24;
            this.ProgressBar.Visible = false;
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
            // button_backToLoginForm
            // 
            this.button_backToLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.button_backToLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_backToLoginForm.Image = global::TRPO_Project.Properties.Resources.exit_sign_64px;
            this.button_backToLoginForm.ImageActive = null;
            this.button_backToLoginForm.Location = new System.Drawing.Point(751, 11);
            this.button_backToLoginForm.Name = "button_backToLoginForm";
            this.button_backToLoginForm.Size = new System.Drawing.Size(40, 40);
            this.button_backToLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_backToLoginForm.TabIndex = 16;
            this.button_backToLoginForm.TabStop = false;
            this.button_backToLoginForm.Zoom = 5;
            this.button_backToLoginForm.Click += new System.EventHandler(this.button_backToLoginForm_Click);
            // 
            // groupBoxHEAD
            // 
            this.groupBoxHEAD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxHEAD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxHEAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxHEAD.BackgroundImage")));
            this.groupBoxHEAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxHEAD.CausesValidation = false;
            this.groupBoxHEAD.Controls.Add(this.labelPRICE);
            this.groupBoxHEAD.Controls.Add(this.button_backToLoginForm);
            this.groupBoxHEAD.Controls.Add(this.bunifuImageButtonSORT);
            this.groupBoxHEAD.Controls.Add(this.textBox_PRICE);
            this.groupBoxHEAD.Controls.Add(this.bunifuImageButtonADMINPANEL);
            this.groupBoxHEAD.Controls.Add(this.labelRAM);
            this.groupBoxHEAD.Controls.Add(this.labelGPU);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProfile);
            this.groupBoxHEAD.Controls.Add(this.labelCPU);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProductBIN);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxCPUsort);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxTYPEofPC);
            this.groupBoxHEAD.Controls.Add(this.labelTYPEofPC);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxGPUsort);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxRAM);
            this.groupBoxHEAD.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHEAD.GradientBottomLeft = System.Drawing.Color.Blue;
            this.groupBoxHEAD.GradientBottomRight = System.Drawing.Color.Magenta;
            this.groupBoxHEAD.GradientTopLeft = System.Drawing.Color.Plum;
            this.groupBoxHEAD.GradientTopRight = System.Drawing.Color.Aqua;
            this.groupBoxHEAD.Location = new System.Drawing.Point(0, 32);
            this.groupBoxHEAD.Name = "groupBoxHEAD";
            this.groupBoxHEAD.Quality = 100;
            this.groupBoxHEAD.Size = new System.Drawing.Size(796, 56);
            this.groupBoxHEAD.TabIndex = 15;
            // 
            // labelPRICE
            // 
            this.labelPRICE.AutoSize = true;
            this.labelPRICE.BackColor = System.Drawing.Color.Transparent;
            this.labelPRICE.ForeColor = System.Drawing.Color.Cyan;
            this.labelPRICE.Location = new System.Drawing.Point(29, 4);
            this.labelPRICE.Name = "labelPRICE";
            this.labelPRICE.Size = new System.Drawing.Size(47, 15);
            this.labelPRICE.TabIndex = 19;
            this.labelPRICE.Text = "PRICE";
            // 
            // bunifuImageButtonSORT
            // 
            this.bunifuImageButtonSORT.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonSORT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonSORT.Image = global::TRPO_Project.Properties.Resources.sort;
            this.bunifuImageButtonSORT.ImageActive = null;
            this.bunifuImageButtonSORT.Location = new System.Drawing.Point(547, 11);
            this.bunifuImageButtonSORT.Name = "bunifuImageButtonSORT";
            this.bunifuImageButtonSORT.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonSORT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSORT.TabIndex = 16;
            this.bunifuImageButtonSORT.TabStop = false;
            this.bunifuImageButtonSORT.WaitOnLoad = true;
            this.bunifuImageButtonSORT.Zoom = 10;
            this.bunifuImageButtonSORT.Click += new System.EventHandler(this.bunifuImageButtonSORT_Click);
            // 
            // textBox_PRICE
            // 
            this.textBox_PRICE.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_PRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PRICE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_PRICE.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_PRICE.HintForeColor = System.Drawing.Color.Empty;
            this.textBox_PRICE.HintText = "";
            this.textBox_PRICE.isPassword = false;
            this.textBox_PRICE.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.textBox_PRICE.LineIdleColor = System.Drawing.Color.MediumBlue;
            this.textBox_PRICE.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.textBox_PRICE.LineThickness = 3;
            this.textBox_PRICE.Location = new System.Drawing.Point(13, 21);
            this.textBox_PRICE.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PRICE.Name = "textBox_PRICE";
            this.textBox_PRICE.Size = new System.Drawing.Size(83, 24);
            this.textBox_PRICE.TabIndex = 1;
            this.textBox_PRICE.TabStop = false;
            this.textBox_PRICE.Text = "$0-9999";
            this.textBox_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_PRICE.Enter += new System.EventHandler(this.textBox_PRICE_Enter);
            this.textBox_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PRICE_KeyPress);
            this.textBox_PRICE.Leave += new System.EventHandler(this.textBox_PRICE_Leave);
            // 
            // bunifuImageButtonADMINPANEL
            // 
            this.bunifuImageButtonADMINPANEL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonADMINPANEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonADMINPANEL.Image = global::TRPO_Project.Properties.Resources.w400h4001341689813administrator;
            this.bunifuImageButtonADMINPANEL.ImageActive = null;
            this.bunifuImageButtonADMINPANEL.Location = new System.Drawing.Point(703, 11);
            this.bunifuImageButtonADMINPANEL.Name = "bunifuImageButtonADMINPANEL";
            this.bunifuImageButtonADMINPANEL.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonADMINPANEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButtonADMINPANEL.TabIndex = 14;
            this.bunifuImageButtonADMINPANEL.TabStop = false;
            this.bunifuImageButtonADMINPANEL.Zoom = 5;
            this.bunifuImageButtonADMINPANEL.Click += new System.EventHandler(this.bunifuImageButtonADMINPANEL_Click);
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.BackColor = System.Drawing.Color.Transparent;
            this.labelRAM.ForeColor = System.Drawing.Color.Cyan;
            this.labelRAM.Location = new System.Drawing.Point(472, 4);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(31, 15);
            this.labelRAM.TabIndex = 10;
            this.labelRAM.Text = "RAM";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.BackColor = System.Drawing.Color.Transparent;
            this.labelGPU.ForeColor = System.Drawing.Color.Cyan;
            this.labelGPU.Location = new System.Drawing.Point(363, 4);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(31, 15);
            this.labelGPU.TabIndex = 9;
            this.labelGPU.Text = "GPU";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProfile.Image = global::TRPO_Project.Properties.Resources.profile_default;
            this.pictureBoxProfile.ImageActive = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(654, 11);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Zoom = 5;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.BackColor = System.Drawing.Color.Transparent;
            this.labelCPU.ForeColor = System.Drawing.Color.Cyan;
            this.labelCPU.Location = new System.Drawing.Point(249, 4);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(31, 15);
            this.labelCPU.TabIndex = 8;
            this.labelCPU.Text = "CPU";
            // 
            // pictureBoxProductBIN
            // 
            this.pictureBoxProductBIN.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProductBIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProductBIN.Image = global::TRPO_Project.Properties.Resources.shopping_cart;
            this.pictureBoxProductBIN.ImageActive = null;
            this.pictureBoxProductBIN.Location = new System.Drawing.Point(598, 11);
            this.pictureBoxProductBIN.Name = "pictureBoxProductBIN";
            this.pictureBoxProductBIN.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxProductBIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductBIN.TabIndex = 3;
            this.pictureBoxProductBIN.TabStop = false;
            this.pictureBoxProductBIN.Zoom = 5;
            this.pictureBoxProductBIN.Click += new System.EventHandler(this.pictureBoxProductBIN_Click);
            // 
            // metroComboBoxCPUsort
            // 
            this.metroComboBoxCPUsort.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxCPUsort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxCPUsort.DisplayFocus = true;
            this.metroComboBoxCPUsort.DropDownWidth = 150;
            this.metroComboBoxCPUsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxCPUsort.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxCPUsort.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxCPUsort.ItemHeight = 19;
            this.metroComboBoxCPUsort.Location = new System.Drawing.Point(211, 20);
            this.metroComboBoxCPUsort.Name = "metroComboBoxCPUsort";
            this.metroComboBoxCPUsort.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxCPUsort.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxCPUsort.TabIndex = 3;
            this.metroComboBoxCPUsort.UseCustomBackColor = true;
            this.metroComboBoxCPUsort.UseCustomForeColor = true;
            this.metroComboBoxCPUsort.UseSelectable = true;
            // 
            // metroComboBoxTYPEofPC
            // 
            this.metroComboBoxTYPEofPC.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxTYPEofPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxTYPEofPC.DisplayFocus = true;
            this.metroComboBoxTYPEofPC.DropDownWidth = 100;
            this.metroComboBoxTYPEofPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxTYPEofPC.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxTYPEofPC.ForeColor = System.Drawing.Color.Aquamarine;
            this.metroComboBoxTYPEofPC.FormattingEnabled = true;
            this.metroComboBoxTYPEofPC.ItemHeight = 19;
            this.metroComboBoxTYPEofPC.Location = new System.Drawing.Point(100, 20);
            this.metroComboBoxTYPEofPC.Name = "metroComboBoxTYPEofPC";
            this.metroComboBoxTYPEofPC.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxTYPEofPC.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBoxTYPEofPC.TabIndex = 2;
            this.metroComboBoxTYPEofPC.UseCustomBackColor = true;
            this.metroComboBoxTYPEofPC.UseCustomForeColor = true;
            this.metroComboBoxTYPEofPC.UseSelectable = true;
            // 
            // labelTYPEofPC
            // 
            this.labelTYPEofPC.AutoSize = true;
            this.labelTYPEofPC.BackColor = System.Drawing.Color.Transparent;
            this.labelTYPEofPC.ForeColor = System.Drawing.Color.Cyan;
            this.labelTYPEofPC.Location = new System.Drawing.Point(118, 4);
            this.labelTYPEofPC.Name = "labelTYPEofPC";
            this.labelTYPEofPC.Size = new System.Drawing.Size(71, 15);
            this.labelTYPEofPC.TabIndex = 7;
            this.labelTYPEofPC.Text = "TypeOfPC";
            // 
            // metroComboBoxGPUsort
            // 
            this.metroComboBoxGPUsort.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxGPUsort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxGPUsort.DisplayFocus = true;
            this.metroComboBoxGPUsort.DropDownWidth = 160;
            this.metroComboBoxGPUsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxGPUsort.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxGPUsort.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxGPUsort.FormattingEnabled = true;
            this.metroComboBoxGPUsort.ItemHeight = 19;
            this.metroComboBoxGPUsort.Location = new System.Drawing.Point(322, 20);
            this.metroComboBoxGPUsort.Name = "metroComboBoxGPUsort";
            this.metroComboBoxGPUsort.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxGPUsort.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxGPUsort.TabIndex = 4;
            this.metroComboBoxGPUsort.UseCustomBackColor = true;
            this.metroComboBoxGPUsort.UseCustomForeColor = true;
            this.metroComboBoxGPUsort.UseSelectable = true;
            // 
            // metroComboBoxRAM
            // 
            this.metroComboBoxRAM.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroComboBoxRAM.DisplayFocus = true;
            this.metroComboBoxRAM.DropDownWidth = 80;
            this.metroComboBoxRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxRAM.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxRAM.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.metroComboBoxRAM.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxRAM.FormattingEnabled = true;
            this.metroComboBoxRAM.ItemHeight = 19;
            this.metroComboBoxRAM.Location = new System.Drawing.Point(433, 20);
            this.metroComboBoxRAM.Name = "metroComboBoxRAM";
            this.metroComboBoxRAM.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxRAM.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBoxRAM.TabIndex = 5;
            this.metroComboBoxRAM.UseCustomBackColor = true;
            this.metroComboBoxRAM.UseCustomForeColor = true;
            this.metroComboBoxRAM.UseSelectable = true;
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.Crimson;
            this.bunifuImageButtonEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(768, 8);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 2;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // panelHead
            // 
            this.panelHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Controls.Add(this.buttonHelp);
            this.panelHead.Location = new System.Drawing.Point(0, 5);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(796, 28);
            this.panelHead.TabIndex = 16;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // buttonHelp
            // 
            this.buttonHelp.AnimationHoverSpeed = 0.15F;
            this.buttonHelp.AnimationSpeed = 0.03F;
            this.buttonHelp.BaseColor1 = System.Drawing.Color.DarkBlue;
            this.buttonHelp.BaseColor2 = System.Drawing.Color.Indigo;
            this.buttonHelp.BorderColor = System.Drawing.Color.Red;
            this.buttonHelp.BorderSize = 1;
            this.buttonHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonHelp.FocusedColor = System.Drawing.Color.Empty;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Image = global::TRPO_Project.Properties.Resources.help_64px;
            this.buttonHelp.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonHelp.Location = new System.Drawing.Point(12, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.OnHoverBaseColor1 = System.Drawing.Color.Orchid;
            this.buttonHelp.OnHoverBaseColor2 = System.Drawing.Color.DarkSlateBlue;
            this.buttonHelp.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.buttonHelp.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonHelp.OnHoverImage = null;
            this.buttonHelp.OnPressedColor = System.Drawing.Color.OrangeRed;
            this.buttonHelp.Size = new System.Drawing.Size(20, 20);
            this.buttonHelp.TabIndex = 17;
            this.buttonHelp.TabStop = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // formADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(796, 470);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.groupBoxHEAD);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formADMIN";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.button_backToLoginForm)).EndInit();
            this.groupBoxHEAD.ResumeLayout(false);
            this.groupBoxHEAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonADMINPANEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductBIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUICircleProgressBar ProgressBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonADMINPANEL;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private Bunifu.Framework.UI.BunifuGradientPanel groupBoxHEAD;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelGPU;
        private Bunifu.Framework.UI.BunifuImageButton pictureBoxProfile;
        private System.Windows.Forms.Label labelCPU;
        private Bunifu.Framework.UI.BunifuImageButton pictureBoxProductBIN;
        private MetroFramework.Controls.MetroComboBox metroComboBoxCPUsort;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTYPEofPC;
        private System.Windows.Forms.Label labelTYPEofPC;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGPUsort;
        private MetroFramework.Controls.MetroComboBox metroComboBoxRAM;
        private XanderUI.XUIObjectEllipse EllipseForm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_PRICE;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonSORT;
        private Bunifu.Framework.UI.BunifuImageButton button_backToLoginForm;
        private System.Windows.Forms.Label labelPRICE;
        private System.Windows.Forms.Panel panelHead;
        private Guna.UI.WinForms.GunaGradientCircleButton buttonHelp;
    }
}

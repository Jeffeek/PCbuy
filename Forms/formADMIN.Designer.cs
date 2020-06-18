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
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.EllipseForm = new XanderUI.XUIObjectEllipse();
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonHelp = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.buttonAnimator = new XanderUI.XUIObjectAnimator();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBoxHEAD = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button_backToLoginForm = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.bunifuImageButtonADMINPANEL = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.pictureBoxProfile = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.pictureBoxProductBIN = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.bunifuImageButtonSORT = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.labelPRICE = new System.Windows.Forms.Label();
            this.textBox_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelTYPEofPC = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.metroComboBoxTYPEofPC = new Guna.UI.WinForms.GunaComboBox();
            this.metroComboBoxCPUsort = new Guna.UI.WinForms.GunaComboBox();
            this.metroComboBoxRAM = new Guna.UI.WinForms.GunaComboBox();
            this.metroComboBoxGPUsort = new Guna.UI.WinForms.GunaComboBox();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            this.groupBoxHEAD.SuspendLayout();
            this.SuspendLayout();
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
            // gunaColorTransition1
            // 
            this.gunaColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition1.EndColor = System.Drawing.Color.Blue;
            this.gunaColorTransition1.StartColor = System.Drawing.Color.Red;
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.Crimson;
            this.bunifuImageButtonEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(762, 8);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 2;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // groupBoxHEAD
            // 
            this.groupBoxHEAD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxHEAD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxHEAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxHEAD.BackgroundImage")));
            this.groupBoxHEAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxHEAD.CausesValidation = false;
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxRAM);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxGPUsort);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxCPUsort);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxTYPEofPC);
            this.groupBoxHEAD.Controls.Add(this.button_backToLoginForm);
            this.groupBoxHEAD.Controls.Add(this.bunifuImageButtonADMINPANEL);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProfile);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProductBIN);
            this.groupBoxHEAD.Controls.Add(this.bunifuImageButtonSORT);
            this.groupBoxHEAD.Controls.Add(this.labelPRICE);
            this.groupBoxHEAD.Controls.Add(this.textBox_PRICE);
            this.groupBoxHEAD.Controls.Add(this.labelRAM);
            this.groupBoxHEAD.Controls.Add(this.labelGPU);
            this.groupBoxHEAD.Controls.Add(this.labelCPU);
            this.groupBoxHEAD.Controls.Add(this.labelTYPEofPC);
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
            // button_backToLoginForm
            // 
            this.button_backToLoginForm.Animated = true;
            this.button_backToLoginForm.AnimationHoverSpeed = 0.07F;
            this.button_backToLoginForm.AnimationSpeed = 0.03F;
            this.button_backToLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.button_backToLoginForm.BaseColor1 = System.Drawing.Color.Transparent;
            this.button_backToLoginForm.BaseColor2 = System.Drawing.Color.Transparent;
            this.button_backToLoginForm.BorderColor = System.Drawing.Color.Black;
            this.button_backToLoginForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_backToLoginForm.FocusedColor = System.Drawing.Color.Empty;
            this.button_backToLoginForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_backToLoginForm.ForeColor = System.Drawing.Color.White;
            this.button_backToLoginForm.Image = global::TRPO_Project.Properties.Resources.exit_sign_64px;
            this.button_backToLoginForm.ImageSize = new System.Drawing.Size(40, 40);
            this.button_backToLoginForm.Location = new System.Drawing.Point(752, 11);
            this.button_backToLoginForm.Name = "button_backToLoginForm";
            this.button_backToLoginForm.OnHoverBaseColor1 = System.Drawing.Color.Honeydew;
            this.button_backToLoginForm.OnHoverBaseColor2 = System.Drawing.Color.Ivory;
            this.button_backToLoginForm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_backToLoginForm.OnHoverForeColor = System.Drawing.Color.White;
            this.button_backToLoginForm.OnHoverImage = null;
            this.button_backToLoginForm.OnPressedColor = System.Drawing.Color.Black;
            this.button_backToLoginForm.OnPressedDepth = 50;
            this.button_backToLoginForm.Size = new System.Drawing.Size(40, 40);
            this.button_backToLoginForm.TabIndex = 24;
            this.button_backToLoginForm.TabStop = false;
            this.button_backToLoginForm.Click += new System.EventHandler(this.button_backToLoginForm_Click);
            // 
            // bunifuImageButtonADMINPANEL
            // 
            this.bunifuImageButtonADMINPANEL.Animated = true;
            this.bunifuImageButtonADMINPANEL.AnimationHoverSpeed = 0.07F;
            this.bunifuImageButtonADMINPANEL.AnimationSpeed = 0.03F;
            this.bunifuImageButtonADMINPANEL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonADMINPANEL.BaseColor1 = System.Drawing.Color.Transparent;
            this.bunifuImageButtonADMINPANEL.BaseColor2 = System.Drawing.Color.Transparent;
            this.bunifuImageButtonADMINPANEL.BorderColor = System.Drawing.Color.Black;
            this.bunifuImageButtonADMINPANEL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButtonADMINPANEL.FocusedColor = System.Drawing.Color.Empty;
            this.bunifuImageButtonADMINPANEL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuImageButtonADMINPANEL.ForeColor = System.Drawing.Color.White;
            this.bunifuImageButtonADMINPANEL.Image = global::TRPO_Project.Properties.Resources.admin_settings_male_64px;
            this.bunifuImageButtonADMINPANEL.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonADMINPANEL.Location = new System.Drawing.Point(700, 11);
            this.bunifuImageButtonADMINPANEL.Name = "bunifuImageButtonADMINPANEL";
            this.bunifuImageButtonADMINPANEL.OnHoverBaseColor1 = System.Drawing.Color.Honeydew;
            this.bunifuImageButtonADMINPANEL.OnHoverBaseColor2 = System.Drawing.Color.Ivory;
            this.bunifuImageButtonADMINPANEL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bunifuImageButtonADMINPANEL.OnHoverForeColor = System.Drawing.Color.White;
            this.bunifuImageButtonADMINPANEL.OnHoverImage = null;
            this.bunifuImageButtonADMINPANEL.OnPressedColor = System.Drawing.Color.Black;
            this.bunifuImageButtonADMINPANEL.OnPressedDepth = 50;
            this.bunifuImageButtonADMINPANEL.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonADMINPANEL.TabIndex = 23;
            this.bunifuImageButtonADMINPANEL.TabStop = false;
            this.bunifuImageButtonADMINPANEL.Click += new System.EventHandler(this.bunifuImageButtonADMINPANEL_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Animated = true;
            this.pictureBoxProfile.AnimationHoverSpeed = 0.07F;
            this.pictureBoxProfile.AnimationSpeed = 0.03F;
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BaseColor1 = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BaseColor2 = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BorderColor = System.Drawing.Color.Black;
            this.pictureBoxProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pictureBoxProfile.FocusedColor = System.Drawing.Color.Empty;
            this.pictureBoxProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pictureBoxProfile.ForeColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Image = global::TRPO_Project.Properties.Resources.account_64px;
            this.pictureBoxProfile.ImageSize = new System.Drawing.Size(40, 40);
            this.pictureBoxProfile.Location = new System.Drawing.Point(648, 11);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.OnHoverBaseColor1 = System.Drawing.Color.Honeydew;
            this.pictureBoxProfile.OnHoverBaseColor2 = System.Drawing.Color.Ivory;
            this.pictureBoxProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pictureBoxProfile.OnHoverForeColor = System.Drawing.Color.White;
            this.pictureBoxProfile.OnHoverImage = null;
            this.pictureBoxProfile.OnPressedColor = System.Drawing.Color.Black;
            this.pictureBoxProfile.OnPressedDepth = 50;
            this.pictureBoxProfile.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxProfile.TabIndex = 22;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // pictureBoxProductBIN
            // 
            this.pictureBoxProductBIN.Animated = true;
            this.pictureBoxProductBIN.AnimationHoverSpeed = 0.07F;
            this.pictureBoxProductBIN.AnimationSpeed = 0.03F;
            this.pictureBoxProductBIN.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProductBIN.BaseColor1 = System.Drawing.Color.Transparent;
            this.pictureBoxProductBIN.BaseColor2 = System.Drawing.Color.Transparent;
            this.pictureBoxProductBIN.BorderColor = System.Drawing.Color.Black;
            this.pictureBoxProductBIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pictureBoxProductBIN.FocusedColor = System.Drawing.Color.Empty;
            this.pictureBoxProductBIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pictureBoxProductBIN.ForeColor = System.Drawing.Color.White;
            this.pictureBoxProductBIN.Image = global::TRPO_Project.Properties.Resources.shopping_cart_64px;
            this.pictureBoxProductBIN.ImageSize = new System.Drawing.Size(40, 40);
            this.pictureBoxProductBIN.Location = new System.Drawing.Point(596, 11);
            this.pictureBoxProductBIN.Name = "pictureBoxProductBIN";
            this.pictureBoxProductBIN.OnHoverBaseColor1 = System.Drawing.Color.Honeydew;
            this.pictureBoxProductBIN.OnHoverBaseColor2 = System.Drawing.Color.Ivory;
            this.pictureBoxProductBIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pictureBoxProductBIN.OnHoverForeColor = System.Drawing.Color.White;
            this.pictureBoxProductBIN.OnHoverImage = null;
            this.pictureBoxProductBIN.OnPressedColor = System.Drawing.Color.Black;
            this.pictureBoxProductBIN.OnPressedDepth = 50;
            this.pictureBoxProductBIN.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxProductBIN.TabIndex = 21;
            this.pictureBoxProductBIN.TabStop = false;
            this.pictureBoxProductBIN.Click += new System.EventHandler(this.pictureBoxProductBIN_Click);
            // 
            // bunifuImageButtonSORT
            // 
            this.bunifuImageButtonSORT.Animated = true;
            this.bunifuImageButtonSORT.AnimationHoverSpeed = 0.07F;
            this.bunifuImageButtonSORT.AnimationSpeed = 0.03F;
            this.bunifuImageButtonSORT.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonSORT.BaseColor1 = System.Drawing.Color.Transparent;
            this.bunifuImageButtonSORT.BaseColor2 = System.Drawing.Color.Transparent;
            this.bunifuImageButtonSORT.BorderColor = System.Drawing.Color.Black;
            this.bunifuImageButtonSORT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButtonSORT.FocusedColor = System.Drawing.Color.Empty;
            this.bunifuImageButtonSORT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuImageButtonSORT.ForeColor = System.Drawing.Color.White;
            this.bunifuImageButtonSORT.Image = global::TRPO_Project.Properties.Resources.sort;
            this.bunifuImageButtonSORT.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonSORT.Location = new System.Drawing.Point(544, 11);
            this.bunifuImageButtonSORT.Name = "bunifuImageButtonSORT";
            this.bunifuImageButtonSORT.OnHoverBaseColor1 = System.Drawing.Color.Honeydew;
            this.bunifuImageButtonSORT.OnHoverBaseColor2 = System.Drawing.Color.Ivory;
            this.bunifuImageButtonSORT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bunifuImageButtonSORT.OnHoverForeColor = System.Drawing.Color.White;
            this.bunifuImageButtonSORT.OnHoverImage = null;
            this.bunifuImageButtonSORT.OnPressedColor = System.Drawing.Color.Black;
            this.bunifuImageButtonSORT.OnPressedDepth = 50;
            this.bunifuImageButtonSORT.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButtonSORT.TabIndex = 20;
            this.bunifuImageButtonSORT.TabStop = false;
            this.bunifuImageButtonSORT.Click += new System.EventHandler(this.bunifuImageButtonSORT_Click);
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
            this.textBox_PRICE.LineIdleColor = System.Drawing.Color.DarkTurquoise;
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
            // ProgressBar
            // 
            this.ProgressBar.Animated = true;
            this.ProgressBar.AnimationSpeed = 0.6F;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BaseColor = System.Drawing.Color.Transparent;
            this.ProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition;
            this.ProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.ProgressBar.IdleColor = System.Drawing.Color.Transparent;
            this.ProgressBar.IdleOffset = 20;
            this.ProgressBar.Image = null;
            this.ProgressBar.ImageSize = new System.Drawing.Size(52, 52);
            this.ProgressBar.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressBar.Location = new System.Drawing.Point(557, 232);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressMaxColor = System.Drawing.Color.MediumBlue;
            this.ProgressBar.ProgressMinColor = System.Drawing.Color.MediumOrchid;
            this.ProgressBar.ProgressOffset = 15;
            this.ProgressBar.ProgressThickness = 20;
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressBar.Size = new System.Drawing.Size(225, 225);
            this.ProgressBar.TabIndex = 17;
            this.ProgressBar.TabStop = false;
            this.ProgressBar.Visible = false;
            // 
            // metroComboBoxTYPEofPC
            // 
            this.metroComboBoxTYPEofPC.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBoxTYPEofPC.BaseColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxTYPEofPC.BorderColor = System.Drawing.Color.Silver;
            this.metroComboBoxTYPEofPC.BorderSize = 1;
            this.metroComboBoxTYPEofPC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxTYPEofPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxTYPEofPC.FocusedColor = System.Drawing.Color.Empty;
            this.metroComboBoxTYPEofPC.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroComboBoxTYPEofPC.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.metroComboBoxTYPEofPC.FormattingEnabled = true;
            this.metroComboBoxTYPEofPC.ItemHeight = 16;
            this.metroComboBoxTYPEofPC.Location = new System.Drawing.Point(100, 22);
            this.metroComboBoxTYPEofPC.Name = "metroComboBoxTYPEofPC";
            this.metroComboBoxTYPEofPC.OnHoverItemBaseColor = System.Drawing.Color.PowderBlue;
            this.metroComboBoxTYPEofPC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.metroComboBoxTYPEofPC.Radius = 10;
            this.metroComboBoxTYPEofPC.Size = new System.Drawing.Size(105, 22);
            this.metroComboBoxTYPEofPC.TabIndex = 18;
            // 
            // metroComboBoxCPUsort
            // 
            this.metroComboBoxCPUsort.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBoxCPUsort.BaseColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxCPUsort.BorderColor = System.Drawing.Color.Silver;
            this.metroComboBoxCPUsort.BorderSize = 1;
            this.metroComboBoxCPUsort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxCPUsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxCPUsort.DropDownWidth = 180;
            this.metroComboBoxCPUsort.FocusedColor = System.Drawing.Color.Empty;
            this.metroComboBoxCPUsort.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroComboBoxCPUsort.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.metroComboBoxCPUsort.FormattingEnabled = true;
            this.metroComboBoxCPUsort.ItemHeight = 16;
            this.metroComboBoxCPUsort.Location = new System.Drawing.Point(211, 22);
            this.metroComboBoxCPUsort.Name = "metroComboBoxCPUsort";
            this.metroComboBoxCPUsort.OnHoverItemBaseColor = System.Drawing.Color.PowderBlue;
            this.metroComboBoxCPUsort.OnHoverItemForeColor = System.Drawing.Color.White;
            this.metroComboBoxCPUsort.Radius = 10;
            this.metroComboBoxCPUsort.Size = new System.Drawing.Size(105, 22);
            this.metroComboBoxCPUsort.TabIndex = 25;
            // 
            // metroComboBoxRAM
            // 
            this.metroComboBoxRAM.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBoxRAM.BaseColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxRAM.BorderColor = System.Drawing.Color.Silver;
            this.metroComboBoxRAM.BorderSize = 1;
            this.metroComboBoxRAM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxRAM.FocusedColor = System.Drawing.Color.Empty;
            this.metroComboBoxRAM.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroComboBoxRAM.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.metroComboBoxRAM.FormattingEnabled = true;
            this.metroComboBoxRAM.ItemHeight = 16;
            this.metroComboBoxRAM.Location = new System.Drawing.Point(433, 22);
            this.metroComboBoxRAM.Name = "metroComboBoxRAM";
            this.metroComboBoxRAM.OnHoverItemBaseColor = System.Drawing.Color.PowderBlue;
            this.metroComboBoxRAM.OnHoverItemForeColor = System.Drawing.Color.White;
            this.metroComboBoxRAM.Radius = 10;
            this.metroComboBoxRAM.Size = new System.Drawing.Size(105, 22);
            this.metroComboBoxRAM.TabIndex = 27;
            // 
            // metroComboBoxGPUsort
            // 
            this.metroComboBoxGPUsort.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBoxGPUsort.BaseColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxGPUsort.BorderColor = System.Drawing.Color.Silver;
            this.metroComboBoxGPUsort.BorderSize = 1;
            this.metroComboBoxGPUsort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBoxGPUsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBoxGPUsort.DropDownWidth = 200;
            this.metroComboBoxGPUsort.FocusedColor = System.Drawing.Color.Empty;
            this.metroComboBoxGPUsort.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroComboBoxGPUsort.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.metroComboBoxGPUsort.FormattingEnabled = true;
            this.metroComboBoxGPUsort.ItemHeight = 16;
            this.metroComboBoxGPUsort.Location = new System.Drawing.Point(322, 22);
            this.metroComboBoxGPUsort.Name = "metroComboBoxGPUsort";
            this.metroComboBoxGPUsort.OnHoverItemBaseColor = System.Drawing.Color.PowderBlue;
            this.metroComboBoxGPUsort.OnHoverItemForeColor = System.Drawing.Color.White;
            this.metroComboBoxGPUsort.Radius = 10;
            this.metroComboBoxGPUsort.Size = new System.Drawing.Size(105, 22);
            this.metroComboBoxGPUsort.TabIndex = 26;
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
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.groupBoxHEAD);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formADMIN";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            this.groupBoxHEAD.ResumeLayout(false);
            this.groupBoxHEAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private Bunifu.Framework.UI.BunifuGradientPanel groupBoxHEAD;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelTYPEofPC;
        private XanderUI.XUIObjectEllipse EllipseForm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_PRICE;
        private System.Windows.Forms.Label labelPRICE;
        private System.Windows.Forms.Panel panelHead;
        private Guna.UI.WinForms.GunaGradientCircleButton buttonHelp;
        private XanderUI.XUIObjectAnimator buttonAnimator;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI.WinForms.GunaGradientCircleButton bunifuImageButtonSORT;
        private Guna.UI.WinForms.GunaGradientCircleButton pictureBoxProductBIN;
        private Guna.UI.WinForms.GunaGradientCircleButton button_backToLoginForm;
        private Guna.UI.WinForms.GunaGradientCircleButton bunifuImageButtonADMINPANEL;
        private Guna.UI.WinForms.GunaGradientCircleButton pictureBoxProfile;
        private Guna.UI.WinForms.GunaCircleProgressBar ProgressBar;
        private Guna.UI.WinForms.GunaComboBox metroComboBoxRAM;
        private Guna.UI.WinForms.GunaComboBox metroComboBoxGPUsort;
        private Guna.UI.WinForms.GunaComboBox metroComboBoxCPUsort;
        private Guna.UI.WinForms.GunaComboBox metroComboBoxTYPEofPC;
    }
}

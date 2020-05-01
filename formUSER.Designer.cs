﻿namespace TRPO_Project
{
    partial class formUSER
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUSER));
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.FormEllipse = new XanderUI.XUIObjectEllipse();
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.groupBoxHEAD = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_backToLoginForm = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroComboBoxTYPEofPC = new MetroFramework.Controls.MetroComboBox();
            this.bunifuImageButtonSORT = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelCPU = new System.Windows.Forms.Label();
            this.pictureBoxProductBIN = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroComboBoxCPUsort = new MetroFramework.Controls.MetroComboBox();
            this.labelTYPEofPC = new System.Windows.Forms.Label();
            this.metroComboBoxGPUsort = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxRAM = new MetroFramework.Controls.MetroComboBox();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.groupBoxHEAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_backToLoginForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductBIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 10;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.LightBlue;
            this.xuiCircleProgressBar1.FilledColorAlpha = 90;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(540, 240);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 0;
            this.xuiCircleProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(225, 225);
            this.xuiCircleProgressBar1.TabIndex = 2;
            this.xuiCircleProgressBar1.TabStop = false;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.LightSeaGreen;
            this.xuiCircleProgressBar1.TextSize = 30;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.PaleGreen;
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            this.xuiCircleProgressBar1.Visible = false;
            // 
            // FormEllipse
            // 
            this.FormEllipse.CornerRadius = 15;
            this.FormEllipse.EffectedControl = this;
            this.FormEllipse.EffectedForm = this;
            // 
            // FormStartTransition
            // 
            this.FormStartTransition.Delay = 1;
            // 
            // groupBoxHEAD
            // 
            this.groupBoxHEAD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxHEAD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxHEAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxHEAD.BackgroundImage")));
            this.groupBoxHEAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxHEAD.CausesValidation = false;
            this.groupBoxHEAD.Controls.Add(this.label1);
            this.groupBoxHEAD.Controls.Add(this.button_backToLoginForm);
            this.groupBoxHEAD.Controls.Add(this.textBox_PRICE);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxTYPEofPC);
            this.groupBoxHEAD.Controls.Add(this.bunifuImageButtonSORT);
            this.groupBoxHEAD.Controls.Add(this.labelRAM);
            this.groupBoxHEAD.Controls.Add(this.labelGPU);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProfile);
            this.groupBoxHEAD.Controls.Add(this.labelCPU);
            this.groupBoxHEAD.Controls.Add(this.pictureBoxProductBIN);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxCPUsort);
            this.groupBoxHEAD.Controls.Add(this.labelTYPEofPC);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxGPUsort);
            this.groupBoxHEAD.Controls.Add(this.metroComboBoxRAM);
            this.groupBoxHEAD.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHEAD.GradientBottomLeft = System.Drawing.Color.Black;
            this.groupBoxHEAD.GradientBottomRight = System.Drawing.Color.MediumTurquoise;
            this.groupBoxHEAD.GradientTopLeft = System.Drawing.Color.DarkOrchid;
            this.groupBoxHEAD.GradientTopRight = System.Drawing.Color.MediumSlateBlue;
            this.groupBoxHEAD.Location = new System.Drawing.Point(0, 32);
            this.groupBoxHEAD.Name = "groupBoxHEAD";
            this.groupBoxHEAD.Quality = 100;
            this.groupBoxHEAD.Size = new System.Drawing.Size(796, 56);
            this.groupBoxHEAD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(29, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "PRICE";
            // 
            // button_backToLoginForm
            // 
            this.button_backToLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.button_backToLoginForm.Image = global::TRPO_Project.Properties.Resources.exit_sign_64px;
            this.button_backToLoginForm.ImageActive = null;
            this.button_backToLoginForm.Location = new System.Drawing.Point(748, 9);
            this.button_backToLoginForm.Name = "button_backToLoginForm";
            this.button_backToLoginForm.Size = new System.Drawing.Size(43, 43);
            this.button_backToLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_backToLoginForm.TabIndex = 17;
            this.button_backToLoginForm.TabStop = false;
            this.button_backToLoginForm.Zoom = 5;
            this.button_backToLoginForm.Click += new System.EventHandler(this.button_backToLoginForm_Click);
            // 
            // textBox_PRICE
            // 
            this.textBox_PRICE.BackColor = System.Drawing.Color.White;
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
            this.textBox_PRICE.Size = new System.Drawing.Size(83, 25);
            this.textBox_PRICE.TabIndex = 4;
            this.textBox_PRICE.TabStop = false;
            this.textBox_PRICE.Text = "$0-9999";
            this.textBox_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_PRICE.Enter += new System.EventHandler(this.textBox_PRICE_Enter);
            this.textBox_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PRICE_KeyPress);
            this.textBox_PRICE.Leave += new System.EventHandler(this.textBox_PRICE_Leave);
            // 
            // metroComboBoxTYPEofPC
            // 
            this.metroComboBoxTYPEofPC.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxTYPEofPC.DropDownWidth = 140;
            this.metroComboBoxTYPEofPC.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxTYPEofPC.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.metroComboBoxTYPEofPC.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxTYPEofPC.FormattingEnabled = true;
            this.metroComboBoxTYPEofPC.ItemHeight = 19;
            this.metroComboBoxTYPEofPC.Items.AddRange(new object[] {
            "<не выбрано>"});
            this.metroComboBoxTYPEofPC.Location = new System.Drawing.Point(104, 20);
            this.metroComboBoxTYPEofPC.Name = "metroComboBoxTYPEofPC";
            this.metroComboBoxTYPEofPC.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxTYPEofPC.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxTYPEofPC.TabIndex = 15;
            this.metroComboBoxTYPEofPC.TabStop = false;
            this.metroComboBoxTYPEofPC.UseCustomBackColor = true;
            this.metroComboBoxTYPEofPC.UseCustomForeColor = true;
            this.metroComboBoxTYPEofPC.UseSelectable = true;
            this.metroComboBoxTYPEofPC.UseStyleColors = true;
            // 
            // bunifuImageButtonSORT
            // 
            this.bunifuImageButtonSORT.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonSORT.Image = global::TRPO_Project.Properties.Resources.sort;
            this.bunifuImageButtonSORT.ImageActive = null;
            this.bunifuImageButtonSORT.Location = new System.Drawing.Point(560, 9);
            this.bunifuImageButtonSORT.Name = "bunifuImageButtonSORT";
            this.bunifuImageButtonSORT.Size = new System.Drawing.Size(43, 43);
            this.bunifuImageButtonSORT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSORT.TabIndex = 14;
            this.bunifuImageButtonSORT.TabStop = false;
            this.bunifuImageButtonSORT.WaitOnLoad = true;
            this.bunifuImageButtonSORT.Zoom = 10;
            this.bunifuImageButtonSORT.Click += new System.EventHandler(this.bunifuImageButtonSORT_Click);
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.BackColor = System.Drawing.Color.Transparent;
            this.labelRAM.ForeColor = System.Drawing.Color.Cyan;
            this.labelRAM.Location = new System.Drawing.Point(471, 5);
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
            this.labelGPU.Location = new System.Drawing.Point(367, 5);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(31, 15);
            this.labelGPU.TabIndex = 9;
            this.labelGPU.Text = "GPU";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = global::TRPO_Project.Properties.Resources.profile_default;
            this.pictureBoxProfile.ImageActive = null;
            this.pictureBoxProfile.Location = new System.Drawing.Point(699, 9);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(43, 43);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Zoom = 10;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.BackColor = System.Drawing.Color.Transparent;
            this.labelCPU.ForeColor = System.Drawing.Color.Cyan;
            this.labelCPU.Location = new System.Drawing.Point(252, 5);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(31, 15);
            this.labelCPU.TabIndex = 8;
            this.labelCPU.Text = "CPU";
            // 
            // pictureBoxProductBIN
            // 
            this.pictureBoxProductBIN.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProductBIN.Image = global::TRPO_Project.Properties.Resources.shopping_cart;
            this.pictureBoxProductBIN.ImageActive = null;
            this.pictureBoxProductBIN.Location = new System.Drawing.Point(618, 9);
            this.pictureBoxProductBIN.Name = "pictureBoxProductBIN";
            this.pictureBoxProductBIN.Size = new System.Drawing.Size(43, 43);
            this.pictureBoxProductBIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductBIN.TabIndex = 3;
            this.pictureBoxProductBIN.TabStop = false;
            this.pictureBoxProductBIN.Zoom = 10;
            this.pictureBoxProductBIN.Click += new System.EventHandler(this.pictureBoxProductBIN_Click);
            // 
            // metroComboBoxCPUsort
            // 
            this.metroComboBoxCPUsort.BackColor = System.Drawing.Color.Azure;
            this.metroComboBoxCPUsort.DropDownWidth = 140;
            this.metroComboBoxCPUsort.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxCPUsort.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxCPUsort.ItemHeight = 19;
            this.metroComboBoxCPUsort.Items.AddRange(new object[] {
            "<не выбрано>"});
            this.metroComboBoxCPUsort.Location = new System.Drawing.Point(215, 20);
            this.metroComboBoxCPUsort.Name = "metroComboBoxCPUsort";
            this.metroComboBoxCPUsort.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxCPUsort.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxCPUsort.TabIndex = 11;
            this.metroComboBoxCPUsort.TabStop = false;
            this.metroComboBoxCPUsort.UseCustomBackColor = true;
            this.metroComboBoxCPUsort.UseCustomForeColor = true;
            this.metroComboBoxCPUsort.UseSelectable = true;
            this.metroComboBoxCPUsort.UseStyleColors = true;
            // 
            // labelTYPEofPC
            // 
            this.labelTYPEofPC.AutoSize = true;
            this.labelTYPEofPC.BackColor = System.Drawing.Color.Transparent;
            this.labelTYPEofPC.ForeColor = System.Drawing.Color.Cyan;
            this.labelTYPEofPC.Location = new System.Drawing.Point(126, 5);
            this.labelTYPEofPC.Name = "labelTYPEofPC";
            this.labelTYPEofPC.Size = new System.Drawing.Size(71, 15);
            this.labelTYPEofPC.TabIndex = 7;
            this.labelTYPEofPC.Text = "TypeOfPC";
            // 
            // metroComboBoxGPUsort
            // 
            this.metroComboBoxGPUsort.BackColor = System.Drawing.Color.Azure;
            this.metroComboBoxGPUsort.DropDownWidth = 140;
            this.metroComboBoxGPUsort.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxGPUsort.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxGPUsort.FormattingEnabled = true;
            this.metroComboBoxGPUsort.ItemHeight = 19;
            this.metroComboBoxGPUsort.Items.AddRange(new object[] {
            "<не выбрано>"});
            this.metroComboBoxGPUsort.Location = new System.Drawing.Point(326, 20);
            this.metroComboBoxGPUsort.Name = "metroComboBoxGPUsort";
            this.metroComboBoxGPUsort.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxGPUsort.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxGPUsort.TabIndex = 12;
            this.metroComboBoxGPUsort.TabStop = false;
            this.metroComboBoxGPUsort.UseCustomBackColor = true;
            this.metroComboBoxGPUsort.UseCustomForeColor = true;
            this.metroComboBoxGPUsort.UseSelectable = true;
            this.metroComboBoxGPUsort.UseStyleColors = true;
            // 
            // metroComboBoxRAM
            // 
            this.metroComboBoxRAM.BackColor = System.Drawing.Color.LightCyan;
            this.metroComboBoxRAM.DropDownWidth = 140;
            this.metroComboBoxRAM.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBoxRAM.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.metroComboBoxRAM.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroComboBoxRAM.FormattingEnabled = true;
            this.metroComboBoxRAM.ItemHeight = 19;
            this.metroComboBoxRAM.Items.AddRange(new object[] {
            "<не выбрано>"});
            this.metroComboBoxRAM.Location = new System.Drawing.Point(437, 20);
            this.metroComboBoxRAM.Name = "metroComboBoxRAM";
            this.metroComboBoxRAM.Size = new System.Drawing.Size(105, 25);
            this.metroComboBoxRAM.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroComboBoxRAM.TabIndex = 13;
            this.metroComboBoxRAM.TabStop = false;
            this.metroComboBoxRAM.UseCustomBackColor = true;
            this.metroComboBoxRAM.UseCustomForeColor = true;
            this.metroComboBoxRAM.UseSelectable = true;
            this.metroComboBoxRAM.UseStyleColors = true;
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(770, 3);
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
            this.panelHead.Controls.Add(this.bunifuImageButtonEXIT);
            this.panelHead.Location = new System.Drawing.Point(0, 5);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(796, 28);
            this.panelHead.TabIndex = 4;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // formUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(796, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Controls.Add(this.groupBoxHEAD);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUSER";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.groupBoxHEAD.ResumeLayout(false);
            this.groupBoxHEAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_backToLoginForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductBIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label labelRAM;
        protected System.Windows.Forms.Label labelGPU;
        protected System.Windows.Forms.Label labelCPU;
        protected System.Windows.Forms.Label labelTYPEofPC;
        protected MetroFramework.Controls.MetroComboBox metroComboBoxRAM;
        protected MetroFramework.Controls.MetroComboBox metroComboBoxGPUsort;
        protected MetroFramework.Controls.MetroComboBox metroComboBoxCPUsort;
        protected Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private System.ComponentModel.IContainer components;
        protected Bunifu.Framework.UI.BunifuImageButton pictureBoxProductBIN;
        protected Bunifu.Framework.UI.BunifuImageButton pictureBoxProfile;
        internal XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private XanderUI.XUIObjectEllipse FormEllipse;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuGradientPanel groupBoxHEAD;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonSORT;
        protected MetroFramework.Controls.MetroComboBox metroComboBoxTYPEofPC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_PRICE;
        private Bunifu.Framework.UI.BunifuImageButton button_backToLoginForm;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHead;
    }
}
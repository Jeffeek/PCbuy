namespace TRPO_Project
{
    partial class formProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProfile));
            this.openFileDialogchangeAprofilePIC = new System.Windows.Forms.OpenFileDialog();
            this.linkLabelCHANGEprofilePIC = new MetroFramework.Controls.MetroLink();
            this.pictureBoxPROFILE = new System.Windows.Forms.PictureBox();
            this.pictureBoxCHANGEpassVisibility = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuMaterialTextboxEMAIL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextboxPASS = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.linkLabelCHANGEpass = new MetroFramework.Controls.MetroLink();
            this.bunifuImageButtonApplyNewPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuMetroTextboxNewPassSecond = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextboxNewPassFirst = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.linkLabelDELETEprofile = new MetroFramework.Controls.MetroLink();
            this.PASSlabel = new MetroFramework.Controls.MetroLabel();
            this.EMAILlabel = new MetroFramework.Controls.MetroLabel();
            this.EllipseForm = new XanderUI.XUIObjectEllipse();
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelChangeTheme = new Guna.UI.WinForms.GunaLabel();
            this.switchTheme = new Guna.UI.WinForms.GunaWinSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPROFILE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCHANGEpassVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            this.xuiSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonApplyNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogchangeAprofilePIC
            // 
            this.openFileDialogchangeAprofilePIC.Filter = "PNG|*.png";
            // 
            // linkLabelCHANGEprofilePIC
            // 
            this.linkLabelCHANGEprofilePIC.BackColor = System.Drawing.Color.Black;
            this.linkLabelCHANGEprofilePIC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelCHANGEprofilePIC.ForeColor = System.Drawing.Color.Gray;
            this.linkLabelCHANGEprofilePIC.Location = new System.Drawing.Point(119, 138);
            this.linkLabelCHANGEprofilePIC.Name = "linkLabelCHANGEprofilePIC";
            this.linkLabelCHANGEprofilePIC.Size = new System.Drawing.Size(104, 17);
            this.linkLabelCHANGEprofilePIC.TabIndex = 17;
            this.linkLabelCHANGEprofilePIC.Text = "ChangeProfilePic";
            this.linkLabelCHANGEprofilePIC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkLabelCHANGEprofilePIC.UseCustomForeColor = true;
            this.linkLabelCHANGEprofilePIC.UseSelectable = true;
            this.linkLabelCHANGEprofilePIC.Click += new System.EventHandler(this.linkLabelCHANGEprofilePIC_Click);
            // 
            // pictureBoxPROFILE
            // 
            this.pictureBoxPROFILE.ErrorImage = global::TRPO_Project.Properties.Resources.profile_default;
            this.pictureBoxPROFILE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPROFILE.Image")));
            this.pictureBoxPROFILE.Location = new System.Drawing.Point(100, 33);
            this.pictureBoxPROFILE.Name = "pictureBoxPROFILE";
            this.pictureBoxPROFILE.Size = new System.Drawing.Size(124, 122);
            this.pictureBoxPROFILE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPROFILE.TabIndex = 7;
            this.pictureBoxPROFILE.TabStop = false;
            // 
            // pictureBoxCHANGEpassVisibility
            // 
            this.pictureBoxCHANGEpassVisibility.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCHANGEpassVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCHANGEpassVisibility.Image = global::TRPO_Project.Properties.Resources.eye_hide;
            this.pictureBoxCHANGEpassVisibility.ImageActive = null;
            this.pictureBoxCHANGEpassVisibility.Location = new System.Drawing.Point(241, 233);
            this.pictureBoxCHANGEpassVisibility.Name = "pictureBoxCHANGEpassVisibility";
            this.pictureBoxCHANGEpassVisibility.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxCHANGEpassVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCHANGEpassVisibility.TabIndex = 22;
            this.pictureBoxCHANGEpassVisibility.TabStop = false;
            this.pictureBoxCHANGEpassVisibility.Zoom = 10;
            this.pictureBoxCHANGEpassVisibility.Click += new System.EventHandler(this.pictureBoxCHANGEpassVisibility_Click);
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(287, 7);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 21;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // bunifuMaterialTextboxEMAIL
            // 
            this.bunifuMaterialTextboxEMAIL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuMaterialTextboxEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxEMAIL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxEMAIL.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxEMAIL.ForeColor = System.Drawing.Color.Aqua;
            this.bunifuMaterialTextboxEMAIL.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxEMAIL.HintText = "";
            this.bunifuMaterialTextboxEMAIL.isPassword = false;
            this.bunifuMaterialTextboxEMAIL.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextboxEMAIL.LineIdleColor = System.Drawing.Color.LimeGreen;
            this.bunifuMaterialTextboxEMAIL.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMaterialTextboxEMAIL.LineThickness = 3;
            this.bunifuMaterialTextboxEMAIL.Location = new System.Drawing.Point(77, 181);
            this.bunifuMaterialTextboxEMAIL.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxEMAIL.Name = "bunifuMaterialTextboxEMAIL";
            this.bunifuMaterialTextboxEMAIL.Size = new System.Drawing.Size(158, 22);
            this.bunifuMaterialTextboxEMAIL.TabIndex = 24;
            this.bunifuMaterialTextboxEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextboxPASS
            // 
            this.bunifuMaterialTextboxPASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuMaterialTextboxPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuMaterialTextboxPASS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPASS.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxPASS.ForeColor = System.Drawing.Color.Aqua;
            this.bunifuMaterialTextboxPASS.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxPASS.HintText = "";
            this.bunifuMaterialTextboxPASS.isPassword = true;
            this.bunifuMaterialTextboxPASS.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextboxPASS.LineIdleColor = System.Drawing.Color.LimeGreen;
            this.bunifuMaterialTextboxPASS.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMaterialTextboxPASS.LineThickness = 3;
            this.bunifuMaterialTextboxPASS.Location = new System.Drawing.Point(77, 231);
            this.bunifuMaterialTextboxPASS.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxPASS.Name = "bunifuMaterialTextboxPASS";
            this.bunifuMaterialTextboxPASS.Size = new System.Drawing.Size(158, 22);
            this.bunifuMaterialTextboxPASS.TabIndex = 25;
            this.bunifuMaterialTextboxPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.Magenta;
            this.xuiSlidingPanel1.CollapseControl = this.linkLabelCHANGEpass;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.bunifuImageButtonApplyNewPassword);
            this.xuiSlidingPanel1.Controls.Add(this.bunifuMetroTextboxNewPassSecond);
            this.xuiSlidingPanel1.Controls.Add(this.bunifuMetroTextboxNewPassFirst);
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(2, 161);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 0;
            this.xuiSlidingPanel1.PanelWidthExpanded = 310;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(0, 85);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 26;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.Transparent;
            // 
            // linkLabelCHANGEpass
            // 
            this.linkLabelCHANGEpass.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelCHANGEpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelCHANGEpass.ForeColor = System.Drawing.Color.SpringGreen;
            this.linkLabelCHANGEpass.Location = new System.Drawing.Point(0, 268);
            this.linkLabelCHANGEpass.Name = "linkLabelCHANGEpass";
            this.linkLabelCHANGEpass.Size = new System.Drawing.Size(136, 23);
            this.linkLabelCHANGEpass.TabIndex = 27;
            this.linkLabelCHANGEpass.Text = "CHANGE PASSWORD";
            this.linkLabelCHANGEpass.UseCustomBackColor = true;
            this.linkLabelCHANGEpass.UseCustomForeColor = true;
            this.linkLabelCHANGEpass.UseSelectable = true;
            // 
            // bunifuImageButtonApplyNewPassword
            // 
            this.bunifuImageButtonApplyNewPassword.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuImageButtonApplyNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonApplyNewPassword.Enabled = false;
            this.bunifuImageButtonApplyNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonApplyNewPassword.Image")));
            this.bunifuImageButtonApplyNewPassword.ImageActive = null;
            this.bunifuImageButtonApplyNewPassword.Location = new System.Drawing.Point(214, 17);
            this.bunifuImageButtonApplyNewPassword.Name = "bunifuImageButtonApplyNewPassword";
            this.bunifuImageButtonApplyNewPassword.Size = new System.Drawing.Size(91, 54);
            this.bunifuImageButtonApplyNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonApplyNewPassword.TabIndex = 7;
            this.bunifuImageButtonApplyNewPassword.TabStop = false;
            this.bunifuImageButtonApplyNewPassword.Zoom = 10;
            this.bunifuImageButtonApplyNewPassword.Click += new System.EventHandler(this.bunifuImageButtonApplyNewPassword_Click);
            // 
            // bunifuMetroTextboxNewPassSecond
            // 
            this.bunifuMetroTextboxNewPassSecond.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextboxNewPassSecond.BorderColorFocused = System.Drawing.Color.DarkTurquoise;
            this.bunifuMetroTextboxNewPassSecond.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.bunifuMetroTextboxNewPassSecond.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.bunifuMetroTextboxNewPassSecond.BorderThickness = 1;
            this.bunifuMetroTextboxNewPassSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxNewPassSecond.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextboxNewPassSecond.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextboxNewPassSecond.isPassword = false;
            this.bunifuMetroTextboxNewPassSecond.Location = new System.Drawing.Point(10, 48);
            this.bunifuMetroTextboxNewPassSecond.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxNewPassSecond.Name = "bunifuMetroTextboxNewPassSecond";
            this.bunifuMetroTextboxNewPassSecond.Size = new System.Drawing.Size(200, 25);
            this.bunifuMetroTextboxNewPassSecond.TabIndex = 6;
            this.bunifuMetroTextboxNewPassSecond.Text = "REPEAT YOUR PASSWORD";
            this.bunifuMetroTextboxNewPassSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextboxNewPassSecond.OnValueChanged += new System.EventHandler(this.bunifuMetroTextboxNewPassSecond_OnValueChanged);
            this.bunifuMetroTextboxNewPassSecond.Enter += new System.EventHandler(this.bunifuMetroTextboxNewPassSecond_Enter);
            this.bunifuMetroTextboxNewPassSecond.Leave += new System.EventHandler(this.bunifuMetroTextboxNewPassSecond_Leave);
            // 
            // bunifuMetroTextboxNewPassFirst
            // 
            this.bunifuMetroTextboxNewPassFirst.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuMetroTextboxNewPassFirst.BorderColorFocused = System.Drawing.Color.DarkTurquoise;
            this.bunifuMetroTextboxNewPassFirst.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.bunifuMetroTextboxNewPassFirst.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.bunifuMetroTextboxNewPassFirst.BorderThickness = 1;
            this.bunifuMetroTextboxNewPassFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxNewPassFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextboxNewPassFirst.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextboxNewPassFirst.isPassword = false;
            this.bunifuMetroTextboxNewPassFirst.Location = new System.Drawing.Point(10, 15);
            this.bunifuMetroTextboxNewPassFirst.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxNewPassFirst.Name = "bunifuMetroTextboxNewPassFirst";
            this.bunifuMetroTextboxNewPassFirst.Size = new System.Drawing.Size(200, 25);
            this.bunifuMetroTextboxNewPassFirst.TabIndex = 5;
            this.bunifuMetroTextboxNewPassFirst.Text = "NEW PASSWORD";
            this.bunifuMetroTextboxNewPassFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextboxNewPassFirst.OnValueChanged += new System.EventHandler(this.bunifuMetroTextboxNewPassFirst_OnValueChanged);
            this.bunifuMetroTextboxNewPassFirst.Enter += new System.EventHandler(this.bunifuMetroTextboxNewPassFirst_Enter);
            this.bunifuMetroTextboxNewPassFirst.Leave += new System.EventHandler(this.bunifuMetroTextboxNewPassFirst_Leave);
            // 
            // linkLabelDELETEprofile
            // 
            this.linkLabelDELETEprofile.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelDELETEprofile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelDELETEprofile.ForeColor = System.Drawing.Color.Maroon;
            this.linkLabelDELETEprofile.Location = new System.Drawing.Point(216, 268);
            this.linkLabelDELETEprofile.Name = "linkLabelDELETEprofile";
            this.linkLabelDELETEprofile.Size = new System.Drawing.Size(99, 23);
            this.linkLabelDELETEprofile.TabIndex = 28;
            this.linkLabelDELETEprofile.Text = "DELETE PROFILE";
            this.linkLabelDELETEprofile.UseCustomBackColor = true;
            this.linkLabelDELETEprofile.UseCustomForeColor = true;
            this.linkLabelDELETEprofile.UseSelectable = true;
            this.linkLabelDELETEprofile.Click += new System.EventHandler(this.linkLabelDELETEprofile_Click);
            // 
            // PASSlabel
            // 
            this.PASSlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PASSlabel.AutoSize = true;
            this.PASSlabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PASSlabel.Location = new System.Drawing.Point(120, 205);
            this.PASSlabel.Name = "PASSlabel";
            this.PASSlabel.Size = new System.Drawing.Size(79, 19);
            this.PASSlabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.PASSlabel.TabIndex = 30;
            this.PASSlabel.Text = "PASSWORD";
            this.PASSlabel.UseCustomBackColor = true;
            this.PASSlabel.UseCustomForeColor = true;
            this.PASSlabel.UseMnemonic = false;
            this.PASSlabel.UseStyleColors = true;
            // 
            // EMAILlabel
            // 
            this.EMAILlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMAILlabel.AutoSize = true;
            this.EMAILlabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EMAILlabel.Location = new System.Drawing.Point(138, 158);
            this.EMAILlabel.Name = "EMAILlabel";
            this.EMAILlabel.Size = new System.Drawing.Size(46, 19);
            this.EMAILlabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.EMAILlabel.TabIndex = 29;
            this.EMAILlabel.Text = "EMAIL";
            this.EMAILlabel.UseCustomBackColor = true;
            this.EMAILlabel.UseCustomForeColor = true;
            this.EMAILlabel.UseStyleColors = true;
            // 
            // EllipseForm
            // 
            this.EllipseForm.CornerRadius = 15;
            this.EllipseForm.EffectedControl = this;
            this.EllipseForm.EffectedForm = this;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Transparent;
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Location = new System.Drawing.Point(-2, 5);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(320, 25);
            this.panelHead.TabIndex = 31;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // labelChangeTheme
            // 
            this.labelChangeTheme.AutoSize = true;
            this.labelChangeTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelChangeTheme.ForeColor = System.Drawing.Color.White;
            this.labelChangeTheme.Location = new System.Drawing.Point(230, 43);
            this.labelChangeTheme.Name = "labelChangeTheme";
            this.labelChangeTheme.Size = new System.Drawing.Size(80, 15);
            this.labelChangeTheme.TabIndex = 34;
            this.labelChangeTheme.Text = "Светлая тема";
            // 
            // switchTheme
            // 
            this.switchTheme.BackColor = System.Drawing.Color.Transparent;
            this.switchTheme.BaseColor = System.Drawing.SystemColors.Control;
            this.switchTheme.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.switchTheme.CheckedOnColor = System.Drawing.Color.SpringGreen;
            this.switchTheme.FillColor = System.Drawing.Color.White;
            this.switchTheme.Location = new System.Drawing.Point(250, 63);
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Size = new System.Drawing.Size(40, 22);
            this.switchTheme.TabIndex = 33;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged);
            // 
            // formProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 288);
            this.ControlBox = false;
            this.Controls.Add(this.labelChangeTheme);
            this.Controls.Add(this.switchTheme);
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.xuiSlidingPanel1);
            this.Controls.Add(this.PASSlabel);
            this.Controls.Add(this.EMAILlabel);
            this.Controls.Add(this.linkLabelDELETEprofile);
            this.Controls.Add(this.linkLabelCHANGEpass);
            this.Controls.Add(this.bunifuMaterialTextboxPASS);
            this.Controls.Add(this.bunifuMaterialTextboxEMAIL);
            this.Controls.Add(this.pictureBoxCHANGEpassVisibility);
            this.Controls.Add(this.linkLabelCHANGEprofilePIC);
            this.Controls.Add(this.pictureBoxPROFILE);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formProfile";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPROFILE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCHANGEpassVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            this.xuiSlidingPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonApplyNewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPROFILE;
        private System.Windows.Forms.OpenFileDialog openFileDialogchangeAprofilePIC;
        private MetroFramework.Controls.MetroLink linkLabelCHANGEprofilePIC;
        private Bunifu.Framework.UI.BunifuImageButton pictureBoxCHANGEpassVisibility;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxEMAIL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPASS;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonApplyNewPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxNewPassSecond;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxNewPassFirst;
        private MetroFramework.Controls.MetroLink linkLabelDELETEprofile;
        private MetroFramework.Controls.MetroLink linkLabelCHANGEpass;
        private MetroFramework.Controls.MetroLabel PASSlabel;
        private MetroFramework.Controls.MetroLabel EMAILlabel;
        private XanderUI.XUIObjectEllipse EllipseForm;
        private System.Windows.Forms.Panel panelHead;
        private Guna.UI.WinForms.GunaLabel labelChangeTheme;
        private Guna.UI.WinForms.GunaWinSwitch switchTheme;
    }
}
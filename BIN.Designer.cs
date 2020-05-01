namespace TRPO_Project
{
    partial class BIN
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPRODUCTs = new MetroFramework.Controls.MetroTabControl();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.imageButtonCONFIRMorder = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonCONFIRMorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR ORDER:";
            // 
            // tabControlPRODUCTs
            // 
            this.tabControlPRODUCTs.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControlPRODUCTs.Location = new System.Drawing.Point(2, 63);
            this.tabControlPRODUCTs.Name = "tabControlPRODUCTs";
            this.tabControlPRODUCTs.Size = new System.Drawing.Size(464, 232);
            this.tabControlPRODUCTs.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tabControlPRODUCTs.TabIndex = 2;
            this.tabControlPRODUCTs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControlPRODUCTs.UseSelectable = true;
            this.tabControlPRODUCTs.UseStyleColors = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormStartTransition
            // 
            this.FormStartTransition.Delay = 1;
            // 
            // imageButtonCONFIRMorder
            // 
            this.imageButtonCONFIRMorder.BackColor = System.Drawing.Color.SlateGray;
            this.imageButtonCONFIRMorder.Enabled = false;
            this.imageButtonCONFIRMorder.Image = global::TRPO_Project.Properties.Resources.X;
            this.imageButtonCONFIRMorder.ImageActive = null;
            this.imageButtonCONFIRMorder.Location = new System.Drawing.Point(139, 300);
            this.imageButtonCONFIRMorder.Name = "imageButtonCONFIRMorder";
            this.imageButtonCONFIRMorder.Size = new System.Drawing.Size(205, 46);
            this.imageButtonCONFIRMorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButtonCONFIRMorder.TabIndex = 3;
            this.imageButtonCONFIRMorder.TabStop = false;
            this.imageButtonCONFIRMorder.Zoom = 10;
            this.imageButtonCONFIRMorder.Click += new System.EventHandler(this.imageButtonCONFIRMorder_Click);
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(445, 8);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 4;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.BackColor = System.Drawing.Color.Transparent;
            this.metroLabelID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelID.ForeColor = System.Drawing.Color.Magenta;
            this.metroLabelID.Location = new System.Drawing.Point(2, 309);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(90, 25);
            this.metroLabelID.TabIndex = 5;
            this.metroLabelID.Text = "YOUR ID: ";
            this.metroLabelID.UseCustomBackColor = true;
            this.metroLabelID.UseCustomForeColor = true;
            // 
            // BIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 348);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabelID);
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.imageButtonCONFIRMorder);
            this.Controls.Add(this.tabControlPRODUCTs);
            this.Controls.Add(this.label1);
            this.Name = "BIN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.imageButtonCONFIRMorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlPRODUCTs;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuImageButton imageButtonCONFIRMorder;
        protected Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private MetroFramework.Controls.MetroLabel metroLabelID;
    }
}
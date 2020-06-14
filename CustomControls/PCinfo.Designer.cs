namespace TRPO_Project
{
    partial class PCinfo
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCinfo));
            this.buttonBUY = new Bunifu.Framework.UI.BunifuImageButton();
            this.PCimg = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTYPE = new Guna.UI.WinForms.GunaLabel();
            this.labelCPU = new Guna.UI.WinForms.GunaLabel();
            this.labelGPU = new Guna.UI.WinForms.GunaLabel();
            this.labelCOST = new Guna.UI.WinForms.GunaLabel();
            this.labelRAM = new Guna.UI.WinForms.GunaLabel();
            this.labelID = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBUY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCimg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBUY
            // 
            this.buttonBUY.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonBUY.Image = global::TRPO_Project.Properties.Resources.buy;
            this.buttonBUY.ImageActive = null;
            this.buttonBUY.Location = new System.Drawing.Point(290, 196);
            this.buttonBUY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(150, 61);
            this.buttonBUY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonBUY.TabIndex = 1;
            this.buttonBUY.TabStop = false;
            this.buttonBUY.Zoom = 10;
            this.buttonBUY.Click += new System.EventHandler(this.buttonBUY_Click);
            // 
            // PCimg
            // 
            this.PCimg.BackColor = System.Drawing.Color.SeaGreen;
            this.PCimg.Image = ((System.Drawing.Image)(resources.GetObject("PCimg.Image")));
            this.PCimg.ImageActive = null;
            this.PCimg.Location = new System.Drawing.Point(25, 16);
            this.PCimg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PCimg.Name = "PCimg";
            this.PCimg.Size = new System.Drawing.Size(225, 238);
            this.PCimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCimg.TabIndex = 0;
            this.PCimg.TabStop = false;
            this.PCimg.Zoom = 10;
            // 
            // labelTYPE
            // 
            this.labelTYPE.AutoSize = true;
            this.labelTYPE.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTYPE.ForeColor = System.Drawing.Color.Gray;
            this.labelTYPE.Location = new System.Drawing.Point(284, 4);
            this.labelTYPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTYPE.Name = "labelTYPE";
            this.labelTYPE.Size = new System.Drawing.Size(231, 36);
            this.labelTYPE.TabIndex = 2;
            this.labelTYPE.Text = "Type of PC: ";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.ForeColor = System.Drawing.Color.Gray;
            this.labelCPU.Location = new System.Drawing.Point(284, 39);
            this.labelCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(105, 36);
            this.labelCPU.TabIndex = 3;
            this.labelCPU.Text = "CPU: ";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPU.ForeColor = System.Drawing.Color.Gray;
            this.labelGPU.Location = new System.Drawing.Point(284, 74);
            this.labelGPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(105, 36);
            this.labelGPU.TabIndex = 4;
            this.labelGPU.Text = "GPU: ";
            // 
            // labelCOST
            // 
            this.labelCOST.AutoSize = true;
            this.labelCOST.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOST.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelCOST.Location = new System.Drawing.Point(284, 156);
            this.labelCOST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCOST.Name = "labelCOST";
            this.labelCOST.Size = new System.Drawing.Size(141, 36);
            this.labelCOST.TabIndex = 5;
            this.labelCOST.Text = "PRICE: ";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.ForeColor = System.Drawing.Color.Gray;
            this.labelRAM.Location = new System.Drawing.Point(284, 108);
            this.labelRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(105, 36);
            this.labelRAM.TabIndex = 6;
            this.labelRAM.Text = "RAM: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelID.Location = new System.Drawing.Point(781, 0);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(87, 36);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID: ";
            this.labelID.Visible = false;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 261);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(979, 22);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // PCinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCOST);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelTYPE);
            this.Controls.Add(this.buttonBUY);
            this.Controls.Add(this.PCimg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PCinfo";
            this.Size = new System.Drawing.Size(995, 288);
            this.Load += new System.EventHandler(this.PCinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonBUY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton PCimg;
        private Bunifu.Framework.UI.BunifuImageButton buttonBUY;
        private Guna.UI.WinForms.GunaLabel labelTYPE;
        private Guna.UI.WinForms.GunaLabel labelCPU;
        private Guna.UI.WinForms.GunaLabel labelGPU;
        private Guna.UI.WinForms.GunaLabel labelCOST;
        private Guna.UI.WinForms.GunaLabel labelRAM;
        private Guna.UI.WinForms.GunaLabel labelID;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}

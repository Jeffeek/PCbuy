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
            this.buttonBUY.Location = new System.Drawing.Point(232, 157);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(120, 49);
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
            this.PCimg.Location = new System.Drawing.Point(20, 13);
            this.PCimg.Name = "PCimg";
            this.PCimg.Size = new System.Drawing.Size(180, 190);
            this.PCimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCimg.TabIndex = 0;
            this.PCimg.TabStop = false;
            this.PCimg.Zoom = 10;
            // 
            // labelTYPE
            // 
            this.labelTYPE.AutoSize = true;
            this.labelTYPE.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTYPE.ForeColor = System.Drawing.Color.Turquoise;
            this.labelTYPE.Location = new System.Drawing.Point(227, 3);
            this.labelTYPE.Name = "labelTYPE";
            this.labelTYPE.Size = new System.Drawing.Size(163, 29);
            this.labelTYPE.TabIndex = 2;
            this.labelTYPE.Text = "TYPEofPC: ";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelCPU.Location = new System.Drawing.Point(227, 31);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(88, 29);
            this.labelCPU.TabIndex = 3;
            this.labelCPU.Text = "CPU: ";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPU.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelGPU.Location = new System.Drawing.Point(227, 59);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(88, 29);
            this.labelGPU.TabIndex = 4;
            this.labelGPU.Text = "GPU: ";
            // 
            // labelCOST
            // 
            this.labelCOST.AutoSize = true;
            this.labelCOST.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOST.ForeColor = System.Drawing.Color.Red;
            this.labelCOST.Location = new System.Drawing.Point(227, 125);
            this.labelCOST.Name = "labelCOST";
            this.labelCOST.Size = new System.Drawing.Size(118, 29);
            this.labelCOST.TabIndex = 5;
            this.labelCOST.Text = "PRICE: ";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelRAM.Location = new System.Drawing.Point(227, 86);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(88, 29);
            this.labelRAM.TabIndex = 6;
            this.labelRAM.Text = "RAM: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelID.Location = new System.Drawing.Point(625, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(73, 29);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID: ";
            this.labelID.Visible = false;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(0, 209);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(783, 18);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // PCinfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
            this.Name = "PCinfo";
            this.Size = new System.Drawing.Size(782, 266);
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

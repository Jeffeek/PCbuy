namespace TRPO_Project
{
    partial class GraphicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicForm));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.Graphic = new XanderUI.XUILineGraph();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.FormFadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuImageButtonHIDE = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonHIDE)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 15;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // Graphic
            // 
            this.Graphic.BackColor = System.Drawing.Color.Black;
            this.Graphic.BackGroundColor = System.Drawing.Color.Black;
            this.Graphic.BelowLineColor = System.Drawing.Color.Black;
            this.Graphic.BorderColor = System.Drawing.Color.Black;
            this.Graphic.ForeColor = System.Drawing.Color.Black;
            this.Graphic.GraphStyle = XanderUI.XUILineGraph.Style.Curved;
            this.Graphic.GraphTitle = "XUI LineGraph";
            this.Graphic.GraphTitleColor = System.Drawing.Color.Black;
            this.Graphic.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("Graphic.Items")));
            this.Graphic.LineColor = System.Drawing.Color.Orchid;
            this.Graphic.Location = new System.Drawing.Point(0, 34);
            this.Graphic.Name = "Graphic";
            this.Graphic.PointSize = 10;
            this.Graphic.ShowBorder = false;
            this.Graphic.ShowPoints = true;
            this.Graphic.ShowTitle = false;
            this.Graphic.ShowVerticalLines = true;
            this.Graphic.Size = new System.Drawing.Size(780, 418);
            this.Graphic.TabIndex = 0;
            this.Graphic.Text = "xuiLineGraph1";
            this.Graphic.TitleAlignment = System.Drawing.StringAlignment.Center;
            this.Graphic.VerticalLineColor = System.Drawing.Color.Black;
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(756, 11);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 4;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // FormFadeTransition
            // 
            this.FormFadeTransition.Delay = 1;
            // 
            // bunifuImageButtonHIDE
            // 
            this.bunifuImageButtonHIDE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuImageButtonHIDE.Image = global::TRPO_Project.Properties.Resources.minus;
            this.bunifuImageButtonHIDE.ImageActive = null;
            this.bunifuImageButtonHIDE.InitialImage = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonHIDE.Location = new System.Drawing.Point(730, 11);
            this.bunifuImageButtonHIDE.Name = "bunifuImageButtonHIDE";
            this.bunifuImageButtonHIDE.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonHIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonHIDE.TabIndex = 6;
            this.bunifuImageButtonHIDE.TabStop = false;
            this.bunifuImageButtonHIDE.Zoom = 10;
            this.bunifuImageButtonHIDE.Click += new System.EventHandler(this.bunifuImageButtonHIDE_Click);
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 452);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuImageButtonHIDE);
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.Graphic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonHIDE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUILineGraph Graphic;
        protected Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFadeTransition;
        protected Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonHIDE;
    }
}
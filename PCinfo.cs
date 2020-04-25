using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Project
{
    public partial class PCinfo : UserControl
    {
        public string TYPE { get; set; }
        public int ID { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int COST { get; set; }
        public Image IMG { get; set; }
        public bool isAdmin { set; get; }
        public PCinfo(string TYPE, int ID, string CPU, string GPU, int RAM, int COST, Image IMG)
        {
            InitializeComponent();
            this.TYPE = TYPE;
            this.ID = ID;
            this.CPU = CPU;
            this.GPU = GPU;
            this.RAM = RAM;
            this.COST = COST;
            this.IMG = IMG;
            labelID.Text += ID;
            labelTYPE.Text += TYPE;
            labelRAM.Text += RAM + "GB";
            labelCPU.Text += CPU;
            labelCOST.Text += COST + "$";
            labelGPU.Text += GPU;
            PCimg.Image = IMG;
        }

        private void buttonBUY_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                formADMIN.BINid.Add(ID);
            }
            else
            {
                formUSER.BINid.Add(ID);
            }
        }

        private void PCinfo_Load(object sender, EventArgs e)
        {
            if (isAdmin)
                labelID.Visible = true;
        }
    }
}

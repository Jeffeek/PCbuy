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
        public PC PC { get; set; }
        public bool isAdmin { set; get; }

        public PCinfo(PC pc)
        {
            InitializeComponent();
            PC = pc;
            labelID.Text += PC.ID;
            labelTYPE.Text += PC.TYPE;
            labelRAM.Text += PC.RAM + "GB";
            labelCPU.Text += PC.CPU;
            labelCOST.Text += PC.COST + "$";
            labelGPU.Text += PC.GPU;
            PCimg.Image = PC.IMG;
        }

        private void buttonBUY_Click(object sender, EventArgs e) => BIN.ListBIN.Add(PC);

        private void PCinfo_Load(object sender, EventArgs e)
        {
            if (isAdmin)
                labelID.Visible = true;
        }
    }
}

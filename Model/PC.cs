using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project
{

    public class PC
    {
        public string TYPE { get; set; }
        public int ID { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int COST { get; set; }
        public Image IMG { get; set; }

        public PC(string tYPE, int iD, string cPU, string gPU, int rAM, int cOST, Image iMG)
        {
            TYPE = tYPE ?? throw new ArgumentNullException(nameof(tYPE));
            CPU = cPU ?? throw new ArgumentNullException(nameof(cPU));
            GPU = gPU ?? throw new ArgumentNullException(nameof(gPU));
            IMG = iMG ?? throw new ArgumentNullException(nameof(iMG));
            ID = iD; 
            RAM = rAM;
            COST = cOST;
        }
    }
}

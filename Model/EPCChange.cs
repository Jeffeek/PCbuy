using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project
{
    public enum EPCChange
    {
        Remove,
        Add,
        ChangeType,
        ChangeCPU,
        ChangeGPU,
        ChangeRAM,
        ChangeCOST,
        ChangeIMG
    }
}

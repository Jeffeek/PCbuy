using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project
{
    interface IThemeChange
    {
        void ChangeMetroControls(ProgramTheme OBJ);
        void ChangeNonMetroControls(ProgramTheme OBJ);
        void ReadTheme();
    }
}

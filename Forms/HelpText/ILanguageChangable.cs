using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project.Forms.HelpText
{
    public interface ILanguageChangable
    {
        string MainWindowText { get; set; }
        string ProfileWindowText { get; set; }
        string BasketWindowText { get; set; }
    };

}

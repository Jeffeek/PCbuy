using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project.Forms.HelpText
{
    public class EnglishLanguage : ILanguageChangable
    {
        public string MainWindowText { get; set; }
        public string ProfileWindowText { get; set; }
        public string BasketWindowText { get; set; }

        public EnglishLanguage()
        {
            MainWindowText = "When you first start the program and successfully log in, " +
                             "you see the Main Application Window.\r\nClick on the \"FILTER\" " +
                             "button and you will see the whole range. Also use assortment filtering " +
                             "using drop-down lists.";

            ProfileWindowText = "Clicking on the profile open button opens the profile window.\r\nProfile picture " +
                                "can be changed.\r\nBy clicking on the gear additional settings will open. " +
                                "Red color indicates the settings of the panel of the main window. " +
                                "Blue color indicates reset of all default settings. Green indicates the switching " +
                                "of the application theme.";

            BasketWindowText = "Clicking on the \"CART\" button will open a window for purchasing goods.\r\nTo fill" +
                               " the basket, you need to display a list of goods (see the first help page) and select" +
                               " the ones you need by clicking on the \"ADD\" button.";

        }

    }
}

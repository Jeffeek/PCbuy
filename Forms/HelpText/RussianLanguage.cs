using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Project.Forms.HelpText
{
    public class RussianLanguage : ILanguageChangable
    {
        public string MainWindowText { get; set; }
        public string ProfileWindowText { get; set; }
        public string BasketWindowText { get; set; }

        public RussianLanguage()
        {
            MainWindowText = "При первом запуске программы и успешном входе вы видите Главное Окно приложения." +
                             " \r\nКликните на кнопку \"ФИЛЬТР\" и " +
                             "вы увидите весь ассортимент. Также используйте фильтрацию ассортимента при помощи" +
                             " выпадающих списков.\r\n";

            ProfileWindowText = "Клик по кнопке открытия профиля открывает окно профиля.\r\nКартинку профиля можно поменять." +
                                "\r\nПо клику на шестеренку откроются дополнительные настройки. Красным цветом отмечены настройки " +
                                "панели главного окна. Синим цветом обозначен сброс всех настроек по умолчанию. " +
                                "Зеленым цветом обозначено переключение темы приложения.";

            BasketWindowText = "Клик по кнопке \"КОРЗИНА\" откроет окно для покупки товара.\r\nЧто бы заполнить корзину," +
                               " нужно вывести список товара(см.первую страничку помощи) и выбрать нужные кликом по" +
                               " кнопке \"ДОБАВИТЬ\".";
        }
    }
}

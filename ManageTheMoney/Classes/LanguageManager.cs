using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ManageTheMoney.Classes
{
    public class LanguageManager
    {
        // VALUES - DEĞERLER
        #region
        public static ResourceManager RM;
        #endregion

        // Bu metodun amacı uygulamanın dilini ayarlamak.
        public static void SetLanguage(string lang = "en")
        { 
            try
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
                RM = new ResourceManager("ManageTheMoney.Resources.Strings", typeof(LanguageManager).Assembly);
            }
            catch (Exception ex)
            {
                // Hata durumunda varsayılan dili İngilizce olarak ayarla.
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                Console.WriteLine("Dil ayarlanırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}

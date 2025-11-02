using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageTheMoney.Classes;
using ManageTheMoney.Forms;

namespace ManageTheMoney
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dili ayarla
            LanguageManager.SetLanguage("tr");

            if (Properties.Settings.Default.IsLoggedIn)
            {
                // Kullanıcı zaten giriş yapmış → direkt ana forma git
                Application.Run(new FrmMain());
            }
            else
            {
                // İlk kez giriş yapacak → login formu göster
                using (FrmLogin login = new FrmLogin())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                }
            }

        }
    }
}

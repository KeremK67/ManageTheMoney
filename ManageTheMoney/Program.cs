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

            // Login formunu aç
            FrmLogin loginForm = new FrmLogin();

            // Eğer login başarılıysa ana formu aç
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }

        }
    }
}

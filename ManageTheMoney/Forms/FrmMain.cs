using ManageTheMoney.Classes;
using ManageTheMoney.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageTheMoney
{
    public partial class FrmMain : Form
    {
        /*
         * BU FORM ANA FORMDUR!!
         * BU FORMDA AMACIM BİR KONTROL PANELİ OLUŞTURMAK,
         * BU FORMDAN DİĞER FORMLARI ÇAĞIRIP BURDA GÖSTEREREK BİR MENÜ OLUŞTURMAK.
        */

        public FrmMain()
        {
            InitializeComponent();
        }

        // VALUES - DEĞERLER
        #region
        private readonly FrmMainContent  MainContent = new(); // Ana içerik form nesnesi.
        private readonly FrmScenarios Scenarios = new(); // Senaryolar formu nesnesi.

        private string SelectedMenu = "MainMenu"; // Seçili menüyü kontrol etmek için.
        #endregion

        // METHODS - METODLAR
        #region
        // Bu metodun amacı dil içeriklerini ayarlamak.
        private void InitializeLanguage()
        {
            this.Text = LanguageManager.RM.GetString("FrmMainText", CultureInfo.CurrentUICulture);
            TsmiMainMenu.Text = LanguageManager.RM.GetString("TsmiMainMenuText", CultureInfo.CurrentUICulture);
            TsmiScenariosMenu.Text = LanguageManager.RM.GetString("TsmiScenariosMenuText", CultureInfo.CurrentUICulture);
        }

        // Bu metodun amacı ana içerik formunu panelde göstermek.
        private void ShowMainContentMenuInPanel()
        {
            PnlContent.Controls.Clear();
            MainContent.TopLevel = false;
            PnlContent.Controls.Add(MainContent);
            MainContent.FormBorderStyle = FormBorderStyle.None;
            MainContent.Dock = DockStyle.Fill;
            MainContent.Show();
            SelectedMenu = "MainMenu";
        }

        // Bu metodun amacı senaryolar formunu panelde göstermek.
        private void ShowScenariosMenuInPanel()
        {
            PnlContent.Controls.Clear();
            Scenarios.TopLevel = false;
            PnlContent.Controls.Add(Scenarios);
            Scenarios.FormBorderStyle = FormBorderStyle.None;
            Scenarios.Dock = DockStyle.Fill;
            Scenarios.Show();
            SelectedMenu = "ScenariosMenu";
        }
        #endregion

        // LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitializeLanguage();
            ShowMainContentMenuInPanel();
        }
        #endregion

        // TOP MENU - ÜST MENÜ
        #region
        private void TsmiMainMenu_Click(object sender, EventArgs e)
        {
            ShowMainContentMenuInPanel();
        }
        private void TsmiScenariosMenu_Click(object sender, EventArgs e)
        {
            ShowScenariosMenuInPanel();
        }
        #endregion

        // RESIZE - FORM BOYUTU DEĞİŞTİĞİNDE
        #region
        // Bu yapının amacı formun boyutu değiştiğinde içeriğin de boyutuna göre ayarlanması.
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            switch (SelectedMenu)
            {
                case "MainMenu":
                    ShowMainContentMenuInPanel();
                    break;
                case "ScenariosMenu":
                    ShowScenariosMenuInPanel();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

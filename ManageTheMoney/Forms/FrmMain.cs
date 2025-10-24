using ManageTheMoney.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        FrmMainContent  MainContent = new(); // Ana içerik form nesnesi.
        FrmScenarios Scenarios = new(); // Senaryolar formu nesnesi.

        string SelectedMenu = "MainMenu"; // Seçili menüyü kontrol etmek için.
        #endregion

        // METHODS - METODLAR
        #region
        // Bu metodun amacı ana içerik formunu panelde göstermek.
        // Bunu bir metod haline getirdim çünkü hem form yüklendiğinde hem de menüden tıklandığında çağıracağım.
        private void GetMainContentMenu()
        {
            PnlContent.Controls.Clear();
            MainContent.TopLevel = false;
            PnlContent.Controls.Add(MainContent);
            MainContent.FormBorderStyle = FormBorderStyle.None;
            MainContent.Dock = DockStyle.Fill;
            MainContent.Show();
            SelectedMenu = "MainMenu";
        }
        #endregion

        // LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetMainContentMenu();
        }
        #endregion

        // TOP MENU - ÜST MENÜ
        #region
        private void TsmiMainMenu_Click(object sender, EventArgs e)
        {
            GetMainContentMenu();
        }
        private void TsmiScenarios_Click(object sender, EventArgs e)
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

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            switch (SelectedMenu)
            {
                case "MainMenu":
                    GetMainContentMenu();
                    break;
                case "ScenariosMenu":
                    Scenarios.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }
    }
}

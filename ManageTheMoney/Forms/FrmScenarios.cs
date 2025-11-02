using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageTheMoney.Classes;

namespace ManageTheMoney.Forms
{
    public partial class FrmScenarios : Form
    {
        /*
         * BU FORM SENARYOLAR FORMUDUR!!
         * BU FORMDA AMAÇ FARKLI SENARYOLAR İLE KULLANICININ MALİ DURUMUNU ÖNGÖRMEK.
         */

        public FrmScenarios()
        {
            InitializeComponent();
        }

        // FORM LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmScenarios_Load(object sender, EventArgs e)
        {
            DgvScenariosTable.DataSource = Database.LoadTable("Scenarios");
        }
        #endregion
    }
}

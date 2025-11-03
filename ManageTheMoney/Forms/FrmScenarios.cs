using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        // METHODS - METODLAR
        #region
        public static void FormatScenarioGrid(DataGridView grid)
        {
            // Gizlenecek sütunlar
            if (grid.Columns["Id"] != null)
            {
                grid.Columns["Id"].Visible = false;
            }
            if (grid.Columns["UserId"] != null)
            { 
                grid.Columns["UserId"].Visible = false; 
            }
            if (grid.Columns["AccountId"] != null)
            {
                grid.Columns["AccountId"].Visible = false;
            }

            // Başlıklar
            var names = new Dictionary<string, string>()
            {
                { "title", LanguageManager.RM.GetString("ScenarioGridTitleTitle", CultureInfo.CurrentUICulture) },
                { "description", LanguageManager.RM.GetString("ScenarioGridTitleDescription", CultureInfo.CurrentUICulture) },
                { "type", LanguageManager.RM.GetString("ScenarioGridTitleType", CultureInfo.CurrentUICulture)  },
                { "amount", LanguageManager.RM.GetString("ScenarioGridTitleAmount", CultureInfo.CurrentUICulture) },
                { "currency", LanguageManager.RM.GetString("ScenarioGridTitleCurrency", CultureInfo.CurrentUICulture)  },
                { "expecteddate", LanguageManager.RM.GetString("ScenarioGridTitleExpectedDate", CultureInfo.CurrentUICulture) },
                { "expecteddateend", LanguageManager.RM.GetString("ScenarioGridTitleExpectedDateEnd", CultureInfo.CurrentUICulture) },
                { "probability", LanguageManager.RM.GetString("ScenarioGridTitleProbability", CultureInfo.CurrentUICulture) },
                { "recurring", LanguageManager.RM.GetString("ScenarioGridTitleRecurring", CultureInfo.CurrentUICulture) },
                { "isrealized", LanguageManager.RM.GetString("ScenarioGridTitleIsRealized", CultureInfo.CurrentUICulture) },
                { "realizedat", LanguageManager.RM.GetString("ScenarioGridTitleRealizedAt", CultureInfo.CurrentUICulture) },
                { "createdat", LanguageManager.RM.GetString("ScenarioGridTitleCreatedAt", CultureInfo.CurrentUICulture) },
                { "updateat", LanguageManager.RM.GetString("ScenarioGridTitleUpdateAt", CultureInfo.CurrentUICulture) },
            };

            // Sütun başlıklarını ayarla
            foreach (DataGridViewColumn col in grid.Columns)
                if (names.ContainsKey(col.Name))
                    col.HeaderText = names[col.Name];
        }
        #endregion

        // FORM LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmScenarios_Load(object sender, EventArgs e)
        {
            DgvScenariosTable.DataSource = Database.LoadTable("Scenarios");
            FormatScenarioGrid(DgvScenariosTable);
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region

        private void BtnAddScenarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteScenarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditScenarios_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

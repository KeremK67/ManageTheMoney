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

        // VARIABLES - DEĞİŞKENLER
        #region
        private readonly FrmAddScenarios AddScenarios = new();
        #endregion

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
            if (grid.Columns["TypeId"] != null)
            {
                grid.Columns["TypeId"].Visible = false;
            }
            if (grid.Columns["Category"] != null)
            {
                grid.Columns["Category"].Visible = false;
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
                { "isnecessary", LanguageManager.RM.GetString("ScenarioGridTitleIsNecessary", CultureInfo.CurrentUICulture) },
                { "realizedat", LanguageManager.RM.GetString("ScenarioGridTitleRealizedAt", CultureInfo.CurrentUICulture) },
                { "createdat", LanguageManager.RM.GetString("ScenarioGridTitleCreatedAt", CultureInfo.CurrentUICulture) },
                { "updatedat", LanguageManager.RM.GetString("ScenarioGridTitleUpdatedAt", CultureInfo.CurrentUICulture) },
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
            this.Text = LanguageManager.RM.GetString("FrmScenariosText", CultureInfo.CurrentUICulture);
            GrpEditScenarios.Text = LanguageManager.RM.GetString("GrpEditScenariosText", CultureInfo.CurrentUICulture);
            BtnAddScenario.Text = LanguageManager.RM.GetString("BtnAddScenarioText", CultureInfo.CurrentUICulture);
            BtnDeleteScenario.Text = LanguageManager.RM.GetString("BtnDeleteScenarioText", CultureInfo.CurrentUICulture);
            BtnEditScenario.Text = LanguageManager.RM.GetString("BtnEditScenarioText", CultureInfo.CurrentUICulture);
            GrpScenariosTable.Text = LanguageManager.RM.GetString("GrpScenariosTableText", CultureInfo.CurrentUICulture);

            DgvScenariosTable.DataSource = Database.LoadJoinedTable(
                mainTable: "Scenarios",
                joins: new[] {
                ("ScenarioTypes", "TypeId", "Id")},
            columns: new[] { "Scenarios.*", "ScenarioTypes.Category" },
            where: $"UserId = {Properties.Settings.Default.LoggedUserId}",
            orderBy: "ExpectedDate ASC");
            FormatScenarioGrid(DgvScenariosTable);
            DgvScenariosTable.RowTemplate.Height = 50;
        }
        #endregion

        // DATAGRIDVIEW LOAD - DATAGRIDVIEW YÜKLENDİĞİNDE
        #region
        private void DgvScenariosTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DgvScenariosTable.ClearSelection();

            string category = DgvScenariosTable.Rows[e.RowIndex].Cells["Category"].Value?.ToString();

            if (category == "Incomes")
                DgvScenariosTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

            else if (category == "Expenses")
                DgvScenariosTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region

        private void BtnAddScenarios_Click(object sender, EventArgs e)
        {
            AddScenarios.ShowDialog();
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

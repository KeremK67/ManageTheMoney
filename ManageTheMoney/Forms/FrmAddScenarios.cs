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
    public partial class FrmAddScenarios : Form
    {
        // !! TEXTBOXLARI BÜYÜT, SENARYO TİPLERİNİN İSİMLERİNİ DÜZENLE
        public FrmAddScenarios()
        {
            InitializeComponent();
        }

        // VALUES -- DEĞİŞKENLER
        public event Action ScenarioAdded;

        // FORM LOAD -- FORM YÜKLENDİĞİNDE
        #region
        private void FrmAddScenarios_Load(object sender, EventArgs e)
        {
            // Gelir gider türlerini getirme
            LoadScenarioCategories();

            // Hesapları getirme
            CmbAccount.Items.Clear();
            foreach (var item in Database.GetAccounts())
            {
                CmbAccount.Items.Add(item);
            }
            CmbAccount.SelectedIndex = 0;
        }
        #endregion

        // METHODS - METOTLAR
        #region
        // Gelir gider türlerini getirme
        private void LoadScenarioCategories()
        {
            CmbScenarioType.Items.Clear();
            foreach (var item in Database.GetScenarioTypesByCategory(ChbScenarioCategory.Checked))
            {
                CmbScenarioType.Items.Add(item);
            }
            CmbScenarioType.SelectedIndex = 0;
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // kontroller
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Title cannot be left blank");
            }
            else if (string.IsNullOrWhiteSpace(TxtAmount.Text))
            {
                MessageBox.Show("Amount cannot be left blank");
            }
            else if (string.IsNullOrWhiteSpace(TxtProbability.Text))
            {
                MessageBox.Show("Probability cannot be left blank");
            }
            else
            {
                // kontroller
                DateTime? expetedDate = ChbExpectedDateNull.Checked ? null : DtpExpectedDate.Value;
                DateTime? expectedDateEnd = ChbExpectedDateEndNull.Checked ? null : DtpExpectedDateEnd.Value;
                DateTime? realizedAt = ChbRealizedDateNull.Checked ? null : DtpRealizedDate.Value;

                if (
                    Database.AddScenario(
                    Database.GetAccountIdByName(CmbAccount.Text),
                    TxtTitle.Text,
                    TxtDescription.Text,
                    Database.GetTypeIdByName(CmbScenarioType.Text, ChbScenarioCategory.Checked ? "Incomes" : "Expenses"),
                    Convert.ToDecimal(TxtAmount.Text),
                    Convert.ToInt32(TxtProbability.Text),
                    ChbRecurring.Checked,
                    ChbRealized.Checked,
                    ChbNecessary.Checked,
                    expetedDate,
                    expectedDateEnd,
                    realizedAt
                    )
                    )
                {
                    MessageBox.Show("Scenario added successfully");
                    ScenarioAdded?.Invoke();
                    this.Close();
                }
                else
                    MessageBox.Show("An error occurred while adding the scenario");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ScenarioAdded?.Invoke();
            this.Close();
        }
        #endregion

        // CHECKBOXES - ONAY KUTULARI
        #region
        // Null checkbox kontrolleri
        private void ChbRealizedDateNull_CheckedChanged(object sender, EventArgs e)
        {
            DtpRealizedDate.Enabled = !ChbRealizedDateNull.Checked;
        }
        private void ChbExpectedDateEndNull_CheckedChanged(object sender, EventArgs e)
        {
            DtpExpectedDateEnd.Enabled = !ChbExpectedDateEndNull.Checked;
        }
        private void ChbExpectedDateNull_CheckedChanged(object sender, EventArgs e)
        {
            DtpExpectedDate.Enabled = !ChbExpectedDateNull.Checked;
        }
        // Gelir gider ayrımı
        private void ChbScenarioCategory_CheckedChanged(object sender, EventArgs e)
        {
            LoadScenarioCategories();
        }
        #endregion
    }
}

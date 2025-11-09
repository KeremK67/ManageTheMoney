using ManageTheMoney.Classes;
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
using System.Windows.Forms.DataVisualization;

namespace ManageTheMoney.Forms
{
    public partial class FrmMainContent : Form
    {
        /*
         * BU FORM ANA İÇERİK FORMUDUR!!
         * BU FORMDA AMACIM ANA MENÜNÜN İÇERİĞİNİ OLUŞTURMAK.
         * İÇERİĞİNDE GRAFİKLER VE İSTATİSTİKLER GÖSTERİLECEK.
         */

        public FrmMainContent()
        {
            InitializeComponent();
        }

        // VARIABLES - DEĞİŞKENLER
        #region
        private int SelectedMonth = DateTime.Now.Month;
        private int SelectedYear = DateTime.Now.Year;
        #endregion

        // LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmMainContent_Load(object sender, EventArgs e)
        {
            // LOCALIZE - YERELLEŞTİRME
            this.Text = LanguageManager.RM.GetString("FrmMainContentText", CultureInfo.CurrentUICulture);
            string[] langs = LanguageManager.RM.GetString("CmbMonths").Split(';');
            CmbMonths.Items.Clear();
            CmbMonths.Items.AddRange(langs);
            CmbMonths.SelectedIndex = SelectedMonth - 1;
            int[] years = new int[] { DateTime.Now.Year - 5, DateTime.Now.Year - 4, DateTime.Now.Year - 3, DateTime.Now.Year - 2, DateTime.Now.Year - 1, DateTime.Now.Year, DateTime.Now.Year + 1 };
            CmbYears.Items.Clear();
            foreach (int year in years)
            {
                CmbYears.Items.Add(year.ToString());
            }
            CmbYears.Text = SelectedYear.ToString();
            CmbDays.Items.Clear();
            for (int day = 1; day <= DateTime.DaysInMonth(Convert.ToInt16(CmbYears.Text), CmbMonths.SelectedIndex+1); day++)
            {
                CmbDays.Items.Add(day);
            }
            CmbDays.SelectedIndex = 0;
            GrpPreviousStatement.Text = LanguageManager.RM.GetString("GrpPreviousStatementText", CultureInfo.CurrentUICulture);
            GrpStatament.Text = LanguageManager.RM.GetString("GrpStatamentText", CultureInfo.CurrentUICulture);
            LblPreviousIncomes.Text = LanguageManager.RM.GetString("LblPreviousIncomesText", CultureInfo.CurrentUICulture);
            LblPreviousExpenses.Text = LanguageManager.RM.GetString("LblPreviousExpensesText", CultureInfo.CurrentUICulture);
            LblPreviousTotal.Text = LanguageManager.RM.GetString("LblPreviousTotalText", CultureInfo.CurrentUICulture);
            LblIncomes.Text = LanguageManager.RM.GetString("LblIncomesText", CultureInfo.CurrentUICulture);
            LblExpenses.Text = LanguageManager.RM.GetString("LblExpensesText", CultureInfo.CurrentUICulture);
            LblTotal.Text = LanguageManager.RM.GetString("LblTotalText", CultureInfo.CurrentUICulture);

            // LOAD DATA - VERİ YÜKLEME
            decimal incomes = Database.GetIncomesAndExpenses().incomes, expenses = Database.GetIncomesAndExpenses().espenses;

            TxtIncomes.Text = incomes.ToString();
            TxtExpenses.Text = expenses.ToString();
            TxtTotal.Text = (incomes - expenses).ToString();
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region
        // PREVIOUS AND NEXT BUTTONS FOR MONTH SELECTION - AY SEÇİMİ İÇİN ÖNCEKİ VE SONRAKİ BUTONLARI --GÜNLERİ AYARLA!!
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            CmbMonths.SelectedIndex--;
            if (CmbMonths.SelectedIndex < 0)
            {
                CmbMonths.SelectedIndex = 11;
                CmbYears.SelectedIndex--;
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CmbMonths.SelectedIndex >= CmbMonths.Items.Count - 1)
            {
                CmbMonths.SelectedIndex = 0;
                CmbYears.SelectedIndex++;
            }
            else
            {
                CmbMonths.SelectedIndex++;
            }
        }
        #endregion
    }
}

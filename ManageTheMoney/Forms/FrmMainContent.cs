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

        // METHODS - METOTLAR
        #region
        // GET STATEMENT - HESAP ÖZETİNİ ALMA
        private void GetStatement(int year = 0, int month = 0, int day = 0)
        {
            decimal incomes = 0, expenses = 0, total = 0, previousIncomes = 0, previousExpenses = 0, previousTotal = 0;
            if (year != 0 && month == 0 && day == 0)
            {
                incomes = Database.GetIncomesAndExpenses(year).incomes;
                expenses = Database.GetIncomesAndExpenses(year).expenses;
                total = incomes - expenses;

                year--;
                previousIncomes = Database.GetIncomesAndExpenses(year).incomes;
                previousExpenses = Database.GetIncomesAndExpenses(year).expenses;
                previousTotal = previousIncomes - previousExpenses;
            }
            else if (year != 0 && month != 0 && day == 0)
            {
                incomes = Database.GetIncomesAndExpenses(year, month).incomes;
                expenses = Database.GetIncomesAndExpenses(year, month).expenses;
                total = incomes - expenses;

                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }
                previousIncomes = Database.GetIncomesAndExpenses(year, month).incomes;
                previousExpenses = Database.GetIncomesAndExpenses(year, month).expenses;
                previousTotal = previousIncomes - previousExpenses;
            }
            else if (year != 0 && month != 0 && day != 0)
            {
                incomes = Database.GetIncomesAndExpenses(year, month, day).incomes;
                expenses = Database.GetIncomesAndExpenses(year, month, day).expenses;
                total = incomes - expenses;

                day--;
                if (day == 0)
                {
                    month--;
                    if (month == 0)
                    {
                        month = 12;
                        year--;
                    }
                    day = Convert.ToByte(DateTime.DaysInMonth(year, month));
                }
                previousIncomes = Database.GetIncomesAndExpenses(year, month, day).incomes;
                previousExpenses = Database.GetIncomesAndExpenses(year, month, day).expenses;
                previousTotal = previousIncomes - previousExpenses;
            }
            else
            {
                incomes = Database.GetIncomesAndExpenses().incomes;
                expenses = Database.GetIncomesAndExpenses().expenses;
                total = incomes - expenses;
            }

            TxtIncomes.Text = incomes.ToString();
            TxtExpenses.Text = expenses.ToString();
            TxtTotal.Text = total.ToString();
            TxtPreviousIncomes.Text = previousIncomes.ToString();
            TxtPreviousExpenses.Text = previousExpenses.ToString();
            TxtPreviousTotal.Text = previousTotal.ToString();
        }

        // GET DAYS IN MONTH - AYDAKİ GÜNLERİ ALMA
        private void GetDaysInMonth()
        {
            int oldIndex = CmbDays.SelectedIndex;

            // Günleri yeniden yükle
            CmbDays.Items.Clear();
            int days = DateTime.DaysInMonth(Convert.ToInt32(CmbYears.Text), CmbMonths.SelectedIndex + 1);
            for (int day = 1; day <= days; day++)
            {
                CmbDays.Items.Add(day);
            }

            // Eğer eski index geçersiz hale geldiyse, son güne ayarla
            if (oldIndex >= CmbDays.Items.Count)
                oldIndex = CmbDays.Items.Count - 1;

            // Eğer liste boş değilse index’i uygula
            if (oldIndex >= 0)
                CmbDays.SelectedIndex = oldIndex;
            else
                CmbDays.SelectedIndex = 0;
        }
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
            GetDaysInMonth();
            GrpPreviousStatement.Text = LanguageManager.RM.GetString("GrpPreviousStatementText", CultureInfo.CurrentUICulture);
            GrpStatament.Text = LanguageManager.RM.GetString("GrpStatamentText", CultureInfo.CurrentUICulture);
            LblPreviousIncomes.Text = LanguageManager.RM.GetString("LblPreviousIncomesText", CultureInfo.CurrentUICulture);
            LblPreviousExpenses.Text = LanguageManager.RM.GetString("LblPreviousExpensesText", CultureInfo.CurrentUICulture);
            LblPreviousTotal.Text = LanguageManager.RM.GetString("LblPreviousTotalText", CultureInfo.CurrentUICulture);
            LblIncomes.Text = LanguageManager.RM.GetString("LblIncomesText", CultureInfo.CurrentUICulture);
            LblExpenses.Text = LanguageManager.RM.GetString("LblExpensesText", CultureInfo.CurrentUICulture);
            LblTotal.Text = LanguageManager.RM.GetString("LblTotalText", CultureInfo.CurrentUICulture);

            // LOAD DATA - VERİ YÜKLEME
            GetStatement(Convert.ToInt16(CmbYears.Text), Convert.ToByte(CmbMonths.SelectedIndex + 1));
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
            GetDaysInMonth();
            GetStatement(Convert.ToInt16(CmbYears.Text), Convert.ToByte(CmbMonths.SelectedIndex + 1));
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
            GetDaysInMonth();
            GetStatement(Convert.ToInt16(CmbYears.Text), Convert.ToByte(CmbMonths.SelectedIndex + 1));
        }
        #endregion
    }
}

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
    public partial class FrmRegister : Form
    {
        /*
         * BU FORM KAYIT FORMUDUR!!
         */

        // !PAROLA KONTROLÜ EKLE!
        // !TASARIMI DÜZENLE!
        // !TEXTBOXTA KALAN VERİLERİ TEMİZLE!

        public FrmRegister()
        {
            InitializeComponent();
        }

        // LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.Text = LanguageManager.RM.GetString("FrmRegisterText", System.Globalization.CultureInfo.CurrentUICulture);
            GrpRegister.Text = LanguageManager.RM.GetString("GrpRegisterText", System.Globalization.CultureInfo.CurrentUICulture);
            LblName.Text = LanguageManager.RM.GetString("LblNameText", System.Globalization.CultureInfo.CurrentUICulture);
            LblSurname.Text = LanguageManager.RM.GetString("LblSurnameText", System.Globalization.CultureInfo.CurrentUICulture);
            LblUsername.Text = LanguageManager.RM.GetString("LblUsernameText", System.Globalization.CultureInfo.CurrentUICulture);
            LblPassword.Text = LanguageManager.RM.GetString("LblPasswordText", System.Globalization.CultureInfo.CurrentUICulture);
            LblMail.Text = LanguageManager.RM.GetString("LblMailText", System.Globalization.CultureInfo.CurrentUICulture);
            LblPhoneNumber.Text = LanguageManager.RM.GetString("LblPhoneNumberText", System.Globalization.CultureInfo.CurrentUICulture);
            LblDateOfBirth.Text = LanguageManager.RM.GetString("LblDateOfBirthText", System.Globalization.CultureInfo.CurrentUICulture);
            BtnCancel.Text = LanguageManager.RM.GetString("BtnCancelText", System.Globalization.CultureInfo.CurrentUICulture);
            BtnRegister.Text = LanguageManager.RM.GetString("BtnRegisterText", System.Globalization.CultureInfo.CurrentUICulture);
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Database.Register(TxtName.Text,TxtSurname.Text,TxtUsername.Text,TxtPassword.Text,DtpDateOfBirth.Value,TxtMail.Text,TxtPhoneNumber.Text))
            {
                MessageBox.Show("başarılı");
            }
            else
            {
                MessageBox.Show("başarısız");
            }
        }
        #endregion
    }
}

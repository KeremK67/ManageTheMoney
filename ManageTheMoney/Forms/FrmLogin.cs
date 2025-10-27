using ManageTheMoney.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ManageTheMoney.Forms
{
    public partial class FrmLogin : Form
    {
        /*
         * BU FORM GİRİŞ FORMUDUR!!
         * BU FORMDA AMACIM KULLANICININ KULLANICI ADI VE ŞİFRESİNİ ALIP DOĞRULAMAK.
         * YA DA YENİ KULLANICI KAYDI OLUŞTURMASINI SAĞLAMAK.
         */

        public FrmLogin()
        {
            InitializeComponent();
        }

        // VALUES - DEĞERLER
        #region
        FrmMain Main = new FrmMain();
        FrmRegister Register = new FrmRegister();
        #endregion

        // LOAD - FORM YÜKLENDİĞİNDE
        #region
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = LanguageManager.RM.GetString("FrmLoginText", CultureInfo.CurrentUICulture);
            GrpLogin.Text = LanguageManager.RM.GetString("GrpLoginText", CultureInfo.CurrentUICulture);
            LblUsername.Text = LanguageManager.RM.GetString("LblUsernameText", CultureInfo.CurrentUICulture);
            LblPassword.Text = LanguageManager.RM.GetString("LblPasswordText", CultureInfo.CurrentUICulture);
            BtnLogin.Text = LanguageManager.RM.GetString("BtnLoginText", CultureInfo.CurrentUICulture);
            BtnRegister.Text = LanguageManager.RM.GetString("BtnRegisterText", CultureInfo.CurrentUICulture);
        }
        #endregion

        // BUTTONS - BUTONLAR
        #region
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Database.Login(TxtUsername.Text, TxtPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                TxtPassword.Clear();
                TxtUsername.Clear();
            }
            else
            {
                MessageBox.Show(LanguageManager.RM.GetString("ErrorLoginFailedMessage", System.Globalization.CultureInfo.CurrentUICulture), LanguageManager.RM.GetString("ErrorTitle", System.Globalization.CultureInfo.CurrentUICulture), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register.ShowDialog();
        }
        #endregion
    }
}

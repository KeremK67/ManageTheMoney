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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        // VARIABLES - DEĞİŞKENLER
        #region
        private readonly FrmRegister Register = new();
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
                Properties.Settings.Default.IsLoggedIn = true;
                Properties.Settings.Default.LoggedUserId = Database.GetUserIdByUsername(TxtUsername.Text);
                Properties.Settings.Default.Save();

                TxtPassword.Clear();
                TxtUsername.Clear();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(LanguageManager.RM.GetString("ErrorLoginFailedMessage",CultureInfo.CurrentUICulture), LanguageManager.RM.GetString("ErrorTitle", CultureInfo.CurrentUICulture), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register.ShowDialog();
        }
        #endregion
    }
}

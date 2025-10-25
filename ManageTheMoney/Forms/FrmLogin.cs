using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
        #endregion

        // BUTTONS - BUTONLAR
        #region
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register.ShowDialog();
        }
        #endregion
    }
}

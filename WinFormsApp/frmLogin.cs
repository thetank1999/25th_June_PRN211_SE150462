using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class frmLogin : Form
    {
        DbAccountRepository _dbAccountRepository = new DbAccountRepository();
        public frmLogin() {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            var _IdEmail = tB_Login_IdEmail.Text;
            var _Password = tB_Login_Password.Text;
            var _temp = _dbAccountRepository.Login(_IdEmail, _Password);
            if (_temp != null) //  | login successfully
                {
                    this.Hide();
                    var formManagement = new frmManagement(_temp); //transfer the account infor into the next form
                    formManagement.Show();
            } else // login failed
                {
                MessageBox.Show("Incorrect Email or Password. Please do it agian");

                tB_Login_Password.Clear();
            }
        }
    }
}

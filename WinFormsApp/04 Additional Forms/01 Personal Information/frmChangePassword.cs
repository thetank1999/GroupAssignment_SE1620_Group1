using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp
{
    public partial class frmChangePassword : Form
    {
        #region [ Fields ]
        private readonly User _user;
        private readonly IUserDataProviders _userDataProvider;
        #endregion

        #region [ Ctor ]
        public frmChangePassword(User user, IUserDataProviders userDataProvider) {
            this._user = user;
            this._userDataProvider = userDataProvider;
            InitializeComponent();
        }
        #endregion

        private void btn_SaveChange_Click(object sender, EventArgs e) {
            if (this.IsNotValidInput(this._user)) {
                MessageBox.Show("Invalid Input");
            } else {
                this._user.UserPassword = tb_NewPassword.Text;
                _userDataProvider.UpdateUser(_user);
                MessageBox.Show("Password is updated.");
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private bool IsNotValidInput(User user) {
            if (tb_CurrentPassword.Text != user.UserPassword) {
                return true;
            }else if (tb_NewPassword.Text != tb_PasswordConfirmation.Text) {
                return true;
            } else {
                return false;
            }
        }
    }
}

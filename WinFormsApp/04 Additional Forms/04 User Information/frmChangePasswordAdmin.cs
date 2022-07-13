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
    public partial class frmChangePasswordAdmin : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private User _user;
        #endregion

        #region [ CTor ]
        public frmChangePasswordAdmin(IUserDataProviders userDataProvider,
                                      User user) {
            this._userDataProvider = userDataProvider;
            this._user = user;
            InitializeComponent();
        }
        #endregion

        #region [ btn Events ]
        private void btn_Save_Click(object sender, EventArgs e) {
            if (this.IsNotValidPassword()) {
                MessageBox.Show("Password confirmation is not correct.");
            } else {
                this._user.UserPassword = tb_PasswordConfirm.Text.ToString();
                this._userDataProvider.UpdateUser(this._user);
                this.Close();
                MessageBox.Show("Password Updated.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region [ validation ]
        private bool IsNotValidPassword() {
            if (tb_Password.Text != tb_PasswordConfirm.Text) {
                return true;
            } else {
                return false;
            }
        }
        #endregion
    }
}

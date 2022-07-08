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

namespace WinFormsApp
{
    public partial class frmLogin : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        #endregion
        public frmLogin(IUserDataProviders userDataProvider) {
            this._userDataProvider = userDataProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var user = _userDataProvider.GetUser(1);
            label1.Text = user.UserFullname.Trim();
        }

        private void button2_Click(object sender, EventArgs e) {
            var user = _userDataProvider.GetUserByEmail("thanh.van@wave5.nl");
            label2.Text = user.UserFullname.Trim(); 
        }
    }
}

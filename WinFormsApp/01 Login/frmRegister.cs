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
    public partial class frmRegister : Form
    {
        #region [ Fields ]
        private readonly IDataHelper _dataHelper;
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        #endregion
        #region [ Ctor ]
        public frmRegister( IUserDataProviders userDataProvider,
                            IDataHelper dataHelper,
                            IRoleDataProvider roleDataProvider,
                            IMajorDataProvider majorDataProvider) {
            this._userDataProvider = userDataProvider;
            this._dataHelper = dataHelper;
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            InitializeComponent();
            this.AutoLoadDataIntoListBox();
        }
        #endregion
        private void btn_Register_Click(object sender, EventArgs e) {
            var isNotValidEmail = !_dataHelper.EmailValidation(tb_EmailAddress.Text);
            var dbEntity = _userDataProvider.GetUserByEmail(tb_EmailAddress.Text);
            var isNotConfirmedPassword = !tb_ConfirmPassword.Text.Equals(tb_Password.Text);
            if (isNotValidEmail) {
                MessageBox.Show("Please enter valid email address.");
            } else if (dbEntity != null) {
                MessageBox.Show("Email Address cannot be dupplicated.");
            } else if (isNotConfirmedPassword) {
                MessageBox.Show("Password and Password confirmation are not the same.");
            } else if (this.IsNotValidatedInput()) {
                MessageBox.Show("Invalid Input.");
            } else {
                var userEntity = new User();
                userEntity.UserEmail = tb_EmailAddress.Text.Trim();
                userEntity.UserRoleId = 2; // default -> member
                userEntity.UserFullname = tb_Fullname.Text.Trim();
                Major majorEntity = listBox_Major.SelectedItem as Major;
                userEntity.UserMajorId = majorEntity.MajorId;
                userEntity.UserPassword = tb_Password.Text.Trim();
                _userDataProvider.AddUser(userEntity);
                MessageBox.Show("Register Successfully");
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AutoLoadDataIntoListBox() {
            listBox_Major.Items.Clear();
            var majorList = _majorDataProvider.GetAllMajors();
            foreach (var major in majorList) {
                listBox_Major.Items.Add(major);
            }
        }

        private bool IsNotValidatedInput() {
            if ((tb_EmailAddress.Text.Length == 0)
               || (tb_Fullname.Text.Length == 0)
               || (tb_Password.Text.Length == 0)
               || (tb_ConfirmPassword.Text.Length == 0)
               || (listBox_Major.SelectedIndex < -1)) {
                return true;
            } else {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp
{
    public partial class frmUpdateInformation : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDataHelper _dataHelper;
        private User _user;
        private List<Major> _majorList;
        private List<Role> _roleList;
        #endregion

        #region [ Ctor ]
        public frmUpdateInformation(IUserDataProviders userDataProvider,
                                    IRoleDataProvider roleDataProvider,
                                    IMajorDataProvider majorDataProvider,
                                    IDataHelper dataHelper,
                                    User user) {
            this._userDataProvider = userDataProvider;
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._dataHelper = dataHelper;
            this._user = user;
            this._majorList = this._majorDataProvider.GetAllMajors();
            this._roleList = this._roleDataProvider.GetAllRoles();
            InitializeComponent();
            this.LoadDataIntoCBsAndTBs(this._majorList, this._roleList, this._user);
        }
        #endregion

        #region [ btn Events ]
        private void btn_Save_Click(object sender, EventArgs e) {
            
            if (this.IsNotValidInput()) {
                MessageBox.Show("Invalid Input");
            }else if(this.IsNotValidEmail()) {
                MessageBox.Show("Invalid Email Address");
            } else {
                var dbMajor = cb_Major.SelectedItem as Major;
                var dbRole = cb_Role.SelectedItem as Role;
                var isActive = Boolean.Parse(cb_IsActive.SelectedItem.ToString());
                this._user.UserRoleId = dbRole.RoleId;
                this._user.UserMajor = dbMajor.MajorId;
                this._user.UserStatus = isActive;
                this._user.UserEmail = tb_Email.Text;
                this._user.UserFullname = tb_Fullname.Text;
                _userDataProvider.UpdateUser(this._user);
                this.Close();
                MessageBox.Show("Updated.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region [ init and load Data ]
        private void LoadDataIntoCBsAndTBs(List<Major> majorList, List<Role> roleList, User user) {
            this.LoadStatusIntoCB(user);
            this.LoadMajorIntoCB(majorList, user);
            this.LoadRolesIntoCb(roleList, user );
            this.LoadDataIntoTBs(user);
        }
        private void LoadMajorIntoCB(List<Major> majorList, User user) {
            cb_Major.Items.Clear();
            foreach (Major major in majorList) {
                cb_Major.Items.Add(major);
                if (major.MajorId == user.UserMajor) {
                    cb_Major.SelectedItem = major;
                }
            }
        }

        private void LoadRolesIntoCb(List<Role> roleList, User user) {
            cb_Role.Items.Clear();
            foreach (Role role in roleList) {
                cb_Role.Items.Add(role);
                if (role.RoleId == user.UserRoleId) {
                    cb_Role.SelectedItem = role;
                }
            }
        }
        private void LoadStatusIntoCB(User user) {
            cb_IsActive.Items.Clear();
            cb_IsActive.Items.Add(true);
            cb_IsActive.Items.Add(false);
            if (user.UserStatus == true) {
                cb_IsActive.SelectedItem = true;
            } else {
                cb_IsActive.SelectedItem = false;
            }
        }

        private void LoadDataIntoTBs(User user) {
            tb_Email.Text = user.UserEmail;
            tb_Fullname.Text = user.UserFullname;
        }

        private bool IsNotValidInput() {
            if (    tb_Email.Text.Length == 0
                ||  tb_Fullname.Text.Length == 0
                ||  cb_IsActive.SelectedIndex <= -1
                ||  cb_Major.SelectedIndex <= -1
                ||  cb_Role.SelectedIndex <= -1) {
                return true;
            }else {
                return false;
            }
        }

        private bool IsNotValidEmail() { 
            var emailString = tb_Email.Text.ToString();
            var dbUser = this._userDataProvider.GetUserByEmail(emailString);
            if (_dataHelper.EmailValidation(emailString) && dbUser == null) {
                return false;
            } else if(_dataHelper.EmailValidation(emailString) && dbUser.UserId == this._user.UserId) {
                return false;
            }else {
                return true;
            }
        }
        #endregion
    }
}

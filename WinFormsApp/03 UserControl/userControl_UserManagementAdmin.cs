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
    public partial class userControl_UserManagementAdmin : UserControl
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDataHelper _dataHelper;
        private readonly User _user;
        private List<User> _userList;
        private List<Major> _majorList;
        private List<Role> _roleList;
        #endregion

        #region [ CTor ]
        public userControl_UserManagementAdmin( IUserDataProviders userDataProvider,
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
            this._userList = this._userDataProvider.GetAllUsers();
            this._roleList = this._roleDataProvider.GetAllRoles();
            InitializeComponent();

            this.LoadDataIntoCBs(_majorList, _roleList);
            this.LoadDataIntoDGV(_userList);
            
        }
        #endregion

        #region [ btn Events ]
        private void btn_Update_Click(object sender, EventArgs e) {
            var id =Int32.Parse(dgv_UserList.SelectedRows[0].Cells[0].Value.ToString());
            var dbUser = this._userDataProvider.GetUser(id);
            var frmUpdateInformation = new frmUpdateInformation(_userDataProvider,
                                                                _roleDataProvider,
                                                                _majorDataProvider,
                                                                _dataHelper,
                                                                dbUser);
            frmUpdateInformation.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e) {
            this.RefreshDataDGV();
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e) {
            var id = Int32.Parse(dgv_UserList.SelectedRows[0].Cells[0].Value.ToString());
            var dbUser = this._userDataProvider.GetUser(id);
            var frmChangePasswordAdmin = new frmChangePasswordAdmin(_userDataProvider,
                                                                    dbUser);
            frmChangePasswordAdmin.ShowDialog();
        }
        #endregion

        #region [cb Events]
        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Status.SelectedIndex > -1) {
                var statusString = cb_Status.SelectedItem.ToString();
                this._userList = this._userList.Where(x=>x.UserStatus.ToString() == statusString).ToList();
                this.LoadDataIntoDGV(this._userList);
            } else {
                this.RefreshDataDGV();
            }
        }

        private void cb_Role_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Role.SelectedIndex > -1) {
                var dbRole = cb_Role.SelectedItem as Role;
                this._userList = this._userList.Where(x => x.UserRoleId == dbRole.RoleId).ToList();
                this.LoadDataIntoDGV(this._userList);
            } else {
                this.RefreshDataDGV();
            }
        }
        private void cb_Major_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Major.SelectedIndex > -1) { 
                var dbMajor = cb_Major.SelectedItem as Major;
                this._userList = this._userList.Where(x => x.UserMajor == dbMajor.MajorId).ToList();
                this.LoadDataIntoDGV(this._userList);
            } else {
                this.RefreshDataDGV();
            }
        }
        #endregion

        #region [ tb Events ]
        private void tb_Email_TextChanged(object sender, EventArgs e) {
            if (tb_Email.Text.Length > 0) {
                var searchString = tb_Email.Text.ToString();
                this._userList = this._userList.Where(x=> x.UserEmail.
                                                Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).
                                                ToList();
                this.LoadDataIntoDGV(this._userList);
            } else {
                this.RefreshDataDGV();
            }
        }
        #endregion

        #region [dgv Events]
        private void dgv_UserList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_UserList.SelectedRows.Count == 1) {
                btn_Update.Enabled = true;
                btn_ChangePassword.Enabled = true;
            }else {
                btn_Update.Enabled = false;
                btn_ChangePassword.Enabled = false;
            }
        }
        #endregion

        #region [ init and Load Data ]
        private void LoadDataIntoCBs(List<Major> majorList, List<Role> roleList) {
            this.LoadStatusIntoCB();
            this.LoadMajorIntoCB(majorList);
            this.LoadRolesIntoCb(roleList);
        }

        private void LoadMajorIntoCB(List<Major> majorList) { 
            cb_Major.Items.Clear();
            foreach (Major major in majorList) {
                cb_Major.Items.Add(major);
            }
        }

        private void LoadRolesIntoCb(List<Role> roleList) { 
            cb_Role.Items.Clear();
            foreach (Role role in roleList) {
                cb_Role.Items.Add(role);
            }
        }

        private void LoadStatusIntoCB() {
            cb_Status.Items.Clear();
            cb_Status.Items.Add(true);
            cb_Status.Items.Add(false);
        }

        private void LoadDataIntoDGV(List<User> userList) {
            dgv_UserList.Rows.Clear();
            foreach (User user in userList) {
                var dbRole = _roleDataProvider.GetRoleById(user.UserRoleId);
                var dbMajor = _majorDataProvider.GetMajorById(user.UserMajor);
                dgv_UserList.Rows.Add(user.UserId, user.UserFullname, user.UserEmail, dbMajor, dbRole , user.UserStatus);
            }
        }

        private void RefreshDataDGV() {
            this._userList = this._userDataProvider.GetAllUsers();
            this.LoadDataIntoDGV(_userList);
        }
        #endregion

    }
}

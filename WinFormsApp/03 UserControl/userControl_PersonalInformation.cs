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
    
    public partial class userControl_PersonalInformation : UserControl
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDataHelper _dataHelper;
        private User _user;
        #endregion

        #region [ Ctor ] 
        public userControl_PersonalInformation(IUserDataProviders userDataProvider,
                                               IRoleDataProvider roleDataProvider,
                                               IMajorDataProvider majorDataProvider,
                                               IDataHelper dataHelper,
                                               User user) {
            this._userDataProvider = userDataProvider;
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._dataHelper = dataHelper;
            this._user = user;
            InitializeComponent();
            this.LoadData(user);
        }
        #endregion
        private void LoadData(User user) {
            tb_EmailAddress.Text = user.UserEmail;
            tb_Fullname.Text = user.UserFullname;
            tb_Major.Text = _majorDataProvider.GetMajorById(user.UserMajor).ToString();
            tb_Role.Text = _roleDataProvider.GetRoleById(user.UserRoleId).ToString();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e) {
            var frmChangePassword = new frmChangePassword( this._user, this._userDataProvider);
            frmChangePassword.ShowDialog();
        }

        private void btn_UpdateInformation_Click(object sender, EventArgs e) {
            var frmChangeInformation = new frmChangeInformationUser(this._userDataProvider, this._majorDataProvider, this._dataHelper, this._user);
            frmChangeInformation.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e) {
            var dbUser = _userDataProvider.GetUser(this._user.UserId);
            this.LoadData(dbUser);
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using WinApp;
using WinApp.Core;
using WinApp.Login;

namespace WinFormsApp
{
    public partial class frmLogin : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IFavouriteDataProvider _favouriteDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        #endregion

        #region [ Ctor ]
        public frmLogin(IUserDataProviders userDataProvider, 
                        IRoleDataProvider roleDataProvider, 
                        IMajorDataProvider majorDataProvider, 
                        IFavouriteDataProvider favouriteDataProvider, 
                        IDocumentDataProvider documentDataProvider, 
                        ICategoryDataProvider categoryDataProvider, 
                        IDataHelper datahelper) {
            this._userDataProvider = userDataProvider;
            _roleDataProvider = roleDataProvider;
            _majorDataProvider = majorDataProvider;
            _favouriteDataProvider = favouriteDataProvider;
            _documentDataProvider = documentDataProvider;
            _categoryDataProvider = categoryDataProvider;
            _datahelper = datahelper;
            InitializeComponent();
        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e) {
            var dbEntity = _userDataProvider.GetUserLogin(tb_Email.Text, tb_Password.Text);
            if (dbEntity.UserRoleId == 1) // admin
                {
                MessageBox.Show(dbEntity.UserFullname.TrimEnd());
            }else if (dbEntity.UserRoleId == 2) // normal member
                {
                MessageBox.Show(dbEntity.UserFullname.TrimEnd()+$"{dbEntity.UserRoleId}");
            } else if (dbEntity.UserRoleId == 3) // lecturer
                {

            } else if (dbEntity.UserRoleId == 4) // head of department
                {

            } else if (dbEntity== null) {
                MessageBox.Show("Invalid email or password.");
                tb_Password.Clear();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e) {
            var frmRegister = new frmRegister(_userDataProvider,_datahelper, _roleDataProvider);
            frmRegister.ShowDialog();
        }
    }
}

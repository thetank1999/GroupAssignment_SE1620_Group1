using System;
using System.Windows.Forms;
using WinApp;
using WinApp.Core;

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
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._favouriteDataProvider = favouriteDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._datahelper = datahelper;
            InitializeComponent();
        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e) {
            var dbEntity = _userDataProvider.GetUserLogin(tb_Email.Text, tb_Password.Text);
            if (dbEntity == null) {
                MessageBox.Show("Invalid email or password.");
                tb_Password.Clear();
            }else {
                var frmGeneral = new frmGeneral(_userDataProvider,
                                                _roleDataProvider,
                                                _majorDataProvider,
                                                _favouriteDataProvider,
                                                _documentDataProvider,
                                                _categoryDataProvider,
                                                _datahelper,
                                                dbEntity);
                this.Hide();
                frmGeneral.ShowDialog();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e) {
            var frmRegister = new frmRegister(_userDataProvider,_datahelper, _roleDataProvider,_majorDataProvider);
            frmRegister.ShowDialog();
        }
    }
}

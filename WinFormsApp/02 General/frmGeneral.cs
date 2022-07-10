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
    public partial class frmGeneral : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IFavouriteDataProvider _favouriteDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        private readonly User _user;
        #endregion

        #region [ Ctor ]
        public frmGeneral(IUserDataProviders userDataProvider,
                        IRoleDataProvider roleDataProvider,
                        IMajorDataProvider majorDataProvider,
                        IFavouriteDataProvider favouriteDataProvider,
                        IDocumentDataProvider documentDataProvider,
                        ICategoryDataProvider categoryDataProvider,
                        IDataHelper datahelper,
                        User user) {
            this._userDataProvider = userDataProvider;
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._favouriteDataProvider = favouriteDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._datahelper = datahelper;
            this._user = user;
            InitializeComponent();
            this.SegregationOfDuty(_user);
        }
        #endregion

        #region [ Normal User ]
        private void btn_PersonalInformation_Click(object sender, EventArgs e) {

        }

        private void btn_MyFavourite_Click(object sender, EventArgs e) {

        }

        private void button_DocumentList_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ Lecturer ]
        private void btn_UploadDocument_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ Head of Lecturer ]
        private void btn_ApproveDocument_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ Administrator ]
        private void btn_DocumentManagement_Click(object sender, EventArgs e) {

        }

        private void btn_UserManagement_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ Segregation of Duty ]
        private void SegregationOfDuty(User user) {
            label_WelcomeBack.Text = $"Welcome Back {user.UserFullname}";
            switch (user.UserRoleId) {
                case 1: // is an admin 
                    {
                        btn_DocumentManagement.Visible = true;
                        btn_UserManagement.Visible = true;
                        break;
                    }
                case 3: {// is a lecturer

                        btn_UploadDocument.Visible = true;
                        break;
                    }
                case 4: {// is a head of lecturer

                        btn_ApproveDocument.Visible = true;
                        break;
                    }
            }
        }
        #endregion
    }
}

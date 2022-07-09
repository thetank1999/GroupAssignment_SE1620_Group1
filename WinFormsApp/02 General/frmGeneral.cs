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
            _roleDataProvider = roleDataProvider;
            _majorDataProvider = majorDataProvider;
            _favouriteDataProvider = favouriteDataProvider;
            _documentDataProvider = documentDataProvider;
            _categoryDataProvider = categoryDataProvider;
            _datahelper = datahelper;
            InitializeComponent();
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
            
        }
        #endregion
    }
}

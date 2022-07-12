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
    public partial class userControl_UploadDocument : UserControl
    {
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        private readonly User _user;
        private List<Document> _documentList;
        private List<Category> _categoryList;
        private List<Major> _majorList;
        
        public userControl_UploadDocument(  IUserDataProviders userDataProvider,
                                            IMajorDataProvider majorDataProvider,
                                            IDocumentDataProvider documentDataProvider,
                                            ICategoryDataProvider categoryDataProvider,
                                            IDataHelper datahelper,
                                            User user) {
            this._userDataProvider = userDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._datahelper = datahelper;
            this._user = user;
            InitializeComponent();
            this.LoadComboBox();
        }
        #region [ DGV ]
        private void dg_UploadList_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
        #endregion

        #region [ btn Events ]
        private void btn_RefreshData_Click(object sender, EventArgs e) {

        }

        private void btn_Delete_Click(object sender, EventArgs e) {

        }
        private void btn_UploadDocument_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ tb Events ]
        private void tb_SearchByName_TextChanged(object sender, EventArgs e) {

        }
        #endregion

        #region [ cb Events ]
        private void cb_Major_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cb_IsApproved_SelectedIndexChanged(object sender, EventArgs e) {

        }
        #endregion

        #region [ init data and load ]
        private List<Document> InitDocumentList(User user) { 
            var result = new List<Document>();
            result = this._documentDataProvider.GetDocumentsByUploaderId(user.UserId);
            return result;
        }

        private void LoadComboBox() {
            this.LoadMajorList();
            this.LoadCategoryList();
            this.LoadApprovalStatusList();
        }

        private void LoadMajorList() {
            this._majorList = _majorDataProvider.GetAllMajors();
            cb_Major.Items.Clear();
            foreach (var major in this._majorList) {
                cb_Major.Items.Add(major);
            }
        }

        private void LoadCategoryList() {
            this._categoryList = this._categoryDataProvider.GetAllCategorys();
            cb_Category.Items.Clear();
            foreach (var category in this._categoryList) {
                cb_Category.Items.Add(category);
            }
        }

        private void LoadApprovalStatusList() {
            cb_IsApproved.Items.Clear();
            cb_IsApproved.Items.Add(true);
            cb_IsApproved.Items.Add(false);
        }

        #endregion
    }
}

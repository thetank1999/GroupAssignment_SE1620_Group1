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
            this._documentList = this.InitDocumentList(this._user);
            InitializeComponent();
            this.LoadDGV(_documentList);
            this.LoadComboBox();
        }
        #region [ DGV ]
        private void dg_UploadList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_UploadList.SelectedRows.Count == 1) {
                btn_Delete.Enabled = true;
            } else {
                btn_Delete.Enabled = false;
            }
        }
        #endregion

        #region [ btn Events ]
        private void btn_RefreshData_Click(object sender, EventArgs e) {
            this._documentList = this.InitDocumentList(this._user);
            this.LoadDGV(_documentList);
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            var _dialogResult = MessageBox.Show("Do you really want to delete chosen submission?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var dbDocument = this._documentDataProvider.GetDocumentById(Int32.Parse(dgv_UploadList.SelectedRows[0].Cells[0].Value.ToString()));

                this._documentDataProvider.RemoveDocument(dbDocument);
                this._documentList = this.InitDocumentList(this._user);
                this.LoadDGV(_documentList);
                MessageBox.Show("Removed submission.");
            }
        }
        private void btn_UploadDocument_Click(object sender, EventArgs e) {
            var frmUploadDocument = new frmUploadDocument(  _userDataProvider,
                                                            _majorDataProvider,
                                                            _documentDataProvider,
                                                            _categoryDataProvider,
                                                            _datahelper,
                                                            _user);
            frmUploadDocument.ShowDialog();
        }
        #endregion

        #region [ tb Events ]
        private void tb_SearchByName_TextChanged(object sender, EventArgs e) {
            var tempDocumentList = this.SearchByName(tb_SearchByName.Text, this._documentList);
            this.LoadDGV(tempDocumentList);
        }
        #endregion

        #region [ cb Events ]
        private void cb_Major_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Category.SelectedIndex <= 0) {
                var dbMajor = cb_Major.SelectedItem as Major;
                var tempDocumentList = this._documentList.Where(x => x.MajorId == dbMajor.MajorId).ToList();
                this.LoadDGV(tempDocumentList);
            }
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Category.SelectedIndex <= 0) {
                var dbCategory = cb_Category.SelectedItem as Category;
                var tempDocumentList = this._documentList.Where(x => x.CategoryId == dbCategory.CategoryId).ToList();
                this.LoadDGV(tempDocumentList);
            }
        }

        private void cb_IsApproved_SelectedIndexChanged(object sender, EventArgs e) {
            var tempDocumentList = this._documentList.Where(x => x.IsApproved.ToString() == cb_IsApproved.SelectedItem.ToString()).ToList();
            this.LoadDGV(tempDocumentList);
        }
        #endregion

        #region [ init data and load ]
        private List<Document> InitDocumentList(User user) { 
            var result = new List<Document>();
            result = this._documentDataProvider.GetDocumentsByUploaderId(user.UserId);
            return result;
        }

        private void LoadDGV(List<Document> documentList) {
            dgv_UploadList.Rows.Clear();
            foreach (Document document in documentList) { 
                var dbMajor = _majorDataProvider.GetMajorById(document.MajorId);
                var dbCategory = _categoryDataProvider.GetCategoryById(document.CategoryId);
                var dbUser = _userDataProvider.GetUser(document.ApproverId);

                dgv_UploadList.Rows.Add(document.DocumentId, document.DocumentUrl,dbMajor,dbCategory, document.IsApproved,dbUser);
            }
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

        #region [ Search ]
        private List<Document> SearchByName(string name, List<Document> documentList) { 
            var result = documentList.Where(x => x.DocumentUrl.Contains(name, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }
        #endregion
    }
}

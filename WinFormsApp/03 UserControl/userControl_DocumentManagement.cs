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
    public partial class userControl_DocumentManagement : UserControl
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly User _user;
        private List<Document> _documentList;
        private List<Major> _majorList;
        private List<Category> _categoryList;
        #endregion

        #region [ Ctor ]
        public userControl_DocumentManagement(  IUserDataProviders userDataProvider,
                                                IMajorDataProvider majorDataProvider,
                                                IDocumentDataProvider documentDataProvider,
                                                ICategoryDataProvider categoryDataProvider,
                                                User user) {
            this._userDataProvider = userDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._user = user;
            this._documentList = this._documentDataProvider.GetAllDocuments();
            this._majorList = this._majorDataProvider.GetAllMajors();
            this._categoryList = this._categoryDataProvider.GetAllCategorys();
            InitializeComponent();
            this.LoadDataIntoCBs(this._majorList,this._categoryList);
            this.LoadDataIntoDGV(this._documentList);
        }
        #endregion

        #region [ btn Events ]
        private void btn_RefreshData_Click(object sender, EventArgs e) {
            this._documentList = this._documentDataProvider.GetAllDocuments();
            this._majorList = this._majorDataProvider.GetAllMajors();
            this._categoryList = this._categoryDataProvider.GetAllCategorys();
            this.LoadDataIntoCBs(this._majorList, this._categoryList);
            this.LoadDataIntoDGV(this._documentList);
        }

        private void btn_Remove_Click(object sender, EventArgs e) {
            var id = Int32.Parse(dgv_DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            var dbDocument = this._documentDataProvider.GetDocumentById(id);
            this._documentDataProvider.RemoveDocument(dbDocument);
            MessageBox.Show("Removed the document.");
        }

        private void btn_Preview_Click(object sender, EventArgs e) {

        }

        private void btn_Search_Click(object sender, EventArgs e) {

        }
        #endregion

        #region [ tb Events ]
        private void tb_Name_TextChanged(object sender, EventArgs e) {

        }

        private void tb_Uploader_TextChanged(object sender, EventArgs e) {

        }

        private void tb_Approver_TextChanged(object sender, EventArgs e) {

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

        #region [ Load Data ]
        private void LoadDataIntoCBs(List<Major> majorList, List<Category> categoryList) {
            this.LoadMajorsIntoCB(majorList);
            this.LoadCategoryIntoCB(categoryList);
            this.LoadIsApprovedIntoCB();
        }

        private void LoadMajorsIntoCB(List<Major> majorList) {
            cb_Major.Items.Clear();
            foreach (var major in majorList) {
                cb_Major.Items.Add(major);
            }
        }

        private void LoadCategoryIntoCB(List<Category> categoryList) {
            cb_Category.Items.Clear();
            foreach (var category in categoryList) {
                cb_Category.Items.Add(category);
            }
        }

        private void LoadIsApprovedIntoCB() {
            cb_IsApproved.Items.Clear();
            cb_IsApproved.Items.Add(true);
            cb_IsApproved.Items.Add(false);
        }

        private void LoadDataIntoDGV(List<Document> documentList) {
            dgv_DocumentList.Rows.Clear();
            foreach (var document in documentList) {
                var dbMajor = this._majorDataProvider.GetMajorById(document.MajorId);
                var dbCategory = this._categoryDataProvider.GetCategoryById(document.CategoryId);
                var dbUploader = this._userDataProvider.GetUser(document.UploaderId);
                var dbApprover = this._userDataProvider.GetUser(document.ApproverId);
                dgv_DocumentList.Rows.Add(document.DocumentId, document.DocumentUrl, dbMajor, dbCategory, dbUploader, dbApprover,document.IsApproved);
            }
        }
        #endregion

        #region [ DGV ]
        private void dgv_DocumentList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_DocumentList.SelectedRows.Count == 1) {
                btn_Preview.Enabled = true;
                btn_Remove.Enabled = true;
            } else {
                btn_Preview.Enabled = false;
                btn_Remove.Enabled = false;
            }
        }
        #endregion

        #region [ Open file ]
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private List<User> _uploaderList;
        private List<User> _approverList;
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
            var _dialogResult = MessageBox.Show("Remove this document?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var id = Int32.Parse(dgv_DocumentList.SelectedRows[0].Cells[0].Value.ToString());
                var dbDocument = this._documentDataProvider.GetDocumentById(id);
                this._documentDataProvider.RemoveDocument(dbDocument);
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
                MessageBox.Show("Removed the document.");
            }
        }
        private void btn_Preview_Click(object sender, EventArgs e) {
            var documentId = Int32.Parse(dgv_DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            this.OpenFile(documentId);
        }

        private void btn_Search_Click(object sender, EventArgs e) {
            
        }
        #endregion

        #region [ tb Events ]
        private void tb_Name_TextChanged(object sender, EventArgs e) {
            if (tb_Name.Text.Length > 0) {
                this._documentList = this._documentList.Where(x => x.DocumentUrl.Contains(tb_Name.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
        }
        private void tb_Uploader_TextChanged(object sender, EventArgs e) {
            if (tb_Uploader.Text.Length > 0) {
                this._uploaderList = this._userDataProvider.GetAllUsers().Where(x => x.UserEmail.Contains(tb_Uploader.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();
                this._documentList.Clear();
                foreach(var user in this._uploaderList) {
                    this._documentList.AddRange(this._documentDataProvider.GetDocumentsByUploaderId(user.UserId));
                }
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
        }

        private void tb_Approver_TextChanged(object sender, EventArgs e) {
            if (tb_Approver.Text.Length > 0) {
                this._approverList = this._userDataProvider.GetAllUsers().Where(x => x.UserEmail.Contains(tb_Approver.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();
                this._documentList.Clear();
                foreach (var user in this._approverList) {
                    this._documentList.AddRange(this._documentDataProvider.GetDocumentsByApproverId(user.UserId));
                }
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
        }
        #endregion

        #region [ cb Events ]
        private void cb_Major_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Major.SelectedIndex > -1) {
                var dbMajor = cb_Major.SelectedItem as Major;
                this._documentList = this._documentList.Where(x => x.MajorId == dbMajor.MajorId).ToList();
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
        }
        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Category.SelectedIndex > -1) {
                var dbCategory = cb_Category.SelectedItem as Category;
                this._documentList = this._documentList.Where(x => x.CategoryId == dbCategory.CategoryId).ToList();
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
        }
        private void cb_IsApproved_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_IsApproved.SelectedIndex > -1) {
                var isApproved = cb_IsApproved.SelectedItem;
                this._documentList = this._documentList.Where(x => x.IsApproved.ToString() == isApproved.ToString()).ToList();
                this.LoadDataIntoDGV(this._documentList);
            } else {
                this._documentList = this._documentDataProvider.GetAllDocuments();
                this.LoadDataIntoDGV(this._documentList);
            }
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
        private void OpenFile(int id) {
            var dbDocument = _documentDataProvider.GetDocumentById(id);
            var newFileName = dbDocument.DocumentUrl.Replace(dbDocument.DocumentType, DateTime.Now.ToString("ddMMyyyyhhmmss")) + dbDocument.DocumentType;
            File.WriteAllBytes(newFileName, dbDocument.DocumentData);
            //System.Diagnostics.Process.Start(newFileName);
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(newFileName) {
                UseShellExecute = true
            };
            p.Start();
        }
        #endregion
    }
}

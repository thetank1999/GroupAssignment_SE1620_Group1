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
    public partial class userControl_ApproveDocument : UserControl
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
        public userControl_ApproveDocument( IUserDataProviders userDataProvider,
                                            IMajorDataProvider majorDataProvider,
                                            IDocumentDataProvider documentDataProvider,
                                            ICategoryDataProvider categoryDataProvider,
                                            User user) {
            this._userDataProvider = userDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._user = user;
            this._documentList = this._documentDataProvider.GetAllNotApprovedDocument();
            this._majorList = this._majorDataProvider.GetAllMajors();
            this._categoryList = this._categoryDataProvider.GetAllCategorys();
            InitializeComponent();

            this.LoadDataIntoDGV(this._documentList);
        }
        #endregion

        #region [ DGV ]
        private void dgv_ApproveList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_ApproveList.SelectedRows.Count == 1) {
                btn_Approve.Enabled = true;
                btn_Preview.Enabled = true;
            } else {
                btn_Approve.Enabled = false;
                btn_Preview.Enabled = false;
            }
        }
        #endregion

        #region [ btn Events ]
        private void btn_Preview_Click(object sender, EventArgs e) {
            var documentId = Int32.Parse(dgv_ApproveList.SelectedRows[0].Cells[0].Value.ToString());
            this.OpenFile(documentId);
        }

        private void btn_Approve_Click(object sender, EventArgs e) {
            var _dialogResult = MessageBox.Show("Approve this document?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var id = Int32.Parse(dgv_ApproveList.SelectedRows[0].Cells[0].Value.ToString());
                var dbEntity = this._documentDataProvider.GetDocumentById(id);
                dbEntity.IsApproved = true;
                dbEntity.ApproverId = this._user.UserId;
                _documentDataProvider.UpdateDocument(dbEntity);
                MessageBox.Show("Approved Document");
            }
        }

        private void btn_RefreshData_Click(object sender, EventArgs e) {
            this._documentList = this._documentDataProvider.GetAllNotApprovedDocument();
            this.LoadDataIntoDGV(this._documentList);
        }
        #endregion

        #region [ Load Data ]
        public void LoadDataIntoDGV(List<Document> documentList) {
            dgv_ApproveList.Rows.Clear();
            foreach (var document in documentList) {
                var dbMajor = _majorDataProvider.GetMajorById(document.MajorId);
                var dbCategory = _categoryDataProvider.GetCategoryById(document.CategoryId);
                var dbUploader = _userDataProvider.GetUser(document.ApproverId);
                dgv_ApproveList.Rows.Add(document.DocumentId,document.DocumentUrl, dbMajor, dbCategory, document.IsApproved.ToString(), dbUploader);
            }
        }
        #endregion

        #region [ Open File ]
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

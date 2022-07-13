using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp
{
    public partial class userControl_DocumentList : UserControl
    {
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IFavouriteDataProvider _favouriteDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly User _user;
        private List<Document> _documentList;
        public userControl_DocumentList(IUserDataProviders userDataProvider,
                                        IMajorDataProvider majorDataProvider,
                                        IFavouriteDataProvider favouriteDataProvider,
                                        IDocumentDataProvider documentDataProvider,
                                        ICategoryDataProvider categoryDataProvider,
                                        IDataHelper datahelper,
                                        User user) {
            this._userDataProvider = userDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._favouriteDataProvider = favouriteDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._user = user;
            this.InitializeComponent();
            this._documentList = this.InitDocumentList();
            this.LoadDataIntoDgv(this._documentList);
            this.LoadDataIntoComboBoxes();
            
        }
        #region [ Dgv Events ]
        private void dgv_DocumentList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_DocumentList.SelectedRows.Count == 1) {
                btn_AddToFavourite.Enabled = true;
                btn_Preview.Enabled = true;
            } else {
                btn_AddToFavourite.Enabled = false;
                btn_Preview.Enabled = false;
            }
        }
        #endregion
        #region [ TextBox Search ]
        private void tb_SearchByName_TextChanged(object sender, EventArgs e) {
            this.LoadDataIntoDgv(this.SearchDocumentByName(_documentList,tb_SearchByName.Text));
        }
        #endregion
        #region [ ComboBox Selected Index Changed ]
        private void cb_CategorySearch_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_CategorySearch.SelectedIndex <= 0) {
                var dbCategory = cb_CategorySearch.SelectedItem as Category;
                var tempDocumentList = this._documentList.Where(x => x.CategoryId == dbCategory.CategoryId).ToList();
                this.LoadDataIntoDgv(tempDocumentList);
            }
        }
      
        private void cb_MajorSearch_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_MajorSearch.SelectedIndex <= 0) {
                var dbMajor = cb_MajorSearch.SelectedItem as Major;
                var tempDocumentList = this._documentList.Where(x => x.MajorId == dbMajor.MajorId).ToList();
                this.LoadDataIntoDgv(tempDocumentList);
            }
        }
        #endregion

        #region [ Button Events ]
        private void btn_Preview_Click(object sender, EventArgs e) {
            var documentId = Int32.Parse(dgv_DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            this.OpenFile(documentId);
        }

        private void btn_AddToFavourite_Click(object sender, EventArgs e) {
            var documentId = Int32.Parse(dgv_DocumentList.SelectedRows[0].Cells[0].Value.ToString());
            var dbFavourite = _favouriteDataProvider.GetFavouriteByUserIdAndDocumentId(this._user.UserId, documentId);
            if (dbFavourite != null) {
                MessageBox.Show("This Document is already in your favourite list");
            } else {
                var dbEntity = new Favourite();
                dbEntity.UserId = this._user.UserId;
                dbEntity.DocumentId = documentId;
                _favouriteDataProvider.AddFavourite(dbEntity);
                MessageBox.Show("Added as a favourite.");
            }
        }

        private void btn_RefreshData_Click(object sender, EventArgs e) {
            this._documentList = this.InitDocumentList();
            this.LoadDataIntoDgv(this._documentList);
        }
        #endregion

        #region [Init]
        private List<Document> InitDocumentList() {
            var result = this._documentDataProvider.GetAllApprovedDocument();
            return result;
        }

        private void LoadDataIntoDgv(List<Document> documentList) {
            dgv_DocumentList.Rows.Clear();
            foreach (var document in documentList) {
                var dbMajor = this._majorDataProvider.GetMajorById(document.MajorId);
                var dbCategory = this._categoryDataProvider.GetCategoryById(document.CategoryId);
                var dbUser = this._userDataProvider.GetUser(document.UploaderId);
                dgv_DocumentList.Rows.Add(  document.DocumentId, 
                                            document.DocumentUrl, // document name
                                            dbMajor, 
                                            dbCategory, 
                                            dbUser);
            }
        }

        private List<Document> SearchDocumentByName(List<Document> documentList, string searchString) {
            var result = new List<Document>();
            result = _documentList.Where(x => x.DocumentUrl.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return result;
        }

        private void LoadDataIntoComboBoxes() {
            this.LoadMajor();
            this.LoadCategory();
        }
        private void LoadMajor() {
             cb_MajorSearch.Items.Clear();
            var majorList = _majorDataProvider.GetAllMajors();
            foreach (var major in majorList) {
                cb_MajorSearch.Items.Add(major);
            }
        }

        private void LoadCategory() {
             cb_CategorySearch.Items.Clear();
            var categoryList = _categoryDataProvider.GetAllCategorys();
            foreach (var category in categoryList) {
                cb_CategorySearch.Items.Add(category);
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

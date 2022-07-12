using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmUploadDocument : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        private readonly User _user;
        #endregion
        public frmUploadDocument(IUserDataProviders userDataProvider,
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
            this.InitializeComponent();

            this.LoadDataIntoComboBoxes();
        }

        #region [btn Events]
        private void btn_Save_Click(object sender, EventArgs e) {
            this.SaveFile(tb_FilePath.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_Browse_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            tb_FilePath.Text = dlg.FileName;
        }
        #endregion

        #region [ Add Data into ComboBoxes ]
        private void LoadDataIntoComboBoxes() {
            this.LoadMajor();
            this.LoadCategory();
        }
        private void LoadMajor() {
            cb_Major.Items.Clear();
            var majorList = _majorDataProvider.GetAllMajors();
            foreach (var major in majorList) {
                cb_Major.Items.Add(major);
            }
        }

        private void LoadCategory() {
            cb_Category.Items.Clear();
            var categoryList = _categoryDataProvider.GetAllCategorys();
            foreach (var category in categoryList) {
                cb_Category.Items.Add(category);
            }
        }
        #endregion

        #region [ Save file ]
        private void SaveFile(string filePath) {
            if (this.IsNotValidInput()) {
                MessageBox.Show("Invavlid Input");
            } else if(!File.Exists(filePath)) {
                MessageBox.Show("Invavlid File Path");
            }
            else {
                using (Stream stream = File.OpenRead(filePath)) {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    var fi = new FileInfo(filePath);
                    string documentType = fi.Extension;
                    string documentName = fi.Name;

                    // save into dbms
                    var documentEntity = new Document();
                    var majorEntity = cb_Major.SelectedItem as Major;
                    documentEntity.MajorId = majorEntity.MajorId;
                    var categoryEntity = cb_Category.SelectedItem as Category;
                    documentEntity.CategoryId = categoryEntity.CategoryId;
                    documentEntity.UploaderId = this._user.UserId;
                    documentEntity.ApproverId = this._user.UserId;
                    documentEntity.DocumentType = documentType;
                    documentEntity.DocumentData = buffer;
                    documentEntity.DocumentUrl = documentName;
                    documentEntity.IsApproved = false;
                    _documentDataProvider.AddDocument(documentEntity);
                    this.Close();
                    MessageBox.Show("Saved");
                }
            }
        }
        private bool IsNotValidInput() {
            if (    tb_FilePath.TextLength == 0
                ||  cb_Category.SelectedIndex < 0
                ||  cb_Major.SelectedIndex < 0) {
                return true;
            } else {
                return false;
            }
        }
        #endregion
    }
}

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

            InitializeComponent();
        }

        #region [btn Events]
        private void btn_Save_Click(object sender, EventArgs e) {

        }

        private void btn_Cancel_Click(object sender, EventArgs e) {

        }

        private void btn_Browse_Click(object sender, EventArgs e) {

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
    }
}

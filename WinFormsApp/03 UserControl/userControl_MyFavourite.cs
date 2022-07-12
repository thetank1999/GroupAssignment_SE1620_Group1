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
    public partial class userControl_MyFavourite : UserControl
    {
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IFavouriteDataProvider _favouriteDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        private readonly User _user;
        public userControl_MyFavourite( IUserDataProviders userDataProvider,
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
            this._datahelper = datahelper;
            this._user = user;
            this.InitializeComponent();
            this.LoadDataIntoDGV(this.GetFavouriteDocuments(this._user));
        }

        private void tb_Search_TextChanged(object sender, EventArgs e) {
            var searchString = tb_Search.Text;
            var result = this.GetFavouriteDocuments(this._user).Where(x => x.DocumentUrl.Contains(searchString)).ToList();
            this.LoadDataIntoDGV(result);
        }

        private void btn_PreviewDocument_Click(object sender, EventArgs e) {

        }

        private void btn_Refresh_Click(object sender, EventArgs e) {
            this.LoadDataIntoDGV(this.GetFavouriteDocuments(this._user));
        }

        private void btn_RemoveFavourite_Click(object sender, EventArgs e) {
            var dbEntity = this._favouriteDataProvider.GetFavouriteByUserIdAndDocumentId(this._user.UserId, Int32.Parse(dgv_FavouriteList.SelectedRows[0].Cells[0].Value.ToString()));
            this._favouriteDataProvider.RemoveFavourite(dbEntity);
        }

        private void dgv_FavouriteList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_FavouriteList.SelectedRows.Count == 1) {
                btn_RemoveFavourite.Enabled = true;
                btn_PreviewDocument.Enabled = true;
            } else {
                btn_RemoveFavourite.Enabled = false;
                btn_PreviewDocument.Enabled = false;
            }
        }
        private void btn_Download_Click(object sender, EventArgs e) {

        }
        private List<Document> GetFavouriteDocuments(User user) {
            var favouriteList = new List<Favourite>();
            favouriteList = this._favouriteDataProvider.GetFavouritesByUserId(user.UserId);
            var result = new List<Document>();
            foreach (var favourite in favouriteList) {
                var dbEntity = _documentDataProvider.GetDocumentById(favourite.DocumentId);
                result.Add(dbEntity);
            }
            return result;
        }


        public void LoadDataIntoDGV(List<Document> documentList) {
            foreach (var document in documentList) {
                var dbMajor = _majorDataProvider.GetMajorById(document.MajorId);
                var dbCategory = _categoryDataProvider.GetCategoryById(document.CategoryId);
                var dbUser = _userDataProvider.GetUser(document.UploaderId);
                dgv_FavouriteList.Rows.Add(document.DocumentId, document.DocumentUrl, dbMajor, dbCategory, dbUser);
            }
        }


    }
}

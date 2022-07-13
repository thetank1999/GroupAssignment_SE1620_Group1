using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp
{
    public partial class frmChangeInformationUser : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IDataHelper _dataHelper;
        private User _user;
        private List<Major> _majorList;
        #endregion

        #region [ Ctor ]
        public frmChangeInformationUser(IUserDataProviders userDataProvider,
                                        IMajorDataProvider majorDataProvider,
                                        IDataHelper dataHelper,
                                        User user) {
            this._userDataProvider = userDataProvider;

            this._majorDataProvider = majorDataProvider;
            this._dataHelper = dataHelper;
            this._user = user;
            this._majorList = this._majorDataProvider.GetAllMajors();
            InitializeComponent();
            this.LoadDataIntoCBsAndTBs(this._majorList, this._user);
        }
        #endregion

        #region [ btn Events ]
        private void btn_Save_Click(object sender, EventArgs e) {
            if (this.IsNotValidInput()) {
                MessageBox.Show("Invalid Input");
            } else if (this.IsNotValidEmail()) {
                MessageBox.Show("Invalid Email Address");
            } else {
                var dbMajor = cb_Major.SelectedItem as Major;
                this._user.UserMajor = dbMajor.MajorId;
                this._user.UserEmail = tb_Email.Text;
                this._user.UserFullname = tb_Fullname.Text;
                _userDataProvider.UpdateUser(this._user);
                this.Close();
                MessageBox.Show("Updated.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region [Load Data]
        private void LoadDataIntoCBsAndTBs(List<Major> majorList, User user) {
            this.LoadMajorIntoCB(majorList, user);
            this.LoadDataIntoTBs(user);
        }
        private void LoadDataIntoTBs(User user) {
            tb_Email.Text = user.UserEmail;
            tb_Fullname.Text = user.UserFullname;
        }

        private void LoadMajorIntoCB(List<Major> majorList, User user) {
            cb_Major.Items.Clear();
            foreach (Major major in majorList) {
                cb_Major.Items.Add(major);
                if (major.MajorId == user.UserMajor) {
                    cb_Major.SelectedItem = major;
                }
            }
        }
        #endregion

        #region [ Validation ]
        private bool IsNotValidInput() {
            if (tb_Email.Text.Length == 0
                || tb_Fullname.Text.Length == 0
                || cb_Major.SelectedIndex <= -1) {
                return true;
            } else {
                return false;
            }
        }
        private bool IsNotValidEmail() {
            var emailString = tb_Email.Text.ToString();
            var dbUser = this._userDataProvider.GetUserByEmail(emailString);
            if (_dataHelper.EmailValidation(emailString) && dbUser == null) {
                return false;
            } else if (_dataHelper.EmailValidation(emailString) && dbUser.UserId == this._user.UserId) {
                return false;
            } else {
                return true;
            }
        }
        #endregion
    }
}

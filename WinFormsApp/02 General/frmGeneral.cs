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
    public partial class frmGeneral : Form
    {
        #region [ Fields ]
        private readonly IUserDataProviders _userDataProvider;
        private readonly IRoleDataProvider _roleDataProvider;
        private readonly IMajorDataProvider _majorDataProvider;
        private readonly IFavouriteDataProvider _favouriteDataProvider;
        private readonly IDocumentDataProvider _documentDataProvider;
        private readonly ICategoryDataProvider _categoryDataProvider;
        private readonly IDataHelper _datahelper;
        private readonly User _user;
        private userControl_PersonalInformation _ucPersonalInfo;
        private userControl_MyFavourite _ucMyFavourite;
        private userControl_DocumentList _ucDocumentList;
        private userControl_UploadDocument _ucUploadDocument;
        private userControl_ApproveDocument _ucApproveDocument;
        private userControl_DocumentManagement _ucDocumentManagement;
        private userControl_UserManagementAdmin _ucUserManagement;
        #endregion

        #region [ Ctor ]
        public frmGeneral(IUserDataProviders userDataProvider,
                        IRoleDataProvider roleDataProvider,
                        IMajorDataProvider majorDataProvider,
                        IFavouriteDataProvider favouriteDataProvider,
                        IDocumentDataProvider documentDataProvider,
                        ICategoryDataProvider categoryDataProvider,
                        IDataHelper datahelper,
                        User user) {
            this._userDataProvider = userDataProvider;
            this._roleDataProvider = roleDataProvider;
            this._majorDataProvider = majorDataProvider;
            this._favouriteDataProvider = favouriteDataProvider;
            this._documentDataProvider = documentDataProvider;
            this._categoryDataProvider = categoryDataProvider;
            this._datahelper = datahelper;
            this._user = user;

            InitializeComponent();
            this.SegregationOfDuty(this._user);
            this.InitializeUserControl(this._user);
        }
        #endregion

        #region [ Normal User ]
        private void btn_PersonalInformation_Click(object sender, EventArgs e) {
            this._ucPersonalInfo.BringToFront();
        }

        private void btn_MyFavourite_Click(object sender, EventArgs e) {
            this._ucMyFavourite.BringToFront();
        }

        private void button_DocumentList_Click(object sender, EventArgs e) {
            this._ucDocumentList.BringToFront();
        }
        #endregion

        #region [ Lecturer ]
        private void btn_UploadDocument_Click(object sender, EventArgs e) {
            this._ucUploadDocument.BringToFront();
        }
        #endregion

        #region [ Head of Lecturer ]
        private void btn_ApproveDocument_Click(object sender, EventArgs e) {
            this._ucApproveDocument.BringToFront();
        }
        #endregion

        #region [ Administrator ]
        private void btn_DocumentManagement_Click(object sender, EventArgs e) {
            this._ucDocumentManagement.BringToFront();
        }

        private void btn_UserManagement_Click(object sender, EventArgs e) {
            this._ucUserManagement.BringToFront();
        }
        #endregion

        #region [ Segregation of Duty ]
        private void SegregationOfDuty(User user) {
            label_WelcomeBack.Text = $"Welcome Back {user.UserFullname}";
            switch (user.UserRoleId) {
                case 1: // is an admin 
                    {
                        btn_DocumentManagement.Visible = true;
                        btn_UserManagement.Visible = true;
                        break;
                    }
                case 3: {// is a lecturer

                        btn_UploadDocument.Visible = true;
                        break;
                    }
                case 4: {// is a head of lecturer

                        btn_ApproveDocument.Visible = true;
                        break;
                    }
                    default: {
                        break;
                    }
            }
        }

        private void InitializeUserControl(User user) {
            // personal infor
            this._ucPersonalInfo = new userControl_PersonalInformation(_userDataProvider, 
                                                                        _roleDataProvider, 
                                                                        _majorDataProvider,
                                                                        _datahelper,
                                                                        _user);
            panel_General.Controls.Add(this._ucPersonalInfo);
            this._ucPersonalInfo.Dock = DockStyle.Fill;

            // my favourite
            this._ucMyFavourite = new userControl_MyFavourite(  _userDataProvider, 
                                                                _majorDataProvider, 
                                                                _favouriteDataProvider, 
                                                                _documentDataProvider, 
                                                                _categoryDataProvider, 
                                                                _datahelper, 
                                                                _user);
            panel_General.Controls.Add(this._ucMyFavourite);
            this._ucMyFavourite.Dock = DockStyle.Fill;  
            
            // document list
            this._ucDocumentList = new userControl_DocumentList(_userDataProvider, 
                                                                _majorDataProvider, 
                                                                _favouriteDataProvider, 
                                                                _documentDataProvider, 
                                                                _categoryDataProvider, 
                                                                _datahelper, 
                                                                _user);
            panel_General.Controls.Add(this._ucDocumentList);
            this._ucDocumentList.Dock = DockStyle.Fill;

            if (user.UserRoleId == 3) {
                // upload document
                this._ucUploadDocument = new userControl_UploadDocument(   _userDataProvider,
                                                                           _majorDataProvider,
                                                                           _documentDataProvider,
                                                                           _categoryDataProvider,
                                                                           _datahelper,
                                                                           _user);
                panel_General.Controls.Add(this._ucUploadDocument);
                this._ucUploadDocument.Dock = DockStyle.Fill;
            } else if (user.UserRoleId == 4) {
                // approve document
                this._ucApproveDocument = new userControl_ApproveDocument(  _userDataProvider,
                                                                            _majorDataProvider,
                                                                            _documentDataProvider,
                                                                            _categoryDataProvider,
                                                                            _user);
                panel_General.Controls.Add(this._ucApproveDocument);
                this._ucApproveDocument.Dock = DockStyle.Fill;
            } else if (user.UserRoleId == 1) {
                // document management
                this._ucDocumentManagement = new userControl_DocumentManagement(_userDataProvider,
                                                                                _majorDataProvider,
                                                                                _documentDataProvider,
                                                                                _categoryDataProvider,
                                                                                _user);
                panel_General.Controls.Add(this._ucDocumentManagement);
                this._ucDocumentManagement.Dock = DockStyle.Fill;
                // user management
                this._ucUserManagement = new userControl_UserManagementAdmin(_userDataProvider,
                                                                                _roleDataProvider,
                                                                                _majorDataProvider,
                                                                                _datahelper,
                                                                                _user);
                panel_General.Controls.Add(this._ucUserManagement);
                this._ucUserManagement.Dock = DockStyle.Fill;
            }
        }
        #endregion
    }
}

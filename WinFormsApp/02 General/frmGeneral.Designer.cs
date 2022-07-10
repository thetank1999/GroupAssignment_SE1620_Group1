namespace WinApp
{
    partial class frmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_PersonalInformation = new System.Windows.Forms.Button();
            this.label_WelcomeBack = new System.Windows.Forms.Label();
            this.btn_MyFavourite = new System.Windows.Forms.Button();
            this.button_DocumentList = new System.Windows.Forms.Button();
            this.btn_UploadDocument = new System.Windows.Forms.Button();
            this.btn_ApproveDocument = new System.Windows.Forms.Button();
            this.btn_DocumentManagement = new System.Windows.Forms.Button();
            this.btn_UserManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PersonalInformation
            // 
            this.btn_PersonalInformation.Location = new System.Drawing.Point(12, 93);
            this.btn_PersonalInformation.Name = "btn_PersonalInformation";
            this.btn_PersonalInformation.Size = new System.Drawing.Size(183, 98);
            this.btn_PersonalInformation.TabIndex = 0;
            this.btn_PersonalInformation.Text = "Personal Information";
            this.btn_PersonalInformation.UseVisualStyleBackColor = true;
            this.btn_PersonalInformation.Visible = false;
            this.btn_PersonalInformation.Click += new System.EventHandler(this.btn_PersonalInformation_Click);
            // 
            // label_WelcomeBack
            // 
            this.label_WelcomeBack.AutoSize = true;
            this.label_WelcomeBack.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_WelcomeBack.Location = new System.Drawing.Point(81, 18);
            this.label_WelcomeBack.Name = "label_WelcomeBack";
            this.label_WelcomeBack.Size = new System.Drawing.Size(230, 41);
            this.label_WelcomeBack.TabIndex = 3;
            this.label_WelcomeBack.Text = "Welcome Back:";
            // 
            // btn_MyFavourite
            // 
            this.btn_MyFavourite.Location = new System.Drawing.Point(12, 206);
            this.btn_MyFavourite.Name = "btn_MyFavourite";
            this.btn_MyFavourite.Size = new System.Drawing.Size(183, 98);
            this.btn_MyFavourite.TabIndex = 1;
            this.btn_MyFavourite.Text = "My Favourite";
            this.btn_MyFavourite.UseVisualStyleBackColor = true;
            this.btn_MyFavourite.Visible = false;
            this.btn_MyFavourite.Click += new System.EventHandler(this.btn_MyFavourite_Click);
            // 
            // button_DocumentList
            // 
            this.button_DocumentList.Location = new System.Drawing.Point(12, 323);
            this.button_DocumentList.Name = "button_DocumentList";
            this.button_DocumentList.Size = new System.Drawing.Size(183, 98);
            this.button_DocumentList.TabIndex = 2;
            this.button_DocumentList.Text = "Document List";
            this.button_DocumentList.UseVisualStyleBackColor = true;
            this.button_DocumentList.Visible = false;
            this.button_DocumentList.Click += new System.EventHandler(this.button_DocumentList_Click);
            // 
            // btn_UploadDocument
            // 
            this.btn_UploadDocument.Location = new System.Drawing.Point(12, 445);
            this.btn_UploadDocument.Name = "btn_UploadDocument";
            this.btn_UploadDocument.Size = new System.Drawing.Size(183, 98);
            this.btn_UploadDocument.TabIndex = 3;
            this.btn_UploadDocument.Text = "Upload Document";
            this.btn_UploadDocument.UseVisualStyleBackColor = true;
            this.btn_UploadDocument.Visible = false;
            this.btn_UploadDocument.Click += new System.EventHandler(this.btn_UploadDocument_Click);
            // 
            // btn_ApproveDocument
            // 
            this.btn_ApproveDocument.Location = new System.Drawing.Point(12, 569);
            this.btn_ApproveDocument.Name = "btn_ApproveDocument";
            this.btn_ApproveDocument.Size = new System.Drawing.Size(183, 98);
            this.btn_ApproveDocument.TabIndex = 4;
            this.btn_ApproveDocument.Text = "Approve Document";
            this.btn_ApproveDocument.UseVisualStyleBackColor = true;
            this.btn_ApproveDocument.Visible = false;
            this.btn_ApproveDocument.Click += new System.EventHandler(this.btn_ApproveDocument_Click);
            // 
            // btn_DocumentManagement
            // 
            this.btn_DocumentManagement.Location = new System.Drawing.Point(12, 685);
            this.btn_DocumentManagement.Name = "btn_DocumentManagement";
            this.btn_DocumentManagement.Size = new System.Drawing.Size(183, 98);
            this.btn_DocumentManagement.TabIndex = 5;
            this.btn_DocumentManagement.Text = "Document Management";
            this.btn_DocumentManagement.UseVisualStyleBackColor = true;
            this.btn_DocumentManagement.Visible = false;
            this.btn_DocumentManagement.Click += new System.EventHandler(this.btn_DocumentManagement_Click);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.Location = new System.Drawing.Point(12, 805);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Size = new System.Drawing.Size(183, 98);
            this.btn_UserManagement.TabIndex = 6;
            this.btn_UserManagement.Text = "User Management";
            this.btn_UserManagement.UseVisualStyleBackColor = true;
            this.btn_UserManagement.Visible = false;
            this.btn_UserManagement.Click += new System.EventHandler(this.btn_UserManagement_Click);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 1180);
            this.Controls.Add(this.btn_UserManagement);
            this.Controls.Add(this.btn_DocumentManagement);
            this.Controls.Add(this.btn_ApproveDocument);
            this.Controls.Add(this.btn_UploadDocument);
            this.Controls.Add(this.button_DocumentList);
            this.Controls.Add(this.btn_MyFavourite);
            this.Controls.Add(this.label_WelcomeBack);
            this.Controls.Add(this.btn_PersonalInformation);
            this.Name = "frmGeneral";
            this.Text = "frmGeneral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PersonalInformation;
        private System.Windows.Forms.Label label_WelcomeBack;
        private System.Windows.Forms.Button btn_MyFavourite;
        private System.Windows.Forms.Button button_DocumentList;
        private System.Windows.Forms.Button btn_UploadDocument;
        private System.Windows.Forms.Button btn_ApproveDocument;
        private System.Windows.Forms.Button btn_DocumentManagement;
        private System.Windows.Forms.Button btn_UserManagement;
    }
}
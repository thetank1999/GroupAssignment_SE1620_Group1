namespace WinApp
{
    partial class userControl_DocumentList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_DocumentList = new System.Windows.Forms.DataGridView();
            this.DocuementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_SearchByName = new System.Windows.Forms.TextBox();
            this.cb_MajorSearch = new System.Windows.Forms.ComboBox();
            this.cb_CategorySearch = new System.Windows.Forms.ComboBox();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_DownloadDocument = new System.Windows.Forms.Button();
            this.btn_AddToFavourite = new System.Windows.Forms.Button();
            this.label_SearchByName = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocumentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DocumentList
            // 
            this.dgv_DocumentList.AllowUserToAddRows = false;
            this.dgv_DocumentList.AllowUserToDeleteRows = false;
            this.dgv_DocumentList.AllowUserToOrderColumns = true;
            this.dgv_DocumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocumentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocuementId,
            this.DocumentName,
            this.Major,
            this.Category,
            this.UploadedBy});
            this.dgv_DocumentList.Location = new System.Drawing.Point(32, 157);
            this.dgv_DocumentList.MultiSelect = false;
            this.dgv_DocumentList.Name = "dgv_DocumentList";
            this.dgv_DocumentList.ReadOnly = true;
            this.dgv_DocumentList.RowHeadersWidth = 62;
            this.dgv_DocumentList.RowTemplate.Height = 33;
            this.dgv_DocumentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DocumentList.Size = new System.Drawing.Size(1115, 578);
            this.dgv_DocumentList.TabIndex = 1;
            this.dgv_DocumentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DocumentList_CellContentClick);
            // 
            // DocuementId
            // 
            this.DocuementId.HeaderText = "Docuement Id";
            this.DocuementId.MinimumWidth = 8;
            this.DocuementId.Name = "DocuementId";
            this.DocuementId.ReadOnly = true;
            this.DocuementId.Visible = false;
            this.DocuementId.Width = 150;
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "Document Name";
            this.DocumentName.MinimumWidth = 8;
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            this.DocumentName.Width = 250;
            // 
            // Major
            // 
            this.Major.HeaderText = "Major";
            this.Major.MinimumWidth = 8;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Width = 250;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 250;
            // 
            // UploadedBy
            // 
            this.UploadedBy.HeaderText = "Uploaded By";
            this.UploadedBy.MinimumWidth = 8;
            this.UploadedBy.Name = "UploadedBy";
            this.UploadedBy.ReadOnly = true;
            this.UploadedBy.Width = 300;
            // 
            // tb_SearchByName
            // 
            this.tb_SearchByName.Location = new System.Drawing.Point(94, 113);
            this.tb_SearchByName.Name = "tb_SearchByName";
            this.tb_SearchByName.Size = new System.Drawing.Size(150, 31);
            this.tb_SearchByName.TabIndex = 2;
            this.tb_SearchByName.TextChanged += new System.EventHandler(this.tb_SearchByName_TextChanged);
            // 
            // cb_MajorSearch
            // 
            this.cb_MajorSearch.FormattingEnabled = true;
            this.cb_MajorSearch.Location = new System.Drawing.Point(345, 111);
            this.cb_MajorSearch.Name = "cb_MajorSearch";
            this.cb_MajorSearch.Size = new System.Drawing.Size(182, 33);
            this.cb_MajorSearch.TabIndex = 3;
            this.cb_MajorSearch.SelectedIndexChanged += new System.EventHandler(this.cb_MajorSearch_SelectedIndexChanged);
            // 
            // cb_CategorySearch
            // 
            this.cb_CategorySearch.FormattingEnabled = true;
            this.cb_CategorySearch.Location = new System.Drawing.Point(597, 111);
            this.cb_CategorySearch.Name = "cb_CategorySearch";
            this.cb_CategorySearch.Size = new System.Drawing.Size(182, 33);
            this.cb_CategorySearch.TabIndex = 4;
            this.cb_CategorySearch.SelectedIndexChanged += new System.EventHandler(this.cb_CategorySearch_SelectedIndexChanged);
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Location = new System.Drawing.Point(1180, 670);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(112, 65);
            this.btn_RefreshData.TabIndex = 5;
            this.btn_RefreshData.Text = "Refresh Data";
            this.btn_RefreshData.UseVisualStyleBackColor = true;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // btn_Preview
            // 
            this.btn_Preview.Enabled = false;
            this.btn_Preview.Location = new System.Drawing.Point(1180, 177);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(112, 34);
            this.btn_Preview.TabIndex = 6;
            this.btn_Preview.Text = "Preview";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_DownloadDocument
            // 
            this.btn_DownloadDocument.Enabled = false;
            this.btn_DownloadDocument.Location = new System.Drawing.Point(1180, 281);
            this.btn_DownloadDocument.Name = "btn_DownloadDocument";
            this.btn_DownloadDocument.Size = new System.Drawing.Size(112, 64);
            this.btn_DownloadDocument.TabIndex = 7;
            this.btn_DownloadDocument.Text = "Download Document";
            this.btn_DownloadDocument.UseVisualStyleBackColor = true;
            this.btn_DownloadDocument.Click += new System.EventHandler(this.btn_DownloadDocument_Click);
            // 
            // btn_AddToFavourite
            // 
            this.btn_AddToFavourite.Enabled = false;
            this.btn_AddToFavourite.Location = new System.Drawing.Point(1180, 382);
            this.btn_AddToFavourite.Name = "btn_AddToFavourite";
            this.btn_AddToFavourite.Size = new System.Drawing.Size(112, 67);
            this.btn_AddToFavourite.TabIndex = 8;
            this.btn_AddToFavourite.Text = "Add to Favourite";
            this.btn_AddToFavourite.UseVisualStyleBackColor = true;
            this.btn_AddToFavourite.Click += new System.EventHandler(this.btn_AddToFavourite_Click);
            // 
            // label_SearchByName
            // 
            this.label_SearchByName.AutoSize = true;
            this.label_SearchByName.Location = new System.Drawing.Point(94, 85);
            this.label_SearchByName.Name = "label_SearchByName";
            this.label_SearchByName.Size = new System.Drawing.Size(144, 25);
            this.label_SearchByName.TabIndex = 9;
            this.label_SearchByName.Text = "Search By Name:";
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(345, 83);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 10;
            this.label_Major.Text = "Major:";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(597, 83);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(84, 25);
            this.label_Category.TabIndex = 11;
            this.label_Category.Text = "Category";
            // 
            // userControl_DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_SearchByName);
            this.Controls.Add(this.btn_AddToFavourite);
            this.Controls.Add(this.btn_DownloadDocument);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.btn_RefreshData);
            this.Controls.Add(this.cb_CategorySearch);
            this.Controls.Add(this.cb_MajorSearch);
            this.Controls.Add(this.tb_SearchByName);
            this.Controls.Add(this.dgv_DocumentList);
            this.Name = "userControl_DocumentList";
            this.Size = new System.Drawing.Size(1321, 782);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocumentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DocumentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocuementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedBy;
        private System.Windows.Forms.TextBox tb_SearchByName;
        private System.Windows.Forms.ComboBox cb_MajorSearch;
        private System.Windows.Forms.ComboBox cb_CategorySearch;
        private System.Windows.Forms.Button btn_RefreshData;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_DownloadDocument;
        private System.Windows.Forms.Button btn_AddToFavourite;
        private System.Windows.Forms.Label label_SearchByName;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_Category;
    }
}

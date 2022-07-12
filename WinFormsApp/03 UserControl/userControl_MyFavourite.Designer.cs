namespace WinApp
{
    partial class userControl_MyFavourite
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
            this.dgv_FavouriteList = new System.Windows.Forms.DataGridView();
            this.DocuementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PreviewDocument = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.btn_RemoveFavourite = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FavouriteList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_FavouriteList
            // 
            this.dgv_FavouriteList.AllowUserToAddRows = false;
            this.dgv_FavouriteList.AllowUserToDeleteRows = false;
            this.dgv_FavouriteList.AllowUserToOrderColumns = true;
            this.dgv_FavouriteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FavouriteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocuementId,
            this.DocumentName,
            this.Major,
            this.Category,
            this.UploadedBy});
            this.dgv_FavouriteList.Location = new System.Drawing.Point(60, 154);
            this.dgv_FavouriteList.MultiSelect = false;
            this.dgv_FavouriteList.Name = "dgv_FavouriteList";
            this.dgv_FavouriteList.ReadOnly = true;
            this.dgv_FavouriteList.RowHeadersWidth = 62;
            this.dgv_FavouriteList.RowTemplate.Height = 33;
            this.dgv_FavouriteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FavouriteList.Size = new System.Drawing.Size(1181, 578);
            this.dgv_FavouriteList.TabIndex = 0;
            this.dgv_FavouriteList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FavouriteList_CellContentClick);
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
            // btn_PreviewDocument
            // 
            this.btn_PreviewDocument.Enabled = false;
            this.btn_PreviewDocument.Location = new System.Drawing.Point(1283, 154);
            this.btn_PreviewDocument.Name = "btn_PreviewDocument";
            this.btn_PreviewDocument.Size = new System.Drawing.Size(112, 69);
            this.btn_PreviewDocument.TabIndex = 1;
            this.btn_PreviewDocument.Text = "Preview Document";
            this.btn_PreviewDocument.UseVisualStyleBackColor = true;
            this.btn_PreviewDocument.Click += new System.EventHandler(this.btn_PreviewDocument_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1283, 512);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(112, 72);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(245, 117);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(186, 31);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(60, 117);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(156, 25);
            this.label_Search.TabIndex = 4;
            this.label_Search.Text = "Search Document:";
            // 
            // btn_RemoveFavourite
            // 
            this.btn_RemoveFavourite.Enabled = false;
            this.btn_RemoveFavourite.Location = new System.Drawing.Point(1283, 660);
            this.btn_RemoveFavourite.Name = "btn_RemoveFavourite";
            this.btn_RemoveFavourite.Size = new System.Drawing.Size(112, 72);
            this.btn_RemoveFavourite.TabIndex = 5;
            this.btn_RemoveFavourite.Text = "Remove Favourite";
            this.btn_RemoveFavourite.UseVisualStyleBackColor = true;
            this.btn_RemoveFavourite.Click += new System.EventHandler(this.btn_RemoveFavourite_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Enabled = false;
            this.btn_Download.Location = new System.Drawing.Point(1283, 254);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(112, 69);
            this.btn_Download.TabIndex = 6;
            this.btn_Download.Text = "Download Document";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // userControl_MyFavourite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_RemoveFavourite);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_PreviewDocument);
            this.Controls.Add(this.dgv_FavouriteList);
            this.Name = "userControl_MyFavourite";
            this.Size = new System.Drawing.Size(1516, 778);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FavouriteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FavouriteList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocuementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedBy;
        private System.Windows.Forms.Button btn_PreviewDocument;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Button btn_RemoveFavourite;
        private System.Windows.Forms.Button btn_Download;
    }
}

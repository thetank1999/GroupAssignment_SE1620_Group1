namespace WinApp
{
    partial class userControl_UploadDocument
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
            this.dgv_UploadList = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_PersonalUpload = new System.Windows.Forms.Label();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_SearchByName = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            this.label_Major = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.cb_IsApproved = new System.Windows.Forms.ComboBox();
            this.btn_UploadDocument = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UploadList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UploadList
            // 
            this.dgv_UploadList.AllowUserToAddRows = false;
            this.dgv_UploadList.AllowUserToDeleteRows = false;
            this.dgv_UploadList.AllowUserToOrderColumns = true;
            this.dgv_UploadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UploadList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.DocumentName,
            this.Major,
            this.Category,
            this.IsApproved,
            this.ApprovedBy});
            this.dgv_UploadList.Location = new System.Drawing.Point(53, 195);
            this.dgv_UploadList.MultiSelect = false;
            this.dgv_UploadList.Name = "dgv_UploadList";
            this.dgv_UploadList.ReadOnly = true;
            this.dgv_UploadList.RowHeadersWidth = 62;
            this.dgv_UploadList.RowTemplate.Height = 33;
            this.dgv_UploadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UploadList.Size = new System.Drawing.Size(1115, 578);
            this.dgv_UploadList.TabIndex = 8;
            this.dgv_UploadList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_UploadList_CellContentClick);
            // 
            // DocumentId
            // 
            this.DocumentId.HeaderText = "Document Id";
            this.DocumentId.MinimumWidth = 8;
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.ReadOnly = true;
            this.DocumentId.Visible = false;
            this.DocumentId.Width = 150;
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "Document Name";
            this.DocumentName.MinimumWidth = 8;
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            this.DocumentName.Width = 200;
            // 
            // Major
            // 
            this.Major.HeaderText = "Major";
            this.Major.MinimumWidth = 8;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Width = 200;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 200;
            // 
            // IsApproved
            // 
            this.IsApproved.HeaderText = "IsApproved";
            this.IsApproved.MinimumWidth = 8;
            this.IsApproved.Name = "IsApproved";
            this.IsApproved.ReadOnly = true;
            this.IsApproved.Width = 200;
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.HeaderText = "ApprovedBy";
            this.ApprovedBy.MinimumWidth = 8;
            this.ApprovedBy.Name = "ApprovedBy";
            this.ApprovedBy.ReadOnly = true;
            this.ApprovedBy.Width = 250;
            // 
            // label_PersonalUpload
            // 
            this.label_PersonalUpload.AutoSize = true;
            this.label_PersonalUpload.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_PersonalUpload.Location = new System.Drawing.Point(533, 29);
            this.label_PersonalUpload.Name = "label_PersonalUpload";
            this.label_PersonalUpload.Size = new System.Drawing.Size(256, 41);
            this.label_PersonalUpload.TabIndex = 9;
            this.label_PersonalUpload.Text = "Personal Upload:";
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Location = new System.Drawing.Point(1238, 322);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(112, 69);
            this.btn_RefreshData.TabIndex = 10;
            this.btn_RefreshData.Text = "Refresh Data";
            this.btn_RefreshData.UseVisualStyleBackColor = true;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(1238, 690);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 83);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete Submition";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_SearchByName
            // 
            this.tb_SearchByName.Location = new System.Drawing.Point(119, 144);
            this.tb_SearchByName.Name = "tb_SearchByName";
            this.tb_SearchByName.Size = new System.Drawing.Size(150, 31);
            this.tb_SearchByName.TabIndex = 12;
            this.tb_SearchByName.TextChanged += new System.EventHandler(this.tb_SearchByName_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(119, 114);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(144, 25);
            this.label_Search.TabIndex = 13;
            this.label_Search.Text = "Search By Name:";
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(321, 142);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(182, 33);
            this.cb_Major.TabIndex = 14;
            this.cb_Major.SelectedIndexChanged += new System.EventHandler(this.cb_Major_SelectedIndexChanged);
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(377, 114);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 15;
            this.label_Major.Text = "Major:";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(533, 142);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(182, 33);
            this.cb_Category.TabIndex = 16;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(586, 114);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(88, 25);
            this.label_Category.TabIndex = 17;
            this.label_Category.Text = "Category:";
            // 
            // cb_IsApproved
            // 
            this.cb_IsApproved.FormattingEnabled = true;
            this.cb_IsApproved.Location = new System.Drawing.Point(735, 142);
            this.cb_IsApproved.Name = "cb_IsApproved";
            this.cb_IsApproved.Size = new System.Drawing.Size(182, 33);
            this.cb_IsApproved.TabIndex = 18;
            this.cb_IsApproved.SelectedIndexChanged += new System.EventHandler(this.cb_IsApproved_SelectedIndexChanged);
            // 
            // btn_UploadDocument
            // 
            this.btn_UploadDocument.Location = new System.Drawing.Point(1238, 195);
            this.btn_UploadDocument.Name = "btn_UploadDocument";
            this.btn_UploadDocument.Size = new System.Drawing.Size(112, 74);
            this.btn_UploadDocument.TabIndex = 19;
            this.btn_UploadDocument.Text = "Upload Document";
            this.btn_UploadDocument.UseVisualStyleBackColor = true;
            this.btn_UploadDocument.Click += new System.EventHandler(this.btn_UploadDocument_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Approval Status:";
            // 
            // userControl_UploadDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UploadDocument);
            this.Controls.Add(this.cb_IsApproved);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.tb_SearchByName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_RefreshData);
            this.Controls.Add(this.label_PersonalUpload);
            this.Controls.Add(this.dgv_UploadList);
            this.Name = "userControl_UploadDocument";
            this.Size = new System.Drawing.Size(1393, 807);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UploadList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_UploadList;
        private System.Windows.Forms.Label label_PersonalUpload;
        private System.Windows.Forms.Button btn_RefreshData;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_SearchByName;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.ComboBox cb_Major;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.ComboBox cb_IsApproved;
        private System.Windows.Forms.Button btn_UploadDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
    }
}

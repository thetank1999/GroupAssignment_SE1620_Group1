namespace WinApp
{
    partial class userControl_DocumentManagement
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
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.cb_IsApproved = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Uploader = new System.Windows.Forms.TextBox();
            this.tb_Approver = new System.Windows.Forms.TextBox();
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
            this.UploadedBy,
            this.ApprovedBy,
            this.IsApproved});
            this.dgv_DocumentList.Location = new System.Drawing.Point(25, 225);
            this.dgv_DocumentList.MultiSelect = false;
            this.dgv_DocumentList.Name = "dgv_DocumentList";
            this.dgv_DocumentList.ReadOnly = true;
            this.dgv_DocumentList.RowHeadersWidth = 62;
            this.dgv_DocumentList.RowTemplate.Height = 33;
            this.dgv_DocumentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DocumentList.Size = new System.Drawing.Size(1271, 630);
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
            // UploadedBy
            // 
            this.UploadedBy.HeaderText = "Uploaded By";
            this.UploadedBy.MinimumWidth = 8;
            this.UploadedBy.Name = "UploadedBy";
            this.UploadedBy.ReadOnly = true;
            this.UploadedBy.Width = 200;
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.HeaderText = "ApprovedBy";
            this.ApprovedBy.MinimumWidth = 8;
            this.ApprovedBy.Name = "ApprovedBy";
            this.ApprovedBy.ReadOnly = true;
            this.ApprovedBy.Width = 200;
            // 
            // IsApproved
            // 
            this.IsApproved.HeaderText = "IsApproved";
            this.IsApproved.MinimumWidth = 8;
            this.IsApproved.Name = "IsApproved";
            this.IsApproved.ReadOnly = true;
            this.IsApproved.Width = 150;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(342, 58);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(366, 41);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Document Management:";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Enabled = false;
            this.btn_Preview.Location = new System.Drawing.Point(1312, 225);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(112, 78);
            this.btn_Preview.TabIndex = 3;
            this.btn_Preview.Text = "Preview Document";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(1312, 387);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(112, 81);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove Document";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Location = new System.Drawing.Point(1312, 775);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(112, 80);
            this.btn_RefreshData.TabIndex = 5;
            this.btn_RefreshData.Text = "Refresh Data";
            this.btn_RefreshData.UseVisualStyleBackColor = true;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(342, 177);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(197, 33);
            this.cb_Major.TabIndex = 6;
            this.cb_Major.SelectedIndexChanged += new System.EventHandler(this.cb_Major_SelectedIndexChanged);
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(545, 177);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(182, 33);
            this.cb_Category.TabIndex = 7;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // cb_IsApproved
            // 
            this.cb_IsApproved.FormattingEnabled = true;
            this.cb_IsApproved.Location = new System.Drawing.Point(1145, 177);
            this.cb_IsApproved.Name = "cb_IsApproved";
            this.cb_IsApproved.Size = new System.Drawing.Size(151, 33);
            this.cb_IsApproved.TabIndex = 10;
            this.cb_IsApproved.SelectedIndexChanged += new System.EventHandler(this.cb_IsApproved_SelectedIndexChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(84, 177);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(252, 31);
            this.tb_Name.TabIndex = 11;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1312, 175);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 34);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Uploader
            // 
            this.tb_Uploader.Location = new System.Drawing.Point(733, 177);
            this.tb_Uploader.Name = "tb_Uploader";
            this.tb_Uploader.Size = new System.Drawing.Size(200, 31);
            this.tb_Uploader.TabIndex = 14;
            this.tb_Uploader.TextChanged += new System.EventHandler(this.tb_Uploader_TextChanged);
            // 
            // tb_Approver
            // 
            this.tb_Approver.Location = new System.Drawing.Point(939, 177);
            this.tb_Approver.Name = "tb_Approver";
            this.tb_Approver.Size = new System.Drawing.Size(200, 31);
            this.tb_Approver.TabIndex = 15;
            this.tb_Approver.TextChanged += new System.EventHandler(this.tb_Approver_TextChanged);
            // 
            // userControl_DocumentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Approver);
            this.Controls.Add(this.tb_Uploader);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cb_IsApproved);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.btn_RefreshData);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.dgv_DocumentList);
            this.Name = "userControl_DocumentManagement";
            this.Size = new System.Drawing.Size(1581, 882);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocumentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DocumentList;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocuementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsApproved;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_RefreshData;
        private System.Windows.Forms.ComboBox cb_Major;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.ComboBox cb_IsApproved;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Uploader;
        private System.Windows.Forms.TextBox tb_Approver;
    }
}

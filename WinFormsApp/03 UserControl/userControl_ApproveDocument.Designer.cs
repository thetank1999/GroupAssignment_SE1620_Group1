namespace WinApp
{
    partial class userControl_ApproveDocument
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
            this.dgv_ApproveList = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RefreshData = new System.Windows.Forms.Button();
            this.btn_Approve = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApproveList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ApproveList
            // 
            this.dgv_ApproveList.AllowUserToAddRows = false;
            this.dgv_ApproveList.AllowUserToDeleteRows = false;
            this.dgv_ApproveList.AllowUserToOrderColumns = true;
            this.dgv_ApproveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ApproveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.DocumentName,
            this.Major,
            this.Category,
            this.IsApproved,
            this.UploadedBy});
            this.dgv_ApproveList.Location = new System.Drawing.Point(51, 246);
            this.dgv_ApproveList.MultiSelect = false;
            this.dgv_ApproveList.Name = "dgv_ApproveList";
            this.dgv_ApproveList.ReadOnly = true;
            this.dgv_ApproveList.RowHeadersWidth = 62;
            this.dgv_ApproveList.RowTemplate.Height = 33;
            this.dgv_ApproveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ApproveList.Size = new System.Drawing.Size(1115, 578);
            this.dgv_ApproveList.TabIndex = 9;
            this.dgv_ApproveList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ApproveList_CellContentClick);
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
            // UploadedBy
            // 
            this.UploadedBy.HeaderText = "UploadedBy";
            this.UploadedBy.MinimumWidth = 8;
            this.UploadedBy.Name = "UploadedBy";
            this.UploadedBy.ReadOnly = true;
            this.UploadedBy.Width = 250;
            // 
            // btn_RefreshData
            // 
            this.btn_RefreshData.Location = new System.Drawing.Point(1238, 756);
            this.btn_RefreshData.Name = "btn_RefreshData";
            this.btn_RefreshData.Size = new System.Drawing.Size(112, 68);
            this.btn_RefreshData.TabIndex = 10;
            this.btn_RefreshData.Text = "Refresh Data";
            this.btn_RefreshData.UseVisualStyleBackColor = true;
            this.btn_RefreshData.Click += new System.EventHandler(this.btn_RefreshData_Click);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Enabled = false;
            this.btn_Approve.Location = new System.Drawing.Point(1238, 368);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(112, 67);
            this.btn_Approve.TabIndex = 11;
            this.btn_Approve.Text = "Approve Document";
            this.btn_Approve.UseVisualStyleBackColor = true;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(413, 33);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(354, 41);
            this.label_Title.TabIndex = 12;
            this.label_Title.Text = "Approve Document Site";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Enabled = false;
            this.btn_Preview.Location = new System.Drawing.Point(1238, 246);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(112, 77);
            this.btn_Preview.TabIndex = 13;
            this.btn_Preview.Text = "Preview Document";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // userControl_ApproveDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.btn_Approve);
            this.Controls.Add(this.btn_RefreshData);
            this.Controls.Add(this.dgv_ApproveList);
            this.Name = "userControl_ApproveDocument";
            this.Size = new System.Drawing.Size(1421, 997);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ApproveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ApproveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadedBy;
        private System.Windows.Forms.Button btn_RefreshData;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btn_Preview;
    }
}

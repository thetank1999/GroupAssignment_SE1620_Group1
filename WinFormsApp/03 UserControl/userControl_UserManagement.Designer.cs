namespace WinApp { 
    partial class userControl_UserManagement
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
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 150;
            // 
            // UserEmail
            // 
            this.UserEmail.HeaderText = "UserEmail";
            this.UserEmail.MinimumWidth = 8;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            this.UserEmail.Width = 250;
            // 
            // UserRole
            // 
            this.UserRole.HeaderText = "UserRole";
            this.UserRole.MinimumWidth = 8;
            this.UserRole.Name = "UserRole";
            this.UserRole.ReadOnly = true;
            this.UserRole.Width = 150;
            // 
            // UserFullname
            // 
            this.UserFullname.HeaderText = "UserFullname";
            this.UserFullname.MinimumWidth = 8;
            this.UserFullname.Name = "UserFullname";
            this.UserFullname.ReadOnly = true;
            this.UserFullname.Width = 250;
            // 
            // UserStatus
            // 
            this.UserStatus.HeaderText = "UserStatus";
            this.UserStatus.MinimumWidth = 8;
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.ReadOnly = true;
            this.UserStatus.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.MinimumWidth = 8;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "ROle";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.AllowUserToAddRows = false;
            this.dgv_UserList.AllowUserToDeleteRows = false;
            this.dgv_UserList.AllowUserToOrderColumns = true;
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.EmailAddress,
            this.RoleId,
            this.User_Status});
            this.dgv_UserList.Location = new System.Drawing.Point(29, 186);
            this.dgv_UserList.MultiSelect = false;
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.ReadOnly = true;
            this.dgv_UserList.RowHeadersWidth = 62;
            this.dgv_UserList.RowTemplate.Height = 33;
            this.dgv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserList.Size = new System.Drawing.Size(988, 691);
            this.dgv_UserList.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "UserId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.MinimumWidth = 8;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 200;
            // 
            // RoleId
            // 
            this.RoleId.HeaderText = "Role";
            this.RoleId.MinimumWidth = 8;
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            this.RoleId.Width = 200;
            // 
            // User_Status
            // 
            this.User_Status.HeaderText = "Status";
            this.User_Status.MinimumWidth = 8;
            this.User_Status.Name = "User_Status";
            this.User_Status.ReadOnly = true;
            this.User_Status.Width = 200;
            // 
            // userControl_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_UserList);
            this.Name = "userControl_UserManagement";
            this.Size = new System.Drawing.Size(1435, 1051);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Status;
    }
}

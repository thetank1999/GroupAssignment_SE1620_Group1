namespace WinApp { 
    partial class userControl_UserManagementAdmin
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
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
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
            this.Major,
            this.RoleId,
            this.User_Status});
            this.dgv_UserList.Location = new System.Drawing.Point(29, 186);
            this.dgv_UserList.MultiSelect = false;
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.ReadOnly = true;
            this.dgv_UserList.RowHeadersWidth = 62;
            this.dgv_UserList.RowTemplate.Height = 33;
            this.dgv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserList.Size = new System.Drawing.Size(1223, 691);
            this.dgv_UserList.TabIndex = 9;
            this.dgv_UserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserList_CellContentClick);
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
            this.Name.Width = 250;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.MinimumWidth = 8;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 300;
            // 
            // Major
            // 
            this.Major.HeaderText = "Major";
            this.Major.MinimumWidth = 8;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Width = 200;
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
            this.User_Status.HeaderText = "IsActive";
            this.User_Status.MinimumWidth = 8;
            this.User_Status.Name = "User_Status";
            this.User_Status.ReadOnly = true;
            this.User_Status.Width = 200;
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(1258, 186);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 66);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update Information";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(440, 18);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(276, 41);
            this.label_Title.TabIndex = 11;
            this.label_Title.Text = "User Management";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1272, 801);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(113, 76);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh Data";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(348, 147);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(241, 31);
            this.tb_Email.TabIndex = 13;
            this.tb_Email.TextChanged += new System.EventHandler(this.tb_Email_TextChanged);
            // 
            // cb_Role
            // 
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(845, 147);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(182, 33);
            this.cb_Role.TabIndex = 14;
            this.cb_Role.SelectedIndexChanged += new System.EventHandler(this.cb_Role_SelectedIndexChanged);
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(1045, 147);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(182, 33);
            this.cb_Status.TabIndex = 15;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Enabled = false;
            this.btn_ChangePassword.Location = new System.Drawing.Point(1258, 289);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(127, 71);
            this.btn_ChangePassword.TabIndex = 16;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(645, 147);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(182, 33);
            this.cb_Major.TabIndex = 17;
            this.cb_Major.SelectedIndexChanged += new System.EventHandler(this.cb_Major_SelectedIndexChanged);
            // 
            // userControl_UserManagementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_UserList);
            //this.Name = "userControl_UserManagementAdmin";
            this.Size = new System.Drawing.Size(1426, 1051);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserFullname;
        //private System.Windows.Forms.DataGridViewTextBoxColumn UserStatus;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Status;
        private System.Windows.Forms.ComboBox cb_Major;
    }
}

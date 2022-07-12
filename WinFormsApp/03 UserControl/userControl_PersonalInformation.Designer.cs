namespace WinApp
{
    partial class userControl_PersonalInformation
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
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.tb_Major = new System.Windows.Forms.TextBox();
            this.tb_Role = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.Location = new System.Drawing.Point(241, 124);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(128, 25);
            this.label_EmailAddress.TabIndex = 0;
            this.label_EmailAddress.Text = "Email Address:";
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Location = new System.Drawing.Point(241, 188);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(87, 25);
            this.label_Fullname.TabIndex = 1;
            this.label_Fullname.Text = "Fullname:";
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(241, 245);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 2;
            this.label_Major.Text = "Major:";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(241, 304);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(50, 25);
            this.label_Role.TabIndex = 3;
            this.label_Role.Text = "Role:";
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Enabled = false;
            this.tb_EmailAddress.Location = new System.Drawing.Point(420, 118);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(233, 31);
            this.tb_EmailAddress.TabIndex = 4;
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Enabled = false;
            this.tb_Fullname.Location = new System.Drawing.Point(420, 182);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.Size = new System.Drawing.Size(233, 31);
            this.tb_Fullname.TabIndex = 5;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(515, 406);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(138, 65);
            this.btn_ChangePassword.TabIndex = 9;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // tb_Major
            // 
            this.tb_Major.Enabled = false;
            this.tb_Major.Location = new System.Drawing.Point(420, 239);
            this.tb_Major.Name = "tb_Major";
            this.tb_Major.Size = new System.Drawing.Size(233, 31);
            this.tb_Major.TabIndex = 10;
            // 
            // tb_Role
            // 
            this.tb_Role.Enabled = false;
            this.tb_Role.Location = new System.Drawing.Point(420, 298);
            this.tb_Role.Name = "tb_Role";
            this.tb_Role.Size = new System.Drawing.Size(233, 31);
            this.tb_Role.TabIndex = 11;
            // 
            // userControl_PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Role);
            this.Controls.Add(this.tb_Major);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.tb_EmailAddress);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_Fullname);
            this.Controls.Add(this.label_EmailAddress);
            this.Name = "userControl_PersonalInformation";
            this.Size = new System.Drawing.Size(1191, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EmailAddress;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.TextBox tb_Fullname;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.TextBox tb_Major;
        private System.Windows.Forms.TextBox tb_Role;
    }
}

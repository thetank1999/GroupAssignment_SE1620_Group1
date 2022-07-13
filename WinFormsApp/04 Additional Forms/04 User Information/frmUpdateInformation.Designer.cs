namespace WinApp { 
    partial class frmUpdateInformation
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
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            this.cb_IsActive = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.Location = new System.Drawing.Point(257, 117);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(128, 25);
            this.label_EmailAddress.TabIndex = 0;
            this.label_EmailAddress.Text = "Email Address:";
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(257, 172);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(50, 25);
            this.label_Role.TabIndex = 1;
            this.label_Role.Text = "Role:";
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Location = new System.Drawing.Point(257, 222);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(87, 25);
            this.label_Fullname.TabIndex = 2;
            this.label_Fullname.Text = "Fullname:";
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(257, 275);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 3;
            this.label_Major.Text = "Major:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(260, 324);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(77, 25);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "IsActive:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(408, 111);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(229, 31);
            this.tb_Email.TabIndex = 5;
            // 
            // cb_Role
            // 
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(408, 164);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(229, 33);
            this.cb_Role.TabIndex = 6;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(266, 24);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(371, 41);
            this.label_Title.TabIndex = 7;
            this.label_Title.Text = "Update User Information";
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Location = new System.Drawing.Point(408, 216);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.Size = new System.Drawing.Size(229, 31);
            this.tb_Fullname.TabIndex = 8;
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(408, 272);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(229, 33);
            this.cb_Major.TabIndex = 9;
            // 
            // cb_IsActive
            // 
            this.cb_IsActive.FormattingEnabled = true;
            this.cb_IsActive.Location = new System.Drawing.Point(408, 321);
            this.cb_IsActive.Name = "cb_IsActive";
            this.cb_IsActive.Size = new System.Drawing.Size(229, 33);
            this.cb_IsActive.TabIndex = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(266, 407);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(488, 407);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmUpdateInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 473);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cb_IsActive);
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_Fullname);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.label_EmailAddress);
            this.Name = "frmUpdateInformation";
            this.Text = "UpdateInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label label_EmailAddress;
    private System.Windows.Forms.Label label_Role;
    private System.Windows.Forms.Label label_Fullname;
    private System.Windows.Forms.Label label_Major;
    private System.Windows.Forms.Label label_Status;
    private System.Windows.Forms.TextBox tb_Email;
    private System.Windows.Forms.ComboBox cb_Role;
    private System.Windows.Forms.Label label_Title;
    private System.Windows.Forms.TextBox tb_Fullname;
    private System.Windows.Forms.ComboBox cb_Major;
    private System.Windows.Forms.ComboBox cb_IsActive;
    private System.Windows.Forms.Button btn_Cancel;
    private System.Windows.Forms.Button btn_Save;
}
}
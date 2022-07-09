namespace WinApp
{
    partial class frmRegister
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
            this.tb_EmailAddress = new System.Windows.Forms.TextBox();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_Welcom = new System.Windows.Forms.Label();
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_EmailAddress
            // 
            this.tb_EmailAddress.Location = new System.Drawing.Point(369, 60);
            this.tb_EmailAddress.Name = "tb_EmailAddress";
            this.tb_EmailAddress.Size = new System.Drawing.Size(221, 31);
            this.tb_EmailAddress.TabIndex = 0;
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Location = new System.Drawing.Point(369, 127);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.Size = new System.Drawing.Size(221, 31);
            this.tb_Fullname.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(369, 195);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(221, 31);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(369, 270);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.PasswordChar = '*';
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(221, 31);
            this.tb_ConfirmPassword.TabIndex = 3;
            // 
            // label_Welcom
            // 
            this.label_Welcom.AutoSize = true;
            this.label_Welcom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Welcom.Location = new System.Drawing.Point(304, 9);
            this.label_Welcom.Name = "label_Welcom";
            this.label_Welcom.Size = new System.Drawing.Size(134, 41);
            this.label_Welcom.TabIndex = 4;
            this.label_Welcom.Text = "Register";
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.Location = new System.Drawing.Point(224, 63);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(128, 25);
            this.label_EmailAddress.TabIndex = 5;
            this.label_EmailAddress.Text = "Email Address:";
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Location = new System.Drawing.Point(224, 133);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(92, 25);
            this.label_Fullname.TabIndex = 6;
            this.label_Fullname.Text = "Fullname: ";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(224, 201);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(91, 25);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Password:";
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(192, 276);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(160, 25);
            this.label_ConfirmPassword.TabIndex = 8;
            this.label_ConfirmPassword.Text = "Confirm Password:";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(417, 366);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(112, 34);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(249, 366);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Fullname);
            this.Controls.Add(this.label_EmailAddress);
            this.Controls.Add(this.label_Welcom);
            this.Controls.Add(this.tb_ConfirmPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.tb_EmailAddress);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EmailAddress;
        private System.Windows.Forms.TextBox tb_Fullname;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.Label label_Welcom;
        private System.Windows.Forms.Label label_EmailAddress;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
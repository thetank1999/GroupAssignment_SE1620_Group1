namespace WinApp
{
    partial class frmChangePassword
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
            this.label_CurrentPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SaveChange = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_CurrentPassword = new System.Windows.Forms.TextBox();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.tb_PasswordConfirmation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_CurrentPassword
            // 
            this.label_CurrentPassword.AutoSize = true;
            this.label_CurrentPassword.Location = new System.Drawing.Point(216, 85);
            this.label_CurrentPassword.Name = "label_CurrentPassword";
            this.label_CurrentPassword.Size = new System.Drawing.Size(154, 25);
            this.label_CurrentPassword.TabIndex = 0;
            this.label_CurrentPassword.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password Confirmation:";
            // 
            // btn_SaveChange
            // 
            this.btn_SaveChange.Location = new System.Drawing.Point(425, 356);
            this.btn_SaveChange.Name = "btn_SaveChange";
            this.btn_SaveChange.Size = new System.Drawing.Size(112, 61);
            this.btn_SaveChange.TabIndex = 3;
            this.btn_SaveChange.Text = "Save Change";
            this.btn_SaveChange.UseVisualStyleBackColor = true;
            this.btn_SaveChange.Click += new System.EventHandler(this.btn_SaveChange_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(249, 356);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 61);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_CurrentPassword
            // 
            this.tb_CurrentPassword.Location = new System.Drawing.Point(394, 82);
            this.tb_CurrentPassword.Name = "tb_CurrentPassword";
            this.tb_CurrentPassword.Size = new System.Drawing.Size(209, 31);
            this.tb_CurrentPassword.TabIndex = 5;
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(394, 164);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(209, 31);
            this.tb_NewPassword.TabIndex = 6;
            // 
            // tb_PasswordConfirmation
            // 
            this.tb_PasswordConfirmation.Location = new System.Drawing.Point(394, 226);
            this.tb_PasswordConfirmation.Name = "tb_PasswordConfirmation";
            this.tb_PasswordConfirmation.Size = new System.Drawing.Size(209, 31);
            this.tb_PasswordConfirmation.TabIndex = 7;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_PasswordConfirmation);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.tb_CurrentPassword);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CurrentPassword);
            this.Name = "frmChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SaveChange;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_CurrentPassword;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.TextBox tb_PasswordConfirmation;
    }
}
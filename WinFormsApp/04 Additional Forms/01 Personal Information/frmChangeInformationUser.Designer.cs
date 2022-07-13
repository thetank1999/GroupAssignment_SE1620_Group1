namespace WinApp
{
    partial class frmChangeInformationUser
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            this.tb_Fullname = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Fullname = new System.Windows.Forms.Label();
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(488, 318);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(242, 318);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(384, 246);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(229, 33);
            this.cb_Major.TabIndex = 22;
            // 
            // tb_Fullname
            // 
            this.tb_Fullname.Location = new System.Drawing.Point(384, 187);
            this.tb_Fullname.Name = "tb_Fullname";
            this.tb_Fullname.Size = new System.Drawing.Size(229, 31);
            this.tb_Fullname.TabIndex = 21;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(242, 45);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(371, 41);
            this.label_Title.TabIndex = 20;
            this.label_Title.Text = "Update User Information";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(384, 132);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(229, 31);
            this.tb_Email.TabIndex = 18;
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(233, 246);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 16;
            this.label_Major.Text = "Major:";
            // 
            // label_Fullname
            // 
            this.label_Fullname.AutoSize = true;
            this.label_Fullname.Location = new System.Drawing.Point(233, 190);
            this.label_Fullname.Name = "label_Fullname";
            this.label_Fullname.Size = new System.Drawing.Size(87, 25);
            this.label_Fullname.TabIndex = 15;
            this.label_Fullname.Text = "Fullname:";
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.Location = new System.Drawing.Point(233, 138);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(128, 25);
            this.label_EmailAddress.TabIndex = 13;
            this.label_EmailAddress.Text = "Email Address:";
            // 
            // frmChangeInformationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 451);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.tb_Fullname);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_Fullname);
            this.Controls.Add(this.label_EmailAddress);
            this.Name = "frmChangeInformationUser";
            this.Text = "ChangeInformationUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cb_Major;
        private System.Windows.Forms.TextBox tb_Fullname;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label_Major;
        private System.Windows.Forms.Label label_Fullname;
        private System.Windows.Forms.Label label_EmailAddress;
    }
}
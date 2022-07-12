namespace WinApp
{   partial class frmUploadDocument
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
            this.label_Major = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.cb_Major = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Major
            // 
            this.label_Major.AutoSize = true;
            this.label_Major.Location = new System.Drawing.Point(463, 117);
            this.label_Major.Name = "label_Major";
            this.label_Major.Size = new System.Drawing.Size(62, 25);
            this.label_Major.TabIndex = 14;
            this.label_Major.Text = "Major:";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(34, 120);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(88, 25);
            this.label_Category.TabIndex = 13;
            this.label_Category.Text = "Category:";
            // 
            // cb_Major
            // 
            this.cb_Major.FormattingEnabled = true;
            this.cb_Major.Location = new System.Drawing.Point(531, 117);
            this.cb_Major.Name = "cb_Major";
            this.cb_Major.Size = new System.Drawing.Size(182, 33);
            this.cb_Major.TabIndex = 12;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(128, 117);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(182, 33);
            this.cb_Category.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(531, 268);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(768, 170);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(112, 34);
            this.btn_Browse.TabIndex = 9;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(34, 170);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(679, 31);
            this.tb_FilePath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Upload Document:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(304, 268);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmUploadDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 376);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Major);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.cb_Major);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_FilePath);
            this.Name = "frmUploadDocument";
            this.Text = "UploadDocument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label label_Major;
    private System.Windows.Forms.Label label_Category;
    private System.Windows.Forms.ComboBox cb_Major;
    private System.Windows.Forms.ComboBox cb_Category;
    private System.Windows.Forms.Button btn_Save;
    private System.Windows.Forms.Button btn_Browse;
    private System.Windows.Forms.TextBox tb_FilePath;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_Cancel;
}
}
namespace QuanLySinhVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblStudent = new System.Windows.Forms.DataGridView();
            this.lbDeptCode = new System.Windows.Forms.Label();
            this.cbDeptCode = new System.Windows.Forms.ComboBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStudent.Location = new System.Drawing.Point(88, 103);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.ReadOnly = true;
            this.tblStudent.Size = new System.Drawing.Size(438, 215);
            this.tblStudent.TabIndex = 0;
            // 
            // lbDeptCode
            // 
            this.lbDeptCode.AutoSize = true;
            this.lbDeptCode.Location = new System.Drawing.Point(85, 59);
            this.lbDeptCode.Name = "lbDeptCode";
            this.lbDeptCode.Size = new System.Drawing.Size(49, 13);
            this.lbDeptCode.TabIndex = 1;
            this.lbDeptCode.Text = "Ma khoa";
            // 
            // cbDeptCode
            // 
            this.cbDeptCode.FormattingEnabled = true;
            this.cbDeptCode.Location = new System.Drawing.Point(140, 56);
            this.cbDeptCode.Name = "cbDeptCode";
            this.cbDeptCode.Size = new System.Drawing.Size(121, 21);
            this.cbDeptCode.TabIndex = 2;
            this.cbDeptCode.SelectedValueChanged += new System.EventHandler(this.cbDeptCode_SelectedIndexChanged);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(342, 56);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(184, 20);
            this.txtDept.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.cbDeptCode);
            this.Controls.Add(this.lbDeptCode);
            this.Controls.Add(this.tblStudent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "QuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblStudent;
        private System.Windows.Forms.Label lbDeptCode;
        private System.Windows.Forms.ComboBox cbDeptCode;
        private System.Windows.Forms.TextBox txtDept;
    }
}


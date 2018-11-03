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
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchSvien = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStudent
            // 
            this.tblStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStudent.Location = new System.Drawing.Point(37, 76);
            this.tblStudent.Name = "tblStudent";
            this.tblStudent.ReadOnly = true;
            this.tblStudent.Size = new System.Drawing.Size(749, 349);
            this.tblStudent.TabIndex = 0;
            // 
            // lbDeptCode
            // 
            this.lbDeptCode.AutoSize = true;
            this.lbDeptCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeptCode.Location = new System.Drawing.Point(34, 30);
            this.lbDeptCode.Name = "lbDeptCode";
            this.lbDeptCode.Size = new System.Drawing.Size(61, 16);
            this.lbDeptCode.TabIndex = 1;
            this.lbDeptCode.Text = "Mã Khoa";
            // 
            // cbDeptCode
            // 
            this.cbDeptCode.FormattingEnabled = true;
            this.cbDeptCode.Location = new System.Drawing.Point(101, 27);
            this.cbDeptCode.Name = "cbDeptCode";
            this.cbDeptCode.Size = new System.Drawing.Size(71, 21);
            this.cbDeptCode.TabIndex = 2;
            this.cbDeptCode.SelectedValueChanged += new System.EventHandler(this.cbDeptCode_SelectedIndexChanged);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(188, 27);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(184, 20);
            this.txtDept.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm sinh viên";
            // 
            // txbSearchSvien
            // 
            this.txbSearchSvien.Location = new System.Drawing.Point(546, 27);
            this.txbSearchSvien.Name = "txbSearchSvien";
            this.txbSearchSvien.Size = new System.Drawing.Size(168, 20);
            this.txbSearchSvien.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(720, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchSvien);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchSvien;
        private System.Windows.Forms.Button btnSearch;
    }
}


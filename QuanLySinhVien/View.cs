using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        DataTable table, combo;

        public frmMain()
        {
            InitializeComponent();

            // Init txtSearchSVien
            ActiveControl = txbSearchSvien;

            // Init data grid view
            
            DAO dao = new DAO();
            table = dao.Table;
            tblStudent.DataSource = table;

            tblStudent.Columns[0].HeaderText = "Họ Tên";
            tblStudent.Columns[1].HeaderText = "Mã SV";
            tblStudent.Columns[2].HeaderText = "Năm";
            tblStudent.Columns[3].HeaderText = "Mã Khoa";
            tblStudent.Columns[0].Width = tblStudent.Width - tblStudent.Columns[0].Width * 3 - tblStudent.RowHeadersWidth - 2;
            // Init cbbox
            combo = dao.Combo;
            cbDeptCode.DataSource = combo.DefaultView;
            cbDeptCode.DisplayMember = "MAKHOA";
            txtDept.Text = combo.Rows[0]["TENKHOA"].ToString();
        }

        private void search() {
            int index = cbDeptCode.SelectedIndex;
            string searchSvien = txbSearchSvien.Text;

            txtDept.Text = combo.Rows[index]["TENKHOA"].ToString();
            string deptCode = combo.Rows[index]["MAKHOA"].ToString();

            DataView dv = new DataView(table) {
                RowFilter = $"MAKH = '{deptCode}' AND TEN LIKE '%{searchSvien}%'"
            };
            tblStudent.DataSource = dv;
            lbTotal.Text = tblStudent.RowCount.ToString();
        }

        private void txbSearchSvien_TextChanged(object sender, EventArgs e) {
            search();
        }

        private void txbSearchSvien_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                txbSearchSvien.Clear();
            }
        }

        private void cbDeptCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

    }
}

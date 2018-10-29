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

            DAO dao = new DAO();
            table = dao.table;
            tblStudent.DataSource = table;

            combo = dao.combo;
            cbDeptCode.DataSource = combo.DefaultView;
            cbDeptCode.DisplayMember = "MAKHOA";
            txtDept.Text = combo.Rows[0]["TENKHOA"].ToString();
        }
        private void cbDeptCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = cbDeptCode.SelectedIndex;

            string dept = combo.Rows[index]["TENKHOA"].ToString();
            txtDept.Text = dept;
            string deptCode = combo.Rows[index]["MAKHOA"].ToString();

            DataView dv = new DataView(table);
            dv.RowFilter = "MAKH = '" + deptCode + "'"; // query example = "id = 10"
            tblStudent.DataSource = dv;
        }

    }
}

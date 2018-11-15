using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    class DAO
    {
        private SqlDataAdapter Adapter;
        private string CnnStr = "Data Source = localhost; uid = sa; pwd = 123456; Initial Catalog = QLSVien";
        public DataTable Table;
        public DataTable Combo;
        public DAO()
        {
            loadTableSvien();
            loadTableKhoa();
        }

        public void loadTableSvien()
        {
            string sqlSVien = "SELECT * FROM SVIEN";

            Adapter = new SqlDataAdapter(sqlSVien, CnnStr);
            Table = new DataTable();
            Adapter.Fill(Table);
        }

        public void loadTableKhoa()
        {
            string sqlCombo = "SELECT * FROM KHOA";

            Combo = new DataTable();
            Adapter = new SqlDataAdapter(sqlCombo, CnnStr);
            Adapter.Fill(Combo);
        }
    }
}

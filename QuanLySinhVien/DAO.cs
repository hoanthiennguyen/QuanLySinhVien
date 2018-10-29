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
        SqlDataAdapter adapter;
        public DataTable table;
        public DataTable combo;
        public DAO()
        {
            string cnnStr = "Data Source = localhost; uid = sa; pwd = 123456; Initial Catalog = QLSVien";
            string sqlSVien = "SELECT * FROM SVien";
            string sqlCombo = "SELECT * FROM Khoa";
            adapter = new SqlDataAdapter(sqlSVien, cnnStr);
            table = new DataTable();
            adapter.Fill(table);

            combo = new DataTable();
            adapter = new SqlDataAdapter(sqlCombo, cnnStr);
            adapter.Fill(combo);
        }
        
    }
}

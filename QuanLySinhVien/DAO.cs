using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTable
{
    [Serializable]
    class DAO
    {
        SqlDataAdapter adapter;
        public DataTable table;
        public DAO()
        {
            string cnnStr = "Data Source = localhost; uid = sa; pwd = 123456; Initial Catalog = QLSVien";
            string sql = "SELECT * FROM SVien";

            adapter = new SqlDataAdapter(sql, cnnStr);

            table = new DataTable();

            adapter.Fill(table);
        }
        
    }
}

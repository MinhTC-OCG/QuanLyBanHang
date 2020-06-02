using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Lop_DTO
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-G3PG01C\NHATNGUYEN;Initial Catalog=QLBH;Integrated Security=True");
        }

        public DataTable getTable()
        {

        }
    }
}

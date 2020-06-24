using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Lop_DAL
    {

        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-G3PG01C\NHATNGUYEN;Initial Catalog=QLBH;Integrated Security=True");
            //Data Source=DESKTOP-G3PG01C\NHATNGUYEN;Initial Catalog=QLBH;Integrated Security=True
            //Data Source=DESKTOP-KRH26DK\MINH;Initial Catalog=QLBH;Integrated Security=True
            //Data Source=LONGLD\LLD;Initial Catalog=QLBH;Integrated Security=True
        }

        public DataTable getTable(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            return dt;
        }

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}

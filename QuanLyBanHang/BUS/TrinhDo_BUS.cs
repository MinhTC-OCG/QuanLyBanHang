using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TrinhDo_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        //Lấy thông tin trong bảng TrinhDo đổ  lên  datagridview
          public DataTable ShowTrinhDo()
        {
            string sql = "SELECT * FROM TrinhDo12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void InsertTrinhdo(string matd,string tentd)
        {
            string sql = "INSERT INTO TrinhDo12 VALUES ('" + matd + "',N'" + tentd + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void UpdateTrinhDo(string matd, string tentd)
        {
            string sql = "UPDATE TrinhDo12 SET TenTD =N'" + tentd + "' Where MaTD=N'"+matd+"'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteTrinhdo(string matd)
        {
            string sql = "DELETE TrinhDo12 WHERE MaTD = '" + matd + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchTrinhdo(string matd)
        {
            string sql = "SELECT * FROM TrinhDo12 WHERE MaTD = '" + matd + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

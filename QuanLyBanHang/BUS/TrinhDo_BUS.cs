using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class TrinhDo_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        linq lq = new linq();

        public List<TrinhDo_DTO> ShowTD()
        {
            List<TrinhDo_DTO> td = new List<TrinhDo_DTO>();
            td = lq.ShowTrinhDo();
            return td.ToList();
        }

        public void InsertTD(string matd, string tentd)
        {
            lq.InsertTrinhDo_LinQ(matd, tentd);
        }

        public void UpdateTD(string matd, string tentd)
        {
            lq.UpdateTrinhDo_Linq(matd, tentd);
        }

        public void DeleteTD(string matd)
        {
            lq.DeleteTrinhDo_LinQ(matd);
        }

        public List<TrinhDo_DTO> SearchTD(string matd)
        {
            List<TrinhDo_DTO> td = new List<TrinhDo_DTO>();
            td = lq.SearchTrinhDo(matd);
            return td.ToList();
        }

        //Lấy thông tin trong bảng TrinhDo đổ  lên  datagridview
        //public DataTable ShowTrinhDo()
        //{
        //    string sql = "SELECT * FROM TrinhDo12";
        //    DataTable dt = new DataTable();
        //    dt = dal.getTable(sql);
        //    return dt;
        //}
        //public void InsertTrinhdo(string matd,string tentd)
        //{
        //    string sql = "INSERT INTO TrinhDo12 VALUES ('" + matd + "',N'" + tentd + "')";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public void UpdateTrinhDo(string matd, string tentd)
        //{
        //    string sql = "UPDATE TrinhDo12 SET TenTD =N'" + tentd + "' Where MaTD=N'"+matd+"'";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public void DeleteTrinhdo(string matd)
        //{
        //    string sql = "DELETE TrinhDo12 WHERE MaTD = '" + matd + "'";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public DataTable SearchTrinhdo(string matd)
        //{
        //    string sql = "SELECT * FROM TrinhDo12 WHERE MaTD = '" + matd + "'";
        //    DataTable dt = new DataTable();
        //    dt = dal.getTable(sql);
        //    return dt;
        //}
    }
}

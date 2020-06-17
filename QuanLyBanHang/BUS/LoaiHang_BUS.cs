using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class LoaiHang_BUS
    {
        Lop_DAL dal = new Lop_DAL();


        linq lq = new linq();
        public List<LoaiHang_DTO> ShowLH()
        {
            List<LoaiHang_DTO> lh = new List<LoaiHang_DTO>();
            lh = lq.ShowLoaiHang();
            return lh.ToList();
        }

        public void InsertLH(string maloai, string tenloai, string ghichu)
        {
            lq.InsertLoaiHang_LinQ(maloai, tenloai, ghichu);
        }

        public void UpdateLH(string maloai, string tenloai, string ghichu)
        {
            lq.UpdateLoaiHang_LinQ(maloai, tenloai, ghichu);
        }

        public void DeleteLH(string maloai)
        {
            lq.DeleteLoaiHang_LinQ(maloai);
        }

        public List<LoaiHang_DTO> SearchLH(string maloai)
        {
            List<LoaiHang_DTO> lh = new List<LoaiHang_DTO>();
            lh = lq.SearchLoaiHang(maloai);
            return lh.ToList();
        }

        //public DataTable ShowLoaiHang()
        //{
        //    string sql = "SELECT * FROM LoaiHang12";
        //    DataTable dt = new DataTable();
        //    dt = dal.getTable(sql);
        //    return dt;
        //}

        //public void InsertLoaiHang(string maloai, string tenloai,string ghichu)
        //{
        //    string sql = "INSERT INTO LoaiHang12 VALUES ('" + maloai + "',N'" + tenloai + "',N'" + ghichu + "')";
        //    dal.ExecuteNonQuery(sql);
        //}


        //public void UpdateLoaiHang(string maloai, string tenloai, string ghichu)
        //{
        //    string sql = "UPDATE LoaiHang12 SET TenL = N'"+tenloai+"',GhiChu = N'"+ghichu+"' WHERE MaL = '"+maloai+"'";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public void DeleteLoaiHang(string maloai)
        //{
        //    string sql = "DELETE LoaiHang12 WHERE MaL = '"+maloai+"'";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public DataTable SearchLoaiHang(string maloai)
        //{
        //    string sql = "SELECT *FROM LoaiHang12 WHERE MaL = '" + maloai + "'";
        //    DataTable dt = new DataTable();
        //    dt = dal.getTable(sql);
        //    return dt;
        //}

    }
}

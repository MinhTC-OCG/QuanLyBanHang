using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class LoaiHang_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        
        public DataTable ShowLoaiHang()
        {
            string sql = "SELECT * FROM LoaiHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertLoaiHang(string maloai, string tenloai,string ghichu)
        {
            string sql = "INSERT INTO LoaiHang12 VALUES ('" + maloai + "',N'" + tenloai + "',N'" + ghichu + "')";
            dal.ExecuteNonQuery(sql);
        }


        public void UpdateLoaiHang(string maloai, string tenloai, string ghichu)
        {
            string sql = "UPDATE LoaiHang12 SET TenL = N'"+tenloai+"',GhiChu = N'"+ghichu+"' WHERE MaL = '"+maloai+"'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteLoaiHang(string maloai)
        {
            string sql = "DELETE LoaiHang12 WHERE MaL = '"+maloai+"'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchLoaiHang(string maloai)
        {
            string sql = "SELECT *FROM LoaiHang12 WHERE MaL = '" + maloai + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

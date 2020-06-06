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
    public class LichSuGia_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable ShowLichSuGia()
        {
            string sql = "select * from dbo.LichSuGia12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable GetDataHang()
        {
            string sql = "select * from Hang12";
            DataTable dtcb = new DataTable();
            dtcb = dal.getTable(sql);
            return dtcb;
        }
        public void InsertLichSuGia(string mahang, string ngaybatdau, string ngayketthuc, string dongia,string ngaycapnhat)
        {
            string sql = "Insert into LichSuGia12 values('"+ mahang +"','"+ngaybatdau+"','"+ngayketthuc+"',"+ dongia +",'"+ngaycapnhat+"')";
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

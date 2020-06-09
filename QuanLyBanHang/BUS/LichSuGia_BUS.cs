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
        public void InsertLichSuGia(string mahang, String ngaybatdau, string ngayketthuc, int dongia,string ngaycapnhat)
        {
            string sql = "Insert into LichSuGia12 values('"+ mahang +"','"+ngaybatdau+"','"+ngayketthuc+"',"+ dongia +",'"+ngaycapnhat+"')";
            dal.ExecuteNonQuery(sql);
        }
        public void UpdateLichSuGia(string mahang, string ngaybatdau, string ngayketthuc, int dongia, string ngaycapnhat)
        {
            string sql = "update LichSuGia12 set NgayBD='"+ ngaybatdau +"',NgayKT='"+ ngayketthuc +"',DonG= "+ dongia +",NgayCN='"+ngaycapnhat+"' where Mah='"+mahang+"'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteLichSuGia(string mahang)
        {
            string sql = "delete from dbo.LichSuGia12 where MaH='"+mahang+"'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchLichSuHang(string mahang)
        {
            string sql = "SELECT * FROM LichSuGia12 where MaH='"+ mahang +"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

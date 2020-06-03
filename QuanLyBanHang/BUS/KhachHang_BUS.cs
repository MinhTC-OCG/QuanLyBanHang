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
    public class KhachHang_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public System.Data.DataTable ShowKhachHang()
        {
            string sql = "select * from KhachHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void InsertKhachHang(string makhachhang, string hoten, string diachi, int dongia, string sodienthoai)
        {
            string sql = "Insert into LichSuGia12 values('" + makhachhang + "','" + hoten + "','" + diachi + "',20000,'" + sodienthoai + "')";
            dal.ExecuteNonQuery(sql);
        }
    }
}

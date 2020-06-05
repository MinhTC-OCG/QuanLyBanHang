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
    public class HoaDon_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable GetNamePrice (string mahang)
        {
            string sql = "Select TenH,DonG from Hang12 WHERE MaH='"+mahang+"'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertThongtinhang(string mah, string tenhang, int soluong, int dongia, int thanhtien)
        {
            string sql = "INSERT INTO ThongTinHang12 VALUES ('" + mah + "',N'" + tenhang + "','" + soluong + "','" + dongia + "','" + thanhtien + "')";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable GetThongtinhang()
        {
            string sql = "select * from ThongTinHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void UpdateThongtinloaihang(string mahang, string tenhang, int soluong, int dongia, int thanhtien)
        {
            string sql = "UPDATE ThongTinHang12 SET  TenHang= N'" + tenhang + "',SoLuong = N'" + soluong + "',DonGia='" + dongia + "',ThanhTien='" + thanhtien + "' WHERE MaH = '" + mahang + "'";
        dal.ExecuteNonQuery(sql);
        }
        public void DeleteThongtinloaihang(string mahang)
        {
            string sql = "DELETE ThongTinHang12 WHERE MaH = '" + mahang + "'";
            dal.ExecuteNonQuery(sql);
        }
    }
}

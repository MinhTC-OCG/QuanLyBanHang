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


        public DataTable GetNamePrice(string mahang)
        {
            string sql = "Select TenH,DonG from Hang12 WHERE MaH='" + mahang + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetNameKH(string makh)
        {
            string sql = "SELECT HoTen FROM KhachHang12 WHERE MaKH='" + makh + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetNameNV(string manv)
        {
            string sql = "SELECT HoTen FROM NhanVien12 WHERE MaNV='" + manv + "'";
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

        public DataTable GetAmountHD()
        {
            string sql = "SELECT * FROM HoaDon12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        /**
         * INSERT vao bang hoa don va hoa don chi tiet
        **/

        public void InsertHD(string mahd, string makh, string ngaylap, string manv)
        {
            string sql = "INSERT INTO HoaDon12 VALUES('" + mahd + "','" + makh + "','" + ngaylap + "','" + manv + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void InsertHDChiTiet(string mahd, string mahang, int soluong)
        {
            string sql = "INSERT INTO HoaDonChiTiet12 VALUES('" + mahd + "','" + mahang + "','" + soluong + "')";
            dal.ExecuteNonQuery(sql);
        }

        //------------------
        //Hien thi du lieu tong bang HoaDonTongHop len datagridview
        public DataTable showDgvHoaDonTongHop()
        {
            string sql = "SELECT * FROM HoaDonTongHop12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
      
        public void InsertHoaDonTongHop(string mahd,string makh,string tenkh,string ngaylaphd,string manv, string tennv,string mahang,string tenhang,string soluong,string dongia,string thanhtien,string tongtien)
        {
            string sql = "INSERT INTO HoaDonTongHop12 VALUES ('" + mahd + "','" + makh + "',N'" + tenkh + "','" + ngaylaphd + "','" + manv + "',N'" + tennv + "','" + mahang + "','" + tenhang + "','" + soluong + "','" + dongia + "','" + thanhtien + "','" + tongtien + "')";
            dal.ExecuteNonQuery(sql);
        } 
    }
}

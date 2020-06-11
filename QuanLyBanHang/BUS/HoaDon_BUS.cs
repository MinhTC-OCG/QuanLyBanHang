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


        /**
         * INSERT, UPDATE, DELETE in ThongTinHang12 table
        **/
        public DataTable GetThongtinhang()
        {
            string sql = "select * from ThongTinHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertThongtinhang(string mah, string tenhang, int soluong, int dongia, int thanhtien)
        {
            string sql = "INSERT INTO ThongTinHang12 VALUES ('" + mah + "',N'" + tenhang + "','" + soluong + "','" + dongia + "','" + thanhtien + "')";
            dal.ExecuteNonQuery(sql);
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

        public void DeleteAllCart()
        {
            string sql = "DELETE ThongTinHang12";
            dal.ExecuteNonQuery(sql);
        }



        /**
         * INSERT, UPDATE, DELETE in HoaDon12 table
        **/
        public DataTable GetAmountHD()
        {
            string sql = "SELECT * FROM HoaDon12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertHD(string mahd, string makh, string ngaylap, string manv)
        {
            string sql = "INSERT INTO HoaDon12 VALUES('" + mahd + "','" + makh + "','" + ngaylap + "','" + manv + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void UpdateHD(string mahd, string makh, string ngaylap, string manv)
        {
            string sql = "UPDATE HoaDon12 SET MaKH='" + makh + "',NgayLap='" + ngaylap + "',MaNV='" + manv + "' WHERE MaHD ='" + mahd + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteHD(string mahd)
        {
            string sql = "DELETE HoaDon12 WHERE MaHD ='" + mahd + "'";
            dal.ExecuteNonQuery(sql);
        }

        /**
         * INSERT, UPDATE, DELETE in HoaDonChiTiet12 table
        **/
        public void InsertHDChiTiet(string mahd, string mahang, int soluong)
        {
            string sql = "INSERT INTO HoaDonChiTiet12 VALUES('" + mahd + "','" + mahang + "','" + soluong + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void UpdateHDChiTiet(string mahd, string mahang, int soluong)
        {
            string sql = "UPDATE HoaDonChiTiet12 SET SoLuong='" + soluong + "' WHERE MaHD='"+mahd+"' AND MaH='"+mahang+"'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteHDChiTiet(string mahd)
        {
            string sql = "DELETE HoaDonChiTiet12 WHERE MaHD ='" + mahd+"'";
            dal.ExecuteNonQuery(sql);
        }

        /**
         * INSERT, UPDATE, DELETE in HoaDonTongHop12 table
        **/
        public DataTable showDgvHoaDonTongHop()
        {
            string sql = "SELECT * FROM HoaDonTongHop12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertHoaDonTongHop(string mahd, string makh, string tenkh, string ngaylaphd, string manv, string tennv, string mahang, string tenhang, int soluong, int dongia, int thanhtien, string tongtien)
        {
            string sql = "INSERT INTO HoaDonTongHop12 VALUES ('" + mahd + "','" + makh + "',N'" + tenkh + "','" + ngaylaphd + "','" + manv + "',N'" + tennv + "','" + mahang + "',N'" + tenhang + "','" + soluong + "','" + dongia + "','" + thanhtien + "','" + tongtien + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void UpdateHoaDonTongHop(string mahd, string makh, string tenkh, string ngaylaphd, string manv, string tennv, string mahang, string tenhang, int soluong, int dongia, int thanhtien, string tongtien)
        {
            string sql = "UPDATE HoaDonTongHop12 SET " +
                "MaKH='" + makh +
                "',TenKH=N'" + tenkh +
                "',NgayLapHD ='" + ngaylaphd +
                "',MaNV='" + manv +
                "',TenNV=N'" + tennv +
                "',MaHang='" + mahang +
                "',TenHangHD=N'" + tenhang +
                "',SoLuongHD='" + soluong +
                "',DonGiaHD='" + dongia +
                "',ThanhTienHD='" + thanhtien +
                "',TongTienHD='" + tongtien +
                "' WHERE MaHD ='" + mahd + "' AND MaHang ='"+mahang+"'";
            dal.ExecuteNonQuery(sql);
        }

        public void UpdateHoaDonTongHop2(string mahd, string ngaylaphd,string tongtien)
        {
            string sql = "UPDATE HoaDonTongHop12 SET " +
                "NgayLapHD ='" + ngaylaphd +
                "',TongTienHD='" + tongtien +
                "' WHERE MaHD ='" + mahd + "'";
            dal.ExecuteNonQuery(sql);
        }

        
        public void DeleteHoaDonTongHop(string mahd)
        {
            string sql = "DELETE HoaDonTongHop12 WHERE MaHD ='" + mahd + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchHD(string mahd)
        {
            string sql = "SELECT * FROM HoaDonTongHop12 WHERE MaHD = '" + mahd + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }


        /**
         * INSERT to LichSuHang12
         */
         public void InsertLichSuHang(string mahang,string tenhang,int soluongcon,string ngaycapnhat)
        {
            string sql = "INSERT INTO LichSuHang12 VALUES('"+ mahang+"',N'"+tenhang+"','"+soluongcon+"','" + ngaycapnhat + "'";
            dal.ExecuteNonQuery(sql);
        }
    }
}

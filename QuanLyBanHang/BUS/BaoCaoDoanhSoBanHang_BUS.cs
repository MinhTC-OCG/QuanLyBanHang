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
    public class BaoCaoDoanhSoBanHang_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable ShowBaoCaoDoanhSoHang()
        {
            string sql = "Select * from DoanhSoBanHangTheoHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable ShowBaoCaoDoanhSoNhanVien()
        {
            string sql = "select nv.MaNV, nv.HoTen,hd.MaHD,HD.NgayLap,kh.HoTen,hdct.SoLuong,h.MaH,h.TenH,h.DonG, sum(hdct.SoLuong * h.DonG ) as'Tong' from HoaDon12 hd inner join NhanVien12 nv on hd.MaNV=nv.MaNV "+
                          " inner join KhachHang12 kh on hd.MaKH = kh.MaKH "
                        + " inner join HoaDonChiTiet12 hdct on hd.MaHD = hdct.MaHD "
                        + " inner join Hang12 h on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH "
                        + " Group by  nv.MaNV, nv.HoTen,hd.MaHD,HD.NgayLap,kh.HoTen,hdct.SoLuong,h.MaH,h.TenH,h.DonG";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

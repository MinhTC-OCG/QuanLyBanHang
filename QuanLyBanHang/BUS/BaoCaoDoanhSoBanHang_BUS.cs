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
            string sql = "select hd.NgayLap as 'Ngày lập',h.MaH as'Mã hàng',h.TenH as 'Tên hàng',lh.TenL as'Tên loại',ncc.TenNCC as'Nhà cung cấp',hd.MaHD as'Mã hóa đơn',nv.HoTen as'Họ tên NV',kh.HoTenKH as'Họ tên KH',h.DonG as 'Đơn giá',hdct.SoLuong as 'Số lượng', sum(hdct.SoLuong * h.DonG ) as'Tổng tiền'  from HoaDon12 hd inner join NhanVien12 nv on hd.MaNV=nv.MaNV  inner join KhachHang12 kh on hd.MaKH = kh.MaKH  inner join HoaDonChiTiet12 hdct on hd.MaHD = hdct.MaHD inner join Hang12 h on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH inner join NhaCungCap12 ncc on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH and h.MaNCC=ncc.MaNCC inner join LoaiHang12 lh on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH and h.MaL= lh.MaL group by hd.NgayLap,h.MaH,h.TenH,lh.TenL,ncc.TenNCC,hd.MaHD,nv.HoTen,kh.HoTenKH,ncc.MaNCC,hdct.SoLuong,h.DonG";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable DanhSachHangTheoThang(String year, String month)
        {
            string sql = "select hd.NgayLap as 'Ngày lập',h.MaH as'Mã hàng',h.TenH as 'Tên Hàng',lh.TenL as'Tên loại',ncc.TenNCC as'Nhà cung cấp',hd.MaHD as'Mã hóa đơn',nv.HoTen as'Họ tên NV',kh.HoTenKH as'Họ tên KH',h.DonG as 'Đơn giá',hdct.SoLuong as 'Số lượng', sum(hdct.SoLuong * h.DonG ) as'Tổng tiền' from HoaDon12 hd inner join NhanVien12 nv on hd.MaNV=nv.MaNV  inner join KhachHang12 kh on hd.MaKH = kh.MaKH  inner join HoaDonChiTiet12 hdct on hd.MaHD = hdct.MaHD inner join Hang12 h on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH inner join NhaCungCap12 ncc on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH and h.MaNCC=ncc.MaNCC inner join LoaiHang12 lh on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH and h.MaL= lh.MaL group by hd.NgayLap,h.MaH,h.TenH,lh.TenL,ncc.TenNCC,hd.MaHD,nv.HoTen,kh.HoTenKH,ncc.MaNCC,hdct.SoLuong,h.DonG having YEAR(hd.NgayLap)="+year+" and MONTH(hd.NgayLap)="+month+" ";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable ShowBaoCaoDoanhSoNhanVien()
        {
            string sql = "select HD.NgayLap as 'Ngày lập',nv.MaNV as 'Mã NV', nv.HoTen as 'Họ tên NV',hd.MaHD as 'Mã hóa đơn',kh.HoTenKH as 'Họ tên KH',h.MaH  as 'Mã hàng',h.TenH as 'Tên hàng',hdct.SoLuong as 'Số lượng',h.DonG as 'Đơn giá', sum(hdct.SoLuong * h.DonG ) as'Tổng tiền' from HoaDon12 hd inner join NhanVien12 nv on hd.MaNV=nv.MaNV  inner join KhachHang12 kh on hd.MaKH = kh.MaKH  inner join HoaDonChiTiet12 hdct on hd.MaHD = hdct.MaHD  inner join Hang12 h on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH  Group by  nv.MaNV , nv.HoTen,hd.MaHD,HD.NgayLap,kh.HoTenKH,hdct.SoLuong,h.MaH,h.TenH,h.DonG";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable DanhSachNhanVienTheoThang(String year, String month)
        {
            string sql = "select HD.NgayLap as 'Ngày lập',nv.MaNV as 'Mã NV', nv.HoTen as 'Họ tên NV',hd.MaHD as 'Mã hóa đơn',kh.HoTenKH as 'Họ tên KH',h.MaH  as 'Mã hàng',h.TenH as 'Tên hàng',hdct.SoLuong as 'Số lượng',h.DonG as 'Đơn giá', sum(hdct.SoLuong * h.DonG ) as'Tổng tiền' from HoaDon12 hd inner join NhanVien12 nv on hd.MaNV=nv.MaNV  inner join KhachHang12 kh on hd.MaKH = kh.MaKH  inner join HoaDonChiTiet12 hdct on hd.MaHD = hdct.MaHD  inner join Hang12 h on hd.MaHD = hdct.MaHD and hdct.MaH = h.MaH  Group by  nv.MaNV , nv.HoTen,hd.MaHD,HD.NgayLap,kh.HoTenKH,hdct.SoLuong,h.MaH,h.TenH,h.DonG  having YEAR(hd.NgayLap)=" +year+ " and MONTH(hd.NgayLap)="+month+" ";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

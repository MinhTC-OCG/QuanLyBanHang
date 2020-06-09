using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BCHTonThang_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable BCTonThang(string year,string month)
        {
            //string sql = "Select Hang12.MaH,Hang12.TenH,Hang12.DonVT,Hang12.SLC,LoaiHang12.GhiChu From Hang12 " +
            //    "inner join LoaiHang12 on Hang12.MaL=LoaiHang12.MaL "+
            //    "inner join HoaDonChiTiet12 on Hang12.MaH = HoaDonChiTiet12.MaH "+
            //    "inner join HoaDon12 on HoaDonChiTiet12.MaHD = HoaDon12.MaHD "+
            //    "where (YEAR(NgayLap) ='"+year+ "' AND MONTH(NgayLap) ='"+month+"')" + " OR Hang12.SLC != 0";

            string sql = "SELECT * from LichSuHang12 where (YEAR(NgayCapNhat) ='" + year + "' AND MONTH(NgayCapNhat) ='" + month + "')";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

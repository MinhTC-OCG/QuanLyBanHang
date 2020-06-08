using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BaoCao_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable GetReport(string ngaylap)
        {
            string sql = "SELECT Hang12.MaH,Hang12.TenH,Hang12.DonVT,Hang12.DonG," +
                "SUM(HoaDonChiTiet12.SoLuong) as SoLuongBan,SUM(HoaDonChiTiet12.Soluong*Hang12.DonG) as ThanhTien " +
                "FROM Hang12 INNER JOIN HoaDonChiTiet12 ON Hang12.MaH = HoaDonChiTiet12.MaH INNER JOIN HoaDon12 ON HoaDonChiTiet12.MaHD = HoaDon12.MaHD " +
                "WHERE NgayLap ='"+ngaylap+"'" + " GROUP BY Hang12.MaH, Hang12.TenH,Hang12.DonVT,Hang12.DonG";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

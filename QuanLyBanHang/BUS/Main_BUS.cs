using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class Main_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable GetAmount_Hang()
        {
            string sql = "SELECT COUNT(*) as SoMatHang, SUM(SLC) as TongHang FROM Hang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetAmount_KhachHang()
        {
            string sql = "SELECT COUNT(*) as TongKH FROM KhachHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetAmount_NhanVien()
        {
            string sql = "SELECT COUNT(*) as TongNhanVien FROM NhanVien12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

    }
}

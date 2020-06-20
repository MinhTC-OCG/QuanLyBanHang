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
    }
}

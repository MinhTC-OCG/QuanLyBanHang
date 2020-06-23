using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DangKy_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public void DangKyMatKhau(string tendangnhap, string matkhau, int quyen, string sdtdangky)
        {
            string sql = "insert into DangNhap12 values('"+tendangnhap+"','"+matkhau+"','"+quyen+"','"+sdtdangky+"')";
            dal.ExecuteNonQuery(sql);
        }
        public DataTable KiemTra()
        {
            string sql = "select TenDN,SoDTDK from DangNhap12";
            DataTable dtcb = new DataTable();
            dtcb.Clear();
            dtcb = dal.getTable(sql);
            return dtcb;
        }
    }
}

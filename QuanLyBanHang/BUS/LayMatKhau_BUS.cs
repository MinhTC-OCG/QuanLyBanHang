using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class LayMatKhau_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable getTaiKhoan()
        {
            string sql = "SELECT * FROM DangNhap12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void UpdateMatKhau(string tendangnhap, string matkhau,string sdtdangky)
        {
            string sql = "update DangNhap12 set MatKhau='" + matkhau + "' WHERE TenDN = '" + tendangnhap + "' AND SoDTDK='" + sdtdangky + "'";
            dal.ExecuteNonQuery(sql);
        }
    }
}

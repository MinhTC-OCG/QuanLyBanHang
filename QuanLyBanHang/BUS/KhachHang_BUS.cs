using DAL;
using System.Data;

namespace BUS
{
    public class KhachHang_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable ShowKhachHang()
        {
            string sql = "Select * from KhachHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void InsertKhachHang(string makhachhang, string hoten, string diachi, string sodienthoai)
        {
            string sql = "insert into KhachHang12 values('" + makhachhang + "',N'" + hoten + "',N'" + diachi + "','" + sodienthoai + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void UpdateKhachHang(string makhachhang, string hoten, string diachi, string sodienthoai)
        {
            string sql = "update KhachHang12 set HoTen=N'" + hoten + "',DiaChi=N'" + diachi + "',SoDT='" + sodienthoai + "' where MaKH=N'" + makhachhang + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteKhachHang(string makhachhang)
        {
            string sql = "delete from dbo.KhachHang12 where MaKH='" + makhachhang + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchKhachHang(string makhachhang)
        {
            string sql = "SELECT * FROM KhachHang12 where MaKH='" + makhachhang + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

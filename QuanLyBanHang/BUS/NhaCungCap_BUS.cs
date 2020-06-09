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
    public class NhaCungCap_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        public DataTable ShowNhaCungCap()
        {
            string sql = "SELECT * FROM NhaCungCap12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertNhaCungCap(string mancc, string tenncc, string diachi, string sodt)
        {
            string sql = "INSERT INTO NhaCungCap12 VALUES ('" + mancc + "',N'" + tenncc + "',N'" + diachi + "',N'" + sodt + "')";
            dal.ExecuteNonQuery(sql);
        }


        public void UpdateNhaCungCap(string mancc, string tenncc, string diachi, string sodt)
        {
            string sql = "UPDATE NhaCungCap12 SET TenNCC = N'" + tenncc + "',diachi = N'" + diachi + "',sodt = N'" + sodt + "' WHERE mancc = '" + mancc + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteNhaCungCap(string mancc)
        {
            string sql = "DELETE NhaCungCap12 WHERE MaNCC = '" + mancc + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchNhaCungCap(string key)
        {
            string sql = "SELECT * FROM NhaCungCap12 WHERE MaNCC like N'%" + key + "%'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

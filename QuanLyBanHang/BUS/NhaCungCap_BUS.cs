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
            string sql = "SELECT * FROM Nhacungcap12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertNhaCungCap(string mancc, string tenncc, string diachi, int sodt)
        {
            string sql = "INSERT INTO Nhacungcap12 VALUES ('" + mancc + "',N'" + tenncc + "',N'" + diachi + "',N'" + sodt + "')";
            dal.ExecuteNonQuery(sql);
        }


        public void UpdateNhaCungCap(string mancc, string tenncc, string diachi, int sodt)
        {
            string sql = "UPDATE Nhacungcap12 SET TenNCC = N'" + tenncc + "',diachi = N'" + diachi + "',sodt = N'" + sodt + "' WHERE mancc = '" + mancc + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteNhaCungCap(string mancc)
        {
            string sql = "DELETE Nhacungcap12 WHERE mancc = '" + mancc + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchNhaCungCap(string mancc)
        {
            string sql = "SELECT *FROM Nhacungcap12 WHERE mancc like '%" + mancc + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

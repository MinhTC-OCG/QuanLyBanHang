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
    public class NhanVien_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        public DataTable ShowNhanVien()
        {
            string sql = "SELECT * FROM Nhanvien12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertNhanVien(string manv, string hoten, string diachi, string sodt, string matd)
        {
            string sql = "INSERT INTO Nhanvien12 VALUES ('" + manv + "',N'" + hoten + "',N'" + diachi + "',N'" + sodt + "',N'" + matd + "')";
            dal.ExecuteNonQuery(sql);
        }


        public void UpdateNhanvien(string manv, string hoten, string diachi, string sodt, string matd)
        {
            string sql = "UPDATE Nhanvien12 SET hoten = N'" + hoten + "',diachi = N'" + diachi + "',sodt = N'" + sodt + "',matd = N'" + matd + "' WHERE manv = '" + manv + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteNhanVien(string manv)
        {
            string sql = "DELETE Nhanvien12 WHERE manv = '" + manv + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchNhanVien(string manv)
        {
            string sql = "SELECT *FROM Nhanvien12 WHERE manv like '%" + manv + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

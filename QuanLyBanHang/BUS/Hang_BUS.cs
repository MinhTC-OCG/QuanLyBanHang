using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class Hang_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        public DataTable ShowHang()
        {
            string sql = "SELECT * FROM Hang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetComboLoaiHang()
        {
            string sql = "SELECT * FROM LoaiHang12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public DataTable GetComboNhaCungCap()
        {
            string sql = "SELECT * FROM NhaCungCap12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }

        public void InsertHang(string mahang, string tenhang, string donvt,int dongia,string maloai,string mancc, int soluongco)
        {
            string sql = "INSERT INTO Hang12 VALUES ('" + mahang + "',N'" + tenhang + "',N'" + donvt +"','"+ dongia +"','"+ maloai +"','"+ mancc +"','"+ soluongco + "')";
            dal.ExecuteNonQuery(sql);
        }


        public void UpdateHang(string mahang, string tenhang, string donvt, int dongia, string maloai, string mancc, int soluongco)
        {
            string sql = "UPDATE Hang12 SET TenH =N'"+tenhang+"',DonVT=N'"+donvt+"',DonG="+dongia+",MaL='"+maloai+"', MaNCC= '"+mancc+"', SLC="+soluongco+"' WHERE MaH ='"+mahang;
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteHang(string mahang)
        {
            string sql = "DELETE Hang12 WHERE MaH = '" + mahang + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchHang(string mahang)
        {
            string sql = "SELECT *FROM Hang12 WHERE MaH = '" + mahang + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

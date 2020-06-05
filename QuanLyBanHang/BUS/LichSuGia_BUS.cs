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
    public class LichSuGia_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable ShowLichSuGia()
        {
            string sql = "select * from dbo.LichSuGia12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void InsertLichSuGia(string mahang, string ngaybatdau, string ngayketthuc, int dongia,string ngaycapnhat)
        {
            string sql = "Insert into LichSuGia12 values('"+ mahang +"','"+ngaybatdau+"','"+ngayketthuc+"',20000,'"+ngaycapnhat+"')";
            dal.ExecuteNonQuery(sql);
        }


    }
}

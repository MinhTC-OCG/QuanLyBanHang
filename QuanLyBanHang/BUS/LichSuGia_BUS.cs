
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
        public DataTable GetDataHang()
        {
            string sql = "select * from Hang12";
            DataTable dtcb = new DataTable();
            dtcb = dal.getTable(sql);
            return dtcb;
        }

        public DataTable GetMa(String tenhang)
        {
            string sql = "select MaH from Hang12 where TenH= N'" + tenhang + "'";
            DataTable dtcb = new DataTable();
            dtcb.Clear();
            dtcb = dal.getTable(sql);
            return dtcb;
        }
        public DataTable GetTen(String mahang)
        {
            string sql = "select TenH from Hang12 where MaH= N'" + mahang + "'";
            DataTable dtcb = new DataTable();
            dtcb.Clear();
            dtcb = dal.getTable(sql);
            return dtcb;
        }

        public DataTable InsertLichSuGia(string mahang, String ngaybatdau, string ngayketthuc, int dongia, string ngaycapnhat)
        {
            DataTable dtNgay = new DataTable();
            dtNgay.Clear();
            string sql = " Declare @ERROR int"
                          + " exec insertlsgia '" + mahang + "','" + ngaybatdau + "','" + ngayketthuc + "'," + dongia + ",'" + ngaycapnhat + "',@ERROR output"
                          + " select @ERROR";
            dtNgay = dal.getTable(sql);
            return dtNgay;
        }
        public DataTable UpdateLichSuGia(string mahang, string ngaybatdau, string ngayketthuc, int dongia, string ngaycapnhat, String ngaybatdaucu)
        {
            DataTable dtNgay1 = new DataTable();
            dtNgay1.Clear();
            string sql = " Declare @ERROR int"
                        + " exec updatelsgia '" + mahang + "','" + ngaybatdau + "','" + ngayketthuc + "'," + dongia + ",'" + ngaycapnhat + "','" + ngaybatdaucu + "',@ERROR output"
                        + " select @ERROR";
            dtNgay1 = dal.getTable(sql);
            return dtNgay1;
        }

        public void DeleteLichSuGia(string mahang, String ngaybatdau)
        {
            string sql = "delete from LichSuGia12 where MaH='" + mahang + "' and NgayBD='" + ngaybatdau + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable SearchLichSuHang(string mahang)
        {
            string sql = "SELECT * FROM LichSuGia12 where MaH='" + mahang + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
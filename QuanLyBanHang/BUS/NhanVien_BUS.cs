using DAL;
using System.Data;
namespace BUS
{
    public class NhanVien_BUS {
        Lop_DAL dal = new Lop_DAL();
        public DataTable ShowNhanVien() {
            string sql = "SELECT * FROM NhanVien12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt; }
        public DataTable GetComboTrinhDo() {
            string sql = "SELECT * FROM TrinhDo12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt; }
        public void InsertNhanVien(string manv, string hoten, string diachi, string sodt, string matd) {
            string sql = "INSERT INTO NhanVien12 VALUES ('" + manv + "',N'" + hoten + "',N'" + diachi + "',N'" + sodt + "',N'" + matd + "')";
            dal.ExecuteNonQuery(sql);}
        public void UpdateNhanvien(string manv, string hoten, string diachi, string sodt, string matd) {
            string sql = "UPDATE NhanVien12 SET hoten = N'" + hoten + "',diachi = N'" + diachi + "',sodt = N'" + sodt + "',matd = N'" + matd + "' WHERE manv = '" + manv + "'";
            dal.ExecuteNonQuery(sql); }
        public void DeleteNhanVien(string manv) {
            string sql = "DELETE NhanVien12 WHERE manv = '" + manv + "'";
            dal.ExecuteNonQuery(sql);}
        public DataTable SearchNhanVien(string manv) {
            string sql = "SELECT * FROM NhanVien12 WHERE manv like '%" + manv + "%'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt; }  }}

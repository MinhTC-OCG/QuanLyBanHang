using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class linq
    {
        dbDataContext db = new dbDataContext();


        public List<LoaiHang_DTO> ShowLoaiHang()
        {
           var query = from lh in db.LoaiHang12s select new LoaiHang_DTO{Maloai=lh.MaL,Tenloai=lh.TenL,Ghichu = lh.GhiChu};
            return query.ToList();
        }

        public void InsertLoaiHang_LinQ(string maloai, string tenloai, string ghichu)
        {

            LoaiHang12 them = new LoaiHang12();
            them.MaL = maloai;
            them.TenL = tenloai;
            them.GhiChu = ghichu;
            db.LoaiHang12s.InsertOnSubmit(them);
            db.SubmitChanges();
        }

        public void UpdateLoaiHang_LinQ(string maloai, string tenloai, string ghichu)
        {
            var sua = db.LoaiHang12s.Single(lh => lh.MaL == maloai.Trim());
            //sua.MaL = maloai;
            sua.TenL = tenloai;
            sua.GhiChu = ghichu;
            db.SubmitChanges();
        }

        public void DeleteLoaiHang_LinQ(string maloai)
        {
            var xoa = from lh in db.LoaiHang12s where lh.MaL == maloai select lh;
            foreach (var i in xoa)
            {
                db.LoaiHang12s.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
        }

        public List<LoaiHang_DTO>SearchLoaiHang(string maloai)
        {
            var query = from lh in db.LoaiHang12s where lh.MaL.Trim() == maloai.Trim() select new LoaiHang_DTO { Maloai = lh.MaL, Tenloai = lh.TenL, Ghichu = lh.GhiChu };
            return query.ToList();
        }

        //TrinhDo LinQ
        public List<TrinhDo_DTO> ShowTrinhDo()
        {
            var query = from td in db.TrinhDo12s select new TrinhDo_DTO { MaTD_1 = td.MaTD, TenTD1 = td.TenTD };
            return query.ToList();
        }

        public void InsertTrinhDo_LinQ(string matd, string tentd)
        {

            TrinhDo12 them = new TrinhDo12();
            them.MaTD = matd;
            them.TenTD = tentd;
            db.TrinhDo12s.InsertOnSubmit(them);
            db.SubmitChanges();
        }

        public void UpdateTrinhDo_Linq(string matd, string tentd)
        {
            var sua = db.TrinhDo12s.Single(td => td.MaTD == matd.Trim());
            //sua.MaL = maloai;
            sua.TenTD = tentd;
            db.SubmitChanges();
        }

        public void DeleteTrinhDo_LinQ(string matd)
        {
            var xoa = from td in db.TrinhDo12s where td.MaTD == matd select td;
            foreach (var i in xoa)
            {
                db.TrinhDo12s.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
        }

        public List<TrinhDo_DTO> SearchTrinhDo(string matd)
        {
            var query = from td in db.TrinhDo12s where td.MaTD.Trim() == matd.Trim() select new TrinhDo_DTO { MaTD_1 = td.MaTD, TenTD1 = td.TenTD };
            return query.ToList();
        }
    }
}

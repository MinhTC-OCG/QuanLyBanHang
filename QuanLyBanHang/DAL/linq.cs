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
            sua.MaL = maloai;
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
    }
}

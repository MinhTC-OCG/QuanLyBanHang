using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class BCHTonThang
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable BCTonThang(string date)
        {
            string sql = "Select Hang12.MaH,Hang12.TenH,Hang12.DonVT,Hang12.SLC,LoaiHang12.GhiChu From Hang12 inner join LoaiHang12 " +
                "on Hang12.MaL=LoaiHang12.MaL Where ";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}

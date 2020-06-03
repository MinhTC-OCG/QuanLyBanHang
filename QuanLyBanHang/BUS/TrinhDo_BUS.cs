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
    public class TrinhDo_BUS
    {
        Lop_DAL dal = new Lop_DAL();

        //Lấy thông tin trong bảng TrinhDo đổ  lên  datagridview
          public DataTable ShowTrinhDo()
        {
            string sql = "SELECT * FROM TrinhDo12";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }


}

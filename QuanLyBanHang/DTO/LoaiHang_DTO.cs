using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiHang_DTO
    {
        string maloai, tenloai, ghichu;

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang_DTO
    {

        string maloai, tenloai, ghichu;

        public LoaiHang_DTO()
        {
        }

        public LoaiHang_DTO(string maloai, string tenloai, string ghichu)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.ghichu = ghichu;
        }

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}

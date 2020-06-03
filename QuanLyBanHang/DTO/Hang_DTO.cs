using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang_DTO
    {
        string mahang, tenhang, donvt;
        int dongia;
        string maloai;
        string mancc;
        int soluongco;
        public Hang_DTO()
        {

        }

        public Hang_DTO(string mahang, string tenhang, string donvt, int dongia, string maloai, string mancc, int soluongco)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.donvt = donvt;
            this.dongia = dongia;
            this.maloai = maloai;
            this.mancc = mancc;
            this.soluongco = soluongco;
        }

        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Donvt { get => donvt; set => donvt = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public int Soluongco { get => soluongco; set => soluongco = value; }
    }
}

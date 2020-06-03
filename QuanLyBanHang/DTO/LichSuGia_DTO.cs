using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LichSuGia_DTO
    {
        String Mahang_, NgayBatDau_, NgayKetThuc_, NgayCapNhat_ ;
        int DonGia_;

        public LichSuGia_DTO(string mahang_, string ngayBatDau_, string ngayKetThuc_, string ngayCapNhat_, int donGia_)
        {
            Mahang_ = mahang_;
            NgayBatDau_ = ngayBatDau_;
            NgayKetThuc_ = ngayKetThuc_;
            NgayCapNhat_ = ngayCapNhat_;
            DonGia_ = donGia_;
        }

        public string Mahang_1 { get => Mahang_; set => Mahang_ = value; }
        public string NgayBatDau_1 { get => NgayBatDau_; set => NgayBatDau_ = value; }
        public string NgayKetThuc_1 { get => NgayKetThuc_; set => NgayKetThuc_ = value; }
        public string NgayCapNhat_1 { get => NgayCapNhat_; set => NgayCapNhat_ = value; }
        public int DonGia_1 { get => DonGia_; set => DonGia_ = value; }
    }
}

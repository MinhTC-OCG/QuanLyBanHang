﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LichSuGia_DTO
    {
        String MaHang_ ,NgayBatDau_, NgayKetThuc_, NgayCapNhat_;
        int DonGia_;

        public LichSuGia_DTO(string maHang_, string ngayBatDau_, string ngayKetThuc_, string ngayCapNhat_, int donGia_)
        {
            MaHang_ = maHang_;
            NgayBatDau_ = ngayBatDau_;
            NgayKetThuc_ = ngayKetThuc_;
            NgayCapNhat_ = ngayCapNhat_;
            DonGia_ = donGia_;
        }

        public string MaHang_1 { get => MaHang_; set => MaHang_ = value; }
        public string NgayBatDau_1 { get => NgayBatDau_; set => NgayBatDau_ = value; }
        public string NgayKetThuc_1 { get => NgayKetThuc_; set => NgayKetThuc_ = value; }
        public string NgayCapNhat_1 { get => NgayCapNhat_; set => NgayCapNhat_ = value; }
        public int DonGia_1 { get => DonGia_; set => DonGia_ = value; }
    }
}

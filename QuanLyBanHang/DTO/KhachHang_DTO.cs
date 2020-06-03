using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHang_DTO
    {
        String MaKhachHang_, HoTen_, DiaChi, SoDienThoai_;

        public KhachHang_DTO(string maKhachHang_, string hoTen_, string diaChi, string soDienThoai_)
        {
            MaKhachHang_ = maKhachHang_;
            HoTen_ = hoTen_;
            DiaChi = diaChi;
            SoDienThoai_ = soDienThoai_;
        }

        public string MaKhachHang_1 { get => MaKhachHang_; set => MaKhachHang_ = value; }
        public string HoTen_1 { get => HoTen_; set => HoTen_ = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SoDienThoai_1 { get => SoDienThoai_; set => SoDienThoai_ = value; }
    }
}

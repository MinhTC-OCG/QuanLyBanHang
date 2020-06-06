using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        String MaKhachHang_, HoTen_,DiaChi_,SoDienThoai_;

        public KhachHang_DTO(string maKhachHang_, string hoTen_, string diaChi_, string soDienThoai_)
        {
            MaKhachHang_ = maKhachHang_;
            HoTen_ = hoTen_;
            DiaChi_ = diaChi_;
            SoDienThoai_ = soDienThoai_;
        }

        public string MaKhachHang_1 { get => MaKhachHang_; set => MaKhachHang_ = value; }
        public string HoTen_1 { get => HoTen_; set => HoTen_ = value; }
        public string DiaChi_1 { get => DiaChi_; set => DiaChi_ = value; }
        public string SoDienThoai_1 { get => SoDienThoai_; set => SoDienThoai_ = value; }
    }
}

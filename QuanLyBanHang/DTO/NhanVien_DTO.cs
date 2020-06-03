using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien_DTO
    {
        string MaNV_, HoTen_, DiaChi_,MaTD_;
        int SoDT_;

        public string MaNV { get => MaNV_; set => MaNV_ = value; }
        public string HoTen { get => HoTen_; set => HoTen_ = value; }
        public string DiaChi { get => DiaChi_; set => DiaChi_ = value; }
        public string MaTD { get => MaTD_; set => MaTD_ = value; }
        public int SoDT { get => SoDT; set => SoDT = value; }
    }
}

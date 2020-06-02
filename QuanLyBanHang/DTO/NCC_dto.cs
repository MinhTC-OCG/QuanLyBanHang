using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NCC_dto
    {
        string MaNCC_, TenNCC_, DiaChi_;
        int SoDT_;

        public string MaNCC { get => MaNCC_; set => MaNCC_ = value; }
        public string TenNC { get => TenNCC_; set => TenNCC_ = value; }
        public string DiaChi { get => DiaChi_; set => DiaChi_ = value; }
        public int SoDT { get => SoDT_; set => SoDT_ = value; }
    }
}

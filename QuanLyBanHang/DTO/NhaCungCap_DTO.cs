using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhaCungCap_DTO
    {
        string MaNCC_,TenNCC_,DiaChi_;
        int SoDT_;

        public string MaNCC { get => MaNCC_; set => MaNCC_ = value; }
        public string TenNCC { get => TenNCC_; set => TenNCC_ = value; }
        public string DiaChi { get => DiaChi_; set => DiaChi_ = value; }
        public int SoDT { get => SoDT; set => SoDT = value; }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class KhachHang : Form
    {
        LichSuGia_DTO dto = new LichSuGia_DTO();
        Lop_DAL dal = new Lop_DAL();
        LichSuGia_BUS bus = new LichSuGia_BUS();
        DataTable KhachHang
        public KhachHang()
        {
            InitializeComponent();
        }
        

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khb.ShowKhachHang();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {

        }
    }
}

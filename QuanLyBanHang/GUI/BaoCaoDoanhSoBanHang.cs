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
using DAL;
using DTO;

namespace GUI
{
    public partial class BaoCaoDoanhSoBanHang : Form
    {
        Lop_DAL dal = new Lop_DAL();
        BaoCaoDoanhSoBanHang_BUS bus = new BUS.BaoCaoDoanhSoBanHang_BUS();
        DataTable dtBaoCaoKhachHang;

        public BaoCaoDoanhSoBanHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dtBaoCaoKhachHang = new DataTable();
            dtBaoCaoKhachHang.Clear();
            dtBaoCaoKhachHang = bus.ShowBaoCaoDoanhSoHang();
            dgvDoanhSoHang.DataSource = dtBaoCaoKhachHang;
            dgvDoanhSoHang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
        }

        private void BaoCaoDoanhSoBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

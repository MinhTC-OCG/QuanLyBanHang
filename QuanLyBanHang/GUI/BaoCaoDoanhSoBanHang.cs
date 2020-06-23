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
        DataTable dtBaoCaoHang,dtBaoCaoNhanVien,dtNhanVienTheoThang,dtHangTheoThang;

        public BaoCaoDoanhSoBanHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dtBaoCaoHang = new DataTable();
            dtBaoCaoHang.Clear();
            dtBaoCaoHang = bus.ShowBaoCaoDoanhSoHang();
            dgvDoanhSoHang.DataSource = dtBaoCaoHang;

            dtBaoCaoNhanVien = new DataTable();
            dtBaoCaoNhanVien.Clear();
            dtBaoCaoNhanVien = bus.ShowBaoCaoDoanhSoNhanVien();
            dgvNhanVien.DataSource = dtBaoCaoNhanVien;

            dgvDoanhSoHang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
        }

        private void BaoCaoDoanhSoBanHang_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Hide();
            cbH.Checked = true;
            cbNV.Checked = false;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "MM/yyyy";
            LoadData();
        }
        private void clickCBHang()
        {
            dgvNhanVien.Hide();
            dgvDoanhSoHang.Show();
            cbNV.Checked = false;
        }
        private void clickCBNV()
        {
            dgvNhanVien.Show();
            dgvDoanhSoHang.Hide();
            cbH.Checked = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            lbThang.Text = dtPicker.Value.ToString("MM/yyyy");
            lbNguoiLap.Text = DangNhap.tendangnhap;
            
            dgvNhanVien.DataSource = null;
            dtNhanVienTheoThang = new DataTable();
            dtNhanVienTheoThang = bus.DanhSachNhanVienTheoThang(dtPicker.Value.ToString("yyyy"), dtPicker.Value.ToString("MM"));
            dgvNhanVien.DataSource = dtNhanVienTheoThang;

            dgvDoanhSoHang.DataSource = null;
            dtHangTheoThang = new DataTable();
            dtHangTheoThang = bus.DanhSachHangTheoThang(dtPicker.Value.ToString("yyyy"), dtPicker.Value.ToString("MM"));
            dgvDoanhSoHang.DataSource = dtHangTheoThang;
            

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbNV_CheckedChanged(object sender, EventArgs e)
        {
            
                clickCBNV();
        }

        private void cbH_CheckedChanged(object sender, EventArgs e)
        {
            
                clickCBHang();
        }
    }
}

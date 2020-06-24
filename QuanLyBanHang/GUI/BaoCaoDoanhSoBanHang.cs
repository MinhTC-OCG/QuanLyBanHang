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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class BaoCaoDoanhSoBanHang : Form
    {
        ReportDataSource rs = new ReportDataSource();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<BaoCaoDoanhSo> list = new List<BaoCaoDoanhSo>();
            list.Clear();
            for (int i = 0; i < dgvDoanhSoHang.RowCount; i++)
            {
                BaoCaoDoanhSo bc = new BaoCaoDoanhSo();
                bc.Ngaylap = dgvDoanhSoHang.Rows[i].Cells[0].Value.ToString();
                bc.Manv = dgvDoanhSoHang.Rows[i].Cells[1].Value.ToString();
                bc.Tennv = dgvDoanhSoHang.Rows[i].Cells[2].Value.ToString();
                bc.Mahd = dgvDoanhSoHang.Rows[i].Cells[3].Value.ToString();
                bc.Tenkh = dgvDoanhSoHang.Rows[i].Cells[4].Value.ToString();
                bc.Mahang = dgvDoanhSoHang.Rows[i].Cells[5].Value.ToString();
                bc.Tenhang = dgvDoanhSoHang.Rows[i].Cells[6].Value.ToString();
                bc.Soluong = dgvDoanhSoHang.Rows[i].Cells[7].Value.ToString();
                bc.Dongia = dgvDoanhSoHang.Rows[i].Cells[8].Value.ToString();
                bc.Tongtien = dgvDoanhSoHang.Rows[i].Cells[9].Value.ToString();
                list.Add(bc);

            }
            rs.Name = "DataSet1";
            rs.Value = list;
            ReportBaoCaoDoanhSoBanHang rp = new ReportBaoCaoDoanhSoBanHang();
            rp.reportViewer1.LocalReport.DataSources.Clear();
            rp.reportViewer1.LocalReport.DataSources.Add(rs);
            rp.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBaoCaoDoanhSoBanHang.rdlc";
            rp.ShowDialog();
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

    public class BaoCaoDoanhSo{
        string ngaylap, manv, tennv, mahd, tenkh, mahang, tenhang, soluong, dongia, tongtien;

        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
    }
}

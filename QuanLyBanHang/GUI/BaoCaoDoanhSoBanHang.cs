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
            cbH.Checked = true;
            cbNV.Checked = false;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "MM/yyyy";
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
            dgvDoanhSoHang.DataSource = null;
            
            DateTime dt1 = dtPicker.Value;
            dt1 = new DateTime(dt1.Year, dt1.Month, 1); // get first day of selected month
            DateTime dt2 = dt1.AddMonths(1); // get first day of next month
            int numDays = (dt2 - dt1).Days;

            if (dgvDoanhSoHang.RowCount < numDays)
            {
                dgvDoanhSoHang.RowCount = numDays;
            }

            int row = 0;

            while (dt1 < dt2)
            {
                dgvDoanhSoHang.Rows[row].Cells[0].Value = dt1.ToString("dd/MM/yyyy");
                dt1 = dt1.AddDays(1);
                row++;
            }
            
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class Hang : Form
    {
        Hang_BUS bus = new Hang_BUS();
        Hang_DTO dto = new Hang_DTO();

        DataTable dtHang, dtLoaiHang, dtNhaCungCap, dtTimKiemHang;
        public Hang()
        {
            InitializeComponent();
        }

        private void Hang_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        public void LoadData()
        {
            dtHang = new DataTable();
            dtHang = bus.ShowHang();
            dgvHang.DataSource = dtHang;
        }

        public void LoadComboBox()
        {
            dtLoaiHang = new DataTable();
            dtLoaiHang = bus.GetComboLoaiHang();
            cboMaL.DataSource = dtLoaiHang;
            cboMaL.DisplayMember = "TenL";
            cboMaL.ValueMember = "MaL";

            dtNhaCungCap = new DataTable();
            dtNhaCungCap = bus.GetComboNhaCungCap();
            cboMaNCC.DataSource = dtNhaCungCap;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";

            (dgvHang.Columns["MaL"] as DataGridViewComboBoxColumn).DataSource = dtLoaiHang;
            (dgvHang.Columns["MaL"] as DataGridViewComboBoxColumn).DisplayMember = "TenL";
            (dgvHang.Columns["MaL"] as DataGridViewComboBoxColumn).ValueMember = "MaL";

            (dgvHang.Columns["MaNCC"] as DataGridViewComboBoxColumn).DataSource = dtNhaCungCap;
            (dgvHang.Columns["MaNCC"] as DataGridViewComboBoxColumn).DisplayMember = "TenNCC";
            (dgvHang.Columns["MaNCC"] as DataGridViewComboBoxColumn).ValueMember = "MaNCC";
        }
    }
}

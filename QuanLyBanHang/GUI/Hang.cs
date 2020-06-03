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
        Hang_DTO dto;

        DataTable dtHang, dtLoaiHang, dtNhaCungCap, dtTimKiemHang;
        public Hang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaH.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã loại, nhập lại!");
                else if (txtTenH.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên hàng, nhập lại!");
                else if (txtDonVT.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn vị, nhập lại!");
                else if (txtDonG.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
                else if (txtSLC.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên loại, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtLoaiHang.Rows)
                    {
                        var check = row["MaH"].ToString().Trim();
                        if (txtMaH.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        string mahang = txtMaH.Text;
                        string tenhang = txtTenH.Text;
                        string dongia = txtDonVT.Text;
                        int dongia = txtDonG.Text;
                        string maloai = cboMaL.SelectedValue.ToString();
                        string mancc = cboMaNCC.SelectedValue.ToString();
                        int soluongco = txtSLC.Text;
                        bus.InsertHang(txtMaL.Text, txtTenL.Text, txtGhiChu.Text);
                        MessageBox.Show("Thêm loại hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã loại hàng đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được loại hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaH.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã hàng, nhập lại!");
                else if (txtTenH.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên hàng, nhập lại!");
                else if (txtDonVT.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn vị, nhập lại!");
                else if (txtDonG.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
                else if (txtSLC.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtHang.Rows)
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
                        dto.Mahang = txtMaH.Text;
                        dto.Tenhang = txtTenH.Text;
                        dto.Donvt = txtDonVT.Text;
                        dto.Dongia = Int32.Parse(txtDonG.Text);
                        dto.Maloai = cboMaL.SelectedValue.ToString();
                        dto.Mancc = cboMaNCC.SelectedValue.ToString();
                        dto.Soluongco = Int32.Parse(txtSLC.Text);

                        bus.InsertHang(dto.Mahang, dto.Tenhang, dto.Donvt, dto.Dongia, dto.Maloai, dto.Mancc, dto.Soluongco);
                        MessageBox.Show("Thêm hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaH.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã hàng, nhập lại!");
                else if (txtTenH.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên hàng, nhập lại!");
                else if (txtDonVT.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn vị, nhập lại!");
                else if (txtDonG.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
                else if (txtSLC.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtHang.Rows)
                    {
                        var check = row["MaH"].ToString().Trim();
                        if (txtMaH.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem != 0)
                    {
                        dto.Mahang = txtMaH.Text;
                        dto.Tenhang = txtTenH.Text;
                        dto.Donvt = txtDonVT.Text;
                        dto.Dongia = Int32.Parse(txtDonG.Text);
                        dto.Maloai = cboMaL.SelectedValue.ToString();
                        dto.Mancc = cboMaNCC.SelectedValue.ToString();
                        dto.Soluongco = Int32.Parse(txtSLC.Text);
             
                        bus.InsertHang(dto.Mahang, dto.Tenhang, dto.Donvt, dto.Dongia, dto.Maloai, dto.Mancc, dto.Soluongco);
                        MessageBox.Show("Sửa hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng không tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenH.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.DeleteHang(txtMaH.Text.Trim());
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiemHang = new DataTable();
            dtTimKiemHang = bus.SearchHang(txtMaH.Text);
            dgvHang.DataSource = dtTimKiemHang;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaH.Text = "";
            txtTenH.Text = "";
            txtDonVT.Text = "";
            txtDonG.Text = "";
            txtSLC.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Dispose();
        }

        private void dgvHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = e.RowIndex;
            txtMaH.Text = dgvHang.Rows[r].Cells[0].Value.ToString();
            txtTenH.Text= dgvHang.Rows[r].Cells[1].Value.ToString();
            txtDonVT.Text= dgvHang.Rows[r].Cells[2].Value.ToString();
            txtDonG.Text = dgvHang.Rows[r].Cells[3].Value.ToString();
            cboMaL.SelectedValue = dgvHang.Rows[r].Cells[4].Value.ToString();
            cboMaNCC.SelectedValue= dgvHang.Rows[r].Cells[5].Value.ToString();
            txtSLC.Text = dgvHang.Rows[r].Cells[6].Value.ToString();
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

using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        public NhanVien_BUS bus = new NhanVien_BUS();
        public NhanVien_DTO dto = new NhanVien_DTO();
        DataTable dtNhanVien, dtTrinhDo;
        public void LoadData()
        {
            dtNhanVien = new DataTable();
            dtNhanVien = bus.ShowNhanVien();
            dgvNV.DataSource = dtNhanVien;
        }
        public void LoadComboBox()
        {
            dtTrinhDo = new DataTable();
            dtTrinhDo = bus.GetComboTrinhDo();
            cbMaTD.DataSource = dtTrinhDo;
            cbMaTD.DisplayMember = "TenTD";
            cbMaTD.ValueMember = "MaTD";

            (dgvNV.Columns["MaTD"] as DataGridViewComboBoxColumn).DataSource = dtTrinhDo;
            (dgvNV.Columns["MaTD"] as DataGridViewComboBoxColumn).DisplayMember = "TenTD";
            (dgvNV.Columns["MaTD"] as DataGridViewComboBoxColumn).ValueMember = "MaTD";
        }
        private void bnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSoDT.ResetText();
            txtMaNV.Focus();
        }

        private void dgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = e.RowIndex;
            txtMaNV.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNV.Rows[r].Cells[2].Value.ToString();
            txtSoDT.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã Nhân viên, nhập lại!");
                else if (txtHoTen.Text == "")
                    MessageBox.Show("Bạn chưa nhập họ tên nhân viên, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập địa chỉ, nhập lại!");
                else if (txtSoDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập số điện thoại, nhập lại!");
                else
                {
                    dto.MaNV = txtMaNV.Text;
                    dto.HoTen = txtHoTen.Text;
                    dto.DiaChi = txtDiaChi.Text;
                    dto.MaTD = cbMaTD.SelectedValue.ToString();
                    dto.SoDT = txtSoDT.Text;
                    int dem = 0;
                    foreach (DataRow row in dtNhanVien.Rows)
                    {
                        var check = row["MaNV"].ToString().Trim();
                        if (txtMaNV.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        bus.InsertNhanVien(dto.MaNV, dto.HoTen, dto.DiaChi, dto.SoDT, dto.MaTD);
                        MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được nhân viên, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã Nhân viên, nhập lại!");
                else if (txtHoTen.Text == "")
                    MessageBox.Show("Bạn chưa nhập họ tên nhân viên, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập địa chỉ, nhập lại!");
                else if (txtSoDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập số điện thoại, nhập lại!");
                else
                {
                    dto.MaNV = txtMaNV.Text;
                    dto.HoTen = txtHoTen.Text;
                    dto.DiaChi = txtDiaChi.Text;
                    dto.MaTD = cbMaTD.SelectedValue.ToString();
                    dto.SoDT = txtSoDT.Text;
                    int dem = 0;
                    foreach (DataRow row in dtNhanVien.Rows)
                    {
                        var check = row.ToString().Trim();
                        if (txtMaNV.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        bus.UpdateNhanvien(dto.MaNV, dto.HoTen, dto.DiaChi, dto.SoDT, dto.MaTD);
                        NhanVien_Load_1(sender, e);
                        MessageBox.Show("Cập nhập nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không cập nhật được nhân viên, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Thất bại, chưa nhập mã nhân viên cần xóa!");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa nhân viên \"" + txtHoTen.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.DeleteNhanVien(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
        }

        private void bnTim_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            else
                dgvNV.DataSource = bus.SearchNhanVien(txtMaNV.Text);
        }

        private void bnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NhanVien_Load_1(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

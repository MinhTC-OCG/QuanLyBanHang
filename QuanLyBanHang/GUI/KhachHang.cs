using BUS;
using DAL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI
{
    public partial class KhachHang : Form
    {
        KhachHang_DTO dto = new KhachHang_DTO();
        Lop_DAL dal = new Lop_DAL();
        KhachHang_BUS bus = new KhachHang_BUS();
        DataTable dtKhachHang, dtTimKiemHang;

        public KhachHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dtKhachHang = new DataTable();
            dtKhachHang.Clear();
            dtKhachHang = bus.ShowKhachHang();
            dgvKhachHang.DataSource = dtKhachHang;

        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearText()
        {
            txtMaKhachHang.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhachHang.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã hàng, nhập lại!");
                else if (txtHoTen.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên hàng, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn vị, nhập lại!");
                else if (txtSoDienThoai.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtKhachHang.Rows)
                    {
                        var check = row["MaKH"].ToString().Trim();
                        if (txtMaKhachHang.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        dto.MaKhachHang_1 = txtMaKhachHang.Text;
                        dto.HoTen_1 = txtHoTen.Text;
                        dto.DiaChi_1 = txtDiaChi.Text;
                        dto.SoDienThoai_1 = txtSoDienThoai.Text;

                        bus.InsertKhachHang(dto.MaKhachHang_1, dto.HoTen_1, dto.DiaChi_1, dto.SoDienThoai_1);
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Mã khach hàng đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được khach hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Thất bại, chưa nhập mã khách hàng cần xóa!");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtHoTen.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.DeleteKhachHang(txtMaKhachHang.Text.Trim());
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
        }

        private void btnNhapLai_Click_1(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Dispose();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhachHang.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã hàng, nhập lại!");
                else if (txtHoTen.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên hàng, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập đơn vị, nhập lại!");
                else if (txtSoDienThoai.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtKhachHang.Rows)
                    {
                        var check = row["MaKH"].ToString().Trim();
                        if (txtMaKhachHang.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem != 0)
                    {
                        dto.MaKhachHang_1 = txtMaKhachHang.Text;
                        dto.HoTen_1 = txtHoTen.Text;
                        dto.DiaChi_1 = txtDiaChi.Text;
                        dto.SoDienThoai_1 = txtSoDienThoai.Text;

                        bus.UpdateKhachHang(dto.MaKhachHang_1, dto.HoTen_1, dto.DiaChi_1, dto.SoDienThoai_1);
                        MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Mã khach hàng đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được khach hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = e.RowIndex;
            txtMaKhachHang.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            dtTimKiemHang = new DataTable();
            dtTimKiemHang = bus.SearchKhachHang(txtMaKhachHang.Text);
            dgvKhachHang.DataSource = dtTimKiemHang;
        }

    }
}

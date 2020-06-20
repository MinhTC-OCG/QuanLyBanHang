using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GUI
{
    public partial class LoaiHang : Form
    {
        LoaiHang_BUS bus = new LoaiHang_BUS();
        LoaiHang_DTO lh = new LoaiHang_DTO();
        List<LoaiHang_DTO> list = new List<LoaiHang_DTO>();

        public LoaiHang()
        {
            InitializeComponent();
        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            list = bus.ShowLH();
            dgvLoaiHang.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaL.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã loại, nhập lại!");
                else if (txtTenL.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên loại, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (LoaiHang_DTO lh in list)
                    {
                        if (txtMaL.Text.Trim() == lh.Maloai.Trim())
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem == 0)
                    {
                        bus.InsertLH(txtMaL.Text, txtTenL.Text, txtGhiChu.Text);
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
            try
            {
                if (txtMaL.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã loại, nhập lại!");
                else if (txtTenL.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên loại, nhập lại!");
                else
                {
                    lh.Maloai = txtMaL.Text;
                    lh.Tenloai = txtTenL.Text;
                    lh.Ghichu = txtGhiChu.Text;
                    int dem = 0;
                    foreach (LoaiHang_DTO lh in list)
                    {
                        if (txtMaL.Text.Trim() == lh.Maloai.Trim())
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        bus.UpdateLH(lh.Maloai, lh.Tenloai, lh.Ghichu);
                        LoaiHang_Load(sender, e);
                        MessageBox.Show("Cập nhập loại hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã loại hàng không tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không cập nhật được loại hàng, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaL.Text == "")
            {
                MessageBox.Show("Thất bại, chưa nhập mã loại cần xóa!");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenL.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.DeleteLH(txtMaL.Text);
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Dispose();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaL.Text = "";
            txtTenL.Text = "";
            txtGhiChu.Text = "";
            txtMaL.Focus();
        }

        private void dgvLoaiHang_Click(object sender, EventArgs e)
        {
            dgvLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = dgvLoaiHang.CurrentCell.RowIndex;
            txtMaL.Text = dgvLoaiHang.Rows[r].Cells[0].Value.ToString();
            txtTenL.Text = dgvLoaiHang.Rows[r].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvLoaiHang.Rows[r].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<LoaiHang_DTO> list_tk = new List<LoaiHang_DTO>();
            list_tk = bus.SearchLH(txtMaL.Text);
            dgvLoaiHang.DataSource = list_tk;
        }
    }
}

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
using DAL;
using BUS;
namespace GUI
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap_DTO dto = new NhaCungCap_DTO();
        DataTable dtNhaCungCap;
        public void LoadData()
        {
            dtNhaCungCap = new DataTable();
            dtNhaCungCap = bus.ShowNhaCungCap();
            dgvNCC.DataSource = dtNhaCungCap;
        }
        private void bnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtMaNCC.Focus();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã nhà cung cấp, nhập lại!");
                else if (txtTenNCC.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập địa chỉ, nhập lại!");
                else if (txtSoDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập số điện thoại, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtNhaCungCap.Rows)
                    {
                        var check = row["MaNCC"].ToString().Trim();
                        if (txtMaNCC.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        dto.Mancc = txtMaNCC.Text;
                        dto.Tenncc = txtTenNCC.Text;
                        dto.Diachi= txtDiaChi.Text;
                        dto.Sodt = txtSoDT.Text;
                        bus.InsertNhaCungCap(dto.Mancc, dto.Tenncc, dto.Diachi, dto.Sodt);
                        MessageBox.Show("Thêm Nhà Cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được nhà cung cấp, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã Nhà cung cấp, nhập lại!");
                else if (txtTenNCC.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp, nhập lại!");
                else if (txtDiaChi.Text == "")
                    MessageBox.Show("Bạn chưa nhập địa chỉ, nhập lại!");
                else if (txtSoDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập số điện thoại, nhập lại!");
                else
                {
                    dto.Mancc = txtMaNCC.Text;
                    dto.Tenncc = txtTenNCC.Text;
                    dto.Diachi = txtDiaChi.Text;
                    dto.Sodt = txtSoDT.Text;
                    int dem = 0;
                    foreach (DataRow row in dtNhaCungCap.Rows)
                    {
                        foreach (DataColumn c in dtNhaCungCap.Columns)
                        {
                            var check = row[c].ToString().Trim();
                            if (txtMaNCC.Text.Trim() == check)
                            {
                                dem++;
                                break;
                            }
                        }

                    }
                    if (dem != 0)
                    {
                        bus.UpdateNhaCungCap(dto.Mancc, dto.Tenncc, dto.Diachi, dto.Sodt);
                        NhaCungCap_Load(sender, e);
                        MessageBox.Show("Cập nhập nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà cung cấp không tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không cập nhật được nhà cung cấp, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenNCC.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.DeleteNhaCungCap(txtMaNCC.Text);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void bnTim_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            else
            {
                dgvNCC.DataSource = bus.SearchNhaCungCap(txtMaNCC.Text);
            }
        }

        private void dgvNCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = e.RowIndex;
            txtMaNCC.Text = dgvNCC.Rows[r].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[r].Cells[2].Value.ToString();
            txtSoDT.Text = dgvNCC.Rows[r].Cells[3].Value.ToString();
        }

        private void bnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

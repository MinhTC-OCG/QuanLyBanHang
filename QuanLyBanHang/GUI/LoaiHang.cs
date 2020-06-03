using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
namespace GUI
{
    public partial class LoaiHang : Form
    {
        LoaiHang_BUS bus = new LoaiHang_BUS();
        LoaiHang_DTO lh = new LoaiHang_DTO();

        DataTable dtLoaiHang, dtTimKiem;

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
            dtLoaiHang = new DataTable();
            dtLoaiHang = bus.ShowLoaiHang();
            dgvLoaiHang.DataSource = dtLoaiHang;
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
                    foreach (DataRow row in dtLoaiHang.Rows)
                    {
                        var check = row["MaL"].ToString().Trim();
                        if (txtMaL.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        bus.InsertLoaiHang(txtMaL.Text, txtTenL.Text, txtGhiChu.Text);
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
                    foreach (DataRow row in dtLoaiHang.Rows)
                    {
                        foreach (DataColumn c in dtLoaiHang.Columns)
                        {
                            var check = row[c].ToString().Trim();
                            if (txtMaL.Text.Trim() == check)
                            {
                                dem++;
                                break;
                            }
                        }

                    }
                    if (dem != 0)
                    {
                        bus.UpdateLoaiHang(lh.Maloai,lh.Tenloai,lh.Ghichu);
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
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenL.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bus.DeleteLoaiHang(txtMaL.Text);
                MessageBox.Show("Xóa thành công");
                LoadData();
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

        private void dgvLoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int r = e.RowIndex;
            txtMaL.Text = dgvLoaiHang.Rows[r].Cells[0].Value.ToString();
            txtTenL.Text = dgvLoaiHang.Rows[r].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvLoaiHang.Rows[r].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = bus.SearchLoaiHang(txtMaL.Text);
            dgvLoaiHang.DataSource = dtTimKiem;
        }
    }
}

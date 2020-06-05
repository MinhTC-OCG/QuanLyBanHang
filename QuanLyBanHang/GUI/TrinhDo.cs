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
    public partial class TrinhDo : Form
    {
        public TrinhDo()
        {
            InitializeComponent();
        }
        TrinhDo_DTO T = new TrinhDo_DTO();
        TrinhDo_BUS td = new TrinhDo_BUS();
        DataTable dtTrinhdo, dtTimKiem;
        public void LoadData()
        {
            dtTrinhdo = new DataTable();
            dtTrinhdo = td.ShowTrinhDo();
            dgvTrinhdo.DataSource = dtTrinhdo;
        }
        private void TrinhDo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTrinhdo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[1].Value.ToString().Trim();
            txtMatrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[0].Value.ToString().Trim();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatrinhdo.Text = "";
            txtTrinhdo.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = td.SearchTrinhdo(txtTim.Text);
            dgvTrinhdo.DataSource = dtTimKiem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrinhdo.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên trình độ, nhập lại!"); 
                else if (txtMatrinhdo.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã trình độ, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtTrinhdo.Rows)
                    {
                        var check = row["MaTD"].ToString().Trim();
                        if (txtMatrinhdo.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {

                        td.InsertTrinhdo(txtMatrinhdo.Text, txtTrinhdo.Text);
                        MessageBox.Show("Thêm hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã trình độ tồn tại , nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được trình độ, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrinhdo.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên trình độ, nhập lại!");
                else if (txtMatrinhdo.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã trình độ, nhập lại!");
                else
                {
                    int dem = 0;
                    foreach (DataRow row in dtTrinhdo.Rows)
                    {
                        var check = row["MaTD"].ToString().Trim();
                        if (txtMatrinhdo.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem != 0)
                    {

                        td.UpdateTrinhDo(txtMatrinhdo.Text, txtTrinhdo.Text);
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã trình độ không tồn tại, nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không sửa được trình độ, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTrinhdo.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                td.DeleteTrinhdo(txtMatrinhdo.Text.Trim());
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}

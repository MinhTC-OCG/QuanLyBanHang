using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrinhDo : Form
    {
        TrinhDo_DTO td = new TrinhDo_DTO();
        TrinhDo_BUS bus = new TrinhDo_BUS();

        List<TrinhDo_DTO> list = new List<TrinhDo_DTO>();

        public TrinhDo()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            list = bus.ShowTD();
            dgvTrinhdo.DataSource = list;
        }
        private void TrinhDo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTrinhdo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMatrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[1].Value.ToString().Trim();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMatrinhdo.Text = "";
            txtTrinhdo.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<TrinhDo_DTO> list_tk = new List<TrinhDo_DTO>();
            list_tk = bus.SearchTD(txtTim.Text);
            dgvTrinhdo.DataSource = list_tk;
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
                    foreach (TrinhDo_DTO td in list)
                    {
                        if (txtMatrinhdo.Text.Trim() == td.MaTD_1.Trim())
                        {
                            dem++;
                            break;
                        }
                    }

                    if (dem == 0)
                    {
                        bus.InsertTD(txtMatrinhdo.Text, txtTrinhdo.Text);
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
                    foreach (TrinhDo_DTO td in list)
                    {
                        if (txtMatrinhdo.Text.Trim() == td.MaTD_1.Trim())
                        {
                            dem++;
                            break;
                        }
                    }

                    if (dem != 0)
                    {

                        bus.UpdateTD(txtMatrinhdo.Text, txtTrinhdo.Text);
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
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Thất bại, chưa nhập mã trình độ cần xóa!");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTrinhdo.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bus.DeleteTD(txtMatrinhdo.Text.Trim());
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
            }
        }
    }
}

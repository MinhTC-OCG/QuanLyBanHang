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
        NhaCungCap_DTO lh = new NhaCungCap_DTO();
        DataTable dtNhaCungCap;
        public void LoadData()
        {
            dtNhaCungCap = new DataTable();
            dtNhaCungCap = bus.ShowNhaCungCap();
            dgvNCC.DataSource = dtNhaCungCap;
        }
        private void bnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSoDT.ResetText();
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
                        var check = row["MaL"].ToString().Trim();
                        if (txtMaNCC.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }

                    }
                    if (dem == 0)
                    {
                        bus.InsertNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, Int32.Parse(txtSoDT.Text));
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
    }
}

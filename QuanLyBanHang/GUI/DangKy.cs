using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAL;

namespace GUI
{
    public partial class DangKy : Form
    {
        LichSuGia_DTO dto = new LichSuGia_DTO();
        Lop_DAL dal = new Lop_DAL();
        DangKy_BUS bus = new DangKy_BUS();
        DataTable dtcheck;

        public DangKy()
        {
            
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Close();
            dn.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text== "" || txtSdt.Text == "" || txtMK.Text == "" || txtXacNhan.Text == "" || cbVaiTro.Text=="")
            {
                MessageBox.Show("Chưa điền đầy dủ thông tin!" , "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(txtMK.Text.Equals(txtXacNhan.Text) == false)
            {
                MessageBox.Show("Mật khẩu và xác nhận không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int dem = 0;
                dtcheck = new DataTable();
                dtcheck.Clear();
                dtcheck = bus.KiemTra();
                for (int i = 0; i < dtcheck.Rows.Count; i++)
                {
                    if(dtcheck.Rows[i]["TenDN"].ToString().Trim().Equals(txtTenTK.Text.Trim())==true || dtcheck.Rows[i]["SoDTDK"].ToString().Trim().Equals(txtSdt.Text.Trim()) == true)
                    {
                        dem = dem + 1;
                    }
                }

                if(cbVaiTro.Text.Trim().Equals("Quản lý") == true)
                {
                    if (dem == 0)
                    {
                        bus.DangKyMatKhau(txtTenTK.Text.Trim(), txtMK.Text.Trim(),1, txtSdt.Text.Trim());
                        MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tên hoặc số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    
                }
                else if(cbVaiTro.Text.Trim().Equals("Nhân viên") == true)
                {
                    if (dem == 0)
                    {
                        bus.DangKyMatKhau(txtTenTK.Text.Trim(), txtMK.Text.Trim(),0, txtSdt.Text.Trim());
                        MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(dem==1)
                    {
                        MessageBox.Show("Sai tên hoặc số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sai vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

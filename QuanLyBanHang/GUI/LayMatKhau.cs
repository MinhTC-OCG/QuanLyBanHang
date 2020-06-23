using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class LayMatKhau : Form
    {
        DataTable dtTaiKhoan;
        LayMatKhau_BUS bus = new LayMatKhau_BUS();
        public LayMatKhau()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Close();
            dn.Show();
        }

        private void LayMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Thông báo");
            }
            else if (txtSoDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điệnt thoại!", "Thông báo");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo");

            }
            else if (txtXacNhan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu!", "Thông báo");
            }
            else
            {
                dtTaiKhoan = new DataTable();
                dtTaiKhoan = bus.getTaiKhoan();
                try
                {
                    int dem = 0;
                    foreach (DataRow r in dtTaiKhoan.Rows)
                    {
                        var tk = r["TenDN"].ToString().Trim();
                        var sodt = r["SoDTDK"].ToString().Trim();
                        if (txtTaiKhoan.Text.Trim() == tk && txtSoDT.Text.Trim() == sodt)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        if(txtMatKhau.Text.Trim() == txtXacNhan.Text.Trim())
                        {
                            bus.UpdateMatKhau(txtTaiKhoan.Text.Trim(),txtMatKhau.Text.Trim(), txtSoDT.Text.Trim());
                            MessageBox.Show("Cập nhật mật khẩu thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thất bại, mật khẩu bạn nhập vào không trùng nhau!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc số điện thoại nhập vào không đúng!", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không sửa được tài khoản","Thông báo");
                }

            }
        }
    }
}

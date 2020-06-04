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
namespace GUI
{
    public partial class DangNhap : Form
    {
        DangNhap_BUS bus = new DangNhap_BUS();
        DangNhap_DTO dto = new DangNhap_DTO();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dto.Tendangnhap = txtTenDN.Text.Trim();
            dto.Matkhau = txtMatKhau.Text.Trim();
           
            dt = bus.DangNhap(dto.Tendangnhap,dto.Matkhau);
            int dem = 0;
            foreach (DataRow r in dt.Rows)
            {

                var tk = r["TenDN"].ToString().Trim();
                var mk = r["MatKhau"].ToString().Trim();
                if (dto.Tendangnhap == tk && dto.Matkhau == mk)
                {
                    dem++;
                    break;
                }
            }
            if(dem != 0)
            {
               
                Main m = new Main();
                m.Show();
                this.Visible=false;

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

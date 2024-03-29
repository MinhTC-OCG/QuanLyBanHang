﻿using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI
{
    public partial class DangNhap : Form
    {
        DangNhap_BUS bus = new DangNhap_BUS();
        DangNhap_DTO dto = new DangNhap_DTO();
        
        public static string tendangnhap = "";

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dto.Tendangnhap = txtTenDN.Text.Trim();
            dto.Matkhau = txtMatKhau.Text.Trim();

            dt = bus.DangNhap(dto.Tendangnhap, dto.Matkhau);
            int dem = 0;
            foreach (DataRow r in dt.Rows)
            {
                var tk = r["TenDN"].ToString().Trim();
                var mk = r["MatKhau"].ToString().Trim();
                if (dto.Tendangnhap == tk && dto.Matkhau == mk)
                {
                    tendangnhap = tk;
                    dem++;
                    break;
                }
            }
            if (dem != 0)
            {
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác, thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbLinkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LayMatKhau lmk = new LayMatKhau();
            this.Hide();
            lmk.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            this.Hide();
            dk.Show();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

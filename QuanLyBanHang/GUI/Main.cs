using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang loaihang = new LoaiHang();
            loaihang.Show();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.Show();
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDo td = new TrinhDo();
            td.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void lịchSửGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuGia lsg = new LichSuGia();
            lsg.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void loạiHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.Show();
        }

        private void hàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hang h = new Hang();
            h.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Show();
        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void lịchSửGiáToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LichSuGia ls = new LichSuGia();
            ls.Show();
        }

        private void trìnhĐộToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrinhDo td = new TrinhDo();
            td.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void mnTSThoat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Close();
        }

        private void LoaiHangMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.Show();
        }

        private void HangMenuItem_Click(object sender, EventArgs e)
        {
            Hang h = new Hang();
            h.Show();
        }

        private void NCCMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Show();
        }

        private void NhanVienMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void KhachHangMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void LichSuGiaMenuItem_Click(object sender, EventArgs e)
        {
            LichSuGia ls = new LichSuGia();
            ls.Show();
        }

        private void TrinhDoMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDo td = new TrinhDo();
            td.Show();
        }

        private void HoaDonMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void BaoCaoTheoNgayMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTheoNgay bc = new BaoCaoTheoNgay();
            bc.Show();
        }
    }
}

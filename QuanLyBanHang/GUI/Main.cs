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
namespace GUI
{
    public partial class Main : Form
    {
        HoaDon_BUS bus = new HoaDon_BUS();
        Main_BUS mbus = new Main_BUS();
        DataTable dt = new DataTable();

        public int somathang;
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

        private void BaoCaoTheoThangMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTonCuoiThang bc = new BaoCaoTonCuoiThang();
            bc.Show();
        }

        public void LoadData()
        {
            DataTable dtTongHang, dtTongNhanVien, dtTongKhachHang;
            dtTongHang = mbus.GetAmount_Hang();
            dtTongNhanVien = mbus.GetAmount_NhanVien();
            dtTongKhachHang = mbus.GetAmount_KhachHang();
            foreach (DataRow r in dtTongHang.Rows)
            {
                lbTongHang.Text = r["TongHang"].ToString();
                somathang = Int32.Parse(r["SoMatHang"].ToString());
            }

            foreach (DataRow r in dtTongNhanVien.Rows)
            {
                lbTongNhanVien.Text = r["TongNhanVien"].ToString();
            }

            foreach (DataRow r in dtTongKhachHang.Rows)
            {
                lbTongKH.Text = r["TongKH"].ToString();
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
            dt = bus.getLichSuHang();

            chart1.DataSource = dt;
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Area0");
            chart1.Series.Add("SoLuongCon");
          

            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Maximum = somathang;

            chart1.ChartAreas[0].AxisY.Minimum = 0;

            //chart1.ChartAreas[0].AxisY.Maximum = 5000;

            chart1.Series[0].XValueMember = "TenHang";
            chart1.Series[0].YValueMembers = "SoLuongCon";
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}

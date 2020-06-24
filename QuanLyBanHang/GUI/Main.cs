using BUS;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
namespace GUI
{
    public partial class Main : Form
    {
        HoaDon_BUS bus = new HoaDon_BUS();
        Main_BUS mbus = new Main_BUS();
        DataTable dt;
        public int somathang;

        public Main()
        {
            InitializeComponent();
        }

        private void mnTSThoat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Close();
        }

        public void LoadData()
        {
            DataTable dtTongHang, dtTongNhanVien, dtTongKhachHang,dtTongDoanhThu;
            dtTongHang = mbus.GetAmount_Hang();
            dtTongNhanVien = mbus.GetAmount_NhanVien();
            dtTongKhachHang = mbus.GetAmount_KhachHang();
            dtTongDoanhThu = mbus.TongDoanhThu();
         
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

            foreach (DataRow r in dtTongKhachHang.Rows)
            {
                lbTongKH.Text = r["TongKH"].ToString();
            }

            long tongDoanhThu = 0;
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            foreach (DataRow r in dtTongDoanhThu.Rows)
            {
                tongDoanhThu = tongDoanhThu + Int32.Parse(r["ThanhTienHD"].ToString());
            }
            lbTongDoanhThu.Text = tongDoanhThu.ToString("N0",nfi);
        }

        //public void LoadChart()
        //{
        //    dt = bus.getLichSuHang();

        //    chart1.DataSource = dt;
        //    chart1.Series.Clear();
        //    chart1.ChartAreas.Clear();
        //    chart1.ChartAreas.Add("Area0");
        //    chart1.Series.Add("SoLuongCon");

        //    chart1.Series[0].XValueMember = "MaHang";
        //    chart1.Series[0].YValueMembers = "SoLuongCon";
        //    chart1.Series[0].IsValueShownAsLabel = true;
        //    chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

        //    chart1.ChartAreas[0].AxisX.Minimum = 0;
        //    chart1.ChartAreas[0].AxisX.Maximum = somathang;
        //    chart1.ChartAreas[0].AxisY.Minimum = 0;
        //    chart1.ChartAreas[0].AxisY.Maximum = 5000;
        //}

        private void btnReload_Click(object sender, EventArgs e)
        {
            Main_Load(sender, e);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //------------------------------------------
        private void mntsLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHang loaihang = new LoaiHang();
            loaihang.Show();
        }

        private void mntsHang_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.Show();
        }

        private void mntsNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.Show();
        }

        private void mntsNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void mntsKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void mntsLichSuGia_Click(object sender, EventArgs e)
        {
            LichSuGia ls = new LichSuGia();
            ls.Show();
        }

        private void mntsTrinhDo_Click(object sender, EventArgs e)
        {
            TrinhDo td = new TrinhDo();
            td.Show();
        }

        private void mntsHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void mntsBaoCaoTheoNgay_Click(object sender, EventArgs e)
        {
            BaoCaoTheoNgay bc = new BaoCaoTheoNgay();
            bc.Show();
        }

        private void mntsBaoCaoTheoThang_Click(object sender, EventArgs e)
        {
            BaoCaoTonCuoiThang bc = new BaoCaoTonCuoiThang();
            bc.Show();
        }

        private void mntsBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoBanHang bc = new BaoCaoDoanhSoBanHang();
            bc.Show();
        }

        private void mnstDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

        private void mnstDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }
    }
}

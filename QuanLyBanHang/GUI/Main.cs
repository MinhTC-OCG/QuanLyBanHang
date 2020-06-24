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
        int qdn=0;
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
            int demq = 0;
            DataTable quyen = new DataTable();
            quyen.Clear();
            quyen = mbus.QuyenDangNhap(DangNhap.tendangnhap.Trim());
            string q = "";
            foreach (DataRow r in quyen.Rows)
            {
                 q = r["Quyen"].ToString().Trim();
             
            }

            if (q=="True")
            {

                mnQuanLy.Enabled = false;
            }
            //else if (demq == 0)
            //{
            //    qdn = 0;
            //}
            LoadData();
            
        }
        //------------------------------------------
        private void mntsLoaiHang_Click(object sender, EventArgs e)
        {
            if (qdn == 0)
            {
                LoaiHang loaihang = new LoaiHang();
                loaihang.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
            
        }

        private void mntsHang_Click(object sender, EventArgs e)
        {

            if (qdn == 0)
            {
                Hang hang = new Hang();
                hang.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void mntsNCC_Click(object sender, EventArgs e)
        {
            
            if (qdn == 0)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void mntsNhanVien_Click(object sender, EventArgs e)
        {
            
            if (qdn == 0)
            {
                NhanVien nv = new NhanVien();
                nv.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void mntsKhachHang_Click(object sender, EventArgs e)
        {
            
            if (qdn == 0)
            {
                KhachHang kh = new KhachHang();
                kh.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void mntsLichSuGia_Click(object sender, EventArgs e)
        {
             if (qdn == 0)
            {
                LichSuGia ls = new LichSuGia();
                ls.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
        }

        private void mntsTrinhDo_Click(object sender, EventArgs e)
        {
            
            if (qdn == 0)
            {
                TrinhDo td = new TrinhDo();
                td.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
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

        private void mnQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void mnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void mnTaiKhoản_Click(object sender, EventArgs e)
        {
            
        }

        

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                HoaDon hd = new HoaDon();
                hd.Show();
            
            
        }
    }
}

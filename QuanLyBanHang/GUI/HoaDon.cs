using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using System.Diagnostics;

namespace GUI
{
    public partial class HoaDon : Form
    {
        public int thanhtien;
        public int dongia;
        public int soluong;


        Lop_DAL dal = new Lop_DAL();
        HoaDon_BUS hd = new HoaDon_BUS();

        DataTable dtGetNamePrice, dtGetInfor, dtGetHoaDonTongHop, dtGetNameKH, dtGetNameNV;



        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dtGetInfor = new DataTable();
            dtGetInfor = hd.GetThongtinhang();
            dgvThongtinhang.DataSource = dtGetInfor;

            dtGetHoaDonTongHop = new DataTable();
            dtGetHoaDonTongHop = hd.showDgvHoaDonTongHop();
            dgvHoaDonTongHop.DataSource = dtGetHoaDonTongHop;

            LoadMaHD();

            int tongtienhoadon = 0;
            foreach (DataRow r in dtGetInfor.Rows)
            {
                tongtienhoadon = tongtienhoadon + Int32.Parse(r[4].ToString().Trim());
            }
            txtTongTien.Text = tongtienhoadon.ToString();

        }

        //Load so thu tu ma hoa don the tu dong dien ma hoa don vao o textbox
        public void LoadMaHD()
        {
            DataTable dt = new DataTable();
            dt = hd.GetAmountHD();
            int numb = dt.Rows.Count;
            txtMaHD.Text = "HD" + (numb + 1).ToString();
            txtMaHD.Enabled = false;
        }

        private void txtMahang_TextChanged(object sender, EventArgs e)
        {
            dtGetNamePrice = new DataTable();
            dtGetNamePrice = hd.GetNamePrice(txtMahang.Text);
            string tenhang;

            foreach (DataRow r in dtGetNamePrice.Rows)
            {
                tenhang = r[0].ToString().Trim();
                dongia = Int32.Parse(r[1].ToString().Trim());
                txtTenhang.Text = tenhang;
                txtDongia.Text = dongia.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem != 0)
                {
                    hd.UpdateThongtinloaihang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Sửa giỏ hàng thành công");
                    HoaDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không sửa được hàng");
                }
            }

        }

        private void nrSoluong_ValueChanged(object sender, EventArgs e)
        {
            if (nrSoluong.Value == 0)
            {
                soluong = 0;
                thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
            }
            else
            {
                soluong = Int32.Parse(nrSoluong.Value.ToString());
                thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
                int tt = Int32.Parse(txtThanhtien.Text);
                if (dtGetHoaDonTongHop.Rows.Count > 0)
                {
                    //soluong = Int32.Parse(nrSoluong.Value.ToString());
                    //thanhtien = soluong * dongia;
                    //txtThanhtien.Text = thanhtien.ToString();
                    

                    int numb = 0;
                    foreach (DataRow r in dtGetHoaDonTongHop.Rows)
                    {
                        if (r["MaHD"].ToString().Trim() == txtMaHD.Text.Trim() && r["MaHang"].ToString().Trim() != txtMahang.Text.Trim())
                        {
                            int n = Int32.Parse(r["SoLuongHD"].ToString()) * Int32.Parse(r["DonGiaHD"].ToString());
                            numb = numb + n;
                        }
                    }
                    txtTongTien.Text = (tt + numb).ToString();
                }
            }

            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenhang.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                hd.DeleteThongtinloaihang(txtMahang.Text.Trim());
                MessageBox.Show("Xóa thành công");
                HoaDon_Load(sender, e);
            }
        }

        //Them hoa don
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaGioHang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem != 0)
                {
                    hd.UpdateThongtinloaihang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Sửa giỏ hàng thành công");
                    HoaDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không sửa được hàng");
                }
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem == 0)
                {
                    hd.InsertThongtinhang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Thêm vào giỏ hàng thành công.");
                    HoaDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hàng đã tồn tại, chọn mua mặt hàng khác!");
                }
            }
        }

        private void btnXoaHangTrongGio_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenhang.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                hd.DeleteThongtinloaihang(txtMahang.Text.Trim());
                MessageBox.Show("Xóa thành công");
                HoaDon_Load(sender, e);
            }
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text.Trim();
            string makh = txtMaKH.Text;
            string tenkh = txtHotenKH.Text;
            string ngaylap = dpNgayLap.Value.Date.ToString("yyyy-MM-dd"); ;
            string manv = txtMaNV.Text;
            string tennv = txtTenNV.Text;
            string tongtienhd = txtTongTien.Text;

            string mahang = txtMahang.Text, tenhang = txtTenhang.Text;
            int dongia = Int32.Parse(txtDongia.Text);
            int thanhtien = Int32.Parse(txtThanhtien.Text), soluong = Int32.Parse(nrSoluong.Text);
            hd.UpdateHoaDonTongHop(mahd,makh,tenkh,ngaylap,manv,tennv,mahang,tenhang,soluong,dongia,thanhtien,tongtienhd);
            hd.UpdateHD(mahd, makh, ngaylap, manv);
            hd.UpdateHDChiTiet(mahd, mahang, soluong);
            MessageBox.Show("Cập nhật hóa đơn thành công.");
            HoaDon_Load(sender, e);
            btnNhaplai_Click(sender, e);
            txtMahang.Enabled = true;
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text.Trim();
            string mahang = txtMahang.Text;
           
            hd.DeleteHoaDonTongHop(mahd);
            hd.DeleteHDChiTiet(mahd);
            hd.DeleteHD(mahd);
            MessageBox.Show("Xóa hóa đơn thành công.");
            HoaDon_Load(sender,e);
            btnNhaplai_Click(sender, e);
        }

        private void dgvHoaDonTongHop_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDonTongHop.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHoaDonTongHop.Rows[r].Cells[0].Value.ToString();
            txtMaKH.Text = dgvHoaDonTongHop.Rows[r].Cells[1].Value.ToString();
            txtHotenKH.Text = dgvHoaDonTongHop.Rows[r].Cells[2].Value.ToString();
            dpNgayLap.Value = Convert.ToDateTime(dgvHoaDonTongHop.Rows[r].Cells[3].Value);
            txtMaNV.Text = dgvHoaDonTongHop.Rows[r].Cells[4].Value.ToString();
            txtTenNV.Text = dgvHoaDonTongHop.Rows[r].Cells[5].Value.ToString();
            txtMahang.Text = dgvHoaDonTongHop.Rows[r].Cells[6].Value.ToString();
            txtTenNV.Text = dgvHoaDonTongHop.Rows[r].Cells[7].Value.ToString();
            nrSoluong.Text = dgvHoaDonTongHop.Rows[r].Cells[8].Value.ToString();
            txtDongia.Text = dgvHoaDonTongHop.Rows[r].Cells[9].Value.ToString();
            txtThanhtien.Text = dgvHoaDonTongHop.Rows[r].Cells[10].Value.ToString();
            txtTongTien.Text = dgvHoaDonTongHop.Rows[r].Cells[11].Value.ToString();
            txtMahang.Enabled = false;
        }

        private void dgvThongtinhang_Click(object sender, EventArgs e)
        {
            int dong = dgvThongtinhang.CurrentCell.RowIndex;
            txtMahang.Text = dgvThongtinhang.Rows[dong].Cells[0].Value.ToString();
            txtTenhang.Text = dgvThongtinhang.Rows[dong].Cells[1].Value.ToString();
            nrSoluong.Text = dgvThongtinhang.Rows[dong].Cells[2].Value.ToString();
            txtDongia.Text = dgvThongtinhang.Rows[dong].Cells[3].Value.ToString();
            txtThanhtien.Text = dgvThongtinhang.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            HoaDon_Load(sender,e);
            txtMaKH.Text = "";
            txtHotenKH.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTongTien.Text = "";
            txtMahang.Text = "";
            txtTenhang.Text = "";
            nrSoluong.Value = 0;
            txtDongia.Text = "";
            txtMahang.Enabled = true;
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
                MessageBox.Show("Chưa nhập mã khách hàng, nhập lại!");
            else if (txtTenhang.Text == "")
                MessageBox.Show("Chưa nhập tên khách hàng, nhập lại!");
            else if (txtMaNV.Text == "")
                MessageBox.Show("Chưa nhập mã nhân viên, nhập lại!");
            else if (txtTenNV.Text == "")
                MessageBox.Show("Chưa nhập tên nhân viên, nhập lại!");
            else
            {
                string mahd = txtMaHD.Text.Trim();
                string makh = txtMaKH.Text;
                string tenkh = txtHotenKH.Text;
                string ngaylap = dpNgayLap.Value.Date.ToString("yyyy-MM-dd"); ;
                string manv = txtMaNV.Text;
                string tennv = txtTenNV.Text;
                string tongtienhd = txtTongTien.Text;

                string mahang = "", tenhang = "";
                int dongia = 0;
                int thanhtien = 0, soluong = 0;


                hd.InsertHD(mahd, makh, ngaylap, manv);

                foreach (DataRow r in dtGetInfor.Rows)
                {
                    mahang = r[0].ToString();
                    tenhang = r[1].ToString();
                    soluong = Int32.Parse(r[2].ToString());
                    dongia = Int32.Parse(r[3].ToString());
                    thanhtien = Int32.Parse(r[4].ToString());

                    hd.InsertHDChiTiet(mahd, mahang, soluong);
                    hd.InsertHoaDonTongHop(mahd, makh, tenkh, ngaylap, manv, tennv, mahang, tenhang, soluong, dongia, thanhtien, tongtienhd);
                }

                
                MessageBox.Show("Tạo hóa đơn thành công.");
                hd.DeleteAllCart();
                HoaDon_Load(sender, e);
                btnNhaplai_Click(sender, e);
            }
        }

        //Khi nhap vao ma nhan vien thi ten nhan vien tu dong hien thi tren o textbox
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            dtGetNameNV = new DataTable();
            dtGetNameNV = hd.GetNameNV(txtMaNV.Text.Trim());
            if (dtGetNameNV.Rows.Count > 0)
            {
                string tennv;
                foreach (DataRow r in dtGetNameKH.Rows)
                {
                    tennv = r[0].ToString().Trim();
                    txtTenNV.Text = tennv == "" ? "" : tennv;
                }
            }
            else
            {
                txtTenNV.Text = "";
            }

        }

        //Khi nhap vao ma khach hang thi ten khach hang tu dong hien thi tren o textbox
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            dtGetNameKH = new DataTable();
            dtGetNameKH = hd.GetNameKH(txtMaKH.Text.Trim());
            if (dtGetNameKH.Rows.Count > 0)
            {
                string tenkh;
                foreach (DataRow r in dtGetNameKH.Rows)
                {
                    tenkh = r[0].ToString().Trim();
                    txtHotenKH.Text = tenkh == "" ? "" : tenkh;
                }
            }
            else
            {
                txtHotenKH.Text = "";
            }
        }

        private void btnThemhang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem == 0)
                {
                    hd.InsertThongtinhang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Thêm hàng vào giỏ hàng thành công");
                    HoaDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hàng bạn chọn đã có trong giỏ hàng, chọn hàng khác");
                }
            }
        }
    }
}

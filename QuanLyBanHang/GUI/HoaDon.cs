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

        DataTable dtGetNamePrice, dtGetInfor,dtGetHoaDonTongHop, dtGetNameKH, dtGetNameNV;

        string mahang, tenhang;

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
            txtMaHD.Text = "HD" + (numb+1).ToString();
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

        private void dgvThongtinhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMahang.Text = dgvThongtinhang.Rows[dong].Cells[0].Value.ToString();
            txtTenhang.Text = dgvThongtinhang.Rows[dong].Cells[1].Value.ToString();
            nrSoluong.Text = dgvThongtinhang.Rows[dong].Cells[2].Value.ToString();
            txtDongia.Text = dgvThongtinhang.Rows[dong].Cells[3].Value.ToString();
            txtThanhtien.Text = dgvThongtinhang.Rows[dong].Cells[4].Value.ToString();
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

        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {

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

                string  dongia;
                int thanhtien, soluong;

                //gop tat ca ten hang da mua trong gio hang
                string ten = "";
                //gop tat ca gia tien cua tung mat hang trong gioi hang;
                string sl="", dg="", tt="";
                hd.InsertHD(mahd, makh, ngaylap, manv);

                foreach (DataRow r in dtGetInfor.Rows)
                {
                    mahang = r[0].ToString();
                    tenhang = r[1].ToString();
                    soluong = Int32.Parse(r[2].ToString());
                    dongia = r[3].ToString();
                    thanhtien = Int32.Parse(r[4].ToString());

                    ten = string.Concat(tenhang) + ",";
                    sl = string.Concat(soluong.ToString()) + " , ";
                    dg = string.Concat(dongia.ToString()) + " , ";
                    tt = string.Concat(thanhtien.ToString()) + " , ";
                    hd.InsertHDChiTiet(mahd, mahang, soluong);
                   
                }
                hd.InsertHoaDonTongHop(mahd, makh, tenkh, ngaylap, manv, tennv, mahang, tenhang, sl, dg, tt, tongtienhd);
                HoaDon_Load(sender, e);
                MessageBox.Show("Tạo hóa đơn thành công.");
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

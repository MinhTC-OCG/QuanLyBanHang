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
using System.Data.SqlClient;

namespace GUI
{
    public partial class LichSuGia : Form
    {
        DateTime ngayCapNhat = DateTime.Now;
        LichSuGia_DTO dto = new LichSuGia_DTO();
        Lop_DAL dal = new Lop_DAL();
        LichSuGia_BUS bus = new LichSuGia_BUS();
        DataTable dtLichSuGia;


        public LichSuGia()
        {
            InitializeComponent();
        }

        private void LichSuGia_Load(object sender, EventArgs e)
        {
            
            LoadData();
            LoadComboBox();
        }
        public void LoadData()
        {
            dtLichSuGia = new DataTable();
            dtLichSuGia = bus.ShowLichSuGia();
            dgvLichSuGia.DataSource = dtLichSuGia;
            dgvLichSuGia.ClearSelection();
        }
        public void LoadComboBox()
        {

            DataTable dtHang = new DataTable();
            dtHang.Clear();
            dtHang = bus.GetDataHang();
            cbMaHang.DataSource = dtHang;
            cbMaHang.DisplayMember = "TenH";
            cbMaHang.ValueMember = "MaH";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date);
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
            }
            else if (result > 0)
            {
                MessageBox.Show("Sai ngày bắt đầu và ngày kết thúc!");
            }
            else
            {
                try
                {
                    DataTable dtMaH = new DataTable();
                    dtMaH.Clear();
                    SqlConnection conn = dal.getConnect();
                    conn.Open();
                    SqlDataAdapter ad = new SqlDataAdapter("select MaH from Hang12 where TenH= N'" + cbMaHang.Text + "'", conn);
                    ad.Fill(dtMaH);

                    dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                    dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";

                    dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
                    dtpNgayKetThuc.CustomFormat = "MM/dd/yyyy";


                    try
                    {
                        dto.MaHang_1 = dtMaH.Rows[0]["MaH"].ToString().Trim();
                        dto.NgayBatDau_1 = dtpNgayBatDau.Text.Trim();
                        dto.NgayKetThuc_1 = dtpNgayKetThuc.Text.Trim();
                        dto.NgayCapNhat_1 = ngayCapNhat.ToString("MM/dd/yyyy");
                        dto.DonGia_1 = Int32.Parse(txtDonGia.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Sai format don gia! ");
                    }

                    bus.InsertLichSuGia(dto.MaHang_1, dto.NgayBatDau_1, dto.NgayKetThuc_1, dto.DonGia_1, dto.NgayCapNhat_1);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Sai dữ liệu ");
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtDonGia.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int result = DateTime.Compare(dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date);
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
            }
            else if (result > 0)
            {
                MessageBox.Show("Sai ngày bắt đầu và ngày kết thúc!");
            }
            else
            {
                DataTable dtMaH = new DataTable();
                dtMaH.Clear();
                SqlConnection conn = dal.getConnect();
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select MaH from Hang12 where TenH= N'" + cbMaHang.Text + "'", conn);
                ad.Fill(dtMaH);

                dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
                dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";

                dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
                dtpNgayKetThuc.CustomFormat = "MM/dd/yyyy";



                dto.MaHang_1 = dtMaH.Rows[0]["MaH"].ToString().Trim();
                dto.NgayBatDau_1 = dtpNgayBatDau.Text.Trim();
                dto.NgayKetThuc_1 = dtpNgayKetThuc.Text.Trim();
                dto.NgayCapNhat_1 = ngayCapNhat.ToString("MM/dd/yyyy");
                dto.DonGia_1 = Int32.Parse(txtDonGia.Text);


                bus.UpdateLichSuGia(dto.MaHang_1, dto.NgayBatDau_1, dto.NgayKetThuc_1, dto.DonGia_1, dto.NgayCapNhat_1);
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa  \"" + cbMaHang.Text + "\" ra khỏi danh sách lịch sử giá?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DataTable dtMaH = new DataTable();
                dtMaH.Clear();
                SqlConnection conn = dal.getConnect();
                conn.Open();
                try
                {
                    SqlDataAdapter ad = new SqlDataAdapter("select MaH from Hang12 where TenH= N'" + cbMaHang.Text + "'", conn);
                    ad.Fill(dtMaH);
                    String s1 = bus.SearchLichSuHang(dtMaH.Rows[0]["MaH"].ToString().Trim()).Rows[0]["MaH"].ToString().Trim();
                    String s2 = dtMaH.Rows[0]["MaH"].ToString().Trim();
                    if (s1.Equals(s2) == true)
                    {
                        bus.DeleteLichSuGia(dtMaH.Rows[0]["MaH"].ToString().Trim());
                        LoadData();
                        MessageBox.Show("Xóa thành công");
                    }

                }
                catch
                {
                    MessageBox.Show("Không có Hàng " + dtMaH.Rows[0]["MaH"].ToString().Trim() + "! ");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtMaH = new DataTable();
            dtMaH.Clear();
            SqlConnection conn = dal.getConnect();
            conn.Open();
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("select MaH from Hang12 where TenH= N'" + cbMaHang.Text + "'", conn);
                ad.Fill(dtMaH);
                dgvLichSuGia.DataSource = bus.SearchLichSuHang(dtMaH.Rows[0]["MaH"].ToString().Trim());
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu Combobox");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void rowenter(object sender, DataGridViewCellEventArgs e)
        {
            int c = e.RowIndex;
            
            String maHang= dgvLichSuGia.Rows[c].Cells[0].Value.ToString().Trim();

            
            DataTable dtMaH = new DataTable();
            dtMaH.Clear();
            SqlConnection conn = dal.getConnect();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select TenH from Hang12 where MaH= N'" + maHang + "'", conn);
            ad.Fill(dtMaH);
            try
            {
                cbMaHang.Text = "";
                cbMaHang.SelectedText = dtMaH.Rows[0]["TenH"].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Khong lay dc ma hang");
            }
            txtDonGia.Text = dgvLichSuGia.Rows[c].Cells[3].Value.ToString().Trim();
        }
    }
}

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
            loadData();
            LoadComboBox();
        }
        public void loadData()
        {
            dtLichSuGia = new DataTable();
            dtLichSuGia = bus.ShowLichSuGia();
            dgvLichSuGia.DataSource = dtLichSuGia;
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtDonGia.ResetText();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá, nhập lại!");
            }
            else
            {
                DataTable dtMaH = new DataTable();
                dtMaH.Clear();
                SqlConnection conn = dal.getConnect();
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select MaH from Hang12 where TenH= N'" + cbMaHang.Text + "'", conn);
                ad.Fill(dtMaH);

                txtDonGia.Text = dtMaH.Rows[0]["MaH"].ToString();
            }
        }

        private void dgvLichSuGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgayCapNhat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        private Lop_DAL dal = new Lop_DAL();
        HoaDon_BUS hd = new HoaDon_BUS();
        DataTable dtGetNamePrice, dtGetInfor;
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dtGetInfor = new DataTable();
            dtGetInfor = hd.GetThongtinhang();
            dgvThongtinhang.DataSource = dtGetInfor;
        }

        private void txtMahang_TextChanged(object sender, EventArgs e)
        {
            dtGetNamePrice = new DataTable();
            dtGetNamePrice = hd.GetNamePrice(txtMahang.Text);
            string tenhang;
            
            foreach(DataRow r in dtGetNamePrice.Rows)
            {
                tenhang = r[0].ToString().Trim();
                dongia = Int32.Parse(r [1].ToString().Trim());
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

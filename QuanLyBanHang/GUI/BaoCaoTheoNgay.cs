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
    public partial class BaoCaoTheoNgay : Form
    {
        DataTable dtInfo;
        BaoCao_BUS bus = new BaoCao_BUS();
        public BaoCaoTheoNgay()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            string dateCurrent = DateTime.Now.ToString("dd-MM-yyyy");
            lbNgayLap.Text = dateCurrent;
            lbNguoiLap.Text = DangNhap.tendangnhap;
        }

        public void HienThiBaoCao()
        {
            try
            {
                string ngaychon = dtPicker.Value.Date.ToString("yyyy-MM-dd");
                lbNgayLayDuLieu.Text = ngaychon;
                dtInfo = new DataTable();
                dtInfo = bus.GetReport(ngaychon);
                if (dtInfo.Rows.Count > 0)
                {
                    dgvBaoCao.DataSource = dtInfo;
                }
                else
                {
                    MessageBox.Show("Không có mặt hàng nào được bán vào ngào " + ngaychon);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu!");
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            HienThiBaoCao();
        }

        private void dgvBaoCao_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dtInfo.Rows.Count; i++)
            {
                dgvBaoCao.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

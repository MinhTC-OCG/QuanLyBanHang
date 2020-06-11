using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class BaoCaoTheoNgay : Form
    {
        ReportDataSource rs = new ReportDataSource();
        DataTable dtInfo;
        BaoCao_BUS bus = new BaoCao_BUS();
        public BaoCaoTheoNgay()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<BaoCao> list = new List<BaoCao>();
            list.Clear();
            for (int i = 0; i < dgvBaoCao.RowCount; i++)
            {
                BaoCao bc = new BaoCao();
                bc.Stt = dgvBaoCao.Rows[i].Cells[0].Value.ToString();
                bc.Mahang = dgvBaoCao.Rows[i].Cells[1].Value.ToString();
                bc.Tenhang = dgvBaoCao.Rows[i].Cells[2].Value.ToString();
                bc.Donvi = dgvBaoCao.Rows[i].Cells[3].Value.ToString();
                bc.Dongia = dgvBaoCao.Rows[i].Cells[4].Value.ToString();
                bc.Soluong = dgvBaoCao.Rows[i].Cells[5].Value.ToString();
                bc.Thanhtien = dgvBaoCao.Rows[i].Cells[6].Value.ToString();
                list.Add(bc);

            }
            rs.Name = "DataSet1";
            rs.Value = list;
            ReportBaoCaoTheoNgay rp = new ReportBaoCaoTheoNgay();
            rp.reportViewer1.LocalReport.DataSources.Clear();
            rp.reportViewer1.LocalReport.DataSources.Add(rs);
            rp.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBaoCaoTheoNgay.rdlc";
            rp.ShowDialog();

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
                string fmngaychon = dtPicker.Value.Date.ToString("dd-MM-yyyy");
                lbNgayLayDuLieu.Text = fmngaychon;
                dtInfo = new DataTable();
                dtInfo = bus.GetReport(ngaychon);
                if (dtInfo.Rows.Count > 0)
                {
                    dgvBaoCao.DataSource = dtInfo;
                }
                else
                {
                    MessageBox.Show("Không có mặt hàng nào được bán vào ngày " + ngaychon);
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
            for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
            {
                dgvBaoCao.Rows[i].Cells[0].Value = i + 1;
            }
        }

    }
    public class BaoCao
    {
        string stt, mahang, tenhang, donvi, dongia, soluong, thanhtien;

        //public BaoCao(string stt, string mahang, string tenhang, string donvi, string dongia, string soluong, string thanhtien)
        //{
        //    this.stt = stt;
        //    this.mahang = mahang;
        //    this.tenhang = tenhang;
        //    this.donvi = donvi;
        //    this.dongia = dongia;
        //    this.soluong = soluong;
        //    this.thanhtien = thanhtien;
        //}

        public string Stt { get => stt; set => stt = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Donvi { get => donvi; set => donvi = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}

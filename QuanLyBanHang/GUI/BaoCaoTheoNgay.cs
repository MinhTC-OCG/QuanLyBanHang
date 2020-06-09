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

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Baocaotheongay.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể xuất báo cáo");
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dgvBaoCao.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgvBaoCao.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvBaoCao.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Xuất báo cáo thành công.", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
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
            for (int i = 0; i < dtInfo.Rows.Count; i++)
            {
                dgvBaoCao.Rows[i].Cells[0].Value = i + 1;
            }
        }

    }
}

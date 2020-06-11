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
    public partial class BaoCaoTonCuoiThang : Form
    {
        BCHTonThang_BUS bus = new BCHTonThang_BUS();

        public BaoCaoTonCuoiThang()
        {
            InitializeComponent();
        }
        public void formatDPicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM";
        }
       
        private void BaoCaoTonCuoiThang_Load(object sender, EventArgs e)
        {
            formatDPicker();
            lbNguoiLap.Text = DangNhap.tendangnhap;
            lbDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            
        }

        private void bnXuat_Click(object sender, EventArgs e)
        {
            string ym = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string[] mang = ym.Split('-');
            string year = mang[0];
            string month = mang[1];
            DataTable dt = new DataTable();
            dt = bus.BCTonThang(year,month);
            dgvBCHTonThang.DataSource = dt;
        }

        private void bnIn_Click(object sender, EventArgs e)
        {
            if (dgvBCHTonThang.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Baocaotheothang.pdf";
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
                        PdfPTable pdfTable = new PdfPTable(dgvBCHTonThang.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgvBCHTonThang.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvBCHTonThang.Rows)
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
        private void dgvBCHTonThang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvBCHTonThang.Rows.Count; i++)
            {
                dgvBCHTonThang.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}

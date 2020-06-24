using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReportBaoCaoTonCuoiThang : Form
    {
        public ReportBaoCaoTonCuoiThang()
        {
            InitializeComponent();
        }

        private void ReportBaoCaoTheoThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet.LichSuHang12' table. You can move, or remove it, as needed.
            this.LichSuHang12TableAdapter.Fill(this.QLBHDataSet.LichSuHang12);
            // TODO: This line of code loads data into the 'QLBH_DataSet.LichSuHang12' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

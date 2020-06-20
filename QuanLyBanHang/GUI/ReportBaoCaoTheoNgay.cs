using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReportBaoCaoTheoNgay : Form
    {
        public ReportBaoCaoTheoNgay()
        {
            InitializeComponent();
        }

        private void ReportBaoCaoTheoNgay_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

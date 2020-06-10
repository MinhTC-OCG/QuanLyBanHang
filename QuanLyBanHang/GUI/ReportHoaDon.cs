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
    public partial class ReportHoaDon : Form
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet.HoaDonTongHop12' table. You can move, or remove it, as needed.
            this.HoaDonTongHop12TableAdapter.Fill(this.QLBHDataSet.HoaDonTongHop12);

            this.reportViewer1.RefreshReport();
        }
    }
}

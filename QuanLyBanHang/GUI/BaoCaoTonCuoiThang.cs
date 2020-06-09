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
            string ym = dateTimePicker1.Value.ToString("yyyy-MM");
            string[] mang = ym.Split('-');
            string year = mang[0];
            string month = mang[1];
            DataTable dt = new DataTable();
            dt = bus.BCTonThang(year, month);
            dgvBCHTonThang.DataSource = dt;
        }
    }
}

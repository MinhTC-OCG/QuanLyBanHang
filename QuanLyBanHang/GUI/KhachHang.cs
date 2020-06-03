using DAL;
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

namespace GUI
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        Lop_DAL dal = new Lop_DAL();
        KhachHang_BUS khb = new KhachHang_BUS();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khb.ShowKhachHang();
        }
    }
}

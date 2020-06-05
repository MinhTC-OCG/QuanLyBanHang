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
using DAL;

namespace GUI
{
    public partial class LichSuGia : Form
    {
        Lop_DAL dal = new Lop_DAL();
        LichSuGia_BUS lsgb = new LichSuGia_BUS();
        DataTable dtLichSuGia;


        public LichSuGia()
        {
            InitializeComponent();
        }

        private void LichSuGia_Load(object sender, EventArgs e)
        {
            dtLichSuGia = new DataTable;
            dtLichSuGia= lsgb.ShowLichSuGia();
            dgvLichSuGia.DataSource = dtLichSuGia;
        }

        private void dtpNgayCapNhat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

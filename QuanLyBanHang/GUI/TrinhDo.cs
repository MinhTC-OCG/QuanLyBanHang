using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;

namespace GUI
{
    public partial class TrinhDo : Form
    {
        public TrinhDo()
        {
            InitializeComponent();
        }
        TrinhDo_DTO T = new TrinhDo_DTO();
        TrinhDo_BUS td = new TrinhDo_BUS();

        private void TrinhDo_Load(object sender, EventArgs e)
        {
            dgvTrinhdo.DataSource = td.ShowTrinhDo();
        }

        private void dgvTrinhdo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[0].Value.ToString().Trim();
            txtMatrinhdo.Text = dgvTrinhdo.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatrinhdo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

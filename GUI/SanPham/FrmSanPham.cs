using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.SanPham
{
    public partial class FrmSanPham : Form
    {
        public BLL_SanPham bll_sp = new BLL_SanPham();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void dgv_DSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadingSanPham();
        }

        private void LoadingSanPham()
        {
            dgv_DSSP.DataSource = bll_sp.GetAllSanPham();
        }
    }
}

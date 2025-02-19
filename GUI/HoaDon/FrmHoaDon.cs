using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.HoaDon
{
    public partial class FrmHoaDon : Form
    {
        private BLL_SanPham BLL_SP = new BLL_SanPham();
        private BLL_LoSanPham BLL_LoSP = new BLL_LoSanPham();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void dgv_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadingSanPham()
        {
            dgv_SP.DataSource = BLL_SP.GetAllSanPham();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadingSanPham();
        }

        private void dgv_loSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maSP = Convert.ToInt32(dgv_SP.Rows[e.RowIndex].Cells["MaSP"].Value);

                LoadLoSanPham(maSP);
            }
        }
        private void LoadLoSanPham(int maSP)
        {
            dgv_loSanPham.DataSource = BLL_LoSP.GetLoSanPhamByMaSP(maSP);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

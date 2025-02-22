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

namespace GUI.QL_HoaDOnNHap
{
    public partial class Frm_QL_HoaDonXuat : Form
    {
        public BLL_PhieuXuat bll = new BLL_PhieuXuat();
        public Frm_QL_HoaDonXuat()
        {
            InitializeComponent();
        }

        private void gdv_hoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_Detail_HoaDonXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Frm_QL_HoaDonXuat_Load(object sender, EventArgs e)
        {
            gdv_hoaDonXuat.DataSource = bll.LayDanhSachPhieuXuat();
            dgv_Detail_HoaDonXuat.SelectionChanged += Dgv_Detail_HoaDonXuat_SelectionChanged;
            gdv_hoaDonXuat.SelectionChanged += Gdv_hoaDonXuat_SelectionChanged;
            gdv_hoaDonXuat.ColumnHeadersHeight = 40;
            dgv_Detail_HoaDonXuat.ColumnHeadersHeight = 40;
        }

        private void Gdv_hoaDonXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (gdv_hoaDonXuat.SelectedRows.Count > 0)
            {
                int maPhieuXuat = Convert.ToInt32(gdv_hoaDonXuat.SelectedRows[0].Cells["MaHD"].Value);

                dgv_Detail_HoaDonXuat.DataSource = bll.LayChiTietPhieuXuat(maPhieuXuat);
            }
            else
            {
                dgv_Detail_HoaDonXuat.DataSource = null;
            }
        }

        private void Dgv_Detail_HoaDonXuat_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}

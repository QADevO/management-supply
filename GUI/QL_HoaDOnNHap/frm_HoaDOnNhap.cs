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

namespace GUI.QL_HoaDOnNHap
{
    public partial class frm_HoaDOnNhap : Form
    {
        public BLL_PhieuNhap bll = new BLL_PhieuNhap();
        public frm_HoaDOnNhap()
        {
            InitializeComponent();
        }

        private void frm_HoaDOnNhap_Load(object sender, EventArgs e)
        {
            dgv_hoadonnhap.SelectionChanged += Dgv_hoadonnhap_SelectionChanged;
            dgv_hoadonnhap.ColumnHeadersHeight = 40;
            dgv_hoadonnhap_detail.ColumnHeadersHeight = 40;
        }

        private void Dgv_hoadonnhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_hoadonnhap.SelectedRows.Count > 0)
            {
                int maPhieuNhap = Convert.ToInt32(dgv_hoadonnhap.SelectedRows[0].Cells["MaNhap"].Value);
                dgv_hoadonnhap_detail.DataSource = bll.GetInvoiceDetails(maPhieuNhap);
            }
        }

        private void dgv_hoadonnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_hoadonnhap_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

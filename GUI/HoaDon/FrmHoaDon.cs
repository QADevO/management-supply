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
        private BLL_DaiLy BLL_DaiLy = new BLL_DaiLy();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

       

        private void LoadingSanPham()
        {
            dgv_SP.DataSource = BLL_SP.GetAllSanPham();
        }
        private void loadingDaiLy()
        {
            List<DTO.DaiLy> dsDL = BLL_DaiLy.GetAllDL();
            cbb_listDaiLy.DataSource = dsDL;
            cbb_listDaiLy.DisplayMember = "TenDL";
            cbb_listDaiLy.ValueMember = "MaDL";
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadingSanPham();
            loadingDaiLy();
            // Định nghĩa các cột nếu chưa có
            dgv_invoice_detail.ColumnCount = 6;
            dgv_invoice_detail.Columns[0].Name = "Mã Lô Hàng";
            dgv_invoice_detail.Columns[1].Name = "Tên Sản Phẩm";
            dgv_invoice_detail.Columns[2].Name = "Số Lượng";
            dgv_invoice_detail.Columns[3].Name = "Đơn Vị Tính";
            dgv_invoice_detail.Columns[4].Name = "Giá";
            dgv_invoice_detail.Columns[5].Name = "Thành Tiền";
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

      
        private void cbb_listDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgv_loSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_loSanPham.Rows[e.RowIndex];

                txt_MaLoHang.Text = row.Cells["MaLoSP"].Value?.ToString();
            }
        }
        private void dgv_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SP.Rows[e.RowIndex];
                txt_MaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txt_TenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txt_Gia.Text = row.Cells["DonGia"].Value?.ToString();
                txt_donViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
            }
        }
        private void txt_MaLoHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_soLuongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SLBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_donViTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_loSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường dữ liệu có được nhập không
            if (string.IsNullOrWhiteSpace(txt_MaLoHang.Text) ||
                string.IsNullOrWhiteSpace(txt_TenSP.Text) ||
                string.IsNullOrWhiteSpace(txt_SLBan.Text) ||
                string.IsNullOrWhiteSpace(txt_donViTinh.Text) ||
                string.IsNullOrWhiteSpace(txt_Gia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi số lượng và giá sang kiểu số
            if (!int.TryParse(txt_SLBan.Text, out int soLuongMoi))
            {
                MessageBox.Show("Số lượng bán phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txt_Gia.Text, out decimal gia))
            {
                MessageBox.Show("Giá phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maLoHang = txt_MaLoHang.Text;
            bool daTonTai = false;

            // Kiểm tra xem mã lô hàng đã tồn tại trong DataGridView chưa
            foreach (DataGridViewRow row in dgv_invoice_detail.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maLoHang)
                {
                    // Cộng dồn số lượng
                    int soLuongHienTai = Convert.ToInt32(row.Cells[2].Value);
                    int soLuongMoiCapNhat = soLuongHienTai + soLuongMoi;
                    row.Cells[2].Value = soLuongMoiCapNhat;

                    // Cập nhật thành tiền
                    decimal thanhTienMoi = soLuongMoiCapNhat * gia;
                    row.Cells[5].Value = thanhTienMoi;

                    daTonTai = true;
                    break;
                }
            }

            // Nếu không tìm thấy mã lô hàng, thêm hàng mới
            if (!daTonTai)
            {
                decimal thanhTien = soLuongMoi * gia;
                dgv_invoice_detail.Rows.Add(maLoHang, txt_TenSP.Text, soLuongMoi, txt_donViTinh.Text, gia, thanhTien);
            }

            // Xóa dữ liệu trên các textbox sau khi thêm
            txt_MaLoHang.Clear();
            txt_TenSP.Clear();
            txt_SLBan.Clear();
            txt_donViTinh.Clear();
            txt_Gia.Clear();
        }

        private void dgv_invoice_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

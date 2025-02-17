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

namespace GUI.NguyenLieu
{
    public partial class FrmNguyenLieu : Form
    {
        private BLL_NguyenLieu bll = new BLL_NguyenLieu();
        public FrmNguyenLieu()
        {
            InitializeComponent();
            LoadNguyenLieuData();
        }
        // Tải dữ liệu nguyên liệu vào DataGridView
        private void LoadNguyenLieuData()
        {
            List<DTO.NguyenLieu> nguyenLieuList = bll.GetAllNguyenLieu();
            dgv_NguyenLieu.DataSource = nguyenLieuList;
        }
        private void txt_MaNL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenNL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TonKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNL.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa.");
                return;
            }

            // Xóa nguyên liệu
            bool result = bll.DeleteNguyenLieu(int.Parse(txt_MaNL.Text.Trim()));
            if (result)
            {
                MessageBox.Show("Xóa nguyên liệu thành công!");
                LoadNguyenLieuData(); // Tải lại danh sách nguyên liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy nguyên liệu để xóa.");
            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txt_TenNL.Text.Trim()))
            {
                MessageBox.Show("Tên nguyên liệu không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DVT.Text.Trim()))
            {
                MessageBox.Show("Đơn vị tính không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TonKho.Text.Trim()) || !int.TryParse(txt_TonKho.Text.Trim(), out _))
            {
                MessageBox.Show("Số lượng tồn kho phải là một số hợp lệ.");
                return;
            }

            // Tạo đối tượng nguyên liệu mới
            DTO.NguyenLieu newNguyenLieu = new DTO.NguyenLieu
            {
                TenNL = txt_TenNL.Text.Trim(),
                DonViTinh = txt_DVT.Text.Trim(),
                TonKho = int.Parse(txt_TonKho.Text.Trim())
            };

            // Thêm nguyên liệu vào cơ sở dữ liệu
            bool result = bll.AddNguyenLieu(newNguyenLieu);
            if (result)
            {
                MessageBox.Show("Thêm nguyên liệu thành công!");
                LoadNguyenLieuData(); // Tải lại danh sách nguyên liệu
            }
            else
            {
                MessageBox.Show("Tên nguyên liệu đã tồn tại.");
            }
        }

        private void dgv_NguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NguyenLieu.Rows[e.RowIndex];
                txt_MaNL.Text = row.Cells["MaNL"].Value.ToString();
                txt_TenNL.Text = row.Cells["TenNL"].Value.ToString();
                txt_DVT.Text = row.Cells["DonViTinh"].Value.ToString();
                txt_TonKho.Text = row.Cells["TonKho"].Value.ToString();
            }
        }

        private void FrmNguyenLieu_Load(object sender, EventArgs e)
        {

        }
    }
}

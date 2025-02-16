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

namespace GUI.NhanVien
{
    public partial class FrmNhanVien : Form
    {
        private BLL_NhanVien bll_nhanvien = new BLL_NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                int maNV = Convert.ToInt32(dgv_NhanVien.SelectedRows[0].Cells["MaNV"].Value);

                if (bll_nhanvien.DeleteNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count > 0)
            {
                int maNV = Convert.ToInt32(dgv_NhanVien.SelectedRows[0].Cells["MaNV"].Value);

                DTO.NhanVien nv = new DTO.NhanVien
                {
                    MaNV = maNV,
                    HoTen = txt_TenNV.Text,
                    ChucVu = cb_ChucVu.Text,
                    SoDienThoai = txt_DienThoai.Text,
                    Email = txt_Email.Text,
                    MatKhau = txt_MatKhau.Text
                };

                if (bll_nhanvien.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO.NhanVien nv = new DTO.NhanVien
            {
                HoTen = txt_TenNV.Text,
                ChucVu = cb_ChucVu.Text,
                SoDienThoai = txt_DienThoai.Text,
                Email = txt_Email.Text,
                MatKhau = txt_MatKhau.Text
            };

            if (bll_nhanvien.AddNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }
       
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_chuVu_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void txt_TenNV_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void cb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        // Hiển thị danh sách nhân viên lên DataGridView
        private void LoadNhanVien()
        {
            dgv_NhanVien.DataSource = bll_nhanvien.GetAllNhanVien();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để tránh lỗi khi click vào tiêu đề
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
                cb_ChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txt_DienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }
    }
}

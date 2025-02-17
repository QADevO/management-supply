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

namespace GUI.NhaCungCap
{
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
            LoadNhaCungCapData();
        }
        private void LoadNhaCungCapData()
        {
            BLL_NhaCungCap bll = new BLL_NhaCungCap();
            List<DTO.NhaCungCap> nccList = bll.GetAllNCC();
            dgv_NhaCungCap.DataSource = nccList;
        }


        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            BLL_NhaCungCap bll = new BLL_NhaCungCap();
            List<DTO.NhaCungCap> nccList = bll.SearchNCC(keyword);
            dgv_NhaCungCap.DataSource = nccList;
        }


        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txt_MaNCC.Text.Trim()) || !int.TryParse(txt_MaNCC.Text.Trim(), out int maNCC))
            {
                MessageBox.Show("Mã nhà cung cấp phải là một số hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNCC.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_Email.Text.Trim()) || !txt_Email.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DienThoai.Text.Trim()) || txt_DienThoai.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            // Create new NhaCungCap object
            DTO.NhaCungCap newNCC = new DTO.NhaCungCap
            {
                MaNCC = maNCC, // Use parsed integer value
                TenNCC = txt_TenNCC.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                DiaChi = txt_DiaChi.Text.Trim(),
                SoDienThoai = txt_DienThoai.Text.Trim()
            };

            // Add supplier via BLL
            BLL_NhaCungCap bll = new BLL_NhaCungCap();
            bool result = bll.AddNCC(newNCC);

            // Check the result and show message
            if (result)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                LoadNhaCungCapData(); // Refresh the data grid
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại!");
            }
        }


        private void txt_MaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Validate the inputs
            if (string.IsNullOrEmpty(txt_MaNCC.Text.Trim()) || !int.TryParse(txt_MaNCC.Text.Trim(), out int maNCC))
            {
                MessageBox.Show("Mã nhà cung cấp phải là một số hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNCC.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_Email.Text.Trim()) || !txt_Email.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DienThoai.Text.Trim()) || txt_DienThoai.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            // Create the updated NhaCungCap object with data from the form
            DTO.NhaCungCap updatedNCC = new DTO.NhaCungCap
            {
                MaNCC = maNCC, // Ensure that MaNCC is properly set
                TenNCC = txt_TenNCC.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                DiaChi = txt_DiaChi.Text.Trim(),
                SoDienThoai = txt_DienThoai.Text.Trim()
            };

            // Call the BLL to update the supplier
            BLL_NhaCungCap bll = new BLL_NhaCungCap();
            bool result = bll.UpdateNCC(updatedNCC);

            // Provide feedback to the user based on the result
            if (result)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                LoadNhaCungCapData(); // Refresh the supplier list
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhaCungCap.Rows[e.RowIndex];

                txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString(); 
                txt_TenNCC.Text = row.Cells["TenNCC"].Value.ToString(); 
                txt_Email.Text = row.Cells["Email"].Value.ToString(); 
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString(); 
                txt_DienThoai.Text = row.Cells["SoDienThoai"].Value.ToString(); 
            }
        }
    }
}

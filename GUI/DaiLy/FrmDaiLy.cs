using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DaiLy
{
    public partial class FrmDaiLy : Form
    {
        BLL_DaiLy bllDl = new BLL_DaiLy();
        public FrmDaiLy()
        {
            InitializeComponent();
            LoadDaiLyData();
            btn_ThemMoi.Click += Btn_ThemMoi_Click;
            btn_CapNhat.Click += Btn_CapNhat_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaDL.Text.Trim()) || !int.TryParse(txt_MaDL.Text.Trim(), out int maDL))
            {
                MessageBox.Show("Vui lòng chọn một đại lý hợp lệ để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đại lý này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = bllDl.DeleteDaiLy(maDL);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa đại lý thành công!");
                    LoadDaiLyData(); // Cập nhật danh sách
                    ClearFields(); // Xóa dữ liệu trên form
                }
                else
                {
                    MessageBox.Show("Xóa đại lý thất bại! Vui lòng thử lại.");
                }
            }
        }

        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            List<DTO.DaiLy> dlList = bllDl.SearchDLByName(keyword);
            dgv_DaiLy.DataSource = dlList;
        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Validate the inputs
            if (string.IsNullOrEmpty(txt_MaDL.Text.Trim()) || !int.TryParse(txt_MaDL.Text.Trim(), out int maDL))
            {
                MessageBox.Show("Mã đại lý phải là một số hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenDL.Text.Trim()))
            {
                MessageBox.Show("Tên đại lý không được để trống.");
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

            DTO.DaiLy updatedDL = new DTO.DaiLy
            {
                MaDL = maDL, 
                TenDL = txt_TenDL.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                DiaChi = txt_DiaChi.Text.Trim(),
                SoDienThoai = txt_DienThoai.Text.Trim()
            };

            bool result = bllDl.UpdateDLInfo(updatedDL);
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin đại lý thành công!");
                LoadDaiLyData(); // Refresh the supplier list
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin đại lý thất bại!");
            }

        }

        private void Btn_ThemMoi_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txt_MaDL.Text.Trim()) || !int.TryParse(txt_MaDL.Text.Trim(), out int maDL))
            {
                MessageBox.Show("Mã đại lý phải là một số hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenDL.Text.Trim()))
            {
                MessageBox.Show("Tên đại lý không được để trống.");
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

            // Create new DaiLy object
            DTO.DaiLy newDL = new DTO.DaiLy
            {
                MaDL = maDL, // Use parsed integer value
                TenDL = txt_TenDL.Text.Trim(),
                Email = txt_Email.Text.Trim(),
                DiaChi = txt_DiaChi.Text.Trim(),
                SoDienThoai = txt_DienThoai.Text.Trim()
            };

            //Add DL
            bool result = bllDl.AddNewDL(newDL);

            if (result)
            {
                MessageBox.Show("Thêm đại lý mới thành công!");
                LoadDaiLyData();
            }
            else
            {
                MessageBox.Show("Thêm đại lý thất bại!");
            }
        }

        private void LoadDaiLyData()
        {
            BLL_DaiLy bll = new BLL_DaiLy();
            List<DTO.DaiLy> dlList = bll.GetAllDL();
            dgv_DaiLy.DataSource = dlList;
        }

        private void dgv_DaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DaiLy.Rows[e.RowIndex];

                txt_MaDL.Text = row.Cells["MaDL"].Value.ToString();
                txt_TenDL.Text = row.Cells["TenDL"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_DienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
            }
        }

        // Hàm xóa dữ liệu trong các ô nhập
        private void ClearFields()
        {
            txt_MaDL.Clear();
            txt_TenDL.Clear();
            txt_Email.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
        }
    }
}

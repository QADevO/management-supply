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
            LoadingSanPham();
            btn_ThemMoi.Click += Btn_ThemMoi_Click;
            btn_CapNhat.Click += Btn_CapNhat_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_TimKiem.Click += Btn_TimKiem_Click;
        }

        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            List<DTO.SanPham> spList = bll_sp.SearchSPByName(keyword);
            dgv_DSSP.DataSource = spList;
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSP.Text.Trim()) || !int.TryParse(txt_MaSP.Text.Trim(), out int maSP))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm hợp lệ để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = bll_sp.DeleteSP(maSP);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadingSanPham(); // Cập nhật danh sách
                    ClearFields(); // Xóa dữ liệu trên form
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại! Vui lòng thử lại.");
                }
            }

        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txt_MaSP.Text.Trim()) || !int.TryParse(txt_MaSP.Text.Trim(), out int maSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenSP.Text.Trim()))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DonViTinh.Text.Trim()))
            {
                MessageBox.Show("Đơn vị tính không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_SoLuongTon.Text.Trim()) || !int.TryParse(txt_SoLuongTon.Text.Trim(), out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ (phải là số nguyên không âm).");
                return;
            }

            DTO.SanPham updateSP = new DTO.SanPham
            {
                MaSP = maSP, // Use parsed integer value
                TenSP = txt_TenSP.Text.Trim(),
                DonViTinh = txt_DonViTinh.Text.Trim(),
                SoLuongTon = soLuongTon,
            };

            bool result = bll_sp.UpdateSPInfo(updateSP);
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                LoadingSanPham();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!");
            }

        }

        private void Btn_ThemMoi_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txt_MaSP.Text.Trim()) || !int.TryParse(txt_MaSP.Text.Trim(), out int maSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenSP.Text.Trim()))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_DonViTinh.Text.Trim()))
            {
                MessageBox.Show("Đơn vị tính không được để trống.");
                return;
            }
            if (string.IsNullOrEmpty(txt_SoLuongTon.Text.Trim()) || !int.TryParse(txt_SoLuongTon.Text.Trim(), out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ (phải là số nguyên không âm).");
                return;
            }

            // Create new DaiLy object
            DTO.SanPham newSP = new DTO.SanPham
            {
                MaSP = maSP, // Use parsed integer value
                TenSP = txt_TenSP.Text.Trim(),
                DonViTinh = txt_DonViTinh.Text.Trim(),
                SoLuongTon = soLuongTon,
            };

            bool result = bll_sp.AddNewSP(newSP);

            if (result)
            {
                MessageBox.Show("Thêm sản phẩm mới thành công!");
                LoadingSanPham();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
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

        private void dgv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSSP.Rows[e.RowIndex];

                txt_MaSP.Text = row.Cells["MaSP"].Value.ToString();
                txt_TenSP.Text = row.Cells["TenSP"].Value.ToString();
                txt_DonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txt_SoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_DonViTinh.Clear();
            txt_SoLuongTon.Clear();
        }
    }
}

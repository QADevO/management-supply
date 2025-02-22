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
using System.Text.RegularExpressions;

namespace GUI.NguyenLieu
{
    public partial class FrmNguyenLieu : Form
    {
        private BLL_NguyenLieu bll = new BLL_NguyenLieu();
        private BLL_NhaCungCap ncc = new BLL_NhaCungCap();
        public FrmNguyenLieu()
        {
            InitializeComponent();
            LoadNguyenLieuData();
            LoadNhaCungCap();
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
            if (dgv_HD_NhapHang.Columns.Count == 0)
            {
                dgv_HD_NhapHang.Columns.Add("MaNL", "Mã NL");
                dgv_HD_NhapHang.Columns.Add("TenNL", "Tên Nguyên Liệu");
                dgv_HD_NhapHang.Columns.Add("DonViTinh", "Đơn Vị Tính");
                dgv_HD_NhapHang.Columns.Add("SoLuong", "Số Lượng");
                dgv_HD_NhapHang.Columns.Add("GiaNhap", "Giá Nhập");

                // Thêm cột nút xóa
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.Name = "Xoa";
                btnXoa.HeaderText = "Xóa";
                btnXoa.Text = "Xóa";
                btnXoa.UseColumnTextForButtonValue = true;
                dgv_HD_NhapHang.Columns.Add(btnXoa);
            }

            dgv_HD_NhapHang.ColumnHeadersHeight = 40;
            dgv_NguyenLieu.ColumnHeadersHeight = 40;
        }

        private void btn_SL_NhapThem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemVaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNL.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần nhập.");
                return;
            }

            if (string.IsNullOrEmpty(btn_SL_NhapThem.Text.Trim()) || !int.TryParse(btn_SL_NhapThem.Text.Trim(), out int soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập phải là một số nguyên dương.");
                return;
            }

            if (string.IsNullOrEmpty(txt_GiaNhap.Text.Trim()) || !decimal.TryParse(txt_GiaNhap.Text.Trim(), out decimal giaNhap) || giaNhap <= 0)
            {
                MessageBox.Show("Giá nhập phải là một số hợp lệ và lớn hơn 0.");
                return;
            }

            int maNL = int.Parse(txt_MaNL.Text.Trim());
            string tenNL = txt_TenNL.Text.Trim();
            string donViTinh = txt_DVT.Text.Trim();

            bool isExist = false;
            foreach (DataGridViewRow row in dgv_HD_NhapHang.Rows)
            {
                if (row.Cells["MaNL"].Value != null && (int)row.Cells["MaNL"].Value == maNL)
                {
                    int soLuongHienTai = (int)row.Cells["SoLuong"].Value;
                    row.Cells["SoLuong"].Value = soLuongHienTai + soLuongNhap;
                    row.Cells["GiaNhap"].Value = giaNhap;
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                dgv_HD_NhapHang.Rows.Add(maNL, tenNL, donViTinh, soLuongNhap, giaNhap);
            }

            btn_SL_NhapThem.Clear();
            txt_GiaNhap.Clear();
        }

        private void dgv_HD_NhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_HD_NhapHang.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dgv_HD_NhapHang.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_TaoHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (dgv_HD_NhapHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có nguyên liệu nào trong hóa đơn nhập.");
                return;
            }
            int mancc = Convert.ToInt32(cbb_nhaCungCap.SelectedValue);
            // Tạo đối tượng phiếu nhập nguyên liệu mới
            PhieuNhapNguyenLieu phieuNhap = new PhieuNhapNguyenLieu
            {
                NgayNhap = DateTime.Now,
                TongTien = 0, // Sẽ tính sau
                TrinhTrangDonHang = 1,
                MaNhanVien = CurrentUser.UserID,
                MaNCC = mancc

            };

            List<ChiTietPhieuNhapNguyenLieu> chiTietPhieuNhapList = new List<ChiTietPhieuNhapNguyenLieu>();
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgv_HD_NhapHang.Rows)
            {
                if (row.Cells["MaNL"].Value == null) continue;

                int maNL = Convert.ToInt32(row.Cells["MaNL"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                decimal giaNhap = Convert.ToDecimal(row.Cells["GiaNhap"].Value);
                tongTien += soLuong * giaNhap;

                chiTietPhieuNhapList.Add(new ChiTietPhieuNhapNguyenLieu
                {
                    MaNL = maNL,
                    SoLuong = soLuong,
                    GiaNhap = giaNhap
                });
            }

            phieuNhap.TongTien = tongTien;

            // Gọi BLL để lưu phiếu nhập vào cơ sở dữ liệu
            BLL_PhieuNhap bllPhieuNhap = new BLL_PhieuNhap();
            bool result = bllPhieuNhap.TaoPhieuNhap(phieuNhap, chiTietPhieuNhapList);

            if (result)
            {
                MessageBox.Show("Tạo hóa đơn nhập thành công!");
                dgv_HD_NhapHang.Rows.Clear(); // Xóa danh sách sau khi tạo hóa đơn thành công
                LoadNguyenLieuData(); // Cập nhật lại danh sách nguyên liệu
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn nhập thất bại!");
            }
        }

        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_nhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadNhaCungCap()
        {
            List<DTO.NhaCungCap> danhSachNCC = ncc.GetAllNCC();

            cbb_nhaCungCap.DataSource = danhSachNCC;
            cbb_nhaCungCap.DisplayMember = "TenNCC";  // Tên cột hiển thị
            cbb_nhaCungCap.ValueMember = "MaNCC";     // Giá trị ẩn
        }

    }
}

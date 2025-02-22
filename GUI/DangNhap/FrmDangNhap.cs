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
using GUI.TrangChu;

namespace GUI.DangNhap
{
    public partial class FrmDangNhap : Form
    {
        private BLL_NhanVien bll_nhanvien = new BLL_NhanVien();
        public FrmDangNhap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string email = txt_TaiKhoan.Text.Trim();
            string password = txt_MatKhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isLoginSuccessful = bll_nhanvien.login(email, password);
            // Lấy thông tin user thay vì chỉ kiểm tra đăng nhập
            var user = bll_nhanvien.GetUserByEmailAndPassword(email, password);
            if (isLoginSuccessful)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu thông tin vào biến tĩnh
                CurrentUser.Username = user.HoTen;
                CurrentUser.UserID = user.MaNV;
                // Mở giao diện chính và đóng form đăng nhập
                FrmTrangChu frmMain = new FrmTrangChu();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

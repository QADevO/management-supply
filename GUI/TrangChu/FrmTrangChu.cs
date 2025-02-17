using GUI.DangNhap;
using GUI.NhanVien;
using GUI.NhaCungCap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.HoaDon;
using GUI.SanPham;
using GUI.DaiLy;

namespace GUI.TrangChu
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
            btn_NhaPhanPhoi.Click += Btn_NhaPhanPhoi_Click;
            btn_SanPham.Click += Btn_SanPham_Click;
            btn_NhanVien.Click += Btn_NhanVien_Click;
            btn_HoaDon.Click += Btn_HoaDon_Click;
            btn_NhaCungCap.Click += Btn_NhaCungCap_Click;
            btn_DangXuat.Click += Btn_DangXuat_Click;
        }

        private void Btn_DangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.Show();
            this.Hide();
        }

        private void Btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Quản Lý Nhà Cung Cấp";
            AddControls(new FrmNhaCungCap());

        }

        private void Btn_HoaDon_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Quản Lý Hóa Đơn";
            AddControls(new FrmHoaDon());
        }

        private void Btn_NhanVien_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Quản Lý Nhân Viên";
            AddControls(new FrmNhanVien());
        }

        private void Btn_SanPham_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Quản Lý Sản Phẩm";
            AddControls(new FrmSanPham());
        }

        private void Btn_NhaPhanPhoi_Click(object sender, EventArgs e)
        {
            lbl_TieuDe.Text = "Quản Lý Nhà Phân Phối";
            AddControls(new FrmDaiLy());
        }

        static FrmTrangChu _obj;
        public static FrmTrangChu Instance
        {
            get { if (_obj == null) { _obj = new FrmTrangChu(); } return _obj; }
        }

        public void AddControls(Form f)
        {
            panel_NoiDung.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_NoiDung.Controls.Add(f);
            f.Show();
        }

    }
}

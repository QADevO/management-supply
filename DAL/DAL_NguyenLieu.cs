using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NguyenLieu
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();

        // Lấy tất cả nguyên liệu
        public List<NguyenLieu> GetAll_NguyenLieu()
        {
            return sql.NguyenLieus.ToList();
        }

        // Kiểm tra tên nguyên liệu có bị trùng hay không
        public bool IsNameExist(string name)
        {
            return sql.NguyenLieus.Any(nl => nl.TenNL == name);
        }

        // Thêm nguyên liệu mới
        public bool AddNguyenLieu(NguyenLieu newNguyenLieu)
        {
            if (IsNameExist(newNguyenLieu.TenNL))
            {
                return false; // Tên nguyên liệu đã tồn tại
            }

            sql.NguyenLieus.InsertOnSubmit(newNguyenLieu);
            sql.SubmitChanges();
            return true;
        }

        // Sửa nguyên liệu
        public bool UpdateNguyenLieu(NguyenLieu updatedNguyenLieu)
        {
            var existingNguyenLieu = sql.NguyenLieus.SingleOrDefault(nl => nl.MaNL == updatedNguyenLieu.MaNL);
            if (existingNguyenLieu == null)
            {
                return false; // Không tìm thấy nguyên liệu để sửa
            }

            // Kiểm tra tên nguyên liệu mới có bị trùng không
            if (IsNameExist(updatedNguyenLieu.TenNL) && existingNguyenLieu.TenNL != updatedNguyenLieu.TenNL)
            {
                return false; // Tên nguyên liệu mới đã tồn tại
            }

            // Cập nhật thông tin
            existingNguyenLieu.TenNL = updatedNguyenLieu.TenNL;
            existingNguyenLieu.DonViTinh = updatedNguyenLieu.DonViTinh; // Thêm các thuộc tính cần cập nhật
            existingNguyenLieu.TonKho = updatedNguyenLieu.TonKho;

            sql.SubmitChanges();
            return true;
        }

        // Xóa nguyên liệu
        public bool DeleteNguyenLieu(int maNguyenLieu)
        {
            var nguyenLieuToDelete = sql.NguyenLieus.SingleOrDefault(nl => nl.MaNL == maNguyenLieu);
            if (nguyenLieuToDelete == null)
            {
                return false; // Không tìm thấy nguyên liệu để xóa
            }

            sql.NguyenLieus.DeleteOnSubmit(nguyenLieuToDelete);
            sql.SubmitChanges();
            return true;
        }
    }
}

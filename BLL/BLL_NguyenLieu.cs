using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NguyenLieu
    {
        private DAL_NguyenLieu dal = new DAL_NguyenLieu();

        // Lấy tất cả nguyên liệu
        public List<NguyenLieu> GetAllNguyenLieu()
        {
            return dal.GetAll_NguyenLieu();
        }

        // Kiểm tra tên nguyên liệu có tồn tại không
        public bool IsNameExist(string name)
        {
            return dal.IsNameExist(name);
        }

        // Thêm nguyên liệu mới
        public bool AddNguyenLieu(NguyenLieu newNguyenLieu)
        {
            return dal.AddNguyenLieu(newNguyenLieu);
        }

        // Cập nhật thông tin nguyên liệu
        public bool UpdateNguyenLieu(NguyenLieu updatedNguyenLieu)
        {
            return dal.UpdateNguyenLieu(updatedNguyenLieu);
        }

        // Xóa nguyên liệu
        public bool DeleteNguyenLieu(int maNguyenLieu)
        {
            return dal.DeleteNguyenLieu(maNguyenLieu);
        }
    }
}

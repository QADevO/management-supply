using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhaCungCap
    {
        private DAL_NhaCungCap dalNCC = new DAL_NhaCungCap();

        // Lấy danh sách nhà cung cấp
        public List<NhaCungCap> GetAllNCC()
        {
            return dalNCC.GetAll_NCC();
        }

        // Thêm nhà cung cấp
        public bool AddNCC(NhaCungCap ncc)
        {
            return dalNCC.AddNCC(ncc);
        }

        // Sửa nhà cung cấp
        public bool UpdateNCC(NhaCungCap ncc)
        {
            return dalNCC.UpdateNCC(ncc);
        }

        // Xóa nhà cung cấp
        public bool DeleteNCC(int maNCC)
        {
            return dalNCC.DeleteNCC(maNCC);
        }

        // Tìm kiếm nhà cung cấp
        public List<NhaCungCap> SearchNCC(string keyword)
        {
            return dalNCC.SearchNCC(keyword);
        }
    }
}

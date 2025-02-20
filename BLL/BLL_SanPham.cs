using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SanPham
    {
        private DAL_SanPham dalSanPham = new DAL_SanPham();

        public List<SanPham> GetAllSanPham()
        {
            return dalSanPham.GetAllSanPham();
        }

        //thêm đại lý
        public bool AddNewSP(SanPham sp)
        {
            return dalSanPham.AddSP(sp);
        }

        // Sửa thông tin đại  lý
        public bool UpdateSPInfo(SanPham sp)
        {
            return dalSanPham.UpdateSP(sp);
        }

        // Xóa đại lý
        public bool DeleteSP(int maDL)
        {
            return dalSanPham.DeleteSP(maDL);
        }

        // Tìm kiếm nhà cung cấp
        public List<SanPham> SearchSPByName(string keyword)
        {
            return dalSanPham.SearchSPByName(keyword);
        }
    }
}

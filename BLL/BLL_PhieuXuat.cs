using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_PhieuXuat
    {
        private DAL_PhieuXuat dalPhieuXuat = new DAL_PhieuXuat();
        public List<HoaDon> LayDanhSachPhieuXuat()
        {
            return dalPhieuXuat.GetDanhSachPhieuXuat();
        }

        public List<ChiTietHoaDon> LayChiTietPhieuXuat(int maHD)
        {
            return dalPhieuXuat.GetChiTietPhieuXuat(maHD);
        }
    }
}

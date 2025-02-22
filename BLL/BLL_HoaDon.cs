using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_HoaDon
    {
        private DAL_PhieuXuat dal_phieuXuat;
        public BLL_HoaDon()
        {
            dal_phieuXuat = new DAL_PhieuXuat();
        }
        public bool TaoPhieuNhap(HoaDon hd, List<ChiTietHoaDon> cthd)
        {
            if (hd == null || cthd == null || cthd.Count == 0)
            {
                throw new ArgumentException("Dữ liệu phiếu nhập không hợp lệ!");
            }

            return dal_phieuXuat.CreateInvoiceWithDetails(hd, cthd);
        }
    }
}

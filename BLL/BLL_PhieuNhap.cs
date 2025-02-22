using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_PhieuNhap
    {
        private DAL_PhieuNhap dalPhieuNhap;

        public BLL_PhieuNhap()
        {
            dalPhieuNhap = new DAL_PhieuNhap();
        }

        public bool TaoPhieuNhap(PhieuNhapNguyenLieu phieuNhap, List<ChiTietPhieuNhapNguyenLieu> chiTietPhieuNhap)
        {
            if (phieuNhap == null || chiTietPhieuNhap == null || chiTietPhieuNhap.Count == 0)
            {
                throw new ArgumentException("Dữ liệu phiếu nhập không hợp lệ!");
            }

            return dalPhieuNhap.CreateInvoiceWithDetails(phieuNhap, chiTietPhieuNhap);
        }
        public List<PhieuNhapNguyenLieu> GetAllInvoices()
        {
            return dalPhieuNhap.GetAllInvoices();
        }
        public List<ChiTietPhieuNhapNguyenLieu> GetInvoiceDetails(int maPhieuNhap)
        {
            return dalPhieuNhap.GetInvoiceDetails(maPhieuNhap);
        }

    }
}

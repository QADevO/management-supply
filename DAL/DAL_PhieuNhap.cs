using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DTO;

namespace DAL
{
    public class DAL_PhieuNhap
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();
        public bool CreateInvoiceWithDetails(PhieuNhapNguyenLieu phieunhap, List<ChiTietPhieuNhapNguyenLieu> chitietphieunhap)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    sql.PhieuNhapNguyenLieus.InsertOnSubmit(phieunhap);
                    sql.SubmitChanges();

                    int maNhapHang = phieunhap.MaNhap;

                    foreach (var detail in chitietphieunhap)
                    {
                        detail.MaPhieuNhap = maNhapHang;
                        sql.ChiTietPhieuNhapNguyenLieus.InsertOnSubmit(detail);
                    }
                    sql.SubmitChanges();

                    transaction.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

    }
}

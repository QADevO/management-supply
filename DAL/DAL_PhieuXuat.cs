using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DTO;

namespace DAL
{
    public class DAL_PhieuXuat
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();
        public bool CreateInvoiceWithDetails(HoaDon hoadon, List<ChiTietHoaDon> ctHoaDOn)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    sql.HoaDons.InsertOnSubmit(hoadon);
                    sql.SubmitChanges();

                    int maHD = hoadon.MaHD;

                    foreach (var detail in ctHoaDOn)
                    {
                        detail.MaHD = maHD;
                        sql.ChiTietHoaDons.InsertOnSubmit(detail);
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

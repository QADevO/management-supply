using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SanPham
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();

        // Lấy danh sách sản phẩm
        public List<SanPham> GetAllSanPham()
        {
            return sql.SanPhams.ToList();
        }

        // thêm sản phẩm mới
        public bool AddSP(SanPham sp)
        {
            try
            {
                sql.SanPhams.InsertOnSubmit(sp);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin sản phẩm
        public bool UpdateSP(SanPham sp)
        {
            try
            {
                var existingDL = sql.SanPhams.FirstOrDefault(n => n.MaSP == sp.MaSP);
                if (existingDL != null)
                {
                    existingDL.TenSP = sp.TenSP;
                    existingDL.DonViTinh = sp.DonViTinh;
                    existingDL.SoLuongTon = sp.SoLuongTon;

                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Xóa sản phẩm
        public bool DeleteSP(int maSP)
        {
            try
            {
                var sp = sql.SanPhams.FirstOrDefault(n => n.MaSP == maSP);
                if (sp != null)
                {
                    sql.SanPhams.DeleteOnSubmit(sp);
                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi khóa ngoại trong SQL Server
                {
                    throw new Exception("Không thể xóa sản phẩm này vì đang được tham chiếu ở bảng khác!");
                }
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Tìm kiếm nhà sản phẩm theo tên
        public List<SanPham> SearchSPByName(string keyword)
        {
            return sql.SanPhams.Where(n => n.TenSP.Contains(keyword)).ToList();
        }

    }
}

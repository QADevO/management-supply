using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DaiLy
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();
        public List<DaiLy> GetAll_DL()
        {
            return sql.DaiLies.ToList();
        }

        // thêm đại lý mới
        public bool AddDL(DaiLy dl)
        {
            try
            {
                sql.DaiLies.InsertOnSubmit(dl);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin đại lý
        public bool UpdateDL(DaiLy dl)
        {
            try
            {
                var existingDL = sql.DaiLies.FirstOrDefault(n => n.MaDL == dl.MaDL);
                if (existingDL != null)
                {
                    existingDL.TenDL = dl.TenDL;
                    existingDL.DiaChi = dl.DiaChi;
                    existingDL.SoDienThoai = dl.SoDienThoai;
                    existingDL.Email = dl.Email;

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

        // Xóa đại lý
        public bool DeleteDL(int maDL)
        {
            try
            {
                var dl = sql.DaiLies.FirstOrDefault(n => n.MaDL == maDL);
                if (dl != null)
                {
                    sql.DaiLies.DeleteOnSubmit(dl);
                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi khóa ngoại trong SQL Server
                {
                    throw new Exception("Không thể xóa đại lý này vì đang được tham chiếu ở bảng khác!");
                }
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Tìm kiếm nhà cung cấp theo tên
        public List<DaiLy> SearchDLByName(string keyword)
        {
            return sql.DaiLies.Where(n => n.TenDL.Contains(keyword)).ToList();
        }
    }
}

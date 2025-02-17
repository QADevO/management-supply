using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhaCungCap
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();
        public List<NhaCungCap> GetAll_NCC()
        {
            return sql.NhaCungCaps.ToList();
        }
        // Thêm nhà cung cấp
        public bool AddNCC(NhaCungCap ncc)
        {
            try
            {
                sql.NhaCungCaps.InsertOnSubmit(ncc);
                sql.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        // Sửa thông tin nhà cung cấp
        public bool UpdateNCC(NhaCungCap ncc)
        {
            try
            {
                var existingNCC = sql.NhaCungCaps.FirstOrDefault(n => n.MaNCC == ncc.MaNCC);
                if (existingNCC != null)
                {
                    existingNCC.TenNCC = ncc.TenNCC;
                    existingNCC.DiaChi = ncc.DiaChi;
                    existingNCC.SoDienThoai = ncc.SoDienThoai;
                    existingNCC.Email = ncc.Email;

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

        // Xóa nhà cung cấp
        public bool DeleteNCC(int maNCC)
        {
            try
            {
                var ncc = sql.NhaCungCaps.FirstOrDefault(n => n.MaNCC == maNCC);
                if (ncc != null)
                {
                    sql.NhaCungCaps.DeleteOnSubmit(ncc);
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

        // Tìm kiếm nhà cung cấp theo tên
        public List<NhaCungCap> SearchNCC(string keyword)
        {
            return sql.NhaCungCaps.Where(n => n.TenNCC.Contains(keyword)).ToList();
        }
    }
}

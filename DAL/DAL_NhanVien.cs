using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        chuoicungnungnuocngotDataContext sql = new chuoicungnungnuocngotDataContext();

        public bool Login(string email, string password)
        {
            try
            {
                return sql.NhanViens.Any(nv => nv.Email == email && nv.MatKhau == password);
            }
            catch
            {
                return false;
            }
        }

        // Hiển thị danh sách nhân viên
        public List<NhanVien> GetAllNhanVien()
        {
            return sql.NhanViens.ToList();
        }

        // Thêm nhân viên
        public bool AddNhanVien(NhanVien nv)
        {
            try
            {
                sql.NhanViens.InsertOnSubmit(nv);
                sql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sửa thông tin nhân viên
        public bool UpdateNhanVien(NhanVien nv)
        {
            try
            {
                var existingNV = sql.NhanViens.FirstOrDefault(n => n.MaNV == nv.MaNV);
                if (existingNV != null)
                {
                    existingNV.HoTen = nv.HoTen;
                    existingNV.ChucVu = nv.ChucVu;
                    existingNV.SoDienThoai = nv.SoDienThoai;
                    existingNV.Email = nv.Email;
                    existingNV.MatKhau = nv.MatKhau;

                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Xóa nhân viên
        public bool DeleteNhanVien(int maNV)
        {
            try
            {
                var nv = sql.NhanViens.FirstOrDefault(n => n.MaNV == maNV);
                if (nv != null)
                {
                    sql.NhanViens.DeleteOnSubmit(nv);
                    sql.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}

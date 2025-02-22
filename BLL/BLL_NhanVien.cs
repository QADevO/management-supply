using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   
    public class BLL_NhanVien
    {
        private DAL_NhanVien dal_nhanvien = new DAL_NhanVien();

        public bool login(string email, string password)
        {
            return dal_nhanvien.Login(email, password);
        }
        public NhanVien GetUserByEmailAndPassword(string email, string password)
        {
            return dal_nhanvien.GetUserByEmailAndPassword(email, password);
        }
        // Lấy danh sách nhân viên
        public List<NhanVien> GetAllNhanVien()
        {
            return dal_nhanvien.GetAllNhanVien();
        }

        // Thêm nhân viên
        public bool AddNhanVien(NhanVien nv)
        {
            return dal_nhanvien.AddNhanVien(nv);
        }

        // Sửa thông tin nhân viên
        public bool UpdateNhanVien(NhanVien nv)
        {
            return dal_nhanvien.UpdateNhanVien(nv);
        }

        // Xóa nhân viên
        public bool DeleteNhanVien(int maNV)
        {
            return dal_nhanvien.DeleteNhanVien(maNV);
        }
    }
}

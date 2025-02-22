using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_LoSanPham
    {
        private DAL_LoSanPham dalLoSanPham = new DAL_LoSanPham();

        public List<LoSanPham> GetAllLoSanPham()
        {
            return dalLoSanPham.GetAllLoSanPham();
        }
        public List<LoSanPham> GetLoSanPhamByMaSP(int masp)
        {
            return dalLoSanPham.GetLoSanPhamByMaSP(masp);
        }

        public bool AddLoSanPham(LoSanPham loSanPham)
        {
            if (loSanPham == null || loSanPham.MaSP == 0 || loSanPham.SoLuong <= 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                return false;
            }
            return dalLoSanPham.AddLoSanPham(loSanPham);
        }

        // Cập nhật lô sản phẩm
        public bool UpdateLoSanPham(LoSanPham loSanPham)
        {
            if (loSanPham == null || loSanPham.MaLoSP == 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ để cập nhật!");
                return false;
            }
            return dalLoSanPham.UpdateLoSanPham(loSanPham);
        }

        // Xóa lô sản phẩm
        public bool DeleteLoSanPham(int maLo)
        {
            if (maLo <= 0)
            {
                Console.WriteLine("Mã lô sản phẩm không hợp lệ!");
                return false;
            }
            return dalLoSanPham.DeleteLoSanPham(maLo);
        }
    }
}

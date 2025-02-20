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

    }
}

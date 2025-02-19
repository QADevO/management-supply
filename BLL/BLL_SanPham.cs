using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SanPham
    {
        private DAL_SanPham dalSanPham = new DAL_SanPham();

        public List<SanPham> GetAllSanPham()
        {
            return dalSanPham.GetAllSanPham();
        }
    }
}

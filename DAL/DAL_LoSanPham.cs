using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LoSanPham
    {
        chuoicungnungnuocngotDataContext db = new chuoicungnungnuocngotDataContext();
        public List<LoSanPham> GetAllLoSanPham()
        {
            return db.LoSanPhams.ToList();
        }

        public List<LoSanPham> GetLoSanPhamByMaSP(int maSP)
        {
            return db.LoSanPhams
                .Where(lo => lo.MaSP == maSP)
                .ToList();
        }

    }
}

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

        // Thêm mới lô sản phẩm
        public bool AddLoSanPham(LoSanPham loSanPham)
        {
            try
            {
                db.LoSanPhams.InsertOnSubmit(loSanPham);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm lô sản phẩm: " + ex.Message);
                return false;
            }
        }

        // Cập nhật thông tin lô sản phẩm
        public bool UpdateLoSanPham(LoSanPham loSanPham)
        {
            try
            {
                var lo = db.LoSanPhams.FirstOrDefault(l => l.MaLoSP == loSanPham.MaLoSP);
                if (lo != null)
                {
                    lo.MaSP = loSanPham.MaSP;
                    lo.NSX = loSanPham.NSX;
                    lo.HSD = loSanPham.HSD;
                    lo.SoLuong = loSanPham.SoLuong;

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật lô sản phẩm: " + ex.Message);
                return false;
            }
        }

        // Xóa lô sản phẩm
        public bool DeleteLoSanPham(int maLo)
        {
            try
            {
                var lo = db.LoSanPhams.FirstOrDefault(l => l.MaLoSP == maLo);
                if (lo != null)
                {
                    db.LoSanPhams.DeleteOnSubmit(lo);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa lô sản phẩm: " + ex.Message);
                return false;
            }
        }
    }
}

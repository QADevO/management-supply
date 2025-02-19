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
        chuoicungnungnuocngotDataContext db = new chuoicungnungnuocngotDataContext();

        // Lấy danh sách sản phẩm
        public List<SanPham> GetAllSanPham()
        {
            return db.SanPhams.ToList();
        }

    }
}

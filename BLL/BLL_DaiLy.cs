using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DaiLy
    {
        private DAL_DaiLy dalDL = new DAL_DaiLy();
        public List<DaiLy> GetAllDL()
        {
            return dalDL.GetAll_DL();
        }

        //thêm đại lý
        public bool AddNewDL(DaiLy dl)
        {
            return dalDL.AddDL(dl);
        }

        // Sửa thông tin đại  lý
        public bool UpdateDLInfo(DaiLy dl)
        {
            return dalDL.UpdateDL(dl);
        }

        // Xóa đại lý
        public bool DeleteDaiLy(int maDL)
        {
            return dalDL.DeleteDL(maDL);
        }


        // Tìm kiếm nhà cung cấp
        public List<DaiLy> SearchDLByName(string keyword)
        {
            return dalDL.SearchDLByName(keyword);
        }
    }
}

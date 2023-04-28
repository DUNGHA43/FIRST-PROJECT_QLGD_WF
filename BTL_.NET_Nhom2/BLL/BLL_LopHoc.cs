using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_LopHoc
    {
        DAL_LopHoc _LH = new DAL_LopHoc();
        //Hiển thị danh sách lớp học
        public DataTable HienthiDS()
        {
            return _LH.HienthiDS();
        }
        //Thêm lớp học
        public bool ThemLop(DTO_LopHoc lh)
        {
            return _LH.ThemLop(lh);
        }
        // Sửa lớp học
        public bool SuaLop(DTO_LopHoc lh)
        {
            return _LH.SuaLop(lh);
        }
        // Xóa lớp học
        public bool XoaLop(DTO_LopHoc lh)
        {
            return _LH.XoaLop(lh);
        }
        // Tìm kiếm lớp học
        public DataTable TimKiem(DTO_LopHoc lh)
        {
            return _LH.TimKiem(lh);
        }
        // Hiển thị khóa đào tạo
        public DataTable HienThiKDT()
        {
            return _LH.HienThiKDT();
        }
        // Tìm kiếm khóa đào tạo
        public DataTable TimKiemKDT(string mkdt)
        {
            return _LH.TimKiemKDT(mkdt);
        }
    }
}

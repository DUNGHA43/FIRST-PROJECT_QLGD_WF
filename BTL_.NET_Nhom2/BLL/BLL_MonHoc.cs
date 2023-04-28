using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_MonHoc
    {
        DAL_MonHoc _MH = new DAL_MonHoc();

        // Hiển thị danh sách môn học
        public DataTable HienthiDS()
        {
            return _MH.HienThiDS();
        }

        // Thêm môn học
        public bool ThemMH(DTO_MonHoc mh)
        {
            return _MH.ThemMH(mh);
        }

        // Sửa thông tin môn học
        public bool SuaMH(DTO_MonHoc mh)
        {
            return _MH.SuaMH(mh);
        }

        // Xóa môn học
        public bool XoaMH(DTO_MonHoc mh)
        {
            return _MH.XoaMH(mh);
        }

        // Tìm kiếm Môn học
        public DataTable TimKiem(DTO_MonHoc mh)
        {
            return _MH.TimKiemMH(mh);
        }
    }
}

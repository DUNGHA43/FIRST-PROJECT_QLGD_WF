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
    public class BLL_PhongHoc
    {
        DAL_PhongHoc _PH = new DAL_PhongHoc();
        // Hiển thị danh sách phòng học
        public DataTable HienThiDSPhongHoc()
        {
            return _PH.HienThiDSPhong();
        }
        // Thêm phòng học
        public bool ThemPhongHoc(DTO_PhongHoc ph)
        {
            return _PH.ThemPhongHoc(ph);
        }
        // Sửa thông tin phòng học
        public bool SuaPhongHoc(DTO_PhongHoc ph)
        {
            return _PH.SuaPhongHoc(ph);
        }
        // Xóa phòng học
        public bool XoaPhongHoc(DTO_PhongHoc ph)
        {
            return _PH.XoaPhongHoc(ph);
        }
        // Tìm kiếm phòng học
        public DataTable TimKiemPhongHoc(DTO_PhongHoc ph)
        {
            return _PH.TimKiemPhongHoc(ph);
        }
    }
}

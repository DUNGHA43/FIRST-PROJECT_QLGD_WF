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
    public class BLL_GiangVien
    {
        DAL_GiangVien _GV = new DAL_GiangVien();

        // Hiển thị danh sách giảng viên
        public DataTable HienThiDS()
        {
            return _GV.HienThiDSGV();
        }

        // Thêm giảng viên
        public bool ThemGV(DTO_GiangVien gv)
        {
            return _GV.ThemGV(gv);
        }

        // Sửa thông tin giảng viên
        public bool SuaGV(DTO_GiangVien gv)
        {
            return _GV.SuaGV(gv);
        }

        // Xóa giảng viên
        public bool XoaGV(DTO_GiangVien gv)
        {
            return _GV.XoaGV(gv);
        }

        // Tìm kiếm giảng viên
        public DataTable TimKiem(DTO_GiangVien gv)
        {
            return _GV.TimKiemGV(gv);
        }

        // Hiển thị mã khoa vào Combobox
        public DataTable LaodMaKhoa()
        {
            return _GV.loadMaKhoa();
        }
        // Trả về tên khoa khi chọn khoa trong Combobox
        public string loadTenk(string mk)
        {
            return _GV.loadtenKhoa(mk);
        }
    }
}

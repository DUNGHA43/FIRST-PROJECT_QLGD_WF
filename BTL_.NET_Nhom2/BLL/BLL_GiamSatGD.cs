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
    public class BLL_GiamSatGD
    {
        DAL_GiamSatGiangDay _GS = new DAL_GiamSatGiangDay();
        // Hiển thị danh sách giám sát giảng dạy
        public DataTable HienThiDSGianSatGD()
        {
            return _GS.HienThiDSGianSatGD();
        }
        // Thêm Giám sát giảng dạy
        public bool ThemGSGD(DTO_GiamSatGiangDay gs)
        {
            return _GS.ThemGSGD(gs);
        }
        // Cập nhật giám sát giảng dạy
        public bool CapNhatGSGD(DTO_GiamSatGiangDay gs)
        {
            return _GS.CapNhatGSGD(gs);
        }
        // Xóa giám sát giảng dạy
        public bool XoaGSGD(DTO_GiamSatGiangDay gs)
        {
            return _GS.XoaGSGD(gs);
        }
        // Tìm kiếm theo mã phân công giảng dạy
        public DataTable TimKiemTheoMaPCGD(DTO_GiamSatGiangDay gs)
        {
            return _GS.TimKiemTheoMaPCGD(gs);
        }
        // Tìm kiếm theo mã giảng viên
        public DataTable TimKiemTheoMaGV(DTO_GiamSatGiangDay gs)
        {
            return _GS.TimKiemTheoMaGV(gs);
        }
        // Cập nhật cột Trạng thái
        public bool XacNhanHoanThanh(DTO_GiamSatGiangDay gs)
        {
            return _GS.XacNhanHoanThanh(gs);
        }
        // Cập nhật cột trạng thái
        public bool XacNhanChuaHoanThanh(DTO_GiamSatGiangDay gs)
        {
            return _GS.XacNhanChuaHoanThanh(gs);
        }
        // Hiển thị mã phân công giảng dạy vào ComboBox
        public DataTable loadMaPCGD()
        {
            return _GS.loadMaPCGD();
        }
        // Trả về mã giảng viên tương ứng khi chọn mã phân công giảng dạy trong ComboBox
        public string loadGV(string mgv)
        {
            return _GS.loadGV(mgv);
        }
    }
}

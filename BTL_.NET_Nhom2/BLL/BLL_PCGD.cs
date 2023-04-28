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
    public class BLL_PCGD
    {
        DAL_PCGD _PC = new DAL_PCGD();

        // Hiển thị danh sách phân công giảng dạy
        public DataTable HienThiDSPC()
        {
            return _PC.HienThiDanhSachPCGD();
        }

        // Thêm phân công giảng dạy
        public bool ThemPCGD(DTO_PCGD pc)
        {
            return _PC.ThemPDGD(pc);
        }

        // Sửa thông tin phân công giảng dạy của giảng viên
        public bool SuaPCGD(DTO_PCGD pc)
        {
            return _PC.SuaPDGD(pc);
        }
        // Tìm kiếm danh sách phân công giảng dạy
        public DataTable TimkiemDSPC(DTO_PCGD pc)
        {
            return _PC.TimKiemPCGD(pc);
        }
        // Hiển thi danh sách tên giảng viên vào ComboBox
        public DataTable loadGV()
        {
            return _PC.loadGV();
        }
        // Trả về mã của giảng viên tương ứng khi chọn giảng viên trong ComboBox
        public string loadMaGV(string maGV)
        {
            return _PC.loadMaGV(maGV);
        }
        // Hiển thi danh sách mã học phần vào ComboBox
        public DataTable loadMaHocPhan()
        {
            return _PC.loadMaHocPhan();
        }
        // Hiển thi danh sách phòng học vào ComboBox
        public DataTable loadMaPhongHoc()
        {
            return _PC.loadMaPhongHoc();
        }
        // Hiển thi danh sách lớp học vào ComboBox
        public DataTable loadMaLopHoc()
        {
            return _PC.loadMaLopHoc();
        }
    }
}

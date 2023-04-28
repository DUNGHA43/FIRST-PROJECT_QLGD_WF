using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_BAOCAO_KLGD
    {
        DAL_THONGKE_KLGD _TK = new DAL_THONGKE_KLGD();
        // Hiển thị danh sách phân công giảng dạy
        public DataTable HienTHiDS()
        {
            return _TK.HienThiDS();
        }
        // Báo cáo khối lượng giảng dạy của các giảng viên
        public DataTable BaoCao_DS_ALL_PCGD()
        {
            return _TK.BaoCao_DS_ALL_PCGD();
        }
        // Báo cáo khối lượng giảng dạy của giảng viên được chọn
        public DataTable BaoCao_DS_ALL_PCGD_GV(string mgv)
        {
            return _TK.BaoCao_DS_ALL_PCGD_GV(mgv);
        }
        // Hiển thị tên giảng viên vào ComboBox
        public DataTable loadTenGV()
        {
            return _TK.loadTenGV();
        }
        // Trả về mã giảng viên tương ứng khi chọn giảng viên trong ComboBox
        public string loadMaGV(string gv)
        {
            return _TK.loadMaGV(gv);
        }
        // Tìm kiếm phân công giảng dạy
        public DataTable BaoCao_DS_TIMKIEM_PCGD_GV(string mgv)
        {
            return _TK.BaoCao_DS_TIMKIEM_PCGD_GV(mgv);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_BAOCAO_CLGD
    {
        DAL_THONGKE_CLGD _BC = new DAL_THONGKE_CLGD();
        // Hiển thị danh sách giám sát giảng dạy
        public DataTable Hienth_DS()
        {
            return _BC.Hienth_DS();
        }
        // Hiển thị danh sách tên giảng viên vào ComboBox
        public DataTable loadTenGV()
        {
            return _BC.loadTenGV();
        }
        // Trả về mã giảng viên tương ứng khi chọn giảng viên trong ComboBox
        public string loadMaGV(string gv)
        {
            return _BC.loadMaGV(gv);
        }
        // Tạo báo cáo chất lượng giảng dạy của giảng viên được chọn
        public DataTable TaoBaoCao_CLGD(string mgv)
        {
            return _BC.TaoBaoCao_CLGD(mgv);
        }
        // Tìm kiếm danh sách giám sát giảng dạy
        public DataTable TimKiem_CLGD_GV(string mgv)
        {
            return _BC.TimKiem_CLGD_GV(mgv);
        }
    }
}

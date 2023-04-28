using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_PCGD
    {
        DataTable HienThiDanhSachPCGD();
        bool ThemPDGD(DTO_PCGD pc);
        bool SuaPDGD(DTO_PCGD pc);
        DataTable TimKiemPCGD(DTO_PCGD pc);
        DataTable loadGV();
        string loadMaGV(string maGV);
        DataTable loadMaHocPhan();
        DataTable loadMaPhongHoc();
        DataTable loadMaLopHoc();
    }
}

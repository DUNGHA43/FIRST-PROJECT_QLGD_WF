using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Interface_THONGKE_KLGD
    {
        DataTable HienThiDS();
        DataTable loadTenGV();
        string loadMaGV(string gv);
        DataTable BaoCao_DS_ALL_PCGD();
        DataTable BaoCao_DS_ALL_PCGD_GV(string mgv);
        DataTable BaoCao_DS_TIMKIEM_PCGD_GV(string mgv);
    }
}

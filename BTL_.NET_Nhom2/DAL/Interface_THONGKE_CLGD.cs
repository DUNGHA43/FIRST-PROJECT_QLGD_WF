using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_THONGKE_CLGD
    {
        DataTable Hienth_DS();
        DataTable loadTenGV();
        string loadMaGV(string gv);
        DataTable TaoBaoCao_CLGD(string mgv);
        DataTable TimKiem_CLGD_GV(string mgv);
    }
}

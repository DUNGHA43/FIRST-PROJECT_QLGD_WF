using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_LopHoc
    {
        DataTable HienthiDS();
        bool ThemLop(DTO_LopHoc lh);
        bool SuaLop(DTO_LopHoc lh);
        bool XoaLop(DTO_LopHoc lh);
        DataTable TimKiem(DTO_LopHoc lh);
        DataTable HienThiKDT();
        DataTable TimKiemKDT(string mkdt);
    }
}

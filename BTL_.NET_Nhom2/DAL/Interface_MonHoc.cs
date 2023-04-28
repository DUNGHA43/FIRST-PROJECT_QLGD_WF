using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_MonHoc
    {
        DataTable HienThiDS();
        bool ThemMH(DTO_MonHoc mh);
        bool SuaMH(DTO_MonHoc mh);
        bool XoaMH(DTO_MonHoc mh);
        DataTable TimKiemMH(DTO_MonHoc mh);
    }
}

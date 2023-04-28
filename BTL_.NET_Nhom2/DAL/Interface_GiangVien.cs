using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Interface_GiangVien
    {
        DataTable HienThiDSGV();
        bool ThemGV(DTO_GiangVien gv);
        bool SuaGV(DTO_GiangVien gv);
        bool XoaGV(DTO_GiangVien gv);
        DataTable TimKiemGV(DTO_GiangVien gv);
        DataTable loadMaKhoa();
        string loadtenKhoa(string mk);
    }
}

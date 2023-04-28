using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_PhongHoc
    {
        DataTable HienThiDSPhong();
        bool ThemPhongHoc(DTO_PhongHoc ph);
        bool SuaPhongHoc(DTO_PhongHoc ph);
        bool XoaPhongHoc(DTO_PhongHoc ph);
        DataTable TimKiemPhongHoc(DTO_PhongHoc ph);
    }
}

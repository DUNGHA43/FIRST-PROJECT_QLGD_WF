using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    interface Interface_GiamSatGiangDay
    {
        DataTable HienThiDSGianSatGD();
        bool ThemGSGD(DTO_GiamSatGiangDay gs);
        bool CapNhatGSGD(DTO_GiamSatGiangDay gs);
        bool XoaGSGD(DTO_GiamSatGiangDay gs);
        DataTable TimKiemTheoMaPCGD(DTO_GiamSatGiangDay gs);
        DataTable TimKiemTheoMaGV(DTO_GiamSatGiangDay gs);
        bool XacNhanHoanThanh(DTO_GiamSatGiangDay gs);
        bool XacNhanChuaHoanThanh(DTO_GiamSatGiangDay gs);
        DataTable loadMaPCGD();
        string loadGV(string mgv);
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Interface_TaiKhoan
    {
        string DangNhap(DTO_DangNhap dn);
        bool DoiMatKhau(DTO_DangNhap dn);
    }
}

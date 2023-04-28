using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_TaiKhoan : Connect_Close_DB, Interface_TaiKhoan
    {
        SqlCommand cmd;
        public string DangNhap(DTO_DangNhap dn)
        {
            connect_DB();
            string mk = null;
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT Password FROM TblTaiKhoan AS tk WHERE Username = '{dn.tk}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                mk = rd.GetString(0);
            }
            rd.Close();
            return mk;
        }
        public bool DoiMatKhau(DTO_DangNhap dn)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblTaiKhoan SET Password = '{dn.mk}' WHERE Username = '{dn.tk}'";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                return true;
            }
            return false;
        }
    }
}

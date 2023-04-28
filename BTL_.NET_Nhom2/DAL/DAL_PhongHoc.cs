using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_PhongHoc : Connect_Close_DB, Interface_PhongHoc
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable HienThiDSPhong()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSPhongHoc";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            return dt;
        }
        public bool ThemPhongHoc(DTO_PhongHoc ph)
        {
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO TblPhongHoc VALUES('{ph.MaPhongHoc}', N'{ph.TenPhongHoc}', N'{ph.DiaDiem}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaPhongHoc(DTO_PhongHoc ph)
        {
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblPhongHoc SET TenPhongHoc = N'{ph.TenPhongHoc}', DiaDiem = N'{ph.DiaDiem}' WHERE MaPhongHoc = '{ph.MaPhongHoc}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaPhongHoc(DTO_PhongHoc ph)
        {
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"DELETE TblPhongHoc WHERE MaPhongHoc = '{ph.MaPhongHoc}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiemPhongHoc(DTO_PhongHoc ph)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SElECT * FROM TblPhongHoc WHERE MaPhongHoc LIKE '%{ph.MaPhongHoc}%'";
            adt.SelectCommand = cmd;
            var timkiem = new DataTable();
            timkiem.Clear();
            adt.Fill(timkiem);
            return timkiem;
        }
    }
}

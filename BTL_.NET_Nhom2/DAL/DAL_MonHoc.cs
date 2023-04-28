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
    public class DAL_MonHoc : Connect_Close_DB, Interface_MonHoc
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable HienThiDS()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSMonHoc";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            return dt;
        }
        public bool ThemMH(DTO_MonHoc mh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO TblMon VALUES ('{mh.MaMon}', N'{mh.TenMon}')";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaMH(DTO_MonHoc mh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblMon SET TenMon = N'{mh.TenMon} WHERE MaMon = '{mh.MaMon}''";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaMH(DTO_MonHoc mh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"DELETE TblMon WHERE MaMon = '{mh.MaMon}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiemMH(DTO_MonHoc mh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT * FROM TblMon WHERE MaMon LIKE '%{mh.MaMon}%'";
            adt.SelectCommand = cmd;
            var timkiem = new DataTable();
            dt.Clear();
            adt.Fill(timkiem);
            return timkiem;
        }
    }
}

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
    public class DAL_LopHoc : Connect_Close_DB, Interface_LopHoc
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable HienthiDS()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSLop";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            return dt;
        }
        public bool ThemLop(DTO_LopHoc lh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO TblLop VALUES ('{lh.MaLop}', N'{lh.TenLop}', '{lh.MaKhoaDT}', {lh.SoSV})";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaLop(DTO_LopHoc lh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblLop SET TenLop = N'{lh.TenLop}', MaKhoaDT = '{lh.MaKhoaDT}', SoSV = {lh.SoSV} WHERE MaLop = '{lh.MaLop}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaLop(DTO_LopHoc lh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"DELETE TblLop WHERE MaLop = '{lh.MaLop}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiem(DTO_LopHoc lh)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT * FROM TblLop WHERE MaLop LIKE '%{lh.MaLop}%'";
            adt.SelectCommand = cmd;
            var timkiem = new DataTable();
            dt.Clear();
            adt.Fill(timkiem);
            return timkiem;
        }

        public DataTable HienThiKDT()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSKDT";
            adt.SelectCommand = cmd;
            var kdt = new DataTable();
            kdt.Clear();
            adt.Fill(kdt);
            return kdt;
        }
        public DataTable TimKiemKDT(string mkdt)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT * FROM TblKhoaDT WHERE MaKhoaDT LIKE '%{mkdt}%'";
            adt.SelectCommand = cmd;
            var timkiem = new DataTable();
            dt.Clear();
            adt.Fill(timkiem);
            return timkiem;
        }
    }
}

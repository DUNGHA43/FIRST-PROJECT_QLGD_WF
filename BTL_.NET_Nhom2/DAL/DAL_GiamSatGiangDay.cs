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
    public class DAL_GiamSatGiangDay : Connect_Close_DB, Interface_GiamSatGiangDay
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable HienThiDSGianSatGD() 
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"HienThiDSGSGD";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            return dt;
        }
        public bool ThemGSGD(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO GiamSatGD VALUES ('{gs.MaGS}', '{gs.MaPCGD}', '{gs.MaGV}', {gs.SoTietNghi}, N'{gs.NgayNghi}', {gs.SoTietBu}, N'{gs.NgayBu}', N'Chờ xác nhận', N'{gs.GhiChu}')";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool CapNhatGSGD(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE GiamSatGD SET SoTietNghi = {gs.SoTietNghi}, NgayNghi = N'{gs.NgayNghi}', SoTietBu = {gs.SoTietBu}, NgayBu = N'{gs.NgayBu}', GhiChu = N'{gs.GhiChu}' WHERE MaGS = '{gs.MaGS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaGSGD(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"DELETE GiamSatGD WHERE MaGS = '{gs.MaGS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiemTheoMaPCGD(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            var pc = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT gs.MaGS AS Mã_Giám_Sát,  gs.MaPCGD AS Mã_PCGD,gs.MaGV AS Mã_Giảng_Viên, gv.HoTenGV AS Giảng_Viên, SoTietNghi AS Số_Tiết_Nghỉ, NgayNghi AS Ngày_Nghỉ, SoTietBu AS Số_Tiết_Bù, NgayBu AS Ngày_Bù, KetQua AS Trạng_Thái, GhiChu AS Ghi_Chú FROM GiamSatGD gs
INNER JOIN PhanCongGD pc
ON gs.MaPCGD = pc.MaPCDG
INNER JOIN TblGiangVien gv
ON  gs.MaGV = gv.MaGV AND gv.MaGV = pc.MaGV WHERE gs.MaPCGD LIKE '%{gs.MaPCGD}%'";
            adt.SelectCommand = cmd;
            pc.Clear();
            adt.Fill(pc);
            return pc;
        }
        public DataTable TimKiemTheoMaGV(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            var gv = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT gs.MaGS AS Mã_Giám_Sát,  gs.MaPCGD AS Mã_PCGD,gs.MaGV AS Mã_Giảng_Viên, gv.HoTenGV AS Giảng_Viên, SoTietNghi AS Số_Tiết_Nghỉ, NgayNghi AS Ngày_Nghỉ, SoTietBu AS Số_Tiết_Bù, NgayBu AS Ngày_Bù, KetQua AS Trạng_Thái, GhiChu AS Ghi_Chú FROM GiamSatGD gs
INNER JOIN PhanCongGD pc
ON gs.MaPCGD = pc.MaPCDG
INNER JOIN TblGiangVien gv
ON  gs.MaGV = gv.MaGV AND gv.MaGV = pc.MaGV WHERE gs.MaGV LIKE '%{gs.MaGV}%'";
            adt.SelectCommand = cmd;
            gv.Clear();
            adt.Fill(gv);
            return gv;
        }
        public bool XacNhanHoanThanh(DTO_GiamSatGiangDay gs) 
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE GiamSatGD SET KetQua = N'Hoàn thành' WHERE MaGS = '{gs.MaGS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool XacNhanChuaHoanThanh(DTO_GiamSatGiangDay gs)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE GiamSatGD SET KetQua = N'Chưa hoàn thành' WHERE MaGS = '{gs.MaGS}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable loadMaPCGD()
        {
            connect_DB();
            var pc = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "SELECT MaPCDG FROM PhanCongGD";
            adt.SelectCommand = cmd;
            pc.Clear();
            adt.Fill(pc);
            return pc;
        }
        public string loadGV(string mgv)
        {
            connect_DB();
            string tmp = "";
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT MaGV FROM PhanCongGD WHERE MaPCDG = '{mgv}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            return tmp;
        }
    }
}

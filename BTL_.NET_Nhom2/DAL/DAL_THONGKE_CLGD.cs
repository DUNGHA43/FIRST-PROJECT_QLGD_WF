using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_THONGKE_CLGD : Connect_Close_DB, Interface_THONGKE_CLGD
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable Hienth_DS()
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
        public DataTable loadTenGV()
        {
            connect_DB();
            var gv = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "SELECT HoTenGV FROM TblGiangVien";
            adt.SelectCommand = cmd;
            gv.Clear();
            adt.Fill(gv);
            return gv;
        }
        public string loadMaGV(string gv)
        {
            connect_DB();
            string tmp = "";
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT MaGV FROM TblGiangVien WHERE HoTenGV = N'{gv}'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            return tmp;
        }

        public DataTable TaoBaoCao_CLGD(string mgv)
        {
            connect_DB();
            var bc = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT        GiamSatGD.MaGS, GiamSatGD.MaPCGD, TblGiangVien.HoTenGV, GiamSatGD.SoTietNghi, GiamSatGD.NgayNghi, GiamSatGD.SoTietBu, GiamSatGD.NgayBu, GiamSatGD.KetQua, GiamSatGD.GhiChu
FROM            GiamSatGD INNER JOIN
                         TblGiangVien ON GiamSatGD.MaGV = TblGiangVien.MaGV
WHERE GiamSatGD.MaGV = '{mgv}'";
            adt.SelectCommand = cmd;
            bc.Clear();
            adt.Fill(bc);
            return bc;
        }

        public DataTable TimKiem_CLGD_GV(string mgv)
        {
            connect_DB();
            var tk = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT gs.MaGS AS Mã_Giám_Sát,  gs.MaPCGD AS Mã_PCGD,gs.MaGV AS Mã_Giảng_Viên, gv.HoTenGV AS Giảng_Viên, SoTietNghi AS Số_Tiết_Nghỉ, NgayNghi AS Ngày_Nghỉ, SoTietBu AS Số_Tiết_Bù, NgayBu AS Ngày_Bù, KetQua AS Trạng_Thái, GhiChu AS Ghi_Chú FROM GiamSatGD gs
INNER JOIN PhanCongGD pc
ON gs.MaPCGD = pc.MaPCDG
INNER JOIN TblGiangVien gv
ON gs.MaGV = gv.MaGV AND gv.MaGV = pc.MaGV
WHERE gs.MaGV = '{mgv}'";
            adt.SelectCommand = cmd;
            tk.Clear();
            adt.Fill(tk);
            return tk;
        }
    }
}

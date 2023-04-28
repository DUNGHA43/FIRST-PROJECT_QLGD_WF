using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_THONGKE_KLGD : Connect_Close_DB, Interface_THONGKE_KLGD
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable HienThiDS()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"HienThiDSPCGD";
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
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            return tmp;
        }
        public DataTable BaoCao_DS_ALL_PCGD()
        {
            connect_DB();
            var rp = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = @"SELECT        PhanCongGD.MaPCDG, TblGiangVien.HoTenGV, PhanCongGD.MaHocPhan, PhanCongGD.MaPhongHoc, PhanCongGD.MaLop, TblKhoaDT.MaKhoaDT, PhanCongGD.NgayBatDau, PhanCongGD.NgayKetThuc, 
                         PhanCongGD.ThuHoc, PhanCongGD.CaHoc
FROM            PhanCongGD INNER JOIN
                         TblGiangVien ON PhanCongGD.MaGV = TblGiangVien.MaGV INNER JOIN
                         TblLop ON PhanCongGD.MaLop = TblLop.MaLop INNER JOIN
                         TblKhoaDT ON TblLop.MaKhoaDT = TblKhoaDT.MaKhoaDT";
            adt.SelectCommand = cmd;
            rp.Clear();
            adt.Fill(rp);
            return rp;
        }

        public DataTable BaoCao_DS_ALL_PCGD_GV(string mgv)
        {
            connect_DB();
            var rp = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT        PhanCongGD.MaPCDG, TblGiangVien.HoTenGV, PhanCongGD.MaHocPhan, PhanCongGD.MaPhongHoc, PhanCongGD.MaLop, TblKhoaDT.MaKhoaDT, PhanCongGD.NgayBatDau, PhanCongGD.NgayKetThuc, 
                         PhanCongGD.ThuHoc, PhanCongGD.CaHoc
FROM            PhanCongGD INNER JOIN
                         TblGiangVien ON PhanCongGD.MaGV = TblGiangVien.MaGV INNER JOIN
                         TblLop ON PhanCongGD.MaLop = TblLop.MaLop INNER JOIN
                         TblKhoaDT ON TblLop.MaKhoaDT = TblKhoaDT.MaKhoaDT
WHERE			PhanCongGD.MaGV = '{mgv}'";
            adt.SelectCommand = cmd;
            rp.Clear();
            adt.Fill(rp);
            return rp;
        }
        public DataTable BaoCao_DS_TIMKIEM_PCGD_GV(string mgv)
        {
            connect_DB();
            var rp = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $@"SELECT MaPCDG AS Mã_PCGD, HoTenGV AS Giảng_Viên, pcgd.MaHocPhan AS Mã_Học_Phần, pcgd.MaPhongHoc AS Phòng_Học, pcgd.MaLop AS Lớp, l.MaKhoaDT AS Khóa_Đào_Tạo , NgayBatDau AS Ngày_Bắt_Đầu, NgayKetThuc AS Ngày_Kết_Thúc, ThuHoc AS Thứ_Học, CaHoc AS Ca_Học  FROM PhanCongGD pcgd
INNER JOIN TblGiangVien gv
ON pcgd.MaGV = gv.MaGV
INNER JOIN TblCTDT ctdt
ON pcgd.MaHocPhan = ctdt.MaHocPhan
INNER JOIN TblLop l 
ON pcgd.MaLop = l.MaLop 
INNER JOIN TblKhoaDT kdt 
ON l.MaKhoaDT = kdt.MaKhoaDT
WHERE pcgd.MaGV = '{mgv}'";
            adt.SelectCommand = cmd;
            rp.Clear();
            adt.Fill(rp);
            return rp;
        }
    }
}

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
    public class DAL_PCGD : Connect_Close_DB, Interface_PCGD
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable HienThiDanhSachPCGD()
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
        public bool ThemPDGD(DTO_PCGD pc)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO PhanCongGD VALUES('{pc.MaPCGD}', '{pc.MaGV}', '{pc.MaHocPhan}', '{pc.MaPhongHoc}', '{pc.MaLop}', '{pc.NgayBatDau}', '{pc.NgayKetThuc}', N'{pc.ThuHoc}', {pc.CaHoc})";
            int kt = cmd.ExecuteNonQuery();
            if(kt > 0)
            {
                return true;
            }
            return false;
        }
        public bool SuaPDGD(DTO_PCGD pc)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE PhanCongGD SET MaGV = '{pc.MaGV}', MaHocPhan = '{pc.MaHocPhan}', MaPhongHoc = '{pc.MaPhongHoc}', MaLop = '{pc.MaLop}', NgayBatDau = '{pc.NgayBatDau}', NgayKetThuc = '{pc.NgayKetThuc}', ThuHoc = N'{pc.ThuHoc}', CaHoc = {pc.CaHoc} WHERE MaPCDG = '{pc.MaPCGD}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiemPCGD(DTO_PCGD pc)
        {
            connect_DB();
            var TimKiem = new DataTable();
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
WHERE pcgd.MaPCDG LIKE '%{pc.MaPCGD}%'";
            adt.SelectCommand = cmd;
            TimKiem.Clear();
            adt.Fill(TimKiem);
            return TimKiem;
        }
        public DataTable loadGV()
        {
            connect_DB();
            var gv = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSGV";
            adt.SelectCommand = cmd;
            gv.Clear();
            adt.Fill(gv);
            return gv;
        }
        public string loadMaGV(string maGV)
        {
            connect_DB();
            string tmp = "";
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT MaGV FROM TblGiangVien WHERE HoTenGV = N'{maGV}'";
            var rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            return tmp;
        }
        public DataTable loadMaHocPhan()
        {
            connect_DB();
            var mahp = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSCTDT";
            adt.SelectCommand = cmd;
            mahp.Clear();
            adt.Fill(mahp);
            return mahp;
        }
        public DataTable loadMaPhongHoc()
        {
            connect_DB();
            var maph = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSPhongHoc";
            adt.SelectCommand = cmd;
            maph.Clear();
            adt.Fill(maph);
            return maph;
        }
        public DataTable loadMaLopHoc()
        {
            connect_DB();
            var mal = new DataTable();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSLop";
            adt.SelectCommand = cmd;
            mal.Clear();
            adt.Fill(mal);
            return mal;
        }
    }
}

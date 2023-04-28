using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_GiangVien : Connect_Close_DB, Interface_GiangVien
    {
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();

        // Hien thi danh sach giang vien
        public DataTable HienThiDSGV()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiDSGV";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            return dt;
        }
        // Ham convert duong dan anh thanh chuoi nhi phan
        private Byte[] convertImageToBytes(DTO_GiangVien gv)
        {
            FileStream fs;
            fs = new FileStream(gv.AnhGV, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        // Them Giang Vien
        public bool ThemGV(DTO_GiangVien gv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"INSERT INTO TblGiangVien VALUES ('{gv.MaGV}', N'{gv.HoTenGV}', @AnhGV, '{gv.MaKhoa}', N'{gv.ChuyenMon}', N'{gv.ChucVu}', '{gv.NgaySinh}', N'{gv.GioiTinh}', '{gv.SDT}', N'{gv.DiaChi}')";
            cmd.Parameters.AddWithValue("@AnhGV", convertImageToBytes(gv));
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        // Sua thong tin giang vien
        public bool SuaGV(DTO_GiangVien gv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"UPDATE TblGiangvien SET HoTenGV = N'{gv.HoTenGV}', AnhGV = @AnhGV, MaKhoa = '{gv.MaKhoa}', ChuyenMon = N'{gv.ChuyenMon}', ChucVu = N'{gv.ChucVu}', NgaySinh = '{gv.NgaySinh}', GioiTinh = N'{gv.GioiTinh}', SDT = '{gv.SDT}', DiaChi = N'{gv.DiaChi}' WHERE MaGV = '{gv.MaGV}'";
            cmd.Parameters.AddWithValue("@AnhGV", convertImageToBytes(gv));
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        // Xoa Giang Vien
        public bool XoaGV(DTO_GiangVien gv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"DELETE TblGiangVien WHERE MaGV = '{gv.MaGV}'";
            int kt = cmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            return false;
        }
        // Tim kiem Giang Vien
        public DataTable TimKiemGV(DTO_GiangVien gv)
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT * FROM TblGiangVien WHERE MaGV LIKE '%{gv.MaGV}%'";
            adt.SelectCommand = cmd;
            var timkiem = new DataTable();
            dt.Clear();
            adt.Fill(timkiem);
            return timkiem;
        }

        // LoadMaKhoa
        public DataTable loadMaKhoa()
        {
            connect_DB();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "SELECT TenKhoa FROM TblKhoa";
            adt.SelectCommand = cmd;
            var loadMK = new DataTable();
            loadMK.Clear();
            adt.Fill(loadMK);
            return loadMK;
        }

        public string loadtenKhoa(string mk)
        {
            connect_DB();
            string tmp = "";
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "SELECT MaKhoa FROM TblKhoa WHERE TenKhoa = N'"+mk+"'";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tmp = rd.GetString(0);
            }
            rd.Close();
            return tmp;
        }
    }
}

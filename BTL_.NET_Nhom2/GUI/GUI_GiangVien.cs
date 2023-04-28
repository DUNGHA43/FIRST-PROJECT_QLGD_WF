using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class GUI_GiangVien : DevExpress.XtraEditors.XtraForm
    {
        BLL_GiangVien bllgv = new BLL_GiangVien();
        DTO_GiangVien gv = new DTO_GiangVien();
        string tmp;
        public GUI_GiangVien()
        {
            InitializeComponent();
        }

        private void HienthiDSGV()
        {
            dgvDSGV.DataSource = bllgv.HienThiDS();
        }

        private void HienthiTenKhoa()
        {
            txtTenKhoa.DisplayMember = "TenKhoa";
            txtTenKhoa.DataSource = bllgv.LaodMaKhoa();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                opdAnhGV.ShowDialog();
                string file = opdAnhGV.FileName;
                if (string.IsNullOrEmpty(file))
                {
                    return;
                }
                Image img = Image.FromFile(file);
                ptbAnhGV.Image = img;
                tmp = opdAnhGV.FileName;
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn ảnh");
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gv.MaGV = txtMaGV.Text.Trim();
                gv.HoTenGV = txtHoTen.Text.Trim();
                gv.AnhGV = tmp;
                gv.MaKhoa = txtMaKhoa.Text.Trim();
                gv.ChuyenMon = txtChuyenMon.Text.Trim();
                gv.ChucVu = txtChucVu.Text.Trim();
                gv.NgaySinh = txtNgaySinh.Text.Trim();
                gv.GioiTinh = txtGioiTinh.Text.Trim();
                gv.SDT = txtSDT.Text.Trim();
                gv.DiaChi = txtDiaChi.Text.Trim();
                bllgv.ThemGV(gv);
                HienthiDSGV();
                MessageBox.Show("Thêm thành công!");
                txtMaGV.Clear();
                txtHoTen.Clear();
                tmp = "";
                txtTenKhoa.Text = null;
                txtMaKhoa.Text = null;
                txtChuyenMon.Text = null;
                txtChucVu.Text = null;
                ptbAnhGV.Image = null;
                txtNgaySinh.Refresh();
                txtGioiTinh.Text = null;
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gv.MaGV = txtMaGV.Text.Trim();
                gv.HoTenGV = txtHoTen.Text.Trim();
                gv.AnhGV = tmp;
                gv.MaKhoa = txtMaKhoa.Text.Trim();
                gv.ChuyenMon = txtChuyenMon.Text.Trim();
                gv.ChucVu = txtChucVu.Text.Trim();
                gv.NgaySinh = txtNgaySinh.Text.Trim();
                gv.GioiTinh = txtGioiTinh.Text.Trim();
                gv.SDT = txtSDT.Text.Trim();
                gv.DiaChi = txtDiaChi.Text.Trim();
                bllgv.SuaGV(gv);
                HienthiDSGV();
                MessageBox.Show("Sủa thông tin thành công!");
                txtMaGV.Clear();
                txtHoTen.Clear();
                tmp = "";
                txtTenKhoa.Text = null;
                txtMaKhoa.Text = null;
                txtChuyenMon.Text = null;
                txtChucVu.Text = null;
                ptbAnhGV.Image = null;
                txtNgaySinh.Refresh();
                txtGioiTinh.Text = null;
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show(" Sửa không thành công! \n Bạn nên chọn lại ảnh! ");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gv.MaGV = txtMaGV.Text.Trim();
                bllgv.XoaGV(gv);
                HienthiDSGV();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void txtTimKimMaGV_EditValueChanged(object sender, EventArgs e)
        {
            gv.MaGV = txtTimKimMaGV.EditValue.ToString();
            dgvDSGV.DataSource = bllgv.TimKiem(gv);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSGV.CurrentRow.Index;
            byte[] x;
            txtMaGV.Text = dgvDSGV.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSGV.Rows[i].Cells[1].Value.ToString();
            x = (byte[])dgvDSGV.Rows[i].Cells[2].Value;
            MemoryStream stream = new MemoryStream(x);
            Image img = Image.FromStream(stream);
            if (img == null)
            {
                return;
            }
            ptbAnhGV.Image = img;
            txtTenKhoa.Text = dgvDSGV.Rows[i].Cells[3].Value.ToString();
            txtChuyenMon.Text = dgvDSGV.Rows[i].Cells[4].Value.ToString();
            txtChucVu.Text = dgvDSGV.Rows[i].Cells[5].Value.ToString();
            txtNgaySinh.Text = dgvDSGV.Rows[i].Cells[6].Value.ToString();
            txtGioiTinh.Text = dgvDSGV.Rows[i].Cells[7].Value.ToString();
            txtSDT.Text = dgvDSGV.Rows[i].Cells[8].Value.ToString();
            txtDiaChi.Text = dgvDSGV.Rows[i].Cells[9].Value.ToString();
        }

        private void GUI_GiangVien_Load(object sender, EventArgs e)
        {
            HienthiDSGV();
            HienthiTenKhoa();
        }

        private void txtTimKiemMaGV_TextChanged(object sender, EventArgs e)
        {
            gv.MaGV = txtTimKiemMaGV.Text;
            dgvDSGV.DataSource = bllgv.TimKiem(gv);
        }

        private void txtTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKhoa.Text = bllgv.loadTenk(txtTenKhoa.Text.Trim());
        }
    }
}
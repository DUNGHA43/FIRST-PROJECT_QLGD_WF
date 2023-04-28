using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class GUI_QuanLyTietDay : DevExpress.XtraEditors.XtraForm
    {
        DTO_GiamSatGiangDay gs = new DTO_GiamSatGiangDay();
        BLL_GiamSatGD _GS = new BLL_GiamSatGD();
        public GUI_QuanLyTietDay()
        {
            InitializeComponent();
        }
        private void HienThiDS()
        {
            dgvDSGiamSat.DataSource = _GS.HienThiDSGianSatGD();
        }
        private void LoadMaPCGD()
        {
            txtMaPCGD.DisplayMember = "MaPCDG";
            txtMaPCGD.DataSource = _GS.loadMaPCGD();
        }
        private void GUI_QuanLyTietDay_Load(object sender, EventArgs e)
        {
            HienThiDS();
            LoadMaPCGD();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gs.MaGS = txtMaGS.Text;
                gs.MaPCGD = txtMaPCGD.Text;
                gs.MaGV = txtMaGV.Text;
                gs.SoTietNghi = Convert.ToInt32(txtSoTietNghi.Text);
                gs.NgayNghi = txtNgayNghi.Text;
                gs.SoTietBu = Convert.ToInt32(txtSoTietBu.Text);
                gs.NgayBu = txtNgayBu.Text;
                gs.KetQua = "Chờ Xác nhận";
                gs.GhiChu = txtGhiChu.Text;
                _GS.ThemGSGD(gs);
                HienThiDS();
                MessageBox.Show("Thêm thành công!");
                txtMaGS.Text = null;
                txtMaPCGD.Text = null;
                txtMaGV.Text = null;
                txtSoTietBu.Text = null;
                txtSoTietNghi.Text = null;
                txtGhiChu.Text = null;
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
                gs.MaGS = txtMaGS.Text;
                gs.MaPCGD = txtMaPCGD.Text;
                gs.MaGV = txtMaGV.Text;
                gs.SoTietNghi = Convert.ToInt32(txtSoTietNghi.Text);
                gs.NgayNghi = txtNgayNghi.Text;
                gs.SoTietBu = Convert.ToInt32(txtSoTietBu.Text);
                gs.NgayBu = txtNgayBu.Text;
                gs.GhiChu = txtGhiChu.Text;
                _GS.CapNhatGSGD(gs);
                HienThiDS();
                MessageBox.Show("Cập nhật thành công!");
                txtMaGS.Text = null;
                txtMaPCGD.Text = null;
                txtMaGV.Text = null;
                txtSoTietBu.Text = null;
                txtSoTietNghi.Text = null;
                txtGhiChu.Text = null;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gs.MaGS = txtMaGS.Text;
                _GS.XoaGSGD(gs);
                HienThiDS();
                MessageBox.Show("Xóa thành công!");
                txtMaGS.Text = null;
                txtMaPCGD.Text = null;
                txtMaGV.Text = null;
                txtSoTietBu.Text = null;
                txtSoTietNghi.Text = null;
                txtGhiChu.Text = null;
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnXacNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gs.MaGS = txtMaGS.Text;
                _GS.XacNhanHoanThanh(gs);
                HienThiDS();
                MessageBox.Show("Cập nhật thành công!");
                txtMaGS.Text = null;
                txtMaPCGD.Text = null;
                txtMaGV.Text = null;
                txtSoTietBu.Text = null;
                txtSoTietNghi.Text = null;
                txtGhiChu.Text = null;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void btnChuaXacNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gs.MaGS = txtMaGS.Text;
                _GS.XacNhanChuaHoanThanh(gs);
                HienThiDS();
                MessageBox.Show("Cập nhật thành công!");
                txtMaGS.Text = null;
                txtMaPCGD.Text = null;
                txtMaGV.Text = null;
                txtSoTietBu.Text = null;
                txtSoTietNghi.Text = null;
                txtGhiChu.Text = null;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dgvDSGiamSat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSGiamSat.CurrentRow.Index;
            txtMaGS.Text = dgvDSGiamSat.Rows[i].Cells[0].Value.ToString();
            txtMaPCGD.Text = dgvDSGiamSat.Rows[i].Cells[1].Value.ToString();
            txtMaGV.Text = dgvDSGiamSat.Rows[i].Cells[2].Value.ToString();
            txtSoTietNghi.Text = dgvDSGiamSat.Rows[i].Cells[4].Value.ToString();
            txtNgayNghi.Text = dgvDSGiamSat.Rows[i].Cells[5].Value.ToString();
            txtSoTietBu.Text = dgvDSGiamSat.Rows[i].Cells[6].Value.ToString();
            txtNgayBu.Text = dgvDSGiamSat.Rows[i].Cells[7].Value.ToString();
            txtGhiChu.Text = dgvDSGiamSat.Rows[i].Cells[9].Value.ToString();
        }

        private void txtTimKiemPCGD_TextChanged(object sender, EventArgs e)
        {
            gs.MaPCGD = txtTimKiemPCGD.Text.Trim();
            dgvDSGiamSat.DataSource = _GS.TimKiemTheoMaPCGD(gs);
        }

        private void txtTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            gs.MaGV = txtTimKiemGV.Text.Trim();
            dgvDSGiamSat.DataSource = _GS.TimKiemTheoMaGV(gs);
        }

        private void txtMaPCGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaGV.Text = _GS.loadGV(txtMaPCGD.Text.Trim());
        }
    }
}
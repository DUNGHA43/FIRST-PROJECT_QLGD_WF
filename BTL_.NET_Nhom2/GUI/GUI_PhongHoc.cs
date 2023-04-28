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
    public partial class GUI_PhongHoc : DevExpress.XtraEditors.XtraForm
    {
        BLL_PhongHoc bllph = new BLL_PhongHoc();
        DTO_PhongHoc ph = new DTO_PhongHoc();
        public GUI_PhongHoc()
        {
            InitializeComponent();
        }
        private void HienThiDS()
        {
            dgvDSPhong.DataSource = bllph.HienThiDSPhongHoc();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ph.MaPhongHoc = txtMaPhong.Text;
                ph.TenPhongHoc = txtTenPhong.Text;
                ph.DiaDiem = txtDiaDiem.Text;
                bllph.ThemPhongHoc(ph);
                HienThiDS();
                MessageBox.Show("Thêm phòng học thành công!");
                txtMaPhong.Text = null;
                txtTenPhong.Text = null;
                txtDiaDiem.Text = null;
            }
            catch
            {
                MessageBox.Show("Thêm phòng học không thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ph.MaPhongHoc = txtMaPhong.Text;
                ph.TenPhongHoc = txtTenPhong.Text;
                ph.DiaDiem = txtDiaDiem.Text;
                bllph.SuaPhongHoc(ph);
                HienThiDS();
                MessageBox.Show("Sửa phòng học thành công!");
                txtMaPhong.Text = null;
                txtTenPhong.Text = null;
                txtDiaDiem.Text = null;
            }
            catch
            {
                MessageBox.Show("Sửa phòng học không thành công!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ph.MaPhongHoc = txtMaPhong.Text;
                bllph.XoaPhongHoc(ph);
                HienThiDS();
                MessageBox.Show("Xóa phòng học thành công!");
                txtMaPhong.Text = null;
                txtTenPhong.Text = null;
                txtDiaDiem.Text = null;
            }
            catch
            {
                MessageBox.Show("Xóa phòng học không thành công!");
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void GUI_PhongHoc_Load(object sender, EventArgs e)
        {
            HienThiDS();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ph.MaPhongHoc = txtTimKiem.Text;
            dgvDSPhong.DataSource = bllph.TimKiemPhongHoc(ph);
        }

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSPhong.CurrentRow.Index;
            txtMaPhong.Text = dgvDSPhong.Rows[i].Cells[0].Value.ToString();
            txtTenPhong.Text = dgvDSPhong.Rows[i].Cells[1].Value.ToString();
            txtDiaDiem.Text = dgvDSPhong.Rows[i].Cells[2].Value.ToString();
        }
    }
}
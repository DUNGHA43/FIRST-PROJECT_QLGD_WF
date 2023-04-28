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
    public partial class GUI_LopHoc : DevExpress.XtraEditors.XtraForm
    {
        DTO_LopHoc lh = new DTO_LopHoc();
        BLL_LopHoc blllh = new BLL_LopHoc();
        public GUI_LopHoc()
        {
            InitializeComponent();
        }
        private void hienthiDSLop()
        {
            dgvDSLop.DataSource = blllh.HienthiDS();
        }
        private void hienthiDSKDT()
        {
            dgvDSKDT.DataSource = blllh.HienThiKDT();
        }
        private void GUI_LopHoc_Load(object sender, EventArgs e)
        {
            hienthiDSKDT();
            hienthiDSLop();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lh.MaLop = txtMaLop.Text;
                lh.TenLop = txtTenLop.Text;
                lh.MaKhoaDT = txtMaKDT.Text;
                lh.SoSV = Convert.ToInt32(txtSoSV.Text);
                blllh.ThemLop(lh);
                hienthiDSLop();
                MessageBox.Show("Thêm lớp thành công!");
                txtMaLop.Text = null;
                txtTenLop.Text = null;
                txtMaKDT.Text = null;
                txtSoSV.Text = null;
            }
            catch
            {
                MessageBox.Show("Thêm lớp không thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lh.MaLop = txtMaLop.Text;
                lh.TenLop = txtTenLop.Text;
                lh.MaKhoaDT = txtMaKDT.Text;
                lh.SoSV = Convert.ToInt32(txtSoSV.Text);
                blllh.SuaLop(lh);
                hienthiDSLop();
                MessageBox.Show("Sửa lớp thành công!");
                txtMaLop.Text = null;
                txtTenLop.Text = null;
                txtMaKDT.Text = null;
                txtSoSV.Text = null;
            }
            catch
            {
                MessageBox.Show("Sửa lớp không thành công!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lh.MaLop = txtMaLop.Text;
                blllh.XoaLop(lh);
                hienthiDSLop();
                MessageBox.Show("Xóa lớp thành công!");
                txtMaLop.Text = null;
                txtTenLop.Text = null;
                txtMaKDT.Text = null;
                txtSoSV.Text = null;
            }
            catch
            {
                MessageBox.Show("Xóa lớp không thành công!");
            }
        }

        private void dgvDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSLop.CurrentRow.Index;
            txtMaLop.Text = dgvDSLop.Rows[i].Cells[0].Value.ToString();
            txtTenLop.Text = dgvDSLop.Rows[i].Cells[1].Value.ToString();
            txtMaKDT.Text = dgvDSLop.Rows[i].Cells[2].Value.ToString();
            txtSoSV.Text = dgvDSLop.Rows[i].Cells[3].Value.ToString();
        }

        private void dgvDSKDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSKDT.CurrentRow.Index;
            txtMaKDT.Text = dgvDSKDT.Rows[i].Cells[0].Value.ToString();
        }

        private void txtTimKiemMaLop_TextChanged(object sender, EventArgs e)
        {
            lh.MaLop = txtTimKiemMaLop.Text;
            dgvDSLop.DataSource = blllh.TimKiem(lh);
        }

        private void txtTimKiemMaKDT_TextChanged(object sender, EventArgs e)
        {
            blllh.TimKiemKDT(txtTimKiemMaKDT.Text);
            dgvDSKDT.DataSource = blllh.TimKiemKDT(txtTimKiemMaKDT.Text);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
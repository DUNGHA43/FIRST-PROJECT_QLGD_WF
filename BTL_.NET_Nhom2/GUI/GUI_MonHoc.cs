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
    public partial class GUI_MonHoc : DevExpress.XtraEditors.XtraForm
    {
        DTO_MonHoc mh = new DTO_MonHoc();
        BLL_MonHoc bllmh = new BLL_MonHoc();
        public GUI_MonHoc()
        {
            InitializeComponent();
        }
        private void HienthiMH()
        {
            dgvDSMonHoc.DataSource = bllmh.HienthiDS();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mh.MaMon = txtMaMon.Text;
                mh.TenMon = txtTenMon.Text;
                bllmh.ThemMH(mh);
                HienthiMH();
                MessageBox.Show("Thêm môn học thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm môn học không thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mh.MaMon = txtMaMon.Text;
                mh.TenMon = txtTenMon.Text;
                bllmh.SuaMH(mh); 
                HienthiMH();
                MessageBox.Show("Sửa môn học thành công!");
            }
            catch
            {
                MessageBox.Show("Sửa môn học không thành công!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mh.MaMon = txtMaMon.Text;
                bllmh.XoaMH(mh);
                HienthiMH();
                MessageBox.Show("Xóa môn học thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa môn học không thành công!");
            }
        }
        private void dgvDSMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSMonHoc.CurrentRow.Index;
            txtMaMon.Text = dgvDSMonHoc.Rows[i].Cells[0].Value.ToString();
            txtTenMon.Text = dgvDSMonHoc.Rows[i].Cells[1].Value.ToString();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void GUI_MonHoc_Load(object sender, EventArgs e)
        {
            HienthiMH();
        }

        private void txtTimKiemMaMH_TextChanged(object sender, EventArgs e)
        {
            mh.MaMon = txtTimKiemMaMH.Text;
            dgvDSMonHoc.DataSource = bllmh.TimKiem(mh);
        }
    }
}
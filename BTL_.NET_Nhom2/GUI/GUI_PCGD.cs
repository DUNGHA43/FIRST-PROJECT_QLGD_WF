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
    public partial class GUI_PCGD : DevExpress.XtraEditors.XtraForm
    {
        BLL_PCGD bllpcgd = new BLL_PCGD();
        DTO_PCGD pc = new DTO_PCGD();
        string tmp = "";
        public GUI_PCGD()
        {
            InitializeComponent();
        }
        private void HienthiDs()
        {
            dgvDSPCGD.DataSource = bllpcgd.HienThiDSPC();
        }
        private void loadGV()
        {
            txtTenGV.DisplayMember = "HoTenGV";
            txtTenGV.DataSource = bllpcgd.loadGV();
        }
        private void loadMaHocPhan()
        {
            txtMaHocPhan.DisplayMember = "MaHocPhan";
            txtMaHocPhan.DataSource = bllpcgd.loadMaHocPhan();
        }
        private void loadMaPhongHoc()
        {
            txtMaPhongHoc.DisplayMember = "MaPhongHoc";
            txtMaPhongHoc.DataSource = bllpcgd.loadMaPhongHoc();
        }
        private void loadMaLopHoc()
        {
            txtMaLop.DisplayMember = "MaLop";
            txtMaLop.DataSource = bllpcgd.loadMaLopHoc();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pc.MaPCGD = txtMaPCGD.Text;
                pc.MaGV = tmp;
                pc.MaHocPhan = txtMaHocPhan.Text;
                pc.MaPhongHoc = txtMaPhongHoc.Text;
                pc.MaLop = txtMaLop.Text;
                pc.NgayBatDau = dtpNgayBD.Text;
                pc.NgayKetThuc = dtpNgayKT.Text;
                pc.ThuHoc = txtThuHoc.Text;
                pc.CaHoc = Convert.ToInt32(txtCaHoc.Text);
                bllpcgd.ThemPCGD(pc);
                HienthiDs();
                MessageBox.Show("Thêm thành công!");
                txtMaPCGD.Text = null;
                txtTenGV.Text = null;
                tmp = null;
                txtMaHocPhan.Text = null;
                txtMaPhongHoc.Text = null;
                txtMaLop.Text = null;
                txtThuHoc.Text = null;
                txtCaHoc.Text = null;
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pc.MaPCGD = txtMaPCGD.Text;
                pc.MaGV = tmp;
                pc.MaHocPhan = txtMaHocPhan.Text;
                pc.MaPhongHoc = txtMaPhongHoc.Text;
                pc.MaLop = txtMaLop.Text;
                pc.NgayBatDau = dtpNgayBD.Text;
                pc.NgayKetThuc = dtpNgayKT.Text;
                pc.ThuHoc = txtThuHoc.Text;
                pc.CaHoc = Convert.ToInt32(txtCaHoc.Text);
                bllpcgd.SuaPCGD(pc);
                HienthiDs();
                MessageBox.Show("Sửa thành công!");
                txtMaPCGD.Text = null;
                txtTenGV.Text = null;
                tmp = null;
                txtMaHocPhan.Text = null;
                txtMaPhongHoc.Text = null;
                txtMaLop.Text = null;
                txtThuHoc.Text = null;
                txtCaHoc.Text = null;
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void GUI_PCGD_Load(object sender, EventArgs e)
        {
            HienthiDs();
            loadGV();
            loadMaHocPhan();
            loadMaPhongHoc();
            loadMaLopHoc();
        }

        private void dgvDSPCGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSPCGD.CurrentRow.Index;
            txtMaPCGD.Text = dgvDSPCGD.Rows[i].Cells[0].Value.ToString();
            txtTenGV.Text = dgvDSPCGD.Rows[i].Cells[1].Value.ToString();
            txtMaHocPhan.Text = dgvDSPCGD.Rows[i].Cells[2].Value.ToString();
            txtMaPhongHoc.Text = dgvDSPCGD.Rows[i].Cells[3].Value.ToString();
            txtMaLop.Text = dgvDSPCGD.Rows[i].Cells[4].Value.ToString();
            dtpNgayBD.Text = dgvDSPCGD.Rows[i].Cells[6].Value.ToString();
            dtpNgayKT.Text = dgvDSPCGD.Rows[i].Cells[7].Value.ToString();
            txtThuHoc.Text = dgvDSPCGD.Rows[i].Cells[8].Value.ToString();
            txtCaHoc.Text = dgvDSPCGD.Rows[i].Cells[9].Value.ToString();
        }

        private void txtTimKiemMaPC_TextChanged(object sender, EventArgs e)
        {
            pc.MaPCGD = txtTimKiemMaPC.Text;
            dgvDSPCGD.DataSource = bllpcgd.TimkiemDSPC(pc);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = null;
            tmp = bllpcgd.loadMaGV(txtTenGV.Text.Trim());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
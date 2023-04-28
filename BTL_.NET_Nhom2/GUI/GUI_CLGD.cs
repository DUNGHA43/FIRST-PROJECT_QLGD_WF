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
using BLL;
namespace GUI
{
    public partial class GUI_CLGD : DevExpress.XtraEditors.XtraForm
    {
        BLL_BAOCAO_CLGD _BC = new BLL_BAOCAO_CLGD();
        string tmp = null;
        public GUI_CLGD()
        {
            InitializeComponent();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BAOCAO_CLGD rp = new BAOCAO_CLGD();
            rp.SetDataSource(_BC.TaoBaoCao_CLGD(tmp));
            REPORT RP = new REPORT();
            RP.cryRP.ReportSource = rp;
            RP.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvCLGD.DataSource = _BC.TimKiem_CLGD_GV(tmp);
        }

        private void txtTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = _BC.loadMaGV(txtTenGV.Text.Trim());
        }

        private void btnHienALL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadDS_CTGD();
        }
        private void loadDS_CTGD()
        {
            dgvCLGD.DataSource = _BC.Hienth_DS();
        }
        private void loadTenGV()
        {
            txtTenGV.DisplayMember = "HoTenGV";
            txtTenGV.DataSource = _BC.loadTenGV();
        }
        private void GUI_CLGD_Load(object sender, EventArgs e)
        {
            loadDS_CTGD();
            loadTenGV();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
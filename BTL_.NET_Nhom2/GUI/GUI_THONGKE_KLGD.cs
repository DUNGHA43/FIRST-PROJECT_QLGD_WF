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
using System.Data.SqlClient;

namespace GUI
{
    public partial class GUI_THONGKE_KLGD : DevExpress.XtraEditors.XtraForm
    {
        BLL_BAOCAO_KLGD _BC = new BLL_BAOCAO_KLGD();
        string tmp = null;
        public GUI_THONGKE_KLGD()
        {
            InitializeComponent();
        }
        private void HienThiDS()
        {
            dgvDSPCGD.DataSource = _BC.HienTHiDS();
        }
        private void LoadTenGV()
        {
            txtTenGV.DisplayMember = "HoTenGV";
            txtTenGV.DataSource = _BC.loadTenGV();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BC_PCGD rp = new BC_PCGD();
            rp.SetDataSource(_BC.BaoCao_DS_ALL_PCGD());
            REPORT RP = new REPORT();
            RP.cryRP.ReportSource = rp;
            RP.ShowDialog();
        }

        private void GUI_THONGKE_KLGD_Load(object sender, EventArgs e)
        {
            HienThiDS();
            LoadTenGV();
        }

        private void btnTaoTKB_Click(object sender, EventArgs e)
        {
            BC_PCGD rp = new BC_PCGD();
            rp.SetDataSource(_BC.BaoCao_DS_ALL_PCGD_GV(tmp));
            REPORT RP = new REPORT();
            RP.cryRP.ReportSource = rp;
            RP.ShowDialog();
        }

        private void txtTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmp = _BC.loadMaGV(txtTenGV.Text);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HienThiDS();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvDSPCGD.DataSource = _BC.BaoCao_DS_TIMKIEM_PCGD_GV(tmp);
        }
    }
}
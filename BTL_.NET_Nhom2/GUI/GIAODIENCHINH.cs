using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string tk;
        string mk;
        public Main_Form()
        {
            InitializeComponent();
        }
        public Main_Form(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonPage2;
        }
        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_GiangVien gv = new GUI_GiangVien();
            gv.MdiParent = this;
            gv.Show();
        }



        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_MonHoc mh = new GUI_MonHoc();
            mh.MdiParent = this;
            mh.Show();
        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_LopHoc mh = new GUI_LopHoc();
            mh.MdiParent = this;
            mh.Show();
        }
        private void btnPhongHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_PhongHoc ph = new GUI_PhongHoc();
            ph.MdiParent = this;
            ph.Show();
        }

        private void btnPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_PCGD pc = new GUI_PCGD();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btnQuanLyTietDay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_QuanLyTietDay ql = new GUI_QuanLyTietDay();
            ql.MdiParent = this;
            ql.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_THONGKE_KLGD tk = new GUI_THONGKE_KLGD();
            tk.MdiParent = this;
            tk.Show();
        }

        private void btnTKCLGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CLGD tk = new GUI_CLGD();
            tk.MdiParent = this;
            tk.Show();
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_DoiMatKhau dmk = new GUI_DoiMatKhau(tk,mk);
            dmk.MdiParent = this;
            dmk.Show();
        }
    }
}


namespace GUI
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyTietDay = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKePCGD = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKCLGD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnThoat,
            this.btnGV,
            this.btnMonHoc,
            this.btnLopHoc,
            this.btnPhongHoc,
            this.btnPhanCong,
            this.btnQuanLyTietDay,
            this.btnThongKePCGD,
            this.btnTKCLGD,
            this.barButtonItem2,
            this.btnDoiMK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1080, 158);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnGV
            // 
            this.btnGV.Caption = "GIẢNG VIÊN";
            this.btnGV.Id = 2;
            this.btnGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGV.ImageOptions.SvgImage")));
            this.btnGV.Name = "btnGV";
            this.btnGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "MÔN HỌC";
            this.btnMonHoc.Id = 3;
            this.btnMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonHoc.ImageOptions.SvgImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Caption = "LỚP HỌC";
            this.btnLopHoc.Id = 4;
            this.btnLopHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLopHoc.ImageOptions.SvgImage")));
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLopHoc_ItemClick);
            // 
            // btnPhongHoc
            // 
            this.btnPhongHoc.Caption = "PHÒNG HỌC";
            this.btnPhongHoc.Id = 5;
            this.btnPhongHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongHoc.ImageOptions.Image")));
            this.btnPhongHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhongHoc.ImageOptions.LargeImage")));
            this.btnPhongHoc.Name = "btnPhongHoc";
            this.btnPhongHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongHoc_ItemClick);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Caption = "PHÂN CÔNG LỊCH GIẢNG DẠY";
            this.btnPhanCong.Id = 6;
            this.btnPhanCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhanCong.ImageOptions.SvgImage")));
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhanCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanCong_ItemClick);
            // 
            // btnQuanLyTietDay
            // 
            this.btnQuanLyTietDay.Caption = "QUẢN LÝ TIẾT DẠY";
            this.btnQuanLyTietDay.Id = 7;
            this.btnQuanLyTietDay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQuanLyTietDay.ImageOptions.SvgImage")));
            this.btnQuanLyTietDay.Name = "btnQuanLyTietDay";
            this.btnQuanLyTietDay.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuanLyTietDay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyTietDay_ItemClick);
            // 
            // btnThongKePCGD
            // 
            this.btnThongKePCGD.Caption = "THỐNG KÊ KHỐI LƯỢNG GIẢNG DẠY";
            this.btnThongKePCGD.Id = 8;
            this.btnThongKePCGD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKePCGD.ImageOptions.SvgImage")));
            this.btnThongKePCGD.Name = "btnThongKePCGD";
            this.btnThongKePCGD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongKePCGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // btnTKCLGD
            // 
            this.btnTKCLGD.Caption = "THỐNG KÊ CHẤT LƯỢNG GIẢNG DẠY";
            this.btnTKCLGD.Id = 9;
            this.btnTKCLGD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTKCLGD.ImageOptions.SvgImage")));
            this.btnTKCLGD.Name = "btnTKCLGD";
            this.btnTKCLGD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTKCLGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKCLGD_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "ĐỔI MẬT KHẨU";
            this.btnDoiMK.Id = 11;
            this.btnDoiMK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMK.ImageOptions.SvgImage")));
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMK_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMK, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "DANH MỤC";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "DANH MỤC";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLopHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongHoc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "DANH MỤC QUẢN LÝ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhanCong);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQuanLyTietDay);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "GIẢNG DẠY";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "THỐNG KÊ & BÁO CÁO";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThongKePCGD);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTKCLGD);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "THỐNG KÊ VÀ IN BÁO CÁO";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Main_Form.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Name = "Main_Form";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ GIẢNG DẠY";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnGV;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnPhongHoc;
        private DevExpress.XtraBars.BarButtonItem btnPhanCong;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyTietDay;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnThongKePCGD;
        private DevExpress.XtraBars.BarButtonItem btnTKCLGD;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
    }
}


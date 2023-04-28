
namespace GUI
{
    partial class GUI_CLGD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CLGD));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.btnHienALL = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem6 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.btnXacNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuaXacNhan = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.lbChonGV = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.ComboBox();
            this.btnTaoBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCLGD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLGD)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar9});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.barStaticItem1,
            this.barEditItem6,
            this.barEditItem2,
            this.barStaticItem2,
            this.barHeaderItem1,
            this.barStaticItem3,
            this.barEditItem1,
            this.btnDong,
            this.barStaticItem4,
            this.barEditItem3,
            this.btnXacNhan,
            this.btnChuaXacNhan,
            this.btnHienALL});
            this.barManager1.MainMenu = this.bar9;
            this.barManager1.MaxItemId = 17;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemHypertextLabel1,
            this.repositoryItemTextEdit2,
            this.repositoryItemFontEdit1});
            // 
            // bar9
            // 
            this.bar9.BarName = "Custom 2";
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHienALL)});
            this.bar9.OptionsBar.MultiLine = true;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Custom 2";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "ĐÓNG";
            this.btnDong.Id = 10;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnHienALL
            // 
            this.btnHienALL.Caption = "HIỂN THỊ TẤT CẢ";
            this.btnHienALL.Id = 16;
            this.btnHienALL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHienALL.ImageOptions.SvgImage")));
            this.btnHienALL.Name = "btnHienALL";
            this.btnHienALL.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHienALL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHienALL_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(792, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(792, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(792, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "TẠO BÁO CÁO";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSua
            // 
            this.btnSua.Caption = "CẬP NHẬT";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "XÓA";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItem6
            // 
            this.barEditItem6.Caption = "barEditItem1";
            this.barEditItem6.Edit = this.repositoryItemTextEdit1;
            this.barEditItem6.Id = 4;
            this.barEditItem6.Name = "barEditItem6";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemHypertextLabel1;
            this.barEditItem2.Id = 5;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "TÌM KIẾM:";
            this.barStaticItem2.Id = 6;
            this.barStaticItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.Image")));
            this.barStaticItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.ImageOptions.LargeImage")));
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barStaticItem2.Size = new System.Drawing.Size(90, 0);
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.barStaticItem2.Width = 90;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 7;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "MÃ MÔN HỌC:";
            this.barStaticItem3.Id = 8;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem3";
            this.barEditItem1.Edit = this.repositoryItemTextEdit2;
            this.barEditItem1.Id = 9;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "barStaticItem4";
            this.barStaticItem4.Id = 11;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemFontEdit1;
            this.barEditItem3.Id = 12;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Caption = "XÁC NHẬN HOÀN THÀNH";
            this.btnXacNhan.Id = 13;
            this.btnXacNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXacNhan.ImageOptions.SvgImage")));
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnChuaXacNhan
            // 
            this.btnChuaXacNhan.Caption = "XÁC NHẬN CHƯA HOÀN THÀNH";
            this.btnChuaXacNhan.Id = 15;
            this.btnChuaXacNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuaXacNhan.ImageOptions.SvgImage")));
            this.btnChuaXacNhan.Name = "btnChuaXacNhan";
            this.btnChuaXacNhan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.lbChonGV);
            this.panel1.Controls.Add(this.txtTenGV);
            this.panel1.Controls.Add(this.btnTaoBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 93);
            this.panel1.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXem.Location = new System.Drawing.Point(317, 37);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "XEM";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lbChonGV
            // 
            this.lbChonGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChonGV.AutoSize = true;
            this.lbChonGV.Location = new System.Drawing.Point(83, 42);
            this.lbChonGV.Name = "lbChonGV";
            this.lbChonGV.Size = new System.Drawing.Size(101, 13);
            this.lbChonGV.TabIndex = 7;
            this.lbChonGV.Text = "CHỌN GIẢNG VIÊN:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenGV.FormattingEnabled = true;
            this.txtTenGV.Location = new System.Drawing.Point(190, 39);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(121, 21);
            this.txtTenGV.TabIndex = 6;
            this.txtTenGV.SelectedIndexChanged += new System.EventHandler(this.txtTenGV_SelectedIndexChanged);
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTaoBaoCao.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaoBaoCao.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaoBaoCao.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTaoBaoCao.Appearance.Options.UseBackColor = true;
            this.btnTaoBaoCao.Appearance.Options.UseForeColor = true;
            this.btnTaoBaoCao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoBaoCao.ImageOptions.SvgImage")));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(517, 31);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(148, 35);
            this.btnTaoBaoCao.TabIndex = 5;
            this.btnTaoBaoCao.Text = "TẠO BÁO CÁO";
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCLGD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CÁC CA NGHỈ VỚI CA BÙ CỦA GIẢNG VIÊN";
            // 
            // dgvCLGD
            // 
            this.dgvCLGD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCLGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCLGD.Location = new System.Drawing.Point(3, 17);
            this.dgvCLGD.Name = "dgvCLGD";
            this.dgvCLGD.Size = new System.Drawing.Size(786, 368);
            this.dgvCLGD.TabIndex = 0;
            // 
            // GUI_CLGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_CLGD";
            this.Text = "THỐNG KÊ CHẤT LƯỢNG GIẢNG DẠY";
            this.Load += new System.EventHandler(this.GUI_CLGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnHienALL;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraBars.BarButtonItem btnXacNhan;
        private DevExpress.XtraBars.BarButtonItem btnChuaXacNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCLGD;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lbChonGV;
        private System.Windows.Forms.ComboBox txtTenGV;
        private DevExpress.XtraEditors.SimpleButton btnTaoBaoCao;
    }
}
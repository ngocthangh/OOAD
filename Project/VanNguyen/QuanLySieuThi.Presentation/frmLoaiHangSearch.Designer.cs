namespace QuanLySieuThi.Presentation
{
    partial class frmLoaiHangSearch
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtLoaiHangSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcLoaiHangSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaChungLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiHangSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHangSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtLoaiHangSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(695, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // txtLoaiHangSearch
            // 
            this.txtLoaiHangSearch.Location = new System.Drawing.Point(125, 11);
            this.txtLoaiHangSearch.Name = "txtLoaiHangSearch";
            this.txtLoaiHangSearch.Size = new System.Drawing.Size(432, 20);
            this.txtLoaiHangSearch.TabIndex = 7;
            this.txtLoaiHangSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhaCungCapSearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Nhập Từ Khóa Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.Zoom_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(563, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.btnDong);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 37);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(695, 38);
            this.panelControl2.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(168, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(87, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.add_1_icon;
            this.btnThem.Location = new System.Drawing.Point(6, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(249, 9);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 75);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(695, 292);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grcLoaiHangSearch);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(691, 288);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // grcLoaiHangSearch
            // 
            this.grcLoaiHangSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLoaiHangSearch.Location = new System.Drawing.Point(2, 20);
            this.grcLoaiHangSearch.MainView = this.gridView;
            this.grcLoaiHangSearch.Name = "grcLoaiHangSearch";
            this.grcLoaiHangSearch.Size = new System.Drawing.Size(687, 266);
            this.grcLoaiHangSearch.TabIndex = 0;
            this.grcLoaiHangSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grcLoaiHangSearch.Load += new System.EventHandler(this.grcLoaiHangSearch_Load);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoaiHang,
            this.TenLoaiHang,
            this.MaChungLoai});
            this.gridView.GridControl = this.grcLoaiHangSearch;
            this.gridView.Name = "gridView";
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.Caption = "Mã Loại Hàng";
            this.MaLoaiHang.FieldName = "MaLoaiHang";
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Visible = true;
            this.MaLoaiHang.VisibleIndex = 0;
            this.MaLoaiHang.Width = 119;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.Caption = "Tên Loại Hàng";
            this.TenLoaiHang.FieldName = "TenLoaiHang";
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.Visible = true;
            this.TenLoaiHang.VisibleIndex = 1;
            this.TenLoaiHang.Width = 177;
            // 
            // MaChungLoai
            // 
            this.MaChungLoai.Caption = "Chủng Loại";
            this.MaChungLoai.FieldName = "MaChungLoai";
            this.MaChungLoai.Name = "MaChungLoai";
            this.MaChungLoai.Visible = true;
            this.MaChungLoai.VisibleIndex = 2;
            this.MaChungLoai.Width = 375;
            // 
            // frmLoaiHangSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 367);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmLoaiHangSearch";
            this.Text = "frmLoaiHangSearch";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiHangSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHangSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtLoaiHangSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraGrid.GridControl grcLoaiHangSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaChungLoai;
    }
}
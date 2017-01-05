namespace QuanLySieuThi.Presentation
{
    partial class FrmTraCuuKhachHangThanThiet
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
            this.grcNhaCungCap = new DevExpress.XtraEditors.GroupControl();
            this.grcKHTTSearch = new DevExpress.XtraGrid.GridControl();
            this.grvKHTTSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCapThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiemTichLuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtKHTTSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).BeginInit();
            this.grcNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKHTTSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKHTTSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHTTSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhaCungCap
            // 
            this.grcNhaCungCap.Controls.Add(this.grcKHTTSearch);
            this.grcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhaCungCap.Location = new System.Drawing.Point(0, 73);
            this.grcNhaCungCap.Name = "grcNhaCungCap";
            this.grcNhaCungCap.Size = new System.Drawing.Size(650, 372);
            this.grcNhaCungCap.TabIndex = 2;
            this.grcNhaCungCap.Text = "Kết Quả Tìm Kiếm";
            // 
            // grcKHTTSearch
            // 
            this.grcKHTTSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKHTTSearch.Location = new System.Drawing.Point(2, 20);
            this.grcKHTTSearch.MainView = this.grvKHTTSearch;
            this.grcKHTTSearch.Name = "grcKHTTSearch";
            this.grcKHTTSearch.Size = new System.Drawing.Size(646, 350);
            this.grcKHTTSearch.TabIndex = 4;
            this.grcKHTTSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKHTTSearch});
            // 
            // grvKHTTSearch
            // 
            this.grvKHTTSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhachHang,
            this.HoTen,
            this.DiaChi,
            this.CMND,
            this.NgayCapThe,
            this.DiemTichLuy});
            this.grvKHTTSearch.GridControl = this.grcKHTTSearch;
            this.grvKHTTSearch.IndicatorWidth = 20;
            this.grvKHTTSearch.Name = "grvKHTTSearch";
            this.grvKHTTSearch.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grvKHTTSearch.OptionsSelection.MultiSelect = true;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Caption = "Mã KHTT";
            this.MaKhachHang.FieldName = "MaKhachHang";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.OptionsColumn.AllowEdit = false;
            this.MaKhachHang.Visible = true;
            this.MaKhachHang.VisibleIndex = 0;
            this.MaKhachHang.Width = 56;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Tên khách hàng";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 89;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.AllowEdit = false;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 74;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.OptionsColumn.AllowEdit = false;
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 3;
            // 
            // NgayCapThe
            // 
            this.NgayCapThe.Caption = "Ngày cấp thẻ";
            this.NgayCapThe.FieldName = "NgayCapThe";
            this.NgayCapThe.Name = "NgayCapThe";
            this.NgayCapThe.OptionsColumn.AllowEdit = false;
            this.NgayCapThe.Visible = true;
            this.NgayCapThe.VisibleIndex = 4;
            this.NgayCapThe.Width = 74;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.Caption = "Điểm tích lũy";
            this.DiemTichLuy.FieldName = "DiemThuong";
            this.DiemTichLuy.Name = "DiemTichLuy";
            this.DiemTichLuy.OptionsColumn.AllowEdit = false;
            this.DiemTichLuy.Visible = true;
            this.DiemTichLuy.VisibleIndex = 5;
            this.DiemTichLuy.Width = 86;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.btnDong);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(650, 33);
            this.panelControl2.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(85, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtKHTTSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(650, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // txtKHTTSearch
            // 
            this.txtKHTTSearch.Location = new System.Drawing.Point(127, 12);
            this.txtKHTTSearch.Name = "txtKHTTSearch";
            this.txtKHTTSearch.Size = new System.Drawing.Size(432, 20);
            this.txtKHTTSearch.TabIndex = 4;
            this.txtKHTTSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKHTTSearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhập Từ Khóa Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(565, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmTraCuuKhachHangThanThiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 445);
            this.Controls.Add(this.grcNhaCungCap);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmTraCuuKhachHangThanThiet";
            this.Text = "TraCuuKhachHangThanThiet";
            this.Load += new System.EventHandler(this.FrmTraCuuKhachHangThanThiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).EndInit();
            this.grcNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcKHTTSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKHTTSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHTTSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grcNhaCungCap;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtKHTTSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.GridControl grcKHTTSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKHTTSearch;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCapThe;
        private DevExpress.XtraGrid.Columns.GridColumn DiemTichLuy;
    }
}
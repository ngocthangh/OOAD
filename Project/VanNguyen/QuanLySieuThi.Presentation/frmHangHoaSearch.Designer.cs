namespace QuanLySieuThi.Presentation
{
    partial class frmHangHoaSearch
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grcHanghoaSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dtNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcHanghoaSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.txtTimKiem);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(950, 54);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tìm Kiếm Hàng Hóa";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grcHanghoaSearch);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(950, 308);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Kết Quả Tìm Kiếm";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtNgayNhap);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 328);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(950, 34);
            this.panelControl1.TabIndex = 2;
            // 
            // grcHanghoaSearch
            // 
            this.grcHanghoaSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcHanghoaSearch.Location = new System.Drawing.Point(2, 20);
            this.grcHanghoaSearch.MainView = this.gridView;
            this.grcHanghoaSearch.Name = "grcHanghoaSearch";
            this.grcHanghoaSearch.Size = new System.Drawing.Size(946, 286);
            this.grcHanghoaSearch.TabIndex = 0;
            this.grcHanghoaSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.GiaMua,
            this.GiaBan,
            this.SoLuongNhap,
            this.SoLuongBan,
            this.NgayNhap,
            this.NgaySanXuat,
            this.HanSuDung,
            this.VAT,
            this.LoaiHang,
            this.DonViTinh});
            this.gridView.GridControl = this.grcHanghoaSearch;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.Caption = "Mã Hàng Hóa";
            this.MaHangHoa.FieldName = "MaHangHoa";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.OptionsColumn.AllowEdit = false;
            this.MaHangHoa.Visible = true;
            this.MaHangHoa.VisibleIndex = 0;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.Caption = "Tên Hàng Hóa";
            this.TenHangHoa.FieldName = "TenHangHoa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.OptionsColumn.AllowEdit = false;
            this.TenHangHoa.Visible = true;
            this.TenHangHoa.VisibleIndex = 1;
            // 
            // GiaMua
            // 
            this.GiaMua.Caption = "Giá Mua";
            this.GiaMua.FieldName = "GiaMua";
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.OptionsColumn.AllowEdit = false;
            this.GiaMua.Visible = true;
            this.GiaMua.VisibleIndex = 2;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá Bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.OptionsColumn.AllowEdit = false;
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 3;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.Caption = "Số Lượng Nhập";
            this.SoLuongNhap.FieldName = "SoLuongNhap";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.OptionsColumn.AllowEdit = false;
            this.SoLuongNhap.Visible = true;
            this.SoLuongNhap.VisibleIndex = 4;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.Caption = "Số Lượng Bán";
            this.SoLuongBan.FieldName = "SoLuongBan";
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.OptionsColumn.AllowEdit = false;
            this.SoLuongBan.Visible = true;
            this.SoLuongBan.VisibleIndex = 5;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.OptionsColumn.AllowEdit = false;
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 6;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.Caption = "Ngày Sản Xuất";
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.OptionsColumn.AllowEdit = false;
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 7;
            // 
            // HanSuDung
            // 
            this.HanSuDung.Caption = "Hạn Sử Dụng";
            this.HanSuDung.FieldName = "HanSuDung";
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.OptionsColumn.AllowEdit = false;
            this.HanSuDung.Visible = true;
            this.HanSuDung.VisibleIndex = 8;
            // 
            // VAT
            // 
            this.VAT.Caption = "VAT";
            this.VAT.FieldName = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.OptionsColumn.AllowEdit = false;
            this.VAT.Visible = true;
            this.VAT.VisibleIndex = 9;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Caption = "Loại Hàng";
            this.LoaiHang.FieldName = "MaLoaiHang";
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.OptionsColumn.AllowEdit = false;
            this.LoaiHang.Visible = true;
            this.LoaiHang.VisibleIndex = 10;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị Tính";
            this.DonViTinh.FieldName = "MaDVT";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập Thông Tin Cần Tìm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(140, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 20);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.Zoom_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(476, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.EditValue = null;
            this.dtNgayNhap.Location = new System.Drawing.Point(104, 127);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayNhap.Properties.DisplayFormat.FormatString = "";
            this.dtNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayNhap.Properties.EditFormat.FormatString = "";
            this.dtNgayNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dtNgayNhap.Size = new System.Drawing.Size(131, 20);
            this.dtNgayNhap.TabIndex = 20;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLySieuThi.Presentation.Properties.Resources.Actions_document_edit_icon;
            this.btnSua.Location = new System.Drawing.Point(93, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(253, 6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(172, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.add_1_icon;
            this.btnThem.Location = new System.Drawing.Point(12, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHangHoaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 362);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmHangHoaSearch";
            this.Text = "Tìm Kiếm Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoaSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcHanghoaSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grcHanghoaSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBan;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn HanSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn VAT;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtNgayNhap;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}
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
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
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
            this.LookUpEditLoaiHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHanghoaSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(832, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 30);
            this.btnTimKiem.StyleController = this.layoutControl3;
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.txtTimKiem);
            this.layoutControl3.Controls.Add(this.btnTimKiem);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(388, 160, 250, 350);
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(978, 54);
            this.layoutControl3.TabIndex = 4;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(83, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(735, 20);
            this.txtTimKiem.StyleController = this.layoutControl3;
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.emptySpaceItem6,
            this.layoutControlItem7,
            this.emptySpaceItem8});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(978, 54);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnTimKiem;
            this.layoutControlItem6.Location = new System.Drawing.Point(820, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(56, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(138, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(810, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTimKiem;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(810, 24);
            this.layoutControlItem7.Text = "Nhập Từ Khóa";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem8.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem8.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(810, 10);
            this.emptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // grcHanghoaSearch
            // 
            this.grcHanghoaSearch.Location = new System.Drawing.Point(12, 12);
            this.grcHanghoaSearch.MainView = this.gridView;
            this.grcHanghoaSearch.Name = "grcHanghoaSearch";
            this.grcHanghoaSearch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditLoaiHang,
            this.LookUpEditDonViTinh});
            this.grcHanghoaSearch.Size = new System.Drawing.Size(954, 296);
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
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
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
            this.LoaiHang.ColumnEdit = this.LookUpEditLoaiHang;
            this.LoaiHang.FieldName = "MaLoaiHang";
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.OptionsColumn.AllowEdit = false;
            this.LoaiHang.Visible = true;
            this.LoaiHang.VisibleIndex = 10;
            // 
            // LookUpEditLoaiHang
            // 
            this.LookUpEditLoaiHang.AutoHeight = false;
            this.LookUpEditLoaiHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditLoaiHang.Name = "LookUpEditLoaiHang";
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị Tính";
            this.DonViTinh.ColumnEdit = this.LookUpEditDonViTinh;
            this.DonViTinh.FieldName = "MaDVT";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 11;
            // 
            // LookUpEditDonViTinh
            // 
            this.LookUpEditDonViTinh.AutoHeight = false;
            this.LookUpEditDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditDonViTinh.Name = "LookUpEditDonViTinh";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(685, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 24);
            this.btnThem.StyleController = this.layoutControl1;
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSua);
            this.layoutControl1.Controls.Add(this.btnThem);
            this.layoutControl1.Controls.Add(this.btnDong);
            this.layoutControl1.Controls.Add(this.btnXoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 374);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(430, 125, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(978, 48);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(771, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 24);
            this.btnSua.StyleController = this.layoutControl1;
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(906, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(60, 23);
            this.btnDong.StyleController = this.layoutControl1;
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(836, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 23);
            this.btnXoa.StyleController = this.layoutControl1;
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(978, 48);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDong;
            this.layoutControlItem2.Location = new System.Drawing.Point(894, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(64, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(884, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(824, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(60, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(814, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSua;
            this.layoutControlItem4.Location = new System.Drawing.Point(759, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(55, 28);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(749, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnThem;
            this.layoutControlItem5.Location = new System.Drawing.Point(673, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(76, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(673, 28);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.grcHanghoaSearch);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(0, 54);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup4;
            this.layoutControl4.Size = new System.Drawing.Size(978, 320);
            this.layoutControl4.TabIndex = 5;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(978, 320);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcHanghoaSearch;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(958, 300);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmHangHoaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 422);
            this.Controls.Add(this.layoutControl4);
            this.Controls.Add(this.layoutControl3);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmHangHoaSearch";
            this.Text = "Tìm Kiếm Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoaSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcHanghoaSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditLoaiHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditDonViTinh;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
    }
}
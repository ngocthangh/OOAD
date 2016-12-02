namespace QuanLySieuThi.Presentation
{
    partial class frmHangHoa
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditLoaiHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditDVT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GridLookUpEditLoaiHang = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridLookUpEditDVT = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunmHangHoaSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(962, 33);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDong);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(958, 33);
            this.panelControl2.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(166, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(85, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grcHangHoa);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 33);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(962, 379);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách Hàng Hóa";
            // 
            // grcHangHoa
            // 
            this.grcHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcHangHoa.Location = new System.Drawing.Point(2, 20);
            this.grcHangHoa.MainView = this.gridView;
            this.grcHangHoa.Name = "grcHangHoa";
            this.grcHangHoa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GridLookUpEditLoaiHang,
            this.GridLookUpEditDVT,
            this.LookUpEditLoaiHang,
            this.LookUpEditDVT});
            this.grcHangHoa.Size = new System.Drawing.Size(958, 357);
            this.grcHangHoa.TabIndex = 0;
            this.grcHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grcHangHoa.Load += new System.EventHandler(this.grcHangHoa_Load);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenHangHoa,
            this.GiaMua,
            this.GiaBan,
            this.NgaySanXuat,
            this.HanSuDung,
            this.SoLuongNhap,
            this.SoLuongBan,
            this.NgayNhap,
            this.VAT,
            this.MaLoaiHang,
            this.MaDVT});
            this.gridView.GridControl = this.grcHangHoa;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm Mới";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.Caption = "Tên Hàng Hóa";
            this.TenHangHoa.FieldName = "TenHangHoa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Visible = true;
            this.TenHangHoa.VisibleIndex = 0;
            this.TenHangHoa.Width = 83;
            // 
            // GiaMua
            // 
            this.GiaMua.Caption = "Giá Mua";
            this.GiaMua.FieldName = "GiaMua";
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.Visible = true;
            this.GiaMua.VisibleIndex = 1;
            this.GiaMua.Width = 83;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá Bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 2;
            this.GiaBan.Width = 83;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.Caption = "Ngày Sản Xuất";
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 3;
            this.NgaySanXuat.Width = 83;
            // 
            // HanSuDung
            // 
            this.HanSuDung.Caption = "Hạn Sử Dụng";
            this.HanSuDung.FieldName = "HanSuDung";
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Visible = true;
            this.HanSuDung.VisibleIndex = 4;
            this.HanSuDung.Width = 83;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.Caption = "Số Lượng Nhập";
            this.SoLuongNhap.FieldName = "SoLuongNhap";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Visible = true;
            this.SoLuongNhap.VisibleIndex = 5;
            this.SoLuongNhap.Width = 83;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.Caption = "Số Lượng Bán";
            this.SoLuongBan.FieldName = "SoLuongBan";
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.Visible = true;
            this.SoLuongBan.VisibleIndex = 6;
            this.SoLuongBan.Width = 83;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 7;
            this.NgayNhap.Width = 83;
            // 
            // VAT
            // 
            this.VAT.Caption = "VAT";
            this.VAT.FieldName = "VAT";
            this.VAT.Name = "VAT";
            this.VAT.Visible = true;
            this.VAT.VisibleIndex = 8;
            this.VAT.Width = 83;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.Caption = "Loại Hàng";
            this.MaLoaiHang.ColumnEdit = this.LookUpEditLoaiHang;
            this.MaLoaiHang.FieldName = "MaLoaiHang";
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Visible = true;
            this.MaLoaiHang.VisibleIndex = 9;
            this.MaLoaiHang.Width = 144;
            // 
            // LookUpEditLoaiHang
            // 
            this.LookUpEditLoaiHang.AutoHeight = false;
            this.LookUpEditLoaiHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditLoaiHang.Name = "LookUpEditLoaiHang";
            // 
            // MaDVT
            // 
            this.MaDVT.Caption = "Đơn Vị Tính";
            this.MaDVT.ColumnEdit = this.LookUpEditDVT;
            this.MaDVT.FieldName = "MaDVT";
            this.MaDVT.Name = "MaDVT";
            this.MaDVT.Visible = true;
            this.MaDVT.VisibleIndex = 10;
            this.MaDVT.Width = 144;
            // 
            // LookUpEditDVT
            // 
            this.LookUpEditDVT.AutoHeight = false;
            this.LookUpEditDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditDVT.Name = "LookUpEditDVT";
            // 
            // GridLookUpEditLoaiHang
            // 
            this.GridLookUpEditLoaiHang.AutoHeight = false;
            this.GridLookUpEditLoaiHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditLoaiHang.Name = "GridLookUpEditLoaiHang";
            this.GridLookUpEditLoaiHang.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // GridLookUpEditDVT
            // 
            this.GridLookUpEditDVT.AutoHeight = false;
            this.GridLookUpEditDVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditDVT.Name = "GridLookUpEditDVT";
            this.GridLookUpEditDVT.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colunmHangHoaSTT
            // 
            this.colunmHangHoaSTT.Caption = "STT";
            this.colunmHangHoaSTT.Name = "colunmHangHoaSTT";
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 412);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmHangHoa";
            this.Text = "Quản Lý Hàng Hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangHoa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grcHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn TenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn GiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn HanSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongBan;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn VAT;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaDVT;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colunmHangHoaSTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditLoaiHang;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditDVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditLoaiHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditDVT;
    }
}
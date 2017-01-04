namespace QuanLySieuThi.Presentation
{
    partial class frmPhieuKiemKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuKiemKe));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.lbMaHoaDon = new DevExpress.XtraEditors.LabelControl();
            this.txtSLTrenQuay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLTrongKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lueHangHoa = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.grcPhieuKiemKe = new DevExpress.XtraGrid.GridControl();
            this.grvPhieuKiemKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongTrenQuay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLTrongKho = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTrenQuay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTrongKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuKiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuKiemKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deNgayLap);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtNhanVien);
            this.panelControl1.Controls.Add(this.txtMaPhieu);
            this.panelControl1.Controls.Add(this.lbMaHoaDon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(755, 39);
            this.panelControl1.TabIndex = 1;
            // 
            // deNgayLap
            // 
            this.deNgayLap.EditValue = null;
            this.deNgayLap.Location = new System.Drawing.Point(446, 9);
            this.deNgayLap.Name = "deNgayLap";
            this.deNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deNgayLap.Properties.Appearance.Options.UseFont = true;
            this.deNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayLap.Size = new System.Drawing.Size(104, 22);
            this.deNgayLap.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(188, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nhân viên lập";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Location = new System.Drawing.Point(387, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 17);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Ngày lập";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(276, 9);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtNhanVien.Size = new System.Drawing.Size(99, 22);
            this.txtNhanVien.TabIndex = 7;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(72, 9);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaPhieu.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 22);
            this.txtMaPhieu.TabIndex = 7;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbMaHoaDon.Location = new System.Drawing.Point(12, 12);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(54, 17);
            this.lbMaHoaDon.TabIndex = 6;
            this.lbMaHoaDon.Text = "Mã phiếu";
            // 
            // txtSLTrenQuay
            // 
            this.txtSLTrenQuay.Location = new System.Drawing.Point(313, 29);
            this.txtSLTrenQuay.Name = "txtSLTrenQuay";
            this.txtSLTrenQuay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSLTrenQuay.Properties.Appearance.Options.UseFont = true;
            this.txtSLTrenQuay.Size = new System.Drawing.Size(57, 22);
            this.txtSLTrenQuay.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(188, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số lượng trên quầy";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hàng hóa";
            // 
            // txtSLTrongKho
            // 
            this.txtSLTrongKho.Location = new System.Drawing.Point(513, 29);
            this.txtSLTrongKho.Name = "txtSLTrongKho";
            this.txtSLTrongKho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSLTrongKho.Properties.Appearance.Options.UseFont = true;
            this.txtSLTrongKho.Size = new System.Drawing.Size(55, 22);
            this.txtSLTrongKho.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(387, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số lượng trong kho";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lueHangHoa);
            this.groupControl1.Controls.Add(this.txtSLTrongKho);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSLTrenQuay);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(755, 62);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin sản phẩm kiểm kê";
            // 
            // lueHangHoa
            // 
            this.lueHangHoa.Location = new System.Drawing.Point(72, 29);
            this.lueHangHoa.Name = "lueHangHoa";
            this.lueHangHoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueHangHoa.Properties.Appearance.Options.UseFont = true;
            this.lueHangHoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueHangHoa.Properties.NullText = "Hàng hóa";
            this.lueHangHoa.Size = new System.Drawing.Size(100, 22);
            this.lueHangHoa.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnLamMoi);
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 101);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(755, 39);
            this.panelControl2.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(313, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(219, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(88, 25);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(150, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 25);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(11, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 25);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(81, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 25);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grcPhieuKiemKe
            // 
            this.grcPhieuKiemKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPhieuKiemKe.Location = new System.Drawing.Point(0, 140);
            this.grcPhieuKiemKe.MainView = this.grvPhieuKiemKe;
            this.grcPhieuKiemKe.Name = "grcPhieuKiemKe";
            this.grcPhieuKiemKe.Size = new System.Drawing.Size(755, 206);
            this.grcPhieuKiemKe.TabIndex = 4;
            this.grcPhieuKiemKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuKiemKe});
            // 
            // grvPhieuKiemKe
            // 
            this.grvPhieuKiemKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuongTrenQuay,
            this.SLTrongKho});
            this.grvPhieuKiemKe.GridControl = this.grcPhieuKiemKe;
            this.grvPhieuKiemKe.IndicatorWidth = 40;
            this.grvPhieuKiemKe.Name = "grvPhieuKiemKe";
            this.grvPhieuKiemKe.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grvPhieuKiemKe.OptionsSelection.MultiSelect = true;
            this.grvPhieuKiemKe.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvPhieuKiemKe.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvPhieuKiemKe_CustomDrawRowIndicator);
            this.grvPhieuKiemKe.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.grvPhieuKiemKe_SelectionChanged);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "Mã hàng hóa";
            this.MaSanPham.FieldName = "MaHangHoa";
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 56;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Hàng hóa";
            this.TenSanPham.FieldName = "HangHoa";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowEdit = false;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 89;
            // 
            // SoLuongTrenQuay
            // 
            this.SoLuongTrenQuay.Caption = "Số lượng trên quầy";
            this.SoLuongTrenQuay.FieldName = "SLTonTrenQuay";
            this.SoLuongTrenQuay.Name = "SoLuongTrenQuay";
            this.SoLuongTrenQuay.OptionsColumn.AllowEdit = false;
            this.SoLuongTrenQuay.Visible = true;
            this.SoLuongTrenQuay.VisibleIndex = 2;
            this.SoLuongTrenQuay.Width = 85;
            // 
            // SLTrongKho
            // 
            this.SLTrongKho.Caption = "Số lượng trong kho";
            this.SLTrongKho.FieldName = "SLTonTrongKho";
            this.SLTrongKho.Name = "SLTrongKho";
            this.SLTrongKho.OptionsColumn.AllowEdit = false;
            this.SLTrongKho.Visible = true;
            this.SLTrongKho.VisibleIndex = 3;
            this.SLTrongKho.Width = 74;
            // 
            // frmPhieuKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 346);
            this.Controls.Add(this.grcPhieuKiemKe);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPhieuKiemKe";
            this.Text = "frmPhieuKiemKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuKiemKe_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTrenQuay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTrongKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuKiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuKiemKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSLTrongKho;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbMaHoaDon;
        private DevExpress.XtraEditors.TextEdit txtSLTrenQuay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl grcPhieuKiemKe;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhieuKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTrenQuay;
        private DevExpress.XtraGrid.Columns.GridColumn SLTrongKho;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueHangHoa;
        private DevExpress.XtraEditors.DateEdit deNgayLap;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}
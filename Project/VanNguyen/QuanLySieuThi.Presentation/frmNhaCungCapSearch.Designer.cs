namespace QuanLySieuThi.Presentation
{
    partial class frmNhaCungCapSearch
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grcNhaCungCap = new DevExpress.XtraEditors.GroupControl();
            this.grcNhaCungCapSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNhaCungCapSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.MaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).BeginInit();
            this.grcNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCapSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCapSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNhaCungCapSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(670, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.btnDong);
            this.panelControl2.Controls.Add(this.btnLuu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(670, 33);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grcNhaCungCap);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 73);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(670, 291);
            this.panelControl3.TabIndex = 2;
            // 
            // grcNhaCungCap
            // 
            this.grcNhaCungCap.Controls.Add(this.grcNhaCungCapSearch);
            this.grcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhaCungCap.Location = new System.Drawing.Point(2, 2);
            this.grcNhaCungCap.Name = "grcNhaCungCap";
            this.grcNhaCungCap.Size = new System.Drawing.Size(666, 287);
            this.grcNhaCungCap.TabIndex = 0;
            this.grcNhaCungCap.Text = "Kết Quả Tìm Kiếm";
            // 
            // grcNhaCungCapSearch
            // 
            this.grcNhaCungCapSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhaCungCapSearch.Location = new System.Drawing.Point(2, 20);
            this.grcNhaCungCapSearch.MainView = this.gridView;
            this.grcNhaCungCapSearch.Name = "grcNhaCungCapSearch";
            this.grcNhaCungCapSearch.Size = new System.Drawing.Size(662, 265);
            this.grcNhaCungCapSearch.TabIndex = 0;
            this.grcNhaCungCapSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap,
            this.SoDienThoai,
            this.DiaChi});
            this.gridView.GridControl = this.grcNhaCungCapSearch;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView.OptionsSelection.MultiSelect = true;
            // 
            // txtNhaCungCapSearch
            // 
            this.txtNhaCungCapSearch.Location = new System.Drawing.Point(127, 12);
            this.txtNhaCungCapSearch.Name = "txtNhaCungCapSearch";
            this.txtNhaCungCapSearch.Size = new System.Drawing.Size(432, 20);
            this.txtNhaCungCapSearch.TabIndex = 4;
            this.txtNhaCungCapSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhaCungCapSearch_KeyDown);
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
            this.btnTimKiem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.Zoom_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(565, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(166, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLySieuThi.Presentation.Properties.Resources.add_1_icon;
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
            this.btnDong.Location = new System.Drawing.Point(247, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(85, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Caption = "Mã Nhà Cung Cấp";
            this.MaNhaCungCap.FieldName = "MaNhaCungCap";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Visible = true;
            this.MaNhaCungCap.VisibleIndex = 0;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.Caption = "Tên Nhà Cung Cấp";
            this.TenNhaCungCap.FieldName = "TenNhaCungCap";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.Visible = true;
            this.TenNhaCungCap.VisibleIndex = 1;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "Số Điện Thoại";
            this.SoDienThoai.FieldName = "DienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 2;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            // 
            // frmNhaCungCapSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 364);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhaCungCapSearch";
            this.Text = "frmNhaCungCapSearch";
            this.Load += new System.EventHandler(this.frmNhaCungCapSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).EndInit();
            this.grcNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCapSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCapSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl grcNhaCungCap;
        private DevExpress.XtraGrid.GridControl grcNhaCungCapSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCapSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
    }
}
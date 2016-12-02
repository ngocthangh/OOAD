namespace QuanLySieuThi.Presentation
{
    partial class frmNhaCungCap
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
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.grcDSNhaCungCap = new DevExpress.XtraEditors.GroupControl();
            this.grcNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSNhaCungCap)).BeginInit();
            this.grcDSNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(678, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(176, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(95, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(14, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grcDSNhaCungCap
            // 
            this.grcDSNhaCungCap.Controls.Add(this.grcNhaCungCap);
            this.grcDSNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDSNhaCungCap.Location = new System.Drawing.Point(0, 34);
            this.grcDSNhaCungCap.Name = "grcDSNhaCungCap";
            this.grcDSNhaCungCap.Size = new System.Drawing.Size(678, 367);
            this.grcDSNhaCungCap.TabIndex = 2;
            this.grcDSNhaCungCap.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // grcNhaCungCap
            // 
            this.grcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhaCungCap.Location = new System.Drawing.Point(2, 20);
            this.grcNhaCungCap.MainView = this.gridView;
            this.grcNhaCungCap.Name = "grcNhaCungCap";
            this.grcNhaCungCap.Size = new System.Drawing.Size(674, 345);
            this.grcNhaCungCap.TabIndex = 0;
            this.grcNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView.GridControl = this.grcNhaCungCap;
            this.gridView.IndicatorWidth = 40;
            this.gridView.Name = "gridView";
            this.gridView.NewItemRowText = "Thêm Mới";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView_InvalidRowException);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Nhà Cung Cấp";
            this.gridColumn1.FieldName = "TenNhaCungCap";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Điện Thoại";
            this.gridColumn2.FieldName = "DienThoai";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa Chỉ";
            this.gridColumn3.FieldName = "DiaChi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 401);
            this.Controls.Add(this.grcDSNhaCungCap);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmNhaCungCap";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDSNhaCungCap)).EndInit();
            this.grcDSNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl grcDSNhaCungCap;
        private DevExpress.XtraGrid.GridControl grcNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
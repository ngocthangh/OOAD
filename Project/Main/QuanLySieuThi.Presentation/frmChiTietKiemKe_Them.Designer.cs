namespace QuanLySieuThi.Presentation
{
    partial class frmChiTietKiemKe_Them
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
            this.lueHangHoa = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSLTonTrenQuay = new DevExpress.XtraEditors.TextEdit();
            this.txtSLTonTrongKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTonTrenQuay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTonTrongKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueHangHoa
            // 
            this.lueHangHoa.Location = new System.Drawing.Point(166, 28);
            this.lueHangHoa.Name = "lueHangHoa";
            this.lueHangHoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueHangHoa.Properties.NullText = "Hàng hóa";
            this.lueHangHoa.Size = new System.Drawing.Size(100, 20);
            this.lueHangHoa.TabIndex = 0;
            // 
            // txtSLTonTrenQuay
            // 
            this.txtSLTonTrenQuay.Location = new System.Drawing.Point(166, 74);
            this.txtSLTonTrenQuay.Name = "txtSLTonTrenQuay";
            this.txtSLTonTrenQuay.Size = new System.Drawing.Size(100, 20);
            this.txtSLTonTrenQuay.TabIndex = 1;
            // 
            // txtSLTonTrongKho
            // 
            this.txtSLTonTrongKho.Location = new System.Drawing.Point(166, 121);
            this.txtSLTonTrongKho.Name = "txtSLTonTrongKho";
            this.txtSLTonTrongKho.Size = new System.Drawing.Size(100, 20);
            this.txtSLTonTrongKho.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Hàng Hóa";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Số lượng tồn trên quầy";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số lượng tồn trong kho";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(98, 177);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChiTietKiemKe_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 222);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSLTonTrongKho);
            this.Controls.Add(this.txtSLTonTrenQuay);
            this.Controls.Add(this.lueHangHoa);
            this.MaximizeBox = false;
            this.Name = "frmChiTietKiemKe_Them";
            this.Text = "frmChiTietKiemKe_Them";
            ((System.ComponentModel.ISupportInitialize)(this.lueHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTonTrenQuay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTonTrongKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueHangHoa;
        private DevExpress.XtraEditors.TextEdit txtSLTonTrenQuay;
        private DevExpress.XtraEditors.TextEdit txtSLTonTrongKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
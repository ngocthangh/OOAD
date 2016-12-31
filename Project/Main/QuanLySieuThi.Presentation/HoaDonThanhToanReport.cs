using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySieuThi.Presentation
{
    public partial class HoaDonThanhToanReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonThanhToanReport()
        {
            InitializeComponent();
            if(lblHoTenKhachHang.Text == null)
            {
                lblKhachHang.Visible = false;
                lblHoTenKhachHang.Visible = false;
            }
            if (lblTienGiam.Text == "(VNĐ)")
                lblTienGiam.Text = "0(VNĐ)";
        }

    }
}

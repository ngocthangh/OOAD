using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySieuThi.Presentation
{
    public partial class BaoCaoDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public static DateTime TuNgay, DenNgay;
        public static string NhanVienLap;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            lbltitle1.Text = "TỪ NGÀY " + TuNgay.ToString("dd/MM/yyyy") + " - " + DenNgay.ToString("dd/MM/yyyy");
            lblNhanVienLap.Text = NhanVienLap;
            lblNgayLap.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

    }
}

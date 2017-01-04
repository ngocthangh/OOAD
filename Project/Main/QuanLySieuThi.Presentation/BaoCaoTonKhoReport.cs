using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLySieuThi.Presentation
{
    public partial class BaoCaoTonKhoReport : DevExpress.XtraReports.UI.XtraReport
    {
        public static int thang;
        public static int nam;
        public BaoCaoTonKhoReport()
        {
            InitializeComponent();
            if(thang != 0 && nam != 0)
            {
                lblSmall.Text = "Tháng " + thang + " Năm " + nam;
            }
        }

    }
}

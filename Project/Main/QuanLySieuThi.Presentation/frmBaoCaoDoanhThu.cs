using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QuanLySieuThi.Common;

namespace QuanLySieuThi.Presentation
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            
        }

        private bool validate()
        {
            if (dedTuNgay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu");
                return false;
            }
            if (dedDenNgay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ngày kết thúc");
                return false;
            }
            return true;
        }
        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }
            decimal doanhthu = 0;
            grcDoanhThu.DataSource = HoaDonService.Search(null, dedTuNgay.DateTime.Date, dedDenNgay.DateTime.Date);
            for (int i = 0; i < grvDoanhThu.RowCount; i++)
            {
                decimal tt = decimal.Parse(grvDoanhThu.GetRowCellValue(i, "TongTien").ToString());
                doanhthu += tt;
            }
            lblTongDoanhThu.Text = "Tổng Doanh Thu: " + doanhthu + "(VNĐ)";
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }
            BaoCaoDoanhThu.TuNgay = dedTuNgay.DateTime.Date;
            BaoCaoDoanhThu.DenNgay = dedDenNgay.DateTime.Date;
            BaoCaoDoanhThu.NhanVienLap = (ProjectUltil.HoTenNhanVien != "") ? ProjectUltil.HoTenNhanVien : "";
            BaoCaoDoanhThu bc = new BaoCaoDoanhThu();
            bc.DataSource = HoaDonService.Search(null, dedTuNgay.DateTime.Date, dedDenNgay.DateTime.Date);
            bc.ShowPreviewDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

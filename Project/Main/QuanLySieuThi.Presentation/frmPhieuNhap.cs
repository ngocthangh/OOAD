using QuanLySieuThi.Common;
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

namespace QuanLySieuThi.Presentation
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhapThemSua f = new frmPhieuNhapThemSua();
            f.FormClosing += new FormClosingEventHandler(Reload);
            f.ShowDialog();
        }

        private void Reload(object sender, FormClosingEventArgs e)
        {
            frmPhieuNhapThemSua f = (frmPhieuNhapThemSua)sender;
            if (f.isDataChanged == true)
            {
                grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grvPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string soPhieu = grvPhieuNhap.GetRowCellValue(e.RowHandle, "SoPhieuNhap").ToString();
            grcHangHoa.DataSource = ChiTietPhieuNhapService.GetById(soPhieu);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = null;
            Nullable<DateTime> dateStart = null, dateEnd = null;
            if(cedKey.Checked == true)
            {
                if(sctKey.Text != "")
                {
                    key = sctKey.Text;
                }
            }
            if (cedDate.Checked == true)
            {
                if (dedDateStart.Text != "")
                {
                    dateStart = dedDateStart.DateTime.Date;
                }
                if(dedDateEnd.Text != "")
                {
                    dateEnd = dedDateEnd.DateTime.Date;
                }
            }
            if(key == null && dateStart == null && dateEnd == null)
            {
                grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
            }
            else { grcPhieuNhap.DataSource = PhieuNhapService.Search(key, dateStart, dateEnd);}
        }

        private void sctKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void cedKey_CheckedChanged(object sender, EventArgs e)
        {
            sctKey.Enabled = cedKey.Checked; 
        }

        private void cedDate_CheckedChanged(object sender, EventArgs e)
        {
            dedDateStart.Enabled = cedDate.Checked;
            dedDateEnd.Enabled = cedDate.Checked;
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            string soPhieu = grvPhieuNhap.GetRowCellValue(grvPhieuNhap.FocusedRowHandle, "SoPhieuNhap").ToString();
            if (MessageBox.Show("Hủy phiếu nhập " + soPhieu + " ?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (ChiTietPhieuNhapService.Delete(soPhieu))
                {
                    if (PhieuNhapService.Delete(soPhieu))
                    {
                        grcPhieuNhap.DataSource = PhieuNhapService.LoadDataTable();
                        MessageBox.Show("Hủy phiếu thành công!");
                    }
                    else { MessageBox.Show("Không thể hủy phiếu!"); }
                }
                else { MessageBox.Show("Không thể hủy chi tiết phiếu!"); }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string id = grvPhieuNhap.GetRowCellValue(grvPhieuNhap.FocusedRowHandle, "SoPhieuNhap").ToString();
            if(id != null)
            {
                PhieuNhapReport pnr = new PhieuNhapReport();
                pnr.DataSource = PhieuNhapService.GetById(id);
                pnr.ShowPreviewDialog();
            }
        }
    }
}

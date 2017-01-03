using DevExpress.XtraEditors;
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

namespace QuanLySieuThi.Presentation
{
    public partial class frmPhieuXuat : XtraForm
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
        }

        private void btnLapPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuatThemSua f = new frmPhieuXuatThemSua();
            f.FormClosing += new FormClosingEventHandler(Reload);
            f.ShowDialog();
        }
        private void Reload(object sender, FormClosingEventArgs e)
        {
            frmPhieuXuatThemSua f = (frmPhieuXuatThemSua)sender;
            if (f.isDataChanged == true)
            {
                 grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            string soPhieu = grvPhieuXuat.GetRowCellValue(grvPhieuXuat.FocusedRowHandle, "SoPhieuXuat").ToString();
            if (MessageBox.Show("Hủy phiếu xuất " + soPhieu + " ?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (ChiTietPhieuXuatService.Delete(soPhieu))
                {
                    if (PhieuXuatService.Delete(soPhieu))
                    {
                        grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
                        MessageBox.Show("Hủy phiếu thành công!");
                    }
                    else { MessageBox.Show("Không thể hủy phiếu!"); }
                }
                else { MessageBox.Show("Không thể hủy chi tiết phiếu!"); }
            }
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string soPhieu = grvPhieuXuat.GetRowCellValue(e.RowHandle, "SoPhieuXuat").ToString();
            grcHangHoa.DataSource = ChiTietPhieuXuatService.GetById(soPhieu);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = null;
            Nullable<DateTime> dateStart = null, dateEnd = null;
            if (cedKey.Checked == true)
            {
                if (sctKey.Text != "")
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
                if (dedDateEnd.Text != "")
                {
                    dateEnd = dedDateEnd.DateTime.Date;
                }
            }
            if (key == null && dateStart == null && dateEnd == null)
            {
                grcPhieuXuat.DataSource = PhieuXuatService.LoadDataTable();
            }
            else { grcPhieuXuat.DataSource = PhieuXuatService.Search(key, dateStart, dateEnd); }
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

        private void sctKey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}

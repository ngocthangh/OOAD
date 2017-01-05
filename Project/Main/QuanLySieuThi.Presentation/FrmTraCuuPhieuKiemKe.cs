using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DataBussiness;
using QuanLySieuThi.DataModel;
using DevExpress.XtraEditors;

namespace QuanLySieuThi.Presentation
{
    public partial class FrmTraCuuPhieuKiemKe : Form
    {
        public FrmTraCuuPhieuKiemKe()
        {
            InitializeComponent();
            chbNgay.Checked = false;
            deTuNgay.Enabled = false;
            deDenNgay.Enabled = false;
            chbTuKhoa.Checked = true;
            btnCapNhatCTKK.Enabled = false;
            btnXoaPKK.Enabled = false;
            btnXoaCTKK.Enabled = false;
            btnThemCTKK.Enabled = false;
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = null;
            Nullable<DateTime> dateStart = null, dateEnd = null;
            if (chbTuKhoa.Checked == true)
            {
                if (txtTuKhoa.Text != "")
                {
                    key = txtTuKhoa.Text;
                }
            }
            if (chbNgay.Checked == true)
            {
                if (deTuNgay.Text != "")
                {
                    dateStart = deTuNgay.DateTime.Date;
                }
                if (deDenNgay.Text != "")
                {
                    dateEnd = deDenNgay.DateTime.Date;
                }
            }
            if (key == null && dateStart == null && dateEnd == null)
            {
                grcDSPKK.DataSource = PhieuKiemKeService.LoadDataTable();
            }
            else { grcDSPKK.DataSource = PhieuKiemKeService.Search(key, dateStart, dateEnd); }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void chbNgay_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbNgay.Checked == true)
            {
                deTuNgay.Enabled = true;
                deDenNgay.Enabled = true;
            }
            else
            {
                deTuNgay.Enabled = false;
                deDenNgay.Enabled = false;
            }
        }

        private void chbTuKhoa_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbTuKhoa.Checked == true) txtTuKhoa.Enabled = true;
            else txtTuKhoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            var dtDSPKK = grcDSPKK.DataSource as DataTable;
            var dtCTKK = grcCTKK.DataSource as DataTable;

            if (grvCTKK.RowCount > 0)
            {
                grvCTKK.SelectAll();
                grvCTKK.DeleteSelectedRows();

                if (dtCTKK.GetChanges() == null || ChiTietKiemKeService.SaveChanges(dtCTKK) == false)
                {
                    XtraMessageBox.Show("Xóa thất bại!");
                    return;
                }
            }
            grvDSPKK.DeleteSelectedRows();
            if (PhieuKiemKeService.SaveChanges(dtDSPKK))
            {
                XtraMessageBox.Show("Xóa thành công");
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại");
            }    
            

        }

        private void grvDSPKK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (grvDSPKK.SelectedRowsCount > 0)
            {
                btnXoaPKK.Enabled = true;
                btnThemCTKK.Enabled = true;
            }
            else
            {
                btnXoaPKK.Enabled = false;
                btnThemCTKK.Enabled = false;
            }
            string maPhieu = grvDSPKK.GetRowCellValue(e.RowHandle, "SoPhieuKiemKe").ToString();
            grcCTKK.DataSource = ChiTietKiemKeService.GetById(maPhieu);
        }

        private void btnCapNhatCTHH_Click(object sender, EventArgs e)
        {
            var dt = grcCTKK.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (ChiTietKiemKeService.SaveChanges(dt))
                XtraMessageBox.Show("Cập nhật thành công");
            else XtraMessageBox.Show("Cập nhật thất bại");
            btnCapNhatCTKK.Enabled = false;
        }


        private void grvCTKK_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            btnCapNhatCTKK.Enabled = true;
        }

        private void btnXoaCTKK_Click(object sender, EventArgs e)
        {
            var dt = grcCTKK.DataSource as DataTable;
            grvCTKK.DeleteSelectedRows();
            if (dt == null || dt.GetChanges() == null) return;
            if (ChiTietKiemKeService.SaveChanges(dt))
                XtraMessageBox.Show("Xóa thành công");
            else XtraMessageBox.Show("Xóa thất bại");
        }

        private void grvCTKK_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (grvCTKK.SelectedRowsCount > 0) btnXoaCTKK.Enabled = true;
            else btnXoaCTKK.Enabled = false;
        }
        private void reload(object sender, FormClosingEventArgs e)
        {
            string maPhieu;
            maPhieu = grvDSPKK.GetRowCellValue(grvDSPKK.GetSelectedRows()[0], "SoPhieuKiemKe").ToString();
            frmChiTietKiemKe_Them f = (frmChiTietKiemKe_Them)sender;
            if (f.isDataChanged == true)
            {
                grcCTKK.DataSource = ChiTietKiemKeService.GetById(maPhieu);
            }
        }
        private void btnThemCTKK_Click(object sender, EventArgs e)
        {
            int rowselected=grvDSPKK.GetSelectedRows()[0];
            frmChiTietKiemKe_Them.MaPKK = grvDSPKK.GetRowCellValue(rowselected,"SoPhieuKiemKe").ToString();
            frmChiTietKiemKe_Them f = new frmChiTietKiemKe_Them();
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }
    }
}

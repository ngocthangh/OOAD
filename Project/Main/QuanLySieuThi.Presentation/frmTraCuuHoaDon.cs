using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DataModel;
using QuanLySieuThi.DataBussiness;
using DevExpress.XtraEditors;
namespace QuanLySieuThi.Presentation
{
    public partial class frmTraCuuHoaDon : Form
    {
        public frmTraCuuHoaDon()
        {
            InitializeComponent();
            chbNgay.Checked = false;
            deTuNgay.Enabled = false;
            deDenNgay.Enabled = false;
            chbTuKhoa.Checked = true;
            btnXoaHD.Enabled = false;
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
                grcDSHD.DataSource = HoaDonService.LoadDataTable();
            }
            else { grcDSHD.DataSource = HoaDonService.Search(key, dateStart, dateEnd); }
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

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            var dtDSHD = grcDSHD.DataSource as DataTable;
            var dtCTHD = grcCTHD.DataSource as DataTable;

            if (grvCTHD.RowCount > 0)
            {
                grvCTHD.SelectAll();
                grvCTHD.DeleteSelectedRows();
                if (dtCTHD.GetChanges() == null || ChiTietHoaDonService.SaveChanges(dtCTHD) == false)
                {
                    XtraMessageBox.Show("Xóa thất bại!");
                    return;
                }
            }
            grvDSHD.DeleteSelectedRows();
            if (HoaDonService.SaveChanges(dtDSHD))
            {
                XtraMessageBox.Show("Xóa thành công");
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại");
            }   
            
        }

        private void grvDSHD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (grvDSHD.SelectedRowsCount > 0)
            {
                btnXoaHD.Enabled = true;
            }
            else
            {
                btnXoaHD.Enabled = false;
            }
            string maPhieu = grvDSHD.GetRowCellValue(e.RowHandle, "SoHoaDon").ToString();
            grcCTHD.DataSource = ChiTietHoaDonService.GetById(maPhieu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

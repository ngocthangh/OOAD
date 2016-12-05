using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySieuThi.DataBussiness;

namespace QuanLySieuThi.Presentation
{
    public partial class frmDonViTinhSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinhSearch()
        {
            InitializeComponent();
        }

        private void frmDonViTinhSearch_Load(object sender, EventArgs e)
        {
            grcDonViTinhSearch.DataSource = DonViTinhService.LoadDataTable();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtMaDVTSearch.Text;
            if (key.Trim() != "")
            {
                grcDonViTinhSearch.DataSource = DonViTinhService.Search(key);
            }
            else
            {
                grcDonViTinhSearch.DataSource = DonViTinhService.LoadDataTable();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcDonViTinhSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (DonViTinhService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcDonViTinhSearch.DataSource = DonViTinhService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.GetSelectedRows().Length >= 0)
                if (XtraMessageBox.Show("Bạn có chắc muốn xóa (những) dòng này?", "Xác nhận", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) != DialogResult.Yes) return;
            gridView.DeleteSelectedRows();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmDonViTinh f = new frmDonViTinh();
            f.ShowDialog();
            grcDonViTinhSearch.DataSource = DonViTinhService.LoadDataTable();
        }

        private void txtMaDVTSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtMaDVTSearch.Text;
                if (key.Trim() != "")
                {
                    grcDonViTinhSearch.DataSource = DonViTinhService.Search(key);
                }
                else
                {
                    grcDonViTinhSearch.DataSource = DonViTinhService.LoadDataTable();
                }
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var category = gridView.GetFocusedDataRow();
            if (category.IsNull("TenDVT") || string.IsNullOrWhiteSpace(category["TenDVT"].ToString()))
            {
                e.ErrorText = "Tên đơn vị tính không được phép trống";
                gridView.SetColumnError(gridView.Columns[0], e.ErrorText);
                e.Valid = false;
            }
        }

        private void frmDonViTinhSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcDonViTinhSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (
                XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!DonViTinhService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }
        }
    }
}
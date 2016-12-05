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
using DevExpress.XtraEditors.Controls;

namespace QuanLySieuThi.Presentation
{
    
    public partial class frmLoaiHangSearch : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dtChungLoaiHang;
        public frmLoaiHangSearch()
        {
            InitializeComponent();
        }

        private void grcLoaiHangSearch_Load(object sender, EventArgs e)
        {
            grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
            _dtChungLoaiHang = ChungLoaiService.LoadDataTable();
            LookUpEditChungLoaiHang.DataSource = _dtChungLoaiHang;
            LookUpEditChungLoaiHang.ValueMember = "MaChungLoai";
            LookUpEditChungLoaiHang.DisplayMember = "TenChungLoai";
            LookUpEditChungLoaiHang.Columns.Add(new LookUpColumnInfo("MaChungLoai", "Mã chủng loại hàng"));
            LookUpEditChungLoaiHang.Columns.Add(new LookUpColumnInfo("TenChungLoai", "Tên chủng loại hàng"));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtLoaiHangSearch.Text;
            if (key.Trim() != "")
            {
                grcLoaiHangSearch.DataSource = LoaiHangService.Search(key);
            }
            else
            {
                grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
            }
        }

        private void txtNhaCungCapSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtLoaiHangSearch.Text;
                if (key.Trim() != "")
                {
                    grcLoaiHangSearch.DataSource = LoaiHangService.Search(key);
                }
                else
                {
                    grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLoaiHang f = new frmLoaiHang();
            f.ShowDialog();
            grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcLoaiHangSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (LoaiHangService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
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

        private void frmLoaiHangSearch_Load(object sender, EventArgs e)
        {

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
            var ChungLoaiHang = gridView.GetFocusedDataRow();
            if (ChungLoaiHang.IsNull("TenLoaiHang") || string.IsNullOrWhiteSpace(ChungLoaiHang["TenLoaiHang"].ToString()))
            {
                e.ErrorText = "Tên loại hàng không được phép trống";
                gridView.SetColumnError(gridView.Columns[0], e.ErrorText);
                e.Valid = false;
            }

            if (ChungLoaiHang.IsNull("MaChungLoai") || string.IsNullOrWhiteSpace(ChungLoaiHang["MaChungLoai"].ToString()))
            {
                e.ErrorText = "Tên chủng loại hàng không được phép trống";
                gridView.SetColumnError(gridView.Columns[1], e.ErrorText);
                e.Valid = false;
            }
        }

        private void frmLoaiHangSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcLoaiHangSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (
                XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!LoaiHangService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
﻿using System;
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
    public partial class frmChungLoaiHangSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmChungLoaiHangSearch()
        {
            InitializeComponent();
        }

        private void frmChungLoaiHangSearch_Load(object sender, EventArgs e)
        {
            grcChungLoaiHangSearch.DataSource = ChungLoaiService.LoadDataTable();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Trim() != "")
            {
                grcChungLoaiHangSearch.DataSource = ChungLoaiService.Search(key);
            }
            else
            {
                grcChungLoaiHangSearch.DataSource = ChungLoaiService.LoadDataTable();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcChungLoaiHangSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (ChungLoaiService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcChungLoaiHangSearch.DataSource = ChungLoaiService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChungLoaiHang f = new frmChungLoaiHang();
            f.ShowDialog();
            grcChungLoaiHangSearch.DataSource = ChungLoaiService.LoadDataTable();
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

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtTimKiem.Text;
                if (key.Trim() != "")
                {
                    grcChungLoaiHangSearch.DataSource = ChungLoaiService.Search(key);
                }
                else
                {
                    grcChungLoaiHangSearch.DataSource = ChungLoaiService.LoadDataTable();
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
            var ChungLoaiHang = gridView.GetFocusedDataRow();
            if (ChungLoaiHang.IsNull("TenChungLoai") || string.IsNullOrWhiteSpace(ChungLoaiHang["TenChungLoai"].ToString()))
            {
                e.ErrorText = "Tên chủng loại hàng không được phép trống";
                gridView.SetColumnError(gridView.Columns[0], e.ErrorText);
                e.Valid = false;
            }
        }

        private void frmChungLoaiHangSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcChungLoaiHangSearch.DataSource as DataTable;
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
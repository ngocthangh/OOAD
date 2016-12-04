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
    public partial class frmLoaiHangSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiHangSearch()
        {
            InitializeComponent();
        }

        private void grcLoaiHangSearch_Load(object sender, EventArgs e)
        {
            grcLoaiHangSearch.DataSource = LoaiHangService.LoadDataTable();
            
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
    }
}
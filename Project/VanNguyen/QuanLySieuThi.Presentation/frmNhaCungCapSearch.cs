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
    public partial class frmNhaCungCapSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCapSearch()
        {
            InitializeComponent();
        }

        private void txtNhaCungCapSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtNhaCungCapSearch.Text;
                if (key.Trim() != "")
                {
                    grcNhaCungCapSearch.DataSource = NhaCungCapService.Search(key);
                }
                else
                {
                    grcNhaCungCapSearch.DataSource = NhaCungCapService.LoadDataTable();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtNhaCungCapSearch.Text;
            if (key.Trim() != "")
            {
                grcNhaCungCapSearch.DataSource = NhaCungCapService.Search(key);
            }
            else
            {
                grcNhaCungCapSearch.DataSource = NhaCungCapService.LoadDataTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            grcNhaCungCapSearch.DataSource = NhaCungCapService.LoadDataTable();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcNhaCungCapSearch.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (NhaCungCapService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcNhaCungCapSearch.DataSource = NhaCungCapService.LoadDataTable();
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

        private void frmNhaCungCapSearch_Load(object sender, EventArgs e)
        {
            grcNhaCungCapSearch.DataSource = NhaCungCapService.LoadDataTable();
        }
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QuanLySieuThi.Common;
using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

namespace QuanLySieuThi.Presentation
{
    public partial class frmNhanVien : XtraForm
    {
        private int rowSelected;
        public frmNhanVien()
        {
            InitializeComponent();
            rowSelected = -1;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            var dt = NhanVienService.LoadDataTable();
            grcNhanVien.DataSource = dt;
        }
       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Trim() != "")
            {
                grcNhanVien.DataSource = NhanVienService.Search(key);
            }
            else
            {
                grcNhanVien.DataSource = NhanVienService.LoadDataTable();
            }   
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void grvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }
        private void initSua(int row)
        {
            frmNhanVienThemSua.MaNhanVien = grvNhanVien.GetRowCellValue(row, "MaNhanVien").ToString();
            frmNhanVienThemSua.HoTen = grvNhanVien.GetRowCellValue(row, "HoTen").ToString();
            frmNhanVienThemSua.NgaySinh = (DateTime)grvNhanVien.GetRowCellValue(row, "NgaySinh");
            frmNhanVienThemSua.GioiTinh = grvNhanVien.GetRowCellValue(row, "GioiTinh").ToString();
            frmNhanVienThemSua.CMND = grvNhanVien.GetRowCellValue(row, "CMND").ToString();
            frmNhanVienThemSua.DienThoai = grvNhanVien.GetRowCellValue(row, "DienThoai").ToString();
            frmNhanVienThemSua.NgayVaoLam = (DateTime)grvNhanVien.GetRowCellValue(row, "NgayVaoLam");
            frmNhanVienThemSua.ChucVu = grvNhanVien.GetRowCellValue(row, "TenChucVu").ToString();
            frmNhanVienThemSua.DiaChi = grvNhanVien.GetRowCellValue(row, "DiaChi").ToString();
            frmNhanVienThemSua.TenDangNhap = grvNhanVien.GetRowCellValue(row, "TenDangNhap").ToString();
            frmNhanVienThemSua.MatKhau = ProjectUltil.Decrypt(grvNhanVien.GetRowCellValue(row, "MatKhau").ToString());
            frmNhanVienThemSua f = new frmNhanVienThemSua(1);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }
        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                initSua(info.RowHandle);
            }
        }

        private void reload(object sender, FormClosingEventArgs e)
        {
            frmNhanVienThemSua f = (frmNhanVienThemSua)sender;
            if (f.isDataChanged == true)
            {
                grcNhanVien.DataSource = NhanVienService.LoadDataTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVienThemSua f = new frmNhanVienThemSua(0);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rowSelected = grvNhanVien.GetSelectedRows()[0];
            if(rowSelected >= 0)
            {
                if(MessageBox.Show("Xác nhận xóa nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (NhanVienService.Delete(grvNhanVien.GetRowCellValue(rowSelected, "MaNhanVien").ToString()))
                    {
                        grcNhanVien.DataSource = NhanVienService.LoadDataTable();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else{ MessageBox.Show("Không thể xóa vì nhân viên này còn thông tin liên quan!"); }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!");
            }
        }

        private void grvNhanVien_RowClick(object sender, RowClickEventArgs e)
        {
            rowSelected = e.RowHandle;
            //MessageBox.Show("" + rowSelected);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            rowSelected = grvNhanVien.GetSelectedRows()[0];
            if (rowSelected >= 0)
            {
                initSua(rowSelected);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!");
            }
        }
    }
}

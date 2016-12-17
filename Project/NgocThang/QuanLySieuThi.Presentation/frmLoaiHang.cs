using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frmLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dtChungLoaiHang;     //Biến lấy danh sách chủng loại hàng
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        //Load dữ liệu lên Gridview
        private void grcLoaiHang_Load(object sender, EventArgs e)
        {
            grcLoaiHang.DataSource = LoaiHangService.LoadDataTable();
            _dtChungLoaiHang = ChungLoaiService.LoadDataTable();
            LookUpEditChungLoaiHang.DataSource = _dtChungLoaiHang;
            LookUpEditChungLoaiHang.ValueMember = "MaChungLoai";
            LookUpEditChungLoaiHang.DisplayMember = "TenChungLoai";
            LookUpEditChungLoaiHang.Columns.Add(new LookUpColumnInfo("MaChungLoai", "Mã chủng loại hàng"));
            LookUpEditChungLoaiHang.Columns.Add(new LookUpColumnInfo("TenChungLoai", "Tên chủng loại hàng"));
        }

        //Button Luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcLoaiHang.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;

            if (LoaiHangService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcLoaiHang.DataSource = LoaiHangService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (
                XtraMessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            gridView.DeleteSelectedRows();
        }

        //Button Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hàm tạo số thứ tự của Gridview
        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {

                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        //Hàm kiểm tra giá trị nhập của gridview
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

        private void frmLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcLoaiHang.DataSource as DataTable;
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

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {

        }
    }
}
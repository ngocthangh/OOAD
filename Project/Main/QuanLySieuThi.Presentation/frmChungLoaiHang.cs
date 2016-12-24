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
    public partial class frmChungLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public frmChungLoaiHang()
        {
            InitializeComponent();
        }

        //Hàm load dữ liệu
        private void frmChungLoaiHang_Load(object sender, EventArgs e)
        {
            grcChungLoai.DataSource = ChungLoaiService.LoadDataTable();
            gridview.Columns[0].Visible = false;
            gridview.Columns[1].Caption = @"Tên Chủng Loại Hàng";
        }

        private void ChungLoaiHang_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        //Hàm xác nhận giá trị của rows
        private void ChungLoaiHang_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var ChungLoaiHang = gridview.GetFocusedDataRow();
            if (ChungLoaiHang.IsNull("TenChungLoai") || string.IsNullOrWhiteSpace(ChungLoaiHang["TenChungLoai"].ToString()))
            {
                e.ErrorText = "Tên chủng loại hàng không được phép trống";
                gridview.SetColumnError(gridview.Columns[1], e.ErrorText);
                e.Valid = false;
            }
        }

        //Hàm tự động sinh số thứ tự
        private void ChungLoaiHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //Button Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcChungLoai.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (ChungLoaiService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcChungLoai.DataSource = ChungLoaiService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridview.GetSelectedRows().Length >= 0)
                if (XtraMessageBox.Show("Bạn có chắc muốn xóa (những) dòng này?", "Xác nhận", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) != DialogResult.Yes) return;
            gridview.DeleteSelectedRows();
        }

        //Butoon Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChungLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcChungLoai.DataSource as DataTable;
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
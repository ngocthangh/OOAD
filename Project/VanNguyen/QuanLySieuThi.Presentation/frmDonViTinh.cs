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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        //Hàm load dữ liệu
        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            grcDonViTinh.DataSource = DonViTinhService.LoadDataTable();
            gridView.Columns[0].Visible = false;
            gridView.Columns[1].Caption = @"Tên đơn vị tính";
        }

        //Hàm xác nhận giá trị của rows
        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var category = gridView.GetFocusedDataRow();
            if (category.IsNull("TenDVT") || string.IsNullOrWhiteSpace(category["TenDVT"].ToString()))
            {
                e.ErrorText = "Tên đơn vị tính không được phép trống";
                gridView.SetColumnError(gridView.Columns[1], e.ErrorText);
                e.Valid = false;
            }
        }

        //Button Lưu Đơn Vị Tính Mới
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcDonViTinh.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (DonViTinhService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcDonViTinh.DataSource = DonViTinhService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm xóa 1 dòng trong GridView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.GetSelectedRows().Length >= 0)
                if (XtraMessageBox.Show("Bạn có chắc muốn xóa (những) dòng này?", "Xác nhận", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) != DialogResult.Yes) return;
            gridView.DeleteSelectedRows();

        }

        //Button Đóng của sổ hiển thị Form Đơn Vị Tính
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        //Hàm tự sinh cột số thứ tự
        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

       
    }
}
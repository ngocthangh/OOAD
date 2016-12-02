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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dtLoaiHang;
        private DataTable _dtDVT;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void grcHangHoa_Load(object sender, EventArgs e)
        {
            grcHangHoa.DataSource = HangHoaService.LoadDataTable();

            _dtLoaiHang = LoaiHangService.LoadDataTable();
            _dtDVT = DonViTinhService.LoadDataTable();

            LookUpEditDVT.DataSource = _dtDVT;
            LookUpEditLoaiHang.DataSource = _dtLoaiHang;

            LookUpEditLoaiHang.ValueMember = "MaLoaiHang";
            LookUpEditLoaiHang.DisplayMember = "TenLoaiHang";
            LookUpEditLoaiHang.Columns.Add(new LookUpColumnInfo("MaLoaiHang", "Mã loại hàng"));
            LookUpEditLoaiHang.Columns.Add(new LookUpColumnInfo("TenLoaiHang", "Tên loại hàng"));

            LookUpEditDVT.ValueMember = "MaDVT";
            LookUpEditDVT.DisplayMember = "TenDVT";
            LookUpEditDVT.Columns.Add(new LookUpColumnInfo("MaDVT", "Mã Đơn Vị Tính"));
            LookUpEditDVT.Columns.Add(new LookUpColumnInfo("TenDVT", "Tên Đơn Vị Tính"));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = grcHangHoa.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;

            if (HangHoaService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcHangHoa.DataSource = HangHoaService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (
                XtraMessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            gridView.DeleteSelectedRows();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var HangHoa = gridView.GetFocusedDataRow();
            if (HangHoa.IsNull("TenHangHoa") || string.IsNullOrWhiteSpace(HangHoa["TenHangHoa"].ToString()))
            {
                e.ErrorText = "Tên hàng hóa không được phép trống";
                gridView.SetColumnError(gridView.Columns[0], e.ErrorText);
                e.Valid = false;
            }

            if (HangHoa.IsNull("GiaMua") || string.IsNullOrWhiteSpace(HangHoa["GiaMua"].ToString()))
            {
                e.ErrorText = "Giá Mua không được phép trống";
                gridView.SetColumnError(gridView.Columns[1], e.ErrorText);
                e.Valid = false;
            }

            if (HangHoa.IsNull("GiaBan") || string.IsNullOrWhiteSpace(HangHoa["GiaBan"].ToString()))
            {
                e.ErrorText = "Giá Bán không được phép trống";
                gridView.SetColumnError(gridView.Columns[2], e.ErrorText);
                e.Valid = false;
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void frmHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcHangHoa.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (
                XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!HangHoaService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
    }
}
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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace QuanLySieuThi.Presentation
{
    public partial class frmHangHoaSearch : DevExpress.XtraEditors.XtraForm
    {
        private int rowSelected;
        private DataTable _dtDonViTinh;
        private DataTable _dtLoaiHang;

        public frmHangHoaSearch()
        {
            InitializeComponent();
            rowSelected = -1;
        }


        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text; 
            if (key.Trim() != "")
            {
                grcHanghoaSearch.DataSource = HangHoaService.Search(key);
            }
            else
            {
                grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
            }
        }

        private void frmHangHoaSearch_Load(object sender, EventArgs e)
        {
            grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();

            _dtLoaiHang = LoaiHangService.LoadDataTable();
            _dtDonViTinh = DonViTinhService.LoadDataTable();

            LookUpEditLoaiHang.DataSource = _dtLoaiHang;
            LookUpEditLoaiHang.ValueMember = "MaLoaiHang";
            LookUpEditLoaiHang.DisplayMember = "TenLoaiHang";
            LookUpEditLoaiHang.Columns.Add(new LookUpColumnInfo("MaLoaiHang", "Mã Loại Hàng"));
            LookUpEditLoaiHang.Columns.Add(new LookUpColumnInfo("TenLoaiHang", "Tên Loại Hàng"));

            LookUpEditDonViTinh.DataSource = _dtDonViTinh;
            LookUpEditDonViTinh.ValueMember = "MaDVT";
            LookUpEditDonViTinh.DisplayMember = "TenDVT";
            LookUpEditDonViTinh.Columns.Add(new LookUpColumnInfo("MaDVT", "Mã Đơn Vị Tính"));
            LookUpEditDonViTinh.Columns.Add(new LookUpColumnInfo("TenDVT", "Tên Đơn Vị Tính"));
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtTimKiem.Text;
                if (key.Trim() != "")
                {
                    grcHanghoaSearch.DataSource = HangHoaService.Search(key);
                }
                else
                {
                    grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
                }
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
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

        private void initSua(int row)
        {
            frmHangHoa.MaHangHoa = gridView.GetRowCellValue(row, "MaHangHoa").ToString();
            frmHangHoa.TenHangHoa = gridView.GetRowCellValue(row, "TenHangHoa").ToString();
            frmHangHoa.GiaMua =(Decimal)gridView.GetRowCellValue(row, "GiaMua");
            frmHangHoa.GiaBan = (Decimal)gridView.GetRowCellValue(row, "GiaBan");
            frmHangHoa.SoLuongBan = (int)gridView.GetRowCellValue(row, "SoLuongBan");
            frmHangHoa.SoLuongNhap = (int)gridView.GetRowCellValue(row, "SoLuongNhap");
            frmHangHoa.VAT = (int)gridView.GetRowCellValue(row, "VAT");
            frmHangHoa.NgayNhap = (DateTime)gridView.GetRowCellValue(row, "NgayNhap");
            frmHangHoa.NgaySanXuat = (DateTime)gridView.GetRowCellValue(row, "NgaySanXuat");
            frmHangHoa.HanSuDung = (DateTime)gridView.GetRowCellValue(row, "HanSuDung");
            frmHangHoa.LoaiHang = (int)gridView.GetRowCellValue(row, "MaLoaiHang");
            frmHangHoa.DonViTinh = (int)gridView.GetRowCellValue(row, "MaDVT");

            frmHangHoa f = new frmHangHoa(1);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }

        private void reload(object sender, FormClosingEventArgs e)
        {
            frmHangHoa f = (frmHangHoa)sender;
            if (f.isDataChanged == true)
            {
                grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa(0);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            rowSelected = gridView.GetSelectedRows()[0];
            if (rowSelected >= 0)
            {
                initSua(rowSelected);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            rowSelected = gridView.GetSelectedRows()[0];
            if (rowSelected >= 0)
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (HangHoaService.Delete(gridView.GetRowCellValue(rowSelected, "MaHangHoa").ToString()))
                    {
                        grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else { MessageBox.Show("Không thể xóa vì nhân viên này còn thông tin liên quan!"); }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!");
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            rowSelected = e.RowHandle;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
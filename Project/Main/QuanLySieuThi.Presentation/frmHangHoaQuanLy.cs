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
    public partial class frmHangHoaQuanLy : DevExpress.XtraEditors.XtraForm
    {
        private int rowSelected;
        DataTable dtLoaiHang;

        public frmHangHoaQuanLy()
        {
            InitializeComponent();
            rowSelected = -1;
            dtLoaiHang = new DataTable();
            dtLoaiHang.Columns.Add();
            dtLoaiHang.Columns.Add();
            dtLoaiHang.Columns[0].ColumnName = "MaLoaiHang";
            dtLoaiHang.Columns[1].ColumnName = "TenLoaiHang";
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
            lbcLoaiHang.ValueMember = "MaLoaiHang";
            lbcLoaiHang.DisplayMember = "TenLoaiHang";
            
            lueChungLoai.Properties.ValueMember = "MaChungLoai";
            lueChungLoai.Properties.DisplayMember = "TenChungLoai";
            lueChungLoai.Properties.Columns.Add(new LookUpColumnInfo("TenChungLoai", "Chủng Loại"));
            lueChungLoai.Properties.DataSource = ChungLoaiService.LoadDataTable();

            DataTable temp = LoaiHangService.LoadDataTable();
            DataRow dr = dtLoaiHang.NewRow();
            dr[0] = 0;
            dr[1] = "Tất cả";
            dtLoaiHang.Rows.Add(dr);
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr1 = dtLoaiHang.NewRow();
                dr1[0] = temp.Rows[i].Field<int>("MaLoaiHang");
                dr1[1] = temp.Rows[i].Field<string>("TenLoaiHang");
                dtLoaiHang.Rows.Add(dr1);
            }
            lbcLoaiHang.DataSource = dtLoaiHang;

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
            frmHangHoaThemSua.MaHangHoa = gridView.GetRowCellValue(row, "MaHangHoa").ToString();
            frmHangHoaThemSua.TenHangHoa = gridView.GetRowCellValue(row, "TenHangHoa").ToString();
            frmHangHoaThemSua.GiaNhap =(Decimal)gridView.GetRowCellValue(row, "GiaNhap");
            frmHangHoaThemSua.GiaBan = (Decimal)gridView.GetRowCellValue(row, "GiaBan");
            frmHangHoaThemSua.LoaiHang = (int)gridView.GetRowCellValue(row, "MaLoaiHang");
            frmHangHoaThemSua.DonViTinh = (int)gridView.GetRowCellValue(row, "MaDVT");

            frmHangHoaThemSua f = new frmHangHoaThemSua(1);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }

        private void reload(object sender, FormClosingEventArgs e)
        {
            frmHangHoaThemSua f = (frmHangHoaThemSua)sender;
            if (f.isDataChanged == true)
            {
                grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoaThemSua f = new frmHangHoaThemSua(0);
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

        private void lueChungLoai_TextChanged(object sender, EventArgs e)
        {
            int maChungLoai = -1;
            DataRowView row = lueChungLoai.Properties.GetDataSourceRowByKeyValue(lueChungLoai.EditValue) as DataRowView;
            try
            {
                maChungLoai = int.Parse(row.Row["MaChungLoai"].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy mã!");
            }
            if(maChungLoai != -1)
            {
                DataTable temp = LoaiHangService.GetByChungLoai(maChungLoai);
                if(temp.Rows.Count > 0)
                {
                    dtLoaiHang.Rows.Clear();
                    DataRow dr = dtLoaiHang.NewRow();
                    dr[0] = 0;
                    dr[1] = "Tất cả";
                    dtLoaiHang.Rows.Add(dr);
                    for (int i = 0; i < temp.Rows.Count; i++)
                    {
                        DataRow dr1 = dtLoaiHang.NewRow();
                        dr1[0] = temp.Rows[i].Field<int>("MaLoaiHang");
                        dr1[1] = temp.Rows[i].Field<string>("TenLoaiHang");
                        dtLoaiHang.Rows.Add(dr1);
                    }
                    lbcLoaiHang.DataSource = dtLoaiHang;
                }
                else
                {
                    lbcLoaiHang.DataSource = temp;
                }
            }
        }

        private void lbcLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbcLoaiHang.SelectedValue != null)
            {
                if (lbcLoaiHang.SelectedValue.ToString() == "0")
                {
                    grcHanghoaSearch.DataSource = HangHoaService.LoadDataTable();
                }
                else
                {
                    int maLoaiHang = int.Parse(lbcLoaiHang.SelectedValue.ToString());
                    grcHanghoaSearch.DataSource = HangHoaService.GetByLoaiHang(maLoaiHang);
                }
            }
            else
            {

            }
        }
    }
}
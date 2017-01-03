using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmHangHoaSearch : Form
    {
        public static string maHangDaChon;
        private const int MODE_NORMAL = 1;
        private const int MODE_SELECT = 2;
        private int Mode;
        public frmHangHoaSearch()
        {
            InitializeComponent();
            Mode = MODE_NORMAL;
            btnChon.Visible = false;
        }
        public frmHangHoaSearch(int mode)
        {
            InitializeComponent();
            Mode = MODE_SELECT;
            maHangDaChon = null;
            btnChon.Visible = true;
        }

        private void HangHoaSearch_Load(object sender, EventArgs e)
        {
            lueChungLoai.Properties.ValueMember = "MaChungLoai";
            lueChungLoai.Properties.DisplayMember = "TenChungLoai";
            lueChungLoai.Properties.Columns.Add(new LookUpColumnInfo("TenChungLoai", "Tên chủng loại hàng"));
            lueChungLoai.Properties.DataSource = ChungLoaiService.LoadDataTable();
            lueLoaiHang.Properties.ValueMember = "MaLoaiHang";
            lueLoaiHang.Properties.DisplayMember = "TenLoaiHang";
            lueLoaiHang.Properties.Columns.Add(new LookUpColumnInfo("TenLoaiHang", "Tên Loại Hàng"));
            lueLoaiHang.Properties.DataSource = LoaiHangService.LoadDataTable();
            grcHangHoa.DataSource = HangHoaService.LoadDataTable();
            if(Mode == MODE_NORMAL)
            {
                btnChon.Visible = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = null;
            Nullable<int> loaiHang = null, slTonTu = null, slTonDen = null, slQuayTu = null, slQuayDen = null;
            if (cheKey.Checked == true)
            {
                if (sctKey.Text != "")
                {
                    key = sctKey.Text;
                }
            }
            if(cheLoai.Checked == true)
            {
                if(lueLoaiHang.Text.Trim() != "")
                {
                    DataRowView row = lueLoaiHang.Properties.GetDataSourceRowByKeyValue(lueLoaiHang.EditValue) as DataRowView;
                    try
                    {
                        loaiHang = int.Parse(row.Row["MaLoaiHang"].ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể lấy mã loại!");
                        return;
                    }
                }
            }
            if (cheSLTon.Checked == true)
            {
                if (cbbSLTonTu.Text != "")
                {
                    try
                    {
                        slTonTu = int.Parse(cbbSLTonTu.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (cbbSLTonDen.Text != "")
                {
                    try
                    {
                        slTonDen = int.Parse(cbbSLTonDen.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            if (cheSLQuay.Checked == true)
            {
                if (cbbSLQuayTu.Text != "")
                {
                    try
                    {
                        slQuayTu = int.Parse(cbbSLQuayTu.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (cbbSLQuayDen.Text != "")
                {
                    try
                    {
                        slQuayDen = int.Parse(cbbSLQuayDen.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            if (key == null && loaiHang == null && slTonTu == null && slTonDen == null && slQuayTu == null && slQuayDen == null)
            {
                grcHangHoa.DataSource = HangHoaService.LoadDataTable();
            }
            else { grcHangHoa.DataSource = HangHoaService.Search1(key, loaiHang, slTonTu, slTonDen, slQuayTu, slQuayDen); }
        }

        private void cheKey_CheckedChanged(object sender, EventArgs e)
        {
            sctKey.Enabled = cheKey.Checked;
        }

        private void cheLoai_CheckedChanged(object sender, EventArgs e)
        {
            lueChungLoai.Enabled = cheLoai.Checked;
            lueLoaiHang.Enabled = cheLoai.Checked;

        }

        private void cheSoLuongTon_CheckedChanged(object sender, EventArgs e)
        {
            cbbSLTonTu.Enabled = cheSLTon.Checked; 
            cbbSLTonDen.Enabled = cheSLTon.Checked;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cheSLQuay_CheckedChanged(object sender, EventArgs e)
        {
            cbbSLQuayTu.Enabled = cheSLQuay.Checked;
            cbbSLQuayDen.Enabled = cheSLQuay.Checked;
        }

        private void sctKey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void lueChungLoai_TextChanged(object sender, EventArgs e)
        {
            DataRowView row = lueChungLoai.Properties.GetDataSourceRowByKeyValue(lueChungLoai.EditValue) as DataRowView;
            try
            {
                int machungloai = int.Parse(row.Row["MaChungLoai"].ToString());
                lueLoaiHang.Properties.DataSource = LoaiHangService.GetByChungLoai(machungloai);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy mã chủng loại!");
                return;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
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
                if (Mode == MODE_SELECT)
                {
                    maHangDaChon = grvHangHoa.GetRowCellValue(info.RowHandle, "MaHangHoa").ToString();
                    this.Close();
                }
                else {
                    initSua(info.RowHandle);
                }
            }
        }
        private void initSua(int row)
        {
            frmHangHoaThemSua.MaHangHoa = grvHangHoa.GetRowCellValue(row, "MaHangHoa").ToString();
            frmHangHoaThemSua.TenHangHoa = grvHangHoa.GetRowCellValue(row, "TenHangHoa").ToString();
            frmHangHoaThemSua.GiaNhap = (Decimal)grvHangHoa.GetRowCellValue(row, "GiaNhap");
            frmHangHoaThemSua.GiaBan = (Decimal)grvHangHoa.GetRowCellValue(row, "GiaBan");
            frmHangHoaThemSua.LoaiHang = (int)grvHangHoa.GetRowCellValue(row, "MaLoaiHang");
            frmHangHoaThemSua.DonViTinh = (int)grvHangHoa.GetRowCellValue(row, "MaDVT");

            frmHangHoaThemSua f = new frmHangHoaThemSua(1);
            f.FormClosing += new FormClosingEventHandler(reload);
            f.ShowDialog();
        }

        private void reload(object sender, FormClosingEventArgs e)
        {
            frmHangHoaThemSua f = (frmHangHoaThemSua)sender;
            if (f.isDataChanged == true)
            {
                grcHangHoa.DataSource = HangHoaService.LoadDataTable();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            maHangDaChon = grvHangHoa.GetRowCellValue(grvHangHoa.FocusedRowHandle, "MaHangHoa").ToString();
            this.Close();
        }
    }
}

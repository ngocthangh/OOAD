using DevExpress.XtraEditors;
using QuanLySieuThi.DataBussiness;
using QuanLySieuThi.DataModel;
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
    public partial class frmPhieuXuatThemSua : XtraForm
    {
        private int index;
        DataTable dtHangHoa;
        private decimal TongTien;
        public bool isDataChanged;
        public frmPhieuXuatThemSua()
        {
            InitializeComponent();
            index = 0;
            dtHangHoa = new DataTable();
            dtHangHoa.Columns.Add("MaHangHoa");
            dtHangHoa.Columns.Add("STT");
            dtHangHoa.Columns.Add("HangHoa");
            dtHangHoa.Columns.Add("DonGiaXuat");
            dtHangHoa.Columns.Add("SoLuong");
            dtHangHoa.Columns.Add("ThanhTien");
            TongTien = 0;
            isDataChanged = false;
        }

        private void frmPhieuXuatThemSua_Load(object sender, EventArgs e)
        {
            tedSoPhieu.Text = PhieuXuatService.AutoGenerateId();
            tedNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal dongia;
            int soluong;
            if (lueHangHoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hàng hóa nhập!");
                lueHangHoa.Focus();
                return;
            }
            if (speSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                speSoLuong.Focus();
                return;
            }
            try
            {
                soluong = int.Parse(speSoLuong.EditValue.ToString());
                if (soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0\nVui lòng nhập lại!");
                    speSoLuong.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng phải là số\nVui lòng nhập lại!");
                speSoLuong.Focus();
                return;
            }
            DataRowView row = lueHangHoa.Properties.GetDataSourceRowByKeyValue(lueHangHoa.EditValue) as DataRowView;
            try
            {
                dongia = Decimal.Parse(row.Row["GiaBan"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy đơn giá!");
                return;
            }
            bool check = false;
            if (grvHangHoa.RowCount > 0)
            {
                for (int i = 0; i < grvHangHoa.RowCount; i++)
                {
                    if (lueHangHoa.EditValue.ToString() == grvHangHoa.GetRowCellValue(i, "MaHangHoa").ToString())
                    {
                        int sl = int.Parse(grvHangHoa.GetRowCellValue(i, "SoLuong").ToString());
                        grvHangHoa.SetRowCellValue(i, "SoLuong", (sl + soluong));
                        check = true;
                    }
                }
            }
            if (!check)
            {
                DataRow dr = dtHangHoa.NewRow();
                dr[0] = lueHangHoa.EditValue;
                dr[1] = grvHangHoa.RowCount + 1;
                dr[2] = lueHangHoa.Text;
                dr[3] = dongia;
                dr[4] = soluong;
                dr[5] = (dongia * soluong);
                dtHangHoa.Rows.Add(dr);
                grcHangHoa.DataSource = dtHangHoa;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grvHangHoa.DeleteRow(grvHangHoa.FocusedRowHandle);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cbbNoiDungXuat.SelectedText == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung xuất");
                cbbNoiDungXuat.Focus();
                return;
            }
            if (grvHangHoa.RowCount <= 0)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa xuất");
            }
            else
            {
                PhieuXuat px = new PhieuXuat();
                px.MaNhanVien = "NV0001";
                px.SoPhieuXuat = tedSoPhieu.Text;
                px.NgayLap = DateTime.Now;
                px.TongTien = TongTien;
                px.NoiDungXuat = cbbNoiDungXuat.SelectedText;
                if (PhieuXuatService.Insert(px))
                {
                    int fail = 0;
                    for (int i = 0; i < grvHangHoa.RowCount; i++)
                    {
                        ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                        ctpx.SoPhieuXuat = tedSoPhieu.Text;
                        ctpx.MaHangHoa = grvHangHoa.GetRowCellValue(i, "MaHangHoa").ToString();
                        ctpx.SoLuong = int.Parse(grvHangHoa.GetRowCellValue(i, "SoLuong").ToString());
                        ctpx.DonGiaXuat = decimal.Parse(grvHangHoa.GetRowCellValue(i, "DonGiaXuat").ToString());
                        ctpx.ThanhTien = decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
                        if (!ChiTietPhieuXuatService.Insert(ctpx))
                        { 
                            fail++;
                            if (i > 0)
                            {
                                ChiTietPhieuNhapService.Delete(tedSoPhieu.Text);
                            }
                            if (PhieuNhapService.Delete(tedSoPhieu.Text))
                            { MessageBox.Show("Roll back thành công!"); }
                            else { MessageBox.Show("Roll back không thành công!"); }
                            break;
                        }
                    }
                    if (fail > 0)
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }
                    else 
                    {
                        isDataChanged = true;
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                else
                {
                    if (MessageBox.Show("Thông báo", "Phiếu xuất này đã được lưu, bạn muốn tạo phiếu mới?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        tedSoPhieu.Text = PhieuNhapService.AutoGenerateId();
                    }
                }

            }
        }

        private void grvHangHoa_RowCountChanged(object sender, EventArgs e)
        {
            TongTien = 0;
            for (int i = 0; i < grvHangHoa.RowCount; i++)
            {
                TongTien += Decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
            }
            tedTongTien.Text = TongTien.ToString();
            if (grvHangHoa.RowCount > 0)
            {
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void grvHangHoa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "SoLuong")
            {
                TongTien = 0;
                int sl = int.Parse(grvHangHoa.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
                decimal dg = decimal.Parse(grvHangHoa.GetRowCellValue(e.RowHandle, "DonGiaXuat").ToString());
                grvHangHoa.SetRowCellValue(e.RowHandle, "ThanhTien", (sl * dg));
                for (int i = 0; i < grvHangHoa.RowCount; i++)
                {
                    TongTien += Decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
                }
                tedTongTien.Text = TongTien.ToString();
            }
        }
    }
}

using DevExpress.XtraEditors;
using QuanLySieuThi.Common;
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
        DataTable dtHangHoa;
        private decimal TongTien;
        public bool isDataChanged;
        public bool isSaved;
        public frmPhieuXuatThemSua()
        {
            InitializeComponent();
            dtHangHoa = new DataTable();
            dtHangHoa.Columns.Add("MaHangHoa");
            dtHangHoa.Columns.Add("STT");
            dtHangHoa.Columns.Add("HangHoa");
            dtHangHoa.Columns.Add("DonGiaXuat");
            dtHangHoa.Columns.Add("SoLuong");
            dtHangHoa.Columns.Add("ThanhTien");
            TongTien = 0;
            isDataChanged = false;
            isSaved = false;
        }

        private void frmPhieuXuatThemSua_Load(object sender, EventArgs e)
        {
            tedSoPhieu.Text = PhieuXuatService.AutoGenerateId();
            tedNhanVienLap.Text = (ProjectUltil.HoTenNhanVien != "") ? ProjectUltil.HoTenNhanVien : "";
            tedNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tedNgayLap.ReadOnly = true;
            tedSoPhieu.ReadOnly = true;
            tedNhanVienLap.ReadOnly = true;
            tedTongTien.ReadOnly = true;
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHangHoa", 50, "Mã Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHangHoa", 100, "Tên Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoLuongTon", 50, "Số Lượng Tồn"));
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal dongia;
            int soluong;
            if (cbbNoiDungXuat.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung xuất!");
                cbbNoiDungXuat.Focus();
                return;
            }
            if (lueHangHoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hàng hóa xuất!");
                lueHangHoa.Focus();
                return;
            }
            if (speSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                speSoLuong.Focus();
                return;
            }
            DataRowView row = lueHangHoa.Properties.GetDataSourceRowByKeyValue(lueHangHoa.EditValue) as DataRowView;
            try
            {
                soluong = int.Parse(speSoLuong.EditValue.ToString());
                if (soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0\nVui lòng nhập lại!");
                    speSoLuong.Focus();
                    return;
                }
                int soluongton = int.Parse(row.Row["SoLuongTon"].ToString());
                if(soluong > soluongton)
                {
                    MessageBox.Show("Số lượng xuất phải nhỏ hơn hoặc bằng số lượng tồn hiện tại là " + soluongton);
                    speSoLuong.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng phải là số\nVui lòng nhập lại!");
                speSoLuong.Focus();
                return;
            }
            
            try
            {
                if(cbbNoiDungXuat.SelectedIndex == 0)
                {
                    dongia = Decimal.Parse(row.Row["GiaBan"].ToString());
                }
                else
                {
                    dongia = Decimal.Parse(row.Row["GiaNhap"].ToString());
                }
                
            }
            catch (Exception)
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
            if (cbbNoiDungXuat.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nội dung xuất!");
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
                px.MaNhanVien = (ProjectUltil.MaNhanVien != "") ? ProjectUltil.MaNhanVien : "NV0001";
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
                        if (ChiTietPhieuXuatService.Insert(ctpx))
                        {
                            if (cbbNoiDungXuat.SelectedIndex == 0)
                            {
                                if (!HangHoaService.XuatQuay(ctpx.MaHangHoa, ctpx.SoLuong))
                                {
                                    MessageBox.Show("Không thể cập nhật số lượng hàng hóa!");
                                }
                            }
                            else
                            {
                                if (!HangHoaService.XuatTra(ctpx.MaHangHoa, ctpx.SoLuong))
                                {
                                    MessageBox.Show("Không thể cập nhật số lượng hàng hóa!");
                                }
                            }
                        }
                        else
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
                        isSaved = true;
                        isDataChanged = true;
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                else
                {
                    if (MessageBox.Show("Thông báo", "Phiếu xuất này đã được lưu, bạn muốn tạo phiếu mới?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        btnNhapLai.PerformClick();
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
                if (sl < 1)
                {
                    sl = 1;
                    grvHangHoa.SetRowCellValue(e.RowHandle, "SoLuong", sl);
                }
                decimal dg = decimal.Parse(grvHangHoa.GetRowCellValue(e.RowHandle, "DonGiaXuat").ToString());
                grvHangHoa.SetRowCellValue(e.RowHandle, "ThanhTien", (sl * dg));
                for (int i = 0; i < grvHangHoa.RowCount; i++)
                {
                    TongTien += Decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
                }
                tedTongTien.Text = TongTien.ToString();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận tạo phiếu mới?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tedSoPhieu.Text = PhieuXuatService.AutoGenerateId();
                    while(grvHangHoa.RowCount > 0)
                    { grvHangHoa.DeleteRow(0); }
                    tedTongTien.Text = "0";
                    lueHangHoa.Text = "";
                    cbbNoiDungXuat.Text = "";
                    speSoLuong.Text = "0";
                }
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

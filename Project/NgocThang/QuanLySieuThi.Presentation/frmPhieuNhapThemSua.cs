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
    public partial class frmPhieuNhapThemSua : XtraForm
    {
        DataTable dtHangHoa;
        private decimal TongTien;
        public bool isDataChanged;
        public bool isSaved;
        public frmPhieuNhapThemSua()
        {
            InitializeComponent();
            dtHangHoa = new DataTable();
            dtHangHoa.Columns.Add("MaHangHoa");
            dtHangHoa.Columns.Add("MaNhaCungCap");
            dtHangHoa.Columns.Add("HangHoa");
            dtHangHoa.Columns.Add("NhaCungCap");
            dtHangHoa.Columns.Add("HanSuDung");
            dtHangHoa.Columns.Add("DonGiaNhap");
            dtHangHoa.Columns.Add("SoLuong");
            dtHangHoa.Columns.Add("ThanhTien");
            TongTien = 0;
            isDataChanged = false;
            isSaved = false;
        }
        
        private void frmPhieuNhapThemSua_Load(object sender, EventArgs e)
        {
            tedSoPhieuNhap.Text = PhieuNhapService.AutoGenerateId();
            tedNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHangHoa", 50, "Mã Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHangHoa", 100, "Tên Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoLuongNhap", 50, "Số Lượng Tồn"));
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
            lueNhaCungCap.Properties.ValueMember = "MaNhaCungCap";
            lueNhaCungCap.Properties.DisplayMember = "TenNhaCungCap";
            lueNhaCungCap.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", 100, "Tên NCC"));
            lueNhaCungCap.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiaChi", 100, "Địa Chỉ"));
            lueNhaCungCap.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DienThoai", 100, "Điện Thoại"));
            lueNhaCungCap.Properties.DataSource = NhaCungCapService.LoadDataTable();
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
            if (lueNhaCungCap.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                lueHangHoa.Focus();
                return;
            }
            if (dedHanSuDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hạn sử dụng!");
                dedHanSuDung.Focus();
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
                if(soluong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0\nVui lòng nhập lại!");
                    speSoLuong.Focus();
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Số lượng phải là số\nVui lòng nhập lại!");
                speSoLuong.Focus();
                return;
            }
            DataRowView row = lueHangHoa.Properties.GetDataSourceRowByKeyValue(lueHangHoa.EditValue) as DataRowView;
            try
            {
                dongia = Decimal.Parse(row.Row["GiaMua"].ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể lấy đơn giá!");
                return;
            }
            bool check = false;
            if(grvHangHoa.RowCount > 0)
            {
                for (int i = 0; i < grvHangHoa.RowCount; i++)
                {
                    if(lueHangHoa.EditValue.ToString() == grvHangHoa.GetRowCellValue(i, "MaHangHoa").ToString())
                    {
                        if(lueNhaCungCap.EditValue.ToString() == grvHangHoa.GetRowCellValue(i, "MaNhaCungCap").ToString())
                        {
                            int sl = int.Parse(grvHangHoa.GetRowCellValue(i, "SoLuong").ToString());
                            grvHangHoa.SetRowCellValue(i, "SoLuong", (sl + soluong));
                            check = true;
                        }
                    }
                }
            }
            if(!check)
            {
                DataRow dr = dtHangHoa.NewRow();
                dr[0] = lueHangHoa.EditValue;
                dr[1] = lueNhaCungCap.EditValue;
                dr[2] = lueHangHoa.Text;
                dr[3] = lueNhaCungCap.Text;
                dr[4] = dedHanSuDung.DateTime.Date.ToString("dd/MM/yyyy");
                dr[5] = dongia;
                dr[6] = soluong;
                dr[7] = (dongia * soluong);
                dtHangHoa.Rows.Add(dr);
                grcHangHoa.DataSource = dtHangHoa;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(grvHangHoa.RowCount <= 0)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa nhập");
            }
            else
            {
                PhieuNhap pn = new PhieuNhap();
                pn.MaNhanVien = "NV0001";
                pn.SoPhieuNhap = tedSoPhieuNhap.Text;
                pn.NgayLap = DateTime.Now;
                pn.TongTien = TongTien;
                if(PhieuNhapService.Insert(pn))
                {
                    int success = 0, fail = 0;
                    for (int i = 0; i < grvHangHoa.RowCount; i++)
                    {
                        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                        ctpn.SoPhieuNhap = tedSoPhieuNhap.Text;
                        ctpn.MaHangHoa = grvHangHoa.GetRowCellValue(i, "MaHangHoa").ToString();
                        ctpn.MaNhaCungCap = int.Parse(grvHangHoa.GetRowCellValue(i, "MaNhaCungCap").ToString());
                        ctpn.HanSuDung = DateTime.Parse(grvHangHoa.GetRowCellValue(i, "HanSuDung").ToString());
                        ctpn.SoLuong = int.Parse(grvHangHoa.GetRowCellValue(i, "SoLuong").ToString());
                        ctpn.DonGiaNhap = decimal.Parse(grvHangHoa.GetRowCellValue(i, "DonGiaNhap").ToString());
                        ctpn.ThanhTien = decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
                        if (ChiTietPhieuNhapService.Insert(ctpn))
                            { success++; }
                        else{
                            fail++;
                            if(i > 0)
                            {
                                ChiTietPhieuNhapService.Delete(tedSoPhieuNhap.Text);
                            }
                            if(PhieuNhapService.Delete(tedSoPhieuNhap.Text))
                                { MessageBox.Show("Roll back thành công!"); }
                            else { MessageBox.Show("Roll back không thành công!"); }
                            break;
                        }
                    }
                    if(fail > 0)
                    {
                        MessageBox.Show("Lưu không thành công!");
                    }else if(success == grvHangHoa.RowCount)
                    {
                        isDataChanged = true;
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                else
                {
                    if (MessageBox.Show("Phiếu nhập này đã được lưu, bạn muốn tạo phiếu nhập mới?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        btnNhapLai.PerformClick();
                    }
                }
                
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grvHangHoa.DeleteRow(grvHangHoa.FocusedRowHandle);
        }

        private void grvHangHoa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "SoLuong")
            {
                TongTien = 0;
                int sl = int.Parse(grvHangHoa.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
                if(sl < 1)
                {
                    sl = 1;
                    grvHangHoa.SetRowCellValue(e.RowHandle, "SoLuong", sl);
                }
                decimal dg = decimal.Parse(grvHangHoa.GetRowCellValue(e.RowHandle, "DonGiaNhap").ToString());
                grvHangHoa.SetRowCellValue(e.RowHandle, "ThanhTien", (sl * dg));
                for (int i = 0; i < grvHangHoa.RowCount; i++)
                {
                    TongTien += Decimal.Parse(grvHangHoa.GetRowCellValue(i, "ThanhTien").ToString());
                }
                tedTongTien.Text = TongTien.ToString();
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
            if(grvHangHoa.RowCount > 0)
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận tạo phiếu mới?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    tedSoPhieuNhap.Text = PhieuXuatService.AutoGenerateId();
                    while (grvHangHoa.RowCount > 0)
                    { grvHangHoa.DeleteRow(0); }
                    tedTongTien.Text = "0";
                    lueHangHoa.Text = "";
                    speSoLuong.Text = "0";
                }
            }
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}

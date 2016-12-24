using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.DataBussiness;
using DevExpress.XtraEditors;
using QuanLySieuThi.DataModel;
namespace QuanLySieuThi.Presentation
{
    public partial class frmHoaDon : Form
    {
        bool isSaved;
        DataTable dtCTHD;
        decimal TongTien;
        int DiemThuong;
        int DiemTichLuy;
        int DiemTichLuyCapNhat;
        decimal TienGiam;
        decimal TienThanhToan;
        public frmHoaDon()
        {
            InitializeComponent();
            
            dtCTHD = new DataTable();
            dtCTHD.Columns.Add("MaHangHoa");
            dtCTHD.Columns.Add("TenHangHoa");
            dtCTHD.Columns.Add("SoLuong");
            dtCTHD.Columns.Add("Gia");
            dtCTHD.Columns.Add("ThanhTien");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Init();
            txtDiemTichLuy.ReadOnly = true;
            txtTienGiam.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Text = "0";
            txtDiemTichLuy.Text = DiemTichLuy.ToString();
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHangHoa", 50, "Mã Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHangHoa", 100, "Tên Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GiaBan", 100, "Giá"));
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
        }
        public void Init()
        {
            TongTien = 0;
            DiemThuong = 0;
            DiemTichLuy = 0;
            DiemTichLuyCapNhat = 0;
            TienGiam = 0;
            TienThanhToan = 0;
            isSaved = false;
            seSoLuong.ResetText();
            chbKHTT.Checked = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnKiemTra.Enabled = false;
            txtMaKhachHang.Enabled = false;
            txtSoHoaDon.Text = HoaDonService.AutoGenerateId();
            deNgayLap.DateTime = DateTime.Now;
        }
        public bool validateForm()
        {
            int check;
            if (lueHangHoa.Text.Trim() == "Hàng hóa")
            {
                XtraMessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn hàng hóa!");
                lueHangHoa.Focus();
                return false;
            }
            if (seSoLuong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập số lượng hàng hóa!");
                seSoLuong.Focus();
                return false;
            }
            try
            {
                check = Convert.ToInt32(seSoLuong.Text.ToString());
                if (check <= 0)
                {
                    XtraMessageBox.Show("Số lượng phải lớn hơn 0\nVui lòng nhập lại!");
                    seSoLuong.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Số lượng phải là số\nVui lòng nhập lại!");
                seSoLuong.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                DataRowView row = lueHangHoa.Properties.GetDataSourceRowByKeyValue(lueHangHoa.EditValue) as DataRowView;
                Int32 SL = Convert.ToInt32(seSoLuong.Text.ToString()); ;
                decimal Gia = 0;
                try
                {
                    Gia = Convert.ToDecimal(row.Row["GiaBan"].ToString()); ;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Không lấy được Giá hàng hóa!");
                    return;
                }
                int i;
                for( i=0;i<dtCTHD.Rows.Count;i++)
                {
                    if (lueHangHoa.EditValue.ToString().Equals(dtCTHD.Rows[i][0].ToString()))
                    {
                        SL += Convert.ToInt32(dtCTHD.Rows[i][2].ToString());
                        dtCTHD.Rows[i][2] = SL;
                        dtCTHD.Rows[i][4] = Gia * SL;
                        break;
                    }
                }
                if (i == dtCTHD.Rows.Count)
                {
                    DataRow dr = dtCTHD.NewRow();
                    dr[0] = lueHangHoa.EditValue;
                    dr[1] = lueHangHoa.Text;
                    dr[2] = SL;
                    dr[3] = Gia;
                    dr[4] = (SL * Gia);
                    dtCTHD.Rows.Add(dr);
                    grcHoaDon.DataSource = dtCTHD;
                    
                }
            }
        }

        private void grvHoaDon_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void grvHoaDon_RowCountChanged(object sender, EventArgs e)
        {
            if (grvHoaDon.RowCount > 0) btnLuu.Enabled = true;
            else btnLuu.Enabled = false;
            TongTien=0;
            for(int i=0;i<grvHoaDon.RowCount;i++)
            {
                TongTien = TongTien + Convert.ToDecimal(grvHoaDon.GetRowCellValue(i, "ThanhTien").ToString());
            }
            DiemThuong = Convert.ToInt32(TongTien / 15000);
            

            txtTongTien.Text = TongTien.ToString();
            txtDiemThuong.Text = DiemThuong.ToString();

            TienThanhToan = TongTien-DiemTichLuy;
            if (TienThanhToan < 0) TienThanhToan = 0;
            txtThanhTien.Text = TienThanhToan.ToString();
            
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập mã khách hàng!");
                DiemTichLuy = 0;
                txtDiemTichLuy.Text = DiemTichLuy.ToString();
                txtMaKhachHang.Focus();
                return ;
            }
            DataTable dtKT=KhachHangThanThietService.SearchMaKhachHang(txtMaKhachHang.Text.Trim());
            if(dtKT.Rows.Count==0)
            {
                XtraMessageBox.Show("Mã khách hàng không đúng");
                DiemTichLuy = 0;
                txtDiemTichLuy.Text = DiemTichLuy.ToString();
                txtMaKhachHang.Focus();
                return;
            }
            DiemTichLuy = Convert.ToInt32(dtKT.Rows[0][5].ToString());
            txtDiemTichLuy.Text = DiemTichLuy.ToString();
            
        }

        private void chbKHTT_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKHTT.Checked == true)
            {
                btnKiemTra.Enabled = true;
                txtMaKhachHang.Enabled = true;
            }
            else
            {
                btnKiemTra.Enabled = false;
                txtMaKhachHang.Enabled = false;
                DiemTichLuy = 0;
                txtDiemTichLuy.Text = DiemTichLuy.ToString();
                txtMaKhachHang.Text = "KH0000";
            }
        }

        private void txtDiemTichLuy_TextChanged(object sender, EventArgs e)
        {
            TienGiam = DiemTichLuy * 1000;
            txtTienGiam.Text = TienGiam.ToString();
            TienThanhToan = TongTien - TienGiam;
            if (TienThanhToan < 0) TienThanhToan = 0;
            txtThanhTien.Text = TienThanhToan.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (TongTien >= TienGiam) DiemTichLuyCapNhat = DiemThuong;
            else DiemTichLuyCapNhat = Convert.ToInt32(TongTien / 1000) + DiemThuong;
            HoaDon hd = new HoaDon();
            hd.SoHoaDon = txtSoHoaDon.Text.Trim();
            hd.MaKhachHang = txtMaKhachHang.Text.Trim();
            hd.MaNhanVien = "NV0001";
            hd.NgayLap=deNgayLap.DateTime;
            hd.TongTien = TienThanhToan;
            hd.TienGiam = TienGiam;
            hd.DiemThuong = DiemThuong;
            if(HoaDonService.Insert(hd))
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.SoHoaDon = hd.SoHoaDon;
                for(int i=0;i<grvHoaDon.RowCount;i++)
                {
                    cthd.MaHangHoa = grvHoaDon.GetRowCellValue(i, "MaHangHoa").ToString();
                    cthd.SoLuong = Convert.ToInt32(grvHoaDon.GetRowCellValue(i, "SoLuong").ToString());
                    if (!ChiTietHoaDonService.Insert(cthd))
                    {
                        XtraMessageBox.Show("Lưu thất bại!");
                        if (i > 0)
                        {
                            if(!ChiTietHoaDonService.Delete(hd.SoHoaDon))
                            {
                                XtraMessageBox.Show("Roll back không thành công!");
                                return;
                            }
                        }
                        if (HoaDonService.Delete(hd.SoHoaDon)) XtraMessageBox.Show("Roll back thành công!");
                        else XtraMessageBox.Show("Roll back không thành công!");
                        return;
                    }
                }
                if (hd.MaKhachHang != "KH0000")
                {
                    DataTable dtKT = KhachHangThanThietService.SearchMaKhachHang(hd.MaKhachHang);
                    dtKT.Rows[0][5] = DiemTichLuyCapNhat;
                }
                XtraMessageBox.Show("Lưu thành công!");
                isSaved = true;
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!");
                isSaved = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            grvHoaDon.DeleteSelectedRows();
        }

        private void grvHoaDon_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (grvHoaDon.SelectedRowsCount > 0) btnXoa.Enabled = true;
            else btnXoa.Enabled = false;
        }

        private void btnHoaDonMoi_Click(object sender, EventArgs e)
        {
            if (grvHoaDon.RowCount > 0 && !isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận tạo phiếu mới?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            Init();
            grvHoaDon.SelectAll();
            grvHoaDon.DeleteSelectedRows();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grvHoaDon.RowCount > 0 && !isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
          
        }
    }
}

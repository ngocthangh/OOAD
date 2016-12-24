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
using QuanLySieuThi.DataModel;
using DevExpress.XtraEditors;
using QuanLySieuThi.Common;

namespace QuanLySieuThi.Presentation
{
    public partial class frmPhieuKiemKe : Form
    {
        DataTable dtCTKK;
        bool isSaved;
        public frmPhieuKiemKe()
        {
            InitializeComponent();
            dtCTKK = new DataTable();
            dtCTKK.Columns.Add("MaHangHoa");
            dtCTKK.Columns.Add("HangHoa");
            dtCTKK.Columns.Add("SLTonTrenQuay");
            dtCTKK.Columns.Add("SLTonTrongKho");
        }
        public bool validateForm()
        {
            int check;     
            if (lueHangHoa.Text.Trim() == "Hàng hóa")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn hàng hóa!");
                lueHangHoa.Focus();
                return false;
            }
            if (txtSLTrenQuay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập số lượng hàng hóa trên quầy!");
                txtSLTrenQuay.Focus();
                return false;
            }
            if (txtSLTrongKho.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập số lượng hàng hóa trong kho!");
                txtSLTrongKho.Focus();
                return false;
            }
            try
            {
                check = Convert.ToInt32(txtSLTrenQuay.Text.ToString());
                if (check < 0)
                {
                    MessageBox.Show("Số lượng trên quầy không được nhỏ hơn 0\nVui lòng nhập lại!");
                    txtSLTrenQuay.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng trên quầy phải là số\nVui lòng nhập lại!");
                txtSLTrenQuay.Focus();
                return false;
            }

            try
            {
                check = Convert.ToInt32(txtSLTrongKho.Text.ToString());
                if (check < 0)
                {
                    MessageBox.Show("Số lượng trong kho không được nhỏ hơn 0\nVui lòng nhập lại!");
                    txtSLTrongKho.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số lượng trong kho phải là số\nVui lòng nhập lại!");
                txtSLTrongKho.Focus();
                return false;
            }
            return true;
        }
        private void frmPhieuKiemKe_Load(object sender, EventArgs e)
        {
            isSaved = false;
            txtNhanVien.Text = (ProjectUltil.HoTenNhanVien != "") ? ProjectUltil.HoTenNhanVien : "";
            txtNhanVien.ReadOnly = true;
            txtMaPhieu.ReadOnly = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhieu.Text = PhieuKiemKeService.AutoGenerateId();
            deNgayLap.DateTime = DateTime.Now;
            lueHangHoa.Properties.ValueMember = "MaHangHoa";
            lueHangHoa.Properties.DisplayMember = "TenHangHoa";
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHangHoa", 50, "Mã Hàng Hóa"));
            lueHangHoa.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenHangHoa", 100, "Tên Hàng Hóa"));
            lueHangHoa.Properties.DataSource = HangHoaService.LoadDataTable();
    
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                int i;
                for (i = 0; i < dtCTKK.Rows.Count; i++)
                {
                    if (lueHangHoa.EditValue.ToString().Equals(dtCTKK.Rows[i][0].ToString()))
                    {
                        XtraMessageBox.Show("Hàng hóa đã được kiểm kê");
                        return;
                    }
                }
                DataRow dr = dtCTKK.NewRow();
                dr[0] = lueHangHoa.EditValue;
                dr[1] = lueHangHoa.Text;
                dr[2] = Convert.ToInt32(txtSLTrenQuay.Text.ToString());
                dr[3] = Convert.ToInt32(txtSLTrongKho.Text.ToString());
                dtCTKK.Rows.Add(dr);
                grcPhieuKiemKe.DataSource = dtCTKK;
                
            }
            if (grvPhieuKiemKe.RowCount > 0) btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e) 
        {
            PhieuKiemKe pkk = new PhieuKiemKe();
            pkk.MaNhanVien = (ProjectUltil.MaNhanVien != "") ? ProjectUltil.MaNhanVien : "NV0001";
            pkk.SoPhieuKiemKe = txtMaPhieu.Text.Trim();
            pkk.NgayLap = deNgayLap.DateTime;
            if(PhieuKiemKeService.Insert(pkk))
            {
                for(int i=0;i<grvPhieuKiemKe.RowCount;i++)
                {
                    ChiTietKiemKe ctkk = new ChiTietKiemKe();
                    ctkk.SoPhieuKiemKe = pkk.SoPhieuKiemKe;
                    ctkk.MaHangHoa = grvPhieuKiemKe.GetRowCellValue(i, "MaHangHoa").ToString();
                    ctkk.SLTonTrenQuay = Convert.ToInt32(grvPhieuKiemKe.GetRowCellValue(i, "SLTonTrenQuay").ToString());
                    ctkk.SLTonTrongKho = Convert.ToInt32(grvPhieuKiemKe.GetRowCellValue(i, "SLTonTrongKho").ToString());
                    if (!ChiTietKiemKeService.Insert(ctkk))
                    {
                        XtraMessageBox.Show("Lưu thất bại!");
                        if (i > 0)
                        {
                            if (!ChiTietKiemKeService.Delete(pkk.SoPhieuKiemKe))
                            {
                                XtraMessageBox.Show("Roll back không thành công!");
                                return;
                            }
                        }
                        if (PhieuKiemKeService.Delete(pkk.SoPhieuKiemKe)) XtraMessageBox.Show("Roll back thành công!");
                        else XtraMessageBox.Show("Roll back không thành công!"); 
                        return;
                    }    
                }
                XtraMessageBox.Show("Lưu thành công!");
                isSaved = true;
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) //Hàm chỉ xóa trong bảng
        {
            if (MessageBox.Show("Bạn có chắc xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            grvPhieuKiemKe.DeleteSelectedRows();
            if (grvPhieuKiemKe.RowCount > 0) btnLuu.Enabled = true;
            else btnLuu.Enabled = false;
        
        }

        private void grvPhieuKiemKe_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (grvPhieuKiemKe.SelectedRowsCount > 0) btnXoa.Enabled = true;
            else btnXoa.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (grvPhieuKiemKe.RowCount > 0 && !isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận tạo phiếu mới?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            txtMaPhieu.Text = PhieuKiemKeService.AutoGenerateId();
            deNgayLap.DateTime = DateTime.Now;
            txtSLTrenQuay.ResetText();
            txtSLTrongKho.ResetText();
            lueHangHoa.ResetText();
            isSaved = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            grvPhieuKiemKe.SelectAll();
            grvPhieuKiemKe.DeleteSelectedRows();
        }

        private void grvPhieuKiemKe_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void frmPhieuKiemKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grvPhieuKiemKe.RowCount > 0 && !isSaved)
            {
                if (MessageBox.Show("Thông tin chưa được lưu, xác nhận thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

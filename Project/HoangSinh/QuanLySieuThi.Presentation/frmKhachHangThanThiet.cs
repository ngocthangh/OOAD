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

namespace QuanLySieuThi.Presentation
{
    public partial class frmKhachHangThanThiet : Form
    {
        public frmKhachHangThanThiet()
        {
            InitializeComponent();
        }
        public bool validateForm()
        {
            if (txtMaKhachHangThanThiet.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập mã khách hàng!");
                txtMaKhachHangThanThiet.Focus();
                return false;
            }
            if (txtTenKhachHangThanThiet.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Họ Tên khách hàng!");
                txtTenKhachHangThanThiet.Focus();
                return false;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập CMND!");
                txtCMND.Focus();
                return false;
            }
   

            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập địa chỉ khách hàng!");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        public void initThem()
        {
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaKhachHangThanThiet.ResetText();
            txtTenKhachHangThanThiet.ResetText();
            txtCMND.ResetText();
            txtDiaChi.ResetText();
            deNgayCapThe.DateTime=DateTime.Now;
            txtDiemTichLuy.Text="0";
            txtMaKhachHangThanThiet.Text = KhachHangThanThietService.AutoGenerateId();
        }
        private void frmKhachHangThanThiet_Load(object sender, EventArgs e)
        {
            var dt = KhachHangThanThietService.LoadDataTable();
            grcKHTT.DataSource = dt;
            initThem();
            
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator&& e.RowHandle>=0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                KhachHangThanThiet khtt = new KhachHangThanThiet();
                khtt.MaKhachHang = txtMaKhachHangThanThiet.Text.Trim();
                khtt.HoTen = txtTenKhachHangThanThiet.Text.Trim();
                khtt.DiaChi = txtDiaChi.Text.Trim();
                khtt.CMND = txtCMND.Text.Trim();
                try
                {
                    khtt.DiemThuong = Convert.ToInt32(txtDiemTichLuy.Text);
                }
                catch(Exception ex1)
                {
                    XtraMessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu");
                }
                khtt.NgayCapThe = deNgayCapThe.DateTime;
                try
                {
                    if (KhachHangThanThietService.Insert(khtt))
                    {
                        XtraMessageBox.Show("Thêm thành công");
                        grcKHTT.DataSource = KhachHangThanThietService.LoadDataTable();
                    }
                    else XtraMessageBox.Show("Thêm thất bại!");

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Thêm thất bại");
                }
            }
                
        }

        private void frmKhachHangThanThiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt= grcKHTT.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (
                XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!KhachHangThanThietService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                Dispose();
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
            gridView1.DeleteSelectedRows();
            var dt = grcKHTT.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if(KhachHangThanThietService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Xóa thành công","Xóa",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
            else
                XtraMessageBox.Show("Xóa thất bại", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            int currentID = e.RowHandle;

            string maKH = gridView1.GetRowCellValue(currentID, MaKhachHang).ToString();
            KhachHangThanThiet khtt = new KhachHangThanThiet();
            khtt=KhachHangThanThietService.GetDataFromRowSelected(maKH);
            txtMaKhachHangThanThiet.Text = khtt.MaKhachHang;
            txtTenKhachHangThanThiet.Text = khtt.HoTen;
            txtDiaChi.Text = khtt.DiaChi;
            txtCMND.Text = khtt.CMND;
            deNgayCapThe.DateTime = khtt.NgayCapThe.Value;
            txtDiemTichLuy.Text = khtt.DiemThuong.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmKhachHangThanThiet_Load(sender,e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KhachHangThanThiet khtt = new KhachHangThanThiet();
            khtt.MaKhachHang = txtMaKhachHangThanThiet.Text.Trim();
            khtt.HoTen = txtTenKhachHangThanThiet.Text.Trim();
            khtt.DiaChi = txtDiaChi.Text.Trim();
            khtt.CMND = txtCMND.Text.Trim();
            khtt.DiemThuong = Convert.ToInt32(txtDiemTichLuy.Text);
            khtt.NgayCapThe = deNgayCapThe.DateTime;
            try
            {
                if (KhachHangThanThietService.Update(khtt))
                {
                    XtraMessageBox.Show("Cập nhật thành công");
                    grcKHTT.DataSource = KhachHangThanThietService.LoadDataTable();
                }
                else XtraMessageBox.Show("Cập nhật thất bại!");

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Cập nhật thất bại");
            }
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0) btnXoa.Enabled = true;
            else btnXoa.Enabled = false;
        }
    }
}

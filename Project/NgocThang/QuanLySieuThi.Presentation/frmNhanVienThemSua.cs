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
    public partial class frmNhanVienThemSua : XtraForm
    {
        private const int MODE_UPDATE = 1;
        private const int MODE_ADDNEW = 0;
        public static string MaNhanVien;
        public static string HoTen;
        public static string GioiTinh;
        public static DateTime NgaySinh;
        public static DateTime NgayVaoLam;
        public static string CMND;
        public static string DienThoai;
        public static string ChucVu;
        public static string DiaChi;
        public static string TenDangNhap;
        public static string MatKhau;
        private int mode = MODE_ADDNEW;
        private bool isEdited = false;
        public bool isDataChanged = false;
        public frmNhanVienThemSua()
        {
            InitializeComponent();
        }
        public frmNhanVienThemSua(int mode)
        {
            InitializeComponent();
            this.mode = mode; 
        }
        public void initThem()
        {
            this.Text = "Thêm Nhân Viên Mới";
            txtMaNhanVien.Text = NhanVienService.AutoGenerateId();
            btnSua.Enabled = false;
            
        }
        public void initSua()
        {
            this.Text = "Sửa Thông Tin Nhân Viên";
            txtMaNhanVien.Text = MaNhanVien;
            txtHoTen.Text = HoTen;
            cbbGioiTinh.Text = GioiTinh;
            dedNgaySinh.Text = NgaySinh.ToString("MM/dd/yyyy");
            txtCMND.Text = CMND;
            txtDienThoai.Text = DienThoai;
            cbbChucVu.Text = ChucVu;
            dedNgayVaoLam.Text = NgayVaoLam.ToString("MM/dd/yyyy");
            txtDiaChi.Text = DiaChi;
            txtTenDangNhap.Text = TenDangNhap;
            txtMatKhau.Text = MatKhau;
            btnThem.Enabled = false;
        }

        private void frmNhanVienThemSua_Load(object sender, EventArgs e)
        {
            if(mode == MODE_ADDNEW)
            {
                initThem();
            }
            else
            {
                initSua();
            }
            cbbGioiTinh.Properties.Items.Add("Nam");
            cbbGioiTinh.Properties.Items.Add("Nữ");
            cbbGioiTinh.Properties.Items.Add("Khác");
            cbbChucVu.Properties.Items.Add("Nhân viên bán hàng");
            cbbChucVu.Properties.Items.Add("Nhân viên kho");
            cbbChucVu.Properties.Items.Add("Nhân viên nhân sự");
            cbbChucVu.Properties.Items.Add("Nhân viên tài chính");
        }
        public bool validateForm()
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập mã nhân viên!");
                txtMaNhanVien.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Họ Tên nhân viên!");
                txtHoTen.Focus();
                return false;
            }
            if(dedNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Ngày Sinh!");
                dedNgaySinh.Focus();
                return false;
            }
            if (cbbGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn Giới Tính!");
                cbbGioiTinh.Focus();
                return false;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập CMND!");
                txtCMND.Focus();
                return false;
            }
            if(txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Điện Thoại!");
                txtDienThoai.Focus();
                return false;
            }
            if (cbbChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn Chức Vụ!");
                cbbChucVu.Focus();
                return false;
            }
            if (dedNgayVaoLam.Text.Trim() == "") {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng chọn Ngày Vào Làm!");
                dedNgayVaoLam.Focus();
                return false;
            }
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Tên Đăng Nhập!");
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!\nVui lòng nhập Mật Khẩu!");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = txtMaNhanVien.Text.Trim();
                nv.HoTen = txtHoTen.Text.Trim();
                nv.NgaySinh = dedNgaySinh.DateTime;
                nv.GioiTinh = cbbGioiTinh.Text.Trim();
                nv.CMND = txtCMND.Text.Trim();
                nv.DienThoai = txtDienThoai.Text.Trim();
                nv.MaChucVu = "CV001";
                nv.NgayVaoLam = dedNgayVaoLam.DateTime;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                nv.MatKhau = txtMatKhau.Text.Trim();
                try {
                    if (NhanVienService.Insert(nv))
                    {
                        isDataChanged = true;
                        isEdited = false;
                        MessageBox.Show("Thêm thành công!");
                    }
                    
                    else MessageBox.Show("Không thể thêm\nMã nhân viên đã tồn tại!");
                }
                catch(Exception ex1)
                {
                    MessageBox.Show("Thêm thất bại!");
                }
                
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                if (MessageBox.Show("Thật sự muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                if (validateForm())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = txtMaNhanVien.Text.Trim();
                    nv.HoTen = txtHoTen.Text.Trim();
                    nv.NgaySinh = dedNgaySinh.DateTime;
                    nv.GioiTinh = cbbGioiTinh.Text.Trim();
                    nv.CMND = txtCMND.Text.Trim();
                    nv.DienThoai = txtDienThoai.Text.Trim();
                    nv.MaChucVu = "CV001";
                    nv.NgayVaoLam = dedNgayVaoLam.DateTime;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                    nv.MatKhau = txtMatKhau.Text.Trim();
                    try
                    {
                        if (NhanVienService.Update(nv))
                        {
                            isDataChanged = true;
                            isEdited = false;
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else MessageBox.Show("Không thể cập nhật!");

                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show("Không thể cập nhật!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa sửa thông tin!");
            }
        }
        
        private void keyDown(object sender, KeyEventArgs e)
        {
            isEdited = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if(mode == MODE_ADDNEW)
            {
                txtHoTen.Text = "";
                cbbGioiTinh.Text = "";
                dedNgaySinh.Text = "";
                txtCMND.Text = "";
                txtDienThoai.Text = "";
                cbbChucVu.Text = "";
                dedNgayVaoLam.Text = "";
                txtDiaChi.Text = "";
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
            }
            else
            {
                initSua();
            }
            isEdited = false;
            txtHoTen.Focus();
        }

        private void dedNgaySinh_TextChanged(object sender, EventArgs e)
        {
            if(dedNgaySinh.Text != NgaySinh.ToString("MM/dd/yyyy"))
            {
                isEdited = true;
            }
        }

        private void cbbGioiTinh_TextChanged(object sender, EventArgs e)
        {
            if (cbbGioiTinh.Text != GioiTinh)
            {
                isEdited = true;
            }
        }

        private void dedNgayVaoLam_TextChanged(object sender, EventArgs e)
        {
            if (dedNgayVaoLam.Text != NgayVaoLam.ToString("MM/dd/yyyy"))
            {
                isEdited = true;
            }
        }

        private void cbbChucVu_TextChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.Text != ChucVu)
            {
                isEdited = true;
            }
        }
    }
}

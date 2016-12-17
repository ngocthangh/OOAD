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
using DevExpress.XtraEditors.Controls;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.Presentation
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        private const int MODE_UPDATE = 1;
        private const int MODE_ADDNEW = 0;
        private int mode = MODE_ADDNEW;

        public static string MaHangHoa;
        public static string TenHangHoa;
        public static Decimal GiaMua;
        public static Decimal GiaBan;
        public static int SoLuongNhap;
        public static int SoLuongBan;
        public static int VAT;
        public static int LoaiHang;
        public static int DonViTinh;
        public static DateTime NgaySanXuat;
        public static DateTime HanSuDung;
        public static DateTime NgayNhap;
        public bool isEdited = false;
        public bool isDataChanged = false;

        public DataTable _dtLoaiHang;
        public DataTable _dtDonViTinh;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        public frmHangHoa(int mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        public void initThem()
        {
            this.Text = "Thêm Hàng Hóa Mới";
            txtMaHangHoa.Text = HangHoaService.AutoGenerateId();
            btnSua.Enabled = false;
        }

        public void initSua()
        {
            this.Text = "Sửa Thông Tin Hàng Hóa";
            txtMaHangHoa.Text = MaHangHoa;
            txtTenHangHoa.Text = TenHangHoa;
            txtGiaMua.Text = GiaMua.ToString();
            txtGiaBan.Text = GiaBan.ToString();
            txtSoLuongNhap.Text = SoLuongNhap.ToString();
            txtSoLuongBan.Text = SoLuongBan.ToString();
            txtVAT.Text = VAT.ToString();
            lookUpEditLoaiHang.Text = LoaiHang.ToString();
            lookUpEditDonViTinh.Text = DonViTinh.ToString();
            dtNgaySanXuat.Text = NgaySanXuat.ToString("MM/dd/yyyy");
            dtHanSuDung.Text = HanSuDung.ToString("MM/dd/yyyy");
            dtNgayNhap.Text = NgayNhap.ToString("MM/dd/yyyy");

            btnLuu.Enabled = false;
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            if (mode == MODE_ADDNEW)
            {
                initThem();
            }
            else
            {
                initSua();
            }

            _dtLoaiHang = LoaiHangService.LoadDataTable();
            _dtDonViTinh = DonViTinhService.LoadDataTable();

            lookUpEditLoaiHang.Properties.DataSource = _dtLoaiHang;
            lookUpEditLoaiHang.Properties.ValueMember = "MaLoaiHang";
            lookUpEditLoaiHang.Properties.DisplayMember = "TenLoaiHang";
            lookUpEditLoaiHang.Properties.Columns.Add(new LookUpColumnInfo("MaLoaiHang", "Mã Loại Hàng"));
            lookUpEditLoaiHang.Properties.Columns.Add(new LookUpColumnInfo("TenLoaiHang", "Tên Loại Hàng"));

            lookUpEditDonViTinh.Properties.DataSource = _dtDonViTinh;
            lookUpEditDonViTinh.Properties.ValueMember = "MaDVT";
            lookUpEditDonViTinh.Properties.DisplayMember = "TenDVT";
            lookUpEditDonViTinh.Properties.Columns.Add(new LookUpColumnInfo("MaDVT", "Mã Đơn Vị Tính"));
            lookUpEditDonViTinh.Properties.Columns.Add(new LookUpColumnInfo("TenDVT", "Tên Đơn Vị Tính"));

        }

        private void frmHangHoa_Validated(object sender, EventArgs e)
        {

        }

        public bool validateForm()
        {
            if (txtMaHangHoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập mã hàng hóa!");
                txtMaHangHoa.Focus();
                return false;
            }
            if (txtTenHangHoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập tên hàng hóa!");
                txtTenHangHoa.Focus();
                return false;
            }
            if (txtGiaMua.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Giá mua!");
                txtGiaMua.Focus();
                return false;
            }
            if (txtGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Giá bán!");
                txtGiaBan.Focus();
                return false;
            }
            if (dtNgaySanXuat.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Ngày sản xuất!");
                dtNgaySanXuat.Focus();
                return false;
            }
            if (dtHanSuDung.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Hạn sử dụng!");
                dtHanSuDung.Focus();
                return false;
            }
            if (dtNgayNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Ngày nhập");
                dtNgayNhap.Focus();
                return false;
            }
            if (txtSoLuongNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập vào Số Lượng Nhập");
                txtSoLuongNhap.Focus();
                return false;
            }
            if (txtSoLuongBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập vào Số Lượng Bán");
                txtSoLuongBan.Focus();
                return false;
            }
            if (txtVAT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập vào VAT");
                txtVAT.Focus();
                return false;
            }
            if (lookUpEditLoaiHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng chọn Loại Hàng");
                lookUpEditLoaiHang.Focus();
                return false;
            }
            if (lookUpEditDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng chọn Đơn Vị Tính");
                lookUpEditDonViTinh.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                HangHoa hh = new HangHoa();
                hh.MaHangHoa = txtMaHangHoa.Text.Trim();
                hh.TenHangHoa = txtTenHangHoa.Text.Trim();
                hh.GiaMua = Convert.ToDecimal(txtGiaMua.Text);
                hh.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                hh.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                hh.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
                hh.VAT = Convert.ToInt32(txtVAT.Text);
                hh.NgaySanXuat = dtNgaySanXuat.DateTime;
                hh.NgayNhap = dtNgayNhap.DateTime;
                hh.HanSuDung = dtHanSuDung.DateTime;
                hh.MaLoaiHang = lookUpEditLoaiHang.EditValue.ToString();
                hh.MaDVT = lookUpEditDonViTinh.EditValue.ToString();
                try
                {
                    if (HangHoaService.Insert(hh))
                    {
                        isDataChanged = true;
                        isEdited = false;
                        MessageBox.Show("Thêm thành công!");
                        initThem();
                    }

                    else MessageBox.Show("Không thể thêm\nMã nhân viên đã tồn tại!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                if (MessageBox.Show("Bạn Thật sự muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            if (validateForm())
            {
                HangHoa hh = new HangHoa();
                hh.MaHangHoa = txtMaHangHoa.Text.Trim();
                hh.TenHangHoa = txtTenHangHoa.Text.Trim();
                hh.GiaMua = Convert.ToDecimal(txtGiaMua.Text);
                hh.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                hh.SoLuongBan = Convert.ToInt32(txtSoLuongBan.Text);
                hh.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
                hh.VAT = Convert.ToInt32(txtVAT.Text);
                hh.NgaySanXuat = dtNgaySanXuat.DateTime;
                hh.NgayNhap = dtNgayNhap.DateTime;
                hh.HanSuDung = dtHanSuDung.DateTime;
                hh.MaLoaiHang = lookUpEditLoaiHang.EditValue.ToString();
                hh.MaDVT = lookUpEditDonViTinh.EditValue.ToString();
                try
                {
                    if (HangHoaService.Update(hh))
                    {
                        isDataChanged = true;
                        isEdited = false;
                        MessageBox.Show("Cập Nhật thành công!");
                    }

                    else MessageBox.Show("Không thể cập nhật!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể cập nhật!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa sửa thông tin!");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (mode == MODE_ADDNEW)
            {
                txtTenHangHoa.Text = "";
                txtGiaMua.Text = "";
                txtGiaBan.Text = "";
                txtSoLuongBan.Text = "";
                txtSoLuongNhap.Text = "";
                txtVAT.Text = "";
                dtNgayNhap.Text = "";
                dtNgaySanXuat.Text = "";
                dtHanSuDung.Text = "";
                lookUpEditLoaiHang.Text = "";
                lookUpEditDonViTinh.Text = "";
            }
            else
            {
                initSua();
            }
            isEdited = false;
            txtTenHangHoa.Focus();
        }

        private void dtNgaySanXuat_TextChanged(object sender, EventArgs e)
        {
            if (dtNgaySanXuat.Text != NgaySanXuat.ToString("MM/dd/yyyy"))
            {
                isEdited = true;
            }
        }

        private void dtHanSuDung_TextChanged(object sender, EventArgs e)
        {
            if (dtHanSuDung.Text != HanSuDung.ToString("MM/dd/yyyy"))
            {
                isEdited = true;
            }
        }

        private void dtNgayNhap_TextChanged(object sender, EventArgs e)
        {
            if (dtNgayNhap.Text != NgayNhap.ToString("MM/dd/yyyy"))
            {
                isEdited = true;
            }
        }
    }
}
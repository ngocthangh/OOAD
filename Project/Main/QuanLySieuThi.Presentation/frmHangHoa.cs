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
        public static Decimal GiaNhap;
        public static Decimal GiaBan;
        public static int LoaiHang;
        public static int DonViTinh;
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
            tedMaHangHoa.Text = HangHoaService.AutoGenerateId();
            btnLuu.Text = "Thêm";
        }

        public void initSua()
        {
            this.Text = "Sửa Thông Tin Hàng Hóa";
            tedMaHangHoa.Text = MaHangHoa;
            tedTenHangHoa.Text = TenHangHoa;
            tedGiaNhap.Text = GiaNhap.ToString();
            tedGiaBan.Text = GiaBan.ToString();
            lueLoaiHang.EditValue = LoaiHang.ToString();
            lueDonViTinh.EditValue = DonViTinh.ToString();
            btnLuu.Text = "Sửa";
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
            tedMaHangHoa.ReadOnly = true;
            lueLoaiHang.Properties.ValueMember = "MaLoaiHang";
            lueLoaiHang.Properties.DisplayMember = "TenLoaiHang";
            lueLoaiHang.Properties.Columns.Add(new LookUpColumnInfo("TenLoaiHang", "Tên Loại Hàng"));
            lueLoaiHang.Properties.DataSource = LoaiHangService.LoadDataTable();
            
            lueDonViTinh.Properties.ValueMember = "MaDVT";
            lueDonViTinh.Properties.DisplayMember = "TenDVT";
            lueDonViTinh.Properties.Columns.Add(new LookUpColumnInfo("TenDVT", "Tên Đơn Vị Tính"));
            lueDonViTinh.Properties.DataSource = DonViTinhService.LoadDataTable();
        }

        private void frmHangHoa_Validated(object sender, EventArgs e)
        {

        }

        public bool validateForm()
        {
            if (tedMaHangHoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập mã hàng hóa!");
                tedMaHangHoa.Focus();
                return false;
            }
            if (tedTenHangHoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập tên hàng hóa!");
                tedTenHangHoa.Focus();
                return false;
            }
            if (tedGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Giá mua!");
                tedGiaNhap.Focus();
                return false;
            }
            if (tedGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng nhập Giá bán!");
                tedGiaBan.Focus();
                return false;
            }
            if (lueLoaiHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng chọn Loại Hàng");
                lueLoaiHang.Focus();
                return false;
            }
            if (lueDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin! \nVui lòng chọn Đơn Vị Tính");
                lueDonViTinh.Focus();
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                HangHoa hh = new HangHoa();
                hh.MaHangHoa = tedMaHangHoa.Text.Trim();
                hh.TenHangHoa = tedTenHangHoa.Text.Trim();
                hh.GiaNhap = Convert.ToDecimal(tedGiaNhap.Text);
                hh.GiaBan = Convert.ToDecimal(tedGiaBan.Text);
                hh.SoLuongTon = 0;
                hh.SoLuongQuay = 0;
                hh.MaLoaiHang = lueLoaiHang.EditValue.ToString();
                hh.MaDVT = lueDonViTinh.EditValue.ToString();
                if (mode == MODE_ADDNEW)
                {
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
                else
                {
                    if (isEdited)
                    {
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
            }
        }
        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    if (mode == MODE_ADDNEW)
        //    {
        //        if (validateForm())
        //        {
        //            HangHoa hh = new HangHoa();
        //            hh.MaHangHoa = txtMaHangHoa.Text.Trim();
        //            hh.TenHangHoa = txtTenHangHoa.Text.Trim();
        //            hh.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
        //            hh.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
        //            hh.SoLuongTon = 0;
        //            hh.SoLuongQuay = 0;
        //            hh.MaLoaiHang = lueLoaiHang.EditValue.ToString();
        //            hh.MaDVT = lueDonViTinh.EditValue.ToString();
        //            try
        //            {
        //                if (HangHoaService.Insert(hh))
        //                {
        //                    isDataChanged = true;
        //                    isEdited = false;
        //                    MessageBox.Show("Thêm thành công!");
        //                    initThem();
        //                }

        //                else MessageBox.Show("Không thể thêm\nMã nhân viên đã tồn tại!");
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Thêm thất bại!");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (validateForm())
        //        {
        //            HangHoa hh = new HangHoa();
        //            hh.MaHangHoa = txtMaHangHoa.Text.Trim();
        //            hh.TenHangHoa = txtTenHangHoa.Text.Trim();
        //            hh.GiaNhap = Convert.ToDecimal(txtGiaNhap.Text);
        //            hh.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
        //            hh.SoLuongTon = 0;
        //            hh.SoLuongQuay = 0;
        //            hh.MaLoaiHang = lueLoaiHang.EditValue.ToString();
        //            hh.MaDVT = lueDonViTinh.EditValue.ToString();
        //            try
        //            {
        //                if (HangHoaService.Update(hh))
        //                {
        //                    isDataChanged = true;
        //                    isEdited = false;
        //                    MessageBox.Show("Cập Nhật thành công!");
        //                }

        //                else MessageBox.Show("Không thể cập nhật!");
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Không thể cập nhật!");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Bạn chưa sửa thông tin!");
        //        }
        //    }
                
        //}

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
        
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (mode == MODE_ADDNEW)
            {
                tedMaHangHoa.Text = HangHoaService.AutoGenerateId();
                tedTenHangHoa.Text = "";
                tedGiaNhap.Text = "";
                tedGiaBan.Text = "";
                lueLoaiHang.Text = "";
                lueDonViTinh.Text = "";
            }
            else
            {
                initSua();
            }
            isEdited = false;
            tedTenHangHoa.Focus();
        }

        private void txtMaHangHoa_TextChanged(object sender, EventArgs e)
        {
            if (tedMaHangHoa.Text != MaHangHoa)
            {
                isEdited = true;
            }
        }

        private void tedTenHangHoa_TextChanged(object sender, EventArgs e)
        {
            if (tedTenHangHoa.Text != TenHangHoa)
            {
                isEdited = true;
            }
        }

        private void tedGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (tedGiaNhap.Text != GiaNhap.ToString())
            {
                isEdited = true;
            }
        }
        private void tedGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (tedGiaBan.Text != GiaBan.ToString())
            {
                isEdited = true;
            }
        }

        private void lueLoaiHang_TextChanged(object sender, EventArgs e)
        {
            if (lueLoaiHang.EditValue.ToString() != LoaiHang.ToString())
            {
                isEdited = true;
            }
        }

        private void lueDonViTinh_TextChanged(object sender, EventArgs e)
        {
            if (lueDonViTinh.EditValue.ToString() != DonViTinh.ToString())
            {
                isEdited = true;
            }
        }
    }
}
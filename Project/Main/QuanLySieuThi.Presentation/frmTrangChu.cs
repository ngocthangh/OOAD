using QuanLySieuThi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace QuanLySieuThi.Presentation
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }

        private void OpenForm<T>()
        {
            var f = MdiChildren.FirstOrDefault(i => i is T);

            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                if (f == null) return;
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void buttonClick_ThongTinHanghoa(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmHangHoaSearch>();

        }

        private void buttonClick_ChungLoaiHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmChungLoaiHang>();
        }

        private void buttonClick_LoaiHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmLoaiHang>();
        }

        private void buttonClick_DonViTinh(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmDonViTinh>();
        }

        private void buttonClick_NhaCungCap(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhaCungCap>();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhanVien>();
            //OpenForm<Form1>();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmPhieuNhap>();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmPhieuXuat>();
        }

        private void bbtKhachHangThanThiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmKhachHangThanThiet>();
        }

        private void bbtChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<FrmChucVu>();
        }

        private void bbtLapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmHoaDon>();
        }

        private void bbtPhieuKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmPhieuKiemKe>();
        }

        private void bbtDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.FormClosing += new FormClosingEventHandler(checkUser);
            f.ShowDialog();
        }

        private void checkUser(object sender, FormClosingEventArgs e)
        {
            if(ProjectUltil.HoTenNhanVien != "")
            {
                lblNhanVien.Text = ProjectUltil.HoTenNhanVien;
                bbtDangNhap.Enabled = false;
                bbtDangXuat.Enabled = true;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbtDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProjectUltil.MaNhanVien = "";
            ProjectUltil.HoTenNhanVien = "";
            lblNhanVien.Text = "";
            bbtDangNhap.Enabled = true;
            bbtDangXuat.Enabled = false;
            MessageBox.Show("Đã logout!");
        }

        private void bbtBaoCaoTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmBaoCaoTonKho>();
        }

        private void bbtDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmBaoCaoDoanhThu>();
        }

        private void btnTraCuuNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhaCungCapSearch>();
        }

        private void btnTraCuuChungLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmLoaiHangSearch>();
        }

        private void btnTraCuuDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmDonViTinhSearch>();
        }

        private void btnTraCuuLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmLoaiHangSearch>();
        }
    }
}

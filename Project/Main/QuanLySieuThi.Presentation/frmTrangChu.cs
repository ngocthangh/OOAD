using QuanLySieuThi.Common;
using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace QuanLySieuThi.Presentation
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private const int ADMIN = 1;
        private const int GIAMDOC = 2;
        private const int NHANVIENKHO = 3;
        private const int NHANVIENBANHANG = 4;
        private const int NHANVIENNHANSU = 5;
        private const int NHANVIENKETOAN = 6;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            unlockAll();
        }
        private void unlockAll()
        {
            rbpThayDoiCSDL.Visible = true;
            rbpGiaoDien.Visible = true;
            rbpThayDoiQuyDinh.Visible = true;
            rbpBaoCaoThongKe.Visible = true;
            rbpQuanLy.Visible = true;
            rbpNghiepVu.Visible = true;
            rbpHangHoa.Visible = true;
            rbpNhaCungCap.Visible = true;
            rbpKho.Visible = true;
            rbpKiemKe.Visible = true;
            rbpTraCuu.Visible = true;
            rbpNghiepVu.Visible = true;
            rbpBanHang.Visible = true;
            rbpKhachHangThanThiet.Visible = true;
            rbpTraCuu.Visible = true;
            rbpQuanLy.Visible = true;
            rbpNhanVien.Visible = true;
            rbpChucVu.Visible = true;
            rbpTraCuu.Visible = true;
            rbpBaoCaoThongKe.Visible = true;
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
            OpenForm<frmHangHoaQuanLy>();

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
            if (ProjectUltil.HoTenNhanVien != "")
            {
                lblNhanVien.Text = ProjectUltil.HoTenNhanVien;
                bbtDangNhap.Enabled = false;
                bbtDangXuat.Enabled = true;
            }
            if (ProjectUltil.MaChucVu != 0)
            {
                switch (ProjectUltil.MaChucVu)
                {
                    case ADMIN:
                        rbpThayDoiCSDL.Visible = true;
                        rbpGiaoDien.Visible = true;
                        break;
                    case GIAMDOC:
                        rbpThayDoiQuyDinh.Visible = true;
                        rbpBaoCaoThongKe.Visible = true;
                        break;
                    case NHANVIENKHO:
                        rbpQuanLy.Visible = true;
                        rbpNghiepVu.Visible = true;
                        rbpHangHoa.Visible = true;
                        rbpNhaCungCap.Visible = true;
                        rbpKho.Visible = true;
                        rbpKiemKe.Visible = true;
                        rbpTraCuu.Visible = true;
                        break;
                    case NHANVIENBANHANG:
                        rbpNghiepVu.Visible = true;
                        rbpBanHang.Visible = true;
                        rbpKhachHangThanThiet.Visible = true;
                        rbpTraCuu.Visible = true;
                        break;
                    case NHANVIENNHANSU:
                        rbpQuanLy.Visible = true;
                        rbpNhanVien.Visible = true;
                        rbpChucVu.Visible = true;
                        rbpTraCuu.Visible = true;
                        break;
                    case NHANVIENKETOAN:
                        rbpBaoCaoThongKe.Visible = true;
                        break; ;
                }
            }
        }

        private void reSet()
        {
            rbpThayDoiCSDL.Visible = false;
            rbpGiaoDien.Visible = false;
            rbpThayDoiQuyDinh.Visible = false;
            rbpBaoCaoThongKe.Visible = false;

            rbpQuanLy.Visible = false;
            rbpNghiepVu.Visible = false;
            rbpHangHoa.Visible = false;
            rbpNhaCungCap.Visible = false;
            rbpKho.Visible = false;
            rbpKiemKe.Visible = false;
            rbpTraCuu.Visible = false;

            rbpBanHang.Visible = false;
            rbpKhachHangThanThiet.Visible = false;

            rbpNhanVien.Visible = false;
            rbpChucVu.Visible = false;

            rbpBaoCaoThongKe.Visible = false;

            //tabbedView1.Documents.Clear();
            for (int i = tabbedView1.Documents.Count - 1; i >= 0; i--)
            {
                tabbedView1.Documents[i].Form.Close();
            }
            tabbedView1.Documents.Clear();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbtDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                reSet();
                ProjectUltil.logout();
                lblNhanVien.Text = "";
                bbtDangNhap.Enabled = true;
                bbtDangXuat.Enabled = false;
                MessageBox.Show("Đã logout!");
            }
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
            OpenForm<frmChungLoaiHangSearch>();
        }

        private void btnTraCuuDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmDonViTinhSearch>();
        }

        private void btnTraCuuLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmLoaiHangSearch>();
        }

        private void bbtThayDoiQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThayDoiQuyDinh f = new frmThayDoiQuyDinh();
            f.ShowDialog();
        }

        private void bbtTraCuuHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmHangHoaSearch>();
        }

        private void bbtTTPhanMem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("PHẦN MỀM QUẢN LÝ SIÊU THỊ TNS\nVersion: 1.0\nGiảng viên hướng dẫn: ThS Phạm Thi Vương\nMôn học: Phương pháp phát triển phần mềm hướng đối tượng (SE100.H12)", "Thông Tin Phần Mềm");
        }

        private void bbtTTNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Nhóm sinh viên thực hiện:\n\n\tHUỲNH NGỌC THẮNG - 13520775\n\tNGUYỄN VĂN NGUYỆN - 13520567\n\tLÊ HOÀNG SINH - 13520703", "Thông Tin Nhóm Thực Hiện");
        }

        private void bbtBackupDatabase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bBackUpStatus = true;

            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"D:\SQLBackup"))
            {
                if (File.Exists(@"D:\SQLBackup\QuanLySieuThi.bak"))
                {
                    if (MessageBox.Show(@"Do you want to replace it?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\SQLBackup\QuanLySieuThi.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"D:\SQLBackup");

            if (bBackUpStatus)
            {
                if (BackupDatabaseService.BackupDatabase())
                {
                    MessageBox.Show("Backup thành công");
                }
                else { MessageBox.Show("Backup thất bại"); }
            }

        }

        private void bbtRestoreDatabase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"D:\SQLBackup\QuanLySieuThi.bak"))
                {
                    if (MessageBox.Show("Are you sure you restore?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (BackupDatabaseService.RestoreDatabase())
                        {
                            MessageBox.Show("Restore thành công");
                        }
                        else { MessageBox.Show("Restore thất bại"); }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}

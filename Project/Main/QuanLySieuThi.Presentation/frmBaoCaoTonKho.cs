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
    public partial class frmBaoCaoTonKho : Form
    {
        DataTable dsBaoCaoTonKho, dsPhieuNhap, dsPhieuXuat, dsCTPhieuNhap, dsCTPhieuXuat, dsHangHoa;

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

        }

        BaoCaoTonKho bctk;
        ChiTietBaoCaoTonKho ctbctk;
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            tedNguoiLap.ReadOnly = true;
            tedNgayLap.ReadOnly = true;
            tedNguoiLap.Text = (ProjectUltil.HoTenNhanVien != "") ? ProjectUltil.HoTenNhanVien : "";
            tedNgayLap.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            int thang = 1, nam = 2016;
            if (cbbThang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tháng!");
                return;
            }
            thang = int.Parse(cbbThang.Text);
            if (cbbNam.Text == "")
            {
                MessageBox.Show("Vui lòng chọn năm!");
                return;
            }
            nam = int.Parse(cbbNam.Text);
            DateTime dateStart = new DateTime(nam, thang, 1);
            DateTime dateEnd = new DateTime(nam, thang, ProjectUltil.soNgay(nam, thang));
            if(dateStart > DateTime.Now.Date)
            {
                MessageBox.Show("Thời gian phải trước ngày hiện tại!");
                return;
            }
            //if(dateEnd > DateTime.Now.Date)
            //{
            //    dateEnd = DateTime.Now.Date;
            //}
            dsPhieuNhap = PhieuNhapService.Search(null, dateStart, dateEnd);
            dsPhieuXuat = PhieuXuatService.Search(null, dateStart, dateEnd);
            dsBaoCaoTonKho = BaoCaoTonKhoService.GetByMonthYear(thang, nam);
            dsHangHoa = HangHoaService.LoadDataTable();
            if (dsBaoCaoTonKho.Rows.Count > 0)
            {
                grcBaoCaoTonKho.DataSource = ChiTietBaoCaoTonKhoService.GetById(dsBaoCaoTonKho.Rows[0].Field<int>("MaBaoCaoTonKho"));
            }
            else
            {
                bctk = new BaoCaoTonKho();
                bctk.MaNhanVien = (ProjectUltil.MaNhanVien != "") ? ProjectUltil.MaNhanVien : "NV0001";
                bctk.Nam = nam;
                bctk.Thang = thang;
                bctk.NgayLap = DateTime.Now.Date;
                if ((bctk.MaBaoCaoTonKho = BaoCaoTonKhoService.Insert(bctk)) != -1)
                {
                    for (int i = 0; i < dsHangHoa.Rows.Count; i++)
                    {
                        ctbctk = new ChiTietBaoCaoTonKho();
                        ctbctk.MaBaoCaoTonKho = bctk.MaBaoCaoTonKho;
                        ctbctk.MaHangHoa = dsHangHoa.Rows[i].Field<string>("MaHangHoa");
                        ctbctk.SoLuongDauKy = 0;
                        for (int j = 0; j < dsPhieuNhap.Rows.Count; j++)
                        {
                            dsCTPhieuNhap = ChiTietPhieuNhapService.GetById(dsPhieuNhap.Rows[j].Field<string>("SoPhieuNhap"));
                            for (int k = 0; k < dsCTPhieuNhap.Rows.Count; k++)
                            {
                                if (dsCTPhieuNhap.Rows[k].Field<string>("MaHangHoa") == ctbctk.MaHangHoa)
                                {
                                    int soluong = dsCTPhieuNhap.Rows[k].Field<int>("SoLuong");
                                    ctbctk.SoLuongNhap += soluong;
                                }
                            }
                        }
                        
                        for (int j = 0; j < dsPhieuXuat.Rows.Count; j++)
                        {
                            dsCTPhieuXuat = ChiTietPhieuXuatService.GetById(dsPhieuXuat.Rows[j].Field<string>("SoPhieuXuat"));
                            for (int k = 0; k < dsCTPhieuXuat.Rows.Count; k++)
                            {
                                if (dsCTPhieuXuat.Rows[k].Field<string>("MaHangHoa") == ctbctk.MaHangHoa)
                                {
                                    int soluong = dsCTPhieuXuat.Rows[k].Field<int>("SoLuong");
                                    ctbctk.SoLuongXuat += soluong;
                                }
                            }
                        }
                        
                        ctbctk.SoLuongCuoiKy = ctbctk.SoLuongDauKy + ctbctk.SoLuongNhap - ctbctk.SoLuongXuat;
                        if (!ChiTietBaoCaoTonKhoService.Insert(ctbctk))
                        {
                            ChiTietBaoCaoTonKhoService.Delete(ctbctk.MaBaoCaoTonKho.ToString());
                            BaoCaoTonKhoService.Delete(ctbctk.MaBaoCaoTonKho.ToString());
                            MessageBox.Show("Không thể thêm chi tiết báo cáo!");
                        }
                    }
                }
                else { MessageBox.Show("Không thể lập báo cáo!"); }
                grcBaoCaoTonKho.DataSource = ChiTietBaoCaoTonKhoService.GetById(bctk.MaBaoCaoTonKho);
            }
            
        }
    }
}

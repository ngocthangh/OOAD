using System;

namespace QuanLySieuThi.DataModel
{
    public partial class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public int MaChucVu { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
}

using System;

namespace QuanLySieuThi.DataModel
{
    public partial class PhieuXuat
    {
        public string SoPhieuXuat { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NoiDungXuat { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    }
}

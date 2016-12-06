using System;

namespace QuanLySieuThi.DataModel
{
    public partial class ChiTietHoaDon
    {
        public string SoHoaDon { get; set; }
        public string MaHangHoa { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }
}

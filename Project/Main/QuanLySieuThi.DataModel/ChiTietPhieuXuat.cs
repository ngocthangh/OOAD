using System;


namespace QuanLySieuThi.DataModel
{
    public partial class ChiTietPhieuXuat
    {
        public string SoPhieuXuat { get; set; }
        public string MaHangHoa { get; set; }
        public Nullable<decimal> DonGiaXuat { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }
}
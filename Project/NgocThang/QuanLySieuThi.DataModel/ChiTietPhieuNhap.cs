using System;

namespace QuanLySieuThi.DataModel
{

    public partial class ChiTietPhieuNhap
    {
        public string SoPhieuNhap { get; set; }
        public string MaHangHoa { get; set; }
        public int MaNhaCungCap { get; set; }
        public Nullable<decimal> DonGiaNhap { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }
}

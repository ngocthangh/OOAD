using System;


namespace QuanLySieuThi.DataModel
{
    public partial class HangHoa
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public Nullable<decimal> GiaNhap { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> SoLuongQuay { get; set; }
        public string MaLoaiHang { get; set; }
        public string MaDVT { get; set; }
    }
}

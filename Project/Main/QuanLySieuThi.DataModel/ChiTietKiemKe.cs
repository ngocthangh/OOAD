using System;

namespace QuanLySieuThi.DataModel
{ 
    public partial class ChiTietKiemKe
    {
        public string SoPhieuKiemKe { get; set; }
        public string MaHangHoa { get; set; }
        public Nullable<int> SLTonTrenQuay { get; set; }
        public Nullable<int> SLTonTrongKho { get; set; }
    }
}

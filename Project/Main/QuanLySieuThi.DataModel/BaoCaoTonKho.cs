using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataModel
{
    public class BaoCaoTonKho
    {
        public int MaBaoCaoTonKho { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public int Nam { get; set; }
        public int Thang { get; set; }
    }
}

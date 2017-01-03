using System;

namespace QuanLySieuThi.DataModel
{
    public partial class ThamSo
    {
        public ThamSo(string tenthamso, int giatri)
        {
            TenThamSo = tenthamso;
            GiaTri = giatri;
        }
        public string TenThamSo { get; set; }
        public int GiaTri { get; set; }

    }
}

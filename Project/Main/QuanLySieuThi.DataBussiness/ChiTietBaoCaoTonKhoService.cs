using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataBussiness
{
    public class ChiTietBaoCaoTonKhoService
    {
        private static readonly ChiTietBaoCaoTonKhoController Controller = new ChiTietBaoCaoTonKhoController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }


        public static bool Insert(ChiTietBaoCaoTonKho ctBaoCaoTonKho)
        {
            return Controller.Insert(ctBaoCaoTonKho);
        }
        public static bool Delete(string maBaoCaoTonKho)
        {
            return Controller.Delete(maBaoCaoTonKho);
        }

        public static DataTable GetById(int maBaoCaoTonKho)
        {
            return Controller.GetById(maBaoCaoTonKho);
        }
    }
}

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
    public class BaoCaoTonKhoService
    {
        private static readonly BaoCaoTonKhoController Controller = new BaoCaoTonKhoController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }
        
        public static int Insert(BaoCaoTonKho bcTonKho)
        {
            return Controller.Insert(bcTonKho);
        }
        public static bool Delete(string bcTonKho)
        {
            return Controller.Delete(bcTonKho);
        }
        public static DataTable GetById(int id)
        {
            return Controller.GetById(id);
        }
        public static DataTable GetByMonthYear(int thang, int nam)
        {
            return Controller.GetByMonthYear(thang, nam);
        }
    }
}

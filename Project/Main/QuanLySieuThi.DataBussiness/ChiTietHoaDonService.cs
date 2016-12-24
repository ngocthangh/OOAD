using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataModel;
using QuanLySieuThi.DataAccess;

namespace QuanLySieuThi.DataBussiness
{
    public class ChiTietHoaDonService
    {
        private static readonly ChiTietHoaDonController Controller = new ChiTietHoaDonController();
        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }
        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }
        public static bool Insert(ChiTietHoaDon cthd)
        {
            return Controller.Insert(cthd);
        }
        public static bool Update(ChiTietHoaDon cthd)
        {
            return Controller.Update(cthd);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static bool Delete(string mahoadon)
        {
            return Controller.Delete(mahoadon);
        }
    }
}

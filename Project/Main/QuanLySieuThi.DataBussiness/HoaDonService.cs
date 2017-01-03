using QuanLySieuThi.DataModel;
using QuanLySieuThi.DataAccess;
using System.Data;
using System;

namespace QuanLySieuThi.DataBussiness
{
    public class HoaDonService
    {
        private static readonly HoaDonController Controller = new HoaDonController();
        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }
        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }
        public static bool Insert(HoaDon hoadon)
        {
            return Controller.Insert(hoadon);
        }
        public static bool Update(HoaDon hoadon)
        {
            return Controller.Update(hoadon);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static bool Delete(string mahoadon)
        {
            return Controller.Delete(mahoadon);
        }
        public static DataTable Search(string key = null, Nullable<DateTime> dateStart = null, Nullable<DateTime> dateEnd = null)
        {
            return Controller.Search(key, dateStart, dateEnd);
        }
    }
}

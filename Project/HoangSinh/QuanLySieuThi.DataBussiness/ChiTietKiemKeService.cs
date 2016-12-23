using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DataAccess;
using System.Data;
using QuanLySieuThi.DataModel;
namespace QuanLySieuThi.DataBussiness
{
    public class ChiTietKiemKeService
    {
        private static readonly ChiTietKiemKeController Controller = new ChiTietKiemKeController();
        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }
        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }
        public static bool Insert(ChiTietKiemKe ctkk)
        {
            return Controller.Insert(ctkk);
        }
        public static bool Update(ChiTietKiemKe ctkk)
        {
            return Controller.Update(ctkk);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static bool Delete(string maphieukiemke)
        {
            return Controller.Delete(maphieukiemke);
        }
    }
}

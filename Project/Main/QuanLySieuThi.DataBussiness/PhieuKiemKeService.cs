using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
namespace QuanLySieuThi.DataBussiness
{
    public class PhieuKiemKeService
    {
        private static readonly PhieuKiemKeController Controller = new PhieuKiemKeController();
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
        public static bool Insert(PhieuKiemKe phieukiemke)
        {
            return Controller.Insert(phieukiemke);
        }
        public static bool Update(PhieuKiemKe phieukiemke)
        {
            return Controller.Update(phieukiemke);
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

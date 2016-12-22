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
    public class PhieuXuatService
    {
        private static readonly PhieuXuatController Controller = new PhieuXuatController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }

        public static bool Insert(PhieuXuat phieuXuat)
        {
            return Controller.Insert(phieuXuat);
        }
        public static bool Update(PhieuXuat phieuXuat)
        {
            return Controller.Update(phieuXuat);
        }

        public static bool Delete(string soPhieuXuat)
        {
            return Controller.Delete(soPhieuXuat);
        }


        public static DataTable GetById(string id)
        {
            //return Controller.GetById(id);
            return null;
        }
        public static DataTable Search(string key = null, Nullable<DateTime> dateStart = null, Nullable<DateTime> dateEnd = null)
        {
            return Controller.Search(key, dateStart, dateEnd);
        }
    }
}

using QuanLySieuThi.DataModel;
using QuanLySieuThi.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataBussiness
{
    public class PhieuNhapService
    {
        private static readonly PhieuNhapController Controller = new PhieuNhapController();

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

        public static bool Insert(PhieuNhap phieuNhap)
        {
            return Controller.Insert(phieuNhap);
        }
        public static bool Update(PhieuNhap phieuNhap)
        {
            return Controller.Update(phieuNhap);
        }

        public static bool Delete(string soPhieuNhap)
        {
            return Controller.Delete(soPhieuNhap);
        }


        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
        public static DataTable Search(string key = null, Nullable<DateTime> dateStart = null, Nullable<DateTime> dateEnd = null)
        {
            return Controller.Search(key, dateStart, dateEnd);
        }
    }
}

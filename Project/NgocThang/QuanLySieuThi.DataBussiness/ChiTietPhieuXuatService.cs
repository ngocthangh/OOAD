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
    public class ChiTietPhieuXuatService
    {
        private static readonly ChiTietPhieuXuatController Controller = new ChiTietPhieuXuatController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }


        public static bool Insert(ChiTietPhieuXuat ctPhieuXuat)
        {
            return Controller.Insert(ctPhieuXuat);
        }
        public static bool Update(ChiTietPhieuXuat ctPhieuXuat)
        {
            return Controller.Update(ctPhieuXuat);
        }
        public static bool Delete(string soPhieuXuat)
        {
            return Controller.Delete(soPhieuXuat);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
    }
}

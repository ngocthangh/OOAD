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
    public class ChiTietPhieuNhapService
    {
        private static readonly ChiTietPhieuNhapController Controller = new ChiTietPhieuNhapController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }


        public static bool Insert(ChiTietPhieuNhap ctPhieuNhap)
        {
            return Controller.Insert(ctPhieuNhap);
        }
        public static bool Update(ChiTietPhieuNhap ctPhieuNhap)
        {
            return Controller.Update(ctPhieuNhap);
        }
        public static bool Delete(string soPhieuNhap)
        {
            return Controller.Delete(soPhieuNhap);
        }

        public static DataTable GetById(string id)
        {
            //return Controller.GetById(id);
            return null;
        }
    }
}

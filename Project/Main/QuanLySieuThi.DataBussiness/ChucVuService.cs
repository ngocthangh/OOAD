using System.Data;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.DataBussiness
{
    public class ChucVuService
    {
        private static readonly ChucVuController Controller = new ChucVuController();
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
        public static bool Insert(ChucVu chucvu)
        {
            return Controller.Insert(chucvu);
        }
        public static bool Update(ChucVu chucvu)
        {
            return Controller.Update(chucvu);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
    }

}
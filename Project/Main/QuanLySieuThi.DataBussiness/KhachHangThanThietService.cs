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
    public class KhachHangThanThietService
    {
        private static readonly KhachHangThanThietController Controller = new KhachHangThanThietController();
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
        public static bool Insert(KhachHangThanThiet khtt)
        {
            return Controller.Insert(khtt);
        }
        public static bool Update(KhachHangThanThiet khtt)
        {
            return Controller.Update(khtt);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static DataTable SearchMaKhachHang(string key)
        {
            return Controller.SearchMaKhachHang(key);
        }
        public static DataTable Search(string key)
        {
            return Controller.Search(key);
        }
        public static KhachHangThanThiet GetDataFromRowSelected(string ID)
        {
            return Controller.GetDataFromRowSelected(ID);
        }
    }
}

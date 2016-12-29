using System;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class LoaiHangService
    {
        private static readonly  LoaiHangController Controller = new LoaiHangController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Insert(LoaiHang loaihang)
        {
            return Controller.Insert(loaihang);
        }

        public static bool Update(LoaiHang loaihang)
        {
            return Controller.Update(loaihang);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
        public static DataTable GetByChungLoai(int machungloai)
        {
            return Controller.GetByChungLoai(machungloai);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static DataTable Search(string key)
        {
            return Controller.Search(key);
        }
    }
}

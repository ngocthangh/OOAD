using System;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class HangHoaService
    {
        private static readonly HangHoaController Controller = new HangHoaController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Insert(HangHoa hanghoa)
        {
            return Controller.Insert(hanghoa);
        }

        public static bool Update(HangHoa hanghoa)
        {
            return Controller.Update(hanghoa);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
        public static DataTable GetByLoaiHang(int maloaihang)
        {
            return Controller.GetByLoaiHang(maloaihang);
        }
        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
        public static DataTable Search(string key)
        {
            return Controller.Search(key);
        }
        public static DataTable Search1(string key = null, Nullable<int> loaiHang = null, Nullable<int> slTonTu = null, Nullable<int> slTonDen = null, Nullable<int> slQuayTu = null, Nullable<int> slQuayDen = null)
        {
            return Controller.Search1(key, loaiHang, slTonTu, slTonDen, slQuayTu, slQuayDen);
        }
        public static bool NhapHang(string maHangHoa, int soLuong)
        {
            return Controller.NhapHang(maHangHoa, soLuong);
        }
        public static bool XuatQuay(string maHangHoa, int soLuong)
        {
            return Controller.XuatQuay(maHangHoa, soLuong);
        }

        public static bool XuatTra(string maHangHoa, int soLuong)
        {
            return Controller.XuatTra(maHangHoa, soLuong);
        }
        public static bool Delete(string maHangHoa)
        {
            return Controller.Delete(maHangHoa);
        }
    }
}

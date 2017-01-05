using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.DataAccess
{
    public class HoaDonController
    {
        private readonly Connector _connect;
        public HoaDonController()
        {
            _connect = new Connector("HOADON");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_HOADON_GETALL");
        }
        public DataTable GetById(string mahoadon)
        {
            return _connect.LoadData("SP_HOADON_GETBYID", new[] { "SoHoaDon" }, new object[] { mahoadon }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(HoaDon hoadon)
        {
            return _connect.Update(hoadon);
        }
        public bool Update(HoaDon hoadon)
        {
            return _connect.Update("SP_HOADON_UPD", hoadon);
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_HOADON_AUTOGENERATEID");
        }
        public bool Delete(string mahoadon)
        {
            return _connect.Delete("SP_CHITIETHOADON_DEL", "SoHoaDon", mahoadon);
        }
        public DataTable Search(string key = null, Nullable<DateTime> dateStart = null, Nullable<DateTime> dateEnd = null)
        {
            return _connect.LoadData("SP_HOADON_SEARCH", new[] { "@key", "@dateStart", "@dateEnd" }, new object[] { key, dateStart, dateEnd }, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.DataAccess
{
    public class ChiTietHoaDonController
    {
        
        private readonly Connector _connect;
        public ChiTietHoaDonController()
        {
            _connect = new Connector("CHITIETHOADON");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHITIETHOADON_GETALL");
        }
        public DataTable GetById(string mahoadon)
        {
            return _connect.LoadData("SP_CHITIETHOADON_GETBYID", new[] { "SoHoaDon" }, new object[] { mahoadon }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(ChiTietHoaDon cthd)
        {
            return _connect.Update(cthd);
        }
        public bool Update(ChiTietHoaDon cthd)
        {
            return _connect.Update("SP_CHITIETHOADON_UPD", cthd);
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_CHITIETHOADON_AUTOGENERATEID");
        }
        public bool Delete(string mahoadon)
        {
            return _connect.Delete("SP_CHITIETHOADON_DEL", "SoHoaDon", mahoadon);
        }
    
    }
}

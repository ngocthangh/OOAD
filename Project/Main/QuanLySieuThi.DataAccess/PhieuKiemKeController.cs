using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataModel;
namespace QuanLySieuThi.DataAccess
{
    public class PhieuKiemKeController
    {
        private readonly Connector _connect;
        public PhieuKiemKeController()
        {
            _connect = new Connector("PHIEUKIEMKE");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_PHIEUKIEMKE_GETALL");
        }
        public DataTable GetById(string maphieukiemke)
        {
            return _connect.LoadData("SP_PHIEUKIEMKE_GETBYID", new[] { "MaPhieuKiemKe" }, new object[] { maphieukiemke }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(PhieuKiemKe phieukiemke)
        {
            return _connect.Update(phieukiemke);
        }
        public bool Update(PhieuKiemKe phieukiemke)
        {
            return _connect.Update("SP_PHIEUKIEMKE_UPD", phieukiemke);
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_PHIEUKIEMKE_AUTOGENERATEID");
        }
        public bool Delete(string maphieukiemke)
        {
            return _connect.Delete("SP_PHIEUKIEMKE_DEL", "MaPhieuKiemKe", maphieukiemke);
        }
    }
}

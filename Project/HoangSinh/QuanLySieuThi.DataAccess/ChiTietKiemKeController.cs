using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataAccess
{
    public class ChiTietKiemKeController
    {
        private readonly Connector _connect;
        public ChiTietKiemKeController()
        {
            _connect = new Connector("CHITIETKIEMKE");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHITIETKIEMKE_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(ChiTietKiemKe ctkk)
        {
            return _connect.Update(ctkk);
        }
        public bool Update(ChiTietKiemKe ctkk)
        {
            return _connect.Update("SP_CHITIETKIEMKE_UPD", ctkk) == 1;
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_CHITIETKIEMKE_AUTOGENERATEID");
        }
        public bool Delete(string maphieukiemke)
        {
            return _connect.Delete("SP_CHITIETKIEMKE_DEL", "MaPhieuKiemKe", maphieukiemke);
        }
    }
}

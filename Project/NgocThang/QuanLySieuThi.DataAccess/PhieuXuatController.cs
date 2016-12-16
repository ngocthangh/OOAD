using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class PhieuXuatController
    {
        private readonly Connector _connect;

        public PhieuXuatController()
        {
            _connect = new Connector("PHIEUXUAT");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_PHIEUXUAT_AUTOGENERATEID");
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_PHIEUXUAT_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(PhieuXuat phieuXuat)
        {
            return _connect.Update("SP_PHIEUXUAT_INS", phieuXuat);
        }

        public bool Update(PhieuXuat phieuXuat)
        {
            return _connect.Update("SP_PHIEUXUAT_UPD", phieuXuat);
        }
        public bool Delete(string soPhieuXuat)
        {
            return _connect.Delete("SP_PHIEUXUAT_DEL", "SoPhieuXuat", soPhieuXuat);
        }
    }
}

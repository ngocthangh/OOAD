using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class ChiTietPhieuXuatController
    {
        private readonly Connector _connect;

        public ChiTietPhieuXuatController()
        {
            _connect = new Connector("CHITIETPHIEUXUAT");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHITIETPHIEUXUAT_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(ChiTietPhieuXuat phieuXuat)
        {
            return _connect.Update("SP_CHITIETPHIEUXUAT_INS", phieuXuat);
        }

        public bool Update(ChiTietPhieuXuat phieuXuat)
        {
            return _connect.Update("SP_CHITIETPHIEUXUAT_UPD", phieuXuat);
        }

        public bool Delete(string soPhieuXuat)
        {
            return _connect.Delete("SP_CHITIETPHIEUXUAT_DEL", "SoPhieuXuat", soPhieuXuat);
        }
    }
}

using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class ThamSoController
    {
        private readonly Connector _connect;

        public ThamSoController()
        {
            _connect = new Connector("THAMSO");
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_THAMSO_GETALL");
        }
        public DataTable GetById(string id)
        {
            return _connect.LoadData("SP_THAMSO_GETBYID", new[] { "@TenThamSo" }, new object[] { id }, 1);
        }
        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Update(ThamSo thamso)
        {
            return _connect.Update("SP_THAMSO_UPD", thamso);
        }
    }
}

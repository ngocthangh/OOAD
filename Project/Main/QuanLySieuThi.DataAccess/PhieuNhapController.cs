using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class PhieuNhapController
    {
        private readonly Connector _connect;

        public PhieuNhapController()
        {
            _connect = new Connector("PHIEUNHAP");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_PHIEUNHAP_AUTOGENERATEID");
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_PHIEUNHAP_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        
        public bool Insert(PhieuNhap phieuNhap)
        {
            return _connect.Update("SP_PHIEUNHAP_INS", phieuNhap);
        }
        
        public bool Update(PhieuNhap phieuNhap)
        {
            return _connect.Update("SP_PHIEUNHAP_UPD", phieuNhap);
        }
        public bool Delete(string soPhieuNhap)
        {
            return _connect.Delete("SP_PHIEUNHAP_DEL", "SoPhieuNhap", soPhieuNhap);
        }
        public DataTable Search(string key = null, Nullable<DateTime> dateStart = null, Nullable<DateTime> dateEnd = null)
        {
            return _connect.LoadData("SP_PHIEUNHAP_SEARCH", new[] { "@key", "@dateStart", "@dateEnd" }, new object[] { key, dateStart, dateEnd }, 3);
        }
        public DataTable GetById(string soPhieu)
        {
            return _connect.LoadData("SP_PHIEUNHAP_IN", new[] { "@SoPhieuNhap"}, new object[] { soPhieu}, 1);
        }
    }
}

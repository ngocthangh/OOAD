using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class ChiTietPhieuNhapController
    {
        private readonly Connector _connect;

        public ChiTietPhieuNhapController()
        {
            _connect = new Connector("CHITIETPHIEUNHAP");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHITIETPHIEUNHAP_GETALL");
        }
        public DataTable GetById(string soPhieuNhap)
        {
            return _connect.LoadData("SP_CHITIETPHIEUNHAP_GETBYID", new[] { "@SoPhieuNhap" }, new object[] { soPhieuNhap }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(ChiTietPhieuNhap phieuNhap)
        {
            return _connect.Update("SP_CHITIETPHIEUNHAP_INS", phieuNhap);
        }

        public bool Update(ChiTietPhieuNhap phieuNhap)
        {
            return _connect.Update("SP_CHITIETPHIEUNHAP_UPD", phieuNhap);
        }

        public bool Delete(string soPhieuNhap)
        {
            return _connect.Delete("SP_CHITIETPHIEUNHAP_DEL", "SoPhieuNhap", soPhieuNhap);
        }
    }
}

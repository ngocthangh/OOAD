using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class ChiTietBaoCaoTonKhoController
    {
        private readonly Connector _connect;

        public ChiTietBaoCaoTonKhoController()
        {
            _connect = new Connector("CHITIETBAOCAOTONKHO");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHITIETBAOCAOTONKHO_GETALL");
        }
        public DataTable GetById(int maBaoCaoTonKho)
        {
            return _connect.LoadData("SP_CHITIETBAOCAOTONKHO_GETBYID", new[] { "@MaBaoCaoTonKho" }, new object[] { maBaoCaoTonKho }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(ChiTietBaoCaoTonKho ctbcTonKho)
        {
            return _connect.Update("SP_CHITIETBAOCAOTONKHO_INS", ctbcTonKho);
        }
        
        public bool Delete(string maBaoCaoTonKho)
        {
            return _connect.Delete("SP_CHITIETBAOCAOTONKHO_DEL", "MaBaoCaoTonKho", maBaoCaoTonKho);
        }
    }
}

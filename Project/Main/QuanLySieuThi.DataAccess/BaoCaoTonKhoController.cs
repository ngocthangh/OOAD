using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class BaoCaoTonKhoController
    {
        private readonly Connector _connect;

        public BaoCaoTonKhoController()
        {
            _connect = new Connector("BAOCAOTONKHO");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_BAOCAOTONKHO_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public int Insert(BaoCaoTonKho bcTonKho)
        {
            return _connect.InsertGetId("SP_BAOCAOTONKHO_INS", bcTonKho, "@MaBaoCaoTonKho");
        }

        public bool Delete(string maBaoCao)
        {
            return _connect.Delete("SP_BAOCAOTONKHO_DEL", "SoBAOCAOTONKHO", maBaoCao);
        }
        public DataTable GetByMonthYear(int thang, int nam)
        {
            return _connect.LoadData("SP_BAOCAOTONKHO_GETBYMONTHYEAR", new[] { "@Thang", "@Nam"}, new object[] { thang, nam}, 2);
        }
    }
}

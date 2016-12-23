using System.Data;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.DataAccess
{

    public class ChucVuController
    {
        private readonly Connector _connect;
        public ChucVuController()
        {
            _connect = new Connector("CHUCVU");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHUCVU_GETALL");
        }
        public DataTable GetById(string machucvu)
        {
            return _connect.LoadData("SP_CHUCVU_GETBYID", new[] { "MaChucVu" }, new object[] { machucvu }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(ChucVu chucvu)
        {
            return _connect.Update(chucvu);
        }
        public bool Update(ChucVu chucvu)
        {
            return _connect.Update("SP_CHUCVU_UPD", chucvu) == 1;
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_CHUCVU_AUTOGENERATEID");
        }
    }
}

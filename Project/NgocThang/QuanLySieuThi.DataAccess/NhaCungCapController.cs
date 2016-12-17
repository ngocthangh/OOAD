using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataAccess
{
    public class NhaCungCapController
    {
        private readonly Connector _connect;

        public NhaCungCapController()
        {
            _connect = new Connector("NHACUNGCAP");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_NHACUNGCAP_GETALL");
        }

        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public DataTable GetById(string maNhaCungCap)
        {
            return _connect.LoadData("SP_NHACUNGCAP_GETBYID", new[] { "@MaNhaCungCap" }, new object[] { maNhaCungCap }, 1);
        }

        public bool Insert(NhaCungCap nhaCungCap)
        {
            return _connect.Update(nhaCungCap);
        }

        public bool Update(NhaCungCap nhaCungCap)
        {
            return _connect.Update("SP_NHACUNGCAP_UPD", nhaCungCap);
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_NHACUNGCAP_AUTOGENERATEID");
        }
        public DataTable Search(string key)
        {
            return _connect.Search("SP_NHACUNGCAP_SEARCH", key);
        }
    }
 }

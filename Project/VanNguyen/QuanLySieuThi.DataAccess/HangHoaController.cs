using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataAccess
{
    public class HangHoaController
    {
        private readonly Connector _connect;

        public HangHoaController()
        {
            _connect = new Connector("HANGHOA");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_HANGHOA_GETALL");
        }

        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(HangHoa hanghoa)
        {
            return _connect.Update(hanghoa);
        }

        public DataTable GetById(string mahanghoa)
        {
            return _connect.LoadData("SP_HANGHOA_GETBYID", new[] { "@MaHangHoa" }, new object[] { mahanghoa }, 1);
        }

        public bool Update(HangHoa hanghoa)
        {
            return _connect.Update("SP_HANGHOA_UPD", hanghoa) == 1;
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_HANGHOA_AUTOGENERATEID");
        }
        public DataTable Search(string key)
        {
            return _connect.Search("SP_HANGHOA_SEARCH", key);
        }
        public bool Delete(string maHangHoa)
        {
            try
            {
                _connect.Delete("SP_HANGHOA_DEL", "MaHangHoa", maHangHoa);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}

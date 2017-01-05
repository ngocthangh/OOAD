using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThi.DataModel;
using System.Data.SqlClient;

namespace QuanLySieuThi.DataAccess
{
    public class KhachHangThanThietController
    {
        private readonly Connector _connect;
        public KhachHangThanThietController()
        {
            _connect = new Connector("KHACHHANGTHANTHIET");
        }
        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_KHACHHANGTHANTHIET_GETALL");
        }
        public DataTable GetById(string makhachhang)
        {
            return _connect.LoadData("SP_KHACHHANGTHANTHIET_GETBYID", new[] { "MaKhachHang" }, new object[] { makhachhang }, 1);
        }
        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }
        public bool Insert(KhachHangThanThiet khtt)
        {
            return _connect.Update(khtt);
        }
        public bool Update(KhachHangThanThiet khtt)
        {
            return _connect.Update("SP_KHACHHANGTHANTHIET_UPD", khtt);
        }
        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_KHACHHANGTHANTHIET_AUTOGENERATEID");
        }
        public DataTable SearchMaKhachHang(string key)
        {
            return _connect.Search("SP_KHACHHANGTHANTHIET_SEARCHMAKHACHHANG",key);
        }
        public KhachHangThanThiet GetDataFromRowSelected(string ID)
        {
            _connect.open();
            KhachHangThanThiet khtt=new KhachHangThanThiet();
            string sql;
            sql=string.Format("SELECT * FROM KHACHHANGTHANTHIET WHERE MaKhachHang =  '{0}'",ID) ;
            SqlDataReader reader = _connect.GetDataFromRowSelected(sql);
            while(reader.Read())
            {
                khtt.MaKhachHang = reader[0].ToString();
                khtt.HoTen = reader[1].ToString();
                khtt.DiaChi = reader[2].ToString();
                khtt.CMND = reader[3].ToString();
                khtt.NgayCapThe = Convert.ToDateTime(reader[4].ToString());
                khtt.DiemThuong = Convert.ToInt32(reader[5].ToString());
            }
            _connect.close();
            return khtt;
        }
        public DataTable Search(string key)
        {
            return _connect.Search("SP_KHACHHANGTHANTHIET_SEARCH", key);
        }
    }
}

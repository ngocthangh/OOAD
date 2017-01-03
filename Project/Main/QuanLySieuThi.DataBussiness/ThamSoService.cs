using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataBussiness
{
    public class ThamSoService
    {
        private static readonly ThamSoController Controller = new ThamSoController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Update(ThamSo thamso)
        {
            return Controller.Update(thamso);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
    }
}

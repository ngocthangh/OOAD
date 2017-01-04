using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class BackupDatabaseController
    {
        private readonly Connector _connect;
        public BackupDatabaseController()
        {
            _connect = new Connector("LOAIHANG");
        }
        public bool BackupDatabase()
        {
            return _connect.BackupDatabase();
        }
        public bool RestoreDatabase()
        {
            return _connect.RestoreDatabase();
        }
    }
}

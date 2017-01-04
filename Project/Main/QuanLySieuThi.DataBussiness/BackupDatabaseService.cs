using QuanLySieuThi.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataBussiness
{
    public class BackupDatabaseService
    {
        private static readonly BackupDatabaseController Controller = new BackupDatabaseController();
        public static bool BackupDatabase()
        {
            return Controller.BackupDatabase();
        }
        public static bool RestoreDatabase()
        {
            return Controller.RestoreDatabase();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.CRUD
{
    class Connection
    {
        static string dbPath = @"C:\Users\dmin\Documents\Database1.accdb";
        public static string conString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);
        }
        public static OleDbConnection con = mysqldb();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Test_Project_v1._0
{
    internal class Connection
    {
        public static MySqlConnection conn = new MySqlConnection();

        static string server = "srv1319.hstgr.io;";
        static string database = "u865665685_Test;";
        static string username = "u865665685_test;";
        static string password = "Wea_dayaday05;";

        public static MySqlConnection dataSource()
        {
            conn = new MySqlConnection($"server={server} database={database} username={username} password={password}");
            return conn;
        }

        public void connOpen()
        {
            dataSource();
            conn.Open();
        }
        public void connClose()
        {
            dataSource();
            conn.Close();
        }
    }
}

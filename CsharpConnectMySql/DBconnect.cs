using MySql.Data.MySqlClient;

namespace CsharpConnectMySql
{
    class DBconnect
    {
        private static string server;
        private static string database;
        private static string id;
        private static string pass;

        public static MySqlConnection Connection()
        {
            server = "localhost";
            database = "user";
            id = "root";
            pass = "";

            string url = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + id + ";" + "PASSWORD=" + pass + ";";
            MySqlConnection connect = new MySqlConnection(url);
            return connect;
        }
    }
}

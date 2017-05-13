using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpConnectMySql
{
    class DML
    {
        public MySqlConnection cnt;
        private MySqlCommand cmd;
        public void Insert()
        {
            User u = new User();
            Console.WriteLine("Please add Name: ");
            u.name = Console.ReadLine();
            Console.WriteLine("Please add Password: ");
            u.pass = Console.ReadLine();

            string slt = "INSERT INTO user VALUES ('','" + u.name + "','" + u.pass + "')";
            cnt = DBconnect.Connection();
            cnt.Open();
            MySqlCommand cmd = new MySqlCommand(slt, cnt);
            cmd.ExecuteNonQuery();
            Console.WriteLine("*************");
            Console.WriteLine("Update Succes");
            Console.WriteLine("*************");
            cnt.Close();
        }
        public void Show()
        {
            string show = "SELECT * FROM user";
            cnt = DBconnect.Connection();
            cnt.Open();
            MySqlCommand cmd = new MySqlCommand(show, cnt);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //string row = "";
                //for(int i = 0; i < reader.FieldCount; i++)
                //{
                //row += reader.GetValue(i).ToString() + ", ";
                //}
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string pass = reader.GetString(2);

                Console.WriteLine("****************************************************");
                Console.WriteLine("ID = {0}, NAME = {1}, PASSWORD = {2}", id, name, pass);
                Console.WriteLine("****************************************************");
            }
            cnt.Close();
        }
        public void Update()
        {
            Console.WriteLine("Please input ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if(id != 0)
            {
                Console.WriteLine("Please input new name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please input new password: ");
                string pass = Console.ReadLine();
                string upd = "UPDATE user SET NAME = '" + name + "', PASSWORD = '" + pass + "' WHERE ID = '" + id + "'";

                cnt = DBconnect.Connection();
                cnt.Open();
                MySqlCommand cmd = new MySqlCommand(upd, cnt);
                cmd.ExecuteNonQuery();
                Console.WriteLine("*************");
                Console.WriteLine("Update Succes");
                Console.WriteLine("*************");
                cnt.Close();
            }
            else
            {
                Console.WriteLine("!!!Error!!!");
            }   
        }
        public void Delete()
        {
            Console.WriteLine("Please input ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id != 0)
            {
                string del = "DELETE FROM user WHERE ID = '" + id +"'";
                cnt = DBconnect.Connection();
                cnt.Open();
                MySqlCommand cmd = new MySqlCommand(del, cnt);
                cmd.ExecuteNonQuery();
                Console.WriteLine("*************");
                Console.WriteLine("Delete Succes");
                Console.WriteLine("*************");
                cnt.Close();
            }
            else
            {
                Console.WriteLine("!!!Error!!!");
            }
        }
    }
}

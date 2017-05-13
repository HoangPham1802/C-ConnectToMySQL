using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpConnectMySql
{
    class Program
    {
        static void Main(String[] args) {
            Menu();
        }

        static void Menu() {
            while (true)
            {
                int choice;
                Console.WriteLine("============Menu=============");
                Console.WriteLine("========1.Add new User=======");
                Console.WriteLine("========2.Display User=======");
                Console.WriteLine("========3.Modify User =======");
                Console.WriteLine("========4.Delete User =======");
                Console.WriteLine("========5.Exit        =======");
                Console.WriteLine("=============================");

                choice = int.Parse(Console.ReadLine());
                DML dml = new DML();
                switch (choice)
                {
                    case 1:
                        dml.Insert();
                        break;
                    case 2:
                        dml.Show();
                        break;
                    case 3:
                        dml.Update();
                        break;
                    case 4:
                        dml.Delete();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

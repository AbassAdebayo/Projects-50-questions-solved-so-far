using MySql.Data.MySqlClient;
using StudentApp.Manager;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentApp
{
    class Program
    {
        delegate void PrintMenuDelegate();

        static StudentManager studentManager;
        static AddressManager addressManager;
        static void Main(string[] args)
        {
            var connectionString = "server=localhost;user=root;database=studentapp;password=07038386817Akani";
            MySqlConnection connection = new MySqlConnection(connectionString);
            studentManager = new StudentManager(connection);
            addressManager = new AddressManager(connection);
            Run();
        }

        static void Run()
        {
            bool flag;
            PrintMenuDelegate printMenu = new(PrintMenu);
            do
            {
                PrintMenu();
                var option = HandleSelections(Console.ReadLine(), printMenu);
                flag = HandleMenuOption(option);
            }
            while (flag);
            Console.WriteLine("Thank you for using our app");
        }


        static void PrintMenu()
        {
            Console.WriteLine("Enter 1 To Register a student");
            Console.WriteLine("Enter 2 To Update a student Record");
            Console.WriteLine("Enter 3 To List All Students");
            Console.WriteLine("Enter 4 To Delete Student Record");
            Console.WriteLine("Enter 5 To Find Student");
            Console.WriteLine("Enter 6 To Register Address");
            Console.WriteLine("Enter 7 To Update Address");
            Console.WriteLine("Enter 8 To List All Address");
            Console.WriteLine("Enter 9 To Delete Address");
            Console.WriteLine("Enter 10 To Find Address");
            Console.WriteLine("Enter 0 to end");
        }

        static bool HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    studentManager.Create();
                    return true;
                case 2:
                    studentManager.Update();
                    return true;
                case 3:
                    studentManager.List();
                    return true;
                case 4:
                    studentManager.Delete();
                    return true;
                case 5:
                    studentManager.Find();
                    return true;
                case 6:
                    addressManager.Create();
                    return true;
                case 7:
                    addressManager.Update();
                    return true;
                case 8:
                    addressManager.List();
                    return true;
                case 9:
                    addressManager.Delete();
                    return true;
                case 10:
                    addressManager.Find();
                    return true;
                case 0:
                    return false;
                default:
                    return false;
            }
        }

        static int HandleSelections(string selcetion, PrintMenuDelegate printMenu)
        {
            bool result = int.TryParse(selcetion, out int action);
            while (result == false)
            {
                Console.WriteLine("Try again!");
                printMenu();
                result = int.TryParse(Console.ReadLine(), out action);
            }
            return action;
        }
    }
}

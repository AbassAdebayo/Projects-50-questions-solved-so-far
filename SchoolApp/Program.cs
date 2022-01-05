using System;
using MySql.Data.MySqlClient;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString= "server=localhost;user=root;database=schoolapp2;password=DefinedCode";
            using(MySqlConnection myConnection= new MySqlConnection(connectionString))
            {
            myConnection.Open();
            MySqlCommand sqlCommand2 = new MySqlCommand ("insert into student(firstName, lastName, email, phoneNum, regNum, gender) values('Ade', 'Bola', 'adebola@ymail.com', '08132001513', '20014AJ', 'Female')", myConnection);
            var result= sqlCommand2.ExecuteNonQuery();
            Console.WriteLine("Connection successfully created");

            MySqlCommand mysqlCommand = new MySqlCommand("select * from student", myConnection);
            var reader = mysqlCommand.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"The FirstName is {reader[0]}, lastName is {reader[1]}, email is {reader[2]}, and the phoneNum is {reader[3]}");
            }
            
            };
           

        }
    }
}

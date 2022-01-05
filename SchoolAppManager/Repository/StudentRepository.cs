using System.Reflection.Metadata;
using System;
using MySql.Data.MySqlClient;

namespace StudentApp
{
    public class StudentRepository
    {
        MySqlConnection Connection { get; set; }

        public StudentRepository(MySqlConnection connection)
        {
            Connection = connection;
        }

        public bool Create(Student student)
        {
            string query = $"insert into student (firstName, lastName, email, phoneNumber, regNumber, DateOfRegistration, age, gender) value ('{student.FirstName}', '{student.LastName}', '{student.Email}', '{student.PhoneNumber}', '{student.RegNumber}', '{student.DateOfRegistration.ToString("yyyy-MM-dd HH:MM:ss")}', '{student.Age}', '{student.Gender}')";
            int result = 0;
            try
            {
                Connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return result == 1 ? true : false;
        }

        public void List()
        {
            string query = "select * from student";
            try
            {
                Connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"Student {count}\n\tFirst Name: {reader["firstName"]}\n\tLast Name: {reader["lastName"]}\n\tReg Number: {reader["regNumber"]}\n\tEmail: {reader["email"]}");
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool Update(Student student)
        {
            string query = $"update student SET firstName = '{student.FirstName}', lastName = '{student.LastName}', email = '{student.Email}', age = '{student.Age}', phoneNumber = '{student.PhoneNumber}' where regNumber = '{student.RegNumber}'";
            int result = 0;
            try
            {
                Connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                result = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return result == 1 ? true : false;
        }

        public void Find(string regNumber)
        {
            try
            {
                Connection.Open();
                string query = $"select * from student where regNumber = '{regNumber}'";
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"Student {count}\n\tFirst Name: {reader["firstName"]}\n\tLast Name: {reader["lastName"]}\n\tReg Number: {reader["regNumber"]}\n\tEmail: {reader["email"]}");
                    count++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

        }

        public string FindByRegNumber(string regNumber)
        {
            string result = " ";
            try
            {
                Connection.Open();
                string query = $"select * from student where regNumber = '{regNumber}'";
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    result = $"{reader["firstName"]}\t{reader["lastName"]}\t{reader["email"]}\t{reader["phoneNumber"]}\t{reader["age"]}\t{reader["gender"]}\t{reader["regNumber"]}\t{reader["dateOfRegistration"]}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }

        public bool Delete(string regNumber)
        {
            string query = $"delete from student where regNumber = '{regNumber}'";
            int result = 0;
            try
            {
                Connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                result = mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return result == 1 ? true : false;
        }
    }
}
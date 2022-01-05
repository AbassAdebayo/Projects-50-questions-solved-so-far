using System;
using MySql.Data.MySqlClient;

namespace StudentApp
{
    public class AddressRepository
    {
        MySqlConnection Connection;

        public AddressRepository(MySqlConnection sqlConnection)
        {
            Connection = sqlConnection;
        }

        public bool Create(Address address)
        {
            string query = $"insert into Address (zipcode, street, city, Addressline, state, country, studentId) value ('{address.Zipcode}','{address.Street}', '{address.City}', '{address.AddressLine}', '{address.State}', '{address.Country}', '{address.RegNumber}')";
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



        public bool Update(Address address)
        {
            string query = $"update Address SET zipcode = '{address.Zipcode}', street = '{address.Street}', city = '{address.City}', AddressLine = '{address.AddressLine}', State = '{address.State}' Country = '{address.Country}'  where regNumber = '{address.RegNumber}'";
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
                string query = $"select * from address where regNumber = '{regNumber}'";
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"Address {count}\n\tFirst Name: {reader["firstName"]}\n\tLast Name: {reader["lastName"]}\n\tReg Number: {reader["regNumber"]}\n\tEmail: {reader["email"]}");
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

        public void List()
        {
            string query = "select * from address";
            try
            {
                Connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"Address {count}\n\tFirst Name: {reader["firstName"]}\n\tLast Name: {reader["lastName"]}\n\tReg Number: {reader["regNumber"]}\n\tEmail: {reader["email"]}");
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

        public bool Delete(string regNumber)
        {
            string query = $"delete from address where regNumber = '{regNumber}'";
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

        public string FindByRegNumber(string regNumber)
        {
            string result = " ";
            try
            {
                Connection.Open();
                string query = $"select * from address where regNumber = '{regNumber}'";
                MySqlCommand sqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    result = $"{reader["zipcode"]}\t{reader["street"]}\t{reader["city"]}\t{reader["addressline"]}\t{reader["regNumber"]}\t{reader["state"]}\t{reader["country"]}";
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
    }
}
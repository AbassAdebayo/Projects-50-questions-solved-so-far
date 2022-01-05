using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentApp.Manager
{
    public class AddressManager
    {
        readonly AddressRepository addressRepository;

        public AddressManager(MySqlConnection connection)
        {
            addressRepository = new AddressRepository(connection);
        }
        public void Create()
        {
            Console.WriteLine("Enter Your new zipcode: ");
            int Zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your street: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter Your city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Your addressliner: ");
            string addressline = Console.ReadLine();
            Console.WriteLine("Enter Your regNumberr: ");
            string regNumber = Console.ReadLine();
            Console.WriteLine("Enter Your state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Your country: ");
            string country = Console.ReadLine();
            var address = new Address(Zipcode, street, city, addressline, regNumber, state, country);
            addressRepository.Create(address);
        }
        public void Delete()
        {
            Console.WriteLine("Enter the RegNumber of the Address you want to Find: ");
            string regNumber = Console.ReadLine();
            var result = addressRepository.Delete(regNumber);
            if (result)
            {
                Console.WriteLine("Record Deleted");
            }
            else
            {
                Console.WriteLine("An error occured");
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            var row = addressRepository.FindByRegNumber(regNumber);
            if (!String.IsNullOrEmpty(row))
            {
                var address = Address.ConvertToAddress(row);
                address.UpdateInfo();
                var result = addressRepository.Update(address);
                if (result)
                {
                    Console.WriteLine("Record Updated");
                }
                else
                {
                    Console.WriteLine("An error occured");
                }
            }
            else
            {
                Console.WriteLine("No Matching record found");
            }
        }

        public void Find()
        {
            Console.WriteLine("Enter the RegNumber of the student you want to Find: ");
            string regNumber = Console.ReadLine();
            addressRepository.Find(regNumber);
        }
        public void List()
        {
            addressRepository.List();
        }
    }
}
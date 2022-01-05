using System;

namespace StudentApp
{
    public class Address
    {

        public int Zipcode { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string AddressLine { get; private set; }
        public string RegNumber { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public Address(int zipcode, string street, string city, string addressLine, string regNumber, string state, string country)
        {
            Zipcode = zipcode;
            Street = street;
            City = city;
            AddressLine = addressLine;
            RegNumber = regNumber;
            State = state;
            Country = country;
        }

        public void UpdateInfo()
        {
            bool update = true;
            while (update)
            {
                Console.WriteLine("What do you want to update? ");
                string option = Console.ReadLine();
                switch (option.Trim().ToLower())
                {
                    case "zipcode":
                        Console.WriteLine("Enter your new zipcode? ");
                        Zipcode = int.Parse(Console.ReadLine());
                        break;
                    case "street":
                        Console.WriteLine("Enter your new street? ");
                        Street = Console.ReadLine();
                        break;
                    case "city":
                        Console.WriteLine("Enter your new City? ");
                        City = Console.ReadLine();
                        break;
                    case "addressline":
                        Console.WriteLine("Enter your new Addressline? ");
                        AddressLine = Console.ReadLine();
                        break;
                    case "state":
                        Console.WriteLine("Enter your new State? ");
                        State = Console.ReadLine();
                        break;
                    case "country":
                        Console.WriteLine("Enter your new Country? ");
                        Country = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter valid input!!");
                        break;
                }
                Console.WriteLine("Do you want to continue to update your information, (Yes/No)");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "no")
                {
                    update = false;
                }
            }
        }

        public static Address ConvertToAddress(string row)
        {
            string[] content = row.Split("\t");
            return new Address(int.Parse(content[0]), content[1], content[2], content[3], content[4], content[5], content[6]);
        }

    }
}
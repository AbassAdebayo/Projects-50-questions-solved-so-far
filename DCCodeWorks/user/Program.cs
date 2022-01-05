using System;

namespace user
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New User:");

            Console.WriteLine("enter the username: ");
            string name=Console.Readline();

            Console.WriteLine("enter the Age: ");
            int Age= Convert.ToInt32(Console.Readline());

            Console.WriteLine("enter the phone number: ");
            int phone_number= Convert.ToInt32(Console.Readline());


            WriteLine($"Name: {name}");
            WriteLine($"Age: {Age}");
            WriteLine($"phone_number: {phone_number}");
        }
    }
}

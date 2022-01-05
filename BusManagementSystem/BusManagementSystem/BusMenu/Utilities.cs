using System;
using BusManagementSystem.Enums;

namespace BusManagementSystem
{
    public class Utilities
    {
        public static BusType GetBusType()
        {
            Console.WriteLine("Enter 1 for First Class");
            Console.WriteLine("Enter 2 for Business Class");
            Console.WriteLine("Enter 3 Economy");
            int response = int.Parse(Console.ReadLine());
            return (BusType)response;
        }
    }
}
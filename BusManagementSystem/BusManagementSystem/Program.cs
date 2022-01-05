using System;
using System.Collections.Generic;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Repositories;

namespace BusManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //PassengerRepository _passengerRepository = new PassengerRepository();
            BusMenu.active();


            var passenger1 = new Passenger
            {
                FirstName = "Abass",
                LastName = "Adebayo",
                MiddleName = "Ayodeji",
                FullName = "Abass Adebayo Ayodeji",
                Password = "Ayodeji007",
                Email = "greatmoh007@gmail.com",
                PhoneNumber = "09014698926",
                Address = "Apanpa street, Opp. Sawmill, Dogo, Apata, Ibadan.",
            };

            var passenger2 = new Passenger
            {
                FirstName = "Bayonle",
                LastName = "Alimah",
                MiddleName = "Ajoke",
                FullName = "Bayonle Alimah Ajoke",
                Password = "Alljoke02",
                Email = "Alijoke123@gmail.com",
                PhoneNumber = "09014698926",
                Address = "Apanpa street, Opp. Sawmill, Dogo, Apata, Ibadan.",

            };
           //_passengerRepository.Create(passenger2);
            
            //Console.Write(passenger2);


        }
    }
}
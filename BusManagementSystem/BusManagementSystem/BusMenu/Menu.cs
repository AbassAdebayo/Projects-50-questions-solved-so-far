using System;
using System.Collections.Generic;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Enums;
using BusManagementSystem.Repositories;
using BusManagementSystem.Services;
using Org.BouncyCastle.Crypto.Engines;
using CreateBusRequestModel = BusManagementSystem.Interfaces.Services.CreateBusRequestModel;
using UpdateBusRequestModel = BusManagementSystem.Interfaces.Services.UpdateBusRequestModel;

namespace BusManagementSystem
{
    public static class BusMenu
    {
        private static BusService _busService = new BusService();
        private static BusRepository _busRepository = new BusRepository();

        
        public static void active()
        {
           bool active = true;
           
           Console.WriteLine("Welcome To Bus Management System App....");

           do
           {
               Console.WriteLine("Enter your option");
               PrintMainMenu();
               int option = HandleOption(Console.ReadLine());

               active = HandleMainMenu(option);

           } while (active);

           Console.WriteLine("Thank you for visiting our Bus Management System...");
           
           
        }
        

        public static void PrintMainMenu()
        {
            Console.WriteLine("Enter 1 for bus Management");
            Console.WriteLine("Enter 0 to terminate");
            
        }

        public static bool HandleMainMenu(int option)
        {

            switch (option)
            {
                case 1:
                {
                    PrintBusMenuOptions();
                    HandleBusSubMenu(HandleOption(Console.ReadLine()));
                    return true;
                }
                case 0:
                    return false;
                    
                default:
                    return false;
            }
        }
        
         
        
        
        
        public static void PrintBusMenuOptions()
        {
            Console.WriteLine("Enter 1 to Register a Bus");
            Console.WriteLine("Enter 2 to Update");
            Console.WriteLine("Enter 3 to Delete");
            Console.WriteLine("Enter 4 to List Buses");
            Console.WriteLine("Enter 5 to Find a Bus");
            Console.WriteLine("Enter 6 to get all available Buses");
            Console.WriteLine("Enter 0 to return to the Main menu");
            
        }

        public static bool HandleBusSubMenu(int option)
        {
            switch (option)
            {
                case 1:
                {
                    Console.WriteLine("Enter Bus Type");
                    BusType busType = Utilities.GetBusType();
                    
                    Console.WriteLine("Enter Bus Model");
                    string model = Console.ReadLine();
                    
                    Console.WriteLine("Enter Plate Number");
                    string plateNumber = Console.ReadLine();
                    
                    Console.WriteLine("Enter Bus Capacity");
                    int busCapacity = int.Parse(Console.ReadLine());
                    
                    var bus = new CreateBusRequestModel
                    {
                        Capacity = busCapacity,
                        Model = model,
                        BusType = busType,
                        PlateNumber = plateNumber,

                    };
                    _busService.Register(bus);
                    Console.WriteLine($"The bus with the following details has been successfully created:\nModel: {bus.Model}\nCapacity: {bus.Capacity}\nPlate Number: {bus.PlateNumber} " +
                                      $"\nBus Type: {bus.BusType}");
                    PrintBusMenuOptions();
                    HandleBusSubMenu(HandleOption(Console.ReadLine()));
                    return true;

                }
                case 2:
                {
                    
                    Console.WriteLine("Enter 1 to update Bus Type");
                    Console.WriteLine("Enter 2 to update Bus Plate Number");
                    Console.WriteLine("Enter 0 to return to the main menu");
                    int reply = int.Parse(Console.ReadLine());

                    if (reply==1)
                    {
                        Console.Write("Enter the Bus Registration Number to proceed update");
                        string registrationNumber = Console.ReadLine();
                        var regNum = _busRepository.GetByRegistrationNumber(registrationNumber);
                        if (regNum==_busRepository.GetByRegistrationNumber(registrationNumber))
                        {
                            Console.WriteLine("Enter the Bus Type you want to update to");
                            BusType busType = Utilities.GetBusType();

                            UpdateBusRequestModel _busType = new UpdateBusRequestModel
                            {
                                BusType = busType
                            };
                            _busService.Update(registrationNumber, _busType);
                            Console.WriteLine($"The bus Plate Number has been changed from {busType} to {_busType.BusType}");
                            PrintBusMenuOptions();
                            HandleBusSubMenu(HandleOption(Console.ReadLine()));
                            
                        }
                        else
                        {
                            throw new KeyNotFoundException("The registration number entered cannot be found.");
                        }
                       
                    }
                    else if (reply==2)
                    {
                        Console.WriteLine("Enter the Bus Registration Number to proceed update");
                        string registrationNumber = Console.ReadLine();
                        var regNum = _busRepository.GetByRegistrationNumber(registrationNumber);
                        
                        if (regNum==_busRepository.GetByRegistrationNumber(registrationNumber))
                        {
                            Console.WriteLine("Enter the Bus Plate Number you want change to");
                            string plateNumber = Console.ReadLine();

                            var plateNum = new UpdateBusRequestModel
                            {
                                PlateNumber = plateNumber
                            };
                            _busService.Update(registrationNumber, plateNum);
                            Console.WriteLine($"The bus Plate Number has been changed to {plateNumber}");
                            PrintBusMenuOptions();
                            HandleBusSubMenu(HandleOption(Console.ReadLine()));
                            return true;
                        }
                        else
                        {
                            throw new KeyNotFoundException("The registration number entered cannot be found.");
                        }

                    }
                    else if (reply==0)
                    {
                        return false;
                    }
                    
                    return true;

                }
                case 3:
                {
                    Console.WriteLine("Enter the Registration Number of the bus you want to delete");
                    string registrtaionNumber = Console.ReadLine();

                    var bus = _busRepository.GetByRegistrationNumber(registrtaionNumber);

                    if (bus!=null)
                    {
                        _busRepository.Delete(bus);
                        
                        Console.WriteLine($"The bus with the following details has been successfully deleted:\nModel: {bus.Model}\nRegistration Number: {bus.RegistrationNumber}\nCapacity: {bus.Capacity}\nPlate Number: {bus.PlateNumber}\nTrip Status: " +
                                          $"{bus.TripStatus}\nAvailable Status: {bus.AvailabilityStatus}\nBus Type: {bus.BusType}");
                        PrintBusMenuOptions();
                        HandleBusSubMenu(HandleOption(Console.ReadLine()));
                        return true;

                    }
                    else
                    {
                        throw new KeyNotFoundException("The registration number entered cannot be found.");
                    }

                    return true;
                }
                case 4:
                {
                   var lists= _busService.List();

                   foreach (var item in lists)
                   {
                       Console.WriteLine($"{item.Model} {item.RegistrationNumber} {item.PlateNumber} {item.Capacity} {item.TripStatus} {item.AvailabilityStatus} {item.BusType}");
                   }
                    PrintBusMenuOptions();
                    HandleBusSubMenu(HandleOption(Console.ReadLine()));
                    return true;
                }
                case 5:
                {
                    Console.WriteLine("Enter Registration Number to find Bus");
                    string registrationNumber = (Console.ReadLine());

                    if (registrationNumber==_busService.RegistrationNumber)
                    {
                        _busService.GetByRegNumber(registrationNumber);
                        PrintBusMenuOptions();
                        HandleBusSubMenu(HandleOption(Console.ReadLine()));
                        return true;
                    }
                    else
                    {
                        throw new KeyNotFoundException("The registration number entered cannot be found.");
                    }


                }
                case 0:
                    return false;
                default:
                    return false;
            }
            
        }
        
        
        
        public static int HandleOption(string option)
        {
            bool check = false;
            int val = 0;
            while (!check)
            {
                bool result = int.TryParse(option, out val);
                if (result)
                {
                    check = true;
                }
                else
                {
                    Console.Write("Try again!");
                    option = Console.ReadLine();
                }
            }

            return val;
        }
    }
}
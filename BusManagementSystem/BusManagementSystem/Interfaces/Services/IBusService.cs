using System;
using BusManagementSystem.Enums;

namespace BusManagementSystem.Interfaces.Services
{
    public interface IBusService
    {
        
        public int Id { get; set; }

        public string Model { get; set; }

        public BusType BusType { get; set; }

        public string RegistrationNumber { get; set; }

        public string PlateNumber { get; set; }

        public int Capacity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public bool TripStatus { get; set; }
    }

    public class CreateBusRequestModel
    {
        public string Model { get; set; }

        public BusType BusType { get; set; }

        public string PlateNumber { get; set; }

        public int Capacity { get; set; }
    }

    public class UpdateBusRequestModel
    {
        public BusType BusType { get; set; }
        public string PlateNumber { get; set; }
        public string RegistrationNumber { get; private set; }
        public string DriverLicense { get; set; }
        public Location LandingPoint { get; set; }
        public DateTime LandingTime { get; set; }
        public string TripReference { get; set; }
        public int AvailableSeat { get; set; }
        public DateTime TakeOffTime { get; set; }
        
        public Location TakeOffPoint { get; set; }
    }
}
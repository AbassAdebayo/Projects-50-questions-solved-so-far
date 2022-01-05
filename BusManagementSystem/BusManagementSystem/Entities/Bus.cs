using System.Collections.Generic;
using BusManagementSystem.Enums;

namespace BusManagementSystem.Entities
{
    public class Bus
    {
        public int Id { get; set; }
        
        public string Model { get; set; }
        
        public BusType BusType { get; set; }
        
        public string RegistrationNumber { get; set; }
        
        public string PlateNumber { get; set; }
        
        public bool AvailabilityStatus { get; set; }
        
        public bool TripStatus { get; set; }

        public virtual List<Trip> Trips { get; set; } = new List<Trip>();
        public int Capacity { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}, RegistrationNum: {RegistrationNumber}, BusCapacity: {Capacity}, TripStatus: {TripStatus}, AvailabilityStatus: {AvailabilityStatus}, BusType: {BusType} ";
        }
    }
}
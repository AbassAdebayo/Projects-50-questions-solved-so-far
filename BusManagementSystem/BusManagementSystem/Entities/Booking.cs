using System.Runtime.CompilerServices;
using BusManagementSystem.Enums;

namespace BusManagementSystem.Entities
{
    public class Booking
    {
        public string BookingReference { get; set; }
        
        public int NumberOfPassengers { get; set; }
        
        public int PassengerId { get; set; }
        
        public Passenger Passenger { get; set; }
        
        public int Id { get; set; }
        
        public int CustomerId { get; set; }
        
        public Trip Trip { get; set; }
        
        public  int TripId { get; set; }
        
        public BookingStatus BookingStatus { get; set; }
        
        public bool IsPaid { get; set; }
        
    }
}
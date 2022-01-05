using System.Collections.Generic;
using BusManagementSystem.Repositories;

namespace BusManagementSystem.Entities
{
    public class Passenger: User
    {

        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public override string ToString()
        {
            return $"Details of the Passenger:\nFullname: {FirstName} {LastName} {MiddleName}\nAddress: {Address}\nEmail:{Email}\nPhone Number: {PhoneNumber}\nPassword: {Password}";
        }
    }
}
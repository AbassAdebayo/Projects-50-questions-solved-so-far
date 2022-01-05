using System.Collections.Generic;

namespace BusManagementSystem.Entities
{
    public class Admin: User
    {
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
        
        public override string ToString()
        {
            return $"Details of the Admin:\nFullname: {FirstName} {LastName} {MiddleName}\nAddress: {Address}\nEmail:{Email}\nPhone Number: {PhoneNumber}\nPassword: {Password}";
        }
    }
}
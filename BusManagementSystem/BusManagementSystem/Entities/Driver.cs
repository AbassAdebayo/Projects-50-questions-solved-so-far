using System.Collections.Generic;

namespace BusManagementSystem.Entities
{
    public class Driver: User
    {
        public string LicenseNumber { get; set; }
        
        public string NextOfKin { get; set; }

        public List<Trip> Trips { get; set; } = new List<Trip>();
        
        public override string ToString()
        {
            return $"Details of the Driver:\nFullname: {FirstName} {LastName} {MiddleName}\nAddress: {Address}\nEmail:{Email}\nPhone Number: {PhoneNumber}\nPassword: {Password}";
        }
       
    }
}
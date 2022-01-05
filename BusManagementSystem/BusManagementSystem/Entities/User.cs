using System;
using System.Collections.Generic;
using BusManagementSystem.Enums;

namespace BusManagementSystem.Entities
{
    public abstract class User
    {  
        public int Id { get; set; }

         public string FirstName { get; set; }
                
         public string LastName { get; set; }
         
         public string MiddleName { get; set; }
         
         public string FullName { get; set; }
         
         public string PhoneNumber { get; set; }
         
         public string Email { get; set; }
         
         public string Password { get; set; }
         
         public string Address { get; set; }
         
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
        
    }
}
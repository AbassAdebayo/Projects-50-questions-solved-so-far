namespace BusManagementSystem.Interfaces
{
    public interface IDriverRepository
    {
            public int Id { get; set; } 

             public string FirstName { get; set; }
                    
             public string LastName { get; set; }
             
             public string MiddleName { get; set; }
             
             public string PhoneNumber { get; set; }
             
             public string Email { get; set; }
             
             public string Password { get; set; }
             
             public string Address { get; set; }
             
         
         public class CreateDriverRequestModel
         {
             public string FirstName { get; set; }
                
             public string LastName { get; set; }
         
             public string MiddleName { get; set; }
         
             public string PhoneNumber { get; set; }
         
             public string Email { get; set; }
         
             public string Password { get; set; }
         
             public string Address { get; set; }
         }
         
            public class UpdateDriverRequestModel
         {
             public string FirstName { get; set; }
                
             public string LastName { get; set; }
         
             public string MiddleName { get; set; }
         
             public string PhoneNumber { get; set; }
         
             public string Email { get; set; }
         
             public string Password { get; set; }
         
             public string Address { get; set; }
         }
     
    }
}
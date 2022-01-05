using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestEFCore.Entities
{
    public class AccountHolder
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
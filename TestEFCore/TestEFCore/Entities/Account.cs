using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEFCore.Entities
{
    [Table("accounts")]
    public class Account
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public double Balance { get; set; }
        // [Column("account_number")]
        // [StringLength(3)]
        public string AccountNumber { get; set; }
        public AccountHolder AccountHolder { get; set; }
        
        // [ForeignKey("AccountHolder")]
        public int AccountHolderId { get; set; }
    }
}
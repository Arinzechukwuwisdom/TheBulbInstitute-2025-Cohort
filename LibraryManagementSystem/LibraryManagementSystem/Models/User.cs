using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required int MembershipNumber { get; set; } //1, 2, 3, etc.
        public string MembershipPrefix { get; set; } = "MEMB-";
        public string MembershipCode => MembershipPrefix + MembershipNumber.ToString("D4"); // e.g., MEMB-0001
        public string Address { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
        public List<Transaction> Transactions { get; set; } = [];


    }
}

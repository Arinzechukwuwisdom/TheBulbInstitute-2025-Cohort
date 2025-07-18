using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.DTOs.User
{
    public class GetUserDTO
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string MembershipCode { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public List<Transaction> Transactions { get; set; } = [];
    }
}

using LibraryManagementSystem.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Transaction
    {
        [Key]
        public Guid? Id { get; set; }
        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        [ForeignKey(nameof(Book))]
        public Guid BookId { get; set; }
        public DateTimeOffset TransactionDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset DueDate => TransactionDate.AddDays(14); // Assuming a 2-week borrowing period
        public Status TransactionStatus { get; set; } = Status.Borrowed;
        public DateTimeOffset? ReturnDate { get; set; }

        //Navigational properties
        public User User { get; set; }
        public Book Book { get; set; }
    }
}

namespace LibraryManagementSystem.DTOs.TransactionDTOs
{
    public class CreateTransactionDTO
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public required string TransactionStatus { get; set; }
        public DateTimeOffset? ReturnDate { get; set; }
    }
}

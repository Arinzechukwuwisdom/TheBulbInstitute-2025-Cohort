

using LibraryManagementSystem.DTOs.TransactionDTOs;

namespace LibraryManagementSystem.Interfaces
{
    public interface ITransactionService
    {
        Task<List<GetTransactionDTO>> GetAllTransactionsAsync();
        Task<GetTransactionDTO> GetTransactionByIdAsync(Guid id);
        Task<GetTransactionDTO> CreateTransactionAsync(CreateTransactionDTO transaction);
        Task<GetTransactionDTO> UpdateTransactionAsync(Guid id, CreateTransactionDTO transaction);
        Task<bool> DeleteTransactionAsync(Guid id);
        Task<IEnumerable<GetTransactionDTO>> GetTransactionsByUserIdAsync(Guid userId);
        Task<IEnumerable<GetTransactionDTO>> GetTransactionsByBookIdAsync(Guid bookId);
        Task<IEnumerable<GetTransactionDTO>> GetOverdueTransactionsAsync();
        Task<IEnumerable<GetTransactionDTO>> GetTransactionsByStatusAsync(string status);
    }
}

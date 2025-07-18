using LibraryManagementSystem.DTOs.TransactionDTOs;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Repository
{
    public class TransactionRepository : ITransactionService
    {
        public Task<GetTransactionDTO> CreateTransactionAsync(CreateTransactionDTO transaction)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTransactionAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetTransactionDTO>> GetAllTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetTransactionDTO>> GetOverdueTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetTransactionDTO> GetTransactionByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetTransactionDTO>> GetTransactionsByBookIdAsync(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetTransactionDTO>> GetTransactionsByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetTransactionDTO>> GetTransactionsByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<GetTransactionDTO> UpdateTransactionAsync(Guid id, CreateTransactionDTO transaction)
        {
            throw new NotImplementedException();
        }
    }
}

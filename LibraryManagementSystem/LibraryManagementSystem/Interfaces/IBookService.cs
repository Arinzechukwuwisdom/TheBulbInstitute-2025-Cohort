using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(Guid id);
        Task<Book> AddBookAsync(Book book);
        Task<Book> UpdateBookAsync(Guid id, Book book);
        Task<bool> DeleteBookAsync(Guid id);
        Task<IEnumerable<Book>> SearchBooksAsync(string searchTerm);
        Task<IEnumerable<Book>> GetAvailableBooksAsync();
        Task<IEnumerable<Book>> GetBooksBySpecificFilterAsync(string filter);
    }
}

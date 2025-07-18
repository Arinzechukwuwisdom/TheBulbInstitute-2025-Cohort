using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repository
{
    public class BookRepository : IBookService
    {
        public Task<Book> AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAvailableBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksBySpecificFilterAsync(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> SearchBooksAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateBookAsync(Guid id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}

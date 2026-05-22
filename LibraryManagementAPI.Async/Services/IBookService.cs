using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();

        Task AddBookAsync(Book book);
    }
}
using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();

        Task AddAsync(Book book);
    }
}
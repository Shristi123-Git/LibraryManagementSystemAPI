using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Services
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAuthorAsync();

        Task<Author?> GetAuthorByIdAsync(int id);

        Task AddAuthorAsync(Author author);
    }
}

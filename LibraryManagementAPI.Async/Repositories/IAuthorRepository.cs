using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Repositories;

public interface IAuthorRepository
{
    Task<List<Author>> GetAllAsync();

    Task<Author?> GetByIdAsync(int id);

    Task AddAsync(Author author);
}
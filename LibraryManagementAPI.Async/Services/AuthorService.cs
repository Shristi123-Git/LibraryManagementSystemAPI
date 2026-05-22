/*using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;

namespace LibraryManagementAPI.Async.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<List<Author>> GetAuthorAsync()
        {
            return await _authorRepository.GetAllAsync();
        }

        public async Task<Author?> GetAuthorByIdAsync(int id)
        {
            return await _authorRepository.GetByIdAsync(id);
        }

        public async Task AddAuthorAsync(Author author)
        {
            await _authorRepository.AddAsync(author);
        }
    }
}
*/
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;

namespace LibraryManagementAPI.Async.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<List<Author>> GetAuthorAsync()
    {
        return await _authorRepository.GetAllAsync();
    }

    public async Task<Author?> GetAuthorByIdAsync(int id)
    {
        return await _authorRepository.GetByIdAsync(id);
    }

    public async Task AddAuthorAsync(Author author)
    {
        await _authorRepository.AddAsync(author);
    }
}
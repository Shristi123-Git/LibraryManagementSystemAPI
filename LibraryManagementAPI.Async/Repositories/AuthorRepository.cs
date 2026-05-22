/*using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;

namespace LibraryManagementAPI.Async.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorRepository(IAuthorRepository authorRepository)
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
using LibraryManagementAPI.Async.Data;
using LibraryManagementAPI.Async.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Async.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly LibraryDbContext _context;

    public AuthorRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<List<Author>> GetAllAsync()
    {
        return await _context.Authors.ToListAsync();
    }

    public async Task<Author?> GetByIdAsync(int id)
    {
        return await _context.Authors.FindAsync(id);
    }

    public async Task AddAsync(Author author)
    {
        await _context.Authors.AddAsync(author);
        await _context.SaveChangesAsync();
    }
}

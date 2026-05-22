using LibraryManagementAPI.Async.Data;
using LibraryManagementAPI.Async.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Async.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            //return await _context.Books.ToListAsync();
            return await _context.Books
            .Include(b => b.Author)
            .ToListAsync();
         }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);

            await _context.SaveChangesAsync();
        }
    }
}
/*using LibraryManagementAPI.Async.Data;
using LibraryManagementAPI.Async.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Async.Repositories
{
    public class BookIssueRepository : IBookIssueRepository
    {
        private readonly LibraryDbContext _context;

        public BookIssueRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task IssueBookAsync(BookIssue issue)
        {
            await _context.BookIssues.AddAsync(issue);

            await _context.SaveChangesAsync();
        }
    }
}*/
using LibraryManagementAPI.Async.Data;
using LibraryManagementAPI.Async.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Async.Repositories
{
    public class BookIssueRepository : IBookIssueRepository
    {
        private readonly LibraryDbContext _context;

        public BookIssueRepository(LibraryDbContext context)
        {
            _context = context;
        }

        // 1. ADDED: Implementation to fetch all raw database records
        public async Task<IEnumerable<BookIssue>> GetAllBookIssuesAsync()
        {
            return await _context.BookIssues.ToListAsync();
        }

        public async Task IssueBookAsync(BookIssue issue)
        {
            await _context.BookIssues.AddAsync(issue);
            await _context.SaveChangesAsync();
        }
    }
}

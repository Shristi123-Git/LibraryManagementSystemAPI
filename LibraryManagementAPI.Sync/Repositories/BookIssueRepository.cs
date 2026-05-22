using LibraryManagementAPI.Data;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public class BookIssueRepository : IBookIssueRepository
    {
        private readonly LibraryDbContext _context;

        public BookIssueRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public void IssueBook(BookIssue issue)
        {
            _context.BookIssues.Add(issue);
            _context.SaveChanges();
        }
    }
}
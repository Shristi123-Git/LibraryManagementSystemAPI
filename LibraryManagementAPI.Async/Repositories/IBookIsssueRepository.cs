/*using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Repositories
{
    public interface IBookIssueRepository
    {
        Task IssueBookAsync(BookIssue issue);
    }
}*/
using LibraryManagementAPI.Async.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Async.Repositories
{
    public interface IBookIssueRepository
    {
        // 1. ADDED: Signature to fetch all raw database records
        Task<IEnumerable<BookIssue>> GetAllBookIssuesAsync();

        Task IssueBookAsync(BookIssue issue);
    }
}

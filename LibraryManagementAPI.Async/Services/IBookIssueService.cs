/*using LibraryManagementAPI.Async.Models;

namespace LibraryManagementAPI.Async.Services
{
    public interface IBookIssueService
    {
        Task IssueBookAsync(BookIssue issue);
    }
}*/
using LibraryManagementAPI.Async.DTOs.BookIssue;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Async.Services
{
    public interface IBookIssueService
    {
        Task<IEnumerable<BookIssueReadDTO>> GetAllBookIssuesAsync();
        Task IssueBookAsync(BookIssueCreateDTO issueDTO);
    }
}

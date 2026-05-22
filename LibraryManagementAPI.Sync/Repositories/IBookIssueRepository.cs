using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public interface IBookIssueRepository
    {
        void IssueBook(BookIssue issue);
    }
}
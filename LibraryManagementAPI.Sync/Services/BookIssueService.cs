using LibraryManagementAPI.Models;
using LibraryManagementAPI.Repositories;

namespace LibraryManagementAPI.Services
{
    public class BookIssueService : IBookIssueService
    {
        private readonly IBookIssueRepository _bookIssueRepository;

        public BookIssueService(IBookIssueRepository bookIssueRepository)
        {
            _bookIssueRepository = bookIssueRepository;
        }

        public void IssueBook(BookIssue issue)
        {
            _bookIssueRepository.IssueBook(issue);
        }
    }
}
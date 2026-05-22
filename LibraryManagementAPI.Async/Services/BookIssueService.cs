using LibraryManagementAPI.Async.DTOs.BookIssue;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Async.Services
{
    public class BookIssueService : IBookIssueService
    {
        private readonly IBookIssueRepository _bookIssueRepository;

        public BookIssueService(IBookIssueRepository bookIssueRepository)
        {
            _bookIssueRepository = bookIssueRepository;
        }

        public async Task<IEnumerable<BookIssueReadDTO>> GetAllBookIssuesAsync()
        {
            var issues = await _bookIssueRepository.GetAllBookIssuesAsync();

            return issues.Select(issue => new BookIssueReadDTO
            {
                Id = issue.IssueId,
                BookId = issue.BookId,
                StudentId = issue.StudentId,
                // Explicitly cast to handle any mismatch between model and DTO
                IssueDate = ((DateTime?)issue.IssueDate) ?? DateTime.Now,
                ReturnDate = ((DateTime?)issue.ReturnDate) ?? DateTime.Now.AddDays(14),
                Status = issue.Status
            });
        }

        public async Task IssueBookAsync(BookIssueCreateDTO issueDto)
        {
            var bookIssue = new BookIssue
            {
                BookId = issueDto.BookId,
                StudentId = issueDto.StudentId,
                // Explicitly cast to handle any mismatch between DTO and model
                IssueDate = ((DateTime?)issueDto.IssueDate) ?? DateTime.Now,
                ReturnDate = ((DateTime?)issueDto.ReturnDate) ?? DateTime.Now.AddDays(14),
                Status = issueDto.Status
            };

            await _bookIssueRepository.IssueBookAsync(bookIssue);
        }
    }
}

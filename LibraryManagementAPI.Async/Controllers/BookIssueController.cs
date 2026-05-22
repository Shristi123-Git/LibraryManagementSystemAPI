using LibraryManagementAPI.Async.DTOs.BookIssue;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Services;
using Microsoft.AspNetCore.Authorization; // Added for security
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Async.Controllers
{
    [Authorize] // Requires your JWT token to access these endpoints
    [ApiController]
    [Route("api/[controller]")]
    public class BookIssueController : ControllerBase
    {
        private readonly IBookIssueService _bookIssueService;

        public BookIssueController(IBookIssueService bookIssueService)
        {
            _bookIssueService = bookIssueService;
        }

        // 1. ADDED: GET Endpoint to fetch all records
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookIssueReadDTO>>> GetAllBookIssues()
        {
            var issues = await _bookIssueService.GetAllBookIssuesAsync();
            return Ok(issues);
        }

        // 2. UPDATED: Changed parameter from 'BookIssue' model to 'BookIssueCreateDTO'
        [HttpPost("issue")]
        public async Task<IActionResult> IssueBook([FromBody] BookIssueCreateDTO issueDto)
        {
            if (issueDto == null)
            {
                return BadRequest("Invalid request");
            }

            await _bookIssueService.IssueBookAsync(issueDto);

            return Ok("Book issued successfully");
        }
    }
}

using LibraryManagementAPI.Async.DTOs.Book;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Async.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        /*[HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest("Invalid book data");
            }

            await _bookService.AddBookAsync(book);

            return Ok("Book added successfully");
        }*/
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] BookCreateDTO dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                ISBN = dto.ISBN,
                AuthorId = dto.AuthorId,
                Quantity = dto.Quantity
            };

            await _bookService.AddBookAsync(book);

            return Ok("Book added successfully");
        }
    }
}
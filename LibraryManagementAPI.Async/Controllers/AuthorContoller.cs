using LibraryManagementAPI.Async.DTOs.Author;
using LibraryManagementAPI.Async.Models;
using LibraryManagementAPI.Async.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Async.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthor()
        {
            var authors = await _authorService.GetAuthorAsync();

            var result = authors.Select(a => new AuthorReadDTO
            {
                AuthorId = a.AuthorId,
                AuthorName = a.AuthorName,
                Bio = a.Bio
            });
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);

            if (author == null)
            {
                return NotFound("Author not found");
            }

            var result = new AuthorReadDTO
            {
                AuthorId = author.AuthorId,
                AuthorName = author.AuthorName,
                Bio = author.Bio
            };

            return Ok(author);
        }

        /*[HttpPost]
        public async Task<IActionResult> AddAuthor([FromBody] Author author)
        {
            if (author == null)
            {
                return BadRequest("Invalid author data");
            }

            await _authorService.AddAuthorAsync(author);

            return Ok("Author added successfully");
        }*/
        [HttpPost]
        public async Task<IActionResult> AddAuthor([FromBody] AuthorCreateDTO dto)
        {
            var author = new Author
            {
                AuthorName = dto.AuthorName,
                Bio = dto.Bio
            };

            await _authorService.AddAuthorAsync(author);

            return Ok("Author added successfully");
        }
    }
}
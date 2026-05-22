using LibraryManagementAPI.DTOs.Author;
using LibraryManagementAPI.Models;
using LibraryManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("api/author")]
    [Authorize]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var authors = _authorService.GetAuthor();

            var result = authors.Select(a => new AuthorReadDTO
            {
                AuthorId = a.AuthorId,
                AuthorName = a.AuthorName,
                Bio = a.Bio
            });

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(AuthorCreateDTO dto)
        {
            var author = new Author
            {
                AuthorName = dto.AuthorName,
                Bio = dto.Bio
            };

            _authorService.AddAuthor(author);
            return Ok("Author saved successfully");
        }
    }

}

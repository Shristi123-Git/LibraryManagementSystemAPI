using LibraryManagementAPI.Models;
using LibraryManagementAPI.Repositories;

namespace LibraryManagementAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public List<Author> GetAuthor()
        {
            return _authorRepository.GetAll();
        }

        //public Author GetAuthorById(int id)
        public Author? GetAuthorById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void AddAuthor(Author author)
        {
            _authorRepository.Add(author);
        }
    }

}

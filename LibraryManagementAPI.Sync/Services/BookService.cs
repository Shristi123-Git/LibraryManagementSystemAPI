using LibraryManagementAPI.Models;
using LibraryManagementAPI.Repositories;

namespace LibraryManagementAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetBooks()
        {
            return _bookRepository.GetAll();
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }
    }
}
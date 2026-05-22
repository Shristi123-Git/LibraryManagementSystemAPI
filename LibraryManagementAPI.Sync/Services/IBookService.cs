using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        void AddBook(Book book);
    }
}
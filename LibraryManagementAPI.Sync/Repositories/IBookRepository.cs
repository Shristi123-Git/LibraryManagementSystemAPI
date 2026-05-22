using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void Add(Book book);
    }
}
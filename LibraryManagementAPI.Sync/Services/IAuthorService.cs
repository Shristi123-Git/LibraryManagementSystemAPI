using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services
{
    public interface IAuthorService
    {
        List<Author> GetAuthor();
        //Author GetAuthorById(int id);
        Author? GetAuthorById(int id);
        void AddAuthor(Author author);
    }

}

/*using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Services
{
    public interface IAuthorService
    {
        void AddAuthor(Author author);
    }
}
*/

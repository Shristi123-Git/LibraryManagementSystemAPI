using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        //Author GetById(int id);
        Author? GetById(int id);
        void Add(Author author);
        void Update(Author author);
        void Delete(int id);
    }

}

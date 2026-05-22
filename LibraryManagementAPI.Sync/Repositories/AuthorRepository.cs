using LibraryManagementAPI.Data;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDbContext _context;

        public AuthorRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        //public Author GetById(int id)
        public Author? GetById(int id)
        {
            return _context.Authors.FirstOrDefault(x => x.AuthorId == id);
        }

        public void Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.Authors.FirstOrDefault(x => x.AuthorId == id);
            if (data != null)
            {
                _context.Authors.Remove(data);
                _context.SaveChanges();
            }
        }
    }

}

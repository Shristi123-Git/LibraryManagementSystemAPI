/*namespace LibraryManagementAPI.Async.Models
{
    public class Author
    {
        //public int AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;
    }
}*/
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Async.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;

        //public List<Book>? Books { get; set; }
        //public ICollection<Book> Books { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}

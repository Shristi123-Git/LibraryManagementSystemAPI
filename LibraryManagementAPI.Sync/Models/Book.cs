namespace LibraryManagementAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int AuthorId { get; set; }

        public int Quantity { get; set; }

        public Author? Author { get; set; }
    }
}
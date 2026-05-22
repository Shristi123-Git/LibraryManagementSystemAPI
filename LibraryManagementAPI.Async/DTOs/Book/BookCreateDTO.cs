namespace LibraryManagementAPI.Async.DTOs.Book
{
    public class BookCreateDTO
    {
        public string Title { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int AuthorId { get; set; }

        public int Quantity { get; set; }
    }
}
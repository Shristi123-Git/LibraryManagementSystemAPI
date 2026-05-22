namespace LibraryManagementAPI.Async.DTOs.Book
{
    public class BookReadDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int Quantity { get; set; }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = string.Empty;
    }
}
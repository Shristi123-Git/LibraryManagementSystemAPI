namespace LibraryManagementAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;
    }
}
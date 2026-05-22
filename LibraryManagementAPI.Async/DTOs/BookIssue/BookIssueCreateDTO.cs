namespace LibraryManagementAPI.Async.DTOs.BookIssue
{
    /*public class BookIssueCreateDTO
    {
        public int BookId { get; set; }
        public int StudentId { get; set; }
    }*/
    public class BookIssueCreateDTO
    {
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Status { get; set; }
    }
}

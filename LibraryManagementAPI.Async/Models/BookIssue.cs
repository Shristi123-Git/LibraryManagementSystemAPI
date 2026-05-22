using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Async.Models
{
    public class BookIssue
    {
        [Key]
        public int IssueId { get; set; }

        public int BookId { get; set; }

        public int StudentId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public bool Status { get; set; } = true; // as per guideline
    }
}

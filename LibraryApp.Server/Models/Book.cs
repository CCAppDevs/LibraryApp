using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Server.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverType { get; set; }
        public string CoverUrl { get; set; }
    }
}

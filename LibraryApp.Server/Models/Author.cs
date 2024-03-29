﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Server.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

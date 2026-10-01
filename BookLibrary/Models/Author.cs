using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public partial class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public string Fullname => $"{FirstName} {Surname}";

        

    }
}

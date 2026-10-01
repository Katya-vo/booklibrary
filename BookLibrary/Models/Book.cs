using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int YearOfPublishing { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}

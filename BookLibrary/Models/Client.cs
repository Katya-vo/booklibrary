
using System;

namespace BookLibrary.Models
{
    public class Client
    {
        public int id { get; set; }

        public string name { get; set; } = string.Empty;

        public string username { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public int? bookId { get; set; }

        public DateTime? borrowUntil { get; set; }
    }
}

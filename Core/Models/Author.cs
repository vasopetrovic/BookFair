using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Author : Person
    {
        public int Id { get; set; }
        public string IdCardNumber { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}

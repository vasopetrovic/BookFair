using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string IdCardNumber { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}

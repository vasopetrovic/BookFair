using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public Author? Boss { get; set; }    
        public List<Book> Books { get; set; } = new List<Book>();


        public List<Author> Authors { get; set; } = new List<Author>();
    }
}

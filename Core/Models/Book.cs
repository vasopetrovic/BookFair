using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public enum BookGenre
    {
        Fiction,
        NonFiction,
        Mystery,
        ScienceFiction,
        Fantasy,
        Biography,
        History,
        Romance,
        Thriller,
        SelfHelp
    }
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public BookGenre Genre { get; set; }
        public int PublicationYear { get; set; }
        public double Price { get; set; }
        public int PageNumber { get; set; }
        public List<Author> Authors { get; set; }
        public Visitor Visitor { get; set; }
        public List<Visitor> BuyingVisitors { get; set; } = new List<Visitor>();
        public List<Visitor> WishingVisitors { get; set; } = new List<Visitor>();
    }
}

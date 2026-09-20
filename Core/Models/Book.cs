using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Book
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
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
        public string PublicationYear { get; set; }
        public double Price { get; set; }
        public int PageNumber { get; set; }
        public List<Author> Authors { get; set; }
        public List<Visitor> BuyingVisitors { get; set; }
        public List<Visitor> WishingVisitors { get; set; }
    }
}

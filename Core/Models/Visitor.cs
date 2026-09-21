using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{

    public enum VisitorType
    {
        Regular,
        VIP
    }   
    public class Visitor : Person
    {
        public string MembershipNumber { get; set; } = string.Empty; //SK-1-2023
        public DateTime MembershipYear { get; set; }
        public VisitorType Status { get; set; }
        public List<Purchase> Purchases { get; set; } = new List<Purchase>();
        public List<Book> WishList { get; set; } = new List<Book>();

        //izvedeno
        public double AverageRating => Purchases.Count() == 0 ? 0 : Purchases.Average(p => p.Mark);


    }
}

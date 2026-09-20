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
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IDCardNumber { get; set; } //zbog 0   
        public DateTime MembershipYear { get; set; }
        public VisitorType Status { get; set; }
        public double AverageRating { get; set; }
        public List<Purchase> Purchases { get; set; }
        public List<string> WishList;


    }
}

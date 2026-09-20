using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
        public Visitor Visitor { get; set; }

    }
}

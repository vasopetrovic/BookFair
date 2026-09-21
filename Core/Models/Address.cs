using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"{Street} {HouseNumber}, {City}, {Country}";
        }

    }
}

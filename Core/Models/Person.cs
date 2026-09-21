using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public abstract class Person
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } =string.Empty;
        public DateTime Birthdate{ get; set; }
        public Address Address { get; set; } = new Address();
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;

    }
}

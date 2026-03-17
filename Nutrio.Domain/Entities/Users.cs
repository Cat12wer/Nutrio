using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Entities
{
    internal class Users
    {
        //keys
        public Guid Id { get; set; }

        //others
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public enum Sex {Male, Female }
        public DateOnly BirthDate { get; set; }
        public string? GoogleId { get; set; }
        public string? HashPasword { get; set; }
    }
}

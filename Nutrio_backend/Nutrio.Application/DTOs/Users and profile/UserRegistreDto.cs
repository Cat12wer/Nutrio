using Nutrio.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Nutrio.Application.DTOs.Users_and_profile
{
    public class UserRegistreDto
    {
        
        public string Name { get; set; }
        public string LastName { get; set; }
      
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public Sex sex { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}

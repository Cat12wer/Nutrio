

namespace Nutrio.Application.DTOs
{
    internal class UserRegistrerDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Sex Sex { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
    }
}

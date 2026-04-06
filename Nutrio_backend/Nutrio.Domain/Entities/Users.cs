using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nutrio.Domain.Entities
{
    public partial class Users
    {
        // Ключі та зв'язки
        public Guid Id { get; set; }
        public virtual ICollection<DayCounter> DayCounters { get; set; } = new List<DayCounter>();
        public virtual ICollection<Bodymetrix> BodymetrixRecords { get; set; } = new List<Bodymetrix>();

        // Основні дані (Профіль)
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public enum Sex { Male, Female }
        public Sex UserSex { get; set; }
        public DateOnly BirthDate { get; set; }

        // Останні актуальні антропометричні дані
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }

        // Безпека та Авторизація
        public string? PasswordHash { get; set; } // Тільки хеш
        public string? GoogleId { get; set; }

        // Токени сесії
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}

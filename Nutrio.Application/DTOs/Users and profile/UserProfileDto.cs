using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs
{
    internal class UserProfileDto
    {
        public Guid Id { get; set; }
        public string FullName => $"{Name} {LastName}";
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }

        // Цілі 
        public decimal DailyCalorieGoal { get; set; }
        public decimal ProteinGoal { get; set; }
        public decimal FatGoal { get; set; }
        public decimal CarbsGoal { get; set; }
        public decimal WaterGoal { get; set; }
    }
}

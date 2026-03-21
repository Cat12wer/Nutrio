using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Diary
{
    internal class DayEntryDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public MealType MealType { get; set; }

        // КБЖВ саме для цієї порції
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
    }
}

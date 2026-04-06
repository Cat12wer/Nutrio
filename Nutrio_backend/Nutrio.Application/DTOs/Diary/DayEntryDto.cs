using System;
using System.Collections.Generic;
using System.Text;
using Nutrio.Domain.Entities;

namespace Nutrio.Application.DTOs.Diary
{
    public class DayEntryDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public DayCounter.MealType MealType { get; set; }

        // КБЖВ саме для цієї порції
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
    }
}

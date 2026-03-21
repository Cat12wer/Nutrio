using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Diary
{
    internal class CreateDayCounterDto
    {
        public Guid ProductId { get; set; }
        public decimal Quantity { get; set; }
        public MealType MealType { get; set; }
        public DateTime Date { get; set; }
    }
}

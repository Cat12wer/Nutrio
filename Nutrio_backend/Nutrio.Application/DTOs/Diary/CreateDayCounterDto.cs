using System;
using System.Collections.Generic;
using System.Text;
using Nutrio.Domain.Entities;

namespace Nutrio.Application.DTOs.Diary
{
    public class CreateDayCounterDto
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Quantity { get; set; }
        public DayCounter.MealType MealType { get; set; }
        public DateTime Date { get; set; }
    }
}

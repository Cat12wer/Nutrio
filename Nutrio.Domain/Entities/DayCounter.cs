using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Entities
{
    public class DayCounter
    {
        //keys
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public Users User { get; set; } = null!;
        public Products Product { get; set; } = null!;

        //others
        public DateTime Date {  get; set; }
        public decimal Quantity { get; set; }
        public enum MealType
        {
            Breakfast,
            Lunch,
            Dinner,
            Snack1,
            Snack2 
        }
        public MealType TypeMeal { get; set; }
        public decimal CaloriesAtNow {  get; set; }
        public decimal CarbsAtNow { get; set; } 
        public decimal ProteinAtNow { get;set; }
        public decimal FatAtNow { get; set; }
        public decimal FiberAtNow { get; set; }


    }
}

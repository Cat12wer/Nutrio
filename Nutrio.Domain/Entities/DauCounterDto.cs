using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Entities
{
    internal class DauCounterDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public string MealType { get; set; }
    }
}

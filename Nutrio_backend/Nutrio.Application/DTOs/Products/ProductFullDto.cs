using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Products
{
    internal class ProductFullDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; } = string.Empty;

        // КБЖВ на 100 г продукту
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Fiber { get; set; } 
    }
}

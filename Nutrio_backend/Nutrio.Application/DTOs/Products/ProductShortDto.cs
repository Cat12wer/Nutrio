using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Products
{
    public class ProductShortDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Calories { get; set; } 
        public string? PictureURL { get; set; }
    }
}

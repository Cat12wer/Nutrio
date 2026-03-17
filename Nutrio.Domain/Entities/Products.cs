using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Entities
{
    internal class Products
    {
        //keys
        public Guid Id { get; set; }

        //Others
        public string ProductName { get; set; }
        public decimal Calories { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal  Fiber { get; set; }
        public string? PictureURL { get; set; }
        
        
    }
}

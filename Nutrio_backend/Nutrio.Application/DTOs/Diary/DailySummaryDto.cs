using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.Diary
{
    public class DailySummaryDto
    {
        public DateTime Date { get; set; }
        public decimal TotalCalories { get; set; } = 0;
        public decimal TotalProteins { get; set; } = 0;
        public decimal TotalFats { get; set; } = 0;
        public decimal TotalCarbs { get; set; } = 0;    
        public decimal TotalFibers { get; set; } = 0;
    }
}

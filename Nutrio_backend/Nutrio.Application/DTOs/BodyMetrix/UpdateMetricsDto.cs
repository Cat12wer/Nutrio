using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Application.DTOs.BodyMetrix
{
    public class UpdateMetricsDto
    {
        public decimal Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Waist { get; set; }
        public decimal? Neck { get; set; }
        public decimal? Hip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Entities
{
    internal class Bodymetrix
    {

        //keys
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        //others
        public decimal BodyMassIndex { get; set; }
        public decimal Weight { get; set; }
        public decimal? FatProcent { get; set; }
        public decimal? Height { get; set; }
        public decimal? Waist { get; set; }
        public decimal? Neck  { get; set; }
        public decimal? Hip { get; set; }
        public DateTime DateOfEntryMetrix { get; set; }


    }
}

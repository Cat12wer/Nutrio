using System;
using System.Collections.Generic;
using System.Text;
using Nutrio.Domain.Entities;

namespace Nutrio.Application.DTOs.BodyMetrix
{
    public class OnboardingDataDto
    {
        public enum Sex { man, female }
        public Sex  sex { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public int TargetWeight { get; set; }

        public int Goal { get; set; }

        public enum ActivityLevel { Level_1, Level_2, Level_3, Level_4 }
        public ActivityLevel Activity { get; set; }




    }
}


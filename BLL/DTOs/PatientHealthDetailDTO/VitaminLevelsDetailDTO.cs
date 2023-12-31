﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class VitaminLevelsDetailDTO
    {
        public int VitaminLevelsDetailId { get; set; }
        public int PatientId { get; set; }

        // Properties for individual vitamin levels
        public double? VitaminA { get; set; } // Concentration of Vitamin A
        public double? VitaminD { get; set; } // Concentration of Vitamin D
        public double? VitaminE { get; set; } // Concentration of Vitamin E
        public double? VitaminK { get; set; } // Concentration of Vitamin K
        public double? VitaminB12 { get; set; } // Concentration of Vitamin B12
        public double? Folate { get; set; } // Concentration of Folate (Vitamin B9)
        public double? VitaminC { get; set; } // Concentration of Vitamin C
        public double? VitaminB6 { get; set; } // Concentration of Vitamin B6
        public double? Thiamine { get; set; } // Concentration of Thiamine (Vitamin B1)
        public double? Riboflavin { get; set; } // Concentration of Riboflavin (Vitamin B2)
        public double? Niacin { get; set; } // Concentration of Niacin (Vitamin B3)
        public string PerformedBy { get; set; }

        public string Note { get; set; }

    }
}

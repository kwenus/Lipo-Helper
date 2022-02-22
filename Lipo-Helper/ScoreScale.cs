using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class ScoreScale
    {
        public string? ScaleGender { get; set; }
        public string? ScaleSmoking { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int SystolicPressureMin { get; set; }
        public int SystolicPressureMax { get; set; }
        public double TotalCholesterolMin { get; set; }
        public double TotalCholesterolMax { get; set; }
        public int ScaleRisk { get; set; }

        public bool CheckCell (Patient patient)
            { 
             if (ScaleGender == patient.Gender && ScaleSmoking == patient.Smoking && 
                 AgeMin <= patient.Age && AgeMax >= patient.Age &&
                 SystolicPressureMin <= patient.SystolicPressure && 
                 SystolicPressureMax >= patient.SystolicPressure && 
                 TotalCholesterolMin <= patient.TotalCholesterol && 
                 TotalCholesterolMax >= patient.TotalCholesterol)
                return true;

             return false;
            }

    }
}

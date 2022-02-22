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

        public bool CheckOutScore (Patient patient)
            { 
             if (ScaleGender == patient.gender && ScaleSmoking == patient.smoking && 
                 AgeMin <= patient.age && AgeMax >= patient.age &&
                 SystolicPressureMin <= patient.systolicPressure && 
                 SystolicPressureMax >= patient.systolicPressure && 
                 TotalCholesterolMin <= patient.totalCholesterol && 
                 TotalCholesterolMax >= patient.totalCholesterol)
                return true;

             return false;
            }

    }
}

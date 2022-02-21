using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class ScoreScale
    {
        public string? scaleGender;
        public string scaleSmoking;
        public int ageMin;
        public int ageMax;
        public int systolicPressureMin;
        public int systolicPressureMax;
        public double totalCholesterolMin;
        public double totalCholesterolMax;
        public int scaleRisk;

        public ScoreScale(string gender, string smoking, int agemin, int agemax, int syspresmin, int syspresmax, 
                          double totalcholmin, double totalcholmax, int risk)
            {
            scaleGender = gender;
            scaleSmoking = smoking;
            ageMin = agemin;
            ageMax = agemax;
            systolicPressureMin = syspresmin;
            systolicPressureMax = syspresmax;
            totalCholesterolMin = totalcholmin;
            totalCholesterolMax = totalcholmax;
            scaleRisk = risk;
            }

            public bool Check (Patient patient)
            { 
             if (scaleGender == patient.gender && scaleSmoking == patient.smoking && ageMax > patient.age && ageMin < patient.age &&
                systolicPressureMin < patient.systolicPressure && systolicPressureMax > patient.systolicPressure && 
                totalCholesterolMin < patient.totalCholesterol && totalCholesterolMax > patient.totalCholesterol)
                return true;

             return false;
            }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public delegate bool CardioVascularRisk();
    public delegate void Note(string note);

    public class CVRisk
    {
        public bool CheckOne(Patient patient)
        {
            if (patient.RepetiveACSinTwoYears)
            {
                patient.Risk = "extreme";
                patient.LowLipidsRate = 1.1F;
                return true;
            }
            else return false;
        }
        public bool CheckTwo(Patient patient)
        {
            if (patient.Atherosclerosis == true && patient.Diabetes == true && patient.DiabetesType == 2)
            {
                patient.Risk = "extreme";
                patient.LowLipidsRate = 1.1F;
                return true;
            }
            else return false;
        }
        public bool CheckThree(Patient patient)
        {
            if (patient.AcuteCoronarySyndrome)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckFour(Patient patient)
        {
            if (patient.CoronaryArteryDisease)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckFive(Patient patient)
        {
            if (patient.Stroke)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckSix(Patient patient)
        {
            if (patient.TransientIschemicAttack)
               { 
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
               }
            else return false;
        }
        public bool CheckSeven(Patient patient)
        {
            if (patient.Atherosclerosis == true && patient.PercentageArteryStenosis > 50 && patient.Diabetes == true)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckEight(Patient patient)
        {
            if (patient.GlomerularFiltrationRate < 30)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckNine(Patient patient)
        {
            if (patient.ScoreRate > 10)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckTen(Patient patient)
        {
            if (patient.FamilialHypercholesterolemia == true && patient.Atherosclerosis == true)
            {
                patient.Risk = "very high";
                patient.LowLipidsRate = 1.4F;
                return true;
            }
            else return false;
        }
        public bool CheckEleven(Patient patient)
        {
            if (patient.ScoreRate > 5 && patient.ScoreRate < 10)
            {
                patient.Risk = "high";
                patient.LowLipidsRate = 1.8F;
                return true;
            }
            else return false;
        }
        public bool CheckTwelve(Patient patient)
        {
            if (patient.TotalCholesterol > 8.0 && patient.LowDensityLipids > 4.9 && patient.SystolicPressure > 180)
            {
                patient.Risk = "high";
                patient.LowLipidsRate = 1.8F;
                return true;
            }
            else return false;
        }
        public bool CheckThirdteen(Patient patient)
        {
            if (patient.FamilialHypercholesterolemia)
            {
                patient.Risk = "high";
                patient.LowLipidsRate = 1.8F;
                return true;
            }
            else return false;
        }
        public bool CheckFourteen(Patient patient)
        {
            if (patient.Diabetes == true && patient.DiabetesDuration > 10)
            {
                patient.Risk = "high";
                patient.LowLipidsRate = 1.8F;
                return true;
            }
            else return false;
        }
        public bool CheckFifteen(Patient patient)
        {
            if (patient.PercentageArteryStenosis > 25 && patient.PercentageArteryStenosis < 49)
            {
                patient.Risk = "high";
                patient.LowLipidsRate = 1.8F;
                return true;
            }
            else return false;
        }
        public bool CheckSixteen(Patient patient)
        {
            if (patient.ScoreRate > 1 && patient.ScoreRate < 5)
            {
                patient.Risk = "medium";
                patient.LowLipidsRate = 2.6F;
                return true;
            }
            else return false;
        }
        public bool CheckSeventeen(Patient patient)
        {
            if (patient.Age < 35 && patient.DiabetesType == 1 && patient.DiabetesDuration < 10)
            {
                patient.Risk = "medium";
                patient.LowLipidsRate = 2.6F;
                return true;
            }
            return false;
        }
        public bool CheckEighteen(Patient patient)
        {
            if (patient.Age < 50 && patient.DiabetesType == 2 && patient.DiabetesDuration < 10)
            {
                patient.Risk = "medium";
                patient.LowLipidsRate = 2.6F;
                return true;
            }
            else return false;
        }
        public bool CheckNineteen(Patient patient)
        {
            if (patient.ScoreRate < 1)
            {
                patient.Risk = "low";
                patient.LowLipidsRate = 3.0F;
                return true;
            }
            else return false;
        }
    }
}


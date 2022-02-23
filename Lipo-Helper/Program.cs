using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new()
            {
                Gender = Console.ReadLine(),
                Age = Convert.ToInt32(Console.ReadLine()),
                SystolicPressure = Convert.ToInt32(Console.ReadLine()),
                TotalCholesterol = Convert.ToDouble(Console.ReadLine()),
                LowDensityLipids = Convert.ToDouble(Console.ReadLine()),
                Smoking = Convert.ToBoolean(Console.ReadLine()) 
            };

            ScoreScale.Cell patientRisk = new();
            patientRisk.ShowTenYearRisk(patient);     //расcчёт индекса SCORE;


            Therapy patientTherapy = new();
            patientTherapy.PrescribeTherapy(patient);  //рассчёт лакарственной терапии;



        }
    }
}

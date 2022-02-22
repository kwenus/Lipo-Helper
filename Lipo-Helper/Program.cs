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
                Smoking = Console.ReadLine()   
            };

            Cells patientRisk = new();
            patientRisk.ShowRisk(patient);       //расcчёт индекса SCORE;
        }
    }
}

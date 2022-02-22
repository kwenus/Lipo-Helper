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
            Patient patient = new("n", 0, 0, 0, "n")
            {
                gender = Console.ReadLine(),
                age = Convert.ToInt32(Console.ReadLine()),
                systolicPressure = Convert.ToInt32(Console.ReadLine()),
                totalCholesterol = Convert.ToDouble(Console.ReadLine()),
                smoking = Console.ReadLine()   
            };

            Cells patientRisk = new();
            patientRisk.ShowRisk(patient);       //расcчёт индекса SCORE;
        }
    }
}

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
            Patient patient = new("n", 0, 0, 0, 0, "n")
            {
                gender = Console.ReadLine(),
                age = Convert.ToInt32(Console.ReadLine()),
                systolicPressure = Convert.ToInt32(Console.ReadLine()),
                totalCholesterol = Convert.ToDouble(Console.ReadLine()),
                lowDensityLipo = Convert.ToDouble(Console.ReadLine()),
                smoking = Console.ReadLine()   
            };


            List<ScoreScale> cell = new List<ScoreScale>()
            {
                new ScoreScale("female", "no", 40, 49, 120, 139, 4.0, 4.9, 0),
                new ScoreScale("female", "no", 40, 49, 120, 139, 5.0, 5.9, 1)
            };

            foreach (var item in cell)
            {
                if (item.Check(patient))
                { 
                    Console.WriteLine($"Your risk equals {item.scaleRisk}%");
                    break;
                }
            }
        }
    }
}

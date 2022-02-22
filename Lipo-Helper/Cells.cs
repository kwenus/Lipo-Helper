using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Cells
    {
        List<ScoreScale> cell = new List<ScoreScale>()
            {
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "no",
                AgeMin = 40,
                AgeMax = 49,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 0
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "no",
                AgeMin = 50,
                AgeMax = 54,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 1
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "no",
                AgeMin = 55,
                AgeMax = 59,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 2
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "no",
                AgeMin = 60,
                AgeMax = 64,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 3,
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "no",
                AgeMin = 65,
                AgeMax = 100,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 6
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "yes",
                AgeMin = 40,
                AgeMax = 49,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 0
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "yes",
                AgeMin = 50,
                AgeMax = 54,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 2
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "yes",
                AgeMin = 55,
                AgeMax = 59,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 3
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "yes",
                AgeMin = 60,
                AgeMax = 64,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 6
                },
                new ScoreScale()
                {
                ScaleGender = "female",
                ScaleSmoking = "yes",
                AgeMin = 65,
                AgeMax = 100,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 11
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "no",
                AgeMin = 40,
                AgeMax = 49,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 1
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "no",
                AgeMin = 50,
                AgeMax = 54,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 3
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "no",
                AgeMin = 55,
                AgeMax = 59,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 5
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "no",
                AgeMin = 60,
                AgeMax = 64,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 8
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "yes",
                AgeMin = 40,
                AgeMax = 49,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 2
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "yes",
                AgeMin = 50,
                AgeMax = 54,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 6
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "yes",
                AgeMin = 55,
                AgeMax = 59,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 10
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "yes",
                AgeMin = 60,
                AgeMax = 64,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 16
                },
                new ScoreScale()
                {
                ScaleGender = "male",
                ScaleSmoking = "yes",
                AgeMin = 65,
                AgeMax = 100,
                SystolicPressureMin = 120,
                SystolicPressureMax = 200,
                TotalCholesterolMin = 4.0,
                TotalCholesterolMax = 9.0,
                ScaleRisk = 23
                },
            };

        public void ShowRisk(Patient patient)
        {
            foreach (var item in cell)
            {
                if (item.CheckOutScore(patient))
                {
                    Console.WriteLine($"Your risk equals {item.ScaleRisk}%");
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class ScoreScale
    {
        public class CellData
        {
            public string? ScaleGender { get; set; }
            public bool ScaleSmoking { get; set; }
            public int AgeMin { get; set; }
            public int AgeMax { get; set; }
            public int SystolicPressureMin { get; set; }
            public int SystolicPressureMax { get; set; }
            public double TotalCholesterolMin { get; set; }
            public double TotalCholesterolMax { get; set; }
            public int ScaleRisk { get; set; }

            public bool CheckData(Patient patient) => (ScaleGender == patient.Gender && ScaleSmoking == patient.Smoking &&
                    AgeMin <= patient.Age && AgeMax >= patient.Age &&
                    SystolicPressureMin <= patient.SystolicPressure &&
                    SystolicPressureMax >= patient.SystolicPressure &&
                    TotalCholesterolMin <= patient.TotalCholesterol &&
                    TotalCholesterolMax >= patient.TotalCholesterol);
        }

        public class Cell
        {
            public List<CellData> cells = new()
            {
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = false,
                    AgeMin = 40,
                    AgeMax = 49,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 0
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = false,
                    AgeMin = 50,
                    AgeMax = 54,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 1
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = false,
                    AgeMin = 55,
                    AgeMax = 59,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 2
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = false,
                    AgeMin = 60,
                    AgeMax = 64,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 3,
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = false,
                    AgeMin = 65,
                    AgeMax = 100,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 6
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = true,
                    AgeMin = 40,
                    AgeMax = 49,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 0
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = true,
                    AgeMin = 50,
                    AgeMax = 54,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 2
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = true,
                    AgeMin = 55,
                    AgeMax = 59,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 3
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = true,
                    AgeMin = 60,
                    AgeMax = 64,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 6
                },
                new()
                {
                    ScaleGender = "female",
                    ScaleSmoking = true,
                    AgeMin = 65,
                    AgeMax = 100,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 11
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = false,
                    AgeMin = 40,
                    AgeMax = 49,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 1
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = false,
                    AgeMin = 50,
                    AgeMax = 54,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 3
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = false,
                    AgeMin = 55,
                    AgeMax = 59,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 5
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = false,
                    AgeMin = 60,
                    AgeMax = 64,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 8
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = true,
                    AgeMin = 40,
                    AgeMax = 49,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 2
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = true,
                    AgeMin = 50,
                    AgeMax = 54,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 6
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = true,
                    AgeMin = 55,
                    AgeMax = 59,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 10
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = true,
                    AgeMin = 60,
                    AgeMax = 64,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 16
                },
                new()
                {
                    ScaleGender = "male",
                    ScaleSmoking = true,
                    AgeMin = 65,
                    AgeMax = 100,
                    SystolicPressureMin = 120,
                    SystolicPressureMax = 200,
                    TotalCholesterolMin = 4.0,
                    TotalCholesterolMax = 9.0,
                    ScaleRisk = 23
                },
            };

            public void ShowTenYearRisk(Patient patient)
            {
                foreach (var item in cells)
                {
                    if (item.CheckData(patient))
                    {
                        Console.WriteLine($"Your risk of death in 10 years equals to {item.ScaleRisk}%");
                        patient.ScoreRate = item.ScaleRisk;
                        break;
                    }
                }
            }
        }
    }
}

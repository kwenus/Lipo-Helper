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

            //расcчёт индекса SCORE;

            ScoreScale.Cell patientRisk = new();
            patientRisk.ShowTenYearRisk(patient);


            //вариант 1: рассчёт лакарственной терапии;


            Therapy patientTherapy = new();
            patientTherapy.PrescribeTherapy(patient);

            Console.WriteLine($"Patient needs {patientTherapy.medicines[patientTherapy.med].MedicineName} " +
                              $"{patientTherapy.medicines[patientTherapy.med].MedicineDose}mg " +
                              $"to reach {patientTherapy.postTherapyLevel}.");

            //вариант 2: рассчёт лекарственной терапии;

            Statin rosuvastatin10 = new() { DrugName = "Rosuvastatin", DrugDose = 10, DrugDecrementActivity = 0.54 };
            Statin rosuvastatin20 = new() { DrugName = "Rosuvastatin", DrugDose = 20, DrugDecrementActivity = 0.48 };
            Statin rosuvastatin40 = new() { DrugName = "Rosuvastatin", DrugDose = 40, DrugDecrementActivity = 0.42 };

            AbsorbtionInhibitor ezetemib = new() { DrugName = "Ezetemib", DrugDose = 10, DrugDecrementActivity = 0.78 };

            Cumab alirocumab75 = new() { DrugName = "Ezetemib", DrugDose = 75, DrugDecrementActivity = 0.49 };
            Cumab alirocumab150 = new() { DrugName = "Ezetemib", DrugDose = 150, DrugDecrementActivity = 0.39 };



        }
    }
}

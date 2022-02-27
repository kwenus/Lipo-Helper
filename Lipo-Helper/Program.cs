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
                //Gender = Console.ReadLine(),
                //Age = Convert.ToInt32(Console.ReadLine()),
                //SystolicPressure = Convert.ToInt32(Console.ReadLine()),
                //TotalCholesterol = Convert.ToDouble(Console.ReadLine()),
                LowDensityLipids = Convert.ToSingle(Console.ReadLine()),
                //Smoking = Convert.ToBoolean(Console.ReadLine()) 
            };

            //расcчёт индекса SCORE;

            //ScoreScale.Cell patientRisk = new();
            //patientRisk.ShowTenYearRisk(patient);


            //вариант 1: рассчёт лакарственной терапии;


            Therapy patientTherapy = new();
            patientTherapy.PrescribeTherapy(patient);

            Console.WriteLine($"Patient needs {patientTherapy.medicines[patientTherapy.med-1].MedicineName} " +
                              $"{patientTherapy.medicines[patientTherapy.med-1].MedicineDose}mg " +
                              $"to reach {patientTherapy.postTherapyLevel}.");

            //вариант 2: рассчёт лекарственной терапии;

            Statin rosuvastatin10 = new() { DrugName = "Rosuvastatin", DrugDose = 10, DrugDecrementActivity = 0.54F };
            Statin rosuvastatin20 = new() { DrugName = "Rosuvastatin", DrugDose = 20, DrugDecrementActivity = 0.48F };
            Statin rosuvastatin40 = new() { DrugName = "Rosuvastatin", DrugDose = 40, DrugDecrementActivity = 0.42F };

            AbsorbtionInhibitor ezetemib = new() { DrugName = "Ezetemib", DrugDose = 10, DrugDecrementActivity = 0.78F };

            Cumab alirocumab75 = new() { DrugName = "Ezetemib", DrugDose = 75, DrugDecrementActivity = 0.49F };
            Cumab alirocumab150 = new() { DrugName = "Ezetemib", DrugDose = 150, DrugDecrementActivity = 0.39F };

            rosuvastatin10.StatinReductionOfLipids(patient);
            rosuvastatin20.StatinReductionOfLipids(patient);
            float afterRos40Level = rosuvastatin40.StatinReductionOfLipids(patient);
            ezetemib.AbsbInhReductionOfLipids(patient);
            float afterTripleLevel = ezetemib.DoubleReductionOfLipids(patient, afterRos40Level);
            alirocumab75.CumabReductionOfLipids(patient);
            alirocumab150.CumabReductionOfLipids(patient);
            alirocumab150.TripleReductionOfLipids(patient, afterTripleLevel);
            Console.WriteLine(rosuvastatin40.postStatinLevel);
            Console.WriteLine(ezetemib.postAbsInhLevel);
            Console.WriteLine(ezetemib.postDualLevel);
            Console.WriteLine(alirocumab150.postCumabLevel);
            Console.WriteLine(alirocumab150.postTripleLevel);
        }
    }
}

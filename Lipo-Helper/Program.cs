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
            //создание объектов препаратов;

            Statin rosuvastatin10 = new() { DrugName = "Rosuvastatin", DrugDose = 10, DrugDecrementActivity = 0.54F };
            Statin rosuvastatin20 = new() { DrugName = "Rosuvastatin", DrugDose = 20, DrugDecrementActivity = 0.48F };
            Statin rosuvastatin40 = new() { DrugName = "Rosuvastatin", DrugDose = 40, DrugDecrementActivity = 0.42F };

            AbsorbtionInhibitor ezetemib = new() { DrugName = "Ezetemib", DrugDose = 10, DrugDecrementActivity = 0.78F };

            Cumab alirocumab75 = new() { DrugName = "Ezetemib", DrugDose = 75, DrugDecrementActivity = 0.49F };
            Cumab alirocumab150 = new() { DrugName = "Ezetemib", DrugDose = 150, DrugDecrementActivity = 0.39F };

            //создание методов для делегата; 

            Therapy.Medication Ros10med = ShowLevelAfterRos10;
            Therapy.Medication Ros20med = ShowLevelAfterRos20;
            Therapy.Medication Ros40med = ShowLevelAfterRos40;

            Therapy.Medication Ezetmed = ShowLevelAfterEzet;
            Therapy.Medication Ros10Ezetmed = ShowDualRos10Ezet;
            Therapy.Medication Ros20Ezetmed = ShowDualRos20Ezet;
            Therapy.Medication Ros40Ezetmed = ShowDualRos40Ezet;

            Therapy.Medication Aliro75med = ShowLevelAfterAliro75;
            Therapy.Medication Aliro150med = ShowLevelAfterAliro150;
            Therapy.Medication Ros40EzetAliro75med = ShowTripleRos40EzetAliro75;
            Therapy.Medication Ros40EzetAliro150med = ShowTripleRos40EzetAliro150;



            float ShowLevelAfterRos10() => rosuvastatin10.StatinReductionOfLipids(patient);
            float ShowLevelAfterRos20() => rosuvastatin20.StatinReductionOfLipids(patient);
            float ShowLevelAfterRos40() => rosuvastatin40.StatinReductionOfLipids(patient);

            float ShowLevelAfterEzet() => ezetemib.AbsInhReductionOfLipids(patient);
            float ShowDualRos10Ezet() => ezetemib.DoubleReductionOfLipids(Ros10med);
            float ShowDualRos20Ezet() => ezetemib.DoubleReductionOfLipids(Ros20med);
            float ShowDualRos40Ezet() => ezetemib.DoubleReductionOfLipids(Ros40med);

            float ShowLevelAfterAliro75() => alirocumab75.CumabReductionOfLipids(patient);
            float ShowTripleRos40EzetAliro75() => alirocumab75.TripleReductionOfLipids(Ros40Ezetmed);
            float ShowLevelAfterAliro150() => alirocumab150.CumabReductionOfLipids(patient);
            float ShowTripleRos40EzetAliro150() => alirocumab150.TripleReductionOfLipids(Ros40Ezetmed);

            //использование делегатов

        }
    }
}

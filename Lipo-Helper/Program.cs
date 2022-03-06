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
            Patient patient = new();

            Console.WriteLine("Gender");
            patient.Gender = Console.ReadLine();
            Console.WriteLine("Age");
            patient.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Systolic Pressure");
            patient.SystolicPressure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Cholesterol");
            patient.TotalCholesterol = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Low Density Lipids");
            patient.LowDensityLipids = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Smoking");
            patient.Smoking = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Diabetes");
            patient.Diabetes = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Diabetes Type");
            patient.DiabetesType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diabetes Duration");
            patient.DiabetesDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Glomerular Filtration Rate");
            patient.GlomerularFiltrationRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Familial Hypercholesterolemia");
            patient.FamilialHypercholesterolemia = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Acute Coronary Syndrome ");
            patient.AcuteCoronarySyndrome = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Repetive ACS in 2 years ");
            patient.RepetiveACSinTwoYears = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Coronary Artery Disease");
            patient.CoronaryArteryDisease = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Stroke");
            patient.Stroke = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Transient Ischemic Attack");
            patient.TransientIschemicAttack = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Peripheral Artery Disease");
            patient.PeripheralArteryDisease = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Atherosclerosis");
            patient.Atherosclerosis = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Percentage Artery Stenosis");
            patient.PercentageArteryStenosis = Convert.ToInt32(Console.ReadLine());


            //расcчёт индекса SCORE;

            ScoreScale.Cell patientRisk = new();
            patientRisk.ShowTenYearRisk(patient);


            //определение СС-риска;

            CVRisk examine = new();

            CardioVascularRisk [] check = new CardioVascularRisk [20];
            check[0] = Check1;
            check[1] = Check2;
            check[2] = Check3;
            check[3] = Check4;
            check[4] = Check5;
            check[5] = Check6;
            check[6] = Check7;
            check[7] = Check8;
            check[8] = Check9;
            check[9] = Check10;
            check[10] = Check11;
            check[11] = Check12;
            check[12] = Check13;
            check[13] = Check14;
            check[14] = Check15;
            check[15] = Check16;
            check[16] = Check17;
            check[17] = Check18;
            check[18] = Check19;
            bool Check1() => examine.CheckOne(patient);
            bool Check2() => examine.CheckTwo(patient);
            bool Check3() => examine.CheckThree(patient);
            bool Check4() => examine.CheckFour(patient);
            bool Check5() => examine.CheckFive(patient);
            bool Check6() => examine.CheckSix(patient);
            bool Check7() => examine.CheckSeven(patient);
            bool Check8() => examine.CheckEight(patient);
            bool Check9() => examine.CheckNine(patient);
            bool Check10() => examine.CheckTen(patient);
            bool Check11() => examine.CheckEleven(patient);
            bool Check12() => examine.CheckTwelve(patient);
            bool Check13() => examine.CheckThirdteen(patient);
            bool Check14() => examine.CheckFourteen(patient);
            bool Check15() => examine.CheckFifteen(patient);
            bool Check16() => examine.CheckSixteen(patient);
            bool Check17() => examine.CheckSeventeen(patient);
            bool Check18() => examine.CheckEighteen(patient);
            bool Check19() => examine.CheckNineteen(patient);


            void WarningMassage(string note)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(note);
                Console.ResetColor();
            }

            examine.RiskWarning += WarningMassage;


            for (  int i = 0; i < 20; i++)
            {
                if (check[i]())
                {
                    Console.WriteLine($"Your patient have {patient.Risk} risk." +
                                      $" Therapy must gain {patient.LowLipidsRate} level to decrease posibility of cardio-vascular death.");
                    break;
                }
            }

            examine.RiskWarning -= WarningMassage;

            //вариант 1: рассчёт лакарственной терапии;


            Therapy patientTherapy = new();
            patientTherapy.PrescribeTherapy(patient);

            Console.WriteLine($"Patient needs {patientTherapy.medicines[patientTherapy.med-1].MedicineName} " +
                              $"{patientTherapy.medicines[patientTherapy.med-1].MedicineDose}mg " +
                              $"to reach {patientTherapy.postTherapyLevel}.");

            //вариант 2: рассчёт лекарственной терапии;
            //создание объектов препаратов

            Statin rosuvastatin10 = new() { DrugName = "Rosuvastatin", DrugDose = 10, DrugDecrementActivity = 0.54F };
            Statin rosuvastatin20 = new() { DrugName = "Rosuvastatin", DrugDose = 20, DrugDecrementActivity = 0.48F };
            Statin rosuvastatin40 = new() { DrugName = "Rosuvastatin", DrugDose = 40, DrugDecrementActivity = 0.42F };

            AbsorbtionInhibitor ezetemib = new() { DrugName = "Ezetemib", DrugDose = 10, DrugDecrementActivity = 0.78F };

            Cumab alirocumab75 = new() { DrugName = "Ezetemib", DrugDose = 75, DrugDecrementActivity = 0.49F };
            Cumab alirocumab150 = new() { DrugName = "Ezetemib", DrugDose = 150, DrugDecrementActivity = 0.39F };

            //создание делегатов для рассчёта терапии

            Precription Ros10pres = Ros10;
            Precription Ros20pres = Ros20;
            Precription Ros40pres = Ros40;
            Precription Ros40Ezetpres = Ros40Ezet;
            Precription Ros40EzetAliro75pres = Ros40EzetAliro75;
            Precription Ros40EzetAliro150pres = Ros40EzetAliro150;

            //использование делегатa

            Medication reductionTable = ShowLevelAfterRos10;
            reductionTable += ShowLevelAfterRos20;
            reductionTable += ShowLevelAfterRos40;
            reductionTable += ShowLevelAfterEzet;
            reductionTable += ShowDualRos10Ezet;
            reductionTable += ShowDualRos20Ezet;
            reductionTable += ShowDualRos40Ezet;
            reductionTable += ShowLevelAfterAliro75;
            reductionTable += ShowTripleRos40EzetAliro75;
            reductionTable += ShowLevelAfterAliro150;
            reductionTable += ShowTripleRos40EzetAliro150;

            reductionTable();

            //методы

            void ShowLevelAfterRos10() => Console.WriteLine($"Rosuvastatin 10 - {rosuvastatin10.StatinReductionOfLipids(patient)}");
            void ShowLevelAfterRos20() => Console.WriteLine($"Rosuvastatin 20 - {rosuvastatin20.StatinReductionOfLipids(patient)}");
            void ShowLevelAfterRos40() => Console.WriteLine($"Rosuvastatin 40 - {rosuvastatin40.StatinReductionOfLipids(patient)}");
            void ShowLevelAfterEzet() => Console.WriteLine($"Ezetemib - {ezetemib.AbsInhReductionOfLipids(patient)}");
            void ShowLevelAfterAliro75() => Console.WriteLine($"Alirocumab 75 - {alirocumab75.CumabReductionOfLipids(patient)}");
            void ShowLevelAfterAliro150() => Console.WriteLine($"Alirocumab 150 - {alirocumab150.CumabReductionOfLipids(patient)}");
            void ShowDualRos10Ezet() => Console.WriteLine($"Rosuvastatin 10 + Ezetemib - {ezetemib.DoubleReductionOfLipids(Ros10pres)}");
            void ShowDualRos20Ezet() => Console.WriteLine($"Rosuvastatin 20 + Ezetemib - {ezetemib.DoubleReductionOfLipids(Ros20pres)}"); 
            void ShowDualRos40Ezet() => Console.WriteLine($"Rosuvastatin 40 + Ezetemib - {ezetemib.DoubleReductionOfLipids(Ros40pres)}");
            void ShowTripleRos40EzetAliro75() => Console.WriteLine($"Rosuvastatin 40 + Ezetemib + Alirocumab 75 - " +
                                                                   $"{alirocumab75.TripleReductionOfLipids(Ros40Ezetpres)}");
            void ShowTripleRos40EzetAliro150() => Console.WriteLine($"Rosuvastatin 40 + Ezetemib + Alirocumab 150 - " +
                                                                    $"{alirocumab150.TripleReductionOfLipids(Ros40Ezetpres)}");

            float Ros10() => rosuvastatin10.StatinReductionOfLipids(patient);
            float Ros20() => rosuvastatin20.StatinReductionOfLipids(patient);
            float Ros40() => rosuvastatin40.StatinReductionOfLipids(patient);
            float Ros40Ezet() => ezetemib.DoubleReductionOfLipids(Ros40pres);
            float Ros40EzetAliro75() => alirocumab75.TripleReductionOfLipids(Ros40Ezetpres);
            float Ros40EzetAliro150() => alirocumab150.TripleReductionOfLipids(Ros40Ezetpres);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    class RiskLevel
    {
        static void Main (string[] args)
        {
            double CRL =0.0;
            int SCORE;
            ScoreScale risk = new ();             
            SCORE = risk.CountRisk();              
            Console.WriteLine(SCORE);             
            Patient patient = new("n", 0, 0, 0, "n", "n", 0, "n", "n", "n", "n", "n", 0);


            if (SCORE < 1)
            {
                CRL = 3.0;
                Console.WriteLine("You have low risk");
            }
            else if (SCORE > 1 && SCORE < 5 && patient.Diabetes == "yes" && patient.Duration < 10 && patient.Type == 1 && patient.Age < 35)
                CRL = 2.6;
            else if (SCORE >= 1 && SCORE < 5 && patient.Diabetes == "yes" && patient.Type == 2 && patient.Age < 50 && patient.Duration < 10)
                CRL = 2.6;
            else if (SCORE >= 5 && SCORE < 10 && (patient.TC > 8.0 || patient.LL > 4.9 || patient.FH == "yes" ||
                    (patient.Diabetes == "yes" && patient.Duration >= 10) || patient.GFR < 5 || (patient.AS == "yes" && patient.PAS < 49)))
            { 
                CRL = 1.8;

            //else if (SCORE >= 5 && SCORE < 10 && patient.LL > 4.9)
               // CRL = 1.8;
            //else if (SCORE >= 5 && SCORE < 10 && patient.FH == "yes")
                //CRL = 1.8;
            //else if (SCORE >= 5 && SCORE < 10 && patient.Diabetes == "yes" && patient.Duration >= 10)
                //CRL = 1.8;
            //else if (SCORE >= 5 && SCORE < 10 && patient.GFR < 59)
                //CRL = 1.8;
            //else if (SCORE >= 5 && SCORE < 10 && patient.AS == "yes" && patient.PAS < 49)
                //CRL = 1.8;
            else if (SCORE > 10 && (patient.ACS == "yes" || patient.Stroke == "yes" || patient.TIA == "yes" || patient.PAD == "yes"
                                   || patient.GFR < 30 || patient.FH == "yes" || (patient.AS == "yes" && patient.PAS > 50)))
                CRL = 1.4;
            else if (SCORE > 10 && patient.ACS == "yes" && patient.RepACS <= 2)
                CRL = 1.1;
            else if (SCORE > 10 && patient.AS == "yes" && patient.Diabetes == "yes" && patient.Type == 2)
                CRL = 1.1;
            
            if (CRL == 3.0) => Console.WriteLine("You have low risk")


        }
    }
}

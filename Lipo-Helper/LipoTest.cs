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
            int SCORE;
            ScoreScale risk = new ();             
            SCORE = risk.CountRisk();              
            Console.WriteLine(SCORE);             
            Patient Newpatient = new Patient ();
            
            double ll = Newpatient.LL;


        }
    }
}

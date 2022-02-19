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
            Patient patient = new("n", 0, 0, "n", 0.0, "n", "n", 0, "n", "n", "n", "n", "n", 0);



        }
    }
}

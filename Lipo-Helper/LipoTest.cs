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
            ScoreScale patient = new ();
            SCORE = patient.CountRisk();
            Console.WriteLine(SCORE);
        }
    }
}

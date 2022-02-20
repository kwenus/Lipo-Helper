using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class ScoreScale
    {
            public string? Gender;
            public string? Smoking;
            public int AgeMin;
            public int AgeMax;
            public int SPmin;
            public int SPmax;
            public double TCmin;
            public double TCmax;
            public int Risk;

        //Patient pat = new("n", 0, 0, 0, 0, "n");
        public bool Check (Patient patient)
        { 
            if (Gender == pat.Gender && Smoking == pat.Smoking && AgeMax > pat.Age && AgeMin < pat.Age &&
                SPmax > pat.SP && SPmin < pat.SP && TCmax > pat.TC && TCmin < )
                return true;

            return false;
            
        }

    }
}

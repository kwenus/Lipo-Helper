using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Statin : LipidLoweringDrug
    {
        public float postStatinLevel;
         public float StatinReductionOfLipids(Patient patient)
        {
           postStatinLevel = patient.LowDensityLipids * DrugDecrementActivity;
           return postStatinLevel;
        }
    }
}

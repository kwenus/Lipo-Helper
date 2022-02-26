using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Statin : LipidLoweringDrug
    {
        double postStatinLevel;

        public double StatinsReductionOfLipids(Patient patient)
        {
           postStatinLevel = patient.LowDensityLipids * DrugDecrementActivity;
           return postStatinLevel;
        }
    }
}

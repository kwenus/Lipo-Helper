using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class AbsorbtionInhibitor : LipidLoweringDrug
    {
        public float postAbsInhLevel;
        float postStatinLevel;
        public float postDualLevel;
        public float AbsbInhReductionOfLipids(Patient patient)
        {
           postAbsInhLevel = patient.LowDensityLipids * DrugDecrementActivity;
           return postAbsInhLevel;
        }

        public float DoubleReductionOfLipids(Patient patient, float postStatinLevel)
        {
            postDualLevel = postStatinLevel * DrugDecrementActivity;
            return postDualLevel;
        }
    }
}

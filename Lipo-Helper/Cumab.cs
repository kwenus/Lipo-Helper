using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Cumab : LipidLoweringDrug
    {
        public float postCumabLevel;
        float postDualLevel;
        public float postTripleLevel;

        public float CumabReductionOfLipids(Patient patient)
        {
            postCumabLevel = patient.LowDensityLipids * DrugDecrementActivity;
            return postCumabLevel;
        }

        public float TripleReductionOfLipids(Patient patient, float postDualLevel)
        {
            postTripleLevel = postDualLevel * DrugDecrementActivity;
            return postTripleLevel;
        }
    }
}


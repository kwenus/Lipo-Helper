using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Cumab : LipidLoweringDrug
    {
        double postCumabLevel1;
        double postCumabLevel2;
        double postStatinLevel3;

        public double CumabReductionOfLipids1(Patient patient)
        {
            postCumabLevel1 = patient.LowDensityLipids * DrugDecrementActivity1;
            return postCumabLevel1;
        }

        public double CumabReductionOfLipids2(Patient patient)
        {
            postCumabLevel2 = patient.LowDensityLipids * DrugDecrementActivity2;
            return postCumabLevel2;
        }

    }
}
}

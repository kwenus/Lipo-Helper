using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Cumab : LipidLoweringDrug
    {
        double postCumabLevel;

        public double CumabReductionOfLipids1(Patient patient)
        {
            postCumabLevel = patient.LowDensityLipids * DrugDecrementActivity;
            return postCumabLevel;
        }
    }
}


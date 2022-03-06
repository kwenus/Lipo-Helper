using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Cumab : LipidLoweringDrug
    {
        public float CumabReductionOfLipids(Patient patient) => patient.LowDensityLipids * DrugDecrementActivity;

        public float TripleReductionOfLipids(Precription med) => med() * DrugDecrementActivity;
    }
}


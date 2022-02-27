using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class AbsorbtionInhibitor : LipidLoweringDrug
    {
        public float AbsInhReductionOfLipids(Patient patient) => patient.LowDensityLipids * DrugDecrementActivity;

        public float DoubleReductionOfLipids(Therapy.Medication med) => med() * DrugDecrementActivity;
    }
}

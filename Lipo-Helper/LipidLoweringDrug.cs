using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public abstract class LipidLoweringDrug
    {
        public string? DrugName { get; set; }
        public int DrugDose { get; set; }

        public float DrugDecrementActivity { get; set; }

        public virtual float ReductionOfLipids(Patient patient) => patient.LowDensityLipids * DrugDecrementActivity;

    }
}

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

        public double DrugDecrementActivity { get; set; }

        double postTherapyLevel;

        public virtual double ReductionOfLipids(Patient patient)
        {
            postTherapyLevel = patient.LowDensityLipids * DrugDecrementActivity;
            return postTherapyLevel;
        }

        //public  double ReductionOfLipidsWithStatins (Patient patient)




    }
}

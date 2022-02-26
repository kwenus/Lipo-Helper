using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class AbsorbtionInhibitor : LipidLoweringDrug
    {
        double postAbsInhLevel1;

        public double AbsbInhReductionOfLipids1(Patient patient)
        {
           postAbsInhLevel1 = patient.LowDensityLipids * DrugDecrementActivity1;
           return postAbsInhLevel1;
        }



        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Statin : LipidLoweringDrug
    {
         public float StatinReductionOfLipids(Patient patient) => patient.LowDensityLipids * DrugDecrementActivity;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Medicine
    {
        public string? MedicineName { get; set; }
        public int MedicineDose { get; set; }
        public double DecrementActivity { get; set; }

        public double ReachTheTarget (Patient patient)
        {
            return patient.LowDensityLipids * DecrementActivity;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Patient
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public int SystolicPressure { get; set; }
        public float TotalCholesterol { get; set; }
        public float LowDensityLipids { get; set; }
        public bool Smoking { get; set; }
        public bool Diabetes { get; set; }
        public int DiabetesType { get; set; }
        public int DiabetesDuration { get; set; }
        public int GlomerularFiltrationRate { get; set; }
        public bool FamilialHypercholesterolemia { get; set; }
        public bool AcuteCoronarySyndrome { get; set; }
        public bool RepetiveACSinTwoYears { get; set; }
        public bool CoronaryArteryDisease { get; set; }
        public bool Stroke { get; set; }
        public bool TransientIschemicAttack { get; set; }
        public bool PeripheralArteryDisease { get; set; }
        public bool Atherosclerosis { get; set; }
        public int PercentageArteryStenosis { get; set; }
    }
}


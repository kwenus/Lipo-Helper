using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Therapy
    {

        public delegate float Medication();


        public class Medicine
        {
            public string? MedicineName { get; set; }
            public int MedicineDose { get; set; }
            public float DecrementActivity { get; set; }
        }

        public List<Medicine> medicines = new()
        {
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 10,
                DecrementActivity = 0.54F,
            },
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 20,
                DecrementActivity = 0.48F,
            },
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 40,
                DecrementActivity = 0.42F,
            },
            new()
            {
                MedicineName = "Ezetemibe",
                MedicineDose = 10,
                DecrementActivity = 0.78F,
            },
            new()
            {
                MedicineName = "Alirocumab",
                MedicineDose = 75,
                DecrementActivity = 0.49F,
            },
            new()
            {
                MedicineName = "Alirocumab",
                MedicineDose = 150,
                DecrementActivity = 0.39F,
            },
        };


        public int med;
        public float postTherapyLevel;
        public void PrescribeTherapy(Patient patient)
        {
            postTherapyLevel = patient.LowDensityLipids;
            for (med = 0; postTherapyLevel > 1.4; med++)
            {
                if (medicines[med].MedicineName == "Rozuvastatinum")
                {
                    postTherapyLevel = patient.LowDensityLipids * medicines[med].DecrementActivity;
                }
                else
                {
                    postTherapyLevel *= medicines[med].DecrementActivity;
                }
            }
        }
    }
}



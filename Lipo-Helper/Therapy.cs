using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Therapy
    {
        public class Medicine
        {
            public string? MedicineName { get; set; }
            public int MedicineDose { get; set; }
            public double DecrementActivity { get; set; }
        }

        public List<Medicine> medicines = new()
        {
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 10,
                DecrementActivity = 0.54,
            },
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 20,
                DecrementActivity = 0.48,
            },
            new()
            {
                MedicineName = "Rozuvastatinum",
                MedicineDose = 40,
                DecrementActivity = 0.45,
            },
            new()
            {
                MedicineName = "Ezetemibe",
                MedicineDose = 10,
                DecrementActivity = 0.78,
            },
            new()
            {
                MedicineName = "Alirocumab",
                MedicineDose = 75,
                DecrementActivity = 0.49,
            },
            new()
            {
                MedicineName = "Alirocumab",
                MedicineDose = 150,
                DecrementActivity = 0.39,
            },
        };



        public void PrescribeTherapy(Patient patient)
        {
            int i;
            double postTherapyLevel = patient.LowDensityLipids;
            for (i = 0; postTherapyLevel > 1.4; i++)
            {
                if (medicines[i].MedicineName == "Rozuvastatinum")
                {
                    postTherapyLevel = patient.LowDensityLipids * medicines[i].DecrementActivity;
                }
                else
                {
                    postTherapyLevel *= medicines[i].DecrementActivity;
                }
            }
                Console.WriteLine($"Patient needs {medicines[i].MedicineName} " +
                        $"{medicines[i].MedicineDose}mg to reach {postTherapyLevel}.");
        }
    }
}



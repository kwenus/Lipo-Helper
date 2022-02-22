using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Patient
    {
        public string? firstName;  
        public string lastName;   
        public string gender;     
        public int age;            
        public int systolicPressure;             
        public double totalCholesterol;         
        public double lowDensityLipo;         
        public string smoking;    
        public bool diabetes;   
        public int diabetesType;   
        public int diabetesDuration; 
        public int glomerularFiltrationRate; 
        public bool familialHypercholesterolemia;
        public bool acuteCoronarySyndrome;
        public bool repetiveAuteCoronaySyndrome;
        public bool coronaryArteryDisease;  
        public bool stroke;    
        public bool transientIschemicAttack; 
        public bool peripheralArteryDisease; 
        public bool atherosclerosis;
        public int percentageArteryStenosis;   


        public Patient(string genderParam, int ageParam, int systolicPresParam, 
                       double tcParam, string smokingParam)
        {
            gender = genderParam;
            age = ageParam;
            systolicPressure = systolicPresParam;
            totalCholesterol = tcParam;
            smoking = smokingParam;
        }

        /*public Patient(string diabetes, int type, int duration, int gfr, string fh, string acs, int repASC, 
                       string cad, string stroke, string tia, string pad, string As, int pas)
        {
            Console.WriteLine("Diabetes: ");
            Diabetes = diabetes;
            Diabetes = Console.ReadLine();
            if (Diabetes == "yes")
            {
                Console.WriteLine("Type: ");
                Type = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Duration years: ");
                Duration = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Glomerular Filtration Rate: ");
            GFR = Convert.Toint(Console.ReadLine());
            Console.WriteLine("Familiar HH: ");
            FH = Console.ReadLine();
            Console.WriteLine("Acute Coronary Syndrome: ");
            ACS = Console.ReadLine();
            if (ACS == "yes")
            {
                Console.WriteLine("How many yaers ago?");
                RepACS = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Coronary Artery Disease: ");
            CAD = Console.ReadLine();
            Console.WriteLine("Stroke: ");
            Stroke = Console.ReadLine();
            Console.WriteLine("Transient Ischemic Attack: ");
            TIA = Console.ReadLine();
            Console.WriteLine("Peripheral Artery Disease: ");
            PAD = Console.ReadLine();
            Console.WriteLine("Atherosclerosis: ");
            AS = Console.ReadLine();
            if (AS == "yes")
            {
                Console.WriteLine("Percentage of Stenosis: ");
                PAS = Convert.ToInt32(Console.ReadLine());
            }

        }*/

    }
}


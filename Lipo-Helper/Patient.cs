using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class Patient
    {
        public string? FirstName;  //фамилия
        public string? LastName;   //имя
        public string? Gender;     //пол
        public int Age;            //возраст 
        public int SP;             //артериальное давление 
        public double TC;          //общий холестерин
        public double LL;          //липиды низкой плотности
        public string? Smoking;    //курение (да/нет)
        public string? Diabetes;   //сахарный диабет (да/нет)
        public int Type;           //тип
        public int Duration;       //продолжительность
        public string? DTO;        //повреждение органов(да/нет)
        public int GFR;            //скорость клубочковой фильтрации
        public string? FH;         //семейная гиперхолистеринемия (да/нет)
        public string? ACS;        //острый коронарный синдром (ИМ, НС)
        public int RepACS;         //повторное ОКС
        public string? CAD;        //коронарная недостаточность
        public string? Stroke;     //инсульт
        public string? TIA;        //транзиторная ишемическая атака
        public string? PAD;        //болезнь периферических артерий
        public string? AS;         //атеросклероз
        public int PAS;            //процент стеноза артерий


        public Patient()
        {
            Console.WriteLine("First name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Gender:");
            Gender = Console.ReadLine();
            Console.WriteLine("Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TC");
            TC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("SP");
            SP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you smoking?");
            Smoking = Console.ReadLine();
            Console.WriteLine("Diabetes: ");
            Diabetes = Console.ReadLine();
            if (Diabetes == "yes")
            {
                Console.WriteLine("Type: ");
                Type = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Duration years: ");
                Duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Damage of Target Organs: ");
                DTO = Console.ReadLine();
            }

            Console.WriteLine("Glomerular Filtration Rate: ");
            GFR = Convert.ToInt32(Console.ReadLine());
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
        }
    }
}


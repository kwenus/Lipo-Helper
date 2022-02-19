using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    public class ScoreScale
    {
        struct Scale
        {
            public string Gender;
            public string Smoking;
            public int AgeMin;
            public int AgeMax;
            public int SPmin;
            public int SPmax;
            public double TCmin;
            public double TCmax;
            public int Risk;

            public Scale()
            {
                this.Gender = "female";
                this.Smoking = "no";
                this.AgeMin = 40;
                this.AgeMax = 49;
                this.SPmin = 120;
                this.SPmax = 139;
                this.TCmin = 4.0;
                this.TCmax = 4.9;
                this.Risk = 0;           
            }
        }

        static void Main(string[] args)
        {
            const int size = 400;
            Scale[] cell = new Scale[size];
            cell[0] = new ();
            cell[1] = cell[0] with { TCmin = 5.0, TCmax = 5.9 };
            cell[2] = cell[0] with { TCmin = 6.0, TCmax = 6.9 };
            cell[3] = cell[0] with { TCmin = 7.0, TCmax = 7.9 };
            cell[4] = cell[0] with { TCmin = 8.0, TCmax = 12.0 };
            cell[5] = cell[0] with { SPmin = 140, SPmax = 159 };
            cell[6] = cell[5] with { TCmin = 5.0, TCmax = 5.9 };
            cell[7] = cell[5] with { TCmin = 6.0, TCmax = 6.9 };
            cell[8] = cell[5] with { TCmin = 7.0, TCmax = 7.9 };
            cell[9] = cell[5] with { TCmin = 8.0, TCmax = 12.0 };

            Patient patient = new ();

            string firstname = patient.FirstName;
            string gender = patient.Gender;
            string smoking = patient.Smoking;
            int age = patient.Age;
            double tc = patient.TC;
            int sp = patient.SP;
            int score = patient.SCORE;


            for (int i = 0; i < size; i++)
            {
                if (gender == cell[i].Gender && smoking == cell[i].Smoking
                    && age > cell[i].AgeMin && age < cell[i].AgeMax
                    && tc > cell[i].TCmin && tc < cell[i].TCmax
                    && sp > cell[i].SPmin && sp < cell[i].SPmax)
                {
                    score = cell[i].Risk;
                    Console.WriteLine($"{patient.FirstName} your risk is {score}%");
                    break;
                }
            }
        }
    }
}

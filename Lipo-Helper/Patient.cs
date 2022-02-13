using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    internal class Patient
    {
        public string? FirstName;  //фамилия
        public string? LastName;   //имя
        public string? Sex;        //пол
        public int Age;            //возраст 
        public int SP;             //артериальное давление 
        public double OC;          //общий холестерин
        public double LL;          //липиды низкой плотности
        public string? Smoking;    //курение (да/нет)
        public int SCORE;          //индекс SCORE из калькулятора
        public struct Diabetes     //сахарный диабет (тип, продолжительность, повреждение органов (да/нет))
        {
            public int Type;
            public int Duration;
            public string? DOM;
        }
        public int GFR;            //скорость клубочковой фильтрации
        public string? FH;         //семейная гиперхолистеринемия (да/нет)
        public struct CD           //сердечно-сосудистая патология (да/нет):
        {
            public string ACS;     //острый коронарный синдром (ИМ, НС)
            public string RepACS;  //повторное ОКС в течение 2 лет
            public string CAD;     //коронарная недостаточность
            public string Stroke;  //инсульт
            public string TIA;     //транзиторная ишемичная атака
            public string PAD;     //болезнь периферических артерий
            public int AS;         //атеросклероз (процент стеноза артерий)
        }


    }
}

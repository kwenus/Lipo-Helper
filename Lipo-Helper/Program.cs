using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipo_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new("n", 0, 0, 0, 0, "n");

            List<ScoreScale> cell = new List<ScoreScale>();
            {

            }

            foreach (var item in cell)
            {
                if (item.Check(patient))
                {
                    Console.WriteLine(item.Risk);
                    break;
                }
            }
        }
    }
}

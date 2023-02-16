using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cevrenin_serhedine_qeder_mesafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the x coordinate:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the y coordinate:");
            double y =double.Parse(Console.ReadLine());
            double d=Math.Sqrt(x*x + y*y);

            if(Math.Abs(x)>1 && Math.Abs(y)>1)
            {
                double c = d - 1;
                Console.Write("Bu noqte cevrenin xaricindedir:");
                Console.Write($"c={c}");
            }
            if(Math.Abs(x)<1 && Math.Abs(y)<1)
            { 
                double c = 1 - d;
                Console.Write("Bu noqte cevrenin daxilindedir:");
                Console.Write($"c={c}");
            }
            else if(Math.Abs(x)==1 && Math.Abs(y)==1)   
            {
                Console.Write("Bu noqte cevre uzerindedir:");
                double c = 1;
                Console.Write($"c={c}");
            }
            Console.ReadKey();

        }
    }
}

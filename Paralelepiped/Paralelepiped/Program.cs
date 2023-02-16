using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a tilini daxil edin:");
            double a=double.Parse(Console.ReadLine());
            Console.Write("b tilini daxil edin:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c tilini daxil edin:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Kvadratin terefini daxil edin :");
            double d= double.Parse(Console.ReadLine()); 
            double s=Math.Pow(d,2);           //kvadratin sahesi//

            if(a*b < s || a*c < s || b*c < s)
            {
                Console.Write("Bu paralelepiped kvadrat desiyden kecir");
            }
            else
            {
                Console.Write("Bu paralelepiped kvadrat desiyden kecmir");
            }
            Console.ReadKey();  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daire_ve_kvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin sahesini daxil edin:");
            double s1=double.Parse(Console.ReadLine());
            Console.Write("Kvadratin sahesini daxil edin:");
            double s2=double.Parse(Console.ReadLine());
            double d=Math.Sqrt(s2);   //Kvadratin terefi//
            double r=Math.Sqrt(s1/Math.PI);   //dairenin radiusu//
            double r1 = d / 2;                //verilmis kvadratin daxiline cekilmis dairenin radiusu//

            if (r <= r1)
            {
                Console.Write("Bu daire verilmis kvadratin icine yerlesir");
            }
            else
            {
                Console.Write("Bu daire verilmis kvadratin icine yerlesmir");
            }
            Console.ReadKey (); 
        }
    }
}

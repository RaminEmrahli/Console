using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_ci_hedd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c =0;
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (b < a && b > c)
                {
                    k=i;
                }
                if (a > c)
                {
                    c = a;
                  
                }
            }
            Console.Write("Sira nomre:");
            Console.Write(k-1);
            Console.Write(" ve ");
            Console.Write(k);
            Console.Write(" arasinda yerlesir");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Enter x:");
            double x = double.Parse(Console.ReadLine());
            double p = 1;

            for (double i = 0; i <= n; i++)
            {
                for (double j = 1; j <= k; j++)
                {
                    p = p * (j+(x/(i+2)));

                }
            }
            Console.Write($"product={p:F1}");
            Console.ReadKey();
        }
    }
}

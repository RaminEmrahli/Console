using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace е_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            double n = double.Parse(Console.ReadLine());
            double p = 1;

            for (double i = 1; i <= n; i++)
            {
                p = p * Math.Pow((1 + (1 /i)),n);

            }
            Console.Write($"product={p:F1}");
            Console.ReadKey();
        }
    }
}

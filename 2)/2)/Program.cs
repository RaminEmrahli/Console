using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number");
            int n=int.Parse(Console.ReadLine());
            double sum1 = 0, sum = 0;
            double a =1;

            for(int k = 1; k <= n; k++)
            {
                a = a * k;
                sum1 = Math.Pow(-1, k) * (k + 1) / a;
                sum = sum + sum1;
            }
            Console.Write($"sum={sum}");
            Console.ReadKey();  
        }
    }
}

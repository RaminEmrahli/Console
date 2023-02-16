using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            double n=double.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter x:");
            double x = double.Parse(Console.ReadLine());
            double sum = 0;

            for(double i = 1; i <= n; i++)
            {
                for(double j = 1; j <=k; j++)
                {
                    sum=sum+Math.Pow(a,i)+Math.Pow(x,j);

                }
            }
            Console.Write($"sum={sum:F1}");
            Console.ReadKey(); 
        }
    }
}

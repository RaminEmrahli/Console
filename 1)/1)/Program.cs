using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int n=int.Parse(Console.ReadLine());
            double sum = 0;
            double a=1;
            for(int k =1;k <=n;k++)
            {
                a = a * k;
                sum = sum + (1 / a);
            }
            Console.Write($"sum={sum}");
            Console.ReadKey();  
        }
    }
}
